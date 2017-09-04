#region Usings

using System.Drawing;
using System.Windows.Controls;
using NaroBasicPipes.Inputs.Layers;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;

using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace MetaActionsInterface
{
    public abstract class DrawingLiveShape : DrawingAction3D
    {
        protected DrawingLiveShape(string modifierName)
            : base(modifierName)
        {
        }

        protected StackPanel RibbonPanel { get; set; }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.GeometricSolverPipe);
            DependsOn(InputNames.CoordinateParser);
            DependsOn(InputNames.NodeSelect, OnNodeSelect);
            DependsOn(InputNames.FastToolbarInput);
        }

        protected virtual void OnTreeNodeSelect(Node node)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            _manager = ActionsGraph[InputNames.View].GetData(NotificationNames.GetLayerManager).Get<OcLayer2DManager>();
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Disable);
            RibbonPanel = ActionsGraph[InputNames.FastToolbarInput].Get<StackPanel>();
        }

        public override void OnDeactivate()
        {
            ShowHint(string.Empty);
            ActionsGraph[InputNames.GeometricSolverPipe].Send(NotificationNames.ResetPreviousPoint);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Enable);
            base.OnDeactivate();
        }

        private void OnNodeSelect(DataPackage data)
        {
            OnTreeNodeSelect(data.Get<Node>());
        }

        public Node CreateDefaultSketchNode(Document Document)
        {

            var sketchBuilder = new SketchCreator(Document);
            //var testSketch = sketchBuilder.Project(new Point3D(0, 0, 0));
            //if (testSketch == null)
            //{
            //    BackToNeutralModifier();
            //    return null;
            //}
            //normalOnPlane = sketchBuilder.NormalOnSketch.Value.GpAxis;
            //var trsf = sketchBuilder.CurrentSketch.Get<TransformationInterpreter>().CurrTransform;
            //normalOnPlane = normalOnPlane.Transformed(trsf);
            var sketchNode = sketchBuilder.CurrentSketch;
            var plane = new gpPln(new gpAx3());
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, plane);
           
            AddNodeToTree(sketchNode);
            Document.Commit("Created default sketch plane"); 
            return sketchNode;
        }

        protected NodeBuilder CreateTemporaryBuilder(string functionName)
        {
            return new NodeBuilder(Document, functionName, functionName);
        }

        protected void DrawLine(Point3D firstPoint, Point3D lastPoint)
        {
            DrawLine(firstPoint, lastPoint, Color.Red);
        }

        protected void DrawLine(Point3D firstPoint, Point3D lastPoint, Color color)
        {
            var temporary = CreateTemporaryBuilder(FunctionNames.DottedLine);
            temporary[0].TransformedPoint3D = firstPoint;
            temporary[1].TransformedPoint3D = lastPoint;
            temporary.Color = color;
            temporary.ExecuteFunction();
        }

        protected void DrawMarkerBox(Point3D lastPoint, double size)
        {
            var temporary = CreateTemporaryBuilder(FunctionNames.Box1P);
            temporary[0].TransformedPoint3D = lastPoint;
            temporary[1].Real = size;
            temporary[2].Real = size;
            temporary[3].Real = size;
            temporary.Color = Color.Red;
            temporary.ExecuteFunction();
        }

        protected NodeBuilder BuildLineInDocument(Document previewDocument, bool enableSelection, gpAx1 normalOnPlane)
        {
            var sketchBuilder = new SketchCreator(previewDocument);

            //var nodeBuilder = new NodeBuilder(sketchBuilder.CurrentSketch);
            //nodeBuilder[0].TransformedAxis3D = normalOnPlane;

            var firstPointBuilder = GetSketchProjectedNode(previewDocument, Points[0]);
            var secondPointBuilderNode = GetSketchProjectedNode(previewDocument, Points[1]);

            var builder = new NodeBuilder(previewDocument, FunctionNames.LineTwoPoints);
            builder[0].Reference = firstPointBuilder.Node;
            builder[1].Reference = secondPointBuilderNode.Node;
            builder.EnableSelection = enableSelection;
            builder.ExecuteFunction();
            return builder;
        }

        protected NodeBuilder GetSketchProjectedNode(Document document, Point3D point)
        {
            var sketchBuilder = new SketchCreator(document);
            //var projectedPoint = sketchBuilder.Project(point);
            //Ensure.IsNotNull(projectedPoint);
            return sketchBuilder.GetPoint(point);
        }
        protected NodeBuilder GetSketchNode(Document document, Point3D point, Node sketchNode)
        {
            var pointBuilder = new NodeBuilder(Document, FunctionNames.Point);
            pointBuilder[0].Reference = sketchNode;
            pointBuilder[1].TransformedPoint3D = point;
            pointBuilder.Color = Color.Orange;
            pointBuilder.ExecuteFunction();
            return pointBuilder;
        }

        protected void InitSession()
        {
            InitDocumentSession();
            InitAnimateSession();
        }

        protected void InitAnimateSession()
        {
            AnimationDocument.Revert();
            AnimationDocument.Transact();
        }

        protected virtual void InitDocumentSession()
        {
            Document.Revert();
            Document.Transact();
        }

        protected void CommitFinal(string reason)
        {
            Document.Commit(reason);
            ClearAnimateHistory();

            Document.Transact();
            Points.Clear();
        }

        protected void ShowHint(string message)
        {
            ActionsGraph[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetHint, message);
        }

        private void ClearAnimateHistory()
        {
            GeomUtils.ClearDocumentHistory(AnimationDocument);
        }
    }
}