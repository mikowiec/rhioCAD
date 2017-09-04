#region Usings

using log4net;

#endregion

namespace ViewInterfacePlugin.View
{
    /// <summary>
    ///   Lógica de interacción para FullScreenToolButton.xaml
    /// </summary>
    public partial class FullScreenToolButton
    {
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");

        public FullScreenToolButton()
        {
            Log.Info("After pressing FullScreen button");
            InitializeComponent();
        }
    }
}