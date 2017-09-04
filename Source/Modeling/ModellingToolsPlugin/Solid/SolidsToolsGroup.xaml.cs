#region Usings

using System.Windows.Controls;
using System.Windows.Input;
using log4net;
using NaroPipes.Constants;
using NaroUiBuilder;

#endregion

namespace ModellingToolsPlugin.Solid
{
    /// <summary>
    ///   Lógica de interacción para SolidsToolsGroup.xaml
    /// </summary>
    public partial class SolidsToolsGroup : IControllerUiMapping
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        private UiBuilder _uiBuilder;

        public SolidsToolsGroup()
        {
            InitializeComponent();
        }

        #region IControllerUiMapping Members

        public void SetUiBuilder(UiBuilder uiBuilder)
        {
            _uiBuilder = uiBuilder;
        }

        public Control GetControl()
        {
            return this;
        }

        #endregion

        private void BoxClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Box button");
            SwitchUserAction(ModifierNames.Box);
        }

        private void SphereClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Sphere button");
            SwitchUserAction(ModifierNames.Sphere);
        }

        private void CylinderClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Cylinder button");
            SwitchUserAction(ModifierNames.Cylinder);
        }

        private void ConeClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Cone button");
            SwitchUserAction(ModifierNames.Cone);
        }

        private void TorusClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing Torus button");
            SwitchUserAction(ModifierNames.Torus);
        }

        public void SwitchUserAction(string actionName)
        {
            _uiBuilder.ActionsGraph.SwitchAction(actionName);
        }
    }
}