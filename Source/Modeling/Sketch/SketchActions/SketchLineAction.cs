#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MetaActionsInterface;
using Naro.Infrastructure.Interface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using NaroPipes.Constants;
using OccCode;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using PartModellingLogic.Inputs.Naro.Pipes;
using PropertyDescriptorsInterface;
using Resources.PartModelling;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using SketchHinter;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace SketchActions
{
    public class SketchLineAction : SketchBaseAction
    {
        private Point3D _coordinate;

        public SketchLineAction() : base(ModifierNames.Line3D)
        {
        }
        private gpAx1 normalOnPlane;
        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.CoordinateParser, OnCoordinateParser);
        }

        private Node sketchNode;
        public override void OnActivate()
        {
            ActionsGraph[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, ParserStage.Unknown);
            //if (Document.Root.Children.Count == 0)
            //{
            //    sketchNode = CreateDefaultSketchNode(Document);
            //}
            //else
            //{
            //    var currentSketchNode = Document.Root[Document.Root.Get<DocumentContextInterpreter>().ActiveSketch];
            //    sketchNode = currentSketchNode;
            //}
            var sketchBuilder = new SketchCreator(Document, false);
            sketchNode = sketchBuilder.CurrentSketch;
            if (sketchNode == null)
            {
                ActionsGraph.SwitchAction(ModifierNames.StartSketch, ModifierNames.Line3D);
                return;
            }
            Document.Transact();
            SetupHinter(sketchNode);
            normalOnPlane = sketchNode.Children[1].Get<Axis3DInterpreter>().GpAxis;
            var pointBuilder = GetSketchNode(Document, new Point3D(), sketchNode);
            pointBuilder.Visibility = ObjectVisibility.Hidden;
            var builder = new NodeBuilder(Document, FunctionNames.LineTwoPoints);
            builder[0].Reference = pointBuilder.Node;
            builder[1].Reference = pointBuilder.Node;
            builder.ExecuteFunction();
            AddNodeToTree(builder.Node);
            Reset();
            Hinter2D.Populate();
        }

        private void Reset()
        {
            Points.Clear();

            AddNewEmptyPoint();
            ShowHint(ModelingResources.LineStep1);
        }

        private void OnCoordinateParser(DataPackage data)
        {
            var text = (string) data.Data;
            if (text.Contains(","))
            {
                _coordinate = CoordinateParser.ParsePointValue(text, _coordinate);
                AddNewPoint(_coordinate);
                return;
            }
            if (Points.Count == 1) return;
            var firstPoint = Points[0];
            var secondPoint = Points[1];
            var newLenght = CoordinateParser.ParseDoubleArgument(0, text);
            var distanceRatio = newLenght/firstPoint.Distance(secondPoint);
            if (Math.Abs(distanceRatio) < 1e-6)
                return;

            AddNewPoint(GeomUtils.BetweenValue(firstPoint, secondPoint, distanceRatio));
        }


        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
        {
            base.OnMouseUpAction(mouseData);
            switch (Points.Count)
            {
                case 1:
                    ActionsGraph[InputNames.GeometricSolverPipe].Send(NotificationNames.ResetPreviousPoint);
                    break;
                case 2:
                    ShowHint(ModelingResources.LineStep2);
                    break;
            }
            
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            SetCoordinate(mouseData.Point);
            
            if (Points.Count < 2)
            {
                WriteTextOnPos(mouseData.Initial2Dx, mouseData.Initial2Dy, mouseData.Point.ToString()+"\nLength: "+"\nAngle:");
                return;
            }
            PreviewLine();
            WriteTextOnPos(mouseData.Initial2Dx, mouseData.Initial2Dy, mouseData.Point.ToString() + "\nLength: " + Points[0].Distance(Points[1]).ToString("{0.##}")
                + "\nAngle:" + (NodeBuilderUtils.GetArcAngle(Points[0], Points[1], new NodeBuilder(sketchNode)) * 180 / Math.PI).ToString("{0.##}"));
            Hinter2D.Preview(PreviewDocument);
            UpdateView();
        }

        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            AddNewPoint(mouseData.Point);
            RebuildTreeView();
        }

        private void PreviewLine()
        {
            InitSession();
            var builder = NodeBuilderUtils.BuildLineInDocument(Document, false, normalOnPlane, Points[0], Points[1]);
            PreviewLineInDocument(Document, Points[0], Points[1]);
            NodeBuilderUtils.BuildDimensionForLine(Document, builder, Points[0], Points[1]);
        }

        private NodeBuilder BuildLine()
        {
            InitSession();
            return BuildLineInDocument(Document, true, normalOnPlane);
        }

        public NodeBuilder PreviewLineInDocument(Document previewDocument, Point3D firstPoint, Point3D secondPoint)
        {
            var firstPointBuilder = GetSketchNode(previewDocument, firstPoint, sketchNode);
            var secondPointBuilderNode = GetSketchNode(previewDocument, secondPoint, sketchNode);
            var builder = new NodeBuilder(previewDocument, FunctionNames.LineTwoPoints);
            builder[0].Reference = firstPointBuilder.Node;
            builder[1].Reference = secondPointBuilderNode.Node;
            builder.ExecuteFunction();
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.RefreshPropertyTab, builder.Node);
            return builder;
        }

        public override void OnDeactivate()
        {
            InitAnimateSession();
            Reset();
          //  base.OnDeactivate();
        }

        private void AddNewPoint(Point3D coordinate)
        {
            if (Points.Count == 2 && Points[0].IsEqual(coordinate))
                return;
            SetCoordinate(coordinate);
            AddNewEmptyPoint();
            if (Points.Count <= 2) return;
            var builder = BuildLine();
            AddNodeToTree(builder.Node);
       
            Hinter2D.SetOrigin(builder[0].RefTransformedPoint3D);
            Hinter2D.Populate();
            Hinter2D.ApplyAlgorithms(new NodeBuilder(builder[0].Reference));
            Hinter2D.ApplyAlgorithms(new NodeBuilder(builder[1].Reference));

            var axis = NodeBuilderUtils.GetTransformedAxis(new NodeBuilder(sketchNode));
            var result = Hinter2D.ApplyAlgorithms(builder);
            var constraints = new List<NodeBuilder>();
            foreach(var res in result)
            {
                constraints.AddRange(res.constraintNodes);
            }
            foreach(var constraint in constraints)
            {
                if(constraint.FunctionName == Constraint2DNames.ParallelFunction || constraint.FunctionName == Constraint2DNames.PerpendicularFunction)
                {
                    var secondNode = constraint.Dependency[0].Reference.Index == builder.Node.Index ? constraint.Dependency[1].Reference : constraint.Dependency[0].Reference;
                    NodeBuilderUtils.AdddHintsForNode(Document, secondNode, constraint.Node, axis);
                }
            }

            var sseList = constraints.Select(c => new SceneSelectedEntity(c.Node)).ToList();
        
            var newNode = new NodeBuilder(Document, FunctionNames.LineHints);
            newNode[0].Reference = builder.Node;
            newNode[1].ReferenceList = sseList;
            newNode[2].Axis3D = new Axis(axis);
            newNode.Color = Color.Black;
            newNode.Node.Set<TransformationInterpreter>().Translate = new gpPnt();
            if(!newNode.ExecuteFunction())
                Document.Root.Remove(newNode.Node.Index);

            CommitFinal("Added line to scene");
            UpdateView();
            Reset();
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.SelectNode, builder.Node);
        }

        private void SetCoordinate(Point3D coordinate)
        {
            _coordinate = coordinate;
            Points[Points.Count - 1] = coordinate;
        }
    }
}