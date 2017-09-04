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
using System.IO;
using System.Net;
using System.Threading;

#endregion

namespace UpdateClient
{
    public class UpdateLogic
    {
        private readonly string _filePath;
        private readonly string _downPath;
        private readonly string _currentDirectory;

        private Thread _thrDownload;
        private Stream _strResponse;
        private Stream _strLocal;

        public UpdateLogic(string filePath, string downPath, string currentDirectory)
        {
            _filePath = filePath;
            _downPath = downPath;
            _currentDirectory = currentDirectory;
        }

        public void Download()
        {
            _thrDownload = new Thread(WebDownload);
            _thrDownload.Start();
        }

        public delegate void OnProgressUpdateHandler(Int64 bytesRead, Int64 totalBytes);

        public OnProgressUpdateHandler OnProgressUpdate;

        public delegate void OnUpdateHandler(string currentDirectory);

        public OnUpdateHandler OnFinalize;
        public OnUpdateHandler OnError;

        private void WebDownload()
        {
            using (var wcDownload = new WebClient())
            {
                try
                {
                    var webRequest = WebRequest.Create(_filePath);
                    webRequest.Credentials = CredentialCache.DefaultCredentials;

                    _strResponse = wcDownload.OpenRead(_filePath);
                    if (_strResponse == null)
                        throw new InvalidDataException("Response should succeed");
                    _strLocal = new FileStream(_downPath, FileMode.Create, FileAccess.Write, FileShare.None);
                    Int64 fileSize;
                    var response = webRequest.GetResponse();
                    if (response is HttpWebResponse)
                    {
                        var webResponse = (HttpWebResponse) webRequest.GetResponse();
                        if (webResponse == null)
                            throw new InvalidDataException("Request should succeed");
                        fileSize = webResponse.ContentLength;
                        response.Close();
                    }
                    else
                        fileSize = _strResponse.Length;

                    int bytesSize;
                    var downBuffer = new byte[2048];

                    while ((bytesSize = _strResponse.Read(downBuffer, 0, downBuffer.Length)) > 0)
                    {
                        _strLocal.Write(downBuffer, 0, bytesSize);

                        if (OnProgressUpdate != null)
                            OnProgressUpdate(_strLocal.Length, fileSize);
                    }
                }
                catch
                {
                    if (OnError != null)
                    {
                        OnError(_currentDirectory);
                    }
                }
                finally
                {
                    if (_strResponse != null)
                        _strResponse.Close();
                    if (_strLocal != null)
                        _strLocal.Close();
                }
                if (OnFinalize != null)
                {
                    OnFinalize(_currentDirectory);
                }
            }
        }
    }
}