#region Usages

using System.Collections.Generic;
using System.Text;
using ApiCommon;
using ApiCommon.Generator;

#endregion

namespace ApiToWrapper.CodeWriters.Constructs
{
    public class PropertyWriter
    {
        private readonly CSharpClassWriter _classWriter;
        private readonly DataNode _node;
        private readonly TypeUtil _typeUtil;

        private bool _isReadProperty;
        private bool _isStatic;
        private bool _isWriteProperty;
        private string _name;
        private string _returnType;

        public PropertyWriter(CSharpClassWriter classWriter, DataNode node)
        {
            _classWriter = classWriter;
            _node = node;
            _typeUtil = new TypeUtil(node);
        }

        private string ClassName
        {
            get { return _classWriter.ClassName; }
        }

        private bool IsHandle
        {
            get { return _typeUtil.IsHandle(_returnType); }
        }

        public void Process()
        {
            _name = _node.Name;
            _returnType = _node[Consts.ReturnType];
            var attrsNode = _node.Get(Consts.Attrs);
            if (attrsNode == null) return;

            _isWriteProperty = attrsNode.Is(Consts.IsWriteProperty);
            _isReadProperty = attrsNode.Is(Consts.IsReadProperty);
            _isStatic = attrsNode.Is(Consts.IsStatic);
            _classWriter.AddDependentType(_returnType);
        }

        public void WriteToFile(List<string> lines, List<string> importedNativeFunctions)
        {
            var returnType = _returnType;
            _classWriter.AddDependentType(returnType);
            var methodName = _name;
            var startDeclaration = "public ";
            if (_isStatic)
                startDeclaration += "static ";
            var declaration = startDeclaration + Util.BeautifiedClassName(returnType) + " " + methodName;
            WritePropertyBody(returnType, declaration, lines, importedNativeFunctions);
        }

        private void WritePropertyBody(string returnType, string declaration, List<string> lines,
                                       List<string> importedNatives)
        {
            declaration += "{";
            lines.Add(Util.Indent(2) + declaration);

            if (_isWriteProperty)
            {
                lines.Add(Util.Indent(3) + "set { ");
                AddNativeImport(returnType, true, _name, importedNatives);
                WriteCsPropertyBody(returnType, lines, "Set" + _name);
                lines.Add(Util.Indent(3) + "}");
            }
            if (_isReadProperty)
            {
                lines.Add(Util.Indent(3) + "get {");
                AddNativeImport(returnType, false, _name, importedNatives);
                WriteCsReadPropertyBody(returnType, lines, _name);
                lines.Add(Util.Indent(3) + "}");
            }
            lines.Add(Util.Indent(2) + "}");
        }

        private void WriteCsReadPropertyBody(string returnType, List<string> lines, string name)
        {
            var nativeMethodName = _classWriter.ClassName + "_" + name;
            var callString = _isStatic ? "()" : "(Instance)";
            var fullCallString = nativeMethodName + callString;
            switch (_typeUtil.Type(returnType))
            {
                case Consts.Klass:
                    fullCallString = "new " + Util.BeautifiedClassName(returnType) + "(" + fullCallString +
                                     ")";
                    break;
                case Consts.Enum:
                    fullCallString = "(" + Util.BeautifiedClassName(returnType) + ")" + fullCallString;
                    break;
            }
            fullCallString += ";";
            lines.Add(Util.Indent(4) + "return " + fullCallString);
        }

        private void WriteCsPropertyBody(string returnType, List<string> lines, string name)
        {
            var nativeMethodName = _classWriter.ClassName + "_" + name;
            var valueString = "value";
            switch (_typeUtil.Type(returnType))
            {
                case Consts.Enum:
                    valueString = "(int)value";
                    break;
                case Consts.Klass:
                    valueString = "value.Instance";
                    break;
            }
            var callString = _isStatic ? "(" + valueString + ");" : "(Instance, " + valueString + ");";
            lines.Add(Util.Indent(4) + nativeMethodName + callString);
        }

        private void AddNativeImport(string returnType, bool isWriteProperty, string name,
                                     ICollection<string> importedNatives)
        {
            var declarationLine = string.Empty;
            var nativeMethodName = GetNativeMethodName(isWriteProperty, name);
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

            if (isWriteProperty)
            {
                var callString = _isStatic ? string.Empty : "IntPtr instance, ";
                var item = "void " + nativeMethodName + "(" + callString + declarationLine + " value)";
                importedNatives.Add(item);
                return;
            }
            var paramString = _isStatic ? string.Empty : "IntPtr instance";
            var result = declarationLine + " " + nativeMethodName + "(" + paramString + ")";
            importedNatives.Add(result);
            return;
        }

