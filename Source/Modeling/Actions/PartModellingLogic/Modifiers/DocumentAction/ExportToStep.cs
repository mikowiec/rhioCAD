#region Usings

using System.Collections.Generic;
using System.Windows.Forms;
using MetaActionsInterface;
using Naro.Infrastructure.Library.DocumentHelpers;
using NaroConstants.Names;
using NaroCppCore.Occ.TopoDS;
using NaroPipes.Constants;

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class ExportToStep : DrawingAction3D
    {
        private SaveFileDialog _fileDialog;

        public ExportToStep()
            : base(ModifierNames.ExportToStep)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.FileSaveDialog);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            _fileDialog = new SaveFileDialog {Filter = @"*.step|*.step"};
            var result = _fileDialog.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                BackToNeutralModifier();
                return;
            }
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();

            var nodes = entities;
            var selectedNodes = new List<TopoDSShape>();

            foreach (var entity in nodes)
            {
                var shapeInterpreter = entity.Node.Get<TopoDsShapeInterpreter>();
                if (shapeInterpreter != null)
                    selectedNodes.Add(shapeInterpreter.Shape);
            }

            NodeBuilderUtils.IdentifySelectedObjectLabel(Document.Root);
            if (selectedNodes.Count != 0)
                MeshTopoShapeInterpreter.SaveShapeToStep(selectedNodes, _fileDialog.FileName);
            else
                SaveCommonCodes.SaveToStep(_fileDialog.FileName, Document);
            BackToNeutralModifier();
        }

        public override void OnDeactivate()
        {
            _fileDialog = null;
            base.OnDeactivate();
        }
    }
}