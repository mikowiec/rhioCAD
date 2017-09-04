#region Usings
using Naro.Infrastructure.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using NaroConstants.Names;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.BRepAlgoAPI;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopExp;
using NaroCppCore.Occ.TopoDS;
using OccCode;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
#endregion

namespace Naro.Infrastructure.Interface.GeomHelpers
{
    public static class AutoGroupLogic
    {
        //private static List<Node> _candidates;
        private static Node _nodeFused;
        private static List<Node> _generated= new List<Node>();
        private static List<List<int>> indexesList = new List<List<int>>();

        private static Node CandidateProcessing(Document document, IList<SceneSelectedEntity> groupCandidates,
                                                Point3D currentPoint, Point3D endPoint,
                                                AutoGroupConnectionGraph connectionGraph, Node sketchNode)
        {
            var shapeList = new List<Node>();
            var root = document.Root;
            var topNode = groupCandidates[groupCandidates.Count - 1].Node.Index;
            if (!connectionGraph.CanConnect.ContainsKey(topNode))
                return null;
            BuildShapeList(groupCandidates, connectionGraph, topNode, root, currentPoint, shapeList);

            foreach (var shapeNode in shapeList)
            {
                var nextPoint = GetNextPoint(shapeNode, currentPoint, sketchNode);
                if (nextPoint == null)
                    continue;
                var entity = new SceneSelectedEntity { Node = shapeNode, ShapeType = TopAbsShapeEnum.TopAbs_WIRE };
                groupCandidates.Add(entity);
                if (((Point3D)nextPoint).IsEqual(endPoint))
                {
                    var indexes = groupCandidates.Select(candidate => candidate.Node.Index).ToList();
                    if (!indexesList.Any(item => new HashSet<int>(item).SetEquals(indexes)))
                        indexesList.Add(indexes);
                }
                else
                {
                    CandidateProcessing(document, groupCandidates, (Point3D)nextPoint, endPoint,
                                                              connectionGraph, sketchNode);
                }
                groupCandidates.RemoveAt(groupCandidates.Count - 1);
            }
            return null;
        }

        private static void BuildShapeList(IList<SceneSelectedEntity> groupCandidates,
                                           AutoGroupConnectionGraph connectionGraph, int topNode, Node root,
                                           Point3D currentPoint, ICollection<Node> shapeList)
        {
            var possibleConnectios = connectionGraph.CanConnect[topNode].Keys;

            foreach (var shapeNodeIndex in possibleConnectios)
            {
                var shapeNode = root[shapeNodeIndex];
                var isCandidate = IsCandidate(groupCandidates, currentPoint, shapeNode);
                if (isCandidate)
                    shapeList.Add(shapeNode);
            }
        }

        private static Node GroupCandidates(Document document, IEnumerable<SceneSelectedEntity> groupCandidates)
        {
            var candidates = new List<SceneSelectedEntity>();
            foreach (var candidate in groupCandidates)
                candidates.Add(candidate);
            var builder = new NodeBuilder(document, FunctionNames.Face);
            builder[0].ReferenceList = candidates;
            var result = builder.ExecuteFunction();
            if (result == false)
            {
                document.Root.Remove(builder.Node.Index);
                return null;
            }

            return builder.Node;
        }

        private static Point3D? GetNextPoint(Node shape, Point3D currentPoint, Node sketchNode)
        {
            Point3D? firstPoint = null;
            Point3D? secondPoint = null;
            //var sketchNode = FindSketchNode(shape);
            var trsf = sketchNode.Get<TransformationInterpreter>().CurrTransform;
            if (!GeomUtils.GetExtremasPoints(shape, ref firstPoint, ref secondPoint))
                return null;
            if (firstPoint == null || secondPoint == null)
                return null;
            firstPoint = new Point3D(firstPoint.Value.GpPnt.Transformed(trsf));
            secondPoint = new Point3D(secondPoint.Value.GpPnt.Transformed(trsf));
            if (((Point3D)firstPoint).IsEqual(currentPoint))
                return secondPoint;

            return ((Point3D)secondPoint).IsEqual(currentPoint) ? firstPoint : null;
        }

