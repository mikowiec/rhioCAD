#region Usings

using System.Windows.Input;
using log4net;

#endregion

namespace ViewInterfacePlugin.Constraints
{
    /// <summary>
    ///   Lógica de interacción para ArcToolsSplitButton.xaml
    /// </summary>
    public partial class DefineAxisSystemSplitButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public DefineAxisSystemSplitButton()
        {
            InitializeComponent();
            IsEnabled = false;
        }

        private void ThreePointsAxisSysyemClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing ThreePointsAxis button");
        }

        private void TwoLinesClick(object sender, ExecutedRoutedEventArgs e)
        {
            Log.Info("After pressing TwoLinesAxis button");
        }
    }
}