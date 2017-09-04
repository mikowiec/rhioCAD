using System;
using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Solid
{
    /// <summary>
    /// Lógica de interacción para CylinderButtonTool.xaml
    /// </summary>
    public partial class CylinderButtonTool
    {
        public CylinderButtonTool()
        {
            InitializeComponent();
        }

        private void CylinderClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Cylinder);
        }
    }
}
