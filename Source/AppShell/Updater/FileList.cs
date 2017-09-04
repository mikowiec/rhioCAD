#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using TreeData.Utils;

#endregion

namespace Updater
{
    public class FileList
    {
        #region Data members

        private const string CreateVersionFile = "CreateNewVersionFiles";
        private const string VersionFile = "Version";
        private const string StartString = "[Files]";
        private const string EndString = "[Tasks]";
        private const string SourceStart = "Source: ";
        private const string SourceEnd = ";";
        private const string DestinationStart = "DestDir: {app}";
        private const string DestinationEnd = ";";
        private const string DestinationNameStart = "DestName: ";
        private const string DestinationNameEnd = ";";
        private const char CommentedLine = ';';
        private const string AllFilesExtension = "*.*";
        private const string CertainFilesExtension = "*.";
        private static readonly FileList Instance = new FileList();

        #endregion

        #region Private Methods

        private FileList()
        {
            Initialize();
        }

        private void Initialize()
        {
            Clear();
            CreateListOfFiles();
        }

        private void CreateListOfFiles()
        {
            var fullIsFile = File.ReadAllLines(UpdateLogic.FullIssFilePath);
            AddFiles(fullIsFile, FindStartString(fullIsFile));
        }

        public static int FindStartString(string[] fullIssFile)
        {
            for (var index = 0; index < fullIssFile.Length; index++)
            {
                if (fullIssFile[index].Contains(StartString))
                    return index + 1;
            }
            return 0;
        }

        private void AddFiles(string[] fullIssFile, int index)
        {
            while (!fullIssFile[index].Contains(EndString))
            {
                Interpret(fullIssFile[index]);
                index++;
            }
        }

        public void Interpret(string line)
        {
            try
            {
                if (line[1] == CommentedLine || line.Contains(VersionFile))
                {
                    return;
                }
            }
            catch
            {
                return;
            }
            var currentLine = line;
            var source = Source(ref currentLine);
            var destination = Destination(ref currentLine);

            if (destination != "")
            {
                if (destination[0] == '\\')
                {
                    destination = destination.Substring(1);
                }
            }
            var destName = DestinationName(ref currentLine);
            if (string.IsNullOrEmpty(source))
                return;
            if (!string.IsNullOrEmpty(destName))
            {
                AddOneFile(source, destination, destName);
            }
            else if (string.IsNullOrEmpty(destination))
            {
                InterpretSource(source);
            }
            else
            {
                InterpretSource(source, destination);
            }
        }

        private void InterpretSource(string source)
        {
            if (source.Contains(AllFilesExtension))
            {
                InterpretSourceWithAllFilesExtension(source);
            }
            else if (source.Contains(CertainFilesExtension))
            {
                var fileExtensionFormat = GetFileExtensionFormat(source);
                InterpretSourceCertainFilesExtension(source, fileExtensionFormat);
            }
            else
            {
                AddOneFile(source);
            }
        }

        private static string GetFileExtensionFormat(string source)
        {
            return source.Substring(source.IndexOf(CertainFilesExtension));
        }

        private void InterpretSourceCertainFilesExtension(string source, string fileExtensionFormat)
        {
            AddCertainFilesFromDirectory(source.Substring(0, source.Length - fileExtensionFormat.Length),
                                         fileExtensionFormat);
        }

        private void InterpretSourceWithAllFilesExtension(string source)
        {
            AddAllFilesFromDirectory(source.Substring(0, source.Length - AllFilesExtension.Length));
        }

        private void InterpretSourceWithAllFilesExtension(string source, string destination)
        {
            AddAllFilesFromDirectory(source.Substring(0, source.Length - AllFilesExtension.Length), destination);
        }

        private void InterpretSourceCertainFilesExtension(string source, string fileExtension, string destination)
        {
            AddCertainFilesFromDirectory(source.Substring(0, source.Length - fileExtension.Length), fileExtension,
                                         destination);
        }

        private void InterpretSource(string source, string destination)
        {
            if (source.Contains(AllFilesExtension))
            {
                InterpretSourceWithAllFilesExtension(source, destination);
            }
            else if (source.Contains(CertainFilesExtension))
            {
                InterpretSourceCertainFilesExtension(source, GetFileExtensionFormat(source), destination);
            }
            else
            {
                AddOneFile(source, destination);
            }
        }

