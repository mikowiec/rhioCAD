#region Usings

using System.Collections.Generic;
using System.Drawing;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Inputs.Naro.Pipes
{
    public class FacePickerPipe : InteractiveWorkPipe
    {
        private TopoDSFace _face;

        public FacePickerPipe()
            : base(InputNames.FacePickerPlane)
        {
        }

        private TopoDSFace Face
        {
            get { return _face; }
            set
            {
                if (InteractiveWorkSuspended) return;
                if (_face == value) return;

                if ((_face != null) && (!_face.IsNull) && (value != null) && (!value.IsNull) && _face.IsSame(value))
                    return;

                _face = value;
                NotifyListeners(_face);
            }
        }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.SelectionContainerPipe, DetectFaceUnderMouse);
            DependsOn(InputNames.Mouse3DEventsPipe);
            AddNotificationHandler(NotificationNames.LockPlane, OnLockPlane);
        }

        private void NotifyListeners(TopoDSFace face)
        {
            var plane = GeomUtils.ExtractPlane(face);
            if (plane != null)
                Inputs[InputNames.Mouse3DEventsPipe].Send(NotificationNames.SetPlane, plane);

            AddData(face);
        }

        private void OnLockPlane(DataPackage dataPackage)
        {
            Send(NotificationNames.Suspend);
            Face = dataPackage.Get<TopoDSFace>();
        }

        public override void OnConnect()
        {
            base.OnConnect();
            Face = null;
            if (Face != null)
                AddData(Face);
        }

        private void DetectFaceUnderMouse(DataPackage data)
        {
            if (InteractiveWorkSuspended) return;
            var mousePosition = data.Get<Mouse3DPosition>();
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.BuildSelections, mousePosition);
            var selectedEntities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            if (selectedEntities.Count <= 0)
            {
                Face = null;
                return;
            }

            var shape = selectedEntities[0].TargetShape();
            if (shape == null)
            {
                Face = null;
                return;
            }
            if (shape.ShapeType == TopAbsShapeEnum.TopAbs_FACE)
                Face = TopoDS.Face(shape);
            var container =
            Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetContainer).Get
                <SelectionContainer>();
        //    BuildDragAxis(container.Document, shape, 1);
        }

        private void BuildDragAxis(Document document, TopoDSShape shape, double extrudeSize)
        {
            var gravityCenter = GeomUtils.ExtractGravityCenter(shape);
            var dir = GeomUtils.ExtractDirection(shape);
            if (dir.XYZ.Z < 0)
                dir.Reverse();
            var vec = new gpVec(dir);
            vec.Normalize();
            vec.Multiply(extrudeSize);

            gravityCenter = GeomUtils.BuildTranslation(gravityCenter, vec);
            var point = new gpPnt(dir.XYZ);
            var gravityAxis = new Axis(gravityCenter, new Point3D(point));
            DrawDragAxis(document, gravityAxis, 5, 2);
            // _normalPlane = BuildNormalPlane(dir, gravityAxis);
        }


        private NodeBuilder _axisBuilder;

        private void DrawDragAxis(Document document, Axis xAxis, double length, double width)
        {

            _axisBuilder = new NodeBuilder(document, FunctionNames.AxisHandle);
            _axisBuilder[1].Axis3D = xAxis;
            _axisBuilder[2].Real = length;
            _axisBuilder[3].Real = width;
            _axisBuilder.Color = Color.DarkViolet;
            _axisBuilder.Transparency = 0.2;
            _axisBuilder.ExecuteFunction();
        }

        protected override void StopInteractiveDetection()
        {
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode, PreviousSelectionMode);
        }

        protected override void StartInteractiveDetection()
        {
            Face = null;

            var container =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetContainer).Get
                    <SelectionContainer>();
            PreviousSelectionMode = container.CurrentSelectionMode;
            ////
            
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                           TopAbsShapeEnum.TopAbs_FACE);
        }

        protected override void Cleanup()
        {
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Cleanup);
        }
    }
}
