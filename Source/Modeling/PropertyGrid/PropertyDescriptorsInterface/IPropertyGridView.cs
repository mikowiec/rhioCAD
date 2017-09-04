#region Usings

using System.Collections.Generic;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PropertyDescriptorsInterface
{
    public interface IPropertyGridView
    {
        void RefreshGrid();
        void OnSelectNode(Node lastLabelAdded);
        void OnSelectNodes(Node firstNode, Node secondNode);
        void OnSelectNodes(List<SceneSelectedEntity> nodes);
    }
}