        private static Point3D? GetNextPoint(Node shape, Point3D currentPoint)
        {
            Point3D? firstPoint = null;
            Point3D? secondPoint = null;
            var sketchNode = FindSketchNode(shape);
            var trsf = sketchNode.Get<TransformationInterpreter>().CurrTransform;
            if (!GeomUtils.GetExtremasPoints(shape, ref firstPoint, ref secondPoint))
                return null;
            if (firstPoint == null || secondPoint == null)
                return null;
            firstPoint = new Point3D(firstPoint.Value.GpPnt.Transformed(trsf));
            secondPoint = new Point3D(secondPoint.Value.GpPnt.Transformed(trsf));
            if (((Point3D)firstPoint).IsEqual(currentPoint))
                return secondPoint;

            return ((Point3D)secondPoint).IsEqual(currentPoint) ? firstPoint : null;
        }

        private static bool AlreadyExist(IList<SceneSelectedEntity> groupCandidates, Node node)
        {
            for (var i = groupCandidates.Count - 1; i >= 0; i--)
            {
                var groupNode = groupCandidates[i];
                if (node.Index == groupNode.Node.Index)
                    return true;
            }
            return false;
        }

        private static bool IsCandidate(IList<SceneSelectedEntity> groupCandidates, Point3D currentPoint,
                                        Node shapeNode)
        {
            var func = shapeNode.Get<FunctionInterpreter>();

            if (func == null)
                return false;
            if (AlreadyExist(groupCandidates, shapeNode))
                return false;

            var nextPoint = GetNextPoint(shapeNode, currentPoint);
            return nextPoint != null;
        }

        public static Node FindSketchNode(Node shapeNode)
        {
            if (shapeNode == null)
                return null;
            var nodeBuilder = new NodeBuilder(shapeNode);
            var invalidShapes = new List<string> { string.Empty };
            invalidShapes.AddRange(FunctionNames.GetSolids());
            invalidShapes.Add(FunctionNames.VerticalLine);
            invalidShapes.Add(FunctionNames.HorizontalLine);
            invalidShapes.Add(FunctionNames.Spline);
            invalidShapes.Add(FunctionNames.SplinePath);
            invalidShapes.Add(FunctionNames.Face);
            invalidShapes.Add(FunctionNames.Plane);
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

            if (nodeBuilder.FunctionName == FunctionNames.LineHints)
            {
                return FindSketchNode(nodeBuilder[0].Reference);
            }
            if (nodeBuilder.FunctionName == FunctionNames.Trim || nodeBuilder.FunctionName == FunctionNames.Fillet2D)
            {
                return FindSketchNode(nodeBuilder[0].ReferenceList[0].Node);
            }
            var pointBuilder = nodeBuilder[0].ReferenceBuilder;
            if (pointBuilder == null)
                return null;
            if (pointBuilder.FunctionName == FunctionNames.Sketch)
                return pointBuilder.Node;
            var sketchNode = pointBuilder[0].Reference;
            return sketchNode;
        }

        public static Node TryAutoGroup(Document document, Node addedNewShape)
        {
            var sketchNode = FindSketchNode(addedNewShape);
            Point3D? firstPoint = null, lastPoint = null;
            GeomUtils.GetExtremasPoints(addedNewShape, ref firstPoint, ref lastPoint);
            if (firstPoint == null || lastPoint == null)
                return null;
            firstPoint = new Point3D(firstPoint.Value.GpPnt.Transformed(sketchNode.Get<TransformationInterpreter>().CurrTransform));
            lastPoint = new Point3D(lastPoint.Value.GpPnt.Transformed(sketchNode.Get<TransformationInterpreter>().CurrTransform));
            var connections = new AutoGroupConnectionGraph();
            connections.BuildConnectedLinks(document, addedNewShape.Index);
            var addedEntiy = new SceneSelectedEntity { Node = addedNewShape, ShapeType = TopAbsShapeEnum.TopAbs_WIRE };
            var groupCandidates = new List<SceneSelectedEntity> { addedEntiy };

            var interpreter = addedNewShape.Get<TransformationInterpreter>();
            if (interpreter == null)
                return null;
            
            return CandidateProcessing(document, groupCandidates,
                                             (Point3D)firstPoint,
                                             (Point3D)lastPoint,
                                             connections, sketchNode);
        }

