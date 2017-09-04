#region Usages

using System;
using System.Collections.Generic;
using System.Text;
using ApiCommon;
using ApiCommon.Generator;

#endregion

namespace ApiToWrapper.CodeWriters.Constructs
{
    public class ParameterListWriter
    {
        private readonly TypeUtil _typeUtil;

        public ParameterListWriter(DataNode node)
        {
            _typeUtil = new TypeUtil(node);
            ParamTypes = new List<string>();
            ParamNames = new List<string>();
            ByRef = new List<bool>();
        }

        public int Count
        {
            get { return ParamNames.Count; }
        }

        public List<string> ParamTypes { get; private set; }
        private List<string> ParamNames { get; set; }
        private List<bool> ByRef { get; set; }

        public void SetParameters(DataNode child, CSharpClassWriter classWriter)
        {
            foreach (var node in child.Children)
            {
                classWriter.AddDependentType(node[Consts.ParamType]);
                ParamNames.Add(node.Name);
                ParamTypes.Add(node[Consts.ParamType]);
                ByRef.Add(node.Is(Consts.IsRef));
            }
        }

        internal string GetCppParamString(bool isStatic)
        {
            if (!isStatic && ParamTypes.Count == 0)
                return "void* instance";
            if (ParamTypes.Count == 0) return string.Empty;
            var sb = new StringBuilder();
            if (!isStatic)
            {
                Indent(sb);
                sb.Append("void* instance,");
            }
            for (var i = 0; i < Count; i++)
            {
                Indent(sb);
                var value = ParamTypes[i];
                var paramType = _typeUtil.Type(value);
                switch (paramType)
                {
                    case Consts.Klass:
                        sb.Append("void*");
                        break;
                    case Consts.Enum:
                        sb.Append("int");
                        break;
                    default:
                        var toNativeType = TypeUtil.ToCppNativeType(value);
                        sb.Append(toNativeType);
                        if (ByRef[i])
                            sb.Append("*");
                        break;
                }
                sb.Append(" ");
                sb.Append(ParamNames[i]);
                if (i == Count - 1) continue;
                sb.Append(",");
            }
            return sb.ToString();
        }

        private static void Indent(StringBuilder sb)
        {
            sb.Append(Environment.NewLine + Util.Indent(1));
        }

        public string GetParamCall()
        {
            if (Count == 0) return string.Empty;
            var sb = new StringBuilder();
            for (var i = 0; i < Count; i++)
            {
                if (ByRef[i])
                    sb.Append("ref ");
                var paramName = ParamNames[i];
                var paramType = _typeUtil.Type(ParamTypes[i]);
                switch (paramType)
                {
                    case Consts.Klass:
                        sb.Append(paramName);
                        sb.Append(".Instance");
                        break;
                    case Consts.Enum:
                        sb.Append("(int)");
                        sb.Append(paramName);
                        break;
                    default:
                        sb.Append(paramName);
                        break;
                }
                sb.Append(", ");
            }
            var result = sb.ToString();
            result = result.Remove(result.Length - 2);
            return result;
        }

        public string GetParamString()
        {
            IList<string> paramTypes = ParamTypes;
            IList<string> paramNames = ParamNames;
            if (paramTypes.Count == 0) return string.Empty;
            var sb = new StringBuilder();
            for (var i = 0; i < paramNames.Count; i++)
            {
                if (ByRef[i])
                    sb.Append("ref ");
                sb.Append(Util.BeautifiedClassName(paramTypes[i]));
                sb.Append(" ");
                sb.Append(paramNames[i]);
                sb.Append(",");
            }
            var result = sb.ToString();
            result = result.Remove(result.Length - 1);
            return result;
        }

