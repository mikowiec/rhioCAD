#region Usings

using NaroConstants.Names;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Handles
{
    public abstract class HandleBaseFunction : FunctionBase
    {
        protected HandleBaseFunction(string name) : base(name)
        {
// Due to lack of gpAx2 Interpreter used two gpAx1 interpreters

            // Handle location and main direction
            Dependency.AddAttributeType(InterpreterNames.Axis3D);
            // ! XAxis direction
            Dependency.AddAttributeType(InterpreterNames.Axis3D);
            // Axis length
            Dependency.AddAttributeType(InterpreterNames.Real);
            // Axis width
            Dependency.AddAttributeType(InterpreterNames.Real);
        }
    }
}