        public static TopoDSShape RebuildSketchFace(Node sketchNode, Document document)
        {
            TopoDSShape finalShape = null;
            var results = BuildAutoFaces(sketchNode, document);
            if (results.Count > 0)
            {

                finalShape = results[0];
                for (int i = 1; i < results.Count; i++)
                {
                    var sew = new BRepBuilderAPISewing(1.0e-06, true, true, true, false);
                    sew.Add(finalShape);
                    sew.Add(results[i]);
                    var messg = new MessageProgressIndicator();
                    sew.Perform(messg);

                    finalShape = sew.SewedShape;
                }
            }
            return finalShape;
        }

        /// <summary>
        /// Detects coliding faces in the first list received as parameter and puts them in the second list
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="results"></param>
        private static void DetectColidingCandidates(List<Node> candidates, List<Node> results)
        {
            var shapes = new List<ShapeInfo>();
            int k = 0;
            foreach(var node in candidates)
            {
               
                var shape = node.Get<TopoDsShapeInterpreter>();
                var area = GeomUtils.GetFaceArea(shape.Shape);
                if (area > 0)
                {
                    var shapeInfo = new ShapeInfo {Shape = shape.Shape, Area = area, Node = node, Processed = 0};
                    shapes.Add(shapeInfo);
                }
            }

            shapes = shapes.OrderByDescending(x => x.Area).ToList();
            var iterations = 0;
            for (int i = 0; i < shapes.Count;i++)
            {
                if (shapes[i].Processed == 1)
                    continue;
                for(int j=i+1;j<shapes.Count;j++)
                {
                    
                    if (shapes[j].Processed == 1)
                        continue;
                    var cut = new BRepAlgoAPICommon(shapes[i].Shape, shapes[j].Shape);
                    var shapeCommon = cut.Shape;
                    var fuse = new BRepAlgoAPIFuse(shapes[i].Shape, shapes[j].Shape);
                    var fusedShape = fuse.Shape;
                    var fuseArea = GeomUtils.GetFaceArea(fusedShape);
                    iterations++;

                    if (Math.Abs(fuseArea - shapes[i].Area) < Precision.Confusion)
                    {
                        if(!results.Contains(shapes[i].Node))
                            results.Add(shapes[i].Node);
                        if (!results.Contains(shapes[j].Node))
                            results.Add(shapes[j].Node);
                        shapes[j].Processed = 1;
                    }
                    //if ((shapeCommon != null) && (!shapeCommon.IsNull))
                    //{
                    //    var areaCommon = GeomUtils.GetFaceArea(shapeCommon);
                    //    if (Math.Abs(areaCommon - shapes[j].Area) < Precision.Confusion)
                    //    {
                    //        if (RelativePosition(shapes[j].Shape, shapes[i].Shape) == 1 && !results.Contains(shapes[j].Node))
                    //        {
                    //            results.Add(shapes[j].Node);
                    //            shapes[j].Processed = 1;
                    //        }
                    //        if(!results.Contains(shapes[i].Node))
                    //        {
                    //            results.Add(shapes[i].Node);
                    //        }
                    //    }
                    //}
                }
            }
        }


        /// <summary>
        /// 0 - Shapes have no common edges
        /// 1 - Shapes have some edges in common
        /// 2 - Shape1 is inside the other 
        /// 3 - Shape2 is inside the other
        /// </summary>
        /// <param name="shape1"></param>
        /// <param name="shape2"></param>
        /// <returns></returns>
        private static int RelativePosition(TopoDSShape shape1, TopoDSShape shape2)
        {
            var edgesShape1 = GeomUtils.ExtractEdges(shape1);
            var edgesShape2 = GeomUtils.ExtractEdges(shape2);

            if(edgesShape1.Count==1 || edgesShape2.Count == 1)
            {
                var position = ShapeIsInsideShape(shape1, shape2);
                if (position == 1)
                    return 2;
                if (position == 2)
                    return 3;
            }
            int commonEdgesCount = 0;
            for (int i = 0; i < edgesShape1.Count; i++)
            {
                bool found = false;
                for (int j = 0; j < edgesShape2.Count && !found; j++)
                    if (EdgesAreIdentical(edgesShape1[i], edgesShape2[j]))
                    {
                        commonEdgesCount++;
                        found = true;
                    }
            }
            if (commonEdgesCount == edgesShape1.Count)
                return 2;
            if (commonEdgesCount == edgesShape2.Count)
                return 3;
            if (commonEdgesCount > 0)
                return 1;
            return 0;
        }

