#region Usings

using System;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroPipes.Constants;
using PartModellingLogic.UI.Views.Constraints;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Constraints
{
    internal class ConstraintShapeAction : DrawingLiveShape
    {
        private ConstraintShapeDialog _dialog;
        private bool _disableBackToNone;

        public ConstraintShapeAction()
            : base(ModifierNames.ConstraintShapeAction)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Document.Transact();
            CreateDialog();
            DialogSetSelectedNode();
            _disableBackToNone = false;
        }

        private void DialogSetSelectedNode()
        {
            var node = NodeBuilderUtils.IdentifySelectedObjectLabel(Document.Root);
            _dialog.SetNode(node);
        }

        private void CreateDialog()
        {
            _dialog = new ConstraintShapeDialog(Document);
            _dialog.RefreshViewView += Refresh;
            _dialog.Closed += DialogClosed;
            _dialog.Show();
        }

        private void DialogClosed(object sender, EventArgs e)
        {
            Document.Commit("Constraints updated");
            _dialog = null;

            if (!_disableBackToNone)
                BackToNeutralModifier();
        }

        private void Refresh()
        {
            UpdateView();
            RebuildTreeView();
        }

        public override void OnDeactivate()
        {
            _disableBackToNone = true;
            if (_dialog != null)
                _dialog.Close();
            base.OnDeactivate();
        }

        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            if (mouseData.MouseDown) return;
            DialogSetSelectedNode();
        }

        protected override void OnTreeNodeSelect(Node node)
        {
            _dialog.SetNode(node);
        }
    }
}