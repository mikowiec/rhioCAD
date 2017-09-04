#region Usings

using System;
using Naro.Infrastructure.Interface;
using NaroPipes.Constants;

#endregion

namespace InteractiveEditor.Views.Tools
{
    /// <summary>
    ///   Interaction logic for CutCopyPasteView.xaml
    /// </summary>
    public partial class CopyView
    {
        private readonly ViewInfo _viewInfo;

        public CopyView(ViewInfo viewInfo)
        {
            InitializeComponent();
            _viewInfo = viewInfo;
        }

        private void CopyClicked(object sender, EventArgs e)
        {
            _viewInfo.SwitchAction(ModifierNames.NaroDocumentCopy);
        }
    }
}