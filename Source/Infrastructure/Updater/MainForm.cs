/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License.
 * Other project licenses are of their respective owners
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Updater
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

		}

		void ExecuteNaroCAD()
		{
			var process = new Process();
			process.StartInfo.FileName = "NaroStarter.exe";
			process.StartInfo.Arguments = "";
			process.Start();
		}

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
	}
}
