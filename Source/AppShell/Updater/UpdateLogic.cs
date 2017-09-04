#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows;
using System.Xml.Serialization;
using ErrorReportCommon.Messages;
using log4net;
using NaroConstants.Names;
using NaroPipes.Actions;
using PartModellingUi.Views;
using TreeData.AttributeInterpreter;

#endregion

namespace Updater
{
    public class UpdateLogic
    {
        #region Data members

        private const string AuxiliaryDirectory = @"auxiliary\";
        private const string HelperUpdateDirectory = @"UpdateSucceeded\";
        private const string HelperDownloadDirectory = @"DownloadSucceeded\";
        private const string FailedUpdateDirectory = @"UpdateFailed\";
        private const string versionFileName = "Version.xml";
        private const string HelperVersioningFile = "OldVersion.xml";
        private const string ApplyUpdatesName = "ApplyUpdates.exe";
        private const string compressedFilesDirectory = @"Compressed\";
        private const string compressedFilesExtension = ".zip";
        private const string NaroStableLink = @"http://www.cipdevel.com/download/NaroCADStable/";
        private const string NaroNightlyLink = @"http://www.cipdevel.com/download/NaroCADNightly/";
        private static string fullIssFilePath = @"..\..\Lib\Install\full.iss";
        private static readonly ILog Log = LogManager.GetLogger("NaroCad");
        private static int lengthOfStableVersion;
        private static int lengthOfNightlyVersion;
        private static readonly string currentPath = Directory.GetCurrentDirectory() + "\\";
        private static string _fullNumericVersion;
        private static bool _downloadNightlyUpdate;
        private static bool _downloadStableUpdate;
        private static ActionsGraph _actionGraph;
        private static string _pathToDownload;
        private static UIElement _control;

        #endregion

        #region Properties

        public static string FullIssFilePath
        {
            get { return fullIssFilePath; }
            set { fullIssFilePath = value; }
        }

        public static string VersionFileName
        {
            get { return versionFileName; }
        }

        public static string CurrentPath
        {
            get { return currentPath; }
        }

        public static string CompressedFilesExtension
        {
            get { return compressedFilesExtension; }
        }

        public static string CompressedFilesDirectory
        {
            get { return compressedFilesDirectory; }
        }

        #endregion

        #region PublicMethods

        public UpdateLogic(ActionsGraph actionGraph, bool haveToUpdate, bool updateNightly, UIElement control)
        {
            _control = control;
            _actionGraph = actionGraph;
            Setup(haveToUpdate, updateNightly);
        }

        private static void Setup(bool haveToUpdate, bool updateNightly)
        {
            _downloadStableUpdate = haveToUpdate;
            _downloadNightlyUpdate = updateNightly;
        }

