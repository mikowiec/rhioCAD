#region Usages

using System;
using System.IO;
using ApiCommon;
using ApiToWrapper.CodeWriters;

#endregion

namespace ApiToWrapper
{
    internal static class MainClass
    {
        public static void Main(string[] args)
        {
            ApiProcessor.Process();
            var api = DataNodeLoader.FromFile(@"..\..\FULL.api");
            File.Copy(@"..\..\FULL.api", @"..\..\FULL.api_backup", true);
            var backupApi = DataNodeLoader.FromFile(@"..\..\FULL.api_backup");
            var occCodeWriter = new OccCodeWriter("..\\..\\", api.Set(Consts.Occ, Consts.Generator),
                                                  backupApi.Set(Consts.Occ, Consts.Generator));
            occCodeWriter.WriteCode();

            DataNodeLoader.ToFile(api, @"..\..\FULL.api_backup");

            ApiProcessor.RebuildVcProj(@"..\..\..\..\NaroOccCore\", @"..\..\..\..\NaroOccCore\vcproj-filelist.txt");
            Console.WriteLine("Finished processing");
            Console.ReadLine();
        }
    }
}