#region Usings

using System.Windows.Forms;

#endregion

namespace ErrorReportCommon.Messages
{
    public static class NaroMessage
    {
        private static IMessage _message;

        static NaroMessage()
        {
            _message = new NullMessage();
        }

        public static void SetFactory(IMessage outputMessage)
        {
            _message = outputMessage;
        }

        public static void Show(string message)
        {
            _message.Show(message);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return _message.Show(text, caption, buttons);
        }
    }
}