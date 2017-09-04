/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */

#region Usings

using System;
using System.IO;
using System.Windows.Forms;

#endregion

namespace UpdateTool
{
    /// <summary>
    ///   Class with program entry point.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///   Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "--nightly")
                    MainForm.NightlyBuildVersion();
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}