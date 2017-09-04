#region Usings

using TreeData.Capabilities;
using TreeData.NaroData;

#endregion

namespace Naro.Infrastructure.Interface.Views
{
    public delegate void SelectedLabelEventHandler(Node label);

    public interface ITreeViewControl
    {
        event SelectedLabelEventHandler SelectedLabel;
        //event SelectedLabelEventHandler MouseHoverLabel;
        event SelectedLabelEventHandler MouseLeaveTree;
        void ClearCache();
        void LoadTree(Node nodes);
        void AddNode(Node node);
        void SelectNode(Node label);
        Node GetSelectedNode();

        void SetShapesCapabilities(CapabilitiesCollection capabilitiesCollection);
    }
}