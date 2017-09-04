#region Usings

using System.Windows.Input;
using log4net;
using NaroPipes.Constants;

#endregion

namespace ModellingToolsPlugin.Booleans
{
    /// <summary>
    ///   Lógica de interacción para IntersectToolButton.xaml
    /// </summary>
    public partial class IntersectToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public IntersectToolButton()
        {
            InitializeComponent();
        }

        private void BooleanIntersectClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing BooleanIntersect button");
            SwitchUserAction(ModifierNames.BooleanIntersect);
        }
    }
}