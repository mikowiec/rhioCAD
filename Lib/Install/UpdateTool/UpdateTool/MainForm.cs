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
using System.Windows.Forms;
using ErrorReportCommon;

#endregion

namespace UpdateTool
{
    public partial class MainForm : Form
    {
        private static void WriteVersioning(string version)
        {
            File.WriteAllText(@"..\..\bin\Debug\naro.cfg", version);
        }

        public MainForm()
        {
            InitializeComponent();

            versionTextBox.Text = TodayVersion();
            downloadLinkTextBox.Text = NightlyDownloadLink;
        }

        private const string NightlyDownloadLink = @"http://www.cipdevel.com/download/NaroNightly.exe";

        private static int LastDigit(int number)
        {
            return number%10;
        }

        private static int SecondLastDigit(int number)
        {
            return (number/10)%10;
        }

        private static string LastTwoDigits(int number)
        {
            return SecondLastDigit(number) + LastDigit(number).ToString();
        }

        private static string TodayVersion()
        {
            var result = "Nightly";
            result += LastTwoDigits(DateTime.Today.Year);
            result += LastTwoDigits(DateTime.Today.Month);
            result += LastTwoDigits(DateTime.Today.Day);
            return result;
        }

        private void Button2Click(object sender, EventArgs e)
        {
            Close();
            //Build will stop with an error in this cases
            Environment.Exit(-1);
        }

        private string _version;
        private string _updateReasons;
        private string _installLink;

        private void Button1Click(object sender, EventArgs e)
        {
            _version = versionTextBox.Text;
            _updateReasons = updateReasonTextBox.Text;
            _installLink = downloadLinkTextBox.Text;
            CreateVersionData(_version, _installLink, _updateReasons);

            Close();
        }

        public static void NightlyBuildVersion()
        {
            CreateVersionData(TodayVersion(), NightlyDownloadLink, string.Empty);
        }

        private static void CreateVersionData(string version, string installLink, string updateReasons)
        {
            const string versionFileName = "version.txt";
            const string downloadFileName = "download.url";
            const string updateReasonFileName = "update.txt";
            File.WriteAllText(versionFileName, version);
            File.WriteAllText(downloadFileName, installLink);
            File.WriteAllText(updateReasonFileName, updateReasons);
            var zipPack = new ZipPack("versiondata.zip");
            zipPack.AddFile(versionFileName);
            zipPack.AddFile(updateReasonFileName);
            zipPack.AddFile(downloadFileName);
            zipPack.Close();
            File.Delete(versionFileName);
            File.Delete(updateReasonFileName);
            File.Delete(downloadFileName);

            WriteVersioning(version);
        }
    }
}