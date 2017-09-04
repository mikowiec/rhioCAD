namespace ErrorReportCommon.Messages
{
    /// <summary>
    ///   Lógica de interacción para WarningWindow.xaml
    /// </summary>
    public partial class WarningWindow
    {
        public WarningWindow(string message)
        {
            InitializeComponent();
            textBlock.Text = message;
        }
    }
}