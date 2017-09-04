#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

#endregion

namespace ErrorReportCommon
{
    public class SourceForgeBugReport
    {
        #region Config constants

        private const string SourceforgeUrl = "http://sourceforge.net/tracker/index.php";
        //private const string SOURCEFORGE_URL = "http://localhost:8081/tracker/index.php";

        private const string GroupId = "group_id";
        private const string ActionId = "atid";
        private const string Function = "func";
        private const string FunctionName = "postadd";

        private const string Boundary = "--7670338787335609471139840547";

        private const string ProjectId = "198020"; // FIXME: MagicGroup ID - this should be changed
        private const string AddBugActionId = "963798";

        #endregion

        #region Data members

        private readonly List<byte> _requestBytes = new List<byte>();

        private string _description;
        private string _filename;
        private string _parameters = "";
        private string _title;

        #endregion

        #region Public methods

        public void ReportBug(string title, string description, string filename)
        {
            _title = title;
            _description = description;
            _filename = filename;

            var webRequest = BuildWebRequestAndParameters();

            SendRequest(webRequest);
            ReceiveResponse(webRequest);
        }

        #endregion

        #region Methods

        private HttpWebRequest BuildWebRequestAndParameters()
        {
            var webRequest = BuildWebRequest();
            BuildParameters();
            BuildRequestData(webRequest);

            return webRequest;
        }

        private static HttpWebRequest BuildWebRequest()
        {
            var webRequest = (HttpWebRequest) WebRequest.Create(SourceforgeUrl);
            webRequest.UserAgent =
                "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.10) Gecko/2009042513 Ubuntu/8.04 (hardy) Firefox/3.0.10";

            webRequest.Method = "POST";
            webRequest.Accept = "text/html";
            webRequest.ContentType = "multipart/form-data; boundary=" + Boundary;

            return webRequest;
        }

        private void BuildParameters()
        {
            _parameters = "";
            AddParameter(GroupId, ProjectId);
            AddParameter(ActionId, AddBugActionId);
            AddParameter(Function, FunctionName);
            AddParameter("category_id", "100");
            AddParameter("artifact_group_id", "100");
            AddParameter("summary", _title);
            AddParameter("details", _description);
            AddParameter("submit", "Add Artifact");
            AddFile("input_file", _filename);
            AddParameter("file_description", "Attachement"); // FIXME: you might want to change this

            _parameters += Boundary + "--\n";
        }

        private void BuildRequestData(WebRequest webRequest)
        {
            webRequest.ContentLength = _requestBytes.Count;
        }

        private static IEnumerable<byte> Bytes(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        private static byte[] GetContent(string filename)
        {
            var fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            var result = new byte[fs.Length];

            fs.Read(result, 0, Convert.ToInt32(fs.Length));

            fs.Close();

            return result;
        }

        private void AddParameter(string name, string value)
        {
            var buildString = "";
            buildString += "--" + Boundary + "\n";
            buildString += "Content-Disposition: form-data; name=\"" + name + "\"\n\n";
            buildString += value + "\n";

            _requestBytes.AddRange(Bytes(buildString));
        }

        private void AddFile(string name, string fileName)
        {
            var fileContent = GetContent(fileName);
            _parameters += "--" + Boundary + "\n";
            // FIXME: parse the fileName to get just the basename (e.g. from /tmp/moo/foo.zip -> foo.zip) or hardcode it here.
            _parameters += "Content-Length: " + fileContent.Length + "\n";
            _parameters += "Content-Disposition: form-data; name=\"" + name + "\"; filename=\"log.zip\"\n";
            _parameters += "Content-Type: application/x-zip-compressed\n\n";

            _requestBytes.AddRange(Bytes(_parameters));
            _requestBytes.AddRange(fileContent);
            _requestBytes.AddRange(Bytes("\n\n"));
        }

        private void SendRequest(WebRequest webRequest)
        {
            using (var os = webRequest.GetRequestStream())
            {
                os.Write(_requestBytes.ToArray(), 0, _requestBytes.Count);
            }
        }

        private static void ReceiveResponse(WebRequest webRequest)
        {
            var response = webRequest.GetResponse();
            if (response == null) return;
            var responseStream = response.GetResponseStream();
            if (responseStream != null)
                using (var inStream = new StreamReader(responseStream))
                    inStream.ReadToEnd();
            // FIXME: do you really need this?
        }

        #endregion
    }
}