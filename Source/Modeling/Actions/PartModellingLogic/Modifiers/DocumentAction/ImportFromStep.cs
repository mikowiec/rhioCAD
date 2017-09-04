#region Usings

using System.Windows.Forms;
using MetaActionsInterface;
using Naro.Infrastructure.Library.DocumentHelpers;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class ImportFromStep : DrawingAction3D
    {
        private OpenFileDialog _fileDialog;

        public ImportFromStep()
            : base(ModifierNames.ImportFromStep)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            _fileDialog = new OpenFileDialog {Filter = @"*.step|*.step"};
            var result = _fileDialog.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                BackToNeutralModifier();
                return;
            }
            SaveCommonCodes.LoadStepFile(_fileDialog.FileName, Document);
            UpdateView();
            RebuildTreeView();
            BackToNeutralModifier();
        }

        public override void OnDeactivate()
        {
            _fileDialog = null;
            base.OnDeactivate();
        }
    }
}