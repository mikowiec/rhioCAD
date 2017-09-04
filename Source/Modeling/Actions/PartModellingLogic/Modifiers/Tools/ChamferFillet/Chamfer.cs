#region Usings

using System.Collections.Generic;
using NaroBasicPipes.Actions;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Tools.ChamferFillet
{
    public class Chamfer : ChamferFilletBaseAction
    {
        private SceneSelectedEntity _selectedNode;

        public Chamfer() : base(ModifierNames.Chamfer)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            var sketchBuilder = new SketchCreator(Document, false);
            var sketchNode = sketchBuilder.CurrentSketch;
            if (sketchNode != null)
            {
                ActionsGraph.SwitchAction(ModifierNames.EndSketch, ModifierNames.Fillet);
                return;
            }
            Reset();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            ActionsGraph[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                 TopAbsShapeEnum.TopAbs_EDGE);
        }

        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
        {
            if (_selectedNode != null)
                return;

            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.BuildSelections, mouseData);
            var filletEntities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();

            if (filletEntities.Count <= 0)
            {
                return;
            }
            _selectedNode = filletEntities[filletEntities.Count - 1];

            BuildDialog("Chamfer length");
        }

        protected override void PreviewFillet()
        {
            InitSession();
            Builder = new NodeBuilder(Document, FunctionNames.Fillet);
            Builder[0].Reference = _selectedNode.Node;
            Builder[1].Integer = _selectedNode.ShapeType != TopAbsShapeEnum.TopAbs_EDGE
                                     ? 0
                                     : _selectedNode.ShapeCount;
            Builder[2].Real = SizeWindow.Value;
            Builder[3].Integer = (int) FilletChamferTypes.SimpleChamfer;
            var result = Builder.ExecuteFunction();
            SizeWindow.FailedValue = !result;

            if (!result)
                InitSession();

            Send(InputNames.View, NotificationNames.RefreshView);
        }

        public override void OnDeactivate()
        {
            ActionsGraph[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                                 TopAbsShapeEnum.TopAbs_SOLID);
            Reset();
            _selectedNode = null;
            base.OnDeactivate();
        }
    }
}