#region Usings

using System.Windows.Input;

#endregion

namespace NaroCAD.Plugin.Structural.Design.UI
{
    /// <summary>
    ///   Interaction logic for BeamToolButton.xaml
    /// </summary>
    public partial class BeamToolButton
    {
        public BeamToolButton()
        {
            InitializeComponent();
        }

        private void BeamClick(object sender, ExecutedRoutedEventArgs e)
        {
            SwitchUserAction("BeamAction");
        }
    }
}