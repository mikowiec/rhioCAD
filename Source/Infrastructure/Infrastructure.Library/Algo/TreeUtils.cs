#region Usings

using System;
using System.Collections.Generic;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using OccCode;

using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using Naro.Infrastructure.Interface.GeomHelpers;
using ShapeFunctionsInterface.Interpreters;
using Naro.PartModeling;
using System.Data;

#endregion

namespace Naro.Infrastructure.Library.Algo
{
    public static class TreeUtils
    {
        public static Node BuildSubShape(Document document, Node referenceShape, TopAbsShapeEnum shapeType,
                                         int faceNumber, bool visible)
        {
            // Build subshape targeting a parent node
            var builder = new NodeBuilder(document, FunctionNames.SubShape, DisplayedShapeNames.Face);
            var node = builder.Node;
            // Attach the shape containing the face on which the Extrusion is applied
            builder[0].Reference = referenceShape;
            // Save the number of the face on which the extrusion is applied
            builder[1].Integer = faceNumber;
            builder[2].Integer = (int) shapeType;

            if (!builder.ExecuteFunction())
            {
                return null;
            }

            builder.Node.Set<TreeViewVisibilityInterpreter>();
            // Attach an integer attribute to L to memorize it's not displayed
            if (!visible)
                NodeUtils.Hide(builder.Node);
            else
                NodeUtils.Show(builder.Node);
            return node;
        }

        public static void AddRectangleToNode(Document document, int point1, int point2)
        {
            if (!document.Root.Children.ContainsKey(point1) || !document.Root.Children.ContainsKey(point2))
                return;
            var sketchNode = AutoGroupLogic.FindSketchNode(document.Root[point1]);
            var axis = new gpAx2();
            axis.Axis = (sketchNode.Children[1].Get<Axis3DInterpreter>().Axis.GpAxis);
            var pointLinker = new SketchCreator(document).PointLinker;
            var point3Ds = new List<Point3D>();
            var nb1 = new NodeBuilder(document.Root[point1]);
            var nb2 = new NodeBuilder(document.Root[point2]);
            var _firstPoint = nb1.Dependency[1].TransformedPoint3D;
            var _secondPoint = nb2.Dependency[1].TransformedPoint3D;
            var firstPoint2D = _firstPoint.ToPoint2D(axis);
            var secondPoint2D = _secondPoint.ToPoint2D(axis);
            var x1 = firstPoint2D.X;
            var y1 = firstPoint2D.Y;
            var x2 = secondPoint2D.X;
            var y2 = secondPoint2D.Y;

            point3Ds.Add(GeomUtils.Point2DTo3D(axis, x1, y1));
            point3Ds.Add(GeomUtils.Point2DTo3D(axis, x2, y1));
            point3Ds.Add(GeomUtils.Point2DTo3D(axis, x2, y2));
            point3Ds.Add(GeomUtils.Point2DTo3D(axis, x1, y2));
            document.Root.Remove(nb1.Node.Index);
            document.Root.Remove(nb2.Node.Index);
            BuildLine(document, pointLinker, point3Ds[0], point3Ds[1]);
            BuildLine(document, pointLinker, point3Ds[1], point3Ds[2]);
            BuildLine(document, pointLinker, point3Ds[2], point3Ds[3]);
            BuildLine(document, pointLinker, point3Ds[3], point3Ds[0]);
        }

        private static NodeBuilder BuildLine(Document document, DocumentPointLinker documentPointLinker,
                                            Point3D firstCoordinate, Point3D secondCoordinate)
        {
            var firstPoint = documentPointLinker.GetPoint(firstCoordinate);
            var secondPoint = documentPointLinker.GetPoint(secondCoordinate);
            var line = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            line[0].Reference = firstPoint.Node;
            line[1].Reference = secondPoint.Node;
            line.ExecuteFunction();
            return line;
        }

        public static NodeBuilder AddLineToNode(Document document, int point1, int point2)
        {
            var sketchCreator = new SketchCreator(document);
            if (!document.Root.Children.ContainsKey(point1) || !document.Root.Children.ContainsKey(point2))
                return null;
            var firstPoint = document.Root[point1];
            var secondPoint = document.Root[point2];

            var builder = sketchCreator.CreateBuilder(FunctionNames.LineTwoPoints);

            builder[0].Reference = firstPoint;
            builder[1].Reference = secondPoint;
            builder.ExecuteFunction();
            return builder;
        }

