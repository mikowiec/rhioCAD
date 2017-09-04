#region Usings

using System;
using System.Collections.Generic;
using TreeData.NaroData;

#endregion

namespace TreeData.NaroDataViewer
{
    public class AttributeInterpreterFactory
    {
        private static readonly AttributeInterpreterFactory Instance = new AttributeInterpreterFactory();
        private readonly SortedDictionary<string, string> _shortHands = new SortedDictionary<string, string>();

        private AttributeInterpreterFactory()
        {
            AttributeInterpreters = new SortedDictionary<int, Type>();
        }


        private static Dictionary<string, string> interpreterBaseNames = new Dictionary<string, string>(); 
        private SortedDictionary<int, Type> AttributeInterpreters { get; set; }

        public static void Register<T>()
            where T : AttributeInterpreterBase, new()
        {
            var interpreterName = typeof (T);
            var nameId = interpreterName.GetHashCode();
            var shorthand = ComputeShorthand(interpreterName.FullName);
            Instance.AttributeInterpreters[nameId] = interpreterName;
            Instance._shortHands[shorthand] = interpreterName.FullName;
        }

        private static string ExtractInterpreterBaseName(string name)
        {
            if (interpreterBaseNames.ContainsKey(name))
                return interpreterBaseNames[name];
            var words = name.Split('.');
            var lastword = words[words.Length - 1];
            if (lastword.EndsWith("Interpreter"))
            {
                lastword = lastword.Remove(lastword.LastIndexOf("Interpreter"));
            }
            interpreterBaseNames.Add(name, lastword);
            return lastword;
        }

        private static int GetFullTypeId(string fullName)
        {
            foreach (var typeDesc in Instance.AttributeInterpreters)
            {
                if (typeDesc.Value.FullName == fullName)
                    return typeDesc.Key;
            }
            return -1;
        }

        public static int GetTypeId(string name)
        {
            string fullName;
            if (!Instance._shortHands.TryGetValue(name, out fullName))
                throw new Exception("Invalid string");
            return GetFullTypeId(fullName);
        }

        public static string ComputeShorthand(string fullInterpreterName)
        {
            return ExtractInterpreterBaseName(fullInterpreterName);
        }

        public static AttributeInterpreterBase GetInterpreter(int typeNameId, Node parent)
        {
            Type typeName;
            if (!Instance.AttributeInterpreters.TryGetValue(typeNameId, out typeName))
                return null;
            var result = (AttributeInterpreterBase) Activator.CreateInstance(typeName);
            result.SetupInternal(parent);
            return result;
        }

        public static string GetName(int nameId)
        {
            Type typeName;
            if (Instance.AttributeInterpreters.TryGetValue(nameId, out typeName))
                return ComputeShorthand(typeName.FullName);
            throw new InvalidOperationException(
                string.Format(
                    "Attribute with type ID: {0} not registered. Register current attribute before serialize it", nameId));
        }
    }
}