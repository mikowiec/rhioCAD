#region Usages

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using ApiCommon.Generator;

#endregion

namespace ApiToWrapper.CodeWriters
{
    public class FileWriter
    {
        private readonly string _fileName;

        public FileWriter(string fileName)
        {
            _fileName = Util.ToPlatformPath(fileName);
            Lines = new List<string>();
        }

        public List<string> Lines { get; set; }

        public void AddLine(int indent, string line)
        {
            Lines.Add(Util.Indent(indent) + line);
        }

        public void WriteToDisk()
        {
            var path = Path.GetDirectoryName(_fileName);
            Debug.Assert(path != null);
            Directory.CreateDirectory(path);
            File.WriteAllLines(_fileName, Lines.ToArray());
        }
    }
}