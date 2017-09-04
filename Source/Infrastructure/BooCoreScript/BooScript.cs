#region Usings

using System;
using System.Collections.Generic;
using ErrorReportCommon.Messages;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.gp;
using log4net;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Algo;
using Naro.Infrastructure.Library.DocumentHelpers;
using Naro.PartModeling;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroPipes.Actions;
using OccCode;

using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using ShapeFunctionsInterface.Interpreters;
using Naro.Infrastructure.Library.Geometry;

#endregion

namespace BooCoreScript
{
    public class BooScript
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (BooScript));
        public Document Document;
        private ActionsGraph _actionsGraph;
        private bool _autoGroup;
        public string ExecutionPath { get; set; }

        public void SetInternalData(ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;
            Document =
                _actionsGraph.InputContainer[InputNames.Document].GetData(NotificationNames.GetValue).Get<Document>();
            Document.Root.Set<ActionGraphInterpreter>().ActionsGraph = _actionsGraph;
        }

        public void Gc()
        {
            GC.Collect();
        }

        public void RegisterPlugin(string assemblyName)
        {
            new BooPluginLoader(_actionsGraph).RegisterPlugin(assemblyName, true);
        }

        private Node GetNodeById(int id)
        {
            return Document.Root.Children.ContainsKey(id) ? Document.Root.Children[id] : null;
        }

        public List<SceneSelectedEntity> GetEntitiesById(IEnumerable<int> edges)
        {
            var nodes = new List<SceneSelectedEntity>();

            foreach (var node in edges)
            {
                var subEdge = GetNodeById(node);
                //var func = subEdge.Get<FunctionInterpreter>();
                //if (func.Name != FunctionNames.SubShape) continue;
                var sceneSelectedEntity = new SceneSelectedEntity(subEdge)
                                              {
                                                  ShapeType = TopAbsShapeEnum.TopAbs_EDGE,
                                                  ShapeCount = 1
                                              };
                nodes.Add(sceneSelectedEntity);
            }

            return nodes;
        }

        public void Open(string path)
        {
            if (path != "")
                Document.LoadFromXml(path);
        }

        public void Save(string path)
        {
            SaveCommonCodes.SaveToFile(path, Document);
        }

        public void ExportToStep(string path)
        {
            SaveCommonCodes.SaveToStep(path, Document);
        }

        public void ImportFromBrep(string path)
        {
            SaveCommonCodes.LoadBrepFile(path, Document);
        }

        public void ImportFromStep(string path)
        {
            SaveCommonCodes.LoadStepFile(path, Document);
        }

        public int Line(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            var point1 = new Point3D(x1, y1, z1);
            var point2 = new Point3D(x2, y2, z2);
            Log.Info("Line drawn");
            var lineNode = TreeUtils.AddLineToNode(Document, point1, point2);
            if (_autoGroup)
            {
                MakeFace(lineNode.Node.Index);
            }
            return lineNode.Node.Index;
        }

        public int Line(int p1, int p2)
        {
            Log.Info("Line drawn");
            var lineNode = TreeUtils.AddLineToNode(Document, p1, p2);
            
            return lineNode.Node.Index;
        }

        public void MirrorPoint(int shapeId, int pointId)
        {
            TreeUtils.AddMirrorPoint(Document, shapeId, pointId);
        }

        public void MirrorLine(int shapeId, int lineId)
        {
            TreeUtils.AddMirrorLine(Document, shapeId, lineId);
        }

        public void ArrayPattern( int axis, int normalAxis, int shape, int rows, int columns, int rowDistance, int colDistance)
        {
            TreeUtils.AddArrayPatternNodes(Document, axis, normalAxis, shape, rows, columns, rowDistance, colDistance);
        }

        public void SetAutoGroup(int boolean)
        {
            _autoGroup = (boolean != 0);
        }

        public void Hide(int nodeIndex)
        {
            var node = Document.Root[nodeIndex];
            node.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.Hidden;
            var nb = new NodeBuilder(node);
            nb.ExecuteFunction();
        }

        public void Show(int nodeIndex)
        {
            var node = Document.Root[nodeIndex];
            node.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.ToBeDisplayed;
        }


        public int Extrude(int sketchId, double height)
        {
            return BuildExtrude(sketchId, height, ExtrusionTypes.ToDepth);
        }

        private int BuildExtrude(int sketchId, double height, ExtrusionTypes type)
        {
            if (!Document.Root.Children.ContainsKey(sketchId))
                return -1;
            var sketchNode = Document.Root[sketchId];
            sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode, Document);
            var extrudeBuilder = new NodeBuilder(Document, FunctionNames.Extrude);
            var sse = new SceneSelectedEntity(sketchNode);
            var nb = TreeUtils.Extrude(Document, sse, height, type);
            NodeUtils.SetSketchTransparency(Document, sketchNode, ObjectVisibility.Hidden);
            sketchNode.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.Hidden;
            return nb.Node.Index;
        }

        public int ExtrudeMidPlane(int sketchId, double height)
        {
            return BuildExtrude(sketchId, height, ExtrusionTypes.MidPlane);
        }

        public int BooleanAdd(int shape1, int shape2)
        {
            var node = TreeUtils.AddBoolean(Document, GetNodeById(shape1), GetNodeById(shape2), 1);
            return node.Index;
        }

        public int BooleanSubtract(int shape1, int shape2)
        {
            var node = TreeUtils.AddBoolean(Document, GetNodeById(shape1), GetNodeById(shape2), 0);
            return node.Index;
        }

        public int BooleanIntersect(int shape1, int shape2)
        {
            var node = TreeUtils.AddBoolean(Document, GetNodeById(shape1), GetNodeById(shape2), 2);
            return node.Index;
        }

        public int Ellipse(double x1, double y1, double z1, double x2, double y2, double z2, double x3, double y3,
                           double z3)
        {
            var point1 = new Point3D(x1, y1, z1);
            var point2 = new Point3D(x2, y2, z2);
            var point3 = new Point3D(x3, y3, z3);

            var node = TreeUtils.AddEllipseToNode(Document, point1, point2, point3);
            return node.Index;
        }

        public int Ellipse(int point1, int point2, int point3)
        {
            var node = TreeUtils.AddEllipseToNode(Document, point1, point2, point3);
            return node.Index;
        }

        public void Rectangle(int point1, int point2)
        {
            TreeUtils.AddRectangleToNode(Document, point1, point2);
        }

        public void EnterSketch(int sketchNode)
        {
            if (Document.Root.Children.ContainsKey(sketchNode))
            {
                Document.Root.Get<DocumentContextInterpreter>().ActiveSketch = sketchNode ;
            }
        }

        public int Circle(double x, double y, double z, double radius)
        {
            var node = TreeUtils.AddCircleToNode(Document, new Point3D(x,y, z), radius);
            return node.Index;
        }

        public int Circle(int point, double radius)
        {
            var node = TreeUtils.AddCircleToNode(Document, point, radius);
            return node.Index;
        }

        public int Sphere(double x, double y, double z, double radius)
        {
            var point1 = new Point3D(x, y, z);

            var node = TreeUtils.AddSphere(Document, point1, radius);
            return node.Index;
        }

        public int Box(double x, double y, double z, double x1, double y1, double z1, double x3, double y3, double z3,
                       double height)
        {
            var dir = new gpDir(x1, y1, z1);
            var axis = new gpAx1(new gpPnt(x, y, z), dir);
            var point3 = new Point3D(x3, y3, z3);

            var node = TreeUtils.AddBox(Document, axis, point3, height);
            return node.Index;
        }

        public int Cylinder(double x, double y, double z, double radius, double height, double angle)
        {
            var axis = new gpAx1(new gpPnt(x, y, z), new gpDir());

            var node = TreeUtils.AddCylinder(Document, axis, radius, height, GeomUtils.DegreesToRadians(angle));
            return node.Index;
        }

        public int Cone(double x, double y, double z, double radius1, double radius2, double height, double angle)
        {
            var axis = new gpAx1(new gpPnt(x, y, z), new gpDir());
            var node = TreeUtils.AddCone(Document, axis, radius1, radius2, height, GeomUtils.DegreesToRadians(angle));
            return node.Index;
        }

        public int Torus(double x, double y, double z, double radius1, double radius2)
        {
            var axis = new gpAx1(new gpPnt(x, y, z), new gpDir());

            var node = TreeUtils.AddTorus(Document, axis, radius1, radius2);
            return node.Index;
        }

        public int Fillet(int shapeId, int edge, double size)
        {
            var node = TreeUtils.Fillet(Document, GetNodeById(shapeId), edge, size);
            return node.Index;
        }

        public int Chamfer(int shapeId, double size)
        {
            var node = TreeUtils.Chamfer(Document, GetNodeById(shapeId), size);
            return node.Index;
        }

        public void Fillet2D(int edge1, int edge2, double size)
        {
            var edges = new List<int>() { edge1, edge2 };
            TreeUtils.Fillet2D(Document, GetEntitiesById(edges), size);
        }

        public void Chamfer2D(int edge1, int edge2, double size)
        {
            var edges = new List<int>() { edge1, edge2 };
            TreeUtils.Chamfer2D(Document, GetEntitiesById(edges), size);
        }

        public int Cut(int sketchId, double height)
        {
            if (!Document.Root.Children.ContainsKey(sketchId))
                return -1;
            var sketchNode = Document.Root[sketchId];
            sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode, Document);
            var node = TreeUtils.Cut(Document, sketchNode, height, CutTypes.ToDepth);
            NodeUtils.SetSketchTransparency(Document, sketchNode, ObjectVisibility.Hidden);
            sketchNode.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.Hidden;
            return node.Index;
        }
        public int CutThroughAll(int sketchId)
        {
            if (!Document.Root.Children.ContainsKey(sketchId))
                return -1;
            var sketchNode = Document.Root[sketchId];
            sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode, Document);
            var node = TreeUtils.Cut(Document, sketchNode, 100, CutTypes.ThroughAll);
            NodeUtils.SetSketchTransparency(Document, sketchNode, ObjectVisibility.Hidden);
            sketchNode.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.Hidden;
            return node.Index;
        }

        public int Arc(double x1, double y1, double z1, double x2, double y2, double z2, double x3, double y3, double z3)
        {
            var point1 = new Point3D(x1, y1, z1);
            var point2 = new Point3D(x2, y2, z2);
            var point3 = new Point3D(x3, y3, z3);

            var node = TreeUtils.AddArcToNode(Document, point1, point2, point3);
            return node.Index;
        }

        public int Arc(int p1, int p2, int p3)
        {
            var node = TreeUtils.AddArcToNode(Document, p1, p2, p3);
            return node.Index;
        }

        public int Sketch(double x1, double y1, double z1, double x2, double y2, double z2, double x3, double y3, double z3)
        {
            var point1 = new Point3D(x1, y1, z1);
            var point2 = new Point3D(x2, y2, z2);
            var point3 = new Point3D(x3, y3, z3);

            var node = TreeUtils.AddSketchNode(Document, point1, point2, point3);
            return node.Index;
        }

        public int SubShape(int shapeId, int face)
        {
            var node = TreeUtils.CreateSubShape(Document, GetNodeById(shapeId), face);
            return node.Index;
        }

        public int SubEdge(int shapeId, int edgeIndex)
        {
            var edge = TreeUtils.CreateSubEdge(Document, GetNodeById(shapeId), edgeIndex);
            return edge.Index;
        }

        public void ShowDouble(double dataValue)
        {
            NaroMessage.Show(dataValue.ToString());
        }

        public void ShowInteger(int dataValue)
        {
            NaroMessage.Show(dataValue.ToString());
        }

        public double Sin(double a)
        {
            return Math.Sin(a);
        }

        public double Cos(double a)
        {
            return Math.Cos(a);
        }

        public double Pi()
        {
            return Math.PI;
        }

        public int MakeFace(int node)
        {
            var result = AutoGroupLogic.TryAutoGroup(Document, GetNodeById(node));
            return result != null ? result.Index : -1;
        }

        public int GetFirstShapeContains(string name)
        {
            var pos = 0;
            foreach (var child in Document.Root.Children.Values)
            {
                var strInterpreter = child.Get<StringInterpreter>();
                if (strInterpreter != null)
                {
                    if (strInterpreter.Value.Contains(name))
                    {
                        return pos;
                    }
                }
                pos++;
            }
            return -1;
        }


        public void Dimension(double x, double y, double z, double x1, double y1, double z1)
        {
            var builder = new NodeBuilder(Document, FunctionNames.Dimension);
            builder[0].TransformedPoint3D = new Point3D(x1,y1,z1);
            builder[1].TransformedPoint3D = new Point3D(x, y, z);
            builder.ExecuteFunction();
            //return builder.Node.Index;
            //var point1 = new Point3D(x, y, z);
            //var point2 = new Point3D(x1, y1, z1);
            //var midPoint = GeomUtils.ComputeMidPoint(point1, point2);
            //midPoint.X = midPoint.X + 1;
            //var mkplane = new OCGC_MakePlane(point1.GpPnt, point2.GpPnt, midPoint.GpPnt);
            //var plane = mkplane.Value();
            //GeomUtils.BuildLengthDimension(point1.GpPnt, point2.GpPnt, plane, midPoint.GpPnt,
            //                                            OCDsgPrs_ArrowSide.DsgPrs_AS_BOTHAR, 2, 0.2);
        }

        public int Point(int sketchNode, double x, double y, double z)
        {
            var sketchCreator = new SketchCreator(Document);
            if (!Document.Root.Children.ContainsKey(sketchNode))
                return -1;
            var builder = sketchCreator.CreateBuilder(FunctionNames.Point);
            builder[0].Reference = Document.Root[sketchNode];
            builder[1].TransformedPoint3D = new Point3D(x, y, z);
            builder.ExecuteFunction();
            return builder.Node.Index;
        }

        public int Offset3D(int shapeIndex, double offsetValue)
        {
            var builder = new NodeBuilder(Document, FunctionNames.Offset3D);
            builder[0].Reference = Document.Root[shapeIndex];
            builder[1].Real = offsetValue;
            builder.ExecuteFunction();
            return builder.Node.Index;
        }

        public int PatternClone(int shapeId, int lineId, double rotations, int steps, int applyTranslate)
        {
            var builder = new NodeBuilder(Document, FunctionNames.CircularPattern);
            builder[0].Reference = Document.Root[shapeId];
            builder[1].Reference = Document.Root[lineId];
            builder[2].Real = rotations;
            builder[3].Integer = steps;
            builder[4].Integer = applyTranslate;
            builder.ExecuteFunction();
            return builder.Node.Index;
        }

        public int Pipe(int shapeId, int lineId)
        {
            var builder = new NodeBuilder(Document, FunctionNames.Pipe);
            builder[0].Reference = Document.Root[shapeId];
            builder[1].Reference = Document.Root[lineId];
            builder.ExecuteFunction();
            return builder.Node.Index;
        }

        public int Revolve(int shapeId, int lineId, double angle)
        {
            var sketchNode = Document.Root[shapeId];
            if (sketchNode.Get<FunctionInterpreter>().Name == FunctionNames.Sketch)
            {
                sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape =
                    AutoGroupLogic.RebuildSketchFace(sketchNode, Document);
            }
            var builder = new NodeBuilder(Document, FunctionNames.Revolve);
            builder[0].Reference = sketchNode;
            builder[1].Reference = Document.Root[lineId];
            builder[2].Real = angle;
            builder.ExecuteFunction();
            return builder.Node.Index;
        }

        public int HorizontalLine(double y)
        {
            var builder = new NodeBuilder(Document, FunctionNames.HorizontalLine);
            builder[0].TransformedPoint3D = new Point3D(0, y, 0);
            builder.ExecuteFunction();
            return builder.Node.Index;
        }

        public int VerticalLine(double x)
        {
            var builder = new NodeBuilder(Document, FunctionNames.VerticalLine);
            builder[0].TransformedPoint3D = new Point3D(x, 0, 0);
            builder.ExecuteFunction();
            return builder.Node.Index;
        }
    }
}