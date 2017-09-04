#region Usings

using Naro.Infrastructure.Library.Actions.DocumentAction;
using NaroConstants.Names;
using NaroPipes.Constants;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using ShapeFunctionsInterface.Utils;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    internal class NaroDocumentCopy : DocumentActionBase
    {
        public NaroDocumentCopy()
            : base(ModifierNames.NaroDocumentCopy)
        {
            DependsOn(InputNames.SelectionContext);
            DependsOn(InputNames.ClipboardManager);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            // Close all loacal contexts to draw on the Neutral Point
            var clipboard = Inputs[InputNames.ClipboardManager];
            clipboard.Send(ClipboardManager.ClipboardInputConstants.CopyNode,
                           NodeBuilderUtils.IdentifySelectedObjectLabel(Document.Root));
            //UpdateViewAndTree();
            BackToNeutralModifier();
        }
    }
}