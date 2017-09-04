/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License.
 * Other project licenses are of their respective owners
 */
using System;
using System.Windows.Forms;

namespace Updater
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Program app = new Program();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if(args.Length == 0)
			{
				app.Troubleshot();
			}
			else
			{
				if(args[0] == "-configure")
				{
					app.ConfigureUI();
				}
			}
			Application.Run(app._mainForm);
		}

		Form _mainForm;
		void ConfigureUI()
		{
			_mainForm = new MainForm();
		}
		//This mode will be used without arguments. 
		//Is for users that have an unstable/crashing Naro setup
		void Troubleshot()
		{
			_mainForm = new TroubleshotModeForm();
		}
	}
}
