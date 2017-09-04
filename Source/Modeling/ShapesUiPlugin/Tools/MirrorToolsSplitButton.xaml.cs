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

namespace ShapesUiPlugin.Tools
{
    /// <summary>
    /// Lógica de interacción para MirrorToolsSplitButton.xaml
    /// </summary>
    public partial class MirrorToolsSplitButton
    {
        public MirrorToolsSplitButton()
        {
            InitializeComponent();
        }

        private void MirrorPointClick(object sender, ExecutedRoutedEventArgs e)
        {
            mirrorGroup.Command = MirrorPoint.Command;
            SwitchUserAction(ModifierNames.MirrorPoint);
        }

        private void MirrorAxisClick(object sender, ExecutedRoutedEventArgs e)
        {
            mirrorGroup.Command = MirrorLine.Command;
            SwitchUserAction(ModifierNames.MirrorLine);
        }

        private void MirrorPlaneClick(object sender, ExecutedRoutedEventArgs e)
        {
            mirrorGroup.Command = MirrorPlane.Command;
            SwitchUserAction(ModifierNames.MirrorPlane);
        }
    }
}
