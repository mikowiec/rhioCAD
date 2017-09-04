#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class LineTwoPointsFunction : FunctionBase
    {
        public LineTwoPointsFunction() : base(FunctionNames.LineTwoPoints)
        {
            // First point of line
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Second point of line
            Dependency.AddAttributeType(InterpreterNames.Reference);
        }

        public override bool Execute()
        {
            var firstPoint = Dependency[0].RefTransformedPoint3D;
            var secondPoint = Dependency[1].RefTransformedPoint3D;
            if (firstPoint.IsEqual(secondPoint))
                return false;

            var aEdge = new BRepBuilderAPIMakeEdge(firstPoint.GpPnt, secondPoint.GpPnt).Edge;
            var wire = new BRepBuilderAPIMakeWire(aEdge).Wire;
            Shape = wire;

            return true;
        }
    }
}