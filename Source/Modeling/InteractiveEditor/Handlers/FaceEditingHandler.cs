#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows;
using Naro.Infrastructure.Interface.AppUtils;
using Naro.Infrastructure.Library.Geometry;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using NaroSketchAdapter.Views;
using OccCode;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace InteractiveEditor.Handlers
{
    public class FaceEditingHandler : GenericEditingShapeHandler
    {
        public override int EditingPointsCount()
        {
            return 1;
        }

        public override string GetHandleTypeAtIndex(int index)
        {
            return FunctionNames.AxisHandle;
        }

        private Color solidColor;

        public override gpAx2 GetPointLocation(int index)
        {
            var shape = SelectedEntity.TargetShape();
            if (shape == null)
                return null;
            var gravityCenter = GeomUtils.ExtractGravityCenter(shape);
            var dir = GeomUtils.ExtractDirection(shape);
            if (dir == null)
                return null;
            var orientation = shape.Orientation();
            if (orientation != TopAbsOrientation.TopAbs_REVERSED)
                dir.Reverse();
            solidColor = new NodeBuilder(SelectedEntity.Node).Color;
            return new gpAx2(gravityCenter.GpPnt, dir);
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            if (SelectedEntity.TargetShape() == null)
                return;
            var faceToChangeIndex = 0;
            Node nodeToChange = null;
            var faceShape = new TopoDSShape();
            if (SelectedEntity.Node.Get<FunctionInterpreter>().Name == FunctionNames.Cut)
            {
                var nb = new NodeBuilder(SelectedEntity.Node);
                var affectedShapes = NodeBuilderUtils.GetCutNodeBaseExtrudeNodes(nb).ToList();//nb.Dependency[3];
                var clickedPlane = GeomUtils.ExtractPlane(SelectedEntity.TargetShape());
                if (clickedPlane == null)
                    return;
                foreach (var node in affectedShapes)
                {
                    var faces = GeomUtils.ExtractFaces(new NodeBuilder(node).Shape);
                    int count = 1;
                    foreach (var face in faces)
                    {
                        var direction = GeomUtils.ExtractPlane(face);
                        if (direction == null)
                        {
                            count++;
                            continue;
                        }
                        count++;
                        if (direction.Axis.Direction.IsParallel(clickedPlane.Axis.Direction, Precision.Confusion))
                        {
                            var projectedPnt = GeomUtils.ProjectPointOnPlane(direction.Location, clickedPlane, Precision.Confusion);
                            if (projectedPnt.IsEqual(direction.Location, Precision.Confusion))
                            {
                                faceShape = face;
                                break;
                            }
                        }
                    }

                    // if the face matches the clicked plane, count will be > 0 and will hold the face index on the extruded solid
                    if(count > 0)
                    {
                        faceToChangeIndex = count-1;
                        nodeToChange = node;
                        break;
                    }
                }
            }
            if (SelectedEntity.Node.Get<FunctionInterpreter>().Name == FunctionNames.Extrude)
            {
                faceToChangeIndex = SelectedEntity.ShapeCount;
                nodeToChange = SelectedEntity.Node;
                faceShape = SelectedEntity.TargetShape();
            }
            
            if (prevFaceCount < 0)
                prevFaceCount = faceToChangeIndex;
            if (faceToChangeIndex != prevFaceCount)
                return;
            if (nodeToChange == null)
                return;
            var distance = 0.0;
            var numberOfFaces = GeomUtils.ExtractFaces(new NodeBuilder(nodeToChange).Shape).Count;
            if (faceToChangeIndex == numberOfFaces) //top of shape
               {
                   distance = GeomUtils.CalculateDistance(vertex.Point.GpPnt,
                                                           new NodeBuilder(nodeToChange).Dependency[0].
                                                               ReferenceBuilder.Shape);
                   
                        var extrudeNb = new NodeBuilder(nodeToChange);
                        if (Math.Abs(distance) < Precision.Confusion)
                            distance = 0.1;
                        extrudeNb.Dependency[2].Real = distance;
                        extrudeNb.ExecuteFunction();
                    }

                    if (faceToChangeIndex == (numberOfFaces - 1))
                    {
                      
                    // bottom of shape - sketch which was extruded
                        var extrudeNb = new NodeBuilder(nodeToChange);
                        var extrudeHeight = extrudeNb.Dependency[2].Real;
                        var baseSketch = extrudeNb.Dependency[0].ReferenceBuilder;
                        var faces = GeomUtils.ExtractFaces(extrudeNb.Shape);
                        var topFace = faces[numberOfFaces-1];
                        var distanceTopFace = GeomUtils.CalculateDistance(vertex.Point.GpPnt,
                                   topFace);
                        distance = GeomUtils.CalculateDistance(vertex.Point.GpPnt,
                            SelectedEntity.TargetShape());
             
                        var dirBottomFace = GeomUtils.ExtractDirection(SelectedEntity.TargetShape());
                        var orientationBottomFace = SelectedEntity.TargetShape().Orientation();
                        if (orientationBottomFace != TopAbsOrientation.TopAbs_REVERSED)
                            dirBottomFace.Reverse();
                        var bottomFaceGravityCenter = GeomUtils.ExtractGravityCenter(topFace);
                        var vertexOnDir = TransformationInterpreter.ProjectPointOnLine(bottomFaceGravityCenter,
                                                                                       dirBottomFace, vertex.Point).Value;
                        var startPointOnDir = TransformationInterpreter.ProjectPointOnLine(bottomFaceGravityCenter,
                                                                                               dirBottomFace, new Point3D(previousMousePosition)).Value;

                        var vertexvector = new gpVec(startPointOnDir.GpPnt, vertexOnDir.GpPnt);
                        var normalvector = new gpVec(dirBottomFace);
                        var isOpposite = false;
                        try
                        {
                            isOpposite = vertexvector.IsOpposite(normalvector, Precision.Angular);
                        }
                        catch { return; }
                        // calculate new height for the solid
                        var newHeight = 0.0;
                        if (isOpposite)
                            newHeight = Math.Abs(extrudeHeight) - Math.Abs(distance);
                        else
                            newHeight = Math.Abs(extrudeHeight) + Math.Abs(distance);
                        newHeight *= Math.Sign(extrudeHeight);
                        var face = SelectedEntity.TargetShape();
                        if (face == null)
                            return;
              
                        // calculate the new position for the solid
                        var transformation = baseSketch.Node.Get<TransformationInterpreter>().CurrTransform;
                        var locationOld = new gpPnt(0, 0, 0).Transformed(transformation);
                        var shape = SelectedEntity.TargetShape();

                        var dir = GeomUtils.ExtractDirection(shape);
                        var orientation = shape.Orientation();
                        if (orientation != TopAbsOrientation.TopAbs_REVERSED)
                            dir.Reverse();
                        if (isOpposite)
                            dir.Reverse();

                        var locationNew = new gpPnt
                                              {
                                                  X = locationOld.X + dir.X * Math.Abs(distance),
                                                  Y = locationOld.Y + dir.Y * Math.Abs(distance),
                                                  Z = locationOld.Z + dir.Z * Math.Abs(distance)
                                              };
                       
                        // set the new transformation for the base sketch
                        var T = new gpTrsf();
                        var oldSystemAxis = new gpAx3(new gpPnt(0, 0, 0), new gpDir(0, 0, 1));
                        var newSystemAxis = new gpAx3(locationNew, dir);
                        T.SetTransformation(oldSystemAxis, newSystemAxis);

                        var transformationSet = baseSketch.Node.Set<TransformationInterpreter>();
                        transformationSet.CurrTransform = T.Inverted;
                     
                        extrudeNb.Dependency[2].Real = newHeight;
                        baseSketch.ExecuteFunction();
                        previousMousePosition = vertex.Point.GpPnt;
                    }

                    if (faceToChangeIndex < (numberOfFaces - 1))
                    {
                        var shape = faceShape;
                        var gravityCenter = GeomUtils.ExtractGravityCenter(shape);
                        var extrudeNb = new NodeBuilder(nodeToChange);
                        var baseSketch = extrudeNb.Dependency[0].ReferenceBuilder;
                        var transformation = baseSketch.Node.Get<TransformationInterpreter>().CurrTransform;
                        var locationSketch = new gpPnt(0, 0, 0).Transformed(transformation);
                        var directionSketch = new gpDir(0, 0, 1).Transformed(transformation);
                        var sketchPlane = new gpPln(locationSketch, directionSketch);
                        var pointOnPlane = new Point3D(GeomUtils.ProjectPointOnPlane(gravityCenter.GpPnt, sketchPlane, Precision.Confusion));
                        var sketchNodes = NodeUtils.GetSketchNodes(baseSketch.Node, baseSketch.Node.Root.Get<DocumentContextInterpreter>().Document, true);
                        NodeBuilder draggedLine = null;
                        foreach(var node in sketchNodes)
                        {
                            var nb = new NodeBuilder(node);
                            if (nb.FunctionName != FunctionNames.LineTwoPoints)
                                continue;
                            var edges = GeomUtils.ExtractEdges(nb.Shape);
                            if (edges.Count != 1)
                                continue;
                            if (GeomUtils.PointIsOnEdge(edges[0], pointOnPlane))
                            {
                                draggedLine = nb;
                                break;
                            }
                        }

                        if(draggedLine != null)
                        {
                           
                            var axisLength = CoreGlobalPreferencesSingleton.Instance.ZoomLevel*10;
                            var faceDirection = GeomUtils.ExtractDirection(shape);
                            var orientation = shape.Orientation();
                            if (orientation != TopAbsOrientation.TopAbs_REVERSED)
                                faceDirection.Reverse();
                            var vertexOnPlane = new Point3D(GeomUtils.ProjectPointOnPlane(vertex.Point.GpPnt, sketchPlane, Precision.Confusion));
                          
                            vertexOnPlane.X = (vertexOnPlane.X ) * Math.Abs(faceDirection.X);
                            vertexOnPlane.Y = (vertexOnPlane.Y ) * Math.Abs(faceDirection.Y);
                            vertexOnPlane.Z = (vertexOnPlane.Z ) * Math.Abs(faceDirection.Z);
                            var pointOnPlaneAxis = new Point3D
                                                       {
                                                           X = pointOnPlane.X*Math.Abs(faceDirection.X),
                                                           Y = pointOnPlane.Y*Math.Abs(faceDirection.Y),
                                                           Z = pointOnPlane.Z*Math.Abs(faceDirection.Z)
                                                       };
                            var translateValue = vertexOnPlane.SubstractCoordinate(pointOnPlaneAxis);
                            NodeUtils.TranslateSketchNode(draggedLine, translateValue, baseSketch.Node);
                            var constraintMapper = new ConstraintDocumentHelper(baseSketch.Node.Root.Get<DocumentContextInterpreter>().Document, baseSketch.Node);
                            constraintMapper.SetMousePosition(draggedLine.Dependency[0].Reference.Index);
                            var error = constraintMapper.ImpactAndSolve(draggedLine.Dependency[1].Node.Get<ReferenceInterpreter>().Node);
                            baseSketch.ExecuteFunction();
                            extrudeNb.Color = solidColor;
                            extrudeNb.ExecuteFunction();
                        }
                   
            }
         
        }
    }
}