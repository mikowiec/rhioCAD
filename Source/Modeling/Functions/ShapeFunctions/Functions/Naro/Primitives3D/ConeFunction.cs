#region Usings

using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives3D
{
    public class ConeFunction : FunctionBase
    {
        public ConeFunction() : base(FunctionNames.Cone)
        {
            // Center axis
            Dependency.AddAttributeType(InterpreterNames.Axis3D);
            // Radius in the plane z=0
            Dependency.AddAttributeType(InterpreterNames.Real);
            // Radius in the plane z=height
            Dependency.AddAttributeType(InterpreterNames.Real);
            // Height
            Dependency.AddAttributeType(InterpreterNames.Real);
            // Angle
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            var centerAxis = Dependency[0].Axis3D;
            var radius1 = Dependency[1].Real;
            var radius2 = Dependency[2].Real;
            var height = Dependency[3].Real;
            var angle = Dependency[4].Real; // / 180.0 * Math.PI;

            Shape = GeomUtils.MakeCone(centerAxis.GpAxis, radius1, radius2, height, angle);

            return true;
        }
    }
}