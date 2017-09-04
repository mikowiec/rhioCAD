/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */

#region Usings

using System;
using System.Windows.Forms;

#endregion

namespace App
{
    /// <summary>
    ///   Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        ///   Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}