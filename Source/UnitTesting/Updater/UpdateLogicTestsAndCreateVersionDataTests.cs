#region Usings

using System.Collections.Generic;
using System.IO;
using ApplyUpdates;
using CreateNewVersionFiles;
using NUnit.Framework;
using Updater;

#endregion

namespace UpdaterTests
{
    [TestFixture]
    internal class UpdateLogicTestsAndCreateVersionDataTests
    {
        [Test]
        public void CheckCompressMethod()
        {
            var file = File.Create("aa.txt");
            file.Close();
            Program.Compress("aa.txt", "aa.dat");

            Assert.IsTrue(File.Exists("aa.dat"), "Compression failed.");

            File.Delete("aa1.txt");
        }

        [Test]
        public void CheckCreateListOfFilesToBeDeletedMethod()
        {
            var oldList = new List<string> {"aaa", "bbb", "ccc"};
            var newList = new List<string> {"aaa", "bbb", "ddd"};
            var list = UpdateLogic.CreateListOfFilesToBeDeleted(oldList, newList);
            Assert.IsTrue(list[0] == Directory.GetCurrentDirectory() + "\\" + "ccc",
                          "List of files to be deleted is generated incorectly.");
        }

        [Test]
        public void CheckDeleteFileMethod()
        {
            var file = File.Create("aaa.txt");
            file.Close();
            UpdateLogic.DeleteFile("aaa.txt");
            Assert.IsTrue(!File.Exists("aaa.txt"), "File still exists on disk.");
        }

        [Test]
        public void CheckDeleteFileMethodWhenFileDoesNotExist()
        {
            UpdateLogic.DeleteFile("aaa.txt");
            Assert.IsTrue(!File.Exists("aaa.txt"), "File exists on disk.");
        }

        [Test]
        public void CheckSerilizingAndDeserializeingOfVersionObject()
        {
            var versionObject = VersionObject.GetVersionObject();
            versionObject.Clear();
            versionObject.VersionData.VersionName = "aaa";
            versionObject.VersionData.VersionDescription = "bbb";
            versionObject.VersionData.VersionChanges.Add("c1");
            versionObject.VersionData.VersionChanges.Add("c2");
            var file = File.Create("aa.txt");
            file.Close();
            versionObject.ListOfFiles.Add(new FileInformation("aa.txt"));

            Update.MoveWithReplaceInNaroCad("Version.XML", "Version1.XML");

            Program.SerializeToXml(versionObject);
            versionObject.Clear();

            versionObject = UpdateLogic.DeserializeFromXml("Version.XML");
            Assert.IsTrue(versionObject.VersionData.VersionName == "aaa", "Version name not correct.");
            Assert.IsTrue(versionObject.VersionData.VersionDescription == "bbb", "Version description not correct.");
            Assert.IsTrue(versionObject.VersionData.VersionChanges[0] == "c1", "Version Change 1 not correct.");
            Assert.IsTrue(versionObject.VersionData.VersionChanges[1] == "c2", "Version Change 2 not correct.");
            Assert.IsTrue(versionObject.ListOfFiles[0].SourcePath == "aa.txt", "Source path not correct.");

            Update.MoveWithReplaceInNaroCad("Version1.XML", "Version.XML");
            File.Delete("aa.txt");
        }
    }
}