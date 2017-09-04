#region Usings

using System.Windows.Forms;
using Naro.Infrastructure.Library.Actions.DocumentAction;
using Naro.Infrastructure.Library.DocumentHelpers;
using NaroConstants.Names;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class NaroSave : DocumentActionBase
    {
        private const string FilterNaroXml = "Naro Xml Document (*.naroxml)|*.naroxml|All Files|*.*";

        public NaroSave()
            : base(ModifierNames.FileSave)
        {
            DependsOn(InputNames.FileSaveDialog);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Inputs[InputNames.FileSaveDialog].Send(NotificationNames.SetFilter, FilterNaroXml);
            var fileName = Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.GetFile).Get<string>();
            if (string.IsNullOrEmpty(fileName))
            {
                var dialogResult = DialogResult.Cancel;
                try
                {
                    dialogResult = Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.ShowSaveAs).Get<DialogResult>();
                }
                catch { }
                  
                if (dialogResult == DialogResult.OK)
                    fileName = Inputs[InputNames.FileSaveDialog].GetData(NotificationNames.GetFile).Text;
            }
            SaveCommonCodes.SaveToFile(fileName, Document);

            BackToNeutralModifier();
        }
    }
}