#region Usings

using Naro.Infrastructure.Library.Algo;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes2D
{
    internal abstract class EllipseConstraint : FunctionBase
    {
        protected double MajorRadius;
        protected double MinorRadius;
        protected double NewValue;

        private bool _beginUpdate;

        protected EllipseConstraint(string name)
            : base(name)
        {
            Dependency.AddAttributeType(InterpreterNames.Reference);
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        protected NodeBuilder EllipseBuilder
        {
            get { return new NodeBuilder(Dependency[0].Reference); }
        }

        public override bool Execute()
        {
            if (_beginUpdate) return true;
            _beginUpdate = true;
            var builder = ExtractShapeData();
            var result = ConstraintApply(builder);
            _beginUpdate = false;
            return result;
        }

        private NodeBuilder ExtractShapeData()
        {
            var builder = new NodeBuilder(Dependency[0].Reference);

            MinorRadius = GetPreviousMinorRadius(builder);
            MajorRadius = GetPreviousMajorRadius(builder);
            NewValue = Dependency[1].Real;
            return builder;
        }


        private static void SetRadius(NodeBuilder ellipseBuilder, double majorRadius, double minorRadius)
        {
            bool reversed;
            gpDir dirX = null;
            gpDir dirY = null;
            double previousMinorRadius;
            double previousMajorRadius;
            TreeUtils.ComputeEllipseRadiuses(ellipseBuilder[0].TransformedPoint3D, ellipseBuilder[1].TransformedPoint3D,
                                             ellipseBuilder[2].TransformedPoint3D,
                                             out previousMinorRadius, out previousMajorRadius, out reversed,
                                             ref dirX, ref dirY);
            // Calculate the ratio needed to scale the radiuses
            var scaleMajor = majorRadius/previousMajorRadius;
            var scaleMinor = minorRadius/previousMinorRadius;

            var center = ellipseBuilder[0].TransformedPoint3D;

            var translatedPoint = new Point3D(center.X, center.Y, center.Z);
            var translatedPoint2 = new Point3D(center.X, center.Y, center.Z);

            // If minor radius is smaller than major radius
            if (!reversed)
            {
                translatedPoint = TreeUtils.ScaleSegment(translatedPoint, ellipseBuilder[1].TransformedPoint3D, scaleMajor);
                ellipseBuilder[1].TransformedPoint3D = translatedPoint;
                TreeUtils.ScaleSegment(translatedPoint2, ellipseBuilder[2].TransformedPoint3D, scaleMinor);
                ellipseBuilder[2].TransformedPoint3D = translatedPoint2;
            }
            else
            {
                translatedPoint = TreeUtils.ScaleSegment(translatedPoint, ellipseBuilder[1].TransformedPoint3D, scaleMinor);
                ellipseBuilder[1].TransformedPoint3D = translatedPoint;
                TreeUtils.ScaleSegment(translatedPoint2, ellipseBuilder[2].TransformedPoint3D, scaleMajor);
                ellipseBuilder[2].TransformedPoint3D = translatedPoint2;
            }
        }

        private static double GetPreviousMajorRadius(NodeBuilder builder)
        {
            bool reversed;
            gpDir dirX = null;
            gpDir dirY = null;
            double previousMinorRadius;
            double previousMajorRadius;
            TreeUtils.ComputeEllipseRadiuses(builder[0].TransformedPoint3D, builder[1].TransformedPoint3D, builder[2].TransformedPoint3D,
                                             out previousMinorRadius, out previousMajorRadius, out reversed,
                                             ref dirX, ref dirY);
            return previousMajorRadius;
        }


        private static double GetPreviousMinorRadius(NodeBuilder builder)
        {
            bool reversed;
            gpDir dirX = null;
            gpDir dirY = null;
            double previousMinorRadius;
            double previousMajorRadius;
            TreeUtils.ComputeEllipseRadiuses(builder[0].TransformedPoint3D, builder[1].TransformedPoint3D, builder[2].TransformedPoint3D,
                                             out previousMinorRadius, out previousMajorRadius, out reversed,
                                             ref dirX, ref dirY);
            return previousMinorRadius;
        }

        protected static void SetMajorRadius(NodeBuilder ellipseBuilder, double data)
        {
            SetRadius(ellipseBuilder, data, GetPreviousMajorRadius(ellipseBuilder));
        }

        protected void SetMinorRadius(double data)
        {
            SetRadius(EllipseBuilder, GetPreviousMinorRadius(EllipseBuilder), data);
        }

        protected abstract bool ConstraintApply(NodeBuilder ellipse);
    }
}