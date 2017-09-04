#region Usings

using System.Windows.Forms;

#endregion

namespace ErrorReportCommon.Messages
{
    public class MessageBoxMessage : IMessage
    {
        #region IMessage Members

        public void Show(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowWarning(string message)
        {
            var warningWindow = new WarningWindow(message);
            warningWindow.ShowDialog();
        }

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return MessageBox.Show(text, caption, buttons);
        }

        #endregion
    }
}