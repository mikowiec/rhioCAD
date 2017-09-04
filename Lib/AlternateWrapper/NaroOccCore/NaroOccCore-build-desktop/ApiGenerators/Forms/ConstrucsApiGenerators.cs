#region Usages

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ApiCommon;
using ApiCommon.Generator;

#endregion

namespace ApiGenerators.Forms
{
    internal static class ConstrucsApiGenerators
    {
        public static string ConstructorParamsDefinition(ConstructorInfo constructorInfo)
        {
            var parameterInfos = constructorInfo.GetParameters();
            if (parameterInfos.Length == 0) return string.Empty;
            var sb = new StringBuilder();
            foreach (var parameter in parameterInfos)
            {
                var paramName = OccApiGenerator.PrettyName(parameter.ParameterType.Name);
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
                var paramName = parameter.Name;
                sb.Append(paramName);
                sb.Append(",");
            }
            var result = sb.ToString();
            result = result.Remove(result.Length - 1);
            return result;
        }

        private static DataNode GetConstructorNode(ConstructorInfo constructorInfo, DataNode methodsNode, DataNode node)
        {
            var paramList = new List<string>();
            foreach (var parameter in constructorInfo.GetParameters())
                paramList.Add(OccApiGenerator.PrettyName(node, parameter.ParameterType));

            return IdentifyUniqueConstruct(string.Empty, paramList, Consts.Constructor, methodsNode);
        }

        public static void BuildConstructorNode(DataNode api, Type type, ConstructorInfo item)
        {
            var klassNode = OccApiGenerator.GetClassNode(api, type);
            var ctorsNode = klassNode.Set(Consts.Constructors);

            var ctorNode = GetConstructorNode(item, ctorsNode, ctorsNode);
            ctorNode.Children.Clear();
            var paremetersNode = ctorNode.Set(Consts.Parameters);
            foreach (var parameter in item.GetParameters())
            {
                var node = paremetersNode.Set(parameter.Name, Consts.Parameter);
                var prettyName = OccApiGenerator.PrettyName(node, parameter.ParameterType);
                node[Consts.ParamType] = prettyName;
            }
        }

        public static void BuildMethodNode(DataNode dataNode, Type type, MethodInfo methodInfo, bool forceIsMethod)
        {
            var klassNode = OccApiGenerator.GetClassNode(dataNode, type);
            var isReadProperty = IsReadProperty(methodInfo);
            var isWriteProperty = IsWriteProperty(methodInfo);
            if (!forceIsMethod && (isReadProperty || isWriteProperty))
            {
                var methodName = methodInfo.Name;
                if (isWriteProperty) methodName = methodName.Remove(0, 3);
                var returnType = isWriteProperty ? methodInfo.GetParameters()[0].ParameterType : methodInfo.ReturnType;
                var propertyNode = klassNode.Set(Consts.Properties).Set(methodName, Consts.Property);
                //var propertyNode = GetPropertiesNode(methodName, propertiesNode, returnType);
                var prettyName = OccApiGenerator.PrettyName(dataNode, returnType);
                propertyNode[Consts.ReturnType] = GetReturnPrettyName(prettyName);
                var attrsNode = propertyNode.Set(Consts.Attrs);
                if (isWriteProperty)
                    attrsNode[Consts.IsWriteProperty] = "true";
                if (isReadProperty)
                    attrsNode[Consts.IsReadProperty] = "true";
                if (methodInfo.IsStatic)
                    attrsNode[Consts.IsStatic] = "true";
            }
            else
            {
                var methodsNode = klassNode.Set(Consts.Methods);
                var methodNode = GetMethodNode(methodInfo, methodsNode, dataNode);
                methodNode.Children.Clear();
                if (methodInfo.IsStatic)
                    methodNode.Set(Consts.Attrs).Set(Consts.IsStatic);
                var primitiveTypeName = OccApiGenerator.PrettyName(dataNode, methodInfo.ReturnType);
                methodNode[Consts.ReturnType] = GetReturnPrettyName(primitiveTypeName);
                var paremetersNode = methodNode.Set(Consts.Parameters);
                foreach (var parameter in methodInfo.GetParameters())
                {
                    var node = paremetersNode.Set(parameter.Name, Consts.Parameter);

                    var prettyName = OccApiGenerator.PrettyName(node, parameter.ParameterType);
                    node[Consts.ParamType] = prettyName;
                }
            }
        }

        private static DataNode GetMethodNode(MethodInfo methodInfo, DataNode methodsNode, DataNode node)
        {
            var paramList = new List<string>();
            foreach (var parameter in methodInfo.GetParameters())
                paramList.Add(OccApiGenerator.PrettyName(node, parameter.ParameterType));

            var result = IdentifyUniqueConstruct(methodInfo.Name, paramList, Consts.Method, methodsNode);
            result.Name = methodInfo.Name;
            return result;
        }

        private static DataNode IdentifyUniqueConstruct(string name, List<string> paramList, string nodeTypeToAdd,
                                                        DataNode parentNode)
        {
            var baseString = GetBaseString(paramList, name);
            foreach (var child in parentNode.Children)
            {
                var childParam = new List<string>();
                var childParamNode = child.Set(Consts.Parameters);
                foreach (var node in childParamNode.Children)
                {
                    var paramType = node[Consts.ParamType];
                    childParam.Add(paramType);
                }
                var childMethodString = child.Name + OccApiGenerator.NativeMethodSuffix(childParam);
                if (childMethodString == baseString)
                    return child;
            }
            var result = parentNode.Add(nodeTypeToAdd);
            return result;
        }

        private static string GetBaseString(List<string> paramList, string name)
        {
            return name + OccApiGenerator.NativeMethodSuffix(paramList);
        }

        private static string GetReturnPrettyName(string primitiveTypeName)
        {
            var returnPrettyName = string.Empty;
            if (!string.IsNullOrEmpty(primitiveTypeName))
            {
                returnPrettyName = primitiveTypeName;
            }
            else
            {
                if (primitiveTypeName != null)
                {
                    var words = primitiveTypeName.Split('.');
                    returnPrettyName = words[words.Length - 1];
                }
            }
            return returnPrettyName;
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
    }
}