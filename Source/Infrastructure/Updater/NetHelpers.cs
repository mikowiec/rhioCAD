#region License
/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */
#endregion

#region Usings
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;

using ICSharpCode.SharpZipLib.Zip;
#endregion

namespace Updater
{
	public static class NetHelpers
	{
		public static SortedDictionary<string, int> GetFileVersionsFromXml(string fileIndex)
        {
            var result = new SortedDictionary<string, int>();
            XmlDocument doc = new XmlDocument();

            doc.Load(fileIndex);
            var node = doc.ChildNodes[0];
            foreach (XmlNode childNode in node.ChildNodes)
            {
                string fileName = childNode.Attributes["Name"].Value;
                int version = Convert.ToInt32(childNode.Attributes["Version"].Value);
                result[fileName] = version;
            }
            return result;
        }
		
		public static string repositoryIndex = "filelist.xml";
        public static string localIndex = "localfilelist.xml";

        public static List<string> GetUpdateFileList(bool updateLocalIndex)
        {            
            DownloadRepositoryFile(repositoryIndex);
            var result = new List<string>();
            if (!File.Exists(localIndex))
            {
            	if(updateLocalIndex)
            	{
                	File.Copy(repositoryIndex, localIndex);
            	}
                var filesToDownload = GetFileVersionsFromXml(repositoryIndex);
                foreach (var file in filesToDownload.Keys)
                {
                	result.Add(file);
                }
            }
            else
            {
                var repositoryFiles = GetFileVersionsFromXml(repositoryIndex);
                var localFiles = GetFileVersionsFromXml(localIndex);
                foreach (var file in repositoryFiles.Keys)
                {
                    if (!localFiles.ContainsKey(file) || localFiles[file] < repositoryFiles[file])
                    {
                        result.Add(file);
                    }
                }
            }
            return result;
        }

        public static void DoUpdateFileList(List<string> updatedFileList)
        {
            foreach (var fileToUpdate in updatedFileList)
            {
                DownloadRepositoryFile(fileToUpdate);
            }
            if (File.Exists(localIndex))
            {
                File.Delete(localIndex);
            }
            File.Copy(repositoryIndex, localIndex);
        }
        

		static string repositoryUrl = "http://cipdevel.com/download/Naro/";

        public static void DownloadRepositoryFile(string archiveName)
        {
            WebClient wc = new WebClient();
            wc.DownloadFile(repositoryUrl + archiveName + ".zip", archiveName + ".zip");
            ExtractArchieveLocally(archiveName);
        }

        static void ExtractArchieveLocally(string archiveName)
        {
            try
            {
                using (ZipInputStream s = new ZipInputStream(File.OpenRead(archiveName + ".zip")))
                {
                    ZipEntry theEntry;
                    while ((theEntry = s.GetNextEntry()) != null)
                    {
                        string fileName = Path.GetFileName(theEntry.Name);

                        if (fileName != String.Empty)
                        {
                            using (FileStream streamWriter = File.Create(theEntry.Name))
                            {
                                int size = 2048;
                                byte[] data = new byte[2048];
                                while (true)
                                {
                                    size = s.Read(data, 0, data.Length);
                                    if (size > 0)
                                    {
                                        streamWriter.Write(data, 0, size);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch { }
            File.Delete(archiveName + ".zip");
        }
	}
}
