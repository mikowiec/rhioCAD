#region Usings

using System;
using System.IO;
using System.Xml.Serialization;
using NaroConstants.Names;
using TreeData.AttributeInterpreter;
using Updater;

#endregion

namespace CreateNewVersionFiles
{
    public static class Program
    {
        #region Data members

        private const string StableString = "stable";
        private const string NightlyString = "nightly";
        private static string _fullNumericVersion;
        private static bool _creteNightlyVersionData = true;

        #endregion

        private static void Main(string[] args)
        {
            try
            {
                switch (args[0])
                {
                    case StableString:
                        _creteNightlyVersionData = false;
                        break;
                    case NightlyString:
                        _creteNightlyVersionData = true;
                        break;
                }
            }
            catch
            {
            }
            CreateNewVersionData();
        }

        #region Methods

        private static void CreateNewVersionData()
        {
            CreateVersionData();
            CreateCompressedFiles();
        }

        private static void CreateCompressedFiles()
        {
            UpdateLogic.DeleteDirectory(UpdateLogic.CompressedFilesDirectory);
            UpdateLogic.CreateDirectory(UpdateLogic.CompressedFilesDirectory);
            foreach (var file in FileList.GetFileList().ListOfFiles)
            {
                if (file.Hash ==
                    Compress(file.SourcePath,
                             UpdateLogic.CompressedFilesDirectory + file.DestinationPath +
                             UpdateLogic.CompressedFilesExtension).ToString())
                {
                    //File.Delete(compressedFilesDirectoryPath + file.DestinationPath + compressedFilesExtension);
                }
            }
            Compress(UpdateLogic.VersionFileName,
                     UpdateLogic.CompressedFilesDirectory + UpdateLogic.VersionFileName +
                     UpdateLogic.CompressedFilesExtension);
        }

        public static int Compress(string sourcePath, string destinationPath)
        {
            var filedata = MeshTopoShapeInterpreter.FileToData(sourcePath);
            var compressedData = MeshTopoShapeInterpreter.Pack(filedata);
            var str = Convert.ToBase64String(compressedData);
            UpdateLogic.MakeSureThatDestinationDirectoriesExist(destinationPath, UpdateLogic.CurrentPath);
            File.WriteAllBytes(destinationPath, compressedData);
            return str.GetHashCode();
        }

        private static void CreateVersionData()
        {
            _fullNumericVersion = string.Empty;
            var list = NaroAppConstantNames.Version.Split('.');
            foreach (var listElement in list)
            {
                _fullNumericVersion += listElement;
            }
            if (_creteNightlyVersionData)
            {
                CreateXmlVersionFile(_fullNumericVersion + DateTime.Now.ToString("yyyyMMddHHmm"));
            }
            else
            {
                CreateXmlVersionFile(_fullNumericVersion);
            }
        }

        private static void CreateXmlVersionFile(string versionName)
        {
            VersionObject.GetVersionObject().Initialize(versionName);
            SerializeToXml(VersionObject.GetVersionObject());
        }

        public static void SerializeToXml(VersionObject versionInstance)
        {
            var serializer = new XmlSerializer(typeof (VersionObject));
            TextWriter textWriter = new StreamWriter(UpdateLogic.VersionFileName);
            serializer.Serialize(textWriter, versionInstance);
            textWriter.Close();
        }

        #endregion
    }
}