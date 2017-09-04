#region Usages

using System;
using System.Collections.Generic;
using System.Text;
using ApiCommon;
using ApiCommon.Generator;

#endregion

namespace ApiToWrapper.CodeWriters.Constructs
{
    public class MethodWriter : WriterClassConstruct
    {
        public MethodWriter(CSharpClassWriter classWriter, DataNode node)
        {
            Setup(classWriter, node);
        }


        public string ReturnType { get; private set; }

        public string CppReturnType
        {
            get
            {
                if (!IsHandle) return ClassName;
                return "Handle_" + ClassName;
            }
        }

        private bool IsHandle
        {
            get { return _typeUtil.IsHandle(ClassName); }
        }

        protected string ClassName
        {
            get { return _classWriter.ClassName; }
        }

        public bool IsStatic { get; set; }
        public bool IsProperty { get; set; }

        public string Name { get; private set; }

        private string NativeMethodName
        {
            get
            {
                return _classWriter.ClassName + "_" + Name +
                       OccApiGenerator.NativeMethodSuffix(_parameterList.ParamTypes);
            }
        }

        #region C# code

        public void WriteToFile(List<string> lines, List<string> importedNatives)
        {
            var returnType = ReturnType;
            var methodName = Name;
            var startDeclaration = "public ";
            if (IsStatic)
                startDeclaration += "static ";
            var declaration = startDeclaration + Util.BeautifiedClassName(returnType) + " " + methodName;
            var nativeMethodName = NativeMethodName;
            var paramStr = _parameterList.GetParamString();
            var nativeParamStr = _parameterList.GetCsNativeParamString();
            var addInstanceString = IsStatic ? string.Empty : "IntPtr instance";
            if (_parameterList.Count > 0 && !IsStatic) addInstanceString += ", ";
            var nativeImportText = AddNativeImport(returnType,
                                                   nativeMethodName + "(" + addInstanceString + nativeParamStr + ")");
            importedNatives.Add(nativeImportText);
            lines.Add(Util.Indent(3) + declaration + "(" + paramStr + ")");
            lines.Add(Util.Indent(4) + "{");
            lines.Add(Util.Indent(5) + _parameterList.ComputeCall(returnType, nativeMethodName, IsStatic));
            lines.Add(Util.Indent(4) + "}");
        }

        private string AddNativeImport(string returnType, string nativeMethodName)
        {
            var declarationLine = string.Empty;
            var kindType = _typeUtil.Type(returnType);
            switch (kindType)
            {
                case Consts.Klass:
                    declarationLine += "IntPtr";
                    break;
                case Consts.Enum:
                    declarationLine += "int";
                    break;
                default:
                    declarationLine += returnType;
                    break;
            }
            return declarationLine + " " + nativeMethodName;
        }

        #endregion

        #region C++ code gen

        public void WriteToCppFile(List<string> lines, FileWriter definitionsFile, List<string> includedTypes)
        {
            var returnType = ReturnType;
            var methodDeclaration = GetMethodDeclaration(returnType, NativeMethodName, "DECL_EXPORT ");
            definitionsFile.Lines.Add("extern \"C\" " + methodDeclaration + ";");
            lines.Add(methodDeclaration);
            lines.Add("{");
            _parameterList.DeclareCppConvertParams(lines);
            var className = ClassName;
            var returnIsHandleType = _typeUtil.IsHandle(ReturnType);
            if (!IsStatic)
                lines.Add(Util.Indent(1) + TypeUtil.InstanceToPtr(ClassName, _typeUtil.IsHandle(ClassName)) + ";");

            var baseString = string.Empty;

            var sb = new StringBuilder();
            var kindType = _typeUtil.Type(returnType);
            if (returnType != "void")
            {
                switch (kindType)
                {
                    case Consts.Klass:
                        includedTypes.Add(returnType);
                        sb.Append(Util.Indent(1) + "return new ");
                        if (returnIsHandleType)
                        {
                            sb.Append("Handle_");
                            sb.Append("");
                        }
                        sb.Append(returnType);
                        sb.Append("(");
                        break;
                    default:
                        sb.Append(Util.Indent(1) + "return ");
                        break;
                }
            }

            var paramCall = _parameterList.GetCppParamCall();
            
            sb.Append(baseString);
            sb.Append(" ");
            if (IsStatic)
                sb.Append(className + "::" + Name + "(" + paramCall);
            else
            {
                sb.Append(Util.Indent(1));
                sb.Append("result->" + Name + "(" + paramCall);
            }
            if (kindType == Consts.Klass)
                sb.Append(")");
            sb.AppendLine(");");
            sb.Append("}");

            lines.Add(sb.ToString());
        }

        private string GetMethodDeclaration(string returnType, string methodName, string declarationExport)
        {
            var declarationLine = string.Empty;
            if (returnType != "void")
            {
                if (returnType == "string")
                    declarationLine += "Standard_CString";
                else if (returnType == "IntPtr")
                    declarationLine += "void*";
                else
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
            }
            else
                declarationLine += "void";
            var cppParamString = _parameterList.GetCppParamString(IsStatic);
            return declarationExport + declarationLine + " " + methodName + "(" + cppParamString + ")";
        }

        #endregion

        public override void Process()
        {
            Name = _node.Name;
            ReturnType = _node[Consts.ReturnType];
            if (Name == "Get")
            {
            }
            foreach (var child in _node.Children)
            {
                switch (child.NodeType)
                {
                    case Consts.Attrs:
                        SetAttrs(child);
                        break;
                    case Consts.Parameters:
                        _parameterList.SetParameters(child, _classWriter);
                        break;
                }
            }
            _classWriter.AddDependentType(ReturnType);
        }


        private void SetAttrs(DataNode child)
        {
            IsProperty = child.Get(Consts.IsProperty) != null;
            IsStatic = child.Get(Consts.IsStatic) != null;
        }
    }
}