        public static void DeleteDirectory(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    Log.Info("Directory: " + path + " successfully deleted");
                }
            }
            catch
            {
                Log.Error("Error deleting directory: " + path);
            }
        }

        public static void CreateDirectory(string directoryName)
        {
            try
            {
                if (!Directory.Exists(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }
            }
            catch
            {
                Log.Error("Error creating auxiliary directory");
            }
        }

        public static void MakeSureThatDestinationDirectoriesExist(string destination, string path)
        {
            var textPath = path;
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

        private static void ChangeUpdateIcon(DowloadIconState state)
        {
            switch (state)
            {
                case DowloadIconState.Donwloading:
                    //change icon to downloading
                    break;
                case DowloadIconState.Default:
                    //change icon
                    //
                    break;
                case DowloadIconState.Finished:
                    //change icon
                    break;
                case DowloadIconState.ConnectionProblems:
                    //change icon
                    //
                    break;
                case DowloadIconState.UpToDate:
                    //change icon
                    break;
                case DowloadIconState.NightlyVersionAvailable:
                    //change icon
                    break;
                case DowloadIconState.StableVersionAvailable:
                    //change icon
                    break;
            }
        }

        #endregion

        public static void Main(object data)
        {
            var logic = (UpdateLogic) data;
            Log.Info("Started updater logic");
            CalculateLengthOfNaroVersions();
            DeleteDirectory(FailedUpdateDirectory);
            VersionObject currentVersionData;
            try
            {
                currentVersionData = DeserializeFromXml(versionFileName);
            }
            catch
            {
                Log.Error("The versioning file is corrupt.");
                DeleteDirectory(AuxiliaryDirectory);
                DeleteFile(HelperVersioningFile);
                NaroMessage.Show("The versioning file is corrupt. It is recomanded to download and reinstall NaroCAD.");
                return;
            }
            CalculateNaroVersion(currentVersionData);
            if (MainUpdateWasJustDone())
            {
                if (AttemptToFinalizeUpdate(currentVersionData.GetListOfFiles(),
                                            DeserializeFromXml(HelperVersioningFile).GetListOfFiles()))
                {
                    Log.Info("NaroCAD update successfully compleated");
                    UpdaterWindowsManager.ShowDownloadsFinishedWindow(new List<string>
                                                                          {
                                                                              "",
                                                                              "Update Successfully Compleated",
                                                                              "Enjoy NaroCAD"
                                                                          });
                    UpdaterWindowsManager.DownloadFinishedLoop();
                }
            }
            AttemptToDownloadUpdateFiles(_control);
        }

        private static void OnUpdateDialogClose(object sender, EventArgs e)
        {
            var currentVersionData = DeserializeFromXml(versionFileName);
            var currentVersionFiles = currentVersionData.ListOfFiles;
            var newerVersion = DeserializeFromXml(AuxiliaryDirectory + versionFileName);
            DownloadUpdateFiles(_pathToDownload, currentVersionFiles, newerVersion);
            Log.Info("Ended updater logic");
            if (Directory.Exists(HelperDownloadDirectory))
            {
                UpdaterWindowsManager.ShowDownloadsFinishedWindow(new List<string>
                                                                      {
                                                                          "",
                                                                          "Updates have been downloaded.",
                                                                          "The updates will apply the next time you start NaroCAD."
                                                                      });
                UpdaterWindowsManager.DownloadFinishedLoop();
            }
        }

        #region Methods

        private static bool AttemptToFinalizeUpdate(List<string> newList, IEnumerable<string> oldList)
        {
            if (_fullNumericVersion.Length == lengthOfStableVersion)
            {
                if (DownloadNewApplyUpdates(NaroStableLink + ApplyUpdatesName + compressedFilesExtension,
                                            ApplyUpdatesName))
                {
                    FinalizeUpdate(newList, oldList);
                    return true;
                }
            }
            else if (_fullNumericVersion.Length == lengthOfNightlyVersion)
            {
                if (DownloadNewApplyUpdates(NaroNightlyLink + ApplyUpdatesName + compressedFilesExtension,
                                            ApplyUpdatesName))
                {
                    FinalizeUpdate(newList, oldList);
                    return true;
                }
            }
            return false;
        }

        private static bool MainUpdateWasJustDone()
        {
            return Directory.Exists(HelperUpdateDirectory) && !Directory.Exists(AuxiliaryDirectory);
        }

        private static void FinalizeUpdate(List<string> newList, IEnumerable<string> oldList)
        {
            DeleteDirectory(HelperUpdateDirectory);
            DeleteDirectory(AuxiliaryDirectory);
            DeleteDirectory(HelperDownloadDirectory);
            DeleteFile(HelperVersioningFile);
            ChangeUpdateIcon(DowloadIconState.UpToDate);
            DeleteUslessData(CreateListOfFilesToBeDeleted(oldList, newList));
        }

        private static bool DownloadNewApplyUpdates(string uri, string destinationPath)
        {
            if (!Directory.Exists(AuxiliaryDirectory))
            {
                Directory.CreateDirectory(AuxiliaryDirectory);
            }
            try
            {
                var webClient = new WebClient();
                MakeSureThatDestinationDirectoriesExist(destinationPath, currentPath);
                webClient.DownloadFile(new Uri(uri),
                                       currentPath + AuxiliaryDirectory + destinationPath + compressedFilesExtension);
            }
            catch
            {
                Log.Info("Failed to download: " + destinationPath);
                return false;
            }
            try
            {
                UnpackFile(currentPath + AuxiliaryDirectory + destinationPath, compressedFilesExtension);
                MoveWithReplaceInNaroCad(AuxiliaryDirectory + destinationPath, destinationPath);
                return true;
            }
            catch
            {
                Log.Info("Cannot access: " + currentPath + AuxiliaryDirectory + destinationPath +
                         compressedFilesExtension);
                return false;
            }
        }

        public static VersionObject DeserializeFromXml(string path)
        {
            try
            {
                var deserializer = new XmlSerializer(typeof (VersionObject));
                TextReader textReader = new StreamReader(path);
                var result = (VersionObject) deserializer.Deserialize(textReader);
                textReader.Close();
                return result;
            }
            catch
            {
                return null;
            }
        }

        private static void AttemptToDownloadUpdateFiles(UIElement control)
        {
            if (!_downloadNightlyUpdate && !_downloadStableUpdate)
            {
                DeleteDirectory(AuxiliaryDirectory);
            }
            else
            {
                if (_downloadNightlyUpdate)
                {
                    _pathToDownload = NaroNightlyLink;
                    DownloadUpdates(_pathToDownload, control);
                }
                else if (_downloadStableUpdate)
                {
                    _pathToDownload = NaroStableLink;
                    DownloadUpdates(_pathToDownload, control);
                }
                else
                {
                    DeleteDirectory(AuxiliaryDirectory);
                }
            }
        }

        private static void DownloadUpdates(string downloadPath, UIElement control)
        {
            if (Directory.Exists(AuxiliaryDirectory))
                OnUpdateDialogClose(null, null);
            CreateDirectory(AuxiliaryDirectory);
            if (DownloadSpecificFile(downloadPath + versionFileName + compressedFilesExtension,
                                     AuxiliaryDirectory + versionFileName))
            {
                var newerVersion = DeserializeFromXml(AuxiliaryDirectory + versionFileName);
                if (NewerVersion(newerVersion.VersionData.VersionName))
                {
                    var nightlyDownload = false;
                    if (downloadPath == NaroNightlyLink)
                    {
                        nightlyDownload = true;
                    }
                    UpdaterWindowsManager.ShowWindow(newerVersion.VersionData.VersionChanges, _actionGraph,
                                                     nightlyDownload, control);
                    UpdaterWindowsManager.DownloadUpdatesWindow.Closed += OnUpdateDialogClose;
                    UpdaterWindowsManager.DownloadWindowLoop();
                }
                else
                {
                    DeleteDirectory(AuxiliaryDirectory);
                }
            }
        }

        private static void DownloadUpdateFiles(string downloadPath, IEnumerable<FileInformation> listOfCurrentFiles,
                                                VersionObject newerVersion)
        {
            bool choice;
            try
            {
                choice = UpdaterWindowsManager.DownloadUpdatesWindow.Choice;
            }
            catch
            {
                choice = (Directory.GetFiles(AuxiliaryDirectory).Length > 1);
            }
            if (choice)
            {
                DownloadFiles(downloadPath, listOfCurrentFiles, newerVersion);
            }
            else
            {
                DeleteDirectory(AuxiliaryDirectory);
            }
        }

        public static void DeleteFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    Log.Info("File: " + path + " successfully deleted");
                }
            }
            catch
            {
                Log.Error("Error deleting File: " + path);
            }
        }

        private static bool NewerVersion(string newerVersionName)
        {
            try
            {
                if (newerVersionName.Length == lengthOfStableVersion)
                    if (Int64.Parse(newerVersionName) >
                        Int64.Parse(_fullNumericVersion.Substring(0, lengthOfStableVersion)))
                        return true;
                    else
                    {
                    }
                else if (newerVersionName.Length == lengthOfNightlyVersion)
                    if (_fullNumericVersion.Length == lengthOfNightlyVersion)
                        if (Int64.Parse(newerVersionName) > Int64.Parse(_fullNumericVersion))
                            return true;
                        else
                        {
                        }
                    else if (_fullNumericVersion.Length == lengthOfStableVersion)
                        if (Int64.Parse(newerVersionName.Substring(0, lengthOfStableVersion)) >=
                            Int64.Parse(_fullNumericVersion))
                            return true;
                return false;
            }
            catch
            {
                NaroMessage.Show("The new versioning file was modified unexpectedly.");
                return false;
            }
        }

        private static bool DownloadSpecificFile(string uri, string destinationPath)
        {
            try
            {
                if (destinationPath.Contains(ApplyUpdatesName))
                {
                    return true;
                }
                var webClient = new WebClient();
                MakeSureThatDestinationDirectoriesExist(destinationPath, currentPath);
                webClient.DownloadFile(new Uri(uri), currentPath + destinationPath + compressedFilesExtension);
            }
            catch
            {
                Log.Info("Failed to download : " + destinationPath);
                ChangeUpdateIcon(DowloadIconState.ConnectionProblems);
                return false;
            }
            try
            {
                UnpackFile(currentPath + destinationPath, compressedFilesExtension);
                return true;
            }
            catch
            {
                ChangeUpdateIcon(DowloadIconState.ConnectionProblems);
                Log.Info("Cannot access : " + currentPath + AuxiliaryDirectory + destinationPath +
                         compressedFilesExtension);
                return false;
            }
        }

        private static void UnpackFile(string path, string compressionExtension)
        {
            var dataString = File.ReadAllBytes(path + compressionExtension);
            var fileData = MeshTopoShapeInterpreter.Unpack(dataString);
            File.WriteAllBytes(path, fileData);
            File.Delete(path + compressionExtension);
        }

        private static void DownloadFiles(string downloadPath, IEnumerable<FileInformation> listOfCurrentFiles,
                                          VersionObject newerVersion)
        {
            ChangeUpdateIcon(DowloadIconState.Donwloading);
            var listOfFilesToBeDownloaded = ListOfFilesToBeAdded(newerVersion.ListOfFiles, listOfCurrentFiles);
            DowloadUpdateFiles(listOfFilesToBeDownloaded, downloadPath);
        }

        private static IEnumerable<FileInformation> ListOfFilesToBeAdded(IEnumerable<FileInformation> newList,
                                                                  IEnumerable<FileInformation> oldList)
        {
            var result = new List<FileInformation>();
            foreach (var newFile in newList)
            {
                if (newFile.DestinationPath.Contains(ApplyUpdatesName))
                {
                    continue;
                }
                try
                {
                    var isInList = false;
                    foreach (var oldFile in oldList)
                    {
                        if ((oldFile.Size != newFile.Size) || (oldFile.Hash != newFile.Hash) ||
                            (oldFile.DestinationPath != newFile.DestinationPath)) continue;
                        isInList = true;
                        break;
                    }
                    if (!isInList && !FileWasDownloaded(newFile))
                    {
                        Log.Info(newFile.DestinationPath +
                                 " is not in list but the size on disk is not equal to the size in the new version file");
                        result.Add(newFile);
                    }
                    else if (isInList && newFile.Size != GetLengthFromFile(newFile.DestinationPath))
                    {
                        if (newFile.Size != GetLengthFromFile(AuxiliaryDirectory + newFile.DestinationPath))
                        {
                            Log.Info(newFile.DestinationPath +
                                     " is in list but the size on disk is not equal to the size in the new version file");
                            result.Add(newFile);
                        }
                    }
                }
                catch
                {
                    result.Add(newFile);
                }
            }
            return result;
        }

        private static string GetLengthFromFile(string sourcePath)
        {
            string length;
            try
            {
                length = MeshTopoShapeInterpreter.FileToData(sourcePath).Length.ToString();
            }
            catch
            {
                return "0";
            }
            return length;
        }

        private static bool DowloadUpdateFiles(IEnumerable<FileInformation> list, string downloadPath)
        {
            foreach (var file in list)
            {
                if (
                    !DownloadSpecificFile(
                        downloadPath + file.DestinationPath.Replace('\\', '/') + compressedFilesExtension,
                        AuxiliaryDirectory + file.DestinationPath))
                {
                    return false;
                }
            }
            ChangeUpdateIcon(DowloadIconState.Finished);
            Directory.CreateDirectory(HelperDownloadDirectory);
            Log.Info("Download version files successfully compleated");
            return true;
        }

        private static bool FileWasDownloaded(FileInformation file)
        {
            try
            {
                if (File.Exists(currentPath + AuxiliaryDirectory + file.DestinationPath))
                {
                    if (GetLengthFromFile(AuxiliaryDirectory + file.DestinationPath) == file.Size)
                        return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        private static void CalculateNaroVersion(VersionObject currentVersion)
        {
            _fullNumericVersion = currentVersion.VersionData.VersionName;
        }

        private static void MoveWithReplaceInNaroCad(string sourceFileName, string destFileName)
        {
            if (File.Exists(currentPath + destFileName))
            {
                File.Delete(currentPath + destFileName);
            }
            MakeSureThatDestinationDirectoriesExist(destFileName, currentPath);
            File.Move(currentPath + sourceFileName, currentPath + destFileName);
        }

        private static void CalculateLengthOfNaroVersions()
        {
            lengthOfStableVersion = NaroAppConstantNames.Version.Split('.').Length;
            lengthOfNightlyVersion = lengthOfStableVersion + DateTime.Now.ToString("yyyyMMddHHmm").Length;
        }

        private static void DeleteUslessData(IEnumerable<string> filesToBeDeleted)
        {
            try
            {
                foreach (var file in filesToBeDeleted)
                {
                    File.Delete(file);
                }
            }
            catch
            {
                Log.Error("Error while deleting unused files");
                return;
            }
        }

        public static List<string> CreateListOfFilesToBeDeleted(IEnumerable<string> oldList, List<string> newList)
        {
            var result = new List<string>();
            foreach (var oldFile in oldList)
            {
                if (!newList.Contains(oldFile))
                {
                    result.Add(currentPath + oldFile);
                }
            }
            return result;
        }

        # endregion
    }
}