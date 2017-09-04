#region Usings

using System;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.DsgPrs;
using NaroCppCore.Occ.GC;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class PointsDimensionFunction : FunctionBase
    {
        public PointsDimensionFunction() : base(FunctionNames.PointsDimension)
        {
            // First point of dimension
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            // Second point of dimension
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            // Dimension text location
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            // OCDsgPrs_ArrowSide enum value
            Dependency.AddAttributeType(InterpreterNames.Integer);
            // Arrow size drawn on scene
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            var startPoint = Dependency[0].TransformedPoint3D;
            var endPoint = Dependency[1].TransformedPoint3D;
            var textLocation = Dependency[2].TransformedPoint3D.GpPnt;
            var arrowSide = (DsgPrsArrowSide) Dependency[3].Integer;
            var arrowSize = Dependency[4].Real;

            var interactive = CreateDimension(startPoint.GpPnt, endPoint.GpPnt, textLocation, arrowSide,
                                              arrowSize);
            if (interactive == null)
            {
                return false;
            }
            var attributes = Parent.Get<DrawingAttributesInterpreter>();
            if (attributes != null)
            {
                var color = attributes.OccColor;
                interactive.SetColor(color);
            }
            Interactive = interactive;

            return true;
        }

        /// <summary>
        ///   Builds a dimension between a start and end point.
        /// </summary>
        private static AISInteractiveObject CreateDimension(gpPnt startPoint, gpPnt endPoint,
                                                               gpPnt textLocation, DsgPrsArrowSide arrowSide,
                                                               double arrowSize)
        {
            var mkPlane = new GCMakePlane(startPoint, endPoint, textLocation);
            var plane = new GeomPlane(new gpPln());
            try
            {
                plane = mkPlane.Value;
            }
            catch (Exception)
            {
                //return null;
            }

            var length = startPoint.Distance(endPoint);
            return length < 1e-12
                       ? null
                       : GeomUtils.BuildLengthDimension(startPoint, endPoint, plane, textLocation, arrowSide, arrowSize,
                                                        0.2, false, null);
        }
    }
}