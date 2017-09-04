#region Usings
using System.Collections.Generic;
using NaroBasicPipes.Actions;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroPipes.Constants;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
#endregion

namespace PartModellingLogic.Modifiers.Tools.ChamferFillet
{
    public class Chamfer2D : ChamferFilletBaseAction
    {
        public Chamfer2D() : base(ModifierNames.Chamfer2D)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Enable);
            Reset();
        }

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
           
            BuildDialog("Chamfer length");
        }

        private readonly List<SceneSelectedEntity> _filletNodes = new List<SceneSelectedEntity>();

        protected override void PreviewFillet()
        {
            InitSession();
            bool result;
            bool linesChamfer = _filletNodes[0].Node.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.LineTwoPoints &&
                                _filletNodes[1].Node.Get<ShapeFunctionsInterface.Functions.FunctionInterpreter>().Name == FunctionNames.LineTwoPoints;
            if (!linesChamfer)
            {
                Builder = new NodeBuilder(Document, FunctionNames.Fillet2D);
                Builder[0].ReferenceList = SelectedShapes;
                Builder[1].Real = SizeWindow.Value;
                Builder[2].Integer = (int)FilletChamferTypes.SimpleChamfer2D;
                result = Builder.ExecuteFunction();
                SizeWindow.FailedValue = !result;
            }
            else
            {
                result = NodeBuilderUtils.BuildChamfer(_filletNodes[0], _filletNodes[1], AnimationDocument, Document, SizeWindow.Value);
                AnimationDocument.Revert();
            }
            if (!result)
                InitSession();

            Send(InputNames.View, NotificationNames.RefreshView);
           
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