#region Usings

using Naro.Infrastructure.Library.Actions.DocumentAction;
using NaroPipes.Constants;
using PartModellingLogic.UI.Views;

#endregion

namespace PartModellingLogic.Modifiers.Infrastructure
{
    internal class DeleteHidden : DocumentActionBase
    {
        public DeleteHidden()
            : base(ModifierNames.DeleteHidden)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();

            var form = new DeleteHiddenForm(Document);
            Document.Transact();
            form.ShowDialog();

            //_document.OptimizeData();
            Document.Commit("Delete object");

            UpdateView();
            RebuildTreeView();
        }
    }
}