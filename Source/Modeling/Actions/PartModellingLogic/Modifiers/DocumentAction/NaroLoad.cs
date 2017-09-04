#region Usings

using System.Windows.Forms;
using ErrorReportCommon.Messages;
using Naro.Infrastructure.Library.Actions.DocumentAction;
using Naro.Infrastructure.Library.DocumentHelpers;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Interpreters;
#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class NaroLoad : DocumentActionBase
    {
        private const string FilterNaroXml = "Naro Xml Document (*.naroxml)|*.naroxml|All Files|*.*";

        public NaroLoad()
            : base(ModifierNames.FileOpen)
        {
            DependsOn(InputNames.FileOpenDialog);
            DependsOn(InputNames.FileSaveDialog);
            DependsOn(InputNames.SelectionContainerPipe);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            var shouldExit = SaveFileIfNeeded();
            if (shouldExit)
            {
                BackToNeutralModifier();
                return;
            }
            
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode, TopAbsShapeEnum.TopAbs_SOLID);
            Inputs[InputNames.FileOpenDialog].Send(NotificationNames.SetFilter, FilterNaroXml);
            var dialogResult = Inputs[InputNames.FileOpenDialog].GetData(NotificationNames.Show).Get<DialogResult>();
            if (dialogResult == DialogResult.OK)
            {
                var fileName = Inputs[InputNames.FileOpenDialog].GetData(NotificationNames.GetFile).Text;

                LoadFileContent(fileName);
            }
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                TopAbsShapeEnum.TopAbs_FACE);
            ActionsGraph.SwitchAction(ModifierNames.EndSketch);
            BackToNeutralModifier();
        }

        private void LoadFileContent(string fileName)
        {
            Document.Transact();
          
            Document.Root.RemoveAllChildren();
            Document.Commit("Remove all nodes to reduce propagations");
            Document.LoadFromXml(fileName);
     
            Document.Root.Get<DocumentContextInterpreter>().ActiveSketch = -1;
            Document.Commit("reset active sketch");
            UpdateView();
            RebuildTreeView();
            Document.ResetHistory();
        }

        private bool SaveFileIfNeeded()
        {
            var shouldExit = false;
            var madeChanges = Document.HistoryCount > 0;
            if (madeChanges)
            {
                var result = NaroMessage.Show(
                    "You made changes. Do you want to save them?",
                    "NaroCAD", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel)
                    shouldExit = true;
                if (result == DialogResult.Yes)
                {
                    Inputs[InputNames.FileSaveDialog].Send(NotificationNames.SetFilter, FilterNaroXml);
                    var dialogResult =
                        Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.ShowSaveAs).Get<DialogResult>();
                    if (dialogResult == DialogResult.OK)
                    {
                        var fileName = Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.GetFile).Text;
                        SaveCommonCodes.SaveToFile(fileName, Document);
                    }
                }
            }
            return shouldExit;
        }
    }
}