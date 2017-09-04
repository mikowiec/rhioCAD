#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.DsgPrs;
using NaroCppCore.Occ.TopAbs;
using ShapeFunctions.Utils;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ShapeFunctions.Constraints.Naro.ConstraintsShapes2D
{
    public class CircleRangeConstraint : ConstraintOneRealFunction
    {
        public CircleRangeConstraint()
            : base(FunctionNames.CircleRangeConstraint, 1)
        {
        }

        public override void PreExecute()
        {
            Dependency[0].ConstraintType = ShapeOperations.CircleRadiusConstraint;
        }

        public override bool Execute()
        {
            var circleNode = Dependency[0].ReferenceBuilder;
            return ConstraintCircleRange(circleNode);
        }

        private bool ConstraintCircleRange(NodeBuilder circleNode)
        {
            ApplyConstraint(circleNode);
            return DrawConstraint(circleNode.Node, circleNode);
        }

        private bool DrawConstraint(Node circleNode, NodeBuilder circleBuilder)
        {
            var textLocation = circleBuilder[0].Axis3D.GpAxis.Location.Transformed(circleBuilder.Transformation);
            const int translate = 10;
            textLocation.X = (textLocation.X + circleBuilder[1].Real + translate);
            textLocation.Y = (textLocation.Y + circleBuilder[1].Real + translate);
            var shape = ShapeUtils.ExtractSubShape(circleNode, 1, TopAbsShapeEnum.TopAbs_EDGE);
            var interactive = DimensionUtils.CreateDependency(shape, textLocation, DsgPrsArrowSide.DsgPrs_AS_BOTHAR);
            if (interactive == null)
                return false;

            Parent.Set<TreeViewVisibilityInterpreter>();
            Interactive = interactive;
            return true;
        }
    }
}