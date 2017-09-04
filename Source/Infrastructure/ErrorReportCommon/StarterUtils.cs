#region Usings

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using ErrorReportCommon.Messages;
using log4net;
using NaroConstants.Names;
using Resources.Infrastructure;

#endregion

namespace ErrorReportCommon
{
    public static class StarterUtils
    {
        #region Public methods

        private static void CreateGuard(bool fromLastCrash)
        {
            var directory = Path.GetDirectoryName(NaroAppConstantNames.GuardFileName);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            var file = File.CreateText(NaroAppConstantNames.GuardFileName);
            if (fromLastCrash)
            {
                //means to load auto-save at start
                file.WriteLine("1");
            }
            file.Close();
        }

        public static void RunNaroCad(bool occFound, bool fromLastCrash)
        {
            CreateGuard(fromLastCrash);

            var startInfo = new ProcessStartInfo();
            var currentDirectory = Directory.GetCurrentDirectory();

            //if (occFound)
            //{
            //    startInfo.FileName = "AppShell.exe";
            //    startInfo.WindowStyle = ProcessWindowStyle.Normal;
            //}
            //else
            //{
                var casRootPath = currentDirectory + @"\occ\ros";
                Environment.SetEnvironmentVariable("CASROOT", casRootPath);
                startInfo.FileName = currentDirectory + @"\occ\ros\env.bat";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //}
            startInfo.Arguments = NaroStartInfo.Instance.FullArguments;
            startInfo.WorkingDirectory = currentDirectory;

            startInfo.ErrorDialog = true;

            var naroCadApplication = Process.Start(startInfo);
            if (naroCadApplication == null)
                throw new ArgumentNullException("occFound");
            naroCadApplication.WaitForExit();
        }

        public static string GetDescriptionMessage(string application, string version, bool addTime, string description)
        {
            var result = description;
            result += Environment.NewLine + " ----------------------- ";
            result += Environment.NewLine + "Application: " + application;
            result += Environment.NewLine + "Version: " + version;
            result += Environment.NewLine + "OS: " + Environment.OSVersion;
            result += Environment.NewLine + ".NET: " + Environment.Version;
            result += Environment.NewLine + "Processor count: " + Environment.ProcessorCount;

            if (addTime)
                result += Environment.NewLine + "Time: " + DateTime.Now;
            return result;
        }

        private static void RemovePluginsFromProfileCatalog(XmlNode node)
        {
            var removedList = new List<XmlNode>();
            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.Attributes == null) continue;
                var fileName = child.Attributes["AssemblyFile"].Value;
                if ("Plugins\\".StartsWith(fileName))
                    removedList.Add(child);
            }

            foreach (var pluginNode in removedList)
            {
                node.RemoveChild(pluginNode);
            }
        }

        public static bool SendBugReport(ReportingForm form)
        {
            var sent = true;
            form.FileNames.Add(NaroAppConstantNames.LogFileName);
            form.FileNames.Add(NaroAppConstantNames.AutoSaveFileName);
            form.TopMost = true;

            //Application.Run(form);
            if (form.ShowDialog() == DialogResult.OK)
            {
                sent = SendReportToSf(form, form.FileNames);
                if (!sent)
                {
                    NaroMessage.Show(ErrorReportCommonResources.StarterUtils_Internet_problems);
                }
            }
            return sent;
        }


        private static bool SendReportToSf(ReportingForm form, IEnumerable<string> files)
        {
            var sent = true;
            var zipFile = NaroAppConstantNames.ZipLogFileName;
            var pack = new ZipPack(zipFile);
            foreach (var fileName in files)
            {
                pack.AddFile(fileName);
            }
            pack.Close();

            // submit the error report
            ServicePointManager.Expect100Continue = false;
            var sf = new SourceForgeBugReport();
            try
            {
                sf.ReportBug(form.Title, form.Description, zipFile);
            }
            catch (Exception ex)
            {
                Log.Info("Error sending the report to internet."
                         + Environment.NewLine
                         + " Error message: "
                         + ex.Message);
                sent = false;
            }
            return sent;
        }

        #endregion

        #region Data members

        private static readonly ILog Log = LogManager.GetLogger(typeof (StarterUtils));

        #endregion
    }
}