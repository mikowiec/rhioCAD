using System.Windows.Forms;

namespace ErrorReportCommon.Messaging
{
    internal class NullMessage : IMessage
    {
        public void Show(string message) { }
        public void Show(string text, string caption) { }

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return default(DialogResult);
        }
    }
}