#region Usings

using System.Collections.Generic;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;
using OccCode;

using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Handles.Gizmos
{
    public class TriangleHandleFunction : HandleBaseFunction
    {
        public TriangleHandleFunction() : base(FunctionNames.TriangleHandle)
        {
        }

        public override bool Execute()
        {
            var mainAxis = Dependency[0].Axis3D.GpAxis;
            var xAxis = Dependency[1].Axis3D.GpAxis;
            var triangleEdgeLength = Dependency[2].Real;
            var ax2 = new gpAx2(mainAxis.Location, mainAxis.Direction) {XDirection = (xAxis.Direction)};

            Shape = BuildTopoDsShapeHandle(ax2, triangleEdgeLength*2);

            return true;
        }

        private static TopoDSShape BuildTopoDsShapeHandle(gpAx2 coordinate, double edgeLength)
        {
            var axisLocation = coordinate.Location;
            var firstPoint = new Point3D(axisLocation);

            var secondPointVector = new gpVec(coordinate.Direction);
            secondPointVector.Multiply(edgeLength);
            var secondPoint = new Point3D(axisLocation.Translated(secondPointVector));

            var thirdPointVector = new gpVec(coordinate.XDirection);
            thirdPointVector.Multiply(edgeLength);
            var thirdPoint = new Point3D(axisLocation.Translated(thirdPointVector));

            var firstLine = GeomUtils.BuildLine(firstPoint, secondPoint);
            var secondLine = GeomUtils.BuildLine(secondPoint, thirdPoint);
            var thirdLine = GeomUtils.BuildLine(thirdPoint, firstPoint);

            var wireList = new List<TopoDSWire> {firstLine, secondLine, thirdLine};
            var face = GeomUtils.MakeFace(wireList);
            return face;
        }
    }
}