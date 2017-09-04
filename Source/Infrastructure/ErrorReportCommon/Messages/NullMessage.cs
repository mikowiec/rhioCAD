#region Usings

using System.Windows.Forms;

#endregion

namespace ErrorReportCommon.Messages
{
    internal class NullMessage : IMessage
    {
        #region IMessage Members

        public void Show(string message)
        {
        }

        public void ShowWarning(string message)
        {
        }

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return default(DialogResult);
        }

        #endregion
    }
}