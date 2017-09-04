#region Usings

using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Qos;
using Naro.PartModeling;
using NaroCAD.SolverModule.Factory;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.TopLoc;
using NaroPipes.Actions;
using NaroSetup;
using NaroSketchAdapter.Factory;
using OccCode;
using ShapeFunctionsInterface.Interpreters;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroSketchAdapter
{
    public class SolverExtractLogic
    {
        private static bool _computeIntersections;
        private readonly ReaderWriterLockSlim _cacheLock = new ReaderWriterLockSlim();
        private readonly Document _document;
        private readonly GeometricSolver _solver;

        public SolverExtractLogic(Document document, GeometricSolver solver)
        {
            _document = document;
            _solver = solver;
        }

        private static void AddGeometry(SolverGeometricObject geometry, List<SolverGeometricObject> solverGeometry)
        {
            if (geometry != null && !geometry.IsEmpty)
                solverGeometry.Add(geometry);
        }

        private static void UpdateConfig(ActionsGraph actionGraph)
        {
            var optionsSetup = actionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);
            SolverConstraintFactory.Instance.SolverOptions = optionsSection;
            _computeIntersections = optionsSection.GetBoolValue(7);
        }

        private static List<SolverGeometricObject> BuildGeometry(Document document)
        {
            var agInterpreter = document.Root.Get<ActionGraphInterpreter>();
            var documentContextInterpreter = document.Root.Get<DocumentContextInterpreter>();

            documentContextInterpreter.ShapesGraph.Update();
            UpdateConfig(agInterpreter.ActionsGraph);
            var solverGeometry = new List<SolverGeometricObject>();
            AddOriginPoint(solverGeometry);
            foreach (var nodeId in documentContextInterpreter.ShapeManager.ShapeList.Keys)
            {
                var node = document.Root[nodeId];
                var extracter = SolverConstraintFactory.Instance.ExtractGeometry(node);
                AddGeometry(extracter, solverGeometry);
            }
            if (_computeIntersections)
            {
                BuildIntersectionsPointList(solverGeometry);
            }
            return solverGeometry;
        }

        public static void BuildIntersectionsPointList(List<SolverGeometricObject> solverGeometry)
        {
            var qosLock = QosFactory.Instance.Get(QosNames.EdgeIntersectionLock) ??
                          QosFactory.Instance.Create(QosNames.EdgeIntersectionLock, 120,
                                                     "Edge Intersection precomputation works too slow! Do you want to disable it?");
            qosLock.Begin();
            var intersectedGeometryContainer = new SolverGeometricObject(null);
            var intersections = BuildEdgeIntersectionList(solverGeometry);
            intersections = GeomUtils.SortAndCompactListPoints(intersections).ToArray();
            foreach (var intersectdPoint in intersections)
                intersectedGeometryContainer.Points.Add(new SolverDataPoint(intersectdPoint,
                                                                            GeometryType.EdgeIntersection));
            solverGeometry.Add(intersectedGeometryContainer);
            qosLock.End();
        }

        public static List<Point3D> GetIntersectionsPointList(List<SolverGeometricObject> solverGeometry)
        {
            var qosLock = QosFactory.Instance.Get(QosNames.EdgeIntersectionLock) ??
                          QosFactory.Instance.Create(QosNames.EdgeIntersectionLock, 120,
                                                     "Edge Intersection precomputation works too slow! Do you want to disable it?");
            qosLock.Begin();
            var intersections = BuildEdgeIntersectionList(solverGeometry);
            intersections = GeomUtils.SortAndCompactListPoints(intersections);
      
            qosLock.End();
            return intersections.ToList();
        }

        private static void AddOriginPoint(List<SolverGeometricObject> solverGeometry)
        {
            var originPoint = new SolverGeometricObject(null);
            originPoint.AddPoint(new SolverDataPoint(new Point3D()));
            AddGeometry(originPoint, solverGeometry);
        }


        private static IEnumerable<Point3D> BuildEdgeIntersectionList(List<SolverGeometricObject> solverGeometry)
        {
            var geometry = solverGeometry;
            var intersectionList = new List<Point3D>();
            var boxes = new SortedDictionary<int, ShapeBoundBox>();
            foreach (var geometricObject in geometry)
            {
                if (geometricObject.Parent == null) continue;
                if (geometricObject.Builder.Shape == null) continue;
                var transformedShape =
                    geometricObject.Builder.Shape.Located(new TopLocLocation(geometricObject.Builder.Transformation));
                var bndBox = ShapeUtils.ExtractBoundingBox(transformedShape);
                boxes[geometricObject.Parent.Index] = bndBox;
            }

            foreach (var geometricObject in geometry)
            {
                if (geometricObject.Edges.Count == 0) continue;
                if (geometricObject.Edges.Count > 20) continue;
                if (geometricObject.Parent == null) continue;
                if (!boxes.ContainsKey(geometricObject.Parent.Index)) continue;
                foreach (var destinationObject in geometry)
                {
                    if (destinationObject.Parent == null) continue;
                    if (destinationObject.Edges.Count == 0) continue;
                    if (geometricObject.Edges.Count == 1 || destinationObject.Edges.Count == 1) continue;
                    if (destinationObject.Edges.Count > 20) continue;
                    if (geometricObject.Parent.Index == destinationObject.Parent.Index) continue;

                    if (!boxes.ContainsKey(destinationObject.Parent.Index)) continue;
                    var sourceBox = boxes[geometricObject.Parent.Index];
                    var destBox = boxes[destinationObject.Parent.Index];
                    if (sourceBox == null || destBox == null) continue;
                    if (sourceBox.IsOut(destBox)) continue;
                    BuildEdgeIntersections(geometricObject, destinationObject, intersectionList);
                }
            }
            foreach (var geometricObject in geometry)
            {
                if (geometricObject.Edges.Count == 0) continue;
                foreach (var destinationObject in geometry)
                {
                    if (destinationObject.Edges.Count == 0) continue;
                    if (destinationObject.Builder.Node.Index <= geometricObject.Builder.Node.Index) continue;
                    if (geometricObject.Edges.Count == 1 || destinationObject.Edges.Count == 1)
                        BuildEdgeIntersections(geometricObject, destinationObject, intersectionList);
                }
            }
            return intersectionList;
        }

        private static void BuildEdgeIntersections(SolverGeometricObject geometricObject,
                                                   SolverGeometricObject destinationObject,
                                                   List<Point3D> intersectionList)
        {
            foreach (var edge in geometricObject.Edges)
            {
                var edgeIntersector = edge.Edge;
                foreach (var destinationEdge in destinationObject.Edges)
                {
                    var edgeToIntersect = destinationEdge.Edge;
                    if (edgeIntersector.IsSame(edgeToIntersect)) continue;

                    var intersectionPoints = GeomUtils.IntersectionPoints(edgeIntersector, edgeToIntersect);
                    intersectionList.AddRange(intersectionPoints);
                }
            }
        }

        public void ComputeSolverGeometry()
        {
            try
            {
                GeometryComputation(this);
            }
            catch (Exception)
            {
               
            }
            
            //new Thread(GeometryComputation).Start(this);
        }

        private static void GeometryComputation(object state)
        {
            var solverExtractLogic = (SolverExtractLogic) state;
            var geometry = BuildGeometry(solverExtractLogic._document);
            solverExtractLogic._cacheLock.EnterWriteLock();
            solverExtractLogic._solver.Geometry = geometry;
            solverExtractLogic._solver.LastGeometry = geometry;
            solverExtractLogic._cacheLock.ExitWriteLock();
        }
    }
}