#region Usings

using System;
using Naro.Infrastructure.Library.Algo;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using OccCode;

using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.Precision;

#endregion

namespace ShapeFunctions.Constraints.RealSizeLimits
{
    internal class EdgeDistanceConstraint : FunctionBase
    {
        public EdgeDistanceConstraint() : base(FunctionNames.EdgeDistanceConstraint)
        {
            //source shape
            Dependency.AddAttributeType(InterpreterNames.Reference);
            Dependency.AddAttributeType(InterpreterNames.Real);
            //constrained shape
            Dependency.AddAttributeType(InterpreterNames.Reference);
            Dependency.AddAttributeType(InterpreterNames.Integer);
        }

        public override bool Execute()
        {
            var edgeNode = Dependency[0].Reference;
            var edgeIndexNode = Dependency[0].ReferenceData.ShapeCount;

            if (ShapeUtils.ExtractShape(edgeNode) == null)
            {
                return false;
            }
            var edge =
                TopoDS.Edge(ShapeUtils.ExtractSubShape(edgeNode, edgeIndexNode, TopAbsShapeEnum.TopAbs_EDGE));
            var distance = Dependency[1].Real;

            var referenceShape = Dependency[2].Reference;
            var referebceShapePointIndex = Dependency[3].Integer;
            if (referenceShape == null)
                return false;
            var point = NodeBuilderUtils.GetNodePoint(referenceShape[referebceShapePointIndex]);

            if (point != null)
            {
                var projectionPoint = GeomUtils.ProjectPointOnEdge(edge, ((Point3D) point).GpPnt);
                var newPoint = new Point3D(projectionPoint);
                var currentDistance = projectionPoint.Distance(((Point3D) point).GpPnt);
                if (Math.Abs(currentDistance - distance) > 0.01)
                {
                    var scale = currentDistance/distance;
                    if (Math.Abs(scale - 1) > Precision.Confusion)
                        newPoint = TreeUtils.ScaleSegment(newPoint, ((Point3D) point), scale);
                }

                NodeBuilderUtils.SetupNodePoint(referenceShape[referebceShapePointIndex], newPoint);
            }
            return true;
        }
    }
}