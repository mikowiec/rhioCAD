#region Usages

using System.Collections.Generic;
using ApiCommon;
using ApiCommon.Generator;

#endregion

namespace ApiToWrapper.CodeWriters.Constructs
{
    public class EnumWriter
    {
        private readonly DataNode _classNode;

        public EnumWriter(DataNode classNode)
        {
            _classNode = classNode;
            ClassName = classNode.Name;
        }

        private string ClassName { get; set; }


        public string PackageName
        {
            get
            {
                var className = ClassName;
                return Util.ExtractPackage(className);
            }
        }

        public string DiskFileName
        {
            get { return "Occ\\" + PackageName + "\\" + Util.BeautifiedClassName(ClassName) + ".cs"; }
        }

        public void WriteToFile(List<string> lines)
        {
            lines.Add("namespace NaroCppCore.Occ." + PackageName);
            lines.Add("{");
            lines.Add(Util.Indent(1) + "public enum " + Util.BeautifiedClassName(ClassName) + "{");
            foreach (var line in _classNode.Children)
            {
                lines.Add(Util.Indent(2) + line.Name + ",");
            }
            lines.Add(Util.Indent(1) + "}");
            lines.Add("}");
        }
    }
}