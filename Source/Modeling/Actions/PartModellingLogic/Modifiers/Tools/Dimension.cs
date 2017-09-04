#region Usings

using System.Collections.Generic;
using System.Drawing;
using MetaActions;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Constants;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public class Dimension : DrawingLiveShape
    {
        private SceneSelectedEntity _currentSelectedEntity;

        public Dimension() : base(ModifierNames.Dimension)
        {
            DependsOn(InputNames.CommandLinePrePusher);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Reset();
            PrePushItems();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Enable);
            var mouseCursorInput = Inputs[InputNames.MouseCursorInput];
            mouseCursorInput.Send(NotificationNames.SetResourceManager, MetaActionResource.ResourceManager);
            mouseCursorInput.Send(NotificationNames.SetCursorName, "dimension.cur");
        }

        public override void OnDeactivate()
        {
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                           TopAbsShapeEnum.TopAbs_SOLID);
            base.OnDeactivate();

        }

        private void PrePushItems()
        {
            var prePusher = Inputs[InputNames.CommandLinePrePusher];
            var result = (List<object>) prePusher.GetData(NotificationNames.GetValue).Data;
            if (result.Count == 0)
                return;
            _currentSelectedEntity = (SceneSelectedEntity) result[0];
            prePusher.Send(NotificationNames.Reset);
        }

        private void Reset()
        {
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                           TopAbsShapeEnum.TopAbs_EDGE);
            _currentSelectedEntity = null;
        }

        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            if (!mouseData.MouseDown)
                return;

            if (_currentSelectedEntity == null)
            {
                var selectedEntities =
                    Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                        <List<SceneSelectedEntity>>();
                if (selectedEntities.Count <= 0) return;
                var shape = selectedEntities[0].TargetShape();
                if (shape.ShapeType == TopAbsShapeEnum.TopAbs_EDGE)
                {
                    _currentSelectedEntity = selectedEntities[0];
                    Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Resume);
                }
            }
            else
            {
                InitSession();

                var builder = DrawDimension(mouseData.Point.GpPnt);
                builder[3].Integer = 1;
                builder.ExecuteFunction();
                // The Dimension node is not visible in the tree view
                builder.Node.Set<TreeViewVisibilityInterpreter>();

                Context.CloseAllContexts(true);

                if (!builder.ExecuteFunction())
                {
                    Document.Revert();
                    BackToNeutralModifier();
                    return;
                }

                if (builder.Dependency[0].ReferenceBuilder.FunctionName == FunctionNames.LineTwoPoints)
                {
                    NodeBuilderUtils.AddLengthConstraint(Document, builder.Dependency[0].ReferenceBuilder);
                }

                if (builder.Dependency[0].ReferenceBuilder.FunctionName == FunctionNames.Circle)
                {
                    NodeBuilderUtils.AddRadiusConstraint(Document, builder.Dependency[0].ReferenceBuilder.Node);
                }

                // Finish the transaction
                Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
                Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Cleanup);
                CommitFinal("Apply dimension");

                // Prepare for a new dimension
                Reset();
            }
        }

        private NodeBuilder DrawDimension(gpPnt mousePoint)
        {
            var builder = CreateTemporaryBuilder(FunctionNames.Dimension);
            builder[0].ReferenceData = _currentSelectedEntity;
            builder[1].Node.Set<Point3DInterpreter>().Value = new Point3D(mousePoint);
            builder.Color = Color.Black;
            builder.ExecuteFunction();
            return builder;
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            if (_currentSelectedEntity == null)
                return;

            InitSession();
            DrawDimension(mouseData.Point.GpPnt);
            UpdateView();
        }
    }
}