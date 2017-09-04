#region Usages

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using ApiCommon;
using ApiCommon.Generator;
using ApiToWrapper.CodeWriters.Constructs;

#endregion

namespace ApiToWrapper.CodeWriters
{
    public class CSharpProjectWriter
    {
        public readonly string NativeDllName;
        private readonly string _cppFolder;
        private readonly string _csharpPath;
        private readonly string _csharpProject;
        private readonly string _fileListFileName;
        private List<string> _csFiles;
        private List<string> _fileList;
        private XmlNode _rootPaths;
        private XmlDocument _xmlDocument;

        public CSharpProjectWriter(string nativeDllName, string fileListFileName, string csharpProject, string cppFolder,
                                   string csharpPath)
        {
            CsharpProject = csharpProject;
            NativeDllName = nativeDllName;
            _fileListFileName = fileListFileName;
            _csharpProject = csharpProject;
            _cppFolder = cppFolder;
            _csharpPath = csharpPath;
            Classes = new SortedDictionary<string, CSharpClassWriter>();
            EnumWriters = new SortedDictionary<string, EnumWriter>();
            PreSetupXml();
        }

        private string CsharpProject { get; set; }
        private SortedDictionary<string, CSharpClassWriter> Classes { get; set; }
        private SortedDictionary<string, EnumWriter> EnumWriters { get; set; }

        private void PreSetupXml()
        {
            _xmlDocument = new XmlDocument();
            _xmlDocument.Load(Util.ToPlatformPath(_csharpPath + "\\" + _csharpProject));
            _rootPaths = _xmlDocument.ChildNodes[1].ChildNodes[4];
            _csFiles = new List<string>();
            foreach (XmlNode item in _rootPaths.ChildNodes)
            {
                if (item.Name != "Compile") continue;
                var attr = item.Attributes["Include"];
                if (attr.Value.StartsWith("Occ\\")) continue;
                _csFiles.Add(attr.Value);
            }
            _rootPaths.RemoveAll();
        }


        private CSharpClassWriter GetOrAddClass(DataNode node)
        {
            var className = node.Name;
            CSharpClassWriter result;
            if (Classes.TryGetValue(className, out result)) return result;
            result = new CSharpClassWriter(this, node);
            var implementsNode = node.Get(Consts.Implements);
            result.BasedOn = implementsNode != null
                                 ? Util.BeautifiedClassName(implementsNode.Name)
                                 : "NativeInstancePtr";
            if (implementsNode != null)
                result.AddDependentType(implementsNode.Name);
            Classes[className] = result;
            return result;
        }

        public void WriteMethod(DataNode node)
        {
            var classNode = node.Parent.Parent;
            var classWriter = GetOrAddClass(classNode);
            classWriter.WriteMethod(node);
        }

        public void WriteProperty(DataNode node)
        {
            var classNode = node.Parent.Parent;
            var classWriter = GetOrAddClass(classNode);
            classWriter.WriteProperty(node);
        }

        public void WriteToDisk(DataNode set)
        {
            PrepareFiles();

            foreach (var klass in Classes.Values)
            {
                //C#
                WriteCsToDisk(klass, set);
                //C++
                WriteCppToDisk(klass, set);
            }
            foreach (var enumItem in EnumWriters.Values)
            {
                var csFile = new FileWriter(_csharpPath + "\\" + enumItem.DiskFileName);
                WriteEnum(enumItem, csFile.Lines);
                csFile.WriteToDisk();
                _csFiles.Add(enumItem.DiskFileName);
            }
            File.WriteAllLines(_cppFolder + "\\" + _fileListFileName, _fileList.ToArray());

            foreach (var csFile in _csFiles)
            {
                var xmlelem = _xmlDocument.CreateElement("Compile",
                                                         "http://schemas.microsoft.com/developer/msbuild/2003");

                var attr = _xmlDocument.CreateAttribute("Include");
                attr.Value = csFile;
                xmlelem.Attributes.Append(attr);
                xmlelem.RemoveAttribute("xmlns");
                _rootPaths.AppendChild(xmlelem);
            }
            _xmlDocument.Save(_csharpPath + "\\" + CsharpProject);
        }

