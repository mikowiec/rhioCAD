#region Usages

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

#endregion

namespace ApiCommon.Generator
{
    public static class OccApiGenerator
    {
        private static readonly SortedDictionary<string, string> TypeMappings = new SortedDictionary<string, string>();
        private static string _baseFullName;

        static OccApiGenerator()
        {
            TypeMappings["System.Void"] = "void";
            TypeMappings["System.Double"] = "double";
            TypeMappings["System.Int32"] = "int";
            TypeMappings["System.Boolean"] = "bool";
            TypeMappings["System.String"] = "string";
            TypeMappings["System.IntPtr"] = "IntPtr";
            TypeMappings["System.Char"] = "char";
        }

        public static string PackageName(Type type)
        {
            var typeName = type.Name;
            return PackageName(typeName);
        }

        public static string PackageName(string typeName)
        {
            var words = typeName.Split('_');
            var result = words.Length > 0 ? words[0] : string.Empty;
            if (result.StartsWith("OC")) result = result.Remove(0, 2);
            return result;
        }

        public static string OccClassName(Type type)
        {
            var packageName = PackageName(type);
            var typeName = type.Name;
            var words = typeName.Split('_');
            return words.Length == 1 ? packageName : packageName + "_" + words[1];
        }

        public static DataNode GetClassNode(DataNode dataNode, Type type)
        {
            var fullName = type.FullName;
            var baseType = type.BaseType;
            if (baseType != null) _baseFullName = baseType.FullName;

            if (fullName == null) return null;
            if (!type.IsClass ||
                !fullName.StartsWith("OCNaroWrappers.OC"))
            {
                return null;
            }
            var generator = dataNode.Root.Set(Consts.Occ, Consts.Generator);
            var ns = generator.Set(Consts.NaroCppCore, Consts.Namespace);
            var occ = ns.Set(Consts.Occ, Consts.Namespace);


            var packageName = PackageName(type);
            var packageNode = occ.Set(packageName, Consts.Namespace);

            var klassName = OccClassName(type);

            var result = packageNode.Set(klassName, Consts.Klass);

            if (baseType != null)
            {
                if (
                    !baseType.Equals(typeof (void)) &&
                    _baseFullName != null &&
                    baseType.IsClass &&
                    _baseFullName.StartsWith("OCNaroWrappers.OC"))
                {
                    GetClassNode(dataNode, baseType);
                    var baseName = OccClassName(baseType);
                    result.Set(baseName, Consts.Implements);
                }
            }
            result.Set(Consts.Methods);
            return result;
        }


        public static void PopulateEnum(DataNode dataNode, Type type)
        {
            if (type.FullName == null) return;
            if (!type.IsEnum ||
                !type.FullName.StartsWith("OCNaroWrappers.OC"))
                return;
            var generator = dataNode.Root.Set(Consts.Occ, Consts.Generator);
            var ns = generator.Set(Consts.NaroCppCore, Consts.Namespace);
            var occ = ns.Set(Consts.Occ, Consts.Namespace);
            var packageName = PackageName(type);
            var packageNode = occ.Set(packageName, Consts.Namespace);
            var klassName = OccClassName(type);

            var enumNode = packageNode.Set(klassName, Consts.Enum);
            var sortedFieldsValue = new SortedDictionary<int, string>();
            foreach (var memberInfo in type.GetMembers(BindingFlags.Public | BindingFlags.Static))
            {
                var memberName = memberInfo.Name;
                var value = (int) Enum.Parse(type, memberInfo.Name);
                sortedFieldsValue[value] = memberName;
            }

            var lastVal = -1;
            foreach (var member in sortedFieldsValue)
            {
                var enumMember = enumNode.Set(member.Value, Consts.Field);
                if (lastVal + 1 != member.Key)
                    enumMember.Attributes[Consts.Value] = member.Key.ToString();
                lastVal = member.Key;
            }
        }

        public static bool IsWriteProperty(MethodInfo methodInfo)
        {
            if (!methodInfo.ReturnType.Equals(typeof (void))) return false;
            if (!methodInfo.Name.StartsWith("Set")) return false;
            return (methodInfo.GetParameters().Length == 1);
        }

        public static bool IsReadProperty(MethodInfo methodInfo)
        {
            if (methodInfo.ReturnType.Equals(typeof (void))) return false;
            return (methodInfo.GetParameters().Length == 0);
        }

