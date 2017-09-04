#region Usings

using System;

#endregion

namespace NaroTestSuite
{
    /// <summary>
    ///   Class used to debug unit tests without NUnit. 
    ///   This is mostly should used for complex suites or other 
    ///   things that don't want to to be inserted in unit tests 
    ///   for now as API can break or you just don't have NUnit 
    ///   framework debugging enable
    /// </summary>
    public static class StartupClass
    {
        /// <summary>
        /// </summary>
        [STAThread]
        public static void Main()
        {
        }
    }
}