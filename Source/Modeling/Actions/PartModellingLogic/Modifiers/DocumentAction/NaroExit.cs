#region Usings

using System;
using System.IO;
using System.Windows.Forms;
using ErrorReportCommon.Messages;
using Naro.Infrastructure.Library.Actions.DocumentAction;
using Naro.Infrastructure.Library.DocumentHelpers;
using NaroConstants.Names;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    internal class NaroExit : DocumentActionBase
    {
        private const string FilterNaroXml = "Naro Xml Document (*.naroxml)|*.naroxml|STEP Files|*.step";

        public NaroExit()
            : base(ModifierNames.NaroExit)
        {
            DependsOn(InputNames.FileSaveDialog);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            if (Document.HistoryCount == 0)
                ExitFromApplication();
            var result = NaroMessage.Show("Do you want to save your work?", "Exiting NaroCAD",
                                          MessageBoxButtons.YesNoCancel);
            bool saveFileResult = true;
            switch (result)
            {
                case DialogResult.Yes:
                   saveFileResult = SaveFile();
                    break;
                case DialogResult.Cancel:
                    BackToNeutralModifier();
                    return;
            }
            if(saveFileResult)
                ExitFromApplication();
        }

        private static void ExitFromApplication()
        {
            if(File.Exists(NaroAppConstantNames.GuardFileName)) File.Delete(NaroAppConstantNames.GuardFileName);
            //MemMapper.DisplayLeaks();
            Environment.Exit(0);
        }

        private bool SaveFile()
        {
            Inputs[InputNames.FileSaveDialog].Send(NotificationNames.SetFilter, FilterNaroXml);
            var fileName = Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.GetFile).Get<string>();
            if (string.IsNullOrEmpty(fileName))
            {
                var dialogResult =
                    Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.ShowSaveAs).Get<DialogResult>();
                if (dialogResult == DialogResult.OK)
                {   
                    fileName = Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.GetFile).Text;
                    SaveCommonCodes.SaveToFile(fileName, Document);
                    return true;
                }
                Document.ResetHistory();
                BackToNeutralModifier();
                return false;
            }
            return false;
        }
    }
}