        public static NodeBuilder AddLineToNode(Document document, Point3D point1, Point3D point2, ObjectVisibility visibility = ObjectVisibility.ToBeDisplayed)
        {
            var sketchCreator = new SketchCreator(document);

            var firstPointBuilder = sketchCreator.GetPoint(point1);
            var secondPointBuilder = sketchCreator.GetPoint(point2);
            firstPointBuilder.Visibility = visibility;
            secondPointBuilder.Visibility = visibility;
            var firstPoint = firstPointBuilder.Node;
            var secondPoint = secondPointBuilder.Node;

            var builder = sketchCreator.CreateBuilder(FunctionNames.LineTwoPoints);

            builder[0].Reference = firstPoint;
            builder[1].Reference = secondPoint;
            builder.ExecuteFunction();
            return builder;
        }

        public static Node AddCircleToNode(Document document, Point3D coordinate, double radius)
        {
            var sketchCreator = new SketchCreator(document);
            var builder = new NodeBuilder(document,FunctionNames.Circle);

            builder[0].Reference = sketchCreator.GetPoint(coordinate).Node;
            builder[1].Real = radius;

            return !builder.ExecuteFunction() ? null : builder.Node;
        }

        public static void AddMirrorPoint(Document document, int shapeId, int pointId)
        {
            var builder = new NodeBuilder(document, FunctionNames.MirrorPoint);

            builder[0].Reference = document.Root[shapeId];
            builder[1].Reference = document.Root[pointId];
            builder.ExecuteFunction();
            document.Root.Remove(builder.Node.Index);
        }

        public static void AddMirrorLine(Document document, int shapeId, int lineId)
        {
            var builder = new NodeBuilder(document, FunctionNames.MirrorLine);

            builder[0].Reference = document.Root[shapeId];
            builder[1].Reference = document.Root[lineId];
            builder.ExecuteFunction();
            document.Root.Remove(builder.Node.Index);
        }

        public static void AddArrayPatternNodes(Document document, int axis, int columnAxis, int shape, int rows, int columns, int rowDistance, int colDistance)
        {
            var indexColomns = 1;
            var node = document.Root[shape];
            var axisNode = document.Root[axis];
            var _axis = GeomUtils.ExtractAxis(new NodeBuilder(axisNode).Shape);
            var columnAxisNode = document.Root[columnAxis];
            var _ColumnAxis = GeomUtils.ExtractAxis(new NodeBuilder(columnAxisNode).Shape);
            var reverseRows = 1;
            var reverseColumns = 1;
            for (var indexRows = 0; indexRows < rows; indexRows++)
            {
                for (; indexColomns < columns; indexColomns++)
                {
                    var sourceCopyBuilder = new NodeBuilder(Document.CopyPaste(node));
                    sourceCopyBuilder.ShapeName = "Patterned" +
                                                  sourceCopyBuilder.ShapeName.Substring(0, sourceCopyBuilder.ShapeName.
                                                                                            Length - 1) +
                                                  (indexRows * columns + indexColomns);
                    sourceCopyBuilder.Node.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.ToBeDisplayed;
                    var transformInterpreter = sourceCopyBuilder.Node.Get<TransformationInterpreter>();
                    transformInterpreter.ApplyGeneralArrayPattern(_axis, _ColumnAxis, indexRows * rowDistance * reverseRows,
                                                                 indexColomns * colDistance * reverseColumns);
                }
                indexColomns = 0;
            }

            var slectedNode = node;
            var sketchNode = AutoGroupLogic.FindSketchNode(slectedNode);
            NodeUtils.SetSketchTransparency(document, sketchNode, 0);

            var face = AutoGroupLogic.RebuildSketchFace(sketchNode, document);
            sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = face;
            sketchNode.Set<DrawingAttributesInterpreter>().Transparency = 1;
            sketchNode.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.Hidden;
            NodeUtils.SetSketchTransparency(document, sketchNode, 0);
        }

        public static Node AddCircleToNode(Document document, int point, double radius)
        {
            if (!document.Root.Children.ContainsKey(point))
                return null;

            var builder = new NodeBuilder(document,FunctionNames.Circle);

            builder[0].Reference = document.Root[point];
            builder[1].Real = radius;
            return !builder.ExecuteFunction() ? null : builder.Node;
        }

