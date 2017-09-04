#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
//using ConstraintsModule;

using ErrorReportCommon.Messages;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
//using NaroSketchAdapter;
using OccCode;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace Naro.Infrastructure.Library.Geometry
{
    public static class NodeUtils
    {
        public static gpAx2 GetTranslatedPoint(Node node, int index)
        {
            var builder = new NodeBuilder(node);
            if (index > builder.Count || index < 0)
                return null;
            var axis = new gpAx2();
            if (builder[index].Name == InterpreterNames.Point3D)
            {
                axis.Location = (builder[index].TransformedPoint3D.GpPnt);
                return axis;
            }
            if (builder[index].Name == InterpreterNames.Axis3D)
            {
                axis.Axis = (builder[index].TransformedAxis3D);
                return axis;
            }

            return null;
        }

        public static void RebuildDocumentFaces(Document document)
        {
            for (int i = 0; i < document.Root.Children.Count; i++)
            {
                var node = document.Root[i];
                var nb = new NodeBuilder(node);
                if (nb.FunctionName != FunctionNames.Sketch)
                    continue;
                node.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(node, document);
            }
        }

        /// <summary>
        ///   Detects if the scene selected entities have the same parent node.
        ///   Example: edges of a shape
        /// </summary>
        /// <param name = "nodeList"></param>
        /// <returns></returns>
        public static bool SameParentNodes(List<SceneSelectedEntity> nodeList)
        {
            if (nodeList.Count <= 0)
                return false;

            var firstEntity = nodeList[0].Node;
            foreach (var entity in nodeList)
            {
                if (firstEntity != entity.Node)
                    return false;
            }

            return true;
        }


        public static void Hide(Node node)
        {
            node.Set<DrawingAttributesInterpreter>().Disable();
            node.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.Hidden;
            node.Set<NamedShapeInterpreter>().RegenerateInteractive();
            node.Set<DrawingAttributesInterpreter>().Enable();
        }

        public static void SetSketchTransparency(Document document, Node sketchNode, ObjectVisibility visibility)
        {
            var nodes = GetSketchNodes(sketchNode, document, true);
            foreach (var node in nodes)
            {
                node.Set<DrawingAttributesInterpreter>().Visibility = visibility;
            }
        }

        public static List<Node> GetSketchNodes(Node sketchNode, Document document, bool includeAuxiliaryNodes)
        {
            var results = new List<Node>();
            var root = document.Root;
            var found = true;
            var functionNames = new List<string> { FunctionNames.Circle, FunctionNames.Ellipse, FunctionNames.LineTwoPoints, FunctionNames.Arc, FunctionNames.Arc3P, FunctionNames.Point };
            if(includeAuxiliaryNodes)
                functionNames.Add(FunctionNames.LineHints);
            while (found)
            {
                found = false;
                results.AddRange(from node in root.ChildrenList
                                 let builder = new NodeBuilder(node)
                                 where functionNames.Contains(builder.FunctionName)  
                                 let currentSketchNode = AutoGroupLogic.FindSketchNode(node)
                                 where currentSketchNode.Index == sketchNode.Index
                                 select node);
            }
            return results;
        }

        public static bool NodeIsOnSketch(NodeBuilder nodeBuilder)
        {
            var solids = new List<string>() { FunctionNames.Extrude, FunctionNames.Cut, FunctionNames.Boolean, FunctionNames.Fillet };
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

        public static void RebuildAllSketchFaces(Document document)
        {
            int shapeIndex = 0;
            var nodesToRebuild = new List<Node>();
            foreach (var node in document.Root.Children)
                if (node.Value.Get<FunctionInterpreter>().Name == FunctionNames.Sketch)
                {
                    if (SketchHas3DApplied(document, node.Value, out shapeIndex))
                    {
                        nodesToRebuild.Add(node.Value);
                        
                    }
                }
            foreach(var node in nodesToRebuild)
                node.Children[2].Set<MeshTopoShapeInterpreter>().Shape = AutoGroupLogic.RebuildSketchFace(node, document);
        }

        public static void Translate3DNode(NodeBuilder nodeBuilder, Document document, Point3D translateValue)//, Point3D oldValue)
        {
            {
                var list = NodeBuilderUtils.GetAllContained3DNodesIndexes(nodeBuilder.Node).Distinct().ToList();
                var sketchNodes = new List<Node>();
                //find if we are translating a stack of solids and if so, find the base solid
                foreach (var nodeIndex in list)
                {
                    var node = document.Root[nodeIndex.Key];
                    var shapeNodeBuilder = new NodeBuilder(node);
                    if (FunctionNames.GetSolids().Contains(nodeBuilder.FunctionName))
                        continue;

                    var affectedSketchNode = shapeNodeBuilder.Dependency[0].ReferenceBuilder.Node;

                    if (affectedSketchNode != null)
                    {
                        var nb1 = new NodeBuilder(affectedSketchNode);
                        if(nb1.Dependency[2].Reference == null)
                            sketchNodes.Add(affectedSketchNode);
                    }
                }
                
                // if there are no stacked solids, find the base sketch for the solid we need to translate
                if(sketchNodes.Count == 0)
                {
                    foreach (var nodeIndex in list)
                    {
                        var node = document.Root[nodeIndex.Key];
                        var shapeNodeBuilder = new NodeBuilder(node);
                        if (FunctionNames.GetSolids().Contains(nodeBuilder.FunctionName))
                            continue;

                        var affectedSketchNode = shapeNodeBuilder.Dependency[0].ReferenceBuilder.Node;

                        if (affectedSketchNode != null)
                        {
                            sketchNodes.Add(affectedSketchNode);
                        }
                    }
                }
                if (sketchNodes.Count == 0)
                    return;
                
                // use increments to avoid Cut occ bug 
                foreach (var sketchNode in sketchNodes)
                {
                    sketchNode.Set<DrawingAttributesInterpreter>().Disable();
                    var currentLocation = NodeBuilderUtils.GetTransformedAxis(new NodeBuilder(sketchNode)).Location;
                    
                    var currentValue = translateValue;
                    while (Math.Abs(currentValue.X) > Precision.Confusion ||
                           Math.Abs(currentValue.Y) > Precision.Confusion ||
                           Math.Abs(currentValue.Z) > Precision.Confusion)
                    {
                        var currentTranslate = new Point3D(0, 0, 0);
                        if (Math.Abs(currentValue.X) > 0)
                        {
                            if (Math.Abs(currentValue.X) < 10)
                                currentTranslate.X = currentValue.X;
                            else
                                currentTranslate.X = 10 * Math.Sign(currentValue.X);
                            currentValue.X -= currentTranslate.X;
                        }
                        if (Math.Abs(currentValue.Y) > 0)
                        {
                            if (Math.Abs(currentValue.Y) < 10)
                                currentTranslate.Y = currentValue.Y;
                            else
                                currentTranslate.Y = 10 * Math.Sign(currentValue.Y);
                            currentValue.Y -= currentTranslate.Y;
                        }
                        if (Math.Abs(currentValue.Z) > 0)
                        {
                            if (Math.Abs(currentValue.Z) < 10)
                                currentTranslate.Z = currentValue.Z;
                            else
                                currentTranslate.Z = 10 * Math.Sign(currentValue.Z);
                            currentValue.Z -= currentTranslate.Z;
                        }
                        
                        ApplyTranslate(currentLocation, currentTranslate, sketchNode);
                    }
                    sketchNode.Set<DrawingAttributesInterpreter>().Enable();
                }
            }
        }

        private static void ApplyTranslate(gpPnt currentLocation, Point3D increment, Node sketchNode)
        {
            var currentAxis = NodeBuilderUtils.GetTransformedAxis(new NodeBuilder(sketchNode));

            var trsfCurrent = sketchNode.Get<TransformationInterpreter>().CurrTransform;
            var newPosition = new Point3D(currentAxis.Location.X + increment.X,
                                          currentAxis.Location.Y + increment.Y,
                                          currentAxis.Location.Z + increment.Z);
            var newSystemAxis = new gpAx3(newPosition.GpPnt, currentAxis.Direction);
            gpTrsf T = new gpTrsf();
            T.SetDisplacement(new gpAx3(currentAxis.Location, currentAxis.Direction), newSystemAxis);

            trsfCurrent = T.Multiplied(trsfCurrent);
            sketchNode.Set<TransformationInterpreter>().CurrTransform = trsfCurrent;
            var nb = new NodeBuilder(sketchNode);
            nb.ExecuteFunction();
        }

        public static Node RotateNode(NodeBuilder nodeBuilder, Document document, gpAx1 axis, double angle)
        {
            if (FunctionNames.GetSolids().Contains(nodeBuilder.FunctionName))
            {
                RotateSolids(nodeBuilder, axis, angle);
                return null;
            }
            var sketchNode = nodeBuilder.Dependency[0].ReferenceBuilder.Node;
            var nodes = GetSketchNodes(sketchNode, document, true);

            foreach (var node in nodes)
            {
                var nb = new NodeBuilder(node);
                if(nb.FunctionName != FunctionNames.Point)
                    RotateSketchNode(nb, axis, angle);
                //var transformInterpreter = node.Get<TransformationInterpreter>();
                //transformInterpreter.RotateAroundAxis(axis, angle);
                //var nb1 = new NodeBuilder(node);
                //if (nb1.Node != null)
                //    nb1.ExecuteFunction();
            }
            return sketchNode;
        }

        public static void RotateSolids(NodeBuilder nodeBuilder, gpAx1 axis, double angle)
        {
            var transformInterpreter = nodeBuilder.Node.Get<TransformationInterpreter>();
            transformInterpreter.RotateAroundAxis(axis, angle);
            var nb1 = new NodeBuilder(nodeBuilder.Node);
            if (nb1.Node != null)
                nb1.ExecuteFunction();
        }

        public static void RotateSketchNode(NodeBuilder nodeBuilder, gpAx1 axis, double angle)
        {
            for (int i = 0; i < nodeBuilder.Dependency.Count; i++)
            {
                if (nodeBuilder.Dependency[i].Name == InterpreterNames.Reference)
                {
                    var pointInterpreter =
                        nodeBuilder.Dependency[i].Node.Get<ReferenceInterpreter>().Node.Get<TransformationInterpreter>();
                    pointInterpreter.RotateAroundAxis(axis, angle);
                    var nb1 = new NodeBuilder(nodeBuilder.Dependency[i].Node.Get<ReferenceInterpreter>().Node);

                    if (nb1.Node != null)
                        nb1.ExecuteFunction();
                }
                if (nodeBuilder.Dependency[i].Name == InterpreterNames.Point3D)
                {
                    nodeBuilder.Dependency[i].TransformedPoint3D = new Point3D(
                        nodeBuilder.Dependency[i].TransformedPoint3D.GpPnt.Rotated(axis, angle));
                }
            }
            if (nodeBuilder.FunctionName == FunctionNames.Circle)
            {
                // we need to rotate the circle wire; if we don't, it will remain parallel to the original plane

                //sets the correct angle, but also translates the circle
                var rotationInterpreter = nodeBuilder.Node.Get<TransformationInterpreter>();
                rotationInterpreter.RotateAroundAxis(axis, angle);
                var nb3 = new NodeBuilder(nodeBuilder.Node);

                if (nb3.Node != null)
                    nb3.ExecuteFunction();
                // revert the translation, as the position is already set by the center dependency
                var gravityCenter = GeomUtils.ExtractGravityCenter(nodeBuilder.Shape);
                var translateValue = nodeBuilder.Dependency[0].RefTransformedPoint3D.SubstractCoordinate(gravityCenter);
                rotationInterpreter.ApplyTranslateWith(translateValue);
            }

            var nb2 = new NodeBuilder(nodeBuilder.Node);

            if (nb2.Node != null)
                nb2.ExecuteFunction();
        }

        public static List<Node> GetPointNodes(Node node)
        {
            var nb = new NodeBuilder(node);
            switch (nb.FunctionName)
            {
                case FunctionNames.LineTwoPoints:
                    return new List<Node>() { nb.Dependency[0].ReferenceBuilder.Node, nb.Dependency[1].ReferenceBuilder.Node };
                case FunctionNames.Circle:
                    return new List<Node>() { nb.Dependency[0].ReferenceBuilder.Node };
                case FunctionNames.Arc:
                    return new List<Node>() { nb.Dependency[0].ReferenceBuilder.Node, nb.Dependency[1].ReferenceBuilder.Node, nb.Dependency[2].ReferenceBuilder.Node };
                case FunctionNames.Point:
                    return new List<Node>() { nb.Node};
            }
            return null;
        }

        public static void TranslateSketchNode(NodeBuilder nodeBuilder, Point3D translateValue, Node sketchNode)//, gpTrsf translation)
        {

            if (nodeBuilder.FunctionName == FunctionNames.Point)
            {
                gpTrsf translation = new gpTrsf();
                var sketchAxisLocation = NodeBuilderUtils.GetTransformedAxis(new NodeBuilder(sketchNode)).Location;
                var newValue = new Point3D(sketchAxisLocation.X + translateValue.X, sketchAxisLocation.Y + translateValue.Y,
                                    sketchAxisLocation.Z + translateValue.Z);
                translation.SetTranslation(sketchAxisLocation, newValue.GpPnt);
                nodeBuilder.Node.Set<TransformationInterpreter>().CurrTransform = translation;
                nodeBuilder.ExecuteFunction();
            }
            else
            {
                var affectedPoints = GetPointNodes(nodeBuilder.Node);
                if (affectedPoints == null)
                    return;
                var sketchAxisLocation = NodeBuilderUtils.GetTransformedAxis(new NodeBuilder(sketchNode)).Location;
                foreach (var point in affectedPoints)
                {
                    var nb = new NodeBuilder(point);
                    var oldValue = nb[1].TransformedPoint3D;
                    var newValue = new Point3D(oldValue.X + translateValue.X, oldValue.Y + translateValue.Y,
                        oldValue.Z + translateValue.Z);
                    var translation = new gpTrsf();
                    translation.SetTranslation(sketchAxisLocation, newValue.GpPnt);
                    nb.Node.Set<TransformationInterpreter>().CurrTransform = translation;
                    nb.ExecuteFunction();
                }
            }
        }

        public static void DisplayTemporaryDimension(Document animationDocument, Node extrusion, bool enableSelection)
        {
            var subShape = new NodeBuilder(animationDocument, FunctionNames.SubShape);
            subShape[0].Reference = extrusion;
            subShape[1].Integer = 1;
            subShape[2].Integer = (int)TopAbsShapeEnum.TopAbs_EDGE;
            subShape.ExecuteFunction();

            if (subShape.Shape == null)
            {
                return;
            }

            var edge = TopoDS.Edge(subShape.Shape);
            var pnt = new Point3D();
            var computedPoint = GeomUtils.CalculateEdgeMidPoint(edge);
            if (computedPoint != null)
                pnt = (Point3D)computedPoint;

            var dimension = new NodeBuilder(animationDocument, FunctionNames.Dimension);
            dimension[0].Reference = subShape.Node;
            dimension[1].TransformedPoint3D = pnt;
            dimension.EnableSelection = enableSelection;
            dimension.ExecuteFunction();

            subShape.Visibility = ObjectVisibility.Hidden;
        }

        public static void TranslateSolids(NodeBuilder nodeBuilder, Point3D translateValue)
        {
            var currentTrsf = nodeBuilder.Node.Get<TransformationInterpreter>();
            var location = new gpPnt(0,0,0).Transformed(currentTrsf.CurrTransform);
            var difference = translateValue.SubstractCoordinate(new Point3D(location));
            var transformationInterpreter = nodeBuilder.Node.Set<TransformationInterpreter>();
            transformationInterpreter.ApplyTranslateWith(difference);
            var nb1 = new NodeBuilder(nodeBuilder.Node);
            if (nb1.Node != null)
                nb1.ExecuteFunction();
        }

        public static List<Node> GetSolidsNodes(Document document)
        {
            var results = new List<Node>();
            var root = document.Root;
            var found = true;
            while (found)
            {
                found = false;
                results.AddRange(from node in root.ChildrenList
                                 let builder = new NodeBuilder(node)
                                 where FunctionNames.GetSolids().Contains(builder.FunctionName)
                                 select node);
            }
            return results;
        }

        public static List<Node> GetVisibleSketchNodes(Document document)
        {
            var results = new List<Node>();
            var visibleNodes = new List<Node>();
            var root = document.Root;
            var found = true;
            while (found)
            {
                found = false;
                results.AddRange(from node in root.ChildrenList
                                 let builder = new NodeBuilder(node)
                                 where FunctionNames.GetSketchShapes().Contains(builder.FunctionName)
                                 select node);
            }
            var sketchNodes = new Dictionary<Node, bool>();
            foreach(var node in results)
            {
                var sketchNode = AutoGroupLogic.FindSketchNode(node);
                if(!sketchNodes.ContainsKey(sketchNode))
                {
                    int index;
                    sketchNodes.Add(sketchNode, SketchHas3DApplied(document, sketchNode, out index));
                }
                if(!sketchNodes[sketchNode])    
                    visibleNodes.Add(node);
            }
            return visibleNodes;
        }

        public static List<Node> GetSketchPoints(Node sketchNode, Document document)
        {
            var results = new List<Node>();
            var root = document.Root;
            var found = true;
            while (found)
            {
                found = false;
                results.AddRange(from node in root.ChildrenList
                                 let builder = new NodeBuilder(node)
                                 where builder.FunctionName == FunctionNames.Point
                                 let currentSketchNode = AutoGroupLogic.FindSketchNode(node)
                                 where currentSketchNode.Index == sketchNode.Index
                                 select node);
            }
            return results;
        }

        public static List<Node> GetAllVisiblePoints(Document document)
        {
            var results = new List<Node>();
            var root = document.Root;
            var found = true;
            while (found)
            {
                found = false;
                results.AddRange(from node in root.ChildrenList
                                 let builder = new NodeBuilder(node)
                                 where builder.FunctionName == FunctionNames.Point
                                 && builder.Visibility == ObjectVisibility.ToBeDisplayed
                                 select node);
            }
            return results;
        }

        public static List<int> GetDocumentSolids(Document document)
        {
            var results = new List<int>();
            var root = document.Root;
            var alreadyApplied = new List<int>();
            var _3dShapesFunctions = new List<string>();
            _3dShapesFunctions.AddRange(new[] { FunctionNames.Sphere, FunctionNames.Box, FunctionNames.Cylinder,
            FunctionNames.Torus, FunctionNames.Cone});
            foreach(var child in root.ChildrenList)
            {
                var builder = new NodeBuilder(child);
                if(builder.FunctionName == FunctionNames.Cut)
                {
                  alreadyApplied.AddRange(child.Children[4].Get<ReferenceListInterpreter>().Nodes.Select(sse => sse.Node.Index));
                    results.Add(child.Index);
                    continue;
                }

                if (builder.FunctionName == FunctionNames.Boolean)
                {
                    alreadyApplied.Add(child.Children[1].Get<ReferenceInterpreter>().Node.Index);
                    alreadyApplied.Add(child.Children[2].Get<ReferenceInterpreter>().Node.Index);
                    results.Add(child.Index);
                    continue;
                }
                if (builder.FunctionName == FunctionNames.Fillet)
                {
                    alreadyApplied.Add(child.Children[1].Get<ReferenceInterpreter>().Node.Index);
                    results.Add(child.Index);
                    continue;
                }
                if(builder.FunctionName == FunctionNames.Extrude)
                {
                    results.Add(child.Index);
                }
                if(_3dShapesFunctions.Contains(builder.FunctionName))
                {
                    results.Add(child.Index);
                }
            }
            
            foreach (var already in alreadyApplied)
                results.Remove(already);
            return results;
        }

        public static List<int> GetDocumentFaces(Document document)
        {
            var results = new List<int>();
            var root = document.Root;
            var found = true;
            while (found)
            {
                found = false;
                results.AddRange(from node in root.ChildrenList
                                 let builder = new NodeBuilder(node)
                                 where builder.FunctionName == FunctionNames.Face
                                 select node.Index);
            }
            return results;
        }

        public static List<int> GetDocumentNodesOfType(Document document, string functionName)
        {
            var results = new List<int>();
            var root = document.Root;
            var found = true;
            while (found)
            {
                found = false;
                results.AddRange(from node in root.ChildrenList
                                 let builder = new NodeBuilder(node)
                                 where builder.FunctionName == functionName
                                 select node.Index);
            }
            return results;
        }

        /// <summary>
        /// Check if a 3D tool was applied to the sketch
        /// </summary>
        /// <returns></returns>
        public static bool SketchHas3DApplied(Document document,Node sketchNode, out int index)
        {
            var root = document.Root;
            index = -1;
            foreach(var node in root.ChildrenList)
            {
                var nb = new NodeBuilder(node);
                if(nb.FunctionName == FunctionNames.Extrude || nb.FunctionName == FunctionNames.Pipe || nb.FunctionName == FunctionNames.Cut)
                {
                    if (nb.Dependency[0].ReferenceBuilder.Node != null && nb.Dependency[0].ReferenceBuilder.Node.Index == sketchNode.Index)
                    {
                        index = nb.Node.Index;
                        return true;
                    }
                }
            }
            
            return false;
        }

        public static bool NodeIsConstraint(int nodeIndex, Document document)
        {
           var nodeBuilder = new NodeBuilder(document.Root[nodeIndex]);
           
            var constraints = Constraint2DNames.GetConstraints();
            if (constraints.Contains(nodeBuilder.FunctionName))
                return true;
            return false;
        }

        public static bool LineHasLengthConstraint(Node line, Node constraint)
        {
            var nbLine = new NodeBuilder(line);
            var nbConstraint = new NodeBuilder(constraint);
            if (nbLine.FunctionName != FunctionNames.LineTwoPoints || nbConstraint.FunctionName != Constraint2DNames.LineLengthFunction)
                return false;

            var linePoints = new List<int> { nbLine.Dependency[0].Reference.Index, nbLine.Dependency[1].Reference.Index };

            var constraintPoints = new List<int>
                               {
                                   nbConstraint.Node.Children[1].Get<ReferenceInterpreter>().Node.Index,
                                   nbConstraint.Node.Children[2].Get<ReferenceInterpreter>().Node.Index
                               };
            if (!constraintPoints.Except(linePoints).Any())
            {
                return true;
            }
            return false;
        }

        public static NodeBuilder GetConstraintDependencies(Node constraint, string currentName)
        {
            var nb = new NodeBuilder(constraint);
            for (int i = 0; i < nb.Dependency.Count; i++)
            {
                if (nb.Dependency[i].Name == InterpreterNames.Reference)
                {
                    if (nb.Dependency[i].ReferenceBuilder.ShapeName != currentName)
                    {
                        return nb.Dependency[i].ReferenceBuilder;
                    }
                }
            }
            return null;
        }

        public static string GetConstraintDependencies(Node constraint)
        {
            string dependencyNames = string.Empty;
            var nb = new NodeBuilder(constraint);
            for(int i=0;i< nb.Dependency.Count;i++)
            {
                if (nb.Dependency[i].Name == InterpreterNames.Reference)
                {
                    dependencyNames += nb.Dependency[i].ReferenceBuilder.ShapeName + " ";
                }
            }
            return dependencyNames;
        }

        public static void Show(Node node)
        {
            node.Set<DrawingAttributesInterpreter>().Disable();
            node.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.ToBeDisplayed;
            node.Set<NamedShapeInterpreter>().RegenerateInteractive();
            node.Set<DrawingAttributesInterpreter>().Enable();
        }

        public static Point3D GetReferencePoint(NodeBuilder builder, int index)
        {
            var dependency = builder.Node.Get<FunctionInterpreter>().Dependency;
            var sourceData = dependency[index].ReferenceData;
            var shapeNode = sourceData.Node;
            var pointIndex = dependency[index].ReferenceData.ShapeCount;

            var soucePointValue =
                ShapeUtils.ExtractShapesPoint(shapeNode, pointIndex);
            return new Point3D(soucePointValue);
        }

        public static bool SyncronizeNodeFunctions(Node firstNode, ref NodeBuilder secondNode)
        {
            var firstDependency = firstNode.Get<FunctionInterpreter>().Dependency;
            var secondDependency = secondNode.Node.Get<FunctionInterpreter>().Dependency;
            var size = firstDependency.Count;
            for (var i = 1; i < size; i++)
            {
                var serializedNode = Document.ReflectTreeMirror(firstDependency.Children[i].Node);
                serializedNode.ApplyOnNode(secondDependency[i].Node);
            }
            return secondNode.ExecuteFunction();
        }

        public static NodeBuilder ApplyToolOnOtherShape(Document document, Node sourceTool, Node destinationShape)
        {
            var oldTool = new NodeBuilder(sourceTool);
            var newTool = new NodeBuilder(document, sourceTool.Get<FunctionInterpreter>().Name);
            if (oldTool[0].Name != InterpreterNames.Reference && oldTool[0].Name != InterpreterNames.ReferenceList)
            {
                NaroMessage.Show("You should pick a tool as source selection");
                return new NodeBuilder(null);
            }
            newTool[0].ReferenceData = new SceneSelectedEntity
                                           {
                                               Node = destinationShape,
                                               ShapeCount = oldTool[0].ReferenceData.ShapeCount,
                                               ShapeType = oldTool[0].ReferenceData.ShapeType
                                           };
            var result = SyncronizeNodeFunctions(sourceTool, ref newTool);
            return result ? newTool : new NodeBuilder(null);
        }

        public static int GetFirstPointIndex(Node node)
        {
            var nb = new NodeBuilder(node);
            int index = 0;
            switch(nb.FunctionName)
            {
                case FunctionNames.LineTwoPoints:
                case FunctionNames.Circle:
                case FunctionNames.Arc:
                    var firstChild =
                        node.Children[1].Get<ReferenceInterpreter>().Node;
                    index = firstChild.Index;

                    break;
                case FunctionNames.Point:
                    index = node.Index;
                    break;
            }
            return index;
        }
    }
}