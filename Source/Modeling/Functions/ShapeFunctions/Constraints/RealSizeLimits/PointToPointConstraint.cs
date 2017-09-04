#region Usings

using System;
using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.DsgPrs;
using NaroCppCore.Occ.GC;
using OccCode;

using ShapeFunctions.Utils;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.Precision;

#endregion

namespace ShapeFunctions.Constraints.RealSizeLimits
{
    internal class PointToPointConstraint : FunctionBase
    {
        private bool _blockUpdate;

        public PointToPointConstraint()
            : base(FunctionNames.PointToPointConstraint)
        {
            //original shape 
            Dependency.AddAttributeType(InterpreterNames.Reference);
            //original shape 
            Dependency.AddAttributeType(InterpreterNames.Reference);
            //distance point
            Dependency.AddAttributeType(InterpreterNames.Point3D);
        }


        public override bool Execute()
        {
            if (_blockUpdate)
                return true;
            var builder = Builder;
            var sourcePoint = NodeUtils.GetReferencePoint(builder, 0);
            var destinationPoint = NodeUtils.GetReferencePoint(builder, 1);
            var distancePoint = Dependency[2].TransformedPoint3D;
            _blockUpdate = true;
            AISInteractiveObject interactive = null;
            if (ApplyConstraint(Dependency, ref interactive, destinationPoint, sourcePoint, distancePoint))
            {
                Interactive = interactive;
                _blockUpdate = false;
                return true;
            }
            _blockUpdate = false;
            Interactive = UpdateInteractive(sourcePoint);
            return true;
        }

        private bool ApplyConstraint(FunctionDependency dependency, ref AISInteractiveObject interactive,
                                     Point3D destinationPoint, Point3D sourcePoint, Point3D distancePoint)
        {
            var transform = dependency[1].Reference.Set<TransformationInterpreter>();
            var substractedDistance = destinationPoint.SubstractCoordinate(sourcePoint);
            if (dependency[0].Reference.Index != dependency[1].Reference.Index)
            {
                if (distancePoint.IsEqual(substractedDistance))
                {
                    interactive = UpdateInteractive(sourcePoint);
                    return true;
                }

                var translateVal = new Point3D(transform.Translate);
                transform.Translate =
                    translateVal.AddCoordinate(distancePoint.SubstractCoordinate(substractedDistance)).GpPnt;
            }
            else
            {
                var origin = new Point3D();
                var pointDistance = distancePoint.Distance(origin);
                var expectedDistance = substractedDistance.Distance(origin);
                if (Math.Abs(pointDistance - expectedDistance) < Precision.Confusion)
                {
                    interactive = UpdateInteractive(sourcePoint);
                    return true;
                }
                transform.Scale = transform.Scale*pointDistance/expectedDistance;
            }
            return false;
        }

        private AISInteractiveObject UpdateInteractive(Point3D sourcePoint)
        {
            var builder = Builder;
            var destinationPoint = NodeUtils.GetReferencePoint(builder, 1);
            var midPoint = DimensionUtils.ComputeMiddlePoint(sourcePoint, destinationPoint);
            var textPoint = midPoint;
            midPoint.X += 1;
            midPoint.Y += 2;
            midPoint.Z += 3;
            var mkPlane = new GCMakePlane(sourcePoint.GpPnt, destinationPoint.GpPnt, midPoint.GpPnt);
            var plane = mkPlane.Value;
            var ocaisLengthDimension = GeomUtils.BuildLengthDimension(sourcePoint.GpPnt,
                                                                      destinationPoint.GpPnt,
                                                                      plane,
                                                                      textPoint.GpPnt,
                                                                      DsgPrsArrowSide.DsgPrs_AS_BOTHAR, 2, 0.2, false, null);
            return ocaisLengthDimension;
        }
    }
}