#region Usings

using System.Windows.Input;
using NaroPipes.Constants;

#endregion

namespace NaroCAD.Plugin.Structural.Design
{
    /// <summary>
    ///   Interaction logic for CursorToolButton.xaml
    /// </summary>
    public partial class CursorToolButton
    {
        public CursorToolButton()
        {
            InitializeComponent();
        }

        private void CursorClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.None);
        }
    }
}