        public static Node AddArcToNode(Document document, Point3D point1, Point3D point2, Point3D point3)
        {
            var sketchCreator = new SketchCreator(document);
            var builder = new NodeBuilder(document, FunctionNames.Arc);

            builder[0].Reference = sketchCreator.GetPoint(point1).Node;
            builder[1].Reference = sketchCreator.GetPoint(point2).Node;
            builder[2].Reference = sketchCreator.GetPoint(point3).Node;

            return !builder.ExecuteFunction() ? null : builder.Node;
        }

        public static Node AddArcToNode(Document document, int point1, int point2, int point3)
        {
            if (!document.Root.Children.ContainsKey(point1) || !document.Root.Children.ContainsKey(point2)
                ||!document.Root.Children.ContainsKey(point3))
                return null;
            var builder = new NodeBuilder(document, FunctionNames.Arc);

            builder[0].Reference = document.Root[point1];
            builder[1].Reference = document.Root[point2];
            builder[2].Reference = document.Root[point3];

            return !builder.ExecuteFunction() ? null : builder.Node;
        }

        public static Node AddEllipseToNode(Document document, int point1, int point2, int point3)
        {
            if (!document.Root.Children.ContainsKey(point1) || !document.Root.Children.ContainsKey(point2)
                || !document.Root.Children.ContainsKey(point3))
                return null;
            var builder = new NodeBuilder(document, FunctionNames.Ellipse);

            builder[0].Reference = document.Root[point1];
            builder[1].Reference = document.Root[point2];
            builder[2].Reference = document.Root[point3];

            return !builder.ExecuteFunction() ? null : builder.Node;
        }

        public static NodeBuilder ExtrudeToDepth(Document document, int sketchId, double extrusionHeight)
        {
            if (!document.Root.Children.ContainsKey(sketchId))
                return null;
            var sketchNode = document.Root[sketchId];
            sketchNode.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(sketchNode, document);
            var extrudeBuilder = new NodeBuilder(document, FunctionNames.Extrude);
            extrudeBuilder[0].Reference = sketchNode;
            extrudeBuilder[1].Integer = 0;
            extrudeBuilder[2].Real = extrusionHeight;
            extrudeBuilder.ExecuteFunction();
            NodeUtils.SetSketchTransparency(document, sketchNode, ObjectVisibility.Hidden);
            sketchNode.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.Hidden;
            return extrudeBuilder;
        }

        public static Node AddSketchNode(Document document, Point3D point1, Point3D point2, Point3D point3)
        {
            //var sketchCreator = new SketchCreator(document);
            //var currentSketch = sketchCreator.CurrentSketch;
            var sketchNodeBuilder = new NodeBuilder(document,FunctionNames.Sketch);
            var firstvector = new gpDir(point2.GpPnt.X - point1.GpPnt.X, point2.GpPnt.Y - point1.GpPnt.Y, point2.GpPnt.Z - point1.GpPnt.Z);
            var secondvector = new gpDir(point3.GpPnt.X - point1.GpPnt.X, point3.GpPnt.Y - point1.GpPnt.Y, point3.GpPnt.Z - point1.GpPnt.Z);
            var normal = firstvector.Crossed(secondvector);
            var _normalOnPlane = new gpAx1(point1.GpPnt, normal);
            var sketchAx2 = new gpAx2();
            sketchAx2.Axis = (_normalOnPlane);
            sketchNodeBuilder[0].TransformedAxis3D = _normalOnPlane;

            return !sketchNodeBuilder.ExecuteFunction() ? null : sketchNodeBuilder.Node;
        }

        public static Node AddEllipseToNode(Document document, Point3D center, Point3D point2, Point3D point3)
        {
            var sketchCreator = new SketchCreator(document);
            var builder = sketchCreator.CreateBuilder(FunctionNames.Ellipse);

            builder[0].Reference = sketchCreator.GetPoint(center).Node;
            builder[1].Reference = sketchCreator.GetPoint(point2).Node;
            builder[2].Reference = sketchCreator.GetPoint(point3).Node;
            
            return !builder.ExecuteFunction() ? null : builder.Node;
        }

