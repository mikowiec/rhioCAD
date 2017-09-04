#region Usings

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using ErrorReportCommon;
using log4net.Config;
using NaroConstants.Names;
using log4net;
#endregion

namespace NaroStarter
{
    /// <summary>
    ///   Class with program entry point.
    /// </summary>
    internal static class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        /// <summary>
        ///   Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            Log.Info("-------------------------- Starting " + NaroAppConstantNames.AppName + " " +
                    NaroAppConstantNames.Version + " session ---------------------------");

            AttemptUpdate(@"UpdateFailed\", @"auxiliary", @"DownloadSucceeded\");
            NaroStartInfo.Instance.Arguments = args;
            ServicePointManager.Expect100Continue = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if NO_INSTALLER
            CheckEnvironmentRuntime();

            if (EnvironmentErrorsForm.NoOcc || EnvironmentErrorsForm.NoVcRuntime)
            {
                Application.Run(new EnvironmentErrorsForm());

                if (!EnvironmentErrorsForm.IgnoreErrors)
                    return;
            }
#endif

            ReportingForm form;
            var fromLastCrash = false;
            do
            {
                CheckEnvironmentRuntime();
                form = null;

                StarterUtils.RunNaroCad(!EnvironmentErrorsForm.NoOcc, fromLastCrash);
                var guardExists = File.Exists(NaroAppConstantNames.GuardFileName);


                var logExists = File.Exists(NaroAppConstantNames.LogFileName);

                if (!guardExists/* || !logExists*/) continue;
                bool sent;
                fromLastCrash = File.Exists(NaroAppConstantNames.AutoSaveFileName);
                do
                {
                    form = new ReportingForm();
                    sent = StarterUtils.SendBugReport(form);
                } while (!sent);
            } while (form != null && form.NaroNeedRestart);
        }

        private static void AttemptUpdate(string updateFailedPath, string auxiliaryPath, string donwloadSucceded)
        {
            if (Directory.Exists(updateFailedPath) || !Directory.Exists(auxiliaryPath) ||
                !Directory.Exists(donwloadSucceded))
            {
                return;
            }
            Directory.CreateDirectory(updateFailedPath);
            var updaterName = "ApplyUpdates.exe";
            if (File.Exists(updaterName))
            {
                var process = new Process();
                process.StartInfo.FileName = updaterName;
                process.Start();
                Environment.Exit(0);
            }
        }

        private static void CheckEnvironmentRuntime()
        {
            if (File.Exists(EnvironmentErrorsForm.CheckEnvironmentFileLock))
                return;
            var occEnvPath = Environment.GetEnvironmentVariable("CASROOT");
            if (String.IsNullOrEmpty(occEnvPath) || !Directory.Exists(occEnvPath))
            {
                EnvironmentErrorsForm.NoOcc = true;
            }
            else
            {
                EnvironmentErrorsForm.NoOcc = false;
            }

            //check existance of Visual C++ Runtime 2008 SP1
            //conforming to link: http://blogs.msdn.com/astebner/archive/2009/01/29/9384143.aspx
            var returnValue = EnvironmentErrorsForm.MsiQueryProductState("{9A25302D-30C0-39D9-BD6F-21E6EC160475}");
            if (returnValue != 5)
            {
                //after that. Check existance of Visual C++ Express 2008 SP1 (which have with it installed the Visual C++ Runtime)
                // found in key LocalMachine\Software\Microsoft\Windows\Current Version\Uninstall\{F5C819A5-E068-4f7d-B91A-1BD18702AFFB}
                returnValue = EnvironmentErrorsForm.MsiQueryProductState("{F5C819A5-E068-4f7d-B91A-1BD18702AFFB}");
            }
            EnvironmentErrorsForm.NoVcRuntime = (returnValue != 5);
        }
    }
}