        private void PrepareFiles()
        {
            _fileList = new List<string>(new[]
                                             {
                                                 "SOURCES += \\",
                                                 "NaroExport.cpp \\",
                                             }
                );
        }

        private void WriteCsToDisk(CSharpClassWriter klass, DataNode set)
        {
            var csFile = new FileWriter(_csharpPath + "\\" + klass.DiskFileName);
            klass.WriteToCsFile(csFile);
            //if (IsClassChanged(klass, set))
                csFile.WriteToDisk();
            _csFiles.Add(klass.DiskFileName);
        }

        private void WriteCppToDisk(CSharpClassWriter klass, DataNode set)
        {
            var cppFileName = klass.DiskCppFileName;

            AddToFileList(cppFileName);
            var cppFile = new FileWriter(_cppFolder + "\\" + cppFileName);
            var definitionFile = new FileWriter(_cppFolder + "\\" + klass.DiskCppHeaderName);

            klass.WriteToCppFile(cppFile, definitionFile);
         //   if (!IsClassChanged(klass, set)) return;
            CSharpClassWriter.DefinitionsHeaderFinish(definitionFile);
            cppFile.WriteToDisk();
        }

        private static bool IsClassChanged(CSharpClassWriter klass, DataNode set)
        {
            //return true; // decomment to regenerate all wrappers
            var generator = set.Root.Set(Consts.Occ, Consts.Generator);
            var ns = generator.Set(Consts.NaroCppCore, Consts.Namespace);
            var occ = ns.Set(Consts.Occ, Consts.Namespace);
            var packageNode = occ.Get(klass.PackageName, Consts.Namespace);
            if (packageNode == null) return true;
            var classNode = packageNode.Get(klass.ClassName, Consts.Klass);
            if (classNode == null) return true;

            var methodsNode = classNode.Get(Consts.Methods);
            if (methodsNode == null && klass.Methods.Count != 0) return true;
            if (methodsNode != null && methodsNode.Children.Count != klass.Methods.Count) return true;
            var ctorssNode = classNode.Get(Consts.Constructors);
            if (ctorssNode == null && klass.Constructors.Count != 0) return true;
            if (ctorssNode != null && ctorssNode.Children.Count != klass.Constructors.Count) return true;
            var propssNode = classNode.Get(Consts.Properties);
            if (propssNode == null && klass.Properties.Count != 0) return true;
            if (propssNode != null && propssNode.Children.Count != klass.Properties.Count) return true;
            return false;
        }

        private void AddToFileList(string cppFileName)
        {
            _fileList.Add(cppFileName + " \\");
        }

        public void WriteClass(DataNode node)
        {
            GetOrAddClass(node);
        }

        public void WriteConstructor(DataNode node)
        {
            var classNode = node.Parent.Parent;
            var classWriter = GetOrAddClass(classNode);
            classWriter.WriteConstructor(node);
        }

        public void GetOrAddEnum(DataNode node)
        {
            var className = node.Name;
            EnumWriter result;
            if (EnumWriters.TryGetValue(className, out result)) return;
            result = new EnumWriter(node);
            EnumWriters[className] = result;
            return;
        }

        public void WriteEnum(EnumWriter node, List<string> lines)
        {
            node.WriteToFile(lines);
        }

        public void ExecuteTooling()
        {
            var csProjectFile = _csharpPath + "\\" + CsharpProject;
            var process = new Process
                              {
                                  StartInfo =
                                      {
                                          FileName = @"c:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\MSBuild.exe",
                                          Arguments = csProjectFile,
                                          WindowStyle = ProcessWindowStyle.Hidden
                                      }
                              };
            process.Start();
        }
    }
}