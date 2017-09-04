#region Usings
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using System;
using TreeData.NaroDataViewer;
using TreeData.Utils;
#endregion

namespace ShapeFunctionsInterface.Utils
{
    public static class NodeBuilderUtils
    {
        private static gpAx1 ExtractHorizontalLineAxis(Node lineNode, FunctionInterpreter func)
        {
            var transf = lineNode.Get<TransformationInterpreter>();

            var point1 = func.Dependency[0].TransformedPoint3D.GpPnt.Transformed(transf.CurrTransform);
            var point2 = new Point3D(point1);
            point2.X += 100;
            var gpPoint2 = point2.GpPnt;

            return GeomUtils.ExtractAxisFromTwoPoints(point1, gpPoint2);
        }

        public static void HidePlanes(Document Document)
        {
            for (int i = 0; i < Document.Root.Children.Count && i<3; i++)
            {
                var nb = new NodeBuilder(Document.Root.Children[i]);
                if (nb.FunctionName == FunctionNames.Plane)
                    nb.Visibility = ObjectVisibility.Hidden;
            }
        }

        private static gpAx1 ExtractVerticalLineAxis(Node lineNode, FunctionInterpreter func)
        {
            var transf = lineNode.Get<TransformationInterpreter>();

            var point1 = func.Dependency[0].TransformedPoint3D.GpPnt.Transformed(transf.CurrTransform);
            var point2 = new Point3D(point1);
            point2.Y += 100;
            var gpPoint2 = point2.GpPnt;

            return GeomUtils.ExtractAxisFromTwoPoints(point1, gpPoint2);
        }


        private static gpAx1 ExtractLine3DAxis(FunctionInterpreter func)
        {
            var point1 = func.Dependency[1].TransformedPoint3D.GpPnt;
            var point2 = func.Dependency[3].TransformedPoint3D.GpPnt;

            return GeomUtils.ExtractAxisFromTwoPoints(point1, point2);
        }

        public static List<Node> ExtractPointsFromShapes(IEnumerable<SceneSelectedEntity> nodes)
        {
            var addedPoints = new List<string>();
            var nodesList = new List<Node>();
            foreach (var node in nodes)
            {
                var nb1 = new NodeBuilder(node.Node);
                switch (nb1.FunctionName)
                {
                    case FunctionNames.Circle:
                        if (!addedPoints.Contains(nb1.Dependency[0].ReferenceBuilder.ShapeName))
                        {
                            nodesList.Add(nb1.Dependency[0].ReferenceBuilder.Node);
                            addedPoints.Add(nb1.Dependency[0].ReferenceBuilder.ShapeName);
                        }
                        break;
                    case FunctionNames.LineTwoPoints:
                        if (!addedPoints.Contains(nb1.Dependency[0].ReferenceBuilder.ShapeName))
                        {
                            nodesList.Add(nb1.Dependency[0].ReferenceBuilder.Node);
                            addedPoints.Add(nb1.Dependency[0].ReferenceBuilder.ShapeName);
                        }
                        if (!addedPoints.Contains(nb1.Dependency[1].ReferenceBuilder.ShapeName))
                        {
                            nodesList.Add(nb1.Dependency[1].ReferenceBuilder.Node);
                            addedPoints.Add(nb1.Dependency[1].ReferenceBuilder.ShapeName);
                        }
                        break;
                    case FunctionNames.Ellipse:
                    case FunctionNames.Arc:
                    case FunctionNames.Arc3P:
                        if (!addedPoints.Contains(nb1.Dependency[0].ReferenceBuilder.ShapeName))
                        {
                            nodesList.Add(nb1.Dependency[0].ReferenceBuilder.Node);
                            addedPoints.Add(nb1.Dependency[0].ReferenceBuilder.ShapeName);
                        }
                        if (!addedPoints.Contains(nb1.Dependency[1].ReferenceBuilder.ShapeName))
                        {
                            nodesList.Add(nb1.Dependency[1].ReferenceBuilder.Node);
                            addedPoints.Add(nb1.Dependency[1].ReferenceBuilder.ShapeName);
                        }
                        if (!addedPoints.Contains(nb1.Dependency[2].ReferenceBuilder.ShapeName))
                        {
                            nodesList.Add(nb1.Dependency[2].ReferenceBuilder.Node);
                            addedPoints.Add(nb1.Dependency[2].ReferenceBuilder.ShapeName);
                        }
                        break;
                }
            }
            return nodesList;
        }

        public static double GetInternalAngle(NodeBuilder arcBuilder)
        {
            var sketchAxis = GetTransformedAxis(new NodeBuilder(FindSketchNode(arcBuilder.Node)));
            var axis = new gpAx2(sketchAxis.Location, sketchAxis.Direction);
            var center = GeomUtils.Point3DTo2D(axis, arcBuilder[0].RefTransformedPoint3D);
            var point1 = GeomUtils.Point3DTo2D(axis, arcBuilder[1].RefTransformedPoint3D);
            var point2 = GeomUtils.Point3DTo2D(axis, arcBuilder[2].RefTransformedPoint3D);
            var startAngle = (Math.Atan2(point1.Y - center.Y, point1.X - center.X) * 180) / Math.PI;
            var endAngle = (Math.Atan2(point2.Y - center.Y, point2.X - center.X) * 180) / Math.PI;
            var internalAngle = ArcInternalAngle(startAngle, endAngle);
            internalAngle = internalAngle % 360;
           return internalAngle;
        }

        public static double GetInternalAngle(Point3D centerPoint, Point3D startPoint, Point3D endPoint, Node nodeOnSketch)
        {
            var sketchAxis = GetTransformedAxis(new NodeBuilder(FindSketchNode(nodeOnSketch)));
            var axis = new gpAx2(sketchAxis.Location, sketchAxis.Direction);
            var center = GeomUtils.Point3DTo2D(axis, centerPoint);
            var point1 = GeomUtils.Point3DTo2D(axis, startPoint);
            var point2 = GeomUtils.Point3DTo2D(axis, endPoint);
            var startAngle = (Math.Atan2(point1.Y - center.Y, point1.X - center.X) * 180) / Math.PI;
            var endAngle = (Math.Atan2(point2.Y - center.Y, point2.X - center.X) * 180) / Math.PI;
            var internalAngle = ArcInternalAngle(startAngle, endAngle);
            internalAngle = internalAngle % 360;
            return internalAngle;
        }

        public static double GetStartAngle(NodeBuilder arcBuilder)
        {
            var sketchAxis = GetTransformedAxis(new NodeBuilder(FindSketchNode(arcBuilder.Node)));
            var axis = new gpAx2(sketchAxis.Location, sketchAxis.Direction);
            var center = GeomUtils.Point3DTo2D(axis, arcBuilder[0].RefTransformedPoint3D);
            var point = GeomUtils.Point3DTo2D(axis, arcBuilder[1].RefTransformedPoint3D);
            return (Math.Atan2(point.Y - center.Y, point.X - center.X) * 180) / Math.PI;
        }

        public static double GetEndAngle(NodeBuilder arcBuilder)
        {
            var sketchAxis = GetTransformedAxis(new NodeBuilder(FindSketchNode(arcBuilder.Node)));
            var axis = new gpAx2(sketchAxis.Location, sketchAxis.Direction);
            var center = GeomUtils.Point3DTo2D(axis, arcBuilder[0].RefTransformedPoint3D);
            var point = GeomUtils.Point3DTo2D(axis, arcBuilder[2].RefTransformedPoint3D);
            return (Math.Atan2(point.Y - center.Y, point.X - center.X) * 180) / Math.PI;
        }

        public static double GetArcAngle(Point3D arcCenter, Point3D pointOnArc, NodeBuilder arcBuilder)
        {
            var sketchAxis = GetTransformedAxis(new NodeBuilder(FindSketchNode(arcBuilder.Node)));
            var axis = new gpAx2(sketchAxis.Location, sketchAxis.Direction);
            var center = GeomUtils.Point3DTo2D(axis, arcCenter);
            var point = GeomUtils.Point3DTo2D(axis, pointOnArc);
            return Math.Atan2(point.Y - center.Y, point.X - center.X);
        }

        public static double ArcInternalAngle(double startAngle, double endAngle)
        {
            if (startAngle > 0)
            {
                if (endAngle < 0)
                    return 360 - startAngle - Math.Abs(endAngle);
                else
                {
                    if (endAngle >= startAngle)
                        return endAngle - startAngle;
                    return 360 - startAngle + endAngle;
                }
            }
            else
            {
                if (endAngle > 0)
                    return endAngle + Math.Abs(startAngle);
                else
                {
                    if (startAngle < endAngle)
                        return Math.Abs(startAngle) - Math.Abs(endAngle);
                    else
                        return 360 - (Math.Abs(endAngle) - Math.Abs(startAngle));
                }
            }
        }

