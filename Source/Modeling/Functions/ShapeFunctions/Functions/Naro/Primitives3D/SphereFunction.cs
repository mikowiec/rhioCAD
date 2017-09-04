#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.BRepPrimAPI;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives3D
{
    public class SphereFunction : FunctionBase
    {
        public SphereFunction() : base(FunctionNames.Sphere)
        {
            // Center coordinate
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            // Radius
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            var center = Dependency[0].TransformedPoint3D;
            var range = Dependency[1].Real;

            var sphere = new BRepPrimAPIMakeSphere(center.GpPnt, range);

            Shape = sphere.Shape;

            return true;
        }
    }
}