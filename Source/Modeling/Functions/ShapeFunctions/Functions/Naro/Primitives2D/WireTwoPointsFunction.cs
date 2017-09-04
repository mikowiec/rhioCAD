#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using OccCode;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class WireTwoPointsFunction : FunctionBase
    {
        public WireTwoPointsFunction()
            : base(FunctionNames.WireTwoPoints)
        {
            // First point of line
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            // Second point of line
            Dependency.AddAttributeType(InterpreterNames.Point3D);
        }

        public override bool Execute()
        {
            var firstPoint = Dependency[0].TransformedPoint3D;
            var secondPoint = Dependency[1].TransformedPoint3D;
            if (firstPoint.IsEqual(secondPoint))
                return false;

            var aEdge2 = new BRepBuilderAPIMakeEdge(firstPoint.GpPnt, secondPoint.GpPnt).Edge;
            var wire = new BRepBuilderAPIMakeWire(aEdge2).Wire;
            Shape = wire;

            return true;
        }
    }
}