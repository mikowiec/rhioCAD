#region Usings

using System.Windows;
using Naro.Infrastructure.Interface;
using NaroPipes.Constants;

#endregion

namespace InteractiveEditor.Views.Tools
{
    /// <summary>
    ///   Lógica de interacción para PasteView.xaml
    /// </summary>
    public partial class PasteView
    {
        private readonly ViewInfo _viewInfo;

        public PasteView(ViewInfo viewInfo)
        {
            _viewInfo = viewInfo;
            InitializeComponent();
        }

        private void PasteClicked(object sender, RoutedEventArgs e)
        {
            _viewInfo.SwitchAction(ModifierNames.NaroDocumentPaste);
        }
    }
}