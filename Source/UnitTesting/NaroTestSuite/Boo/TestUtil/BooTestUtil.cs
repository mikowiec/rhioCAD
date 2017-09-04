#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Naro.Infrastructure.Interface.Boo;
using NaroConstants.Names;
using NaroPipes.Actions;
using NUnit.Framework;
using TreeData.NaroData;

#endregion

namespace NaroTestSuite.Boo.TestUtil
{
    internal static class BooTestUtil
    {
        public static void ExecuteDirectory(string directoryName, ActionsGraph actionsGraph)
        {
            var sortedFileNames = GetBooFileList(directoryName);
            var document =
                actionsGraph.InputContainer[InputNames.Document].GetData(NotificationNames.GetValue).Get<Document>();

            foreach (var fileName in sortedFileNames)
            {
                try
                {
                    // Set the script location/execution path
                    BooUtil.ExecuteBooScript(actionsGraph, fileName);
                }
                catch (Exception ex)
                {
                    Assert.IsTrue(false, "Error executing file: " + fileName + " Exception: " + ex.Message);
                }
                try
                {
                    document.Undo();
                }
                catch (Exception ex)
                {
                    Assert.IsTrue(false, "Error on undo file: " + fileName + " Exception: " + ex.Message);
                }
            }
        }

        private static IEnumerable<string> GetBooFileList(string directoryName)
        {
            var di = new DirectoryInfo(directoryName);
            var files = di.GetFiles("*.boo");
            var sd = new SortedDictionary<string, int>();
            foreach (var fileName in files)
                sd[fileName.FullName] = 1;
            return sd.Keys.ToList();
        }
    }
}