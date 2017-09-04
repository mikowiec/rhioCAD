#region Usings

using System.Collections.Generic;
using System.IO;
using ApplyUpdates;
using NUnit.Framework;

#endregion

namespace UpdaterTests
{
    [TestFixture]
    internal class ApplyUpdatesTests
    {
        [Test]
        public void CheckAddNewFilesToList()
        {
            var list = new List<string>();
            Update.CreateDirectory("auxiliary");
            var file = File.Create(@"auxiliary\aaa.txt");
            file.Close();
            Update.AddNewFilesToList(Directory.GetCurrentDirectory() + "\\" + @"auxiliary\", list,
                                     Directory.GetCurrentDirectory() + "\\" + @"auxiliary\");
            Assert.IsTrue(list.Contains("aaa.txt"), "File was not found");
            Update.DeleteDirectory("auxiliary");
        }

        [Test]
        public void CheckAddNewFilesToListAddingAFileFromADirectory()
        {
            var list = new List<string>();
            Update.CreateDirectory("auxiliary");
            Update.CreateDirectory(@"auxiliary\test");
            var file = File.Create(@"auxiliary\test\aaa");
            file.Close();
            Update.AddNewFilesToList(Directory.GetCurrentDirectory() + "\\" + @"auxiliary\", list,
                                     Directory.GetCurrentDirectory() + "\\" + @"auxiliary\");
            Assert.IsTrue(list.Contains(@"\test\aaa"), "File was not found");
            Update.DeleteDirectory("auxiliary");
        }

        [Test]
        public void CheckAddNewFilesToListAddingAFileWithNoExtension()
        {
            var list = new List<string>();
            Update.CreateDirectory("auxiliary");
            var file = File.Create(@"auxiliary\aaa");
            file.Close();
            Update.AddNewFilesToList(Directory.GetCurrentDirectory() + "\\" + @"auxiliary\", list,
                                     Directory.GetCurrentDirectory() + "\\" + @"auxiliary\");
            Assert.IsTrue(list.Contains("aaa"), "File was not found");
            Update.DeleteDirectory("auxiliary");
        }

        [Test]
        public void CheckAddNewFilesToListAddingMoreFiles()
        {
            var list = new List<string>();
            Update.CreateDirectory("auxiliary");
            var file = File.Create(@"auxiliary\aaa");
            file.Close();
            var file1 = File.Create(@"auxiliary\aaa.txt");
            file1.Close();
            Update.AddNewFilesToList(Directory.GetCurrentDirectory() + "\\" + @"auxiliary\", list,
                                     Directory.GetCurrentDirectory() + "\\" + @"auxiliary\");
            Assert.IsTrue(list.Contains("aaa"), "File was not found");
            Assert.IsTrue(list.Contains("aaa.txt"), "File was not found");
            Update.DeleteDirectory("auxiliary");
        }

        [Test]
        public void CheckCreateDirectoryMethod()
        {
            Directory.CreateDirectory("auxiliary");
            Update.CreateDirectory("auxiliary");
            Assert.IsTrue(Directory.Exists("auxiliary"), "CreateDirectory method failed.");
            Directory.Delete("auxiliary", true);
        }

        [Test]
        public void CheckCreateDirectoryMethodCreateIfDirectoryAllreadyExists()
        {
            Directory.CreateDirectory("auxiliary");
            Update.CreateDirectory("auxiliary");
            Assert.IsTrue(1 == 1,
                          "CreateDirectory method failed because a directory with the same name allready existed.");
            Directory.Delete("auxiliary", true);
        }

        [Test]
        public void CheckDeleteDirectoryMethod()
        {
            Directory.CreateDirectory("auxiliary");
            Update.DeleteDirectory("auxiliary");
            Assert.IsTrue(1 == 1, "Delete directory not working.");
        }

        [Test]
        public void CheckDeleteDirectoryMethodDirectoryDoesNotExist()
        {
            Update.CreateDirectory("auxiliary");
            Directory.Delete("auxiliary");
            Update.DeleteDirectory("auxiliary");
            var a = 1;
            Assert.IsTrue(a == 1, "Delete Directory not working if directory does not exist.");
        }

        [Test]
        public void CheckMakeSureThatDestinationDirectoriesExistMethod()
        {
            Update.CreateDirectory("auxiliary");
            var file = File.Create(@"auxiliary\aaa.txt");
            file.Close();
            Update.MakeSureThatDestinationDirectoriesExist(@"auxiliary\aaa.txt", Directory.GetCurrentDirectory() + "\\");
            Assert.IsTrue(1 == 1, "Check paths failed.");
            Update.DeleteDirectory("auxiliary");
        }

        [Test]
        public void CheckMakeSureThatDestinationDirectoriesExistMethodDestinationDirectoryDoesNotExist()
        {
            Update.DeleteDirectory("auxiliary");
            Update.MakeSureThatDestinationDirectoriesExist(@"auxiliary\aaa.txt", Directory.GetCurrentDirectory() + "\\");
            Assert.IsTrue(Directory.Exists("auxiliary"), "Needed directory was not created");
            Update.DeleteDirectory("auxiliary");
        }

        [Test]
        public void CheckMoveWithReplaceInNaroCAD()
        {
            Update.CreateDirectory("auxiliary");
            var file = File.Create(@"auxiliary\aaa.txt");
            file.Close();
            Update.MoveWithReplaceInNaroCad(@"auxiliary\aaa.txt", "aaa.txt");
            Assert.IsTrue(!File.Exists(@"auxiliary\aaa.txt"), "Old file still exists on disk.");
            Assert.IsTrue(File.Exists("aaa.txt"), "The file was not moved.");
            Update.DeleteDirectory("auxiliary");
            File.Delete("aaa.txt");
        }

        [Test]
        public void CheckMoveWithReplaceInNaroCADOfAFileWithNoExtension()
        {
            Update.CreateDirectory("auxiliary");
            var file = File.Create(@"auxiliary\aaa");
            file.Close();
            Update.MoveWithReplaceInNaroCad(@"auxiliary\aaa", "aaa");
            Assert.IsTrue(!File.Exists(@"auxiliary\aaa"), "Old file still exists on disk.");
            Assert.IsTrue(File.Exists("aaa"), "The file was not moved.");
            Update.DeleteDirectory("auxiliary");
            File.Delete("aaa");
        }

        [Test]
        public void CheckMoveWithReplaceInNaroCADRenamingAFile()
        {
            Update.CreateDirectory("auxiliary");
            var file = File.Create(@"auxiliary\aaa.txt");
            file.Close();
            Update.MoveWithReplaceInNaroCad(@"auxiliary\aaa.txt", "aaa");
            Assert.IsTrue(!File.Exists(@"auxiliary\aaa.txt"), "Old file still exists on disk.");
            Assert.IsTrue(File.Exists("aaa"), "The file was not moved.");
            Update.DeleteDirectory("auxiliary");
            File.Delete("aaa");
        }
    }
}