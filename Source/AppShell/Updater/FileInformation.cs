#region Usings

using System;
using System.IO;
using TreeData.AttributeInterpreter;

#endregion

namespace Updater
{
    public class FileInformation
    {
        #region Data members

        #endregion

        #region Properties

        public string DestinationPath { get; set; }

        public string Size { get; set; }

        public string Hash { get; set; }

        public string SourcePath { get; set; }

        #endregion

        #region Methods

        public FileInformation()
        {
            SourcePath = String.Empty;
            DestinationPath = String.Empty;
            Size = String.Empty;
            Hash = String.Empty;
        }

        public FileInformation(string sourcePath)
        {
            SourcePath = sourcePath;
            DestinationPath = Path.GetFileName(sourcePath);
            Size = GetSize(sourcePath);
            Hash = GetHash(sourcePath);
        }

        public FileInformation(string sourcePath, string destinationPath)
        {
            SourcePath = sourcePath;
            DestinationPath = destinationPath;
            Size = GetSize(sourcePath);
            Hash = GetHash(sourcePath);
        }

        public static string GetSize(string sourcePath)
        {
            var data = MeshTopoShapeInterpreter.FileToData(sourcePath);
            return data.Length.ToString();
        }

        public static string GetHash(string sourcePath)
        {
            var data = MeshTopoShapeInterpreter.FileToData(sourcePath);
            var encoding = Convert.ToBase64String(data);
            return encoding.GetHashCode().ToString();
        }

        #endregion
    }
}