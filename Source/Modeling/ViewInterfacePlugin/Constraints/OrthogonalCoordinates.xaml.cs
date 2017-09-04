#region Usings

using System.Windows.Input;
using System.Windows.Media;
using NaroConstants.Names;
using NaroSetup;

#endregion

namespace ViewInterfacePlugin.Constraints
{
    /// <summary>
    ///   Lógica de interacción para OrthogonalCoordinates.xaml
    /// </summary>
    public partial class OrthogonalCoordinates
    {
        public OrthogonalCoordinates()
        {
            InitializeComponent();
            IsEnabled = false;
        }

        private void BlockPlaneButtonClick(object sender, ExecutedRoutedEventArgs e)
        {
            var optionsSetup = ActionGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);
            var value = !optionsSection.GetBoolValue(10);
            optionsSetup.Document.Transact();
            optionsSection.SetValue(10, value);
            optionsSetup.Document.Commit("Changed ortho");
            Background = value
                             ? new LinearGradientBrush(new GradientStopCollection
                                                           {
                                                               new GradientStop(Color.FromRgb(63, 63, 255), 0.3),
                                                               new GradientStop(Color.FromRgb(163, 163, 255), 0.7),
                                                               new GradientStop(Color.FromRgb(0, 0, 255), 1.0)
                                                           })
                             : null;
        }
    }
}