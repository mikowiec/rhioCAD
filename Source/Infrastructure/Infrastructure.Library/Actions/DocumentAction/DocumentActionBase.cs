#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using NaroPipes.Constants;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace Naro.Infrastructure.Library.Actions.DocumentAction
{
    public abstract class DocumentActionBase : ActionBase
    {
        protected Document Document;

        protected DocumentActionBase(string name) : base(name)
        {
            DependsOn(InputNames.Document, OnReceiveDocument);
            DependsOn(InputNames.View);
            DependsOn(InputNames.UiElementsItem);
        }

        private void OnReceiveDocument(DataPackage data)
        {
            Document = data.Get<Document>();
        }

        protected void UpdateView()
        {
            Inputs[InputNames.View].Send(NotificationNames.RefreshView);
        }

        protected void RebuildTreeView()
        {
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.RebuildTreeView);
        }

        protected void AddNodeToTree(Node node)
        {
            Inputs[InputNames.UiElementsItem].Send(NotificationNames.AddNewNodeToTree, node);
        }

        protected void ResetTransformationInfo()
        {
            TransformationInterpreter.Transformations.Clear();
            TransformationInfo.maxTrsfIndex = 0;
        }

        protected void BackToNeutralModifier()
        {
            ActionsGraph.SwitchAction(ModifierNames.None);
        }
        

        protected void EndSketch()
        {
            ActionsGraph.SwitchAction(ModifierNames.EndSketch);
        }
    }
}