        public static Point3D SetInternalAngle(NodeBuilder arcBuilder, double newAngle)
        {
            var sketchAxis = GetTransformedAxis(new NodeBuilder(FindSketchNode(arcBuilder.Node)));
            var axis = new gpAx2(sketchAxis.Location, sketchAxis.Direction);
            var center = GeomUtils.Point3DTo2D(axis, arcBuilder[0].RefTransformedPoint3D);
            var point1 = GeomUtils.Point3DTo2D(axis, arcBuilder[1].RefTransformedPoint3D);
            var point2 = GeomUtils.Point3DTo2D(axis, arcBuilder[2].RefTransformedPoint3D);
            var startAngle = (Math.Atan2(point1.Y - center.Y, point1.X - center.X) * 180) / Math.PI;
            var endAngle = (Math.Atan2(point2.Y - center.Y, point2.X - center.X) * 180) / Math.PI;
            var currentValue = ArcInternalAngle(startAngle, endAngle);
            var delta = newAngle - currentValue;
            return PositionForAngle(arcBuilder, arcBuilder[0].RefTransformedPoint3D,
                                    arcBuilder[2].RefTransformedPoint3D, endAngle + delta);
        }

        public static Point3D PositionForAngle(NodeBuilder arc, Point3D center, Point3D point, double angle)
        {
            if (Math.Abs(Math.Abs(angle) - 180) < Precision.Confusion)
            {
                var sketchAxis = NodeBuilderUtils.GetTransformedAxis(new NodeBuilder(NodeBuilderUtils.FindSketchNode(arc.Node)));
                var axis = new gpAx2(sketchAxis.Location, sketchAxis.Direction);
                var center2D = GeomUtils.Point3DTo2D(axis, arc[0].RefTransformedPoint3D);
                var point2D = GeomUtils.Point3DTo2D(axis, arc[1].RefTransformedPoint3D);
                var y = center2D.Y;
                var x = center2D.X - center2D.Distance(point2D);
                return new Point3D(GeomUtils.Point2DTo3D(axis, new gpPnt2d(x, y)));
            }
            if (Math.Abs(angle) < Precision.Confusion)
            {
                var sketchAxis = NodeBuilderUtils.GetTransformedAxis(new NodeBuilder(NodeBuilderUtils.FindSketchNode(arc.Node)));
                var axis = new gpAx2(sketchAxis.Location, sketchAxis.Direction);
                var center2D = GeomUtils.Point3DTo2D(axis, arc[0].RefTransformedPoint3D);
                var point2D = GeomUtils.Point3DTo2D(axis, arc[1].RefTransformedPoint3D);
                var y = center2D.Y;
                var x = center2D.X + center2D.Distance(point2D);
                return new Point3D(GeomUtils.Point2DTo3D(axis, new gpPnt2d(x, y)));
            }
            if (Math.Abs(angle) > 90)
                return PositionForObtuseAngle(arc, center, point, angle);
            return PositionForAcuteAngle(arc, center, point, angle);
        }

        private static Point3D PositionForAcuteAngle(NodeBuilder arc, Point3D center, Point3D point, double angle)
        {
            angle = angle * Math.PI / 180;
            var sketchAxis = GetTransformedAxis(new NodeBuilder(FindSketchNode(arc.Node)));
            var axis = new gpAx2(sketchAxis.Location, sketchAxis.Direction);
            var center2D = GeomUtils.Point3DTo2D(axis, center);
            var point2D = GeomUtils.Point3DTo2D(axis, point);
            var y = point2D.Distance(center2D) * Math.Sin(angle) + center2D.Y;
            var x = center2D.X + (y - center2D.Y) / Math.Tan(angle);
            return new Point3D(GeomUtils.Point2DTo3D(axis, new gpPnt2d(x, y)));
        }

        private static Point3D PositionForObtuseAngle(NodeBuilder arc, Point3D center, Point3D point, double angle)
        {
            var oppositeAngle = 180 - angle;
            if (angle < 0)
                oppositeAngle = -180 - angle;
            angle = oppositeAngle * Math.PI / 180;
            var sketchAxis = GetTransformedAxis(new NodeBuilder(FindSketchNode(arc.Node)));
            var axis = new gpAx2(sketchAxis.Location, sketchAxis.Direction);
            var center2D = GeomUtils.Point3DTo2D(axis, center);
            var point2D = GeomUtils.Point3DTo2D(axis, point);
            var y = point2D.Distance(center2D) * Math.Sin(angle) + center2D.Y;
            var x = center2D.X - (y - center2D.Y) / Math.Tan(angle);
            return new Point3D(GeomUtils.Point2DTo3D(axis, new gpPnt2d(x, y)));
        }

        public static gpAx1 GetTransformedAxis(NodeBuilder sketchNode)
        {
            var sketchTransformed = sketchNode;
            if (sketchNode.FunctionName == FunctionNames.Extrude || sketchNode.FunctionName == FunctionNames.Cut)
            {
                sketchTransformed = sketchNode.Dependency[0].ReferenceBuilder;
            }

          //  var multiplied = GetGlobalTransformation(sketchTransformed);
            var multiplied = sketchNode.Node.Get<TransformationInterpreter>().CurrTransform;
            var transformedAxis = sketchTransformed.Dependency[0].Axis3D.GpAxis.Transformed(multiplied);
            transformedAxis.Direction = RoundToPrecision(transformedAxis.Direction);
            return transformedAxis;
        }

        public static gpTrsf GetGlobalTransformation(NodeBuilder sketchNode)
        {
            var sketchTransformed = sketchNode;
            if (sketchNode.FunctionName == FunctionNames.Extrude || sketchNode.FunctionName == FunctionNames.Cut)
            {
                sketchTransformed = sketchNode.Dependency[0].ReferenceBuilder;
            }
            var transformations = GetTransformations(sketchTransformed);
            var multiplied = new gpTrsf();
            foreach (var trsf in transformations)
                multiplied = multiplied.Multiplied(trsf);

            var newValue = new gpTrsf();
            var allTrsfs = new List<TransformationInfo>();
            var found = false;
            var sketchNodeIndex = sketchNode.Node.Index;
            while (!found)
            {
                var currentLevelSketches = (TransformationInterpreter.Transformations.Where(trsfInfo => trsfInfo.SketchIndex == sketchNodeIndex)).ToList();
                if (currentLevelSketches.Count() == 0)
                {
                    if (sketchNode.Dependency[2].ReferenceBuilder.Node != null)
                    {
                        sketchNodeIndex =
                            sketchNode.Dependency[2].ReferenceBuilder.Dependency[0].ReferenceBuilder.Node.Index;
                        found = true;
                    }
                    else
                        break;
                }
                else
                {


                    var smallestIndex = TransformationInfo.maxTrsfIndex;
                    var smallestIndexTrsf = new TransformationInfo();
                    foreach (var sketch in currentLevelSketches)
                    {
                        if (sketch.TrsfIndex < smallestIndex)
                        {
                            smallestIndex = sketch.TrsfIndex;
                            smallestIndexTrsf = sketch;
                        }
                    }

                    allTrsfs.AddRange(currentLevelSketches);
                    if (smallestIndexTrsf.RefSketchIndex < 0 || allTrsfs.Count == TransformationInterpreter.Transformations.Count)
                        found = true;
                    else
                    {
                        sketchNodeIndex = smallestIndexTrsf.RefSketchIndex;
                    }
                }
            }
            allTrsfs = allTrsfs.OrderBy(p => p.TrsfIndex).Reverse().ToList();
            foreach(var trsfInfo in allTrsfs)
            {
                newValue = newValue.Multiplied(trsfInfo.Transformation);
            }
           
            return multiplied;
          //  return newValue;
        }

        public static gpDir RoundToPrecision(gpDir direction)
        {
            var X = RoundToPrecision(direction.X);
            var Y = RoundToPrecision(direction.Y);
            var Z = RoundToPrecision(direction.Z);
            var rounded = new gpDir(X, Y, Z);
            return rounded;
        }

        private static double RoundToPrecision(double value)
        {
            if (Math.Abs(Math.Ceiling(value) - value) < Precision.Confusion)
                return Math.Ceiling(value);
            if (Math.Abs(Math.Floor(value) - value) < Precision.Confusion)
                return Math.Floor(value);
            return value;
        }

