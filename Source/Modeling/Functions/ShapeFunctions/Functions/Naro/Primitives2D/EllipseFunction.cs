#region Usings

using Naro.Infrastructure.Library.Algo;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class EllipseFunction : FunctionBase
    {
        public EllipseFunction() : base(FunctionNames.Ellipse)
        {
            Dependency.AddAttributeType(InterpreterNames.Reference);
            Dependency.AddAttributeType(InterpreterNames.Reference);
            Dependency.AddAttributeType(InterpreterNames.Reference);
        }

        public override bool Execute()
        {
            var point1 = Dependency[0].ReferenceBuilder[1].TransformedPoint3D;
            var point2 = Dependency[1].ReferenceBuilder[1].TransformedPoint3D;
            var point3 = Dependency[2].ReferenceBuilder[1].TransformedPoint3D;
            Shape = BuildEllipse(point1, point2, point3);

            return true;
        }

        /// <summary>
        ///   Builds an ellipse from 3 points in space
        /// </summary>
        private static TopoDSWire BuildEllipse(Point3D center, Point3D secondPoint, Point3D thirdPoint)
        {
            double minorRadius;
            double majorRadius;
            bool reversed;
            gpDir dirX = null;
            gpDir dirY = null;

            if (secondPoint.GpPnt.Distance(thirdPoint.GpPnt) < Precision.Confusion)
            {
                return null;
            }


            if (!TreeUtils.ComputeEllipseRadiuses(center, secondPoint, thirdPoint,
                                                  out minorRadius, out majorRadius, out reversed,
                                                  ref dirX, ref dirY))
            {
                return null;
            }
            // Build a plane from the 3 points
            var plane = GeomUtils.BuildPlane(center, secondPoint, thirdPoint);
            var ax1 = plane.Axis;
            var ax2 = new gpAx2();
            ax2.Axis = (ax1);
            ax2.Location = (center.GpPnt);

            // If major and minor radius are reversed also their directions arereversed
            if (!reversed)
            {
                ax2.XDirection=(dirX);
                ax2.YDirection=(dirY);
            }
            else
            {
                ax2.XDirection=(dirY);
                ax2.YDirection=(dirX);
            }

            var ellipse = new GeomEllipse(ax2, majorRadius, minorRadius);
            var edge = new BRepBuilderAPIMakeEdge(ellipse).Edge;
            var wire = new BRepBuilderAPIMakeWire(edge).Wire;
            return wire;
        }
    }
}