#region License

/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */

#endregion

#region Usings

using System;
using System.Windows.Forms;

#endregion

namespace Update
{
    /// <summary>
    ///   Class with program entry point.
    /// </summary>
    internal static class Program
    {
        private static string GetCurrentDirectory()
        {
            var exePath = System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName;
            return System.IO.Path.GetDirectoryName(exePath);
        }

        /// <summary>
        ///   Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            if (args.Length != 0) return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm(GetCurrentDirectory()));
        }
    }
}