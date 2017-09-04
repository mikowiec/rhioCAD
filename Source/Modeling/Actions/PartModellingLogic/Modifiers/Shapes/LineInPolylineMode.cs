#region Usings

using System.Collections.Generic;
using MetaActions;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroPipes.Constants;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Shapes
{
    internal class LineInPolylineMode : DrawingLiveShape
    {
        private readonly List<Node> _nodesToAddToTree;
        private NodeBuilder _temporary;

        public LineInPolylineMode()
            : base(ModifierNames.LineInPolylineMode)
        {
            _nodesToAddToTree = new List<Node>();
        }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.CoordinateParser, OnCoordinateParser);
        }

        private Node sketchNode;
        private bool finishDrawing = true;
        public override void OnActivate()
        {
            base.OnActivate();
            Points.Clear();
            Points.Add(new Point3D());
            var sketchBuilder = new SketchCreator(Document, false);
            sketchNode = sketchBuilder.CurrentSketch;
            if (sketchNode == null)
            {
                finishDrawing = false;
                ActionsGraph.SwitchAction(ModifierNames.StartSketch, ModifierNames.LineInPolylineMode);
                return;
            }
            finishDrawing = true;
            var mouseCursorInput = Inputs[InputNames.MouseCursorInput];
            mouseCursorInput.Send(NotificationNames.SetResourceManager, MetaActionResource.ResourceManager);
            mouseCursorInput.Send(NotificationNames.SetCursorName, "polyline.cur");
            Inputs[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, ParserStage.PointAsked);
        }

        public override void OnDeactivate()
        {
            if (!finishDrawing)
                return;
            AddNodeListToTree(_nodesToAddToTree);
            _nodesToAddToTree.Clear();
            _temporary = new NodeBuilder(null);
            base.OnDeactivate();
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            if (Document == null)
                return;
            if (Points.Count < 2)
                return;
            InitSession();
            Points[Points.Count - 1] = mouseData.Point;
            PreviewPolyline(false);

            UpdateView();
        }

        private void OnCoordinateParser(DataPackage data)
        {
            var coordinate = data.Get<Point3D>();
            AddNextPoint(coordinate);
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            var coordinate = mouseData.Point;
            AddNextPoint(coordinate);
        }

        private void AddNextPoint(Point3D coordinate)
        {
            Points[Points.Count - 1] = coordinate;
            Inputs[InputNames.CoordinateParser].Send(NotificationNames.SetLastPoint,
                                                     coordinate);
            BuildPolyline();
            Points.Add(new Point3D());
        }

        private void BuildPolyline()
        {
            InitSession();
            PreviewPolyline(true);
            Document.Commit("Add Line from Polyline");
            UpdateView();
        }

        private void PreviewPolyline(bool selectable)
        {
            if (Points.Count < 2) return;
            var firstPoint = Points[Points.Count - 2];
            var secondPoint = Points[Points.Count - 1];
            AddLine(firstPoint, secondPoint, selectable);
        }

        private NodeBuilder BuildLineInDocument(Document previewDocument, Point3D firstPoint, Point3D lastPoint)
        {
            var sketchBuilder = new SketchCreator(Document);
            var firstPointBuilder = sketchBuilder.GetPoint(firstPoint).Node;
            var secondPointBuilderNode = sketchBuilder.GetPoint(lastPoint).Node;

            var builder = new NodeBuilder(previewDocument, FunctionNames.LineTwoPoints);
            builder[0].Reference = firstPointBuilder;
            builder[1].Reference = secondPointBuilderNode;
            //builder.EnableSelection = false;
            builder.ExecuteFunction();
            return builder;
        }

        private void AddLine(Point3D firstPoint, Point3D lastPoint, bool selectable)
        {
            if (firstPoint.IsEqual(lastPoint))
                return;
            _temporary = BuildLineInDocument(Document, firstPoint, lastPoint);
            if (_temporary.LastExecute && selectable)
                _nodesToAddToTree.Add(_temporary.Node);
            //var result = AutoGroupLogic.TryAutoGroup(Document, _temporary.Node);
            //if (result != null)
            //    _nodesToAddToTree.Add(result);
        }
    }
}