        public static Node CreateSubShape(Document document, Node referedShape, int face)
        {
            var builder = new NodeBuilder(document, FunctionNames.SubShape);

            builder[0].Reference = referedShape;
            builder[1].Integer = face;
            builder[2].Integer = (int) TopAbsShapeEnum.TopAbs_FACE;

            return !builder.ExecuteFunction() ? null : builder.Node;
        }

        public static Node CreateSubEdge(Document document, Node referedShape, int edgeIndex)
        {
            var builder = new NodeBuilder(document, FunctionNames.SubShape);

            builder[0].Reference = referedShape;
            builder[1].Integer = edgeIndex;
            builder[2].Integer = 6;

            return !builder.ExecuteFunction() ? null : builder.Node;
        }


        /// <summary>
        ///   Applies an Extrusion feature on a shape.
        /// </summary>
        /// <param name = "document">Document that holds data tree</param>
        /// <param name = "shape">Shape on which the extrusion is applied</param>
        /// <param name = "extrusionHeight">Extrusion height</param>
        /// <param name = "extrusionType">Extrusion type</param>
        public static NodeBuilder Extrude(Document document, SceneSelectedEntity shape, double extrusionHeight,
                                          ExtrusionTypes extrusionType)
        {
            var builder = new NodeBuilder(document, FunctionNames.Extrude, DisplayedShapeNames.Extrude);

            // Attach the shape on which the Extrusion is applied as the first child label
            builder[0].ReferenceData = shape;
            // Add the Extrusion Type as a third child label
            builder[1].Integer = (int) extrusionType;
            // Add the extrusion height as a second child label
            builder[2].Real = extrusionHeight;
            builder.ExecuteFunction();
            return builder;
        }

        /// <summary>
        ///   Applies a Cut feature with a shape
        /// </summary>
        /// <param name = "document">Document that holds data tree</param>
        /// <param name="shape"></param>
        /// <param name="depth"></param>
        /// <param name="cutType"></param>
        public static Node Cut(Document document, Node sketchNode, double depth, CutTypes cutType)
        {
            var builder = new NodeBuilder(document, FunctionNames.Cut);
            builder[0].Reference = sketchNode;
            builder[1].Real = depth;
            builder[2].Integer = cutType == CutTypes.ToDepth ? 0 : 1;
            builder.ExecuteFunction();

            return builder.Node;
        }

        public static Node Fillet(Document document, Node shape, int edge, double radius)
        {
            var builder = new NodeBuilder(document, FunctionNames.Fillet, DisplayedShapeNames.Fillet);

            // Attach the shape to apply fillet on
            builder[0].Reference = shape;
            //is for all edges
            builder[1].Integer = edge;
            // Add the Fillet radius as a third 
            builder[2].Real = radius;
            //is fillet (not chamfer)
            builder[3].Integer = 0;

            return !builder.ExecuteFunction() ? null : builder.Node;
        }

        public static Node Chamfer(Document document, Node shape, double radius)
        {
            var builder = new NodeBuilder(document, FunctionNames.Fillet, DisplayedShapeNames.Fillet);

            // Attach the shape to apply fillet on
            builder[0].Reference = shape;
            //is for all edges
            builder[1].Integer = 0;
            // Add the Chamfer radius as a third 
            builder[2].Real = radius;
            builder[3].Integer = 1;

            return !builder.ExecuteFunction() ? null : builder.Node;
        }


        public static void Fillet2D(Document document, List<SceneSelectedEntity> entities, double radius)
        {
            var previewDocument = new Document();
            var interpreter = previewDocument.Root.Set<DocumentContextInterpreter>();
            var contextInterpreter = document.Root.Get<DocumentContextInterpreter>();
            interpreter.Context = contextInterpreter.Context;
            previewDocument.Root.Set<ActionGraphInterpreter>().ActionsGraph = document.Root.Get<ActionGraphInterpreter>().ActionsGraph;
            interpreter.Document = previewDocument;
            previewDocument.Transact();
            NodeBuilderUtils.BuildFillet(entities[0], entities[1], previewDocument, document, radius);
            previewDocument.Revert();
        }

