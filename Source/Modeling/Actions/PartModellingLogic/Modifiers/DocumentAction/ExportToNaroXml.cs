#region Usings

using System.Collections.Generic;
using System.Windows.Forms;
using ErrorReportCommon.Messages;
using MetaActionsInterface;
using NaroConstants.Names;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class ExportToNaroXml : DrawingAction3D
    {
        private SaveFileDialog _fileDialog;

        public ExportToNaroXml()
            : base(ModifierNames.ExportToNaroXml)
        {
            DependsOn(InputNames.FileSaveDialog);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            _fileDialog = new SaveFileDialog {Filter = @"NaroXml file(*.naroxml)|*.naroxml|All files (*.*)|*.*"};
            var result = _fileDialog.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                BackToNeutralModifier();
                return;
            }
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            if (entities.Count == 0)
            {
                NaroMessage.Show("You should select a shape or more before exporting!");
                BackToNeutralModifier();
                return;
            }
            var nodes = new List<Node>();
            foreach (var entity in entities)
                nodes.Add(entity.Node);

            var existingShapes = new SortedDictionary<int, int>();
            foreach (var node in nodes)
                existingShapes[node.Index] = 1;

            Document.Transact();
            var toRemoveList = new List<Node>(Document.Root.Children.Values);
            foreach (var node in toRemoveList)
                if (!existingShapes.ContainsKey(node.Index))
                    NodeBuilderUtils.DeleteNode(node, Document);
            Document.OptimizeData();
            Document.Commit("Imported file: " + _fileDialog.FileName);
            Document.SaveToXml(_fileDialog.FileName);
            Document.Undo();
            BackToNeutralModifier();
        }

        public override void OnDeactivate()
        {
            _fileDialog = null;
            base.OnDeactivate();
        }
    }
}