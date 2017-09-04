#region Usings

using System.Collections.Generic;
using Naro.Infrastructure.Library.Actions.DocumentAction;
using NaroConstants.Names;
using NaroPipes.Constants;
using PartModellingLogic.Inputs.Naro.Infrastructure;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    internal class NaroDocumentPaste : DocumentActionBase
    {
        public NaroDocumentPaste()
            : base(ModifierNames.NaroDocumentPaste)
        {
            DependsOn(InputNames.SelectionContext);
            DependsOn(InputNames.ClipboardManager);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            // Close all loacal contexts to draw on the Neutral Point
            Document.Transact();
            var clipboard = ActionsGraph[InputNames.ClipboardManager];
            clipboard.Send(
                ClipboardManager.ClipboardInputConstants.PasteNode,
                Document.Root);
            Document.Commit("Copy Paste");
            UpdateView();
            RebuildTreeView();
       
            BackToNeutralModifier();
        }
    }
}