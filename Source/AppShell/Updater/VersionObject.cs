#region Usings

using System.Collections.Generic;

#endregion

namespace Updater
{
    public class VersionObject
    {
        #region Data members

        private static readonly VersionObject Instance = new VersionObject();

        #endregion

        #region Methods

        private VersionObject()
        {
            Clear();
        }

        public VersionSpecificData VersionData { get; set; }

        public List<FileInformation> ListOfFiles { get; set; }

        public List<string> GetListOfFiles()
        {
            var result = new List<string>();
            foreach (var file in ListOfFiles)
            {
                result.Add(file.DestinationPath);
            }
            return result;
        }

        public void Initialize(string versionName)
        {
            Clear();
            VersionData.Initialize(versionName);
            ListOfFiles = FileList.GetFileList().ListOfFiles;
        }

        public void Clear()
        {
            ListOfFiles = new List<FileInformation>();
            VersionSpecificData.GetVersionSpecificData().Clear();
            VersionData = VersionSpecificData.GetVersionSpecificData();
        }

        public static VersionObject GetVersionObject()
        {
            return Instance;
        }

        #endregion
    }
}