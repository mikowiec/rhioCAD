#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.BRepPrimAPI;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives3D
{
    public class Box1PFunction : FunctionBase
    {
        public Box1PFunction() : base(FunctionNames.Box1P)
        {
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            Dependency.AddAttributeType(InterpreterNames.Real);
            Dependency.AddAttributeType(InterpreterNames.Real);
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            var point = Dependency[0].TransformedPoint3D;
            var boxWidth = Dependency[1].Real;
            var boxHeight = Dependency[1].Real;
            var boxThick = Dependency[1].Real;
            // Display two dynamic boxes at the end of the line
            Shape = new BRepPrimAPIMakeBox(point.GpPnt, boxWidth, boxHeight, boxThick).Shape;
            return true;
        }
    }
}