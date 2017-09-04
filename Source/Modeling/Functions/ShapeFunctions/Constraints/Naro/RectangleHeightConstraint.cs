#region Usings

using Naro.Infrastructure.Library.Algo;
using NaroConstants.Names;
using NaroCppCore.Occ.DsgPrs;
using NaroCppCore.Occ.TopAbs;
using ShapeFunctions.Utils;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ShapeFunctions.Constraints.Naro
{
    public class RectangleHeightConstraint : FunctionBase
    {
        public RectangleHeightConstraint()
            : base(FunctionNames.RectangleHeightConstraint)
        {
            // Reference shape that contains the rectangle
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // the value or ranged constraint
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override void PreExecute()
        {
            Dependency[0].ConstraintType = ShapeOperations.RectangleMeasurementConstraint;
        }

        public override bool Execute()
        {
            var rectangleNode = Dependency[0].Reference;
            var recctangleNewRangeValue = Dependency[1].Real;
            TreeUtils.RectangleSetHeight(rectangleNode, recctangleNewRangeValue);

            return BuildDimensionInteractive(rectangleNode);
        }

        private bool BuildDimensionInteractive(Node rectangleNode)
        {
            var textLocation = DimensionUtils.ComputeMiddlePointPosition(rectangleNode, 1).GpPnt;
            const int translate = 10;
            textLocation.X = (textLocation.X + translate);
            textLocation.Y = (textLocation.Y + translate);
            textLocation.Z = (textLocation.Z + translate);
            var shape = ShapeUtils.ExtractSubShape(rectangleNode, 1, TopAbsShapeEnum.TopAbs_EDGE);
            var interactive = DimensionUtils.CreateDependency(shape, textLocation, DsgPrsArrowSide.DsgPrs_AS_BOTHAR);
            if (interactive == null)
            {
                return false;
            }

            Parent.Set<TreeViewVisibilityInterpreter>();
            Interactive = interactive;
            return true;
        }
    }
}