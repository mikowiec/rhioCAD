#region Usings

using System.Drawing;
using Naro.PartModeling;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;
using NaroPipes.Actions;
using OccCode;

using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Inputs.Naro.Pipes
{
    public class FacePickerVisualFeedbackPipe : PipeBase
    {
        private readonly AISInteractiveContext _context;
        private Document _document;
        private bool _isEnabled;
        private gpAx1 _visualHintAxis;

        public FacePickerVisualFeedbackPipe(AISInteractiveContext context)
            : base(InputNames.FacePickerVisualFeedbackPipe)
        {
            _context = context;
        }

        public override void OnRegister()
        {
            _document = new Document();
            _document.Root.Set<DocumentContextInterpreter>().Context = _context;
            _document.Root.Set<ActionGraphInterpreter>().ActionsGraph = ActionsGraph;
            _visualHintAxis = new gpAx1();
            _isEnabled = false;


            DependsOn(InputNames.FacePickerPlane, HandleNewPlane);
            DependsOn(InputNames.GeometricSolverPipe, HandleMouseEvent);
            DependsOn(InputNames.View);

            AddNotificationHandler(NotificationNames.Enable, OnEnable);
            AddNotificationHandler(NotificationNames.Disable, OnDisable);
        }

        private void OnDisable(DataPackage data)
        {
            Clear();
            Inputs[InputNames.View].Send(NotificationNames.RefreshView);
            _isEnabled = false;
        }

        private void OnEnable(DataPackage data)
        {
            _isEnabled = true;
        }

        public override void OnConnect()
        {
            base.OnConnect();
            _isEnabled = true;
        }

        private void HandleMouseEvent(DataPackage data)
        {
            var mousePosition = data.Get<Mouse3DPosition>();
            _visualHintAxis.Location = (mousePosition.Point.GpPnt);
            DrawHint();
        }

        private void HandleNewPlane(DataPackage data)
        {
            var facePicked = data.Get<TopoDSFace>();
            var plane = GeomUtils.ExtractPlane(facePicked);
            if (plane == null)
                return;
            _visualHintAxis.Direction = (plane.Axis.Direction);
            DrawHint();
        }

        private void DrawHint()
        {
            Clear();
            if (!_isEnabled)
                return;
            _document.Transact();

            var sketchBuilder = new SketchCreator(_document);
            var axis = new Axis(_visualHintAxis);
            var pointBuilder = sketchBuilder.GetPoint(axis.Location);

            var builder = new NodeBuilder(_document, FunctionNames.Circle);
            builder[0].Reference = pointBuilder.Node;
            builder[1].Real = 2;
            builder.Transparency = 0.6;
            builder.Color = Color.Black;
            builder.DisplayMode = AISDisplayMode.AIS_WireFrame;
            builder.EnableSelection = false;
            builder.ExecuteFunction();
            _document.Commit("PreviewPlane");
        }

        private void Clear()
        {
            _document.Undo();
        }

        public override void OnDisconnect()
        {
            Clear();
            Inputs[InputNames.View].Send(NotificationNames.RefreshView);
            _isEnabled = false;
            base.OnDisconnect();
        }
    }
}