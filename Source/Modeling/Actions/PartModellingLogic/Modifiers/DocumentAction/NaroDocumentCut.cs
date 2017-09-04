#region Usings

using Naro.Infrastructure.Library.Actions.DocumentAction;
using NaroConstants.Names;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    internal class NaroDocumentCut : DocumentActionBase
    {
        public NaroDocumentCut()
            : base(ModifierNames.NaroDocumentCut)
        {
            DependsOn(InputNames.SelectionContext);
            DependsOn(InputNames.ClipboardManager);
        }

        public override void OnActivate()
        {
            base.OnActivate();

            //Document.Undo();
            //UpdateViewAndTree();
            BackToNeutralModifier();
        }
    }
}