        private static bool EdgesAreIdentical(TopoDSEdge edge1, TopoDSEdge edge2)
        {
            var pointsEdge1 = GeomUtils.ExtractVertexes(edge1);
            var pointsEdge2 = GeomUtils.ExtractVertexes(edge2);
            if (pointsEdge1.Count != 2 || pointsEdge2.Count != 2)
                return false;
            var p11 = new Point3D(BRepTool.Pnt(pointsEdge1[0]));
            var p12 = new Point3D(BRepTool.Pnt(pointsEdge1[1]));
            var p21 = new Point3D(BRepTool.Pnt(pointsEdge2[0]));
            var p22 = new Point3D(BRepTool.Pnt(pointsEdge2[1]));
            if (p11.IsEqual(p21) && p12.IsEqual(p22))
                return true;
            if (p12.IsEqual(p21) && p11.IsEqual(p22))
                return true;
            return false;
        }

        /// <summary>
        /// Creates a fused face (FaceFuse node) with all the coliding shapes
        /// </summary>
        /// <param name="colidingShapes"></param>
        private static void CreateFusedShape(List<Node> colidingShapes, Document _document)
        {
            var builder = new NodeBuilder(_document, FunctionNames.FaceFuse);
            var colidingList = new List<SceneSelectedEntity>();
            foreach (var node in colidingShapes)
            {
                colidingList.Add(new SceneSelectedEntity(node));
            }

            builder.Dependency[0].ReferenceList = colidingList;
            bool result = builder.ExecuteFunction();
            if (result == false)
            {
                NodeBuilderUtils.DeleteNode(builder.Node, _document);
                _nodeFused = null;
            }
            else
            {
                _nodeFused = builder.Node;
            }

            // The fused face is not visible in the scene, neither in the tree view
            if (_nodeFused != null)
            {
                Hide(_nodeFused);
                _nodeFused.Set<TreeViewVisibilityInterpreter>();
            }
        }

        /// <summary>
        /// Makes a list with the coliding candidates, generates a hidden fused face from them
        /// then generates visible face nodes pointing to the fused shapes
        /// </summary>
        public static List<Node> UpdateFaces(Document _document, List<Node> _candidates)
        {
            _generated.Clear();
            var colidingShapes = new List<Node>();
            DetectColidingCandidates(_candidates, colidingShapes);
            CreateFusedShape(colidingShapes, _document);
            
            int faceNumber;
            var faceExplorer = new TopExpExplorer();
            // Build SubShapes with the Faces resulted after intersecting the candidates
            if (_nodeFused != null)
            {
                var bigFace = _nodeFused.Get<TopoDsShapeInterpreter>().Shape;
                faceNumber = 1;
                
                faceExplorer.Init(bigFace, TopAbsShapeEnum.TopAbs_FACE, TopAbsShapeEnum.TopAbs_SHAPE);

                while (faceExplorer.More)
                {
                    var _faceNode = BuildSubShape(_document, _nodeFused, TopAbsShapeEnum.TopAbs_FACE, faceNumber, true);
                    _generated.Add(_faceNode);
                    faceNumber++;
                    faceExplorer.Next();
                }
            }

            var nonAdjacent = _candidates.Except(colidingShapes);
            foreach(var independent in nonAdjacent)
            {
                faceNumber = 1;
                var shape = independent.Get<TopoDsShapeInterpreter>().Shape;
                faceExplorer = new TopExpExplorer();
                faceExplorer.Init(shape, TopAbsShapeEnum.TopAbs_FACE, TopAbsShapeEnum.TopAbs_SHAPE);
                while (faceExplorer.More)
                {
                    var _faceNode = BuildSubShape(_document, independent, TopAbsShapeEnum.TopAbs_FACE, faceNumber, true);
                    _generated.Add(_faceNode);
                    faceNumber++;
                    faceExplorer.Next();
                }
            }
            if(_nodeFused != null)
                _document.Root.Remove(_nodeFused.Index);
            return _generated;
        }

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
            builder[2].Integer = (int)shapeType;

            if (!builder.ExecuteFunction())
            {
                return null;
            }

