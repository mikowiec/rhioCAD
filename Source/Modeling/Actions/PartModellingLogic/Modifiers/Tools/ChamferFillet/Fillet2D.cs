#region Usings
using System.Collections.Generic;
using NaroBasicPipes.Actions;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroPipes.Constants;
using Resources.PartModelling;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
#endregion

namespace PartModellingLogic.Modifiers.Tools.ChamferFillet
{
    /// <summary>
    ///   Applies a fillet feature on two wires. Works on segments of straight lines and arcs of circles.
    /// </summary>
    public class Fillet2D : ChamferFillet2DBaseAction
    {
        public Fillet2D() : base(ModifierNames.Fillet2D)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Enable);
            Reset();
        }

        private readonly List<SceneSelectedEntity> _filletNodes = new List<SceneSelectedEntity>();

        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
        {
            if (SelectedShapes.Count >= 2)
            {
                return;
            }

            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.BuildSelections, mouseData);
            var filletEntities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();

            SelectedShapes.AddRange(filletEntities);
            if (SelectedShapes.Count != 2)
            {
                ShowHint(ModelingResources.FilletStep2);
                return;
            }

             _filletNodes.Clear();
            _filletNodes.AddRange(SelectedShapes);

            BuildDialog("Fillet Radius");
        }

        protected override void PreviewFillet()
        {
            InitSession();
            bool result;
            var linesChamfer = _filletNodes[0].Node.Get<FunctionInterpreter>().Name == FunctionNames.LineTwoPoints &&
                                _filletNodes[1].Node.Get<FunctionInterpreter>().Name == FunctionNames.LineTwoPoints;
            if (!linesChamfer)
            {
                Builder = new NodeBuilder(Document, FunctionNames.Fillet2D);
                Builder[0].ReferenceList = SelectedShapes;
                Builder[1].Real = SizeWindow.Value;
                Builder[2].Integer = (int)FilletChamferTypes.SimpleFillet2D;
                result = Builder.ExecuteFunction();

                SizeWindow.FailedValue = !result;
            }
            else
            {
                result = NodeBuilderUtils.BuildFillet(_filletNodes[0], _filletNodes[1], AnimationDocument, Document, SizeWindow.Value);
            }
            if (!result)
                InitSession();
            
            AnimationDocument.Revert();
            Send(InputNames.View, NotificationNames.RefreshView);
            Send(InputNames.View, NotificationNames.RebuildTreeView);
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