        public static IEnumerable<gpTrsf> GetTransformations(NodeBuilder sketchNode)
        {
            var _3DShapesFunctions = new List<string>();
            _3DShapesFunctions.AddRange(new[] { FunctionNames.Sphere, FunctionNames.Box, FunctionNames.Cylinder,
                        FunctionNames.Torus, FunctionNames.Cone, FunctionNames.Plane});
            if (_3DShapesFunctions.Contains(sketchNode.FunctionName))
            {
                var trsf = sketchNode.Node.Get<TransformationInterpreter>().CurrTransform;
                yield return trsf;
                yield break;
            }
            if (sketchNode.FunctionName == FunctionNames.Extrude || sketchNode.FunctionName == FunctionNames.Cut)
            {
                foreach (var trsf in GetTransformations(sketchNode.Dependency[0].ReferenceBuilder))
                    yield return trsf;
            }
            else
            {
                if (sketchNode.Dependency[2].ReferenceBuilder != null &&
                    sketchNode.Dependency[2].ReferenceBuilder.Node != null &&
                    sketchNode.Dependency[2].ReferenceBuilder.FunctionName != string.Empty)
                {
                    var nb = new NodeBuilder(sketchNode.Dependency[2].ReferenceBuilder.Node);
                    if(_3DShapesFunctions.Contains(nb.FunctionName))
                    {  
                        yield return nb.Node.Get<TransformationInterpreter>().CurrTransform;
                        yield break;
                    }
                    var baseSketch = nb.Dependency[0].ReferenceBuilder;
                    if (baseSketch.FunctionName == FunctionNames.Extrude || baseSketch.FunctionName == FunctionNames.Cut)
                        foreach (var trsf in GetTransformations(baseSketch.Dependency[0].ReferenceBuilder))
                            yield return trsf;
                    else
                        foreach (var trsf in GetTransformations(baseSketch))
                            yield return trsf;
                }
            }
            if (sketchNode.Node.Get<TransformationInterpreter>() != null)
                yield return sketchNode.Node.Get<TransformationInterpreter>().CurrTransform;
            else
                yield return new gpTrsf();
        }

        public static bool NodeIsOnSketch(NodeBuilder nodeBuilder)
        {
            var solids = new List<string>() { FunctionNames.Extrude, FunctionNames.Cut, FunctionNames.Boolean };
            solids.AddRange(FunctionNames.GetSolids());

            bool isOnSketch = !solids.Contains(nodeBuilder.FunctionName);
            if (!isOnSketch)
            {
                if (nodeBuilder.Shape.ShapeType == TopAbsShapeEnum.TopAbs_WIRE ||
                   nodeBuilder.Shape.ShapeType == TopAbsShapeEnum.TopAbs_VERTEX)
                    isOnSketch = true;
            }
            return isOnSketch;
        }

        public static void SetupNodePoint(Node node, Point3D coordinate)
        {
            var nodePoint = GetNodePoint(node);
            //data may not be yet initialized
            if (nodePoint == null)
                return;
            var originalValue = (Point3D)nodePoint;
            if (coordinate.IsEqual(originalValue))
                return;
            var index = node.Index - 1;
            var builder = new NodeBuilder(node.Parent);
            if (builder[index].Name == InterpreterNames.Point3D)
            {
                builder[index].TransformedPoint3D = coordinate;
            }
            if (builder[index].Name != InterpreterNames.Axis3D) return;
            var axis = new gpAx1(coordinate.GpPnt, builder[index].Axis3D.GpAxis.Direction);
            builder[index].Axis3D = new Axis(axis);
        }

        public static int ShapeHasConstraint(Node node, string constraintName, Document document)
        {
            foreach (var child in document.Root.Children)
            {
                var constraint = child.Key;
                if (document.Root[constraint].Get<FunctionInterpreter>().Name == constraintName)
                {
                    if (node.Get<FunctionInterpreter>().Name == FunctionNames.LineTwoPoints)
                    {
                        var linePoints = GetDependencyReferenceIndexes(node.Index, document);

                        var constraintPoints = GetDependencyReferenceIndexes(constraint, document);

                        if (!constraintPoints.Except(linePoints).Any())
                        {
                            var nb1 = new NodeBuilder(child.Value);
                            if (nb1.FunctionName == constraintName)
                            {
                                return child.Key;
                            }
                        }
                    }
                    if (node.Get<FunctionInterpreter>().Name == FunctionNames.Circle)
                    {
                        var constraintPoints = GetDependencyReferenceIndexes(constraint, document);
                        var circlePoint = new List<int>() { node.Index };
                        if (!constraintPoints.Except(circlePoint).Any())
                        {
                            var nb1 = new NodeBuilder(child.Value);
                            if (nb1.FunctionName == constraintName)
                            {
                                return child.Key;
                            }
                        }
                    }
                }
            }
            return -1;
        }

        public static IEnumerable<int> GetDependencyReferenceIndexes(int index, Document document)
        {
            foreach (var child in document.Root[index].Children)
            {
                if (child.Value.Get<ReferenceInterpreter>() != null)
                {
                    yield return child.Value.Get<ReferenceInterpreter>().Node.Index;
                }
            }
        }

        public static Point3D? GetNodePoint(Node node)
        {
            var index = node.Index - 1;
            var builder = new NodeBuilder(node.Parent);
            if (builder[index].Name == InterpreterNames.Point3D)
                return builder[index].TransformedPoint3D;

            if (node.Get<Axis3DInterpreter>() != null)
                return node.Get<Axis3DInterpreter>().Value;
            return null;
        }


        public static void AddLengthAndDimensionConstraint(Document document, Node parent, bool enableSelection)
        {
            var lineLength = (new NodeBuilder(parent))[0].RefTransformedPoint3D.Distance(new NodeBuilder(parent)[1].RefTransformedPoint3D);
            var builder = new NodeBuilder(document, Constraint2DNames.LineLengthFunction);
            builder[0].Reference = (new NodeBuilder(parent))[0].Reference;
            builder[1].Reference = (new NodeBuilder(parent))[1].Reference;
            builder[2].Real = lineLength;
         
            builder.EnableSelection = enableSelection;
            builder.ExecuteFunction();

            var nbD = new NodeBuilder(document, FunctionNames.Dimension);

            var sse = new SceneSelectedEntity(parent) { ShapeCount = 1, ShapeType = TopAbsShapeEnum.TopAbs_EDGE };
            nbD[0].ReferenceData = sse;
            nbD[1].Node.Set<Point3DInterpreter>().Value = GeomUtils.ComputeMidPoint((new NodeBuilder(parent))[0].RefTransformedPoint3D, (new NodeBuilder(parent))[1].RefTransformedPoint3D);
            nbD.ExecuteFunction();
        }

        public static void AddLengthConstraint(Document document, NodeBuilder parent)
        {
            var lineLength =
                       parent[0].RefTransformedPoint3D.Distance(
                           parent[1].RefTransformedPoint3D);
            var lengthConstraintBuilder = new NodeBuilder(document, Constraint2DNames.LineLengthFunction);
            lengthConstraintBuilder[0].Reference = parent[0].Reference;
            lengthConstraintBuilder[1].Reference = parent[1].Reference;
            lengthConstraintBuilder[2].Real = lineLength;

            lengthConstraintBuilder.ExecuteFunction();
        }

        public static void AddRadiusConstraint(Document document, Node parent)
        {
            var builder = new NodeBuilder(document, Constraint2DNames.CircleRadiusFunction);
            builder[0].Reference = parent;
            builder[1].Real = (new NodeBuilder(parent))[1].Real;
            builder.ExecuteFunction();
        }

        public static void GetSolidsAnd3D(Node currentNode, out List<int> solids, out List<int> nodes)
        {
            var allNodes = GetAllContained3DNodesIndexes(currentNode);
            solids = new List<int>();
            nodes = new List<int>();
            foreach (var node in allNodes)
            {
                var functionName = node.Value;
                if (FunctionNames.GetSolids().Contains(functionName))
                {
                    solids.Add(node.Key);
                }
                else
                {
                    nodes.Add(node.Key);
                }
            }
        }

        public static IEnumerable<KeyValuePair<int, string>> GetAllContained3DNodesIndexes(Node currentNode)
        {
            var nb = new NodeBuilder(currentNode);
            var functionName = nb.FunctionName;

            if (FunctionNames.GetSolids().Contains(functionName))
            {
                yield return new KeyValuePair<int, string>(currentNode.Index, functionName);
            }
            if (functionName == FunctionNames.Cut)
            {
                for (int i = 0; i < currentNode.Children[4].Get<ReferenceListInterpreter>().Nodes.Count; i++)
                {
                    foreach (var index in GetAllContained3DNodesIndexes(currentNode.Children[4].Get<ReferenceListInterpreter>().Nodes[i].Node))
                    {
                        yield return index;
                    }
                }
                yield return new KeyValuePair<int, string>(currentNode.Index, functionName);
            }
            if (functionName == FunctionNames.Extrude)
                yield return new KeyValuePair<int, string>(currentNode.Index, functionName);
            if (functionName == FunctionNames.Boolean)
            {
                foreach (var index in GetAllContained3DNodesIndexes(currentNode.Children[1].Get<ReferenceInterpreter>().Node))
                {
                    yield return index;
                }
                foreach (var index in GetAllContained3DNodesIndexes(currentNode.Children[2].Get<ReferenceInterpreter>().Node))
                {
                    yield return index;
                }
            }
            if (functionName == FunctionNames.Fillet)
            {
                foreach (var index in GetAllContained3DNodesIndexes(currentNode.Children[1].Get<ReferenceInterpreter>().Node))
                {
                    yield return index;
                }
            }
        }