        public static string PrettyName(DataNode node, Type type)
        {
            var typeName = type.FullName;
            if (string.IsNullOrEmpty(typeName)) throw new NullReferenceException("Wrong data!");
            if (type.IsByRef)
            {
                typeName = typeName.Replace("&", string.Empty);
                node[Consts.IsRef] = "true";
            }
            if (typeName.EndsWith("*"))
            {
                typeName = typeName.Remove(typeName.Length - 1);
                node[Consts.IsRef] = "true";
            }
            var primitiveType = PrimitiveTypeName(typeName);
            if (!string.IsNullOrEmpty(primitiveType)) return primitiveType;
            if (typeName.StartsWith("OCNaroWrappers.OC"))
            {
                var occName = OccClassName(type);
                if (type.IsClass)
                    GetClassNode(node, type);
                if (type.IsEnum)
                    PopulateEnum(node, type);
                return occName;
            }
            return typeName;
        }

        public static string NativeMethodSuffix(List<string> paramTypes)
        {
            if (paramTypes.Count == 0) return string.Empty;
            var baseString = new StringBuilder();
            baseString.Append("_");
            foreach (var paramType in paramTypes)
                baseString.Append(paramType);
            var hash = baseString.ToString().GetHashCode();
            return hash.ToString(("X"));
        }

        public static string PrettyName(string typeName)
        {
            var primitiveType = PrimitiveTypeName(typeName);
            if (!string.IsNullOrEmpty(primitiveType)) return primitiveType;
            const string prefix = "OCNaroWrappers.OC";
            if (typeName.StartsWith(prefix))
            {
                var shortName = typeName.Remove(0, prefix.Length);
                var name = Util.BeautifiedClassName(shortName);
                return name;
            }
            const string shortPrefix = "OC";
            if (typeName.StartsWith(shortPrefix))
            {
                var shortName = typeName.Remove(0, shortPrefix.Length);
                var name = Util.BeautifiedClassName(shortName);
                return name;
            }
            return string.Empty;
        }

        public static bool IsPrimitiveType(string typeName)
        {
            return TypeMappings.ContainsValue(typeName);
        }

        public static string PrimitiveTypeName(string typeName)
        {
            string result;
            return !TypeMappings.TryGetValue(typeName, out result) ? string.Empty : result;
        }

        public static string ConstructorParamsDefinition(ConstructorInfo constructorInfo)
        {
            var parameterInfos = constructorInfo.GetParameters();
            if (parameterInfos.Length == 0) return string.Empty;
            var sb = new StringBuilder();
            foreach (var parameter in parameterInfos)
            {
                var paramName = PrettyName(parameter.ParameterType.Name);
                sb.Append(paramName);
                sb.Append(",");
            }
            var result = sb.ToString();
            result = result.Remove(result.Length - 1);
            return result;
        }

        private static string ComposeParamsName(DataNode constructorNode)
        {
            var paremetersNode = constructorNode.Set(Consts.Parameters).Children;
            if (paremetersNode.Count == 0) return string.Empty;
            var sb = new StringBuilder();
            foreach (var parameter in paremetersNode)
            {
                var paramType = parameter[Consts.ParamType];
                var paramName = parameter.Name;
                sb.Append(paramName);
                sb.Append(",");
            }
            var result = sb.ToString();
            result = result.Remove(result.Length - 1);
            return result;
        }

        public static void BuildConstructorNode(DataNode api, Type type, ConstructorInfo item)
        {
            var klassNode = GetClassNode(api, type);
            var ctorsNode = klassNode.Set(Consts.Constructors);
            var paramDef = ConstructorParamsDefinition(item);
            foreach (var ctor in ctorsNode.Children)
            {
                var existingParamDef = ComposeParamsName(ctor);
                if (paramDef != existingParamDef) continue;
                return;
            }
            var ctorNode = ctorsNode.Add(Consts.Constructor);
            var paremetersNode = ctorNode.Set(Consts.Parameters);
            foreach (var parameter in item.GetParameters())
            {
                var node = paremetersNode.Set(parameter.Name, Consts.Parameter);
                var prettyName = PrettyName(node, parameter.ParameterType);
                node[Consts.ParamType] = prettyName;
            }
        }
    }
}