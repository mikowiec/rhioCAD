#region Usages

using System.IO;
using ApiCommon;

#endregion

namespace ApiToWrapper.CodeWriters
{
    internal class OccCodeWriter
    {
        private readonly DataNode _apiNode;
        private readonly CSharpProjectWriter _csProjectWriter;
        private readonly string _outputPath;
        private readonly DataNode _set;

        public OccCodeWriter(string outputPath, DataNode apiNode, DataNode set)
        {
            _outputPath = outputPath;
            _apiNode = apiNode;
            _set = set;
            _csProjectWriter = new CSharpProjectWriter("NaroOccCore.dll", "File.list", "NaroCppCore.csproj",
                                                       "..\\..\\..\\..\\NaroOccCore", "..\\..\\..\\");
        }

        public void WriteCode()
        {
            if (!Directory.Exists(_outputPath))
                Directory.CreateDirectory(_outputPath);
            VisitNodes(_apiNode);

            WriteToDisk();
        }

        private void WriteToDisk()
        {
            _csProjectWriter.WriteToDisk(_set);
            _csProjectWriter.ExecuteTooling();
        }

        private void VisitNodes(DataNode node)
        {
            if (node.NodeType == Consts.Klass)
                WriteClass(node);
            if (node.NodeType == Consts.Enum)
                WriteEnum(node);
            if (node.NodeType == Consts.Method)
                WriteMethod(node);
            if (node.NodeType == Consts.Property)
                WriteProperty(node);
            if (node.NodeType == Consts.Constructor)
                WriteConstructor(node);
            foreach (var child in node.Children)
                VisitNodes(child);
        }

        private void WriteEnum(DataNode node)
        {
            _csProjectWriter.GetOrAddEnum(node);
        }

        private void WriteConstructor(DataNode node)
        {
            _csProjectWriter.WriteConstructor(node);
        }

        private void WriteClass(DataNode node)
        {
            _csProjectWriter.WriteClass(node);
        }

        private void WriteMethod(DataNode nodeMethod)
        {
            _csProjectWriter.WriteMethod(nodeMethod);
        }

        private void WriteProperty(DataNode nodeMethod)
        {
            _csProjectWriter.WriteProperty(nodeMethod);
        }
    }
}