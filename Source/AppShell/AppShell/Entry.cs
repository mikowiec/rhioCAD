#region Usings

using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

using ErrorReportCommon;
using ErrorReportCommon.Messages;
using Extensions.Wpf;
using log4net;
using log4net.Config;
using Naro.Infrastructure.Interface.AppUtils;
using NaroConstants.Names;
using PartModellingLogic;

#if !DEBUG

#endif

#endregion

namespace AppShell
{
    /// <summary>
    ///   Implements the entry point for the application.
    /// </summary>
    internal sealed class Entry
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (Entry));

        [STAThread]
        internal static void Main(string[] args)
        {
#if !DEBUG
                WpfSplash.Instance.Show();
#endif
            CoreGlobalPreferencesSingleton.Instance.StartTime = Environment.TickCount;
            XmlConfigurator.Configure();
            DefaultInterpreters.Setup();

            var app = new App();
            NaroMessage.SetFactory(new MessageBoxMessage());
            NaroStartInfo.Instance.Arguments = args;
            Application.EnableVisualStyles();
            WindowsFormsHost.EnableWindowsFormsInterop();
            Log.Info("-------------------------- Started " + NaroAppConstantNames.AppName + " " +
                     NaroAppConstantNames.Version + " session ---------------------------");

            var optionsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                              @"\NaroCAD\options.nxml";
            if (!File.Exists(optionsPath))
            {
                File.Copy(Directory.GetCurrentDirectory() + @"\options.nxml", optionsPath);
            }

            AppDomain.CurrentDomain.UnhandledException += HandleException;
            var shellWindow = new ShellWindow();
            shellWindow.SetActionGraph();
            app.Run(shellWindow);

            File.Delete(NaroAppConstantNames.GuardFileName);
            //MemMapper.DisplayLeaks();
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs ex)
        {
            if (ex == null)
                return;

            Log.Error("Exception message: " + ex.ExceptionObject);


            throw new Exception("NaroCAD exception occured.");
        }
    }
}