        private static string GetUsefulString(ref string line, string startString, string endString)
        {
            var startIndex = GetStartIndex(ref line, startString);
            return startIndex == 0 ? String.Empty : line.Substring(startIndex, GetEndIndex(line, endString) - startIndex);
        }

        public static int GetStartIndex(ref string line, string startString)
        {
            return line.IndexOf(startString) == -1 ? 0 : line.IndexOf(startString) + startString.Length;
        }

        public static int GetEndIndex(string line, string endString)
        {
            var endIndex = line.IndexOf(endString);
            return endIndex == -1? line.Length : endIndex;
        }

        public static string Source(ref string line)
        {
            try
            {
                var result = GetUsefulString(ref line, SourceStart, SourceEnd);
                line = line.Substring(line.IndexOf(result) + result.Length + SourceEnd.Length);
                return result;
            }
            catch
            {
                return String.Empty;
            }
        }

        public static string Destination(ref string line)
        {
            try
            {
                var helperResult = GetUsefulString(ref line, DestinationStart, DestinationEnd);
                var result = helperResult;
                if (helperResult != "")
                {
                    if (helperResult[helperResult.Length - 1] != '\\')
                        result = helperResult + '\\';
                }
                if (line.Length == line.IndexOf(helperResult) + helperResult.Length)
                {
                    line = "";
                    return result;
                }
                if (result != "")
                    line = line.Substring(line.IndexOf(helperResult) + helperResult.Length + SourceEnd.Length);
                return result;
            }
            catch
            {
                return String.Empty;
            }
        }

        public static string DestinationName(ref string line)
        {
            try
            {
                line = line.Substring(line.IndexOf(DestinationNameStart));
                var result = GetUsefulString(ref line, DestinationNameStart, DestinationNameEnd);
                if (line.Length == line.IndexOf(result) + result.Length)
                {
                    line = "";
                    return result;
                }
                line = line.Substring(line.IndexOf(result) + result.Length + SourceEnd.Length);
                return result;
            }
            catch
            {
                return String.Empty;
            }
        }

        #endregion

        #region Methods

        public List<FileInformation> ListOfFiles { get; private set; }

        public void Clear()
        {
            ListOfFiles = new List<FileInformation>();
        }

        public static FileList GetFileList()
        {
            return Instance;
        }

        public void AddOneFile(string sourcePath)
        {
            ListOfFiles.Add(new FileInformation(sourcePath));
        }

        public void AddOneFile(string sourcePath, string destinationPath)
        {
            var fileName = Path.GetFileName(sourcePath);
            if(fileName == null) 
                throw new NaroException("Invalid Path: " + sourcePath);
            AddOneFile(sourcePath, destinationPath, fileName);
        }

        public void AddOneFile(string sourcePath, string destinationPath, string destinationName)
        {
            ListOfFiles.Add(new FileInformation(sourcePath, destinationPath + destinationName));
        }

        private void AddCertainFilesFromDirectory(string sourcePath, string sourceType, string destinationPath)
        {
            var filePaths = Directory.GetFiles(sourcePath, sourceType);
            foreach (var file in filePaths)
            {
                AddOneFile(file, destinationPath);
            }
        }

        private void AddCertainFilesFromDirectory(string sourcePath, string sourceType)
        {
            var filePaths = Directory.GetFiles(sourcePath, sourceType);
            foreach (var file in filePaths)
            {
                if (file.Contains(CreateVersionFile) || file.Contains(VersionFile))
                    continue;
                AddOneFile(file, "");
            }
        }

        private void AddAllFilesFromDirectory(string sourcePath, string destinationPath)
        {
            var filePaths = Directory.GetFiles(sourcePath);
            foreach (var file in filePaths)
                AddOneFile(file, destinationPath);
        }

        private void AddAllFilesFromDirectory(string sourcePath)
        {
            var filePaths = Directory.GetFiles(sourcePath);
            foreach (var file in filePaths)
                AddOneFile(file, "");
        }

        #endregion
    }
}