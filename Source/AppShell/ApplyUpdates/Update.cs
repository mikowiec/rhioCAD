#region Usings

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using log4net;

#endregion

namespace ApplyUpdates
{
    public static class Update
    {
        #region Data members

        private const string AuxiliaryDirectoryPath = @"auxiliary\";
        private const string HelperUpdateDirectory = @"UpdateSucceeded\";
        private const string HelperDownloadDirectory = @"DownloadSucceeded\";
        private const string VersioningFile = "Version.xml";
        private const string HelperVersioningFile = "OldVersion.xml";
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");
        private static readonly string CurrentPath = Directory.GetCurrentDirectory() + "\\";

        #endregion

        internal static void Main()
        {
            Log.Info("Apply updates started");
            AttemptToUpdate();
            const string naroStarter = "NaroStarter.exe";
            if (!File.Exists(naroStarter)) return;
            var process = new Process {StartInfo = {FileName = naroStarter}};
            process.Start();
            Environment.Exit(0);
        }

        #region Public Methods

        public static void AddNewFilesToList(string curDir, List<string> lista, string startingPath)
        {
            foreach (var file in Directory.GetFiles(curDir))
            {
                lista.Add(file.Substring(startingPath.Length));
            }
            foreach (var subDir in new DirectoryInfo(curDir).GetDirectories())
            {
                AddNewFilesToList(curDir + @"\" + subDir.Name, lista, startingPath);
            }
        }

        public static void CreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
                Log.Info("Directory indicating that update succeded was created");
            }
        }

        public static void DeleteDirectory(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    Log.Error("Directory indicating that update failed deleted");
                }
            }
            catch
            {
                Log.Error("Error deleting directory");
            }
        }

        public static bool MoveWithReplaceInNaroCad(string sourceFileName, string destFileName)
        {
            try
            {
                if (File.Exists(CurrentPath + destFileName))
                {
                    File.Delete(CurrentPath + destFileName);
                }
                MakeSureThatDestinationDirectoriesExist(destFileName, CurrentPath);
                File.Move(CurrentPath + sourceFileName, CurrentPath + destFileName);
                return true;
            }
            catch
            {
                Log.Info("Move file: " + sourceFileName + " to " + destFileName + " did not succeed.");
                return false;
            }
        }

        public static void MakeSureThatDestinationDirectoriesExist(string destination, string startPath)
        {
            var textPath = startPath;
            var list = destination.Split('\\');
            for (var index = 0; index < list.Length - 1; index++)
            {
                textPath += list[index] + "\\";
                if (!Directory.Exists(textPath))
                {
                    Directory.CreateDirectory(textPath);
                }
            }
        }

        #endregion

        #region Methods

        private static void AttemptToUpdate()
        {
            if (MoveWithReplaceInNaroCad(VersioningFile, HelperVersioningFile))
            {
                if (MoveAllDownloadedFiles())
                {
                    DeleteDirectory(AuxiliaryDirectoryPath);
                    CreateDirectory(HelperUpdateDirectory);
                }
                else
                {
                    Log.Info("Could not move downloaded files.");
                    File.Move(HelperVersioningFile, VersioningFile);
                }
            }
            DeleteDirectory(HelperDownloadDirectory);
        }

        private static bool MoveAllDownloadedFiles()
        {
            try
            {
                var filesToBeMoved = CreateListOfFilesToBeMoved();
                MoveFiles(filesToBeMoved);
                Log.Info("Successfully moved all needed downloaded files.");
                return true;
            }
            catch (Exception e)
            {
                Log.Info("Error while moving downloaded files: " + e);
                return false;
            }
        }

        private static IEnumerable<string> CreateListOfFilesToBeMoved()
        {
            var list = new List<string>();
            AddNewFilesToList(CurrentPath + AuxiliaryDirectoryPath, list, CurrentPath + AuxiliaryDirectoryPath);
            return list;
        }

        private static void MoveFiles(IEnumerable<string> filesToBeMoved)
        {
            Log.Info("Starting to move new files");
            try
            {
                foreach (var filePath in filesToBeMoved)
                {
                    MoveWithReplaceInNaroCad(AuxiliaryDirectoryPath + filePath, filePath);
                }
            }
            catch
            {
                Log.Error("Error while moving updater files");
            }
        }

        #endregion
    }
}