#region Usings

using System.Windows.Input;
using BooGearPlugin.Modifiers.Gear;
using BooGearPlugin.Modifiers.Names;

#endregion

namespace BooGearPlugin.Views
{
    /// <summary>
    ///   Lógica de interacción para BooShapeList.xaml
    /// </summary>
    public partial class BooShapeList
    {
        public BooShapeList()
        {
            InitializeComponent();
        }

        private void RegularPolygonClick(object sender, ExecutedRoutedEventArgs e)
        {
            Command = RegularPoly.Command;
            SwitchUserAction(BooModifier.RegularPolygon);
        }

        private void BooGearClick(object sender, ExecutedRoutedEventArgs e)
        {
            Command = BooGearShape.Command;
            SwitchUserAction(BooModifier.BooGearShape);
        }
    }
}