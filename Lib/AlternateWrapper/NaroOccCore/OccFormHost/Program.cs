using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NaroCppCore;
using NaroCppCore.Occ.Precision;

namespace OccFormHost
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var result = NaroCore.Init();
            var confusion = Precision.Confusion;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