        public static void Chamfer2D(Document document, List<SceneSelectedEntity> entities, double radius)
        {
            var previewDocument = new Document();
            var interpreter = previewDocument.Root.Set<DocumentContextInterpreter>();
            var contextInterpreter = document.Root.Get<DocumentContextInterpreter>();
            interpreter.Context = contextInterpreter.Context;
            previewDocument.Root.Set<ActionGraphInterpreter>().ActionsGraph = document.Root.Get<ActionGraphInterpreter>().ActionsGraph;
            interpreter.Document = previewDocument;
            previewDocument.Transact();
            NodeBuilderUtils.BuildChamfer(entities[0], entities[1], previewDocument, document, radius);
            previewDocument.Revert();
        }

        public static Node AddSphere(Document document, Point3D center, double radius)
        {
            var builder = new NodeBuilder(document, FunctionNames.Sphere, DisplayedShapeNames.Sphere);
            var node = builder.Node;

            // Sphere center and radius
            builder[0].TransformedPoint3D = new Point3D(center.GpPnt);
            builder[1].Real = radius;

            return !builder.ExecuteFunction() ? null : node;
        }

        public static Node AddBox(Document document, gpAx1 axis, Point3D secondPoint, double height)
        {
            var builder = new NodeBuilder(document, FunctionNames.Box);

            return AddBox(builder, axis, secondPoint, height);
        }

        private static Node AddBox(NodeBuilder builder, gpAx1 axis, Point3D secondPoint, double height)
        {
            builder[0].Axis3D = new Axis(axis);
            builder[1].TransformedPoint3D = secondPoint;
            builder[2].Real = height;

            return !builder.ExecuteFunction() ? null : builder.Node;
        }

        public static Node AddBoolean(Document document, Node shape1, Node shape2, int operation)
        {
            var builder = new NodeBuilder(document, FunctionNames.Boolean);
            var node = builder.Node;

            builder[0].Reference = shape1;
            builder[1].Reference = shape2;
            builder[2].Integer = operation;

            return !builder.ExecuteFunction() ? null : node;
        }

        public static Node AddCylinder(Document document, gpAx1 centerAxis, double radius, double height,
                                       double angle)
        {
            var builder = new NodeBuilder(document, FunctionNames.Cylinder);
            var node = builder.Node;

            var trsf = GeomUtils.BuildTranslation(new Point3D(centerAxis.Location), new Point3D(0, 0, 0));
            var axis = new gpAx1(centerAxis.Location, centerAxis.Direction);
            axis.Transform(trsf);

            builder[0].Axis3D = new Axis(axis);
            builder[1].Real = radius;
            builder[2].Real = height;
            builder[3].Real = angle;

            node.Set<TransformationInterpreter>().Translate = centerAxis.Location;

            return !builder.ExecuteFunction() ? null : node;
        }

        public static Node AddCone(Document document, gpAx1 centerAxis, double radius1, double radius2, double height,
                                   double angle)
        {
            var builder = new NodeBuilder(document, FunctionNames.Cone);
            var node = builder.Node;
            var trsf = GeomUtils.BuildTranslation(new Point3D(centerAxis.Location), new Point3D(0, 0, 0));
            var axis = new gpAx1(centerAxis.Location, centerAxis.Direction);
            axis.Transform(trsf);

            builder[0].Axis3D = new Axis(axis);
            builder[1].Real = radius1;
            builder[2].Real = radius2;
            builder[3].Real = height;
            builder[4].Real = angle;

            node.Set<TransformationInterpreter>().Translate = centerAxis.Location;

            builder.ExecuteFunction();
            return node;
        }

        public static Node AddTorus(Document document, gpAx1 centerAxis, double radius1, double radius2)
        {
            var builder = new NodeBuilder(document, FunctionNames.Torus, FunctionNames.Torus);

            builder[0].Axis3D = new Axis(centerAxis);
            builder[1].Real = radius1;
            builder[2].Real = radius2;

            return !builder.ExecuteFunction() ? null : builder.Node;
        }

        public static FunctionDependency GetFunctionDependency(Node node)
        {
            var function = node.Get<FunctionInterpreter>();
            return function == null ? null : function.Dependency;
        }

