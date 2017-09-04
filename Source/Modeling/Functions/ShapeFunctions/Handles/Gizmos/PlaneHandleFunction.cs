#region Usings

using System;
using Naro.Infrastructure.Interface.AppUtils;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;
using OccCode;

using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Handles.Gizmos
{
    public class PlaneHandleFunction : HandleBaseFunction
    {
        public PlaneHandleFunction() : base(FunctionNames.PlaneHandle)
        {
        }

        public override bool Execute()
        {
            var planeAxis = Dependency[0].Axis3D.GpAxis;
            var xAxis = Dependency[1].Axis3D.GpAxis;
            var rectangleLength = Dependency[2].Real * CoreGlobalPreferencesSingleton.Instance.EditingHandlerZoom;

            var ax2 = new gpAx2();
            ax2.Axis = (planeAxis);
            ax2.XDirection = (xAxis.Direction);

            var wire = BuildPlane(ax2, 2*rectangleLength);

            if ((wire == null) || (wire.IsNull))
                return false;

            Shape = wire;

            return true;
        }

        private static TopoDSFace BuildPlane(gpAx2 orientation, double rectangleLength)
        {
            var diagonalVector = new gpVec(orientation.XDirection);
            diagonalVector.Multiply(rectangleLength*Math.Sqrt(2));
            var secondPoint = GeomUtils.BuildTranslation(new Point3D(orientation.Location), diagonalVector);
            return OccShapeCreatorCode.BuildRectangle(orientation.Location, secondPoint.GpPnt, orientation.Direction);
        }
    }
}