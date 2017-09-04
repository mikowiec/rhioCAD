#region Usings

using System;
using System.Collections.Generic;
using Naro.Infrastructure.Interface.AppUtils;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;
using NaroPipes.Actions;
using OccCode;

using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Handles.EditingHandles
{
    public class Rectangle2DHandleFunction : HandleBaseFunction
    {
        public Rectangle2DHandleFunction() : base(FunctionNames.Rectangle2DHandle)
        {
        }

        public override bool Execute()
        {
            var mainAxis = Dependency[0].Axis3D.GpAxis;
            var xAxis = Dependency[1].Axis3D.GpAxis;
            var rectangleEdgeLength = Dependency[2].Real * CoreGlobalPreferencesSingleton.Instance.EditingHandlerZoom;
            var ax2 = new gpAx2(mainAxis.Location, mainAxis.Direction);
            ax2.XDirection=(xAxis.Direction);

            Shape = BuildTopoDsShapeHandle(ax2, rectangleEdgeLength);

            return true;
        }

        private static TopoDSShape BuildTopoDsShapeHandle(gpAx2 axis, double edgeLength)
        {
            var axisLocation = axis.Location;
            var translationVector = new gpVec(axis.XDirection);
            translationVector.Normalize();
            translationVector.Multiply(edgeLength*Math.Sqrt(2)/2);
            translationVector.Rotate(axis.Axis, Math.PI/4);

            var firstPoint = new Point3D(axisLocation.Translated(translationVector));
            translationVector.Rotate(axis.Axis, Math.PI/2);
            var secondPoint = new Point3D(axisLocation.Translated(translationVector));
            translationVector.Rotate(axis.Axis, Math.PI/2);
            var thirdPoint = new Point3D(axisLocation.Translated(translationVector));
            translationVector.Rotate(axis.Axis, Math.PI/2);
            var fourthPoint = new Point3D(axisLocation.Translated(translationVector));

            var firstLine = GeomUtils.BuildLine(firstPoint, secondPoint);
            var secondLine = GeomUtils.BuildLine(secondPoint, thirdPoint);
            var thirdLine = GeomUtils.BuildLine(thirdPoint, fourthPoint);
            var fourthLine = GeomUtils.BuildLine(fourthPoint, firstPoint);

            var wireList = new List<TopoDSWire> {firstLine, secondLine, thirdLine, fourthLine};
            var face = GeomUtils.MakeFace(wireList);
            return face;
        }
    }
}