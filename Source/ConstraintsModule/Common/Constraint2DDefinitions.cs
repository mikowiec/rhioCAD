#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using ShapeFunctionsInterface.Functions;

#endregion

namespace NaroSketchAdapter.Common
{
    internal class Constraint2DDefinitions
    {
        public static void Setup(ActionsGraph actionsGraph)
        {
            var functionFactory =
                actionsGraph[InputNames.FunctionFactoryInput].GetData(NotificationNames.GetValue).Get<IFunctionFactory>();
        }
    }
}