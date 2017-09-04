#region Usings

using ConstraintsModule.ConstraintFunctions;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroSketchAdapter.ConstraintFunctions;
using ShapeFunctionsInterface.Functions;

#endregion

namespace NaroSketchAdapter.Common
{
    public class DefaultConstraintFunctions
    {
        private IFunctionFactory _functionFactory;

        public void Setup(ActionsGraph actionsGraph)
        {
            _functionFactory =
                actionsGraph[InputNames.FunctionFactoryInput].GetData(NotificationNames.GetValue).Get<IFunctionFactory>();

            MapFunctions();
        }

        private void MapFunctions()
        {
            _functionFactory.Register<ArcRadiusFunction>();
            _functionFactory.Register<ArcAnglesFunction>();
            _functionFactory.Register<ArcRulesFunction>();
            _functionFactory.Register<CircleRadiusFunction>();
            TwoShapesConstraint(Constraint2DNames.ColinearFunction);
            TwoShapesConstraint(Constraint2DNames.ConcentricArcsFunction);
            TwoShapesConstraint(Constraint2DNames.ConcentricCircArcFunction);
            TwoShapesConstraint(Constraint2DNames.ConcentricCirclesFunction);
            TwoShapesConstraint(Constraint2DNames.EqualLengthFunction);
            TwoShapesConstraint(Constraint2DNames.EqualRadiusArcsFunction);
            TwoShapesConstraint(Constraint2DNames.EqualRadiusCircArcFunction);
            TwoShapesConstraint(Constraint2DNames.EqualRadiusCirclesFunction);

            _functionFactory.Register<ExternalAngleFunction>();
            OneShapesConstraint(Constraint2DNames.HorizontalFunction);
            _functionFactory.Register<InternalAngleFunction>();
            _functionFactory.Register<LineLengthFunction>();
            //_functionFactory.Register<CircleRadiusFunction>();
            _functionFactory.Register<P2LDistanceFunction>();
            _functionFactory.Register<P2LDistanceHorzFunction>();
            _functionFactory.Register<P2LDistanceVertFunction>();
            _functionFactory.Register<P2PDistanceFunction>();
            _functionFactory.Register<P2PDistanceHorzFunction>();
            _functionFactory.Register<P2PDistanceVertFunction>();
            TwoShapesConstraint(Constraint2DNames.ParallelFunction);
            TwoShapesConstraint(Constraint2DNames.PerpendicularFunction);
            TwoShapesConstraint(Constraint2DNames.PointOnArcFunction);
            TwoShapesConstraint(Constraint2DNames.PointOnArcMidpointFunction);
          //  TwoShapesConstraint(Constraint2DNames.PointOnArcMidpointFunction);
            TwoShapesConstraint(Constraint2DNames.PointOnCircleFunction);
            TwoShapesConstraint(Constraint2DNames.PointOnLineFunction);
            TwoShapesConstraint(Constraint2DNames.PointOnSegmentFunction);
            TwoShapesConstraint(Constraint2DNames.PointOnLineMidpointFunction);
            TwoShapesConstraint(Constraint2DNames.PointOnPointFunction);
            _functionFactory.Register<SymmetricPointsFunction>();

            _functionFactory.Register<PositionToCenterFunction>();

            TwoShapesConstraint(Constraint2DNames.TangentToArcFunction);
            TwoShapesConstraint(Constraint2DNames.TangentToCircleFunction);
            OneShapesConstraint(Constraint2DNames.VerticalFunction);
            OneShapesConstraint(Constraint2DNames.PositiveParameterFunction);
        }

        private void TwoShapesConstraint(string functionName)
        {
            var creator = new TwoShapesConstraintFunctionCreator(functionName);
            _functionFactory.RegisterCustomCreator(creator, functionName);
        }

        private void OneShapesConstraint(string functionName)
        {
            var creator = new OneShapesConstraintFunctionCreator(functionName);
            _functionFactory.RegisterCustomCreator(creator, functionName);
        }
    }
}