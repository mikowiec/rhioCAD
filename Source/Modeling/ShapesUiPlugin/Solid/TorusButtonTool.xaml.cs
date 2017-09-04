using System;
using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Solid
{
    /// <summary>
    /// Lógica de interacción para TorusButtonTool.xaml
    /// </summary>
    public partial class TorusButtonTool 
    {
        public TorusButtonTool()
        {
            InitializeComponent();
        }

        private void TorusClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Torus);
        }
    }
}
