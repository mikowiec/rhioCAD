#region Usings

using System.Windows.Forms;

#endregion

namespace ErrorReportCommon.Messages
{
    public interface IMessage
    {
        void Show(string message);
        void ShowWarning(string message);
        DialogResult Show(string text, string caption, MessageBoxButtons buttons);
    }
}