            builder.Node.Set<TreeViewVisibilityInterpreter>();
            // Attach an integer attribute to L to memorize it's not displayed
            if (!visible)
                Hide(builder.Node);
            else
                Show(builder.Node);
            return node;
        }

        public static void Show(Node node)
        {
            node.Set<DrawingAttributesInterpreter>().Disable();
            node.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.ToBeDisplayed;
            node.Set<NamedShapeInterpreter>().RegenerateInteractive();
            node.Set<DrawingAttributesInterpreter>().Enable();
        }

        public static void Hide(Node node)
        {
            node.Set<DrawingAttributesInterpreter>().Disable();
            node.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.Hidden;
            node.Set<NamedShapeInterpreter>().RegenerateInteractive();
            node.Set<DrawingAttributesInterpreter>().Enable();
        }

        public static TopoDSShape RebuildFaces(TopoDSShape face)
        {
            if (face == null)
                return null;
            TopoDSShape shape = null;
            if (face.ShapeType == TopAbsShapeEnum.TopAbs_SHELL)
            {
                shape = GeomUtils.ExtractFaces(face)[0];
            }
            else
            {
                if (face.ShapeType == TopAbsShapeEnum.TopAbs_COMPOUND || face.ShapeType == TopAbsShapeEnum.TopAbs_FACE)
                {
                    var faces = GeomUtils.ExtractFaces(face);
                    TopoDSShape finalShape = faces[0];

                    for (int i = 1; i < faces.Count; i++)
                    {
                        var sew = new BRepBuilderAPISewing(1.0e-06, true, true, true, false);
                        sew.Add(finalShape);
                        sew.Add(faces[i]);
                        var messg = new MessageProgressIndicator();
                        sew.Perform(messg);

                        finalShape = sew.SewedShape;
                    }
                    shape = finalShape;
                }
            }
            return shape;
        }