        /// <summary>
        ///   Calculates the computer radiuses knowing the center position and two points located on the two axis
        /// </summary>
        public static bool ComputeEllipseRadiuses(Point3D center, Point3D secondPoint, Point3D thirdPoint,
                                                  out double minorRadius, out double majorRadius,
                                                  out bool reversed, ref gpDir dirX, ref gpDir dirY)
        {
            // Calculate the major radius
            majorRadius = center.GpPnt.Distance(secondPoint.GpPnt);
            // Calculate also the axis/direction of the major radus
            var vecX = new gpVec(center.GpPnt, secondPoint.GpPnt);

            dirX = new gpDir(vecX);
            var line = new gpLin(center.GpPnt, dirX);

            // Calculate the minor radius
            minorRadius = line.Distance(thirdPoint.GpPnt);
            reversed = false;
            if (minorRadius < Precision.Confusion || majorRadius < Precision.Confusion)
            {
                return false;
            }
            // Calculate also the axis/direction of the major radus
            var vecY = new gpVec(center.GpPnt, thirdPoint.GpPnt);
            // We want the direction to be perpendicular on the direction of the major radius
            var vecZ = vecX.Crossed(vecY);
            vecY = vecX.Crossed(vecZ);
            dirY = new gpDir(vecY);

            // Major radius must be bigger than minor radius

            if (minorRadius > majorRadius)
            {
                var aux = majorRadius;
                majorRadius = minorRadius;
                minorRadius = aux;
                reversed = true;
            }
            return true;
        }

        /// <summary>
        ///   Build a vector from the two pints, scale the vector with the desired value
        ///   and calculate a transformation applied on the first point to generate where
        ///   the second point should be.
        /// </summary>
        public static Point3D ScaleSegment(Point3D point1, Point3D point2, double scale)
        {
            var vector = new gpVec(point1.GpPnt, point2.GpPnt);
            vector.Scale(scale);
            var transformation = new gpTrsf();
            transformation.SetTranslation(vector);

            // Apply the transformation on the vertex
            return new Point3D(point1.GpPnt.Transformed(transformation));
        }

        public static double RectangleGetWidth(Node rectangleNode)
        {
            var builder = new NodeBuilder(rectangleNode);
            return builder[1].TransformedPoint3D.Distance(builder[2].TransformedPoint3D);
        }

        public static void RectangleSetWidth(Node node, double width)
        {
            if (width < Precision.Confusion)
                return;
            ParalelogramSetWidthPoints(node, width);
        }

        public static void ParalelogramSetWidthPoints(Node node, double width)
        {
            if (width < Precision.Confusion)
                return;
            var builder = new NodeBuilder(node);
            var initialWidth = builder[1].TransformedPoint3D.Distance(builder[2].TransformedPoint3D);
            var widthToAdd = width - initialWidth;
            var widthDirection = new gpVec(builder[1].TransformedPoint3D.GpPnt, builder[2].TransformedPoint3D.GpPnt);
            widthDirection.Normalize();
            widthDirection.Multiply(widthToAdd);
            builder[2].TransformedPoint3D = new Point3D(builder[2].TransformedPoint3D.GpPnt.Translated(widthDirection));
        }

        public static double GetWidth(NodeBuilder builder)
        {
            var dependency = builder;
            var secondPoint = new gpPnt();
            var fourthPoint = new gpPnt();
            GeomUtils.CalculateRectangleVertexes(dependency[0].Axis3D.GpAxis.Location, dependency[1].TransformedPoint3D.GpPnt,
                                                 dependency[0].Axis3D.GpAxis.Direction, ref secondPoint,
                                                 ref fourthPoint);
            return dependency[1].TransformedPoint3D.GpPnt.Distance(secondPoint);
        }

        public static void SetWidth(Node node, double width)
        {
            if (width < Precision.Confusion)
                return;
            var builder = new NodeBuilder(node);
            // Calculate the percentage used to scale the width
            var scale = width/GetWidth(builder);
            if (Math.Abs(scale - 1) < Precision.Confusion)
                return;

            // Built two points with the coordinates of the origin vertex and the coordinates of the vertex to be scaled
            var dependency = builder;
            var secondPoint = new gpPnt();
            var fourthPoint = new gpPnt();
            GeomUtils.CalculateRectangleVertexes(dependency[0].TransformedAxis3D.Location,
                                                 dependency[1].TransformedPoint3D.GpPnt,
                                                 dependency[0].TransformedAxis3D.Direction, ref secondPoint,
                                                 ref fourthPoint);
            var point = new Point3D(secondPoint);
            var pointTrs = dependency[1].TransformedPoint3D;

            var result = ScaleSegment(point, pointTrs, scale);

            dependency[1].TransformedPoint3D = result;
        }

