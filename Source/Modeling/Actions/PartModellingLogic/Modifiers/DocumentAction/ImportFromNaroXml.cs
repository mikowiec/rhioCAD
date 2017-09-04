#region Usings

using System.Windows.Forms;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class ImportFromNaroXml : ImportNaroXmlCloneLogic
    {
        private OpenFileDialog _fileDialog;

        public ImportFromNaroXml()
            : base(ModifierNames.ImportFromNaroXml)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            _fileDialog = new OpenFileDialog {Filter = @"NaroCAD Files (*.naroxml)|*.naroxml|All files(*.*)|*.*"};
            var result = _fileDialog.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                BackToNeutralModifier();
                return;
            }
            var document = new Document();
            var loaded = document.LoadFromXml(_fileDialog.FileName);
            if (!loaded)
            {
                ExitAction();
                return;
            }
            Document.Transact();
            foreach (var node in document.Root.Children.Values)
            {
                var builder = new NodeBuilder(node);
                var buildNode = new NodeBuilder(Document, builder.FunctionName);
                ImportedIdMapping[builder.Node.Index] = buildNode.Node.Index;
                BuildMappedShape(builder, buildNode);
            }
            Document.Commit("Imported file: " + _fileDialog.FileName);

            ExitAction();
        }

        private void ExitAction()
        {
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