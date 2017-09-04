#region Usings

using System;
using System.Linq;
using System.Collections.Generic;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gce;
using NaroCppCore.Occ.gp;
using NaroPipes.Constants;
using OccCode;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Shapes
{
    public class TrimAction : DrawingLiveShape
    {
        private readonly List<SceneSelectedEntity> _trimmingEntities = new List<SceneSelectedEntity>();

        public TrimAction() : base(ModifierNames.Trim)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Enable);
            Reset();
        }

        public List<NodeBuilder> GetTrimResult(Document document, List<SceneSelectedEntity> trimmedEntities, Point3D mouseData)
        {
            var sketchCreator = new SketchCreator(document);
            var trimmingEntities = new List<SceneSelectedEntity>();
            foreach (var node in document.Root.Children)
            {
                if (node.Value != trimmedEntities[0].Node && IsTrimmingWire(node.Value))// && !SameArc(node.Value, trimmedEntities[0].Node))
                {
                    var sse = new SceneSelectedEntity(node.Value) { ShapeType = TopAbsShapeEnum.TopAbs_WIRE };
                    trimmingEntities.Add(sse);
                }
            }

            trimmedEntities[0].ShapeType = TopAbsShapeEnum.TopAbs_WIRE;

            var newNodes = new List<NodeBuilder>();

            if (trimmedEntities[0].Node.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.LineTwoPoints)
            {
                var intervals = ExecuteTrim(trimmedEntities[0], trimmingEntities, mouseData.GpPnt);
                if (intervals == null)
                    return newNodes;
                if (intervals.Count == 0)
                {
                    NodeBuilderUtils.DeleteNode(trimmedEntities[0].Node, Document);
                    return newNodes;
                }
                else
                {
                    if (intervals.Count%2 == 0)
                        for (int i = 0; i < intervals.Count; i += 2)
                        {
                            var builder = new NodeBuilder(document, FunctionNames.LineTwoPoints);
                            builder[0].Reference = sketchCreator.GetPoint(intervals[i]).Node;
                            builder[1].Reference = sketchCreator.GetPoint(intervals[i + 1]).Node;
                            builder.ExecuteFunction();
                            newNodes.Add(builder);
                        }
                }
            }
            else
                if (trimmedEntities[0].Node.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.Circle ||
                    trimmedEntities[0].Node.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.Arc)
                {
                    var centre = new NodeBuilder(trimmedEntities[0].Node.Children[1].Get<ReferenceInterpreter>().Node)[1].TransformedPoint3D;
                    var intervals = ExecuteTrim(trimmedEntities[0], trimmingEntities, mouseData.GpPnt);
                    if (intervals != null && intervals.Count % 2 == 0)
                        for (int i = 0; i < intervals.Count; i += 2)
                        {
                            newNodes.Add(BuildArc(document, centre, intervals[i], intervals[i + 1]));
                        }
                }
                else
                    if (trimmedEntities[0].Node.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.Arc3P)
                    {
                        var point1 = new NodeBuilder(trimmedEntities[0].Node.Children[1].Get<ReferenceInterpreter>().Node)[1].TransformedPoint3D;
                        var point2 = new NodeBuilder(trimmedEntities[0].Node.Children[2].Get<ReferenceInterpreter>().Node)[1].TransformedPoint3D;
                        var point3 = new NodeBuilder(trimmedEntities[0].Node.Children[3].Get<ReferenceInterpreter>().Node)[1].TransformedPoint3D;

                        var gceCirc = new gceMakeCirc(point1.GpPnt, point2.GpPnt, point3.GpPnt);
                        var centre = new Point3D(gceCirc.Value.Axis.Location);
                        var intervals = ExecuteTrim(trimmedEntities[0], trimmingEntities, mouseData.GpPnt);
                        if (intervals != null && intervals.Count % 2 == 0)
                            for (int i = 0; i < intervals.Count; i += 2)
                            {
                                newNodes.Add(BuildArc(document, centre, intervals[i], intervals[i + 1]));
                            }
                    }
                    else
                    {
                        var builder = new NodeBuilder(document, FunctionNames.Trim);
                        builder[0].ReferenceList = trimmingEntities;
                        builder[1].ReferenceData = trimmedEntities[0];
                        var point = sketchCreator.GetPoint(mouseData).Node;
                        builder[2].Reference = point;
                        if (builder.ExecuteFunction())
                        { newNodes.Add(builder); }
                        //NodeBuilderUtils.DeleteNode(point, document);
                        point.Set<DrawingAttributesInterpreter>().Visibility = ObjectVisibility.Hidden;

                    }
            return newNodes;
        }

        private bool SameArc(Node node, Node node2)
        {
            double radius1 = -1.0, radius2 = -1.0;
            var center1 = ExtractCenterAndRadius(node, ref radius1);
            var center2 = ExtractCenterAndRadius(node2, ref radius2);

            if (radius1 < 0 || radius2 < 0)
                return false;
            if (Math.Abs(radius1 - radius2) > Precision.Confusion)
                return false;
            if (Math.Abs(center1.X - center2.X) > Precision.Confusion)
                return false;
            if (Math.Abs(center1.Y - center2.Y) > Precision.Confusion)
                return false;
            if (Math.Abs(center1.Z - center2.Z) > Precision.Confusion)
                return false;
            return true;
        }

        private Point3D ExtractCenterAndRadius(Node node, ref double radius)
        {
            var nb = new NodeBuilder(node);
            if(node.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.Arc)
            {
                var P1 = nb.Dependency[0].RefTransformedPoint3D;
                var P2 = nb.Dependency[1].RefTransformedPoint3D;
                radius = Math.Sqrt((P1.X - P2.X) * (P1.X - P2.X) + (P1.Y - P2.Y) * (P1.Y - P2.Y) + (P1.Z - P2.Z) * (P1.Z - P2.Z));
                return P1;
            }
            if (node.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.Circle)
            {
                radius = nb.Dependency[1].Real;
                return nb.Dependency[0].RefTransformedPoint3D;
            }
            if (node.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.Arc3P)
            {
                var sketchNode = AutoGroupLogic.FindSketchNode(node);
                var sketchAx2 = GeomUtils.ExtractSketchNormal(sketchNode);
                var P1 = GeomUtils.Point3DTo2D(sketchAx2, nb.Dependency[0].RefTransformedPoint3D);
                var P2 = GeomUtils.Point3DTo2D(sketchAx2, nb.Dependency[1].RefTransformedPoint3D);
                var P3 = GeomUtils.Point3DTo2D(sketchAx2, nb.Dependency[2].RefTransformedPoint3D);

                var center = GeomUtils.CircleCenter(P1, P2, P3);
                radius = Math.Sqrt((P1.X - center.X) * (P1.X - center.X) + (P1.Y - center.Y) * (P1.Y - center.Y));
                var centerPoint = GeomUtils.Point2DTo3D(sketchAx2, center);
                return new Point3D(centerPoint);
            }
            return new Point3D(0,0,0);
        }

        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
        {
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.BuildSelections, mouseData);
            var trimmedEntities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            if (trimmedEntities.Count == 0)
            {
                return;
            }

            InitSession();
            Reset();
           
            var newNodes = GetTrimResult(Document, trimmedEntities, mouseData.Point);

            if(newNodes.Count ==0)
            {
                return;
            }

            var shapesGraph = new ShapeGraph(); //DocumentShapesGraph();
            shapesGraph.SetDocument(Document);
            shapesGraph.Update();
            
            // remove all referenced constraints
            var constraints = Document.Root.Children.Where(n => NodeUtils.NodeIsConstraint(n.Value.Index, Document)).ToList();

            foreach (var constraint in constraints)
            {
                var children = new NodeBuilder(constraint.Value).Node.Children;
                if (children.Any(child => child.Value.Get<ReferenceInterpreter>().Node.Equals(trimmedEntities[0].Node)))
                {
                    NodeBuilderUtils.DeleteNode(constraint.Value, Document);
                }
            }

            var nodes = new List<ReferenceInterpreter>();
            // remove all referenced points
            foreach (var child in trimmedEntities[0].Node.Children)
            {
                var node = child.Value.Get<ReferenceInterpreter>();
                if (node == null)
                    continue;
                nodes.Add(node);
            }

            foreach (var nb in newNodes)
            {
                var nodeBuilder = new NodeBuilder(nb.Node);
                nodeBuilder.ExecuteFunction();
                AddNodeToTree(nodeBuilder.Node);
            }

            if (newNodes.First().FunctionName == FunctionNames.Trim)
            {
                NodeUtils.Hide(trimmedEntities[0].Node);
            }
            else
            {
                NodeBuilderUtils.DeleteNode(trimmedEntities[0].Node, Document);
            }

            CommitFinal("Trimmed wire");
            RebuildTreeView();
            UpdateView();
        }

        private NodeBuilder BuildArc(Document document, Point3D centre, Point3D point1, Point3D point2)
        {
            var sketchCreator = new SketchCreator(document);
            var builder = new NodeBuilder(document, FunctionNames.Arc);
            // center
            builder[0].Reference = sketchCreator.GetPoint(centre).Node;
            builder[1].Reference = sketchCreator.GetPoint(point1).Node;
            builder[2].Reference = sketchCreator.GetPoint(point2).Node;
            builder.ExecuteFunction();
            return builder;
        }

        private List<Point3D> ExecuteTrim(SceneSelectedEntity wireToTrim, List<SceneSelectedEntity> trimmingWires, gpPnt clickPoint )
        {
            var profileLocation = wireToTrim.TargetShape().Location();
            var profileTranslation = new gpTrsf();
            var profileTranslationVector = profileLocation.Transformation.TranslationPart.Reversed;
            profileTranslation.TranslationPart = (profileTranslationVector);
            var newProfileLocation = new TopLocLocation(profileTranslation);

            foreach (var wire in trimmingWires)
            {
                if (wire.Node.Get<TopoDsShapeInterpreter>().Shape!= null)
                    wire.Node.Get<TopoDsShapeInterpreter>().Shape.Move(newProfileLocation);
            }
            wireToTrim.Node.Get<TopoDsShapeInterpreter>().Shape.Move(newProfileLocation);
            clickPoint.Translate(profileTranslationVector);

            var trimmingEdges = new List<TopoDSEdge>();
            foreach (var trimming in trimmingWires)
            {
                var trimmingE = GeomUtils.ExtractEdges(trimming.TargetShape());
                if (trimmingE.Count > 0)
                    trimmingEdges.AddRange(trimmingE);
            }
            if (trimmingEdges.Count <= 0)
                return null;

            var resultPoints = GeomUtils.TrimKnownShape(trimmingEdges, wireToTrim, new Point3D(clickPoint));

            return resultPoints;
        }

        private bool IsTrimmingWire(Node node)
        {
            var validTrimmingWires = new List<string> { FunctionNames.LineTwoPoints, FunctionNames.Spline, FunctionNames.Circle, FunctionNames.Arc, FunctionNames.Arc3P, FunctionNames.SplinePath, FunctionNames.Ellipse};
            if(node.Interpreters.Count > 1)
                if (validTrimmingWires.Contains(node.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name))
                    return true;
            return false;
        }

        private void Reset()
        {
            _trimmingEntities.Clear();
            ShowHint(ModelingResources.Trim);
        }

        public override void OnDeactivate()
        {
            Reset();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.EnableAll);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Disable);
            base.OnDeactivate();
        }
    }
}