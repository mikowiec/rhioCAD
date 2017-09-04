#region Usings

using System.Collections.Generic;
using System.IO;
using ApplyUpdates;
using NUnit.Framework;
using Updater;

#endregion

namespace UpdaterTests
{
    [TestFixture]
    internal class FileListTests
    {
        private void CreateTestingData()
        {
            DeleteTestingData();
            Update.CreateDirectory("auxiliary");
            var file = File.Create(@"auxiliary\aaa");
            file.Close();
            Update.CreateDirectory(@"auxiliary\dir1");
            var file2 = File.Create(@"auxiliary\dir1\a1.txt");
            file2.Close();
            var file3 = File.Create(@"auxiliary\dir1\a2.txt");
            file3.Close();
            var file4 = File.Create(@"auxiliary\dir1\b1");
            file4.Close();
            var file5 = File.Create(@"auxiliary\dir1\b2");
            file5.Close();
        }

        private void DeleteTestingData()
        {
            Update.DeleteDirectory("auxiliary");
        }

        private static string OldISSPath = UpdateLogic.FullIssFilePath;

        private void FixPaths()
        {
            UpdateLogic.FullIssFilePath = @"..\..\" + UpdateLogic.FullIssFilePath;
            ModifyFiles();
            UpdateLogic.FullIssFilePath = UpdateLogic.FullIssFilePath + "1";
        }

        private void ModifyFiles()
        {
            var fullIssFile = File.ReadAllLines(UpdateLogic.FullIssFilePath);
            var newIss = new List<string>();
            ModifyLines(fullIssFile, FindStartString(fullIssFile), ref newIss);
        }

        private void ModifyLines(string[] fullIssFile, int index, ref List<string> newIss)
        {
            newIss.Add(fullIssFile[index - 1]);
            while (!fullIssFile[index].Contains("[Tasks]"))
            {
                ModifyLine(fullIssFile[index], ref newIss);
                index++;
            }
            newIss.Add(fullIssFile[index]);
            WriteLines(newIss);
        }

        private void WriteLines(List<string> newIss)
        {
            var aa = File.Create(Directory.GetCurrentDirectory() + "\\" + UpdateLogic.FullIssFilePath + "1");
            aa.Close();
            TextWriter tw = new StreamWriter(Directory.GetCurrentDirectory() + "\\" + UpdateLogic.FullIssFilePath + "1");
            foreach (var element in newIss)
            {
                tw.WriteLine(element);
            }
            tw.Close();
        }

