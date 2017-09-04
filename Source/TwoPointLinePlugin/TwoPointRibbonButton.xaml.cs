#region Usings

using System.Windows.Input;

#endregion

namespace TwoPointLinePlugin
{
    /// <summary>
    ///   Lógica de interacción para TwoPointRibbonButton.xaml
    /// </summary>
    public partial class TwoPointRibbonButton
    {
        public TwoPointRibbonButton()
        {
            InitializeComponent();
        }

        private void CursorClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction("TwoPointLineAction");
        }
    }
}