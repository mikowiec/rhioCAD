using System.Windows.Forms;

namespace ErrorReportCommon.Messaging
{
    public interface IMessage
    {
        void Show(string message);
        void Show(string text, string caption);
        DialogResult Show(string text, string caption, MessageBoxButtons buttons);
    }
}