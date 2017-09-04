#region Usings

using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives3D
{
    public class CylinderFunction : FunctionBase
    {
        public CylinderFunction() : base(FunctionNames.Cylinder)
        {
            // Center axis
            Dependency.AddAttributeType(InterpreterNames.Axis3D);
            // Radius
            Dependency.AddAttributeType(InterpreterNames.Real);
            // Length
            Dependency.AddAttributeType(InterpreterNames.Real);
            // Angle
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            var centerAxis = Dependency[0].Axis3D;
            var radius = Dependency[1].Real;
            var height = Dependency[2].Real;
            var angle = Dependency[3].Real; // / 180.0 * Math.PI;

            Shape = GeomUtils.MakeCylinder(centerAxis.GpAxis, radius, height, angle);

            return true;
        }
    }
}