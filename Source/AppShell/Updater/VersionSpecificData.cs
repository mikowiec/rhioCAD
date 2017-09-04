#region Usings

using System.Collections.Generic;

#endregion

namespace Updater
{
    public class VersionSpecificData
    {
        #region Data members

        private static readonly VersionSpecificData Instance = new VersionSpecificData();

        #endregion

        #region Methods

        private VersionSpecificData()
        {
            Clear();
        }

        public string VersionName { get; set; }

        public List<string> VersionChanges { get; set; }

        public string VersionDescription { get; set; }

        public static VersionSpecificData GetVersionSpecificData()
        {
            return Instance;
        }

        public void Clear()
        {
            VersionName = null;
            VersionChanges = new List<string>();
            VersionDescription = null;
        }

        public void Initialize(string versionName)
        {
            Clear();
            VersionName = versionName;
            VersionChanges.Add("Narocad now works with sketch.");
            VersionChanges.Add("Constraints were added.");
            VersionChanges.Add("Some tools were temporarly removed.");
            VersionChanges.Add("New background.");
            VersionDescription = "";
        }

        #endregion
    }
}