        public static double GetHeight(NodeBuilder builder)
        {
            var dependency = builder;
            var secondPoint = new gpPnt();
            var fourthPoint = new gpPnt();
            GeomUtils.CalculateRectangleVertexes(dependency[0].TransformedAxis3D.Location,
                                                 dependency[1].TransformedPoint3D.GpPnt,
                                                 dependency[0].TransformedAxis3D.Direction, ref secondPoint,
                                                 ref fourthPoint);
            return dependency[0].TransformedAxis3D.Location.Distance(secondPoint);
        }

        public static void SetHeight(Node node, double height)
        {
            if (height < Precision.Confusion)
                return;
            var builder = new NodeBuilder(node);

            // Calculate the percentage used to scale the height
            var scale = height/GetHeight(builder);
            if (Math.Abs(scale - 1) < Precision.Confusion)
                return;
            // Built two points with the coordinates of the origin vertex and the coordinates of the vertex to be scaled
            var dependency = builder;
            var secondPoint = new gpPnt();
            var fourthPoint = new gpPnt();
            GeomUtils.CalculateRectangleVertexes(dependency[0].TransformedAxis3D.Location,
                                                 dependency[1].TransformedPoint3D.GpPnt,
                                                 dependency[0].TransformedAxis3D.Direction, ref secondPoint,
                                                 ref fourthPoint);
            var point = new Point3D(dependency[0].TransformedAxis3D.Location);
            var pointTrs = new Point3D(secondPoint);

            var result = ScaleSegment(point, pointTrs, scale);

            dependency[1].TransformedPoint3D =
                new Point3D(GeomUtils.CalculateRectangleVertex3(dependency[0].TransformedAxis3D.Location, result.GpPnt,
                                                                dependency[0].TransformedAxis3D.Direction,
                                                                GetWidth(builder)));
        }

        public static double RectangleGetHeight(Node rectangleNode)
        {
            var builder = new NodeBuilder(rectangleNode);
            return builder[0].TransformedPoint3D.Distance(builder[1].TransformedPoint3D);
        }

        public static void RectangleSetHeight(Node node, double height)
        {
            if (height < Precision.Confusion)
                return;
            ParalelogramSetHeightPoints(node, height);
        }

        public static void ParalelogramSetHeightPoints(Node node, double height)
        {
            if (height < Precision.Confusion)
                return;

            var builder = new NodeBuilder(node);
            var initialHeight = builder[0].TransformedPoint3D.Distance(builder[1].TransformedPoint3D);
            var heigthToAdd = height - initialHeight;
            var heigthDirection = new gpVec(builder[0].TransformedPoint3D.GpPnt, builder[1].TransformedPoint3D.GpPnt);
            heigthDirection.Normalize();
            heigthDirection.Multiply(heigthToAdd);
            builder[1].TransformedPoint3D = new Point3D(builder[1].TransformedPoint3D.GpPnt.Translated(heigthDirection));
            builder[2].TransformedPoint3D = new Point3D(builder[2].TransformedPoint3D.GpPnt.Translated(heigthDirection));
        }

        public static double GetLineLength(Node lineNode)
        {
            var dependency = GetFunctionDependency(lineNode);
            return dependency[0].RefTransformedPoint3D.GpPnt.Distance(dependency[1].RefTransformedPoint3D.GpPnt);
        }

        public static void SetLineLength(Node lineNode, double length)
        {
            if (Math.Abs(length) < Precision.Confusion || lineNode.Children.Count == 0)
            {
                return;
            }
            // Calculate the percentage used to scale the width
            var scale = length/GetLineLength(lineNode);
            if (Math.Abs(scale - 1) < Precision.Confusion)
                return;
            // Built two points with the coordinates of the origin vertex and the coordinates of the vertex to be scaled
            var dependency = GetFunctionDependency(lineNode);
            var point = dependency[0].RefTransformedPoint3D;
            var pointTrs = dependency[1].RefTransformedPoint3D;

            var result = ScaleSegment(point, pointTrs, scale);

            // Disable the Vertex transaction commands
            dependency[1].RefTransformedPoint3D = result;
        }
    }
}