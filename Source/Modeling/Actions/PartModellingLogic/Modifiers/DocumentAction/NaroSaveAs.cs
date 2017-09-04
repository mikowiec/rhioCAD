#region Usings

using System;
using System.Windows.Forms;
using Naro.Infrastructure.Library.Actions.DocumentAction;
using Naro.Infrastructure.Library.DocumentHelpers;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class NaroSaveAs : DocumentActionBase
    {
        private const string FilterNaroXml = "Naro Xml Document (*.naroxml)|*.naroxml|STEP Files|*.step";

        public NaroSaveAs()
            : base(ModifierNames.FileSaveAs)
        {
            DependsOn(InputNames.FileSaveDialog);
            DependsOn(InputNames.View, OnReceiveView);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            const string inputName = InputNames.FileSaveDialog;
            Inputs[inputName].Send(NotificationNames.SetFilter,
                                   "Naro Xml Document (*.naroxml)|*.naroxml|STEP Files|*.step");
            Inputs[inputName].Send(NotificationNames.ShowSaveAs);
        }

        private void OnReceiveView(DataPackage data)
        {
            Inputs[InputNames.FileSaveDialog].Send(NotificationNames.SetFilter, FilterNaroXml);
            var fileName = Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.GetFile).Get<string>();
            if (string.IsNullOrEmpty(fileName))
            {
                var dialogResult = DialogResult.Cancel;
                try
                {
                    dialogResult = Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.ShowSaveAs).Get<DialogResult>();
                }
                catch{ }
                  
                if (dialogResult == DialogResult.OK)
                    fileName = Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.GetFile).Text;
            }
            SaveCommonCodes.SaveToFile(fileName, Document);
            Document.ResetHistory();
            BackToNeutralModifier();
        }
    }
}