        public static IEnumerable<Node> GetAllContained3DNodes(Node currentNode)
        {
            var nb = new NodeBuilder(currentNode);
            var functionName = nb.FunctionName;

            if (FunctionNames.GetSolids().Contains(functionName))
            {
                yield return currentNode;
            }
            if (functionName == FunctionNames.Cut)
            {
                for (int i = 0; i < currentNode.Children[4].Get<ReferenceListInterpreter>().Nodes.Count; i++)
                {
                    foreach (var index in GetAllContained3DNodes(currentNode.Children[4].Get<ReferenceListInterpreter>().Nodes[i].Node))
                    {
                        yield return index;
                    }
                }
                yield return currentNode;
            }
            if (functionName == FunctionNames.Extrude)
                yield return currentNode;
            if (functionName == FunctionNames.Boolean)
            {
                foreach (var index in GetAllContained3DNodes(currentNode.Children[1].Get<ReferenceInterpreter>().Node))
                {
                    yield return index;
                }
                foreach (var index in GetAllContained3DNodes(currentNode.Children[2].Get<ReferenceInterpreter>().Node))
                {
                    yield return index;
                }
            }
            if (functionName == FunctionNames.Fillet)
            {
                foreach (var index in GetAllContained3DNodes(currentNode.Children[1].Get<ReferenceInterpreter>().Node))
                {
                    yield return index;
                }
            }
        }

        public static List<Node> CopyPasteSketch(Node source, List<int> list)
        {
            var sketchNodeTypes = new List<string>(){FunctionNames.Circle,
            FunctionNames.LineTwoPoints, FunctionNames.Ellipse, FunctionNames.Arc,
            FunctionNames.Arc3P};

            var copiedPoints = new List<Node>();
            var document = source.Root.Get<DocumentContextInterpreter>().Document;
            var newShapeIndexes = new Dictionary<int, Node>();
            foreach (var nodeIndex in list)
            {
                var sketchNode = FindSketchNode(document.Root[nodeIndex]);

                var allNodesInSketch = new List<Node>();
                foreach (var node in document.Root.Children.Values)
                {
                    var temp = FindSketchNode(node);
                    //copy paste only non-points on sketch
                    if (temp != null && temp.Index == sketchNode.Index && sketchNodeTypes.Contains(node.Get<FunctionInterpreter>().Name))
                    {
                        allNodesInSketch.Add(node);
                    }
                }
                var shapesOnSketch = allNodesInSketch.Distinct();
                shapesOnSketch.ToList().Remove(sketchNode);

                // copy sketch Node
                var sketchNodeCopy = source.Root.AddNewChild();
                CopyPaste(sketchNode, sketchNodeCopy);

                sketchNodeCopy.Set<StringInterpreter>().Value = GetNextName(sketchNode) + " Copy";

                foreach (var node in shapesOnSketch)
                {
                    var pointsList = new List<Node>();
                    var newPointsIndexes = new Dictionary<int, Node>();
                    foreach (var childNode in node.Children)
                    {
                        if (childNode.Value.Get<ReferenceInterpreter>() != null)
                        {
                            pointsList.Add(childNode.Value.Get<ReferenceInterpreter>().Node);
                        }
                    }

                    foreach (var child in pointsList)
                    {
                        var pointCopy = source.Root.AddNewChild();
                        CopyPaste(child, pointCopy);

                        pointCopy.Set<StringInterpreter>().Value = GetNextName(pointCopy) + " Copy";
                        pointCopy.Children[1].Set<ReferenceInterpreter>().Node = sketchNodeCopy;
                        copiedPoints.Add(pointCopy);
                        newPointsIndexes.Add(child.Index, pointCopy);
                    }
                    var mainShapeCopy = source.Root.AddNewChild();
                    CopyPaste(node, mainShapeCopy);
                    mainShapeCopy.Set<StringInterpreter>().Value = GetNextName(mainShapeCopy) + " Copy";

                    foreach (var childNode in mainShapeCopy.Children)
                    {
                        if (childNode.Value.Get<ReferenceInterpreter>() != null && newPointsIndexes.ContainsKey(childNode.Value.Get<ReferenceInterpreter>().Node.Index))
                        {
                            childNode.Value.Set<ReferenceInterpreter>().Node = newPointsIndexes[childNode.Value.Get<ReferenceInterpreter>().Node.Index];
                        }
                    }
                }

                var finalShapeCopy = source.Root.AddNewChild();
                CopyPaste(document.Root[nodeIndex], finalShapeCopy);
                newShapeIndexes.Add(nodeIndex, finalShapeCopy);
                finalShapeCopy.Children[1].Set<ReferenceInterpreter>().Node = sketchNodeCopy;
                finalShapeCopy.Set<StringInterpreter>().Value = GetNextName(finalShapeCopy) + " Copy";
                if (finalShapeCopy.Get<FunctionInterpreter>().Name == FunctionNames.Cut)
                {
                    var indexList = finalShapeCopy.Children[4].Get<ReferenceListInterpreter>().Nodes.Select(node => node.Node.Index).ToList();
                    var nodeList = indexList.Select(index => new SceneSelectedEntity { Node = newShapeIndexes[index], ShapeType = TopAbsShapeEnum.TopAbs_FACE }).ToList();
                    finalShapeCopy.Children[4].Set<ReferenceListInterpreter>().Nodes = nodeList;
                }
            }
            if (source.Get<FunctionInterpreter>().Name == FunctionNames.Boolean)
            {
                var finalShapeCopy = source.Root.AddNewChild();
                CopyPaste(source, finalShapeCopy);

                finalShapeCopy.Set<StringInterpreter>().Value = GetNextName(finalShapeCopy) + " Copy";
                foreach (var childNode in finalShapeCopy.Children)
                {
                    if (childNode.Value.Get<ReferenceInterpreter>() != null && newShapeIndexes.ContainsKey(childNode.Value.Get<ReferenceInterpreter>().Node.Index))
                    {
                        childNode.Value.Set<ReferenceInterpreter>().Node = newShapeIndexes[childNode.Value.Get<ReferenceInterpreter>().Node.Index];
                    }
                }
            }

            return copiedPoints;
        }

        public static List<Node> CopyPaste(Node source)
        {
            // check if we have 3D objects 
            List<int> solids;
            List<int> nodes;
            GetSolidsAnd3D(source, out solids, out nodes);
            if (nodes.Count > 0)
            {
                var affectedNodes = CopyPasteSketch(source, nodes);
                return affectedNodes;
            }

            var pointsList = new List<Node>();
            var newNodesIndexes = new Dictionary<int, Node>();
            foreach (var childNode in source.Children)
            {
                if (childNode.Value.Get<ReferenceInterpreter>() != null)
                {
                    pointsList.Add(childNode.Value.Get<ReferenceInterpreter>().Node);
                }
            }
            var copiedPoints = new List<Node>();
            foreach (var child in pointsList)
            {
                var destinationChild = source.Root.AddNewChild();
                CopyPaste(child, destinationChild);

                destinationChild.Set<StringInterpreter>().Value = GetNextName(destinationChild) + " (Copy)";
                newNodesIndexes.Add(child.Index, destinationChild);
                copiedPoints.Add(destinationChild);
            }
            var destination = source.Root.AddNewChild();
            CopyPaste(source, destination);
            foreach (var childNode in destination.Children)
            {
                if (childNode.Value.Get<ReferenceInterpreter>() != null)
                {
                    if (newNodesIndexes.ContainsKey(childNode.Value.Get<ReferenceInterpreter>().Node.Index))
                    {
                        childNode.Value.Set<ReferenceInterpreter>().Node =
                            newNodesIndexes[childNode.Value.Get<ReferenceInterpreter>().Node.Index];
                    }
                }
            }
            destination.Set<StringInterpreter>().Value = GetNextName(destination) + " (Copy)";
            if (copiedPoints.Count > 0)
                return copiedPoints;
            return new List<Node> { destination };
        }

