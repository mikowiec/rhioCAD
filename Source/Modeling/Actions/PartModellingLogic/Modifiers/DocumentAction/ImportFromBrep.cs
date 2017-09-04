#region Usings

using System.Windows.Forms;
using MetaActionsInterface;
using Naro.Infrastructure.Library.DocumentHelpers;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class ImportFromBrep : DrawingAction3D
    {
        private OpenFileDialog _fileDialog;

        public ImportFromBrep()
            : base(ModifierNames.ImportFromBrep)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            _fileDialog = new OpenFileDialog {Filter = @"*.brep|*.brep"};
            var result = _fileDialog.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                BackToNeutralModifier();
                return;
            }
            SaveCommonCodes.LoadBrepFile(_fileDialog.FileName, Document);
            UpdateView();
            RebuildTreeView();
            BackToNeutralModifier();
        }

        public override void OnDeactivate()
        {
            _fileDialog = null;
        }
    }
}