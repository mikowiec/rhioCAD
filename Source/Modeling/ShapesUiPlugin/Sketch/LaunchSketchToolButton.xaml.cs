using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NaroPipes.Constants;

namespace ShapesUiPlugin
{
    /// <summary>
    /// Lógica de interacción para LaunchSketchToolButton.xaml
    /// </summary>
    public partial class LaunchSketchToolButton
    {
        public LaunchSketchToolButton()
        {
            InitializeComponent();
        }

        private void LaunchSketcherClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.StartSketchMode);
        }
    }
}
