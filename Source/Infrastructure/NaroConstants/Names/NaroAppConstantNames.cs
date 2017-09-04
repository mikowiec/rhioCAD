#region Usings

using System;
using System.IO;
using System.Reflection;

#endregion

namespace NaroConstants.Names
{
    public static class NaroAppConstantNames
    {
        public const string AppName = "NaroCAD";
        public const string Website = "http://www.narocad.com";
        public const string BlogWebsite = "http://narocad.blogspot.com";
        public const string OpenCascadeWebSite = "http://www.opencascade.org";
        public const string TutorialFile = "Tutorial.pdf";
        public const string Version = "1.8.8";
        public const string Ignore = "Ignore";

        public static string StartupAppDirectory
        {
            get
            {
                var exePath = Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName;
                return Path.GetDirectoryName(exePath);
            }
        }
        static NaroAppConstantNames()
        {
            AppDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\NaroCAD\";
            NaroUserDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\NaroCAD\";
            InstallDirectory = StartupAppDirectory;
        }
        public static string InstallDirectory;

        private static string AppDataDirectory { get; set; }

        private static string NaroUserDirectory { get; set; }

        public static string AutoSaveFileName { get { return AppDataDirectory + @"\autosave.naroxml"; } }
        public static string GuardFileName { get { return AppDataDirectory + @"\.narolock"; } }
        public static string ZipLogFileName { get { return AppDataDirectory + @"\log\log.zip"; } }
        public static string LogFileName { get { return AppDataDirectory + @"\log\log.txt"; } }
        public static string NewFileName { get { return InstallDirectory + @"\NewFile.naroxml"; } }

        public static string BooScriptTemplate { get { return InstallDirectory + @"\boo\booScriptTemplate.boo"; } }

        public static string BooRegularPoly { get { return NaroUserDirectory + @"\Boo\Library\RegularPoly.boo"; } }

        public static string PluginFileDescription { get { return Directory.GetCurrentDirectory() + @"\auto_plugin.naro"; } }
        public static string DockLayoutFilename { get { return NaroUserDirectory + @"\NaroLayout.xml"; } }

        public static string DefaultDockignLayoutFilename { get { return InstallDirectory + @"\DefaultNaroLayout.xml"; } }

        public static string ShadersFolder { get { return InstallDirectory + @"\shaders\"; } }

    }
}