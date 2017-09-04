#region Usages

using System.Collections.Generic;
using System.IO;
using System.Text;

#endregion

namespace ApiCommon.Generator
{
    public static class Util
    {
        public static void ImportDllString(string dllName, List<string> lines, string nativeFunction)
        {
            lines.Add(Indent(2) + "[DllImport(\"" + dllName + "\")]");
            lines.Add(Indent(2) + "private static extern " + nativeFunction + ";");
        }

        public static string ReplaceCharWithAnotherInStr(string text, char toFind, char toReplace)
        {
            var words = text.Split(toFind);
            var sb = new StringBuilder();

            foreach (var word in words)
            {
                sb.Append(word);
                sb.Append(toReplace);
            }
            var result = sb.ToString();
            result = result.Remove(result.Length - 1);
            return result;
        }

        public static string ToPlatformPath(string filePath)
        {
            var separatorChar = Path.DirectorySeparatorChar;
            switch (separatorChar)
            {
                case '/':
                    return ReplaceCharWithAnotherInStr(filePath, '\\', '/');
                case '\\':
                    return ReplaceCharWithAnotherInStr(filePath, '/', '\\');
                default:
                    throw new InvalidDataException();
            }
        }

        public static void NativeInstanceDestructor(string klassName, List<string> lines, string dllName,
                                                    bool defaultConstructorSet)
        {
            var toAdd = new List<string>
                            {
                                string.Empty,
                                Indent(2) + "#region NativeInstancePtr Convert constructor",
                                string.Empty,
                                Indent(2) + "public " + klassName + "() { } ",
                                string.Empty,
                                Indent(2) + "public " + klassName + "(IntPtr instance) : base(instance) { } ",
                                string.Empty,
                                Indent(2) + "protected override void DeleteSelf()",
                                Indent(2) + "{ " + klassName + "_Dtor(Instance); }",
                                string.Empty,
                                Indent(2) + "#endregion",
                                string.Empty
                            };
            if (defaultConstructorSet)
            {
                toAdd.RemoveRange(3, 2);
            }
            lines.AddRange(toAdd);
            ImportDllString(dllName, lines, "void " + klassName + "_Dtor(IntPtr instance)");
        }

        public static string Indent(int times)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < times; i++)
                sb.Append("\t");
            return sb.ToString();
        }

        public static string ToCamel(string text)
        {
            var lower = text.ToLowerInvariant().ToCharArray();
            lower[0] = lower[0].ToString().ToUpper()[0];
            var result = new string(lower);
            return result;
        }

        //From gp_Pnt to gpPnt
        public static string BeautifiedClassName(string klassName)
        {
            var words = klassName.Split('_');
            var sb = new StringBuilder();
            foreach (var word in words)
                sb.Append(word);
            return sb.ToString();
        }

        public static void CreateFolder(string folderName)
        {
            Directory.CreateDirectory(folderName);
        }


        public static string ExtractPackage(string className)
        {
            return !className.Contains("_") ? className : className.Split('_')[0];
        }
    }
}