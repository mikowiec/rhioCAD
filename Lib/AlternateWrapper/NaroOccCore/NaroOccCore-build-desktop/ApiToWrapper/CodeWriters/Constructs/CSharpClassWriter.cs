#region Usages

using System;
using System.Collections.Generic;
using ApiCommon;
using ApiCommon.Generator;

#endregion

namespace ApiToWrapper.CodeWriters.Constructs
{
    public class CSharpClassWriter
    {
        private readonly DataNode _classNode;

        #region Members

        private readonly List<string> _importedNativeFunctions;

        private CSharpProjectWriter ProjectWriter { get; set; }
        public List<MethodWriter> Methods { get; private set; }
        public List<PropertyWriter> Properties { get; private set; }
        public List<ConstructorWriter> Constructors { get; private set; }
        private List<string> UsedPackages { get; set; }
        public string ClassName { private set; get; }
        public string BeautifiedClassName { get; private set; }

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


        public string DiskFileName
        {
            get { return "Occ\\" + PackageName + "\\" + BeautifiedClassName + ".cs"; }
        }

        public string DiskCppFileName
        {
            get { return "Occ\\" + PackageName + "\\" + BeautifiedClassName + ".cpp"; }
        }

        public string DiskCppHeaderName
        {
            get { return "Occ\\" + PackageName + "\\" + BeautifiedClassName + ".h"; }
        }

        public string BasedOn { private get; set; }

        #endregion

        public CSharpClassWriter(CSharpProjectWriter projectWriter, DataNode classNode)
        {
            _classNode = classNode;
            ProjectWriter = projectWriter;
            ClassName = classNode.Name;
            BeautifiedClassName = Util.BeautifiedClassName(ClassName);
            UsedPackages = new List<string>();
            Methods = new List<MethodWriter>();
            Constructors = new List<ConstructorWriter>();
            Properties = new List<PropertyWriter>();
            _importedNativeFunctions = new List<string>();
        }

        #region C#

        public void WriteToCsFile(FileWriter fileWriter)
        {
            var lines = new List<string>();
            var isDefaultCtroSet = false;
            WriteConstructorBodies(lines, ref isDefaultCtroSet);
            WriteMethodBodies(lines);
            WritePropertyBodies(lines);
            foreach (var nativeFunction in _importedNativeFunctions)
                Util.ImportDllString(ProjectWriter.NativeDllName, lines, nativeFunction);
            Util.NativeInstanceDestructor(BeautifiedClassName, lines, ProjectWriter.NativeDllName, isDefaultCtroSet);

            BuildFileLines(lines, fileWriter);
        }

        private void BuildFileLines(IEnumerable<string> lines, FileWriter fileWriter)
        {
            WriteUsings(fileWriter.Lines);
            fileWriter.AddLine(0, "namespace NaroCppCore.Occ." + PackageName);
            fileWriter.AddLine(0, "{");
            fileWriter.AddLine(1, "public class " + BeautifiedClassName + " : " + BasedOn);
            fileWriter.AddLine(1, "{");
            fileWriter.Lines.AddRange(lines);
            fileWriter.AddLine(1, "}");
            fileWriter.AddLine(0, "}");
        }

        private void WritePropertyBodies(List<string> lines)
        {
            foreach (var property in Properties)
            {
                property.WriteToFile(lines, _importedNativeFunctions);
            }
        }

        private void WriteConstructorBodies(List<string> lines, ref bool isDefaultCtorSet)
        {
            foreach (var constructor in Constructors)
                constructor.WriteToFile(lines, _importedNativeFunctions, ref isDefaultCtorSet);
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
                                   "using NaroCppCore.Core;"
                               }
                );
            foreach (var package in UsedPackages)
            {
                //if((package.Contains("GeomAbs") || package.Contains("Geom_Abs"))
                //    Console.WriteLine(package);
                lines.Add("using NaroCppCore.Occ." + package + ";");
            }
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

        public void WriteProperty(DataNode node)
        {
            var writer = new PropertyWriter(this, node);
            Properties.Add(writer);
            writer.Process();
        }

