#region Usings

using System.Collections.Generic;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.BRepAdaptor;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.TopoDS;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroCAD.SolverModule.Helpers
{
    public static class NodeHelper
    {
        /// <summary>
        ///   Adds to a solver description object a vertex
        /// </summary>
        /// <param name = "solverObject"></param>
        /// <param name = "point"></param>
        /// <param name = "type"></param>
        /// <param name = "pointIndex"></param>
        private static void BuildSolverVertex(SolverGeometricObject solverObject, Point3D point, GeometryType type,
                                              int pointIndex)
        {
            AddVertexToSolver(solverObject, point, type, pointIndex);
        }

        private static void AddVertexToSolver(SolverGeometricObject solverObject, Point3D point, GeometryType type,
                                              int pointIndex)
        {
            solverObject.Points.Add(new SolverDataPoint(point, type));
        }

        private static void BuildMidPointVertex(SolverGeometricObject solverObject, int edgeIndex, TopoDSEdge edge)
        {
            Point3D? first, last;
            GeomUtils.EdgeRange(edge, out first, out last);
            if (first == null || last == null) return;
            var firstPoint = (Point3D) first;
            var lastPoint = (Point3D) last;
            var midPoint = new Point3D((firstPoint.X + lastPoint.X)/2,
                                       (firstPoint.Y + lastPoint.Y)/2,
                                       (firstPoint.Z + lastPoint.Z)/2);
            solverObject.Points.Add(new SolverDataPoint(midPoint) {GeometryType = GeometryType.MidPoint});
        }

        /// <summary>
        ///   Builds the solver info (magic points and planes) receiving as parameter a shape.
        /// </summary>
        /// <param name = "solverObject"></param>
        /// <param name = "shape"></param>
        /// <param name = "parallelPrecision"></param>
        /// <param name = "computeParallelism"></param>
        public static void BuildSolverInfo(SolverGeometricObject solverObject, Node shape,
                                           double parallelPrecision, bool computeParallelism)
        {
            var solidShape = ShapeUtils.ExtractShape(solverObject.Parent);
            // Build a list with the magic points made by the vertexes
            BuildPointList(shape, solverObject);
            var functionName = shape.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name;
            if (functionName == FunctionNames.LineTwoPoints || functionName == FunctionNames.Arc ||
                functionName == FunctionNames.Arc3P || functionName == FunctionNames.Circle ||
                functionName == FunctionNames.Ellipse)
            {
                // Build a list with the edges
                BuildEdgeList(solidShape, solverObject);
            }
            // Build a list with the magic points made by the faces/surfaces
            BuildFaceList(solidShape, solverObject);
          
            // Build a list with parallel axis
            if (!computeParallelism) return;
            if(NodeBuilderUtils.NodeIsOnSketch(new NodeBuilder(shape)))
                BuildParallelAxisList(solidShape, solverObject, parallelPrecision);
        }

        private static void BuildPointList(Node shape, SolverGeometricObject solverObject)
        {
            if (shape.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.Point)
            {
                var point = new NodeBuilder(shape).Dependency[1].TransformedPoint3D;
                solverObject.Points.Add(new SolverDataPoint(point, GeometryType.EndPoint));
                return;
            }
            if (shape.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.LineTwoPoints)
            {
                var point = new NodeBuilder(shape).Dependency[0].RefTransformedPoint3D;
                solverObject.Points.Add(new SolverDataPoint(point, GeometryType.EndPoint));
                point = new NodeBuilder(shape).Dependency[1].RefTransformedPoint3D;
                solverObject.Points.Add(new SolverDataPoint(point, GeometryType.EndPoint));
                return;
            }
            if (shape.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.Circle)
            {
                var point = new NodeBuilder(shape).Dependency[0].RefTransformedPoint3D;
                solverObject.Points.Add(new SolverDataPoint(point, GeometryType.EndPoint));
               return;
            }
            if (shape.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.Arc ||
                shape.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.Arc3P)
            {
                var point = new NodeBuilder(shape).Dependency[0].RefTransformedPoint3D;
                solverObject.Points.Add(new SolverDataPoint(point, GeometryType.EndPoint));
                point = new NodeBuilder(shape).Dependency[1].RefTransformedPoint3D;
                solverObject.Points.Add(new SolverDataPoint(point, GeometryType.EndPoint));
                point = new NodeBuilder(shape).Dependency[2].RefTransformedPoint3D;
                solverObject.Points.Add(new SolverDataPoint(point, GeometryType.EndPoint));
            }
            if (shape.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.Extrude ||
                shape.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.Cut)
            {
                var points = GeomUtils.ExtractPoints(new NodeBuilder(shape).Shape);
                foreach(var point in points)
                    solverObject.Points.Add(new SolverDataPoint(point, GeometryType.EndPoint));
            }

        }

        private static void BuildFaceList(TopoDSShape solidShape, SolverGeometricObject solverObject)
        {
            var listOfFaces = GeomUtils.ExtractFaces(solidShape);
            if (listOfFaces.Count <= 0) return;
            foreach (var face in listOfFaces)
            {
                var surf = BRepTool.Surface(face);
                solverObject.Surfaces.Add(new SolverSurface(surf, GeometryType.Face));

                // Check if surface is planar
                var aFaceElementAdaptor = new BRepAdaptorSurface(face, true);
                var surfaceType = aFaceElementAdaptor.GetType;
                if (surfaceType != GeomAbsSurfaceType.GeomAbs_Plane)
                {
                    continue;
                }
                GeomPlane pl = surf.Convert<GeomPlane>();
                solverObject.Planes.Add(new SolverPlane(pl.Pln, GeometryType.Plane, solverObject.Parent));
            }
        }

        private static void BuildPointList(TopoDSShape solidShape, SolverGeometricObject solverObject)
        {
            var listOfVertexes = GeomUtils.ExtractPoints(solidShape);
            if (listOfVertexes.Count <= 0) return;
            var index = 1;
            foreach (var pnt in listOfVertexes)
                BuildSolverVertex(solverObject, pnt, GeometryType.EndPoint, index++);
        }

        private static void BuildEdgeList(TopoDSShape solidShape, SolverGeometricObject solverObject)
        {
            var listOfEdges = GeomUtils.ExtractEdges(solidShape);
            if (listOfEdges.Count <= 0) return;
            var edgeIndex = 1;
            foreach (var edge in listOfEdges)
            {
                solverObject.Edges.Add(new SolverEdge(edge, GeometryType.Edge, solverObject.Parent));
                BuildMidPointVertex(solverObject, edgeIndex, edge);
                edgeIndex++;
            }
        }

      

        private static void BuildParallelAxisList(TopoDSShape solidShape, SolverGeometricObject solverObject,
                                                  double angle)
        {
            var listOfEdges = GeomUtils.ExtractEdges(solidShape);
            if (listOfEdges.Count <= 0) return;
            var extractedAxises = new List<SolverParallelAxis>();
            foreach (var edge in listOfEdges)
            {
                var curve = new BRepAdaptorCurve(TopoDS.Edge(edge));
                if (curve.GetType != GeomAbsCurveType.GeomAbs_Line)
                    continue;
                var buildAxis = new SolverParallelAxis(edge);
                var isParallelWithPreviousAxes = false;
                foreach (var axis in extractedAxises)
                {
                    if (!axis.IsParallel(buildAxis.Vector, angle)) continue;
                    isParallelWithPreviousAxes = true;
                    break;
                }
                if (!isParallelWithPreviousAxes)
                    extractedAxises.Add(buildAxis);
            }
            foreach (var extractedAxis in extractedAxises)
                solverObject.ParallelAxis.Add(extractedAxis);
        }
    }
}