        public static List<int> FindHintsForConstraint(Node constraintNode, Document document)
        {
            var relatedNodes = new List<int>();
            foreach (var node in document.Root.Children)
            {
                if (node.Value.Get<FunctionInterpreter>().Name == FunctionNames.LineHints)
                {
                    var nb = new NodeBuilder(node.Value);
                    try
                    {
                        if (nb.Dependency.Count < 2 || nb.Dependency[1].ReferenceList == null)
                            continue;
                        for (int i = 0; i < nb.Dependency[1].ReferenceList.Count; i++)
                        {
                            if (nb.Dependency[1].ReferenceList[i].Node.Index == constraintNode.Index)
                                relatedNodes.Add(node.Value.Index);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return relatedNodes;
        }

        public static void AdddHintsForNode(Document Document, Node node, Node constraint, gpAx1 axis)
        {
            var hintsForConstraint = FindHintsForShape(node, Document);
            if (hintsForConstraint.Count == 0)
            {
                var newHint = new NodeBuilder(Document, FunctionNames.LineHints);
                newHint[0].Reference = node;
                newHint[1].ReferenceList = new List<SceneSelectedEntity> { new SceneSelectedEntity(constraint) };
                newHint[2].Axis3D = new Axis(axis);
                newHint.Color = Color.Black;
                newHint.ExecuteFunction();
            }
            else
                if (hintsForConstraint.Count == 1)
                {
                    var nb = (new NodeBuilder(Document.Root[hintsForConstraint[0]]));
                    nb.Dependency[1].ReferenceList.Add(
                        new SceneSelectedEntity(constraint));
                    nb.ExecuteFunction();
                }
        }

        public static void AdddHintsForNode(Document Document, Node node, Node constraint)
        {
            var sketchNode = FindSketchNode(node);
            var axis = GetTransformedAxis(new NodeBuilder(sketchNode));
            AdddHintsForNode(Document, node, constraint, axis);
        }

        public static List<int> FindHintsForShape(Node shapeNode, Document document)
        {
            var relatedNodes = new List<int>();
            foreach (var node in document.Root.Children)
            {
                if (node.Value.Get<FunctionInterpreter>().Name == FunctionNames.LineHints)
                {
                    var nb = new NodeBuilder(node.Value);
                    try
                    {
                        if (nb.Dependency.Count < 2 || nb.Dependency[1].ReferenceList == null)
                            continue;
                        if (nb.Dependency[0].Reference.Index == shapeNode.Index)
                            relatedNodes.Add(nb.Node.Index);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return relatedNodes;
        }

        public static void DeleteConstraintNode(Document document, Node node)
        {
            document.Transact();
            var relatedNodes = FindHintsForConstraint(node, document);
            foreach (var index in relatedNodes)
                document.Root.Remove(index);
            document.Root.Remove(node.Index);
            document.Commit("Deleted constraint");
        }

        public static Node FindSketchNode(Node shapeNode)
        {
            var nodeBuilder = new NodeBuilder(shapeNode);
            var invalidShapes = new List<string> { string.Empty };
            invalidShapes.AddRange(FunctionNames.GetSolids());
            invalidShapes.Add(FunctionNames.VerticalLine);
            invalidShapes.Add(FunctionNames.HorizontalLine);
            invalidShapes.Add(FunctionNames.Spline);
            invalidShapes.Add(FunctionNames.SplinePath);
            invalidShapes.Add(FunctionNames.Face);
            invalidShapes.Add(FunctionNames.SubShape);
            invalidShapes.Add(FunctionNames.FaceFuse);
            if (invalidShapes.Contains(nodeBuilder.FunctionName))
                return null;
            if (nodeBuilder.FunctionName == FunctionNames.Sketch)
                return shapeNode;
            if (nodeBuilder.FunctionName == FunctionNames.Dimension || nodeBuilder.FunctionName == FunctionNames.Fillet2D)
            {
                var lineBuilder = nodeBuilder[0].ReferenceBuilder;
                var pointBuilder1 = lineBuilder[0].ReferenceBuilder;
                return pointBuilder1[0].Reference;
            }
            if (nodeBuilder.FunctionName == FunctionNames.Extrude)
                return shapeNode[0];
            var pointBuilder = nodeBuilder[0].ReferenceBuilder;
            if (pointBuilder.Node == null)
                return null;
            if (pointBuilder.FunctionName == FunctionNames.Sketch)
                return pointBuilder.Node;
            var sketchNode = pointBuilder[0].Reference;
            return sketchNode;
        }

        public static Node FindBaseSketchNode(Node shapeNode)
        {
            var nodeBuilder = new NodeBuilder(shapeNode);
            var invalidShapes = new List<string> { string.Empty };
            invalidShapes.AddRange(FunctionNames.GetSolids());
            if (invalidShapes.Contains(nodeBuilder.FunctionName))
                return null;
            if (nodeBuilder.FunctionName == FunctionNames.Sketch)
                return shapeNode;
            if (nodeBuilder.FunctionName == FunctionNames.Dimension)
            {
                var lineBuilder = nodeBuilder[0].ReferenceBuilder;
                var pointBuilder1 = lineBuilder[0].ReferenceBuilder;
                return pointBuilder1[0].Reference;
            }
            var pointBuilder = nodeBuilder[0].ReferenceBuilder;
            if (pointBuilder.FunctionName == FunctionNames.Sketch)
                 return pointBuilder.Node;
            var sketchNode = pointBuilder[0].Reference;
            return sketchNode;
        }

        public static NodeBuilder GetBaseSketch(NodeBuilder sketchNode)
        {
            // if current sketch is on the face of a solid, apply the Trsf for the base sketch of that solid
            if (sketchNode.Dependency[2].ReferenceBuilder != null &&
                sketchNode.Dependency[2].ReferenceBuilder.Node != null)
            {
                var baseSketch =
                    new NodeBuilder(sketchNode.Dependency[2].ReferenceBuilder.Node).Dependency[0].ReferenceBuilder;
                return GetBaseSketch(baseSketch);
            }
            return sketchNode;
        }

        public static string GetNextName(Node node)
        {
            var sketchNode = FindSketchNode(node);
            var nodeBuilder = new NodeBuilder(node);
            if (sketchNode != null)
            {
                var document = sketchNode.Root.Get<DocumentContextInterpreter>().Document;
                var numbering = document.Root.Set<DocumentContextInterpreter>().Numbering;
                var nextNumber = numbering.GetNextIndexNumber(nodeBuilder.FunctionName);
                return nodeBuilder.FunctionName + " " + nextNumber;
            }
            return nodeBuilder.FunctionName;
        }


        private static void CopyPaste(Node source, Node destination)
        {
            destination.RemoveAllChildren();
            destination.RemoveAllInterpreters();
            foreach (var childNode in source.Children)
            {
                CopyPaste(childNode.Value, destination.FindChild(childNode.Key, true));
            }
            foreach (var childInterpreter in source.Interpreters)
            {
                destination.Interpreters[childInterpreter.Key] = AttributeInterpreterFactory.GetInterpreter(
                    childInterpreter.Key,
                    destination);
            }
            foreach (var childInterpreter in source.Interpreters)
            {
                var data = new AttributeData(childInterpreter.Key);
                childInterpreter.Value.Serialize(data);
                destination.Interpreters[childInterpreter.Key].Deserialize(data);
            }
        }


        public static void DeleteNode(Node nodeToDelete, Document document)
        {
            new NodeBuilder(nodeToDelete) { Visibility = ObjectVisibility.ToBeDeleted };
            document.OptimizeData();
        }

        public static void DeactivateSelectionOnNode(Node node, Document document)
        {
            var namedShapeInterpreter = node.Get<NamedShapeInterpreter>();
            if (namedShapeInterpreter != null && namedShapeInterpreter.Interactive != null)
            {
                document.Root.Get<DocumentContextInterpreter>().Context.Deactivate(namedShapeInterpreter.Interactive);
            }
        }

        public static bool IsRefencedByShape(Node node, string functionName)
        {
            foreach (var child in node.Root.Children.Values)
            {
                if (!Document.NodeReferences(child, node)) continue;
                var childFunctionName = FunctionUtils.GetFunctionName(child);
                if (childFunctionName != functionName) continue;
                return true;
            }
            return false;
        }

        public static void RemoveShapeThatReferenceCurrent(Node current, string functionName, Document document)
        {
            Node result = null;
            foreach (var child in current.Root.Children.Values)
            {
                if (!Document.NodeReferences(child, current)) continue;
                var childFunctionName = FunctionUtils.GetFunctionName(child);
                if (childFunctionName != functionName) continue;
                result = child;
                break;
            }
            DeleteNode(result, document);
        }

        public static void AddConstraintToOneField(Document document, Node current, string functionName, int childIndex)
        {
            var currentShapeBuilder = new NodeBuilder(current);
            AddConstraintToOneField(document, current, functionName, currentShapeBuilder[childIndex].Real);
        }

        public static NodeBuilder AddConstraintToOneField(Document document, Node current, string functionName, double value)
        {
            var builder = new NodeBuilder(document, functionName);
            builder[0].Reference = current;
            builder[1].Real = value;
            builder.ExecuteFunction();
            return builder;
        }

        /// <summary>
        ///   Identifies the Node that contains a specified OCTopoDS_Shape
        /// </summary>
        public static Node IdentifyAisNode(Node rootLabel, AISInteractiveObject shape)
        {
            var shapeManager = rootLabel.Get<DocumentContextInterpreter>().ShapeManager;
            foreach (var shapeInteractive in shapeManager.ShapeList)
            {
                if (shapeInteractive.Value.IsSameTransient(shape))
                    return rootLabel[shapeInteractive.Key];
            }
            return null;
        }

        /// <summary>
        ///   Identifies all the nodes coresponding to the selected shapes from the context
        /// </summary>
        public static List<Node> IdentifyAisSelectedNodes(Node rootNode)
        {
            var result = new List<Node>();
            var context = rootNode.Get<DocumentContextInterpreter>().Context;
            var selectedAis = GeomUtils.GetAiSelectedShapes(context);
            foreach (var ais in selectedAis)
            {
                var node = IdentifyAisNode(rootNode, ais);
                if (node != null)
                    result.Add(node);
            }
            return result;
        }

        /// <summary>
        ///   Identifies all the nodes coresponding to the selected shapes from the context
        /// </summary>
        public static List<SceneSelectedEntity> IdentifySelectedNodes(Node rootNode)
        {
            var context = rootNode.Get<DocumentContextInterpreter>().Context;
            var nodes = new List<SceneSelectedEntity>();
            var selectedShapes = GeomUtils.GetAllSelectedShapes(context);
            if (selectedShapes.Count <= 0)
                return nodes;

            foreach (var shape in selectedShapes)
            {
                var node = GeomUtils.IdentifyNode(rootNode, shape);
                if (node != null)
                    nodes.Add(node);
            }

            return nodes;
        }

        /// <summary>
        ///   Identifies shapes under mouse
        /// </summary>
        public static List<Node> IdentifyShapesUnderMouse(Node rootNode, int x, int y, V3dView view)
        {
            var identifiedShapes = new List<Node>();

            var context = rootNode.Get<DocumentContextInterpreter>().Context;
            var selector = context.MainSelector;
            if (selector == null) return identifiedShapes;
            selector.Pick(x, y, view);
            selector.Init();
            while (selector.More)
            {
                var EO = selector.Picked();
                var pickedAIS = EO.Selectable;
                var aisInteractive = pickedAIS.Convert<AISInteractiveObject>();
                if ((aisInteractive == null) || (aisInteractive.Type != AISKindOfInteractive.AIS_KOI_Shape))
                {
                    selector.Next();
                    continue;
                }
                var aisShape = aisInteractive.Convert<AISShape>();
                var topoShape = aisShape.Shape;
                foreach (var childNode in rootNode.Children.Values)
                {
                    if (childNode.Set<DrawingAttributesInterpreter>().Visibility == ObjectVisibility.Hidden)
                    {
                        selector.Next();
                        continue;
                    }

                    var shapeInterpter = childNode.Get<TopoDsShapeInterpreter>();
                    if (shapeInterpter == null) continue;
                    var ocafShape = shapeInterpter.Shape;
                    if ((ocafShape == null) || (ocafShape.IsNull))
                    {
                        selector.Next();
                        continue;
                    }

                    if (ocafShape.IsSame(topoShape))
                    {
                        identifiedShapes.Add(childNode);
                    }
                }
                selector.Next();
            }

            return identifiedShapes;
        }

        /// <summary>
        ///   Identifies all the detected nodes coresponding from the context
        /// </summary>
        public static List<SceneSelectedEntity> IdentifyDetectedNodes(Node rootNode)
        {
            var context = rootNode.Get<DocumentContextInterpreter>().Context;
            var nodes = new List<SceneSelectedEntity>();
            var detectedShapes = GeomUtils.GetAllDetectedShapes(context);
            if (detectedShapes.Count <= 0)
                return nodes;

            foreach (var shape in detectedShapes)
            {
                var node = GeomUtils.IdentifyNode(rootNode, shape);
                if (node != null && !nodes.Any(n => n.Node.Index == node.Node.Index))
                {
                    nodes.Add(node);
                }
            }

            return nodes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstPoint"></param>
        /// <param name="secondPoint"></param>
        /// <param name="distance">Distance is from firstPoint</param>
        /// <returns></returns>
        public static Point3D GetPointAtDistance(NodeBuilder firstPoint, NodeBuilder secondPoint, double distance)
        {
            var sketchAxis = GetTransformedAxis(new NodeBuilder(FindSketchNode(firstPoint.Node)));
            var axis = new gpAx2(sketchAxis.Location, sketchAxis.Direction);
            var firstPoint2D = GeomUtils.Point3DTo2D(axis, firstPoint[1].TransformedPoint3D);
            var secondPoint2D = GeomUtils.Point3DTo2D(axis, secondPoint[1].TransformedPoint3D);
            var newPoint = new gpPnt2d();
           
            newPoint.X = secondPoint2D.X - firstPoint2D.X;
            newPoint.Y = secondPoint2D.Y - firstPoint2D.Y;
            var length = Math.Sqrt(newPoint.X*newPoint.X + newPoint.Y*newPoint.Y);

            newPoint.X = newPoint.X/length*distance;
            newPoint.Y = newPoint.Y/length*distance;

            newPoint.X = firstPoint2D.X + newPoint.X;
            newPoint.Y = firstPoint2D.Y + newPoint.Y;

            return new Point3D(GeomUtils.Point2DTo3D(axis, new gpPnt2d(newPoint.X, newPoint.Y)));
        }

        public static bool BuildFillet(SceneSelectedEntity filletNode1, SceneSelectedEntity filletNode2, Document AnimationDocument, Document Document, double size)
        {
            // get the intersection points and the other points of the original line
            var intersectionPoint = new Point3D();
            var l1p1 = new NodeBuilder(filletNode1.Node.Children[1].Get<ReferenceInterpreter>().Node)[1].TransformedPoint3D;

            var l1p2 = new NodeBuilder(filletNode1.Node.Children[2].Get<ReferenceInterpreter>().Node)[1].TransformedPoint3D;

            var l2p1 = new NodeBuilder(filletNode2.Node.Children[1].Get<ReferenceInterpreter>().Node)[1].TransformedPoint3D;

            var l2p2 = new NodeBuilder(filletNode2.Node.Children[2].Get<ReferenceInterpreter>().Node)[1].TransformedPoint3D;

            if (l1p1.IsEqual(l2p1) || l1p1.IsEqual(l2p2))
            {
                intersectionPoint = l1p1;
            }
            else
                if (l1p2.IsEqual(l2p1) || l1p2.IsEqual(l2p2))
                {
                    intersectionPoint = l1p2;
                }
           
            var sketchBuilder = new SketchCreator(Document, false);
            var intersectionPointBuilder = sketchBuilder.GetPoint(intersectionPoint);

            var vectorL1 = new gpVec(l1p1.GpPnt, l1p2.GpPnt);
            var vectorL2 = new gpVec(l2p1.GpPnt, l2p2.GpPnt);
            var angle = Math.PI - vectorL1.Angle(vectorL2);
            var otherPointLine1 = intersectionPoint.IsEqual(l1p1) ? new NodeBuilder(filletNode1.Node.Children[2].Get<ReferenceInterpreter>().Node) : new NodeBuilder(filletNode1.Node.Children[1].Get<ReferenceInterpreter>().Node);
            var otherPointLine2 = intersectionPoint.IsEqual(l2p1) ? new NodeBuilder(filletNode2.Node.Children[2].Get<ReferenceInterpreter>().Node) : new NodeBuilder(filletNode2.Node.Children[1].Get<ReferenceInterpreter>().Node);
            var distance = size/Math.Tan(angle/2);
          
            var pointOnLine1 = GetPointAtDistance(otherPointLine1, intersectionPointBuilder,
                                                  otherPointLine1[1].TransformedPoint3D.GpPnt.Distance(
                                                      intersectionPoint.GpPnt) - distance);

            var pointOnLine2 = GetPointAtDistance(otherPointLine2, intersectionPointBuilder,
                                                  otherPointLine2[1].TransformedPoint3D.GpPnt.Distance(
                                                      intersectionPoint.GpPnt) - distance);

            //create the first circle. The points where it intersects the original lines are the centers for the other two circles,
            // whose intersections are the original intersection point and the final arc's centre.
           
            var normalOnPlane = sketchBuilder.NormalOnSketch.Value.GpAxis;
            var trsf = sketchBuilder.CurrentSketch.Get<TransformationInterpreter>().CurrTransform;
            normalOnPlane = normalOnPlane.Transformed(trsf);

            //build the 2 helper circles
            var axis1 = new gpAx1(pointOnLine1.GpPnt, normalOnPlane.Direction);
            var axis2 = new gpAx1(pointOnLine2.GpPnt, normalOnPlane.Direction);
            var newCircleWire1 = OccShapeCreatorCode.CreateWireCircle(axis1, size);
            var newCircleWire2 = OccShapeCreatorCode.CreateWireCircle(axis2, size);
            var intersectionCircles = GeomUtils.IntersectionPoints(GeomUtils.ExtractEdge(newCircleWire1), GeomUtils.ExtractEdge(newCircleWire2)).Distinct().ToList();
           
            var length1 = intersectionCircles[0].GpPnt.Distance(intersectionPoint.GpPnt);
            var length2 = intersectionCircles[1].GpPnt.Distance(intersectionPoint.GpPnt);
            
            var arcCentre = length1 > length2
                                ? intersectionCircles[0]
                                : intersectionCircles[1];

            //build the test arc
            var builder = new NodeBuilder(AnimationDocument, FunctionNames.Arc);
            // center
            builder[0].Reference = sketchBuilder.GetPoint(arcCentre).Node;
            builder[1].Reference = sketchBuilder.GetPoint(pointOnLine1).Node;
            builder[2].Reference = sketchBuilder.GetPoint(pointOnLine2).Node;
            builder.ExecuteFunction();
            var line1 = new NodeBuilder(AnimationDocument, FunctionNames.LineTwoPoints);
            line1[0].Reference = sketchBuilder.GetPoint(intersectionPoint).Node;
            line1[1].Reference = sketchBuilder.GetPoint(arcCentre).Node;

            //check that the arc was built with the correct orientation (the minor arc intersects the line between the intersection point and the arc centre)
            var intersectionsHelper = GeomUtils.IntersectionPoints(GeomUtils.ExtractEdge(line1.Shape),
                                                                   GeomUtils.ExtractEdge(builder.Shape));
            BuildArc(Document, sketchBuilder.PointLinker, arcCentre,
                     intersectionsHelper.Count == 0 ? pointOnLine2 : pointOnLine1,
                     intersectionsHelper.Count == 0 ? pointOnLine1 : pointOnLine2);
            AnimationDocument.Root.Remove(line1.Node.Index);
            var secondPoint = intersectionPoint.IsEqual(l1p1) ? l1p2 : l1p1;

            var line = new NodeBuilder(filletNode1.Node);
            line[0].Reference = sketchBuilder.PointLinker.GetPoint(pointOnLine1).Node;
            line[1].Reference = sketchBuilder.PointLinker.GetPoint(secondPoint).Node;
            line.ExecuteFunction();

            secondPoint = intersectionPoint.IsEqual(l2p1) ? l2p2 : l2p1;
           
            line = new NodeBuilder(filletNode2.Node);
            line[0].Reference = sketchBuilder.PointLinker.GetPoint(pointOnLine2).Node;
            line[1].Reference = sketchBuilder.PointLinker.GetPoint(secondPoint).Node;
            bool result = line.ExecuteFunction();

            DeleteNode(sketchBuilder.GetPoint(intersectionPoint).Node, Document);
            return result;
        }
        
        private static NodeBuilder BuildArc(Document document, DocumentPointLinker documentPointLinker,
                                           Point3D firstCoordinate, Point3D secondCoordinate, Point3D thirdCoordinate)
        {
            var firstPoint = documentPointLinker.GetPoint(firstCoordinate);
            var secondPoint = documentPointLinker.GetPoint(secondCoordinate);
            var thirdPoint = documentPointLinker.GetPoint(thirdCoordinate);
            var arc = new NodeBuilder(document, FunctionNames.Arc);
            arc[0].Reference = firstPoint.Node;
            arc[1].Reference = secondPoint.Node;
            arc[2].Reference = thirdPoint.Node;
            arc.ExecuteFunction();
            return arc;
        }

        private static double GetRadiusForChamfer(double desiredLength, double slope1, double slope2)
        {
            if ((double.IsPositiveInfinity(slope1) && slope2 < 0.0001) || (double.IsPositiveInfinity(slope2) && slope1 < 0.0001))
            {
                // we have a right angle parallel to the axes
                return desiredLength * Math.Sqrt(2);
            }
            double angle;
            if (double.IsPositiveInfinity(slope1))
            {
                slope1 = 0;
                angle = Math.Atan(90 - (slope2 - slope1) / (1 + slope2 * slope1));
            }
            else
                if (double.IsPositiveInfinity(slope2))
                {
                    slope2 = 0;
                    angle = Math.Atan(90 - (slope2 - slope1) / (1 + slope2 * slope1));
                }
                else
                {
                    angle = Math.Atan((slope2 - slope1) / (1 + slope2 * slope1));
                }

            return desiredLength / (2 * Math.Sin(angle / 2));
        }

        private static NodeBuilder GetSketchProjectedNode(Document document, Point3D point)
        {
            var sketchBuilder = new SketchCreator(document);
            var projectedPoint = sketchBuilder.Project(point);
            Ensure.IsNotNull(projectedPoint);
            return sketchBuilder.GetPoint(projectedPoint.Value);
        }

        private static NodeBuilder CreateTemporaryBuilder(Document document, string functionName)
        {
            return new NodeBuilder(document, functionName, functionName);
        }

        public static void BuildDimensionForLine(Document document, NodeBuilder line, Point3D firstPoint, Point3D secondPoint)
        {
            var dimensionBuilder = CreateTemporaryBuilder(document, FunctionNames.Dimension);
            dimensionBuilder[0].ReferenceData = new SceneSelectedEntity(line.Node) { ShapeCount = 1, ShapeType = TopAbsShapeEnum.TopAbs_EDGE };
            var middlePoint = GeomUtils.ComputeMidPoint(firstPoint, secondPoint);
            dimensionBuilder[1].Node.Set<Point3DInterpreter>().Value = middlePoint;
            dimensionBuilder[2].Integer = 1;
            dimensionBuilder.Color = line.Color;
            dimensionBuilder.ExecuteFunction();
        }

        public static NodeBuilder BuildLineInDocument(Document previewDocument, bool enableSelection, gpAx1 normalOnPlane, Point3D firstPoint, Point3D secondPoint)
        {
            previewDocument.Transact();

            var firstPointBuilder = GetSketchProjectedNode(previewDocument, firstPoint);
            var secondPointBuilderNode = GetSketchProjectedNode(previewDocument, secondPoint);

            var builder = new NodeBuilder(previewDocument, FunctionNames.LineTwoPoints);
            builder[0].Reference = firstPointBuilder.Node;
            builder[1].Reference = secondPointBuilderNode.Node;
            builder.EnableSelection = enableSelection;
            builder.ExecuteFunction();

            return builder;
        }

        public static bool BuildChamfer(SceneSelectedEntity chamferNode1, SceneSelectedEntity chamferNode2, Document AnimationDocument, Document Document, double size)
        {
            var sketchBuilder = new SketchCreator(Document);
            var animationSketchBuilder = new SketchCreator(AnimationDocument);
            var nba = new NodeBuilder(animationSketchBuilder.CurrentSketch);
            var axis = new gpAx2 { Axis = (sketchBuilder.CurrentSketch.Children[1].Get<Axis3DInterpreter>().Axis.GpAxis) };
            nba[0].TransformedAxis3D = GetTransformedAxis(new NodeBuilder(sketchBuilder.CurrentSketch));
            var firstEdge = GeomUtils.ExtractEdge(chamferNode1.TargetShape());
            var secondEdge = GeomUtils.ExtractEdge(chamferNode2.TargetShape());
            var intersectionPoint = new Point3D();
            var l1p1 = new NodeBuilder(chamferNode1.Node.Children[1].Get<ReferenceInterpreter>().Node)[1].TransformedPoint3D;

            var l1p2 = new NodeBuilder(chamferNode1.Node.Children[2].Get<ReferenceInterpreter>().Node)[1].TransformedPoint3D;

            var l2p1 = new NodeBuilder(chamferNode2.Node.Children[1].Get<ReferenceInterpreter>().Node)[1].TransformedPoint3D;

            var l2p2 = new NodeBuilder(chamferNode2.Node.Children[2].Get<ReferenceInterpreter>().Node)[1].TransformedPoint3D;

            if (l1p1.IsEqual(l2p1) || l1p1.IsEqual(l2p2))
            {
                intersectionPoint = l1p1;
            }
            else
                if (l1p2.IsEqual(l2p1) || l1p2.IsEqual(l2p2))
                {
                    intersectionPoint = l1p2;
                }

            if (intersectionPoint.IsEqual(new Point3D()))
            {
                return false;
            }

            var normalOnPlane = sketchBuilder.NormalOnSketch.Value.GpAxis;
            var trsf = sketchBuilder.CurrentSketch.Get<TransformationInterpreter>().CurrTransform;
            normalOnPlane = normalOnPlane.Transformed(trsf);

            var axis1 = new gpAx1(intersectionPoint.GpPnt, normalOnPlane.Direction);
            var newCircleWire1 = OccShapeCreatorCode.CreateWireCircle(axis1, size);
          
            var circleEdge = GeomUtils.ExtractEdge(newCircleWire1);

            var firstIntPoint = GeomUtils.IntersectionPoints(firstEdge, circleEdge);
            var secondIntPoint = GeomUtils.IntersectionPoints(secondEdge, circleEdge);

            if (firstIntPoint.Count == 0 || secondIntPoint.Count == 0)
                return false;

            // build chamfer line
            var P1 = sketchBuilder.PointLinker.GetPoint(secondIntPoint.First());
            var P2 = sketchBuilder.PointLinker.GetPoint(firstIntPoint.First());
            var line = new NodeBuilder(Document, FunctionNames.LineTwoPoints);
            line[0].Reference = P1.Node;
            line[1].Reference = P2.Node;
            line.ExecuteFunction();

            //rebuild the original line with the new intersection points
            var secondPoint = intersectionPoint.IsEqual(l1p1) ? l1p2 : l1p1;

            P1 = sketchBuilder.PointLinker.GetPoint(firstIntPoint.First());
            P2 = sketchBuilder.PointLinker.GetPoint(secondPoint);
            line = new NodeBuilder(chamferNode1.Node);
            line[0].Reference = P1.Node;
            line[1].Reference = P2.Node;
            line.ExecuteFunction();

            secondPoint = intersectionPoint.IsEqual(l2p1) ? l2p2 : l2p1;

            P1 = sketchBuilder.PointLinker.GetPoint(secondIntPoint.First());
            P2 = sketchBuilder.PointLinker.GetPoint(secondPoint);
            line = new NodeBuilder(chamferNode2.Node);
            line[0].Reference = P1.Node;
            line[1].Reference = P2.Node;
            bool result = line.ExecuteFunction();
            DeleteNode(sketchBuilder.GetPoint(intersectionPoint).Node, Document);

            return result;
        }

        /// <summary>
        ///   Identifies a selected shape from Context in the tree data
        /// </summary>
        public static Node IdentifySelectedObjectLabel(Node rootLabel)
        {
            var context = rootLabel.Get<DocumentContextInterpreter>().Context;
            var selectedShape = GeomUtils.GetCurrentSelectedShape(context);
            if ((selectedShape == null) || (selectedShape.IsNull))
            {
                return null;
            }
            var result = GeomUtils.IdentifyNode(rootLabel, selectedShape);
            return result == null ? null : result.Node;
        }

        public static void DrawConstraints(Document _document, gpAx2 axis2, double currentX, double currentY, bool[] constraints)
        {
            NodeBuilder wireBuilder;
            var wires = new List<NodeBuilder>();
            if (constraints[2])
            {
                wireBuilder = new NodeBuilder(_document, FunctionNames.WireTwoPoints);
                wireBuilder[0].TransformedPoint3D = GeomUtils.Point2DTo3D(axis2, currentX + 1.5, currentY + 1.5);
                wireBuilder[1].TransformedPoint3D = GeomUtils.Point2DTo3D(axis2, currentX + 2.5, currentY + 1.5);
                wires.Add(wireBuilder);

                wireBuilder = new NodeBuilder(_document, FunctionNames.WireTwoPoints);
                wireBuilder[0].TransformedPoint3D = GeomUtils.Point2DTo3D(axis2, currentX + 1.5, currentY + 1);
                wireBuilder[1].TransformedPoint3D = GeomUtils.Point2DTo3D(axis2, currentX + 2.5, currentY + 1);
                wires.Add(wireBuilder);
                currentX += 1.5;
            }
            if (constraints[3])
            {
                wireBuilder = new NodeBuilder(_document, FunctionNames.WireTwoPoints);
                wireBuilder[0].TransformedPoint3D = GeomUtils.Point2DTo3D(axis2, currentX + 1.5, currentY + 1.5);
                wireBuilder[1].TransformedPoint3D = GeomUtils.Point2DTo3D(axis2, currentX + 2.5, currentY + 1.5);
                wires.Add(wireBuilder);

                wireBuilder = new NodeBuilder(_document, FunctionNames.WireTwoPoints);
                wireBuilder[0].TransformedPoint3D = GeomUtils.Point2DTo3D(axis2, currentX + 2, currentY + 0.5);
                wireBuilder[1].TransformedPoint3D = GeomUtils.Point2DTo3D(axis2, currentX + 2, currentY + 1.5);
                wires.Add(wireBuilder);
                currentX += 1.5;
            }
            if (constraints[0])
            {
                wireBuilder = new NodeBuilder(_document, FunctionNames.WireTwoPoints);
                wireBuilder[0].TransformedPoint3D = GeomUtils.Point2DTo3D(axis2, currentX + 1.5, currentY + 2.5);
                wireBuilder[1].TransformedPoint3D = GeomUtils.Point2DTo3D(axis2, currentX + 2.5, currentY + 2.5);
                wires.Add(wireBuilder);
                currentX += 1.5;
            }
            if (constraints[1])
            {
                wireBuilder = new NodeBuilder(_document, FunctionNames.WireTwoPoints);
                wireBuilder[0].TransformedPoint3D = GeomUtils.Point2DTo3D(axis2, currentX + 2, currentY + 0.5);
                wireBuilder[1].TransformedPoint3D = GeomUtils.Point2DTo3D(axis2, currentX + 2, currentY + 1.5);
                wires.Add(wireBuilder);
                currentX += 1.5;
            }
            foreach (var nb in wires)
            {
                nb.Color = Color.Black;
                nb.EnableSelection = false;
                nb.ExecuteFunction();
            }
        }

        public static IEnumerable<Node> GetCutNodeBaseExtrudeNodes(NodeBuilder cutNode)
        {
            var affectedNodes = cutNode.Dependency[3].ReferenceList;
            foreach(var sse in affectedNodes)
            {
                if (sse.Node.Get<FunctionInterpreter>().Name == FunctionNames.Extrude)
                    yield return sse.Node;
                else
                if (sse.Node.Get<FunctionInterpreter>().Name == FunctionNames.Cut)
                   foreach(var node in GetCutNodeBaseExtrudeNodes(new NodeBuilder(sse.Node)))
                        yield return node;
            }
        }

        public static void UpdateSketchesOnFaces(NodeBuilder Builder)
        {
            var sketchNode = FindSketchNode(Builder.Node);
            new NodeBuilder(sketchNode).ExecuteFunction();
            var document = sketchNode.Root.Get<DocumentContextInterpreter>().Document;
            var _3DNodes = new List<string>() { FunctionNames.Extrude, FunctionNames.Cut, FunctionNames.Boolean, FunctionNames.Fillet };
            if(!_3DNodes.Contains(Builder.FunctionName))
            {
                foreach (var node in document.Root.ChildrenList)
                {
                    var nb = new NodeBuilder(node);
                    if (nb.FunctionName == FunctionNames.Extrude || nb.FunctionName == FunctionNames.Pipe || nb.FunctionName == FunctionNames.Cut)
                    {
                        if (nb.Dependency[0].ReferenceBuilder.Node != null && nb.Dependency[0].ReferenceBuilder.Node.Index == sketchNode.Index)
                        {
                            Builder = nb;
                        }
                    }
                }
            }
            var affectedNodes = new List<NodeBuilder>();
            foreach (var node in document.Root.ChildrenList)
            {
                var builder = new NodeBuilder(node);
                if (builder.FunctionName == FunctionNames.Sketch)
                {
                    if (builder.Dependency[2].ReferenceBuilder.Node != null &&
                        builder.Dependency[2].ReferenceBuilder.Node.Index == Builder.Node.Index)
                        affectedNodes.Add(builder);
                }
            }
            foreach (var node in affectedNodes)
            {
                var currentDirection = GeomUtils.ExtractDirection(node.Shape);
                var baseSketch = node.Dependency[2].ReferenceBuilder.Dependency[0].ReferenceBuilder;
                var baseSketchAxisLocation = GetTransformedAxis(baseSketch);
                var faces = GeomUtils.ExtractFaces(node.Dependency[2].ReferenceBuilder.Shape);
                var face = faces[node.Dependency[3].Integer];
                var newPlane = GeomUtils.ExtractPlane(face);
                var newAxis = newPlane.Axis;
                var orientation = face.Orientation();
                if (orientation == TopAbsOrientation.TopAbs_REVERSED)
                    newAxis.Direction = newAxis.Direction.Reversed;
                if (Math.Abs(currentDirection.X - newAxis.Direction.X) < Precision.Confusion &&
                    Math.Abs(currentDirection.Y - newAxis.Direction.Y) < Precision.Confusion &&
                    Math.Abs(currentDirection.Z - newAxis.Direction.Z) < Precision.Confusion)
                {
                    var T = node.Node.Get<TransformationInterpreter>();
                    var trsf = T.CurrTransform;
                    trsf.SetTranslation(baseSketchAxisLocation.Location, newAxis.Location);
                    var transformation = node.Node.Set<TransformationInterpreter>();
                    transformation.CurrTransform = trsf;
                }
                else
                {
                    var T = new gpTrsf();
                    var oldSystemAxis = new gpAx3(baseSketchAxisLocation.Location, baseSketchAxisLocation.Direction);
                    var newSystemAxis = new gpAx3(newAxis.Location, newAxis.Direction);
                    T.SetTransformation(oldSystemAxis, newSystemAxis);
                    var transformation = node.Node.Set<TransformationInterpreter>();
                    transformation.CurrTransform = T.Inverted;
                }
                node.ExecuteFunction();
            }
        }

        public static Point3D PointForNewArcRadius(NodeBuilder builder, Point3D center, Point3D point, double radius)
        {
            var sketchAxis = GetTransformedAxis(new NodeBuilder(FindSketchNode(builder.Node)));
            var angle = GetArcAngle(center, point, builder);
            var axis = new gpAx2(sketchAxis.Location, sketchAxis.Direction);
            var center2D = GeomUtils.Point3DTo2D(axis, center);
            var y = center.Y + Math.Sin(angle) * radius;
                
            var x = center2D.X + (y- center2D.Y) / Math.Tan(angle);
            return new Point3D(GeomUtils.Point2DTo3D(axis, new gpPnt2d(x, y)));
        }
    }
}