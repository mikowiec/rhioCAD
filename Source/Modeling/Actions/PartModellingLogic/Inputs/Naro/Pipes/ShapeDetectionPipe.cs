#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Actions;
using OccCode;

using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Inputs.Naro.Pipes
{
    internal class ShapeDetectionPipe : InteractiveWorkPipe
    {
        private AISInteractiveContext _context;
        private Document _document;
        private bool _prevMouse;
        private SelectionContainer _selectionContainer;

        public ShapeDetectionPipe() : base(InputNames.ShapeDetectionPipe)
        {
        }

        private bool Enabled { get; set; }

        public override void OnRegister()
        {
            base.OnRegister();
            MapInputs();
            MapNotifications();

            var geomUtilsWrapper = new GeomUtilsWrapper();
            _selectionContainer = new SelectionContainer(geomUtilsWrapper);

            Enabled = true;
        }

        private void MapInputs()
        {
            DependsOn(InputNames.Mouse3DEventsPipe);
            DependsOn(InputNames.Context, SourceContextHandler);
            DependsOn(InputNames.Document, SourceDocumentHandler);
            DependsOn(InputNames.GeometricSolverPipe, SourceSolverHandler);
        }

        private void MapNotifications()
        {
            AddNotificationHandler(NotificationNames.Cleanup, OnCleanup);
            AddNotificationHandler(NotificationNames.GetEntities, OnGetEntities);
            AddNotificationHandler(NotificationNames.BuildSelections, OnBuildSelections);
            AddNotificationHandler(NotificationNames.Disable, OnDisabled);
            AddNotificationHandler(NotificationNames.Enable, OnEnabled);
            AddNotificationHandler(NotificationNames.GetContainer, OnGetContainer);
        }

        private void OnGetContainer(DataPackage data)
        {
            ReturnData = new DataPackage(_selectionContainer);
        }

        private void OnEnabled(DataPackage data)
        {
            Enabled = true;
        }

        private void OnDisabled(DataPackage data)
        {
            Enabled = false;
        }

        private void OnBuildSelections(DataPackage dataPackage)
        {
            var data = dataPackage.Get<Mouse3DPosition>();
            _selectionContainer.BuildSelections(data);
        }

        private void OnGetEntities(DataPackage data)
        {
            ReturnData = new DataPackage(_selectionContainer.Entities);
        }

        private void OnCleanup(DataPackage data)
        {
            _selectionContainer.CleanupDetectionEnvironment();
        }

        public override void OnConnect()
        {
            base.OnConnect();

            _selectionContainer.Context = _context;
            _selectionContainer.Document = _document;
        }

        private void SourceSolverHandler(DataPackage data)
        {
            MouseEventHandler(data.Get<Mouse3DPosition>());
            AddData(data.Data);
        }

        private void SourceDocumentHandler(DataPackage data)
        {
            _document = data.Get<Document>();
        }

        private void SourceContextHandler(DataPackage data)
        {
            _context = data.Get<AISInteractiveContext>();
        }

        private void MouseEventHandler(Mouse3DPosition mouseData)
        {
            if (_prevMouse != mouseData.MouseDown)
                MouseClickHandler(mouseData);
            else
                MouseMoveHandler(mouseData);
            _prevMouse = mouseData.MouseDown;
        }

        private void MouseMoveHandler(Mouse3DPosition mousePosition)
        {
            _context.MoveTo(mousePosition.Initial2Dx, mousePosition.Initial2Dy, ViewItems.View);
        }

        private void MouseClickHandler(Mouse3DPosition mousePosition)
        {
            if (!Enabled) return;

            if (mousePosition.MouseDown == false)
                return;

            var correctedMousePosition = CalculateCorrectCoordinate(mousePosition);
            _context.MoveTo(correctedMousePosition.Initial2Dx, correctedMousePosition.Initial2Dy, ViewItems.View);

            if (mousePosition.MouseDown)
            {
                if (mousePosition.ShiftDown)
                    _context.ShiftSelect(true);
                else
                    _context.Select(true);
            }

            // Perform click selection using the corrected coordinate
            _selectionContainer.BuildSelections(correctedMousePosition);
        }

        private Mouse3DPosition CalculateCorrectCoordinate(Mouse3DPosition mousePosition)
        {
            var correctedMousePosition = new Mouse3DPosition(mousePosition);

            var initialSelection = _selectionContainer.CurrentSelectionMode;
            if ((_selectionContainer.CurrentSelectionMode != TopAbsShapeEnum.TopAbs_SOLID)
                && (_selectionContainer.CurrentSelectionMode != TopAbsShapeEnum.TopAbs_COMPOUND))
                return correctedMousePosition;
            _selectionContainer.SwitchSelectionMode(TopAbsShapeEnum.TopAbs_FACE);

            _context.MoveTo(mousePosition.Initial2Dx, mousePosition.Initial2Dy, ViewItems.View);
            _selectionContainer.BuildSelections(mousePosition);
            CorrectCoordinateOnSelectedFace(mousePosition, correctedMousePosition);

            _selectionContainer.SwitchSelectionMode(initialSelection);

            return correctedMousePosition;
        }

        private void CorrectCoordinateOnSelectedFace(Mouse3DPosition mousePosition,
                                                     Mouse3DPosition correctedMousePosition)
        {
            if (_selectionContainer[TopAbsShapeEnum.TopAbs_FACE].Count <= 0) return;
            var face = _selectionContainer[TopAbsShapeEnum.TopAbs_FACE][0].TargetShape();
            var plane = GeomUtils.ExtractPlane(face);
            if (plane == null) return;
            Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, plane);

            double x = 0;
            double y = 0;
            double z = 0;
            var isOnPlane = GeomUtils.ConvertToPlane(ViewItems.View, plane, mousePosition.Initial2Dx,
                                                     mousePosition.Initial2Dy, ref x, ref y, ref z);
            if (isOnPlane)
                correctedMousePosition.Point = new Point3D(x, y, z);
        }
    }
}
