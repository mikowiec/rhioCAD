using System.Windows.Input;
using NaroPipes.Constants;

namespace ShapesUiPlugin.Solid
{
    /// <summary>
    /// Lógica de interacción para BoxButtonTool.xaml
    /// </summary>
    public partial class BoxButtonTool
    {
        public BoxButtonTool()
        {
            InitializeComponent();
        }

        private void BoxClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Box);
        }
    }
}
