#region Usings

using NaroConstants.Names;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Solver
{
    public abstract class DottedLineCommon : FunctionBase
    {
        protected DottedLineCommon(string name)
            : base(name)
        {
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            //Direction
            Dependency.AddAttributeType(InterpreterNames.Point3D);
        }
    }
}