        public string GetCsNativeParamString()
        {
            if (ParamTypes.Count == 0) return string.Empty;
            var sb = new StringBuilder();
            for (var i = 0; i < Count; i++)
            {
                if (ByRef[i])
                    sb.Append("ref ");
                var paramType = _typeUtil.Type(ParamTypes[i]);
                switch (paramType)
                {
                    case Consts.Klass:
                        sb.Append("IntPtr");
                        break;
                    case Consts.Enum:
                        sb.Append("int");
                        break;
                    default:
                        sb.Append(ParamTypes[i]);
                        break;
                }
                sb.Append(" ");
                sb.Append(ParamNames[i]);
                sb.Append(",");
            }
            var result = sb.ToString();
            result = result.Remove(result.Length - 1);
            return result;
        }

        public string GetCsParamString()
        {
            if (ParamTypes.Count == 0) return string.Empty;
            var sb = new StringBuilder();
            for (var i = 0; i < ParamTypes.Count; i++)
            {
                if (ByRef[i])
                    sb.Append("ref ");
                var usedTypeName = Util.BeautifiedClassName(ParamTypes[i]);
                sb.Append(usedTypeName);
                sb.Append(" ");
                sb.Append(ParamNames[i]);
                sb.Append(",");
            }
            var result = sb.ToString();
            result = result.Remove(result.Length - 1);
            return result;
        }

        public string GetCppParamCall()
        {
            if (Count == 0) return string.Empty;
            var sb = new StringBuilder();
            for (var i = 0; i < Count; i++)
            {
                sb.AppendLine(Util.Indent(3));
                var paramType = _typeUtil.Type(ParamTypes[i]);
                switch (paramType)
                {
                    case Consts.Klass:
                        sb.AppendFormat("_{0}", ParamNames[i]);
                        break;
                    case Consts.Enum:
                        sb.AppendFormat("_{0}", ParamNames[i]);
                        break;
                    default:
                        if (ByRef[i])
                            sb.Append("*");
                        sb.Append(ParamNames[i]);
                        break;
                }
                if (i != Count - 1)
                    sb.Append(",");
            }
            var result = sb.ToString();
            return result;
        }

        public string ComputeCall(string returnType, string nativeMethodName, bool isStatic)
        {
            var paramType = _typeUtil.Type(returnType);
            var sb = new StringBuilder();
            if (returnType != "void")
            {
                sb.Append("return ");
                switch (paramType)
                {
                    case Consts.Klass:
                        sb.Append("new ");
                        sb.Append(Util.BeautifiedClassName(returnType));
                        sb.Append("(");
                        break;
                    case Consts.Enum:
                        sb.Append("(" + Util.BeautifiedClassName(returnType) + ")");
                        break;
                }
            }
            sb.Append(nativeMethodName);
            sb.Append("(");
            if (!isStatic)
            {
                sb.Append("Instance");
                if (Count > 0)
                    sb.Append(", ");
            }
            sb.Append(GetParamCall());
            sb.Append(")");

            if (paramType == Consts.Klass)
                sb.Append(")");
            sb.Append(";");
            return sb.ToString();
        }

        public void DeclareCppConvertParams(List<string> lines)
        {
            if (Count == 0) return;
            for (var i = 0; i < Count; i++)
            {
                var sb = new StringBuilder();
                sb.Append(Util.Indent(2));
                var paramType = _typeUtil.Type(ParamTypes[i]);
                switch (paramType)
                {
                    case Consts.Klass:
                        var isHandleType = _typeUtil.IsHandle(ParamTypes[i]);
                        if (isHandleType)
                            sb.AppendFormat(
                                "const Handle_{0}&  _{1} =*(const Handle_{0} *){1};",
                                ParamTypes[i], ParamNames[i]);
                        else sb.AppendFormat(
                                "const {0} &  _{1} =*(const {0} *){1};",
                                ParamTypes[i], ParamNames[i]);
                        lines.Add(sb.ToString());

                        break;
                    case Consts.Enum:
                        sb.AppendFormat("const {0} _{1} =(const {0} ){1};",
                            ParamTypes[i], ParamNames[i]);

                        lines.Add(sb.ToString());
                        break;
                }
            }
        }
    }
}
