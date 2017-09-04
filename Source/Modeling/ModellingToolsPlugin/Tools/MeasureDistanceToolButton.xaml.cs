#region Usings

using System.Windows.Input;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Tools
{
    /// <summary>
    ///   Lógica de interacción para MeasureDistanceToolButton.xaml
    /// </summary>
    public partial class MeasureDistanceToolButton
    {
        public MeasureDistanceToolButton()
        {
            InitializeComponent();
        }

        private void MeasureClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.MeasureDistance);
        }
    }
}