        public static List<TopoDSShape> BuildAutoFaces(Node sketchNode, Document Document)
        {
            var results = new List<Node>();
            var root = Document.Root;
            var circleNodes = new List<int>();
            var nodesOnSketch = new List<Node>();

            // get all 2D wire-based shapes on the sketch
            foreach (var node in root.ChildrenList)
            {
                var builder = new NodeBuilder(node);
                if (builder.FunctionName == FunctionNames.Circle || builder.FunctionName == FunctionNames.Ellipse || builder.FunctionName == FunctionNames.LineTwoPoints || builder.FunctionName == FunctionNames.Arc || builder.FunctionName == FunctionNames.Arc3P)// || builder.FunctionName == FunctionNames.Point)
                {
                    var currentSketchNode = FindSketchNode(node);
                    if (currentSketchNode.Index == sketchNode.Index)
                    {
                        nodesOnSketch.Add(node);
                    }
                }
            }
            indexesList = new List<List<int>>();
            foreach (var node in nodesOnSketch)
            {
               var builder = new NodeBuilder(node);

               if (builder.FunctionName == FunctionNames.Circle || builder.FunctionName == FunctionNames.Ellipse)
               {
                   // ensure the same circle isn't added more than once - if it were, it would be subtracted from itself and would become invisible
                   if (!circleNodes.Contains(node.Index))
                   {
                       circleNodes.Add(node.Index);
                   }
               }

               if (builder.FunctionName == FunctionNames.LineTwoPoints ||
                   builder.FunctionName == FunctionNames.Arc ||
                   builder.FunctionName == FunctionNames.Arc3P)
                {
                    TryAutoGroup(Document, builder.Node);
                }
            }
            var _candidates = new List<Node>();
            foreach (var indexList in indexesList)
            {
                if (indexList.Count < 3)
                    continue;
                if (indexList.Distinct().Count() != indexList.Count)
                    continue;
                //build face 
                var entities = indexList.Select(index => new SceneSelectedEntity { Node = Document.Root[index], ShapeType = TopAbsShapeEnum.TopAbs_WIRE }).ToList();

                var nb = new NodeBuilder(Document, FunctionNames.Face);
                nb[0].ReferenceList = entities;
                nb.ExecuteFunction();
                if (nb.Shape != null)
                {
                    if (GeomUtils.GetFaceArea(nb.Shape) > 0)
                        _candidates.Add(nb.Node);
                    else
                        Document.Root.Remove(nb.Node.Index);
                }
                else
                    Document.Root.Remove(nb.Node.Index);
            }
           
            var generatedFaceNodes = UpdateFaces(Document, _candidates);
            if(generatedFaceNodes != null)
                results.AddRange(generatedFaceNodes);

            var shapesList = new List<TopoDSShape>();
          
            foreach (var node in circleNodes)
            {
                var builder = new NodeBuilder(root[node]);
                var addedEntiy = new SceneSelectedEntity { Node = builder.Node, ShapeType = TopAbsShapeEnum.TopAbs_WIRE };
                var builder2 = new NodeBuilder(Document, FunctionNames.Face);
                builder2[0].ReferenceList = new List<SceneSelectedEntity> { addedEntiy };
                if (builder2.ExecuteFunction())
                {
                    results.Add(builder2.Node);
                }
                else
                {
                    Document.Root.Remove(builder2.Node.Index);
                }
            }

            if (results.Count > 0)
            {
                var shapes = new Dictionary<int, List<int>>();
                for (int i = 0; i < results.Count; i++)
                {
                    shapes.Add(i, new List<int>());
                }

                for (int i = 0; i < results.Count; i++)
                {
                    for (int j = i + 1; j < results.Count; j++)
                    {
                        //var position = ShapeIsInsideShape(new NodeBuilder(results[i]).Shape,
                        //                                  new NodeBuilder(results[j]).Shape);
                        var newMethodValue = 
                            RelativePosition(new NodeBuilder(results[i]).Shape, new NodeBuilder(results[j]).Shape);
                        if (newMethodValue == 2)
                        {
                            // first shape is inside second
                            shapes[j].Add(i);
                            shapes[i].Add(-1);
                        }
                        else
                        {
                            if (newMethodValue == 3)
                            {
                                // second shape is inside first
                                shapes[i].Add(j);
                                shapes[j].Add(-1);
                            }
                        }
                    }
                }

                var facesList = new Dictionary<int, List<int>>();

                for (int i = 0; i < shapes.Count; i++)
                    if (!shapes[i].Contains(-1))
                    {
                        facesList.Add(i, shapes[i]);
                    }

                // end form list
                foreach (int i in facesList.Keys)
                {
                    if (facesList[i].Count == 0)
                    {
                        var nb = new NodeBuilder(results[i]);
                        if(nb.Shape != null)
                        shapesList.Add(nb.Shape);

                    }
                    else
                    {
                        var bigShape = new NodeBuilder(results[i]).Shape;
                        foreach (var inner in facesList[i])
                        {
                            var innerShape = new NodeBuilder(results[inner]).Shape;

                            var subtract = new BRepAlgoAPICut(bigShape, innerShape);
                            if (subtract.IsDone)
                            {
                                bigShape = subtract.Shape;
                            }

                        }
                        var face = GeomUtils.ExtractFaces(bigShape);
                        if (face.Count == 1)
                        {
                            shapesList.Add(face[0]);
                        }
                    }
                }

                foreach (Node node in results)
                {
                    Document.Root.Remove(node.Index);
                }
                if(generatedFaceNodes != null)
                    foreach (Node node in generatedFaceNodes)
                        Document.Root.Remove(node.Index);

                foreach(var node in _candidates)
                    Document.Root.Remove(node.Index);
            }
            return shapesList;
        }



        /// <summary>
        /// Return values:
        /// 0 - no shape is inside the other
        /// 1 - shape1 is inside shape2
        /// 2 - shape2 is inside shape1
        /// </summary>
        /// <param name="shape1"></param>
        /// <param name="shape2"></param>
        /// <returns></returns>
        private static int ShapeIsInsideShape(TopoDSShape shape1, TopoDSShape shape2)
        {
            if (shape1 == null || shape2 == null)
                return -1;
            var area1 = GeomUtils.GetFaceArea(shape1);
            var area2 = GeomUtils.GetFaceArea(shape2);

            var common = new BRepAlgoAPICommon(shape1, shape2);
            if (common.IsDone)
            {
                var shape = common.Shape;
                var commonArea = GeomUtils.GetFaceArea(shape);
                if (Math.Abs(area1 - commonArea) < 0.0001)
                {
                    return 1;
                }

                if (Math.Abs(area2 - commonArea) < 0.0001)
                {
                    return 2;
                }
            }
            return 0;
        }