        private string GetNativeMethodName(bool isWriteProperty, string name)
        {
            if (isWriteProperty) name = "Set" + name;
            return ClassName + "_" + name;
        }

        #region C++ code gen

        private string Name
        {
            get { return _node.Name; }
        }

        public void WriteToCppFile(List<string> lines, FileWriter definitionsFile, List<string> includedTypes)
        {
            if (_isWriteProperty)
                WriteCppMethod(true, definitionsFile, lines, includedTypes);
            if (_isReadProperty)
                WriteCppMethod(false, definitionsFile, lines, includedTypes);
        }

        private void WriteCppMethod(bool isWriteProperty, FileWriter definitionsFile, List<string> lines,
                                    List<string> includedTypes)
        {
            var nativeMethodName = GetNativeMethodName(isWriteProperty, _name);
            var methodDeclaration = GetMethodDeclaration(nativeMethodName, "DECL_EXPORT ", isWriteProperty);
            definitionsFile.Lines.Add("extern \"C\" " + methodDeclaration + ";");
            lines.Add(methodDeclaration);
            lines.Add("{");
            var className = _classWriter.ClassName;
            if (!_isStatic)
                lines.Add(Util.Indent(1) + TypeUtil.InstanceToPtr(ClassName, _typeUtil.IsHandle(ClassName)) + ";");

            var baseString = string.Empty;

            var cppCallName = isWriteProperty ? "Set" + Name : Name;

            var sb = new StringBuilder();
            sb.Append(baseString);
            sb.Append(Util.Indent(1));
            var paramCall = GetCppParamCall(isWriteProperty);
            var kindType = GetKindType();
            if (!isWriteProperty)
            {
                sb.Append("return ");
                switch (kindType)
                {
                    case Consts.Klass:
                        includedTypes.Add(_returnType);
                        sb.Append(Util.Indent(1) + "new ");
                        if (IsHandle)
                        {
                            sb.Append("Handle_");
                        }
                        sb.Append(_returnType);
                        sb.Append("(");
                        break;
                    case Consts.Enum:
                        sb.Append("(int)");
                        break;
                }
            }
            if (_isStatic)
                sb.Append(className + "::" + cppCallName + "(" + paramCall);
            else
            {
                sb.Append(Util.Indent(1));
                sb.Append("result->");
                sb.Append(cppCallName);
                sb.Append("(");
                sb.Append(paramCall);
            }
            if (!isWriteProperty)
            {
                if (kindType == Consts.Klass)
                    sb.Append(")");
            }
            sb.AppendLine(");");
            sb.AppendLine("}");
            lines.Add(sb.ToString());
        }

        private string GetKindType()
        {
            return _typeUtil.Type(_returnType);
        }

        private string GetCppParamCall(bool isWrite)
        {
            if (!isWrite) return string.Empty;
            var kindType = GetKindType();
            switch (kindType)
            {
                case Consts.Klass:
                    {
                        var isHandle = _typeUtil.IsHandle(_returnType);
                        if (!isHandle)
                        {
                            var fullCall = "*(const " + _returnType + " *)" + "value";

                            return fullCall;
                        }
                        else
                        {
                            var fullCall = "*(const Handle_" + _returnType + " *)" + "value";

                            return fullCall;
                        }
                    }
                case Consts.Enum:
                    var enumCall = "(const " + _returnType + ")" + "value";
                    return enumCall;
                default:
                    return "value";
            }
        }

        private string GetMethodDeclaration(string methodName, string declarationExport, bool isWriteProperty)
        {
            var returnType = isWriteProperty ? "void" : _returnType;
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
            var cppParamString = GetCppParamString(isWriteProperty);
            return declarationExport + declarationLine + " " + methodName + "(" + cppParamString + ")";
        }

        private string GetCppParamString(bool isWriteProperty)
        {
            if (!_isStatic && !isWriteProperty)
                return "void* instance";
            if (!isWriteProperty) return string.Empty;
            var sb = new StringBuilder();
            if (!_isStatic)
                sb.Append("void* instance");
            var value = _returnType;
            var paramType = _typeUtil.Type(value);
            switch (paramType)
            {
                case Consts.Klass:
                    sb.Append(", void*");
                    break;
                case Consts.Enum:
                    sb.Append(", int");
                    break;
                default:
                    var toNativeType = TypeUtil.ToCppNativeType(value);
                    sb.Append(", ");
                    sb.Append(toNativeType);
                    break;
            }
            sb.Append(" value");
            return sb.ToString();
        }

        #endregion
    }
}