        private void ModifyLine(string currLine, ref List<string> newIss)
        {
            var line = currLine;
            if (line.Length > 8)
            {
                if (line[8] == '.')
                {
                    line = line.Insert(8, @"..\..\");
                }
                else if (line[8] == 'V' || line[8] == 'o')
                {
                    line = line.Insert(8, @"..\..\..\..\bin\debug\");
                }
            }
            newIss.Add(line);
        }

        private int FindStartString(string[] fullIssFile)
        {
            for (var index = 0; index < fullIssFile.Length; index++)
            {
                if (fullIssFile[index].Contains("[Files]"))
                {
                    return index + 1;
                }
            }
            return 0;
        }

        [Test]
        public void CheckDestinationMethod()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            var line = @"Source: ..\..\bin\Release\*.dll; DestDir: {app}; Flags: ignoreversion";
            Assert.IsTrue(FileList.Source(ref line) == @"..\..\bin\Release\*.dll", "Incorrect source path.");
            Assert.IsTrue(FileList.Destination(ref line) == "", "Incorrect destination path.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckDestinationMethodWhenBackslashAndSemicolonAreMissing()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            var line = @"Source: c:\occ\ros\src\SHMessage\SHAPE.us; DestDir: {app}\occ\ros\src\SHMessage";
            Assert.IsTrue(FileList.Source(ref line) == @"c:\occ\ros\src\SHMessage\SHAPE.us", "Incorrect source path.");
            Assert.IsTrue(FileList.Destination(ref line) == @"\occ\ros\src\SHMessage\", "Incorrect destination path.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckDestinationMethodWhenBackslashIsMissing()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            var line = @"Source: ..\..\bin\debug\Wpf\TipsPages\*.*; DestDir: {app}\Wpf\TipsPages; Flags: ignoreversion";
            Assert.IsTrue(FileList.Source(ref line) == @"..\..\bin\debug\Wpf\TipsPages\*.*", "Incorrect source path.");
            Assert.IsTrue(FileList.Destination(ref line) == @"\Wpf\TipsPages\", "Incorrect destination path.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckDestinationNameMethod()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            var line = @"Source: ..\..\Source\Images\view_comp_on_copy.ico; DestDir: {app}; DestName: naro.ico";
            Assert.IsTrue(FileList.Source(ref line) == @"..\..\Source\Images\view_comp_on_copy.ico",
                          "Incorrect source path.");
            Assert.IsTrue(FileList.Destination(ref line) == "", "Incorrect destination path.");
            Assert.IsTrue(FileList.DestinationName(ref line) == "naro.ico", "Incorrect destination name path.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckFindStartStringMethod()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            var fullIssFile = new[] {"aaa", "[Files]"};
            Assert.IsTrue(FileList.FindStartString(fullIssFile) == 2, "Incorrect start index.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckGetEndIndexMethod()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            var line = @"Source: ..\..\Source\Images\view_comp_on_copy.ico; DestDir: {app}; DestName: naro.ico";
            Assert.IsTrue(FileList.GetEndIndex(line, ":") == 6, "Incorrect end index.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckGetEndIndexMethodWhenItDoesntExist()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            var line = @"Source";
            Assert.IsTrue(FileList.GetEndIndex(line, "::") == 6, "Incorrect end index.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckGetStartIndexMethod()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            var line = @"Source: ..\..\Source\Images\view_comp_on_copy.ico; DestDir: {app}; DestName: naro.ico";
            Assert.IsTrue(FileList.GetStartIndex(ref line, ":") == 7, "Incorrect start index.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckGetStartIndexMethodWhenItDoesntExist()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            var line = @"Source";
            Assert.IsTrue(FileList.GetStartIndex(ref line, "::") == 0, "Incorrect start index.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckIfAddOneFileWith2ParametersWorks()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");
            var file = File.Create("aaa.txt");
            file.Close();
            fileList.AddOneFile("aaa.txt", "bbb\\");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].SourcePath == "aaa.txt",
                          "File source path is incorrect.");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].DestinationPath == @"bbb\aaa.txt",
                          "File destination path is incorrect.");
            File.Delete("aaa.txt");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckIfAddOneFileWith2ParametersWorksWhenAddingAFileFromADirectory()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            Directory.CreateDirectory("test");
            var file = File.Create("test" + "\\" + "aaa.txt");
            file.Close();
            fileList.AddOneFile("test" + "\\" + "aaa.txt", "bbb\\");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].SourcePath == @"test\aaa.txt",
                          "File source path is incorrect.");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].DestinationPath == @"bbb\aaa.txt",
                          "File destination path is incorrect.");
            Directory.Delete("test", true);
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckIfAddOneFileWith2ParametersWorksWhenAddingAFileWithNoExtensionFromADirectory()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            Directory.CreateDirectory("test");
            var file = File.Create("test" + "\\" + "aaa");
            file.Close();
            fileList.AddOneFile("test" + "\\" + "aaa", "bbb\\");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].SourcePath == @"test\aaa",
                          "File source path is incorrect.");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].DestinationPath == @"bbb\aaa",
                          "File destination path is incorrect.");
            Directory.Delete("test", true);
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckIfAddOneFileWith2ParametersWorksWhenFileHasNoExtension()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");
            var file = File.Create("aaa");
            file.Close();
            fileList.AddOneFile("aaa", "bbb\\");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].SourcePath == "aaa", "File source path is incorrect.");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].DestinationPath == @"bbb\aaa",
                          "File destination path is incorrect.");
            File.Delete("aaa");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckIfAddOneFileWith3ParametersWorksWhenAddingAFileWithNoExtensionFromADirectory()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            Directory.CreateDirectory("test");
            var file = File.Create("test" + "\\" + "aaa");
            file.Close();
            fileList.AddOneFile("test" + "\\" + "aaa", "bbb\\", "ccc.txt");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].SourcePath == @"test\aaa",
                          "File source path is incorrect.");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].DestinationPath == @"bbb\ccc.txt",
                          "File destination path is incorrect.");
            Directory.Delete("test", true);
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckIfAddOneFileWorks()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");
            var file = File.Create("aaa.txt");
            file.Close();
            fileList.AddOneFile("aaa.txt");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].SourcePath.Contains("aaa.txt"),
                          "File source path is incorrect.");
            File.Delete("aaa.txt");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckIfAddOneFileWorksWhenAddingAFileFromADirectory()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            Directory.CreateDirectory("test");
            var file = File.Create("test" + "\\" + "aaa.txt");
            file.Close();
            fileList.AddOneFile("test" + "\\" + "aaa.txt");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].SourcePath.Contains(@"test\aaa.txt"),
                          "File source path is incorrect.");
            Directory.Delete("test", true);
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckIfAddOneFileWorksWhenAddingAFileWithNoExtensionFromADirectory()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            Directory.CreateDirectory("test");
            var file = File.Create("test" + "\\" + "aaa");
            file.Close();
            fileList.AddOneFile("test" + "\\" + "aaa");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].SourcePath.Contains(@"test\aaa"),
                          "File source path is incorrect.");
            Directory.Delete("test", true);
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckIfAddOneFileWorksWithFilesThatHaveNoExtension()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");
            var file = File.Create("aaa");
            file.Close();
            fileList.AddOneFile("aaa");
            Assert.IsTrue(FileList.GetFileList().ListOfFiles[0].SourcePath.Contains("aaa"),
                          "File source path is incorrect.");
            File.Delete("aaa");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckIfClearMethodWorks()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckInterpretMethodLineOnlyWithSource()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");
            CreateTestingData();
            fileList.Interpret(@"Source: auxiliary\aaa; DestDir: {app}; Flags: ignoreversion");
            DeleteTestingData();
            Assert.IsTrue(fileList.ListOfFiles[0].SourcePath == @"auxiliary\aaa", "Incorrect file.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckInterpretMethodLineOnlyWithSourceForAllTypesOfFiles()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");
            CreateTestingData();
            fileList.Interpret(@"Source: auxiliary\dir1\*.*; DestDir: {app}; Flags: ignoreversion");
            DeleteTestingData();
            Assert.IsTrue(fileList.ListOfFiles[0].SourcePath == @"auxiliary\dir1\a1.txt", "Incorrect file.");
            Assert.IsTrue(fileList.ListOfFiles[1].SourcePath == @"auxiliary\dir1\a2.txt", "Incorrect file.");
            Assert.IsTrue(fileList.ListOfFiles[2].SourcePath == @"auxiliary\dir1\b1", "Incorrect file.");
            Assert.IsTrue(fileList.ListOfFiles[3].SourcePath == @"auxiliary\dir1\b2", "Incorrect file.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckInterpretMethodLineOnlyWithSourceForSpecificTypesOfFiles()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");
            CreateTestingData();
            fileList.Interpret(@"Source: auxiliary\dir1\*.txt; DestDir: {app}; Flags: ignoreversion");
            DeleteTestingData();
            Assert.IsTrue(fileList.ListOfFiles[0].SourcePath == @"auxiliary\dir1\a1.txt", "Incorrect file.");
            Assert.IsTrue(fileList.ListOfFiles[1].SourcePath == @"auxiliary\dir1\a2.txt", "Incorrect file.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckInterpretMethodLineWithSourceAndDestination()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");
            CreateTestingData();
            fileList.Interpret(@"Source: auxiliary\*.*; DestDir: {app}test; Flags: ignoreversion");
            DeleteTestingData();
            Assert.IsTrue(fileList.ListOfFiles[0].DestinationPath == @"test\aaa", "Incorrect file.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckInterpretMethodLineWithSourceDestinationAndDestinationName()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");
            CreateTestingData();
            fileList.Interpret(@"Source: auxiliary\aaa; DestDir: {app}test; Flags: ignoreversion DestName: naro.ico");
            DeleteTestingData();
            Assert.IsTrue(fileList.ListOfFiles[0].DestinationPath == @"test\naro.ico", "Incorrect file.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckInterpretMethodLineWithoutSource()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");
            CreateTestingData();
            fileList.Interpret(@"DestDir: {app}; Flags: ignoreversion");
            DeleteTestingData();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Incorrect file.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }

        [Test]
        public void CheckSourceMethod()
        {
            FixPaths();
            var fileList = FileList.GetFileList();
            fileList.Clear();
            Assert.IsTrue(fileList.ListOfFiles.Count == 0, "Clear doesn't empty the list of files.");

            var line = @"Source: ..\..\bin\Release\*.dll; DestDir: {app}; Flags: ignoreversion";
            Assert.IsTrue(FileList.Source(ref line) == @"..\..\bin\Release\*.dll", "Incorrect source path.");
            File.Delete(UpdateLogic.FullIssFilePath);
            UpdateLogic.FullIssFilePath = OldISSPath;
        }
    }
}