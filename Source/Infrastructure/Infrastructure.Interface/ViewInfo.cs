#region Usings

using System.Windows.Controls;
using Naro.Infrastructure.Interface.Views;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.V3d;
using NaroPipes.Actions;
using NaroPipes.Constants;

using TreeData.NaroData;

#endregion

namespace Naro.Infrastructure.Interface
{
    public class ViewInfo
    {
        private readonly ActionsGraph _actionsGraph;

        public ViewInfo(ITreeViewControl treeView, ActionsGraph actionGraph)
        {
            TreeView = treeView;
            _actionsGraph = actionGraph;
        }

        public AISInteractiveContext Context { get; set; }
        public V3dViewer Viewer { get; set; }
        public V3dView View { get; set; }
        public Document Document { get; set; }
        private ITreeViewControl TreeView { get; set; }

        public StackPanel RibbonInfoArea { get; set; }


        public void BeginUpdate()
        {
            SwitchToNoneIfNeeded();

            Document.Transact();
        }

        private void SwitchToNoneIfNeeded()
        {
            if (_actionsGraph.CurrentAction.Name != ModifierNames.None)
                _actionsGraph.SwitchAction(ModifierNames.None);
        }

        public void RevertVisualUpdate()
        {
            Document.Revert();
            TreeView.LoadTree(Document.Root);
        }

        public void EndVisualUpdate(string reason)
        {
            Document.Commit(reason);
            SwitchToNoneIfNeeded();
            Redraw();
        }

        public void EndUpdate(string reason)
        {
            Document.Commit(reason);
            TreeView.LoadTree(Document.Root);
        }

        public void SwitchAction(string actionName)
        {
            _actionsGraph.SwitchAction(actionName);
        }

        public void Redraw()
        {
            View.Update();
        }
    }
}