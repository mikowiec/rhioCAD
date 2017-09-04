#region Usings

using System.IO;
using NUnit.Framework;
using Updater;

#endregion

namespace UpdaterTests
{
    [TestFixture]
    internal class FileInformationTests
    {
        [Test]
        public void CheckIfFileSizeCanBeRedFromAFileWithoutExtension()
        {
            var isValid = true;
            var file = File.Create("test");
            file.Close();
            try
            {
                FileInformation.GetSize("test");
            }
            catch
            {
                isValid = false;
            }
            File.Delete("test");
            Assert.IsTrue(isValid, "Can't read information from a file without extension");
            File.Delete("test");
        }

        [Test]
        public void CheckIfFileSizeCanBeRedFromAFileWithoutExtensionInADirectory()
        {
            var isValid = true;
            var fileName = "test";
            var directoryName = "test";
            fileName = directoryName + "\\" + fileName;
            Directory.CreateDirectory(directoryName);
            var file = File.Create(fileName);
            file.Close();
            try
            {
                FileInformation.GetSize(fileName);
            }
            catch
            {
                isValid = false;
            }
            Directory.Delete("test", true);
            Assert.IsTrue(isValid, "Can't read information from a file without extension, in a directory");
        }

        [Test]
        public void CheckIfGetFilesReturnsFilesWithNoExtension()
        {
            var fileName = "test";
            var directoryName = "test";
            fileName = directoryName + "\\" + fileName;
            Directory.CreateDirectory(directoryName);
            var file = File.Create(fileName);
            file.Close();
            var filePaths = Directory.GetFiles(directoryName);
            Directory.Delete(directoryName, true);
            Assert.IsTrue(filePaths.Length == 1, "Can't read information from a file without extension");
        }

        [Test]
        public void CheckIfHashCanBeRedFromAFileWithoutExtension()
        {
            var isValid = true;
            var file = File.Create("test");
            file.Close();
            try
            {
                FileInformation.GetHash("test");
            }
            catch
            {
                isValid = false;
            }
            File.Delete("test");
            Assert.IsTrue(isValid, "Can't read information from a file without extension");
            File.Delete("test");
        }

        [Test]
        public void CheckIfHashCanBeRedFromAFileWithoutExtensionInADirectory()
        {
            var isValid = true;
            var fileName = "test";
            var directoryName = "test";
            fileName = directoryName + "\\" + fileName;
            Directory.CreateDirectory(directoryName);
            var file = File.Create(fileName);
            file.Close();
            try
            {
                FileInformation.GetHash(fileName);
            }
            catch
            {
                isValid = false;
            }
            Directory.Delete("test", true);
            Assert.IsTrue(isValid, "Can't read information from a file without extension, in a directory");
        }
    }
}