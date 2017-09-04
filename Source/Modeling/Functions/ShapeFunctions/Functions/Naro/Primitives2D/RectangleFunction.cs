#region Usings

using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class RectangleFunction : FunctionBase
    {
        public RectangleFunction() : base(FunctionNames.Rectangle)
        {
            Dependency.AddAttributeType(InterpreterNames.Axis3D);
            Dependency.AddAttributeType(InterpreterNames.Point3D);
        }

        public override bool Execute()
        {
            var baseAxis = Dependency[0].Axis3D;
            var firstPoint = baseAxis.GpAxis.Location;
            var secondPoint = Dependency[1].TransformedPoint3D.GpPnt;
            var direction = baseAxis.GpAxis.Direction;

            var wire = OccShapeCreatorCode.BuildRectangle(firstPoint, secondPoint, direction);
            if ((wire == null) || (wire.IsNull))
                return false;

            // Generate also the visual shape axis before the shape regeneration
            Axis = baseAxis.GpAxis;
            Shape = wire;

            return true;
        }
    }
}