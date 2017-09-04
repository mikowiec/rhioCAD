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
    internal class NaroRestart : DocumentActionBase
    {
        private const string FilterNaroXml = "Naro Xml Document (*.naroxml)|*.naroxml|STEP Files|*.step";

        public NaroRestart()
            : base(ModifierNames.NaroRestart)
        {
            DependsOn(InputNames.FileSaveDialog);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            //if (Document.HistoryCount == 0)
            //    ExitFromApplication();
            var result = NaroMessage.Show("NaroCAD can now attempt to update. Do you want to save your work?",
                                          "Restarting NaroCAD",
                                          MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    SaveFile();
                    break;
                case DialogResult.Cancel:
                    BackToNeutralModifier();
                    return;
            }
            RestartApplication();
        }

        private static void RestartApplication()
        {
            File.Delete(NaroAppConstantNames.GuardFileName);
            Environment.Exit(0);
        }

        private void SaveFile()
        {
            Inputs[InputNames.FileSaveDialog].Send(NotificationNames.SetFilter, FilterNaroXml);
            var fileName = Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.GetFile).Get<string>();
            if (string.IsNullOrEmpty(fileName))
            {
                var dialogResult =
                    Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.ShowSaveAs).Get<DialogResult>();
                if (dialogResult == DialogResult.OK)
                    fileName = Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.GetFile).Text;
            }
            SaveCommonCodes.SaveToFile(fileName, Document);
        }
    }
}