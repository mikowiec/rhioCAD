#region Usings

using System;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.gp;

#endregion

namespace ShapeFunctions.Handles.Gizmos
{
    public class CircleHandleFunction : HandleBaseFunction
    {
        public CircleHandleFunction() : base(FunctionNames.CircleHandle)
        {
        }

        public override bool Execute()
        {
            var mainAxis = Dependency[0].Axis3D.GpAxis;
            var xAxis = Dependency[1].Axis3D.GpAxis;
            var radius = Dependency[2].Real;
            var radius2 = Dependency[3].Real;
            var ax2 = new gpAx2(mainAxis.Location, mainAxis.Direction) {XDirection = xAxis.Direction};

            var torusShape = new BRepPrimAPIMakeTorus(ax2, radius*3, radius2/3, 2*Math.PI);
            Shape = torusShape.Shape;
            //Shape = GeomUtils.CreateWireCircle(mainAxis, radius * 3);

            return true;
        }
    }
}