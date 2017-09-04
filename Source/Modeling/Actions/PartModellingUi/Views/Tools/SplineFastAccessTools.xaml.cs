#region Usings

using System.Windows;
using NaroPipes.Actions;
using NaroPipes.Constants;

#endregion

namespace PartModellingUi.Views.Tools
{
    /// <summary>
    ///   Lógica de interacción para SplineFastAccessTools.xaml
    /// </summary>
    public partial class SplineFastAccessTools
    {
        private readonly ActionsGraph _actionsGraph;

        public SplineFastAccessTools(ActionsGraph actionsGraph)
        {
            _actionsGraph = actionsGraph;
            InitializeComponent();
        }

        private void InterpolatedClick(object sender, RoutedEventArgs e)
        {
            _actionsGraph.SwitchAction(ModifierNames.InterpolatedSpline);
        }

        private void ControlPointClick(object sender, RoutedEventArgs e)
        {
            _actionsGraph.SwitchAction(ModifierNames.ControlPointSpline);
        }

        private void SplitSplineClick(object sender, RoutedEventArgs e)
        {
            _actionsGraph.SwitchAction(ModifierNames.SplitSpline);
        }

        private void DoneClick(object sender, RoutedEventArgs e)
        {
            _actionsGraph.SwitchAction(ModifierNames.None);
        }

        private void CombineSplineClick(object sender, RoutedEventArgs e)
        {
            _actionsGraph.SwitchAction(ModifierNames.CombineSplines);
        }

        private void SplineClick(object sender, RoutedEventArgs e)
        {
            _actionsGraph.SwitchAction(ModifierNames.Spline);
        }
    }
}