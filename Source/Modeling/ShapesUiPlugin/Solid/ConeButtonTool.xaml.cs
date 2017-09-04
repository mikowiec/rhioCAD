using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Solid
{
    /// <summary>
    /// Lógica de interacción para ConeButtonTool.xaml
    /// </summary>
    public partial class ConeButtonTool
    {
        public ConeButtonTool()
        {
            InitializeComponent();
        }

        private void ConeClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Cone);
        }
    }
}
