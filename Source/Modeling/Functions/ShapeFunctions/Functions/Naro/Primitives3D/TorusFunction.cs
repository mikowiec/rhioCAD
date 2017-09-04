#region Usings

using System;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.gp;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives3D
{
    public class TorusFunction : FunctionBase
    {
        public TorusFunction() : base(FunctionNames.Torus)
        {
            // Center location and torus orientation
            Dependency.AddAttributeType(InterpreterNames.Axis3D);
            // Internal radius
            Dependency.AddAttributeType(InterpreterNames.Real);
            // External radius
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            var centerAxis = Dependency[0].Axis3D;
            var ax2 = new gpAx2 {Axis = (centerAxis.GpAxis)};
            var radius1 = Dependency[1].Real;
            var radius2 = Dependency[2].Real;

            //BRepPrimAPIMakeTorus cylinderShape = new BRepPrimAPIMakeTorus(
            //    p, radius1, radius2, angle1, angle2, angle);
            var torusShape = new BRepPrimAPIMakeTorus(ax2, radius1, radius2, 2*Math.PI);
            //if (!torusShape.IsDone()) 
            //    return false;

            //Pivot = centerAxis.Location;
            Shape = torusShape.Shape;

            return true;
        }
    }
}