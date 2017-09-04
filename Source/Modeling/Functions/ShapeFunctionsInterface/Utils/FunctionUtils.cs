#region Usings

using ShapeFunctionsInterface.Functions;
using TreeData.NaroData;

#endregion

namespace ShapeFunctionsInterface.Utils
{
    public static class FunctionUtils
    {
        public static string GetFunctionName(Node node)
        {
            if (node == null)
                return string.Empty;
            return node.Get<FunctionInterpreter>() == null ? string.Empty : node.Get<FunctionInterpreter>().Name;
        }
    }
}