/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */

#region Usings

using System;
using System.IO;
using System.Net;
using System.Threading;

#endregion

namespace TransferTool
{
    /// <summary>
    ///   Description of UpdateLogic.
    /// </summary>
    public class UpdateLogic
    {
        private string _filePath;
        private string _downPath;

        private Thread thrDownload;
        private Stream strResponse;
        private Stream strLocal;
        private HttpWebRequest webRequest;
        private HttpWebResponse webResponse;
        private static int PercentProgress;

        public UpdateLogic(string filePath, string downPath)
        {
            _filePath = filePath;
            _downPath = downPath;
            thrDownload = new Thread(Download);
            thrDownload.Start();
        }

        public delegate void OnProgressUpdateHandler(Int64 BytesRead, Int64 TotalBytes);

        public OnProgressUpdateHandler OnProgressUpdate;

        public delegate void OnUpdateHandler();

        public OnUpdateHandler OnFinalize;
        public OnUpdateHandler OnError;

        private void Download()
        {
            using (WebClient wcDownload = new WebClient())
            {
                try
                {
                    webRequest = (HttpWebRequest) WebRequest.Create(_filePath);
                    webRequest.Credentials = CredentialCache.DefaultCredentials;
                    webResponse = (HttpWebResponse) webRequest.GetResponse();
                    Int64 fileSize = webResponse.ContentLength;

                    strResponse = wcDownload.OpenRead(_filePath);
                    strLocal = new FileStream(_downPath, FileMode.Create, FileAccess.Write, FileShare.None);

                    int bytesSize = 0;
                    byte[] downBuffer = new byte[2048];

                    while ((bytesSize = strResponse.Read(downBuffer, 0, downBuffer.Length)) > 0)
                    {
                        strLocal.Write(downBuffer, 0, bytesSize);
                        OnProgressUpdate(strLocal.Length, fileSize);
                    }
                }
                catch (Exception e)
                {
                    if (OnError != null)
                    {
                        OnError();
                    }
                }
                finally
                {
                    strResponse.Close();
                    strLocal.Close();
                }
                if (OnFinalize != null)
                {
                    OnFinalize();
                }
            }
        }
    }
}