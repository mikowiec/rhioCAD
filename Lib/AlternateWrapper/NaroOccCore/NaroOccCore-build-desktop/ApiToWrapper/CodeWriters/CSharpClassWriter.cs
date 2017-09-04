using System.Collections.Generic;
using ApiCommon;
using ApiCommon.Generator;
using ApiToWrapper.CodeWriters.Constructs;

namespace ApiToWrapper.CodeWriters
{
    internal class CSharpClassWriter
    {
        private readonly string _dllName;
        public CSharpProjectWriter ProjectWriter { get; set; }
        public List<MethodWriter> Methods { get; private set; }
        public List<ConstructorWriter> Constructors { get; private set; }
        public List<string> UsedPackages { get; private set; }
        public string Namespace { private set; get; }
        public string ClassName { private set; get; }
        public string BeautifiedClassName { get; set; }
        private readonly List<string> _importedNativeFunctions;

        public CSharpClassWriter(CSharpProjectWriter projectWriter, DataNode classNode, string dllName)
        {
            _dllName = dllName;
            ProjectWriter = projectWriter;
            ClassName = classNode.Name;
            BeautifiedClassName = Util.BeautifiedClassName(ClassName);
            UsedPackages = new List<string>();
            Methods = new List<MethodWriter>();
            Constructors = new List<ConstructorWriter>();
            _importedNativeFunctions = new List<string>();
            BuildNamespace();
        }

        private void BuildNamespace()
        {
            const string basenamespace = "NaroCppCore.Occ";
            var packageName = PackageName;
            Namespace = basenamespace + "." + packageName;
        }

        public bool IsAbstract
        {
            get { return Constructors.Count == 0; }
        }
        public string PackageName
        {
            get
            {
                var className = ClassName;
                return Util.ExtractPackage(className);
            }
        }


        public void AddDependentType(string typeName)
        {
            if (OccApiGenerator.IsPrimitiveType(typeName))
                return;
            var packageName = typeName.Split('_')[0];
            if (!UsedPackages.Contains(packageName))
                UsedPackages.Add(packageName);
        }

        public string DiskFileName
        {
            get
            {
                return "Occ\\" + PackageName + "\\" + BeautifiedClassName + ".cs";
            }
        }

        public string DiskCppFileName
        {
            get
            {
                return "Occ\\" + PackageName + "\\" + BeautifiedClassName + ".cpp";
            }
        }


        public string BasedOn { private get; set; }

        #region C#

        public void WriteToCsFile(FileWriter fileWriter)
        {
            var lines = fileWriter.Lines;

            WriteUsings(lines);

            lines.Add("namespace NaroCppCore.Occ." + PackageName);
            lines.Add("{");
            lines.Add(Util.Indent(1) + "public class " + BeautifiedClassName + " : " + BasedOn);
            lines.Add(Util.Indent(1) + "{");
            WriteConstructorBodies(lines);
            WriteMethodBodies(lines);
            foreach (var nativeFunction in _importedNativeFunctions)
                Util.ImportDllString(ProjectWriter.NativeDllName, lines, nativeFunction);
            Util.NativeInstanceDestructor(BeautifiedClassName, lines, _dllName);
            lines.Add(Util.Indent(1) + "}");
            lines.Add("}");
        }

        private void WriteConstructorBodies(List<string> lines)
        {
            foreach (var constructor in Constructors)
                constructor.WriteToFile(lines, _importedNativeFunctions);
        }


        private void WriteMethodBodies(List<string> lines)
        {
            foreach (var method in Methods)
                method.WriteToFile(lines, _importedNativeFunctions);
        }


        private void WriteUsings(List<string> lines)
        {
            lines.AddRange(new[]
                               {
                                   "#region Usings", 
                                   string.Empty, 
                                   "using System;", 
                                   "using System.Runtime.InteropServices;", 
                                   "using NaroCppCore.Core;"}
                );
            foreach (var package in UsedPackages)
                lines.Add("using NaroCppCore.Occ." + package + ";");
            lines.AddRange(new[]
                               {
                                   string.Empty,
                                   "#endregion",
                                   string.Empty
                               });
        }

        public void WriteMethod(DataNode node)
        {
            var method = new MethodWriter(this, node);
            Methods.Add(method);
            method.Process();
        }
        #endregion

        #region Cpp
        public void WriteToCppFile(FileWriter fileWriter)
        {
            var lines = fileWriter.Lines;
            lines.Add("#include \"NaroExport.h\"");

            var mainInclude = "#include <" + ClassName + ".hxx>";
            lines.Add(mainInclude);

            WriteCppConstructorBodies(lines);
            WriteCppMethodBodies(lines);

            WriteCppDestructor(lines);
        }

        private void WriteCppDestructor(List<string> lines)
        {
            if (IsAbstract) return;
            lines.Add("void Naro" + ClassName + "_Dtor(void* instance) {");
            lines.Add(Util.Indent(1) + "delete (" + ClassName + "*)instance;");
            lines.Add("}");
        }

        private void WriteCppConstructorBodies(List<string> lines)
        {
            foreach (var constructor in Constructors)
                constructor.WriteToCppFile(lines);
        }


        private void WriteCppMethodBodies(List<string> lines)
        {
            foreach (var method in Methods)
                method.WriteToCppFile(lines);
        }


        public void WriteConstructor(DataNode node)
        {
            var constructorWriter = new ConstructorWriter(this, node);
            Constructors.Add(constructorWriter);
            constructorWriter.Process();
        }
        #endregion
    }
}