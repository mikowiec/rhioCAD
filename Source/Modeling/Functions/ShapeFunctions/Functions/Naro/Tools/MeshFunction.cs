#region Usings

using NaroConstants.Names;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    public class MeshFunction : FunctionBase
    {
        public MeshFunction() : base(FunctionNames.Mesh)
        {
            Dependency.AddAttributeType(InterpreterNames.MeshTopoShape);
        }

        public override bool Execute()
        {
            Shape = Dependency[0].Shape;
            return true;
        }
    }
}