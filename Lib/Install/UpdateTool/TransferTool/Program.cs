#region Usings

using System;
using System.Windows.Forms;

#endregion

namespace TransferTool
{
    internal static class Program
    {
        /// <summary>
        ///   The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TransferForm());
        }
    }
}