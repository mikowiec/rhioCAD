#region Usings

using System;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

#endregion

namespace ErrorReportCommon
{
    public class ZipPack
    {
        #region Data members

        private readonly ZipOutputStream _stream;

        #endregion

        #region Constructor

        public ZipPack(string fileName)
        {
            _stream = new ZipOutputStream(File.Create(fileName));
            _stream.SetLevel(9);
        }

        #endregion

        #region Public methods

        public void AddFile(string fileName)
        {
            if (File.Exists(fileName))
                PackFile(fileName);
        }

        public void Close()
        {
            _stream.Finish();
            _stream.Close();
        }

        #endregion

        #region Methods

        private void PackFile(string fileName)
        {
            var buffer = new byte[4*4*1024];
            try
            {
                var entry = new ZipEntry(Path.GetFileName(fileName)) {DateTime = DateTime.Now};
                _stream.PutNextEntry(entry);
                using (var fs = File.OpenRead(fileName))
                {
                    int sourceBytes;
                    do
                    {
                        sourceBytes = fs.Read(buffer, 0, buffer.Length);
                        _stream.Write(buffer, 0, sourceBytes);
                    } while (sourceBytes > 0);
                }
                _stream.CloseEntry();
            }
            catch
            {
                return;
            }

            return;
        }

        #endregion
    }
}