        private static bool SameOrientation(TopoDSShape face, Node sketchNode)
        {
            var faceDirection = GeomUtils.ExtractDirection(face);
            if (faceDirection == null)
                return false;
            var nodeBuilder = new NodeBuilder(sketchNode);
            var sketchDirection = nodeBuilder[0].Axis3D.GpAxis;
            var opposite = faceDirection.IsOpposite(sketchDirection.Direction, Precision.Angular);
            return (!opposite);
        }

        #region Nested type: AutoGroupConnectionGraph

        private class AutoGroupConnectionGraph
        {
            private readonly Queue<int> _connectionQueue = new Queue<int>();
            private readonly SortedDictionary<int, bool> _visited = new SortedDictionary<int, bool>();
            private SortedDictionary<int, KeyValuePair<Point3D, Point3D>> _extremaPoints;

            public AutoGroupConnectionGraph()
            {
                ResetLinks();
            }

            public SortedDictionary<int, SortedDictionary<int, bool>> CanConnect { get; private set; }

            private void ResetLinks()
            {
                CanConnect = new SortedDictionary<int, SortedDictionary<int, bool>>();
                _extremaPoints = new SortedDictionary<int, KeyValuePair<Point3D, Point3D>>();
            }


            private void AddDirectConnection(int source, int destination)
            {
                if (!CanConnect.ContainsKey(source))
                    CanConnect[source] = new SortedDictionary<int, bool>();
                CanConnect[source][destination] = true;
            }

            private void BuildExremaPointsForShape(NodeBuilder builder)
            {
                Point3D? firstPoint = null;
                Point3D? secondPoint = null;
                if (!GeomUtils.GetExtremasPoints(builder.Node, ref firstPoint, ref secondPoint))
                    return;
                if (firstPoint == null || secondPoint == null)
                    return;
                var pair = new KeyValuePair<Point3D, Point3D>((Point3D)firstPoint, (Point3D)secondPoint);
                _extremaPoints[builder.Node.Index] = pair;
            }

            private static bool CheckPreconditions(NodeBuilder builder)
            {
                if (builder.FunctionName == FunctionNames.Circle)
                    return false;
                return true;
            }

            private void AddConnection(int source, int destination)
            {
                AddDirectConnection(source, destination);
                AddDirectConnection(destination, source);
                if (_visited.ContainsKey(destination)) return;
                _visited[destination] = true;
                _connectionQueue.Enqueue(destination);
            }

            private bool AreConnected(int indexShape1, KeyValuePair<Point3D, Point3D> firstExtrema, int indexShape2)
            {
                if (indexShape1 == indexShape2)
                    return false;
                var extremasPair1 = firstExtrema;
                var extremasPair2 = _extremaPoints[indexShape2];
                return extremasPair1.Value.IsEqual(extremasPair2.Key) ||
                       (extremasPair1.Key.IsEqual(extremasPair2.Value) ||
                        (extremasPair1.Key.IsEqual(extremasPair2.Key) ||
                         extremasPair1.Value.IsEqual(extremasPair2.Value)));
            }

            public void BuildConnectedLinks(Document document, int startIndex)
            {
                ResetLinks();
                foreach (var node in document.Root.Children.Values)
                {
                    var builder = new NodeBuilder(node);
                    if (CheckPreconditions(builder))
                        BuildExremaPointsForShape(builder);
                }
                _connectionQueue.Clear();
                _visited.Clear();
                _connectionQueue.Enqueue(startIndex);
                while (_connectionQueue.Count != 0 && _extremaPoints.Count > 0)
                {
                    var extremaPoint1 = _connectionQueue.Dequeue();
                    var firstExtrema = _extremaPoints[extremaPoint1];
                    foreach (var extremaPoint2 in _extremaPoints.Keys)
                    {
                        if (AreConnected(extremaPoint1, firstExtrema, extremaPoint2))
                            AddConnection(extremaPoint1, extremaPoint2);
                    }
                }
            }
        }

        #endregion
    }

    public class ShapeInfo
    {
        public TopoDSShape Shape;
        public double Area;
        public int Processed;
        public Node Node;
    }
}