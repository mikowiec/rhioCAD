#region Usages

using System.Collections.Generic;
using System.Text;
using ApiCommon;
using ApiCommon.Generator;

#endregion

namespace ApiToWrapper.CodeWriters.Constructs
{
    public class ConstructorWriter
    {
        private readonly CSharpClassWriter _classWriter;
        private readonly DataNode _node;
        private readonly ParameterListWriter _parameterList;
        private readonly TypeUtil _typeUtil;

        public ConstructorWriter(CSharpClassWriter classWriter, DataNode node)
        {
            _classWriter = classWriter;
            _node = node;
            _parameterList = new ParameterListWriter(node);
            _typeUtil = new TypeUtil(node);
        }

        public void Process()
        {
            var parametersNode = _node.Get(Consts.Parameters);
            _parameterList.SetParameters(parametersNode, _classWriter);
        }

        #region C#

        public void WriteToFile(List<string> lines, List<string> importedNatives, ref bool isDefaultCtorSet)
        {
            var paramStr = _parameterList.GetCsParamString();
            if (_parameterList.Count == 0)
                isDefaultCtorSet = true;
            var nativeMethodName = GetNativeMethodName();
            var nativeParamStr = _parameterList.GetCsNativeParamString();
            AddNativeImport(nativeParamStr, nativeMethodName, importedNatives);

            lines.Add(Util.Indent(2) + "public " + _classWriter.BeautifiedClassName + "(" + paramStr + ")");
            lines.Add(" :");
            lines.Add(Util.Indent(3) + "base(" + nativeMethodName + "(" + _parameterList.GetParamCall() + ") )");
            lines.Add(Util.Indent(2) + "{}");
        }

        private string GetNativeMethodName()
        {
            var baseString = new StringBuilder();
            baseString.Append(ClassName);
            baseString.Append("_Ctor");
            baseString.Append(OccApiGenerator.NativeMethodSuffix(_parameterList.ParamTypes));

            return baseString.ToString();
        }

        #endregion

        #region Cpp

        private string ClassName
        {
            get { return _classWriter.ClassName; }
        }

        private static void AddNativeImport(string paramStr, string nativeMethodName, List<string> importedNatives)
        {
            var toImport = "IntPtr " + nativeMethodName + "(" + paramStr + ")";
            importedNatives.Add(toImport);
        }

        private string GetMethodDeclaration(string returnType, string methodName, string declarationExport)
        {
            var declarationLine = string.Empty;
            if (returnType != "void")
            {
                var kindType = _typeUtil.Type(returnType);
                switch (kindType)
                {
                    case Consts.Klass:
                        declarationLine += "void*";
                        break;
                    case Consts.Enum:
                        declarationLine += "int";
                        break;
                    default:
                        declarationLine += returnType;
                        break;
                }
            }
            else
                declarationLine += "void";
            var cppParamString = _parameterList.GetCppParamString(true);
            return declarationExport + declarationLine + " " + methodName + "(" + cppParamString + ")";
        }


        public void WriteToCppFile(List<string> lines, FileWriter definitionsFile)
        {
            var nativeMethodName = GetNativeMethodName();
            definitionsFile.Lines.Add("extern \"C\" " +
                                      GetMethodDeclaration(ClassName, nativeMethodName, "DECL_EXPORT ") + ";");
            var paramStr = _parameterList.GetCppParamString(true);
            var declaration = "DECL_EXPORT void* " + nativeMethodName + "(" + paramStr + ")";
            lines.Add(declaration);
            lines.Add("{");
            _parameterList.DeclareCppConvertParams(lines);
            var sb = new StringBuilder();
            sb.Append(Util.Indent(1));
            sb.Append("return new ");
            if (_typeUtil.IsHandle(ClassName))
            {
                sb.Append("Handle_");
                sb.Append(ClassName);
                sb.Append("(new ");
                sb.Append(ClassName);
            }
            else
                sb.Append(ClassName);

            sb.Append("(");
            sb.Append(_parameterList.GetCppParamCall());
            if (_typeUtil.IsHandle(ClassName))
                sb.Append(")");
            sb.Append(");");
            lines.Add(sb.ToString());
            lines.Add("}");
        }

        #endregion
    }
}