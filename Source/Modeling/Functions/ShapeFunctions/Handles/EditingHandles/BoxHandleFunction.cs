#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace ShapeFunctions.Handles.EditingHandles
{
    public class BoxHandleFunction : HandleBaseFunction
    {
        public BoxHandleFunction() : base(FunctionNames.BoxEditingHandle)
        {
        }

        public override bool Execute()
        {
            var mainAxis = Dependency[0].Axis3D.GpAxis;
            var xAxis = Dependency[1].Axis3D.GpAxis;
            var triangleEdgeLength = Dependency[2].Real;
            var ax2 = new gpAx2(mainAxis.Location, mainAxis.Direction) {XDirection = (xAxis.Direction)};

            Shape = BuildTopoDSShapeHandle(ax2, triangleEdgeLength);

            return true;
        }

        private TopoDSShape BuildTopoDSShapeHandle(gpAx2 spaceCoordinate, double edgeLength)
        {
            return new BRepPrimAPIMakeBox(spaceCoordinate, edgeLength, edgeLength, edgeLength/2).Shape;
        }
    }
}