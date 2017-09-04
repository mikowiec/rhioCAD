//#region Usings

//using Naro.Infrastructure.Library.Algo;
//using NaroConstants.Names;
//using NaroCppCore.Occ.DsgPrs;
//using NaroCppCore.Occ.TopAbs;
//using ShapeFunctions.Utils;
//using ShapeFunctionsInterface.Functions;
//using ShapeFunctionsInterface.Utils;
//using TreeData.AttributeInterpreter;
//using TreeData.NaroData;

//#endregion

//namespace ShapeFunctions.Constraints.Naro
//{
//    public class LineLengthConstraint : FunctionBase
//    {
//        public LineLengthConstraint() : base(FunctionNames.LineLengthConstraint)
//        {
//            // Reference shape that contains the line
//            Dependency.AddAttributeType(InterpreterNames.Reference);
//            // the value or ranged constraint
//            Dependency.AddAttributeType(InterpreterNames.Real);
//        }

//        public override void PreExecute()
//        {
//            Dependency[0].ConstraintType = ShapeOperations.LineLengthConstraint;
//        }

//        public override bool Execute()
//        {
//            var lineNode = Dependency[0].Reference;

//            return ConstraintLineLength(lineNode);
//        }

//        private bool ConstraintLineLength(Node lineNode)
//        {
//            var lineBuilder = new NodeBuilder(lineNode);

//            ApplyConstraint(lineBuilder);

//            return BuildDimensionInteractive(lineNode);
//        }

//        private bool BuildDimensionInteractive(Node rectangleNode)
//        {
//            var textLocation = DimensionUtils.ComputeMiddlePointPosition(rectangleNode, 1).GpPnt;
//            const int translate = 10;
//            textLocation.X = (textLocation.X + translate);
//            textLocation.Y = (textLocation.Y + translate);
//            textLocation.Z = (textLocation.Z + translate);
//            var shape = ShapeUtils.ExtractSubShape(rectangleNode, 1, TopAbsShapeEnum.TopAbs_EDGE);
//            var interactive = DimensionUtils.CreateDependency(shape, textLocation, DsgPrsArrowSide.DsgPrs_AS_BOTHAR);
//            if (interactive == null)
//            {
//                return false;
//            }
//            Parent.Set<TreeViewVisibilityInterpreter>();
//            Interactive = interactive;
//            return true;
//        }

//        private void ApplyConstraint(NodeBuilder circleBuilder)
//        {
//            var lineNewLengthValue = Dependency[1].Real;
//            TreeUtils.SetLineLength(circleBuilder.Node, lineNewLengthValue);
//        }
//    }
//}