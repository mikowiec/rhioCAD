#region Usings

using System.Collections.Generic;
using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using ShapeFunctionsInterface.Utils;

#endregion

namespace PartModellingLogic.Inputs.Naro.Infrastructure
{
    public class ClipboardManager : InputBase
    {
        private readonly List<Node> _nodes = new List<Node>();

        public ClipboardManager()
            : base(InputNames.ClipboardManager)
        {
        }

        public override void OnRegister()
        {
            AddNotificationHandler(ClipboardInputConstants.CopyNode, CopyNode);
            AddNotificationHandler(ClipboardInputConstants.PasteNode, PasteNode);
            AddNotificationHandler(ClipboardInputConstants.PasteRefNode, PasteRefNode);
            AddNotificationHandler(NotificationNames.GetValue, NotifyGetValueHandler);
        }

        private void NotifyGetValueHandler(DataPackage objectData)
        {
            ReturnData = new DataPackage(_nodes.Count == 0 ? null : _nodes);
        }

        private void PasteRefNode(DataPackage objectData)
        {
            var data = objectData.Get<Node>();
            if (_nodes.Count <= 0) return;
            if (_nodes[0] == null) return;
            var newChild = data.AddNewChild();
            Document.CopyPasteRef(_nodes[0], newChild);
            newChild.Set<StringInterpreter>().Value += " Ref Copy";
            newChild.Set<TransformationInterpreter>().CurrTransform =
                _nodes[0].Set<TransformationInterpreter>().CurrTransform;
        }

        private void PasteNode(DataPackage objectData)
        {
            if (_nodes.Count <= 0) return;
            if (_nodes[0] == null) return;

            var newChild = NodeBuilderUtils.CopyPaste(_nodes[0]);
            //if(newChild != null)
            //    newChild.Set<StringInterpreter>().Value += " Copy";
        }

        private void CopyNode(DataPackage objectData)
        {
            var data = objectData.Get<Node>();
            _nodes.Clear();
            _nodes.Add(data);
        }

        #region Nested type: ClipboardInputConstants

        public static class ClipboardInputConstants
        {
            public const string CopyNode = "SetNode";
            public const string PasteNode = "PasteNode";
            public const string PasteRefNode = "PasteRefNode";
        }

        #endregion
    }
}