        #endregion

        #region Cpp

        private static void DefinitionsHeaderInit(FileWriter definitionsFile, string className)
        {
            var startLines = new[]
                                 {
                                     "#ifndef " + className + "_H",
                                     "#define " + className + "_H",
                                     "",
                                     "#include \"../../Export_Import.h\"",
                                     ""
                                 };
            definitionsFile.Lines.AddRange(startLines);
        }

        public static void DefinitionsHeaderFinish(FileWriter definitionsFile)
        {
            definitionsFile.Lines.Add(string.Empty);
            definitionsFile.Lines.Add("#endif");
            definitionsFile.WriteToDisk();
        }

        public void WriteToCppFile(FileWriter fileWriter, FileWriter definitionsFile)
        {
            if (ClassName == "Geom_Curve")
            {
            }
            DefinitionsHeaderInit(definitionsFile, ClassName);
            var lines = fileWriter.Lines;
            lines.Add("#include \"" + BeautifiedClassName + ".h\"");
            var className = ClassName;
            AddInclude(lines, className);
            var includedTypes = new List<string>();
            var declarationLines = new List<string>();
            WriteCppConstructorBodies(declarationLines, definitionsFile);
            WriteCppMethodBodies(declarationLines, definitionsFile, includedTypes);
            WriteCppPropertyBodies(declarationLines, definitionsFile, includedTypes);

            WriteCppDestructor(declarationLines, definitionsFile);
            WriteIncludes(lines, includedTypes);
            lines.AddRange(declarationLines);
        }

        private static void WriteIncludes(ICollection<string> lines, IEnumerable<string> includedTypes)
        {
            var dictionary = new SortedDictionary<string, int>();
            foreach (var includedType in includedTypes)
                dictionary[includedType] = 0;
            lines.Add(string.Empty);
            foreach (var includedType in dictionary.Keys)
                AddInclude(lines, includedType);
            lines.Add(string.Empty);
        }

        private static void AddInclude(ICollection<string> lines, string className)
        {
            var mainInclude = "#include <" + className + ".hxx>";
            lines.Add(mainInclude);
        }

        private void WriteCppDestructor(ICollection<string> lines, FileWriter definitionsFile)
        {
            var dtorDeclaration = "DECL_EXPORT void " + BeautifiedClassName + "_Dtor(void* instance)";
            definitionsFile.AddLine(0, "extern \"C\" " + dtorDeclaration + ";");
            lines.Add(dtorDeclaration);
            lines.Add("{");
            var removeString = Util.Indent(1) + "delete (";
            var typeUtil = new TypeUtil(_classNode);
            if (typeUtil.IsHandle(ClassName))
                removeString += "Handle_";
            removeString += ClassName + "*)instance;";
            lines.Add(removeString);
            lines.Add("}");
        }

        private void WriteCppConstructorBodies(List<string> lines, FileWriter definitionsFile)
        {
            foreach (var constructor in Constructors)
                constructor.WriteToCppFile(lines, definitionsFile);
        }


        private void WriteCppMethodBodies(List<string> lines, FileWriter definitionsFile, List<string> includedTypes)
        {
            foreach (var method in Methods)
                method.WriteToCppFile(lines, definitionsFile, includedTypes);
        }

        private void WriteCppPropertyBodies(List<string> lines, FileWriter definitionsFile, List<string> includedTypes)
        {
            foreach (var method in Properties)
                method.WriteToCppFile(lines, definitionsFile, includedTypes);
        }

        public void WriteConstructor(DataNode node)
        {
            var constructorWriter = new ConstructorWriter(this, node);
            Constructors.Add(constructorWriter);
            constructorWriter.Process();
        }

        #endregion

        public void AddDependentType(string typeName)
        {
            if (OccApiGenerator.IsPrimitiveType(typeName))
                return;
            var packageName = typeName.Split('_')[0];
            if (!UsedPackages.Contains(packageName))
                UsedPackages.Add(packageName);
        }
    }
}