#region Usings

using System.Collections.Generic;
using MetaActionsInterface;
using NaroConstants.Names;
using NaroPipes.Constants;
using PartModellingUi.Views.Tools;
using Resources.PartModelling;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Tools.ChamferFillet
{
    public abstract class ChamferFilletBaseAction : DrawingLiveShape
    {
        protected NodeBuilder Builder;
        protected List<SceneSelectedEntity> SelectedShapes = new List<SceneSelectedEntity>();
        protected ToolSizeDoubleWindow SizeWindow;

        protected ChamferFilletBaseAction(string modifierName) : base(modifierName)
        {
        }

        //public override void OnActivate()
        //{
        //    var sketchBuilder = new SketchCreator(Document, false);
        //    var sketchNode = sketchBuilder.CurrentSketch;
        //    if (sketchNode != null)
        //    {
        //        ActionsGraph.SwitchAction(ModifierNames.EndSketch, ModifierNames.Cut);
        //    }
        //}

        protected void BuildDialog(string dialogTitle)
        {
            SizeWindow = new ToolSizeDoubleWindow(1, dialogTitle);
            SizeWindow.OnValueChange += PreviewFillet;
            SizeWindow.OnDialogClosed += OnClosed;
            SizeWindow.Show();
        }

        protected abstract void PreviewFillet();

        private void OnClosed()
        {
            var result = SizeWindow.Result;
            SizeWindow = null;

            // Close all local contexts
            Context.CloseAllContexts(false);
            if (!result)
            {
                Reset();
                BackToNeutralModifier();
                return;
            }

            if (Builder != null)
            {
                if (Builder.FunctionName == FunctionNames.Fillet || Builder.FunctionName == ModifierNames.Chamfer)
                {
                    if (!Builder.ExecuteFunction())
                    {
                        Document.Revert();
                        BackToNeutralModifier();
                        return;
                    }
                    AddNodeToTree(Builder.Node);
                }
            }
            // Finish the transaction
            CommitFinal("Apply Chamfer");
            Reset();
            RebuildTreeView();
     

            BackToNeutralModifier();
        }

        protected void Reset()
        {
            SelectedShapes.Clear();
            ShowHint(ModelingResources.FilletStep1);
        }

        public override void OnDeactivate()
        {
            if (SizeWindow != null)
            {
                SizeWindow.Close();
                SizeWindow = null;
            }
            base.OnDeactivate();
        }
    }
}