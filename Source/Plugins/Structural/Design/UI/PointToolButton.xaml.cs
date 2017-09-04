#region Usings

using System.Windows.Input;
using NaroPipes.Constants;

#endregion

namespace NaroCAD.Plugin.Structural.Design
{
    /// <summary>
    ///   Interaction logic for PointToolButton.xaml
    /// </summary>
    public partial class PointToolButton
    {
        public PointToolButton()
        {
            InitializeComponent();
        }

        private void PointClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction(ModifierNames.Point3D);
        }
    }
}