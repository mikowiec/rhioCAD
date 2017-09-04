#region Usings

using ConstraintsModule;
using ConstraintsModule.Constraints;
using ConstraintsModule.Mappings.Constraints;
using ConstraintsModule.Mappings.Constraints.Common;
using ConstraintsModule.Views;
using NaroConstants.Names;
using NaroSketchAdapter.Mappings.Constraints;
using SketchSolve.Constraints;

#endregion

namespace NaroSketchAdapter
{
    public static class DefaultConstraintsMapping
    {
        public static void SetupDependencies(ConstraintHighLevelDependencyMapping constraintMapper)
        {
            constraintMapper.Register(Constraint2DNames.PointOnPointFunction, "Point On Point",
                                      ResName("perpendicular_constraint.png"), FunctionNames.Point, FunctionNames.Point);

            //constraintMapper.Register(Constraint2DNames.P2PDistanceFunction, "Point To Point Distance",
            //                          ResName("perpendicular_constraint.png"), FunctionNames.Point, FunctionNames.Point);

            constraintMapper.Register(Constraint2DNames.HorizontalFunction, "Horizontal",
                                      ResName("horizontal_constraint.png"), FunctionNames.LineTwoPoints);
            constraintMapper.Register(Constraint2DNames.VerticalFunction, "Vertical", ResName("vertical_constraint.png"),
                                      FunctionNames.LineTwoPoints);

            SetLineToLineConstraints(constraintMapper);

            constraintMapper.Register(Constraint2DNames.PointOnArcFunction, "Arc On Point",
                                      ResName("perpendicular_constraint.png"), FunctionNames.Arc, FunctionNames.Point);

            constraintMapper.Register(Constraint2DNames.PointOnCircleFunction, "Circle On Point",
                                      ResName("perpendicular_constraint.png"), FunctionNames.Circle, FunctionNames.Point);

            constraintMapper.Register(Constraint2DNames.TangentToArcFunction, "Tangent Line On Arc",
                                      ResName("perpendicular_constraint.png"), FunctionNames.Arc,
                                      FunctionNames.LineTwoPoints);

            constraintMapper.Register(Constraint2DNames.TangentToCircleFunction, "Tangent Line On Circle",
                                      ResName("perpendicular_constraint.png"), FunctionNames.Circle,
                                      FunctionNames.LineTwoPoints);

            CircleArcsMethod(constraintMapper);

            constraintMapper.Register(Constraint2DNames.PointOnLineFunction, "Point on Line",
                                      ResName("perpendicular_constraint.png"),
                                      FunctionNames.LineTwoPoints, FunctionNames.Point);
            constraintMapper.Register(Constraint2DNames.PointOnSegmentFunction, "Point on Segment",
                                     ResName("perpendicular_constraint.png"),
                                     FunctionNames.LineTwoPoints, FunctionNames.Point);

            constraintMapper.Register(Constraint2DNames.PointOnLineMidpointFunction, "Point on Middle of Line",
                                      ResName("perpendicular_constraint.png"),
                                      FunctionNames.LineTwoPoints, FunctionNames.Point);
        }

        private static void CircleArcsMethod(ConstraintHighLevelDependencyMapping constraintMapper)
        {
            AddArcOnArcConstraint(constraintMapper, Constraint2DNames.ConcentricArcsFunction, "Concentric Arcs",
                                  "perpendicular_constraint.png");
            AddArcOnArcConstraint(constraintMapper, Constraint2DNames.EqualRadiusArcsFunction, "Equal Radius Arcs",
                                  "perpendicular_constraint.png");

            AddArcOnCircleConstraint(constraintMapper, Constraint2DNames.EqualRadiusCircArcFunction,
                                     "Equal Radius Arc and Circle",
                                     "perpendicular_constraint.png");
            AddArcOnCircleConstraint(constraintMapper, Constraint2DNames.ConcentricCircArcFunction,
                                     "Concentric Arc and Circle",
                                     "perpendicular_constraint.png");

            AddCircleOnCircleConstraint(constraintMapper, Constraint2DNames.ConcentricCirclesFunction,
                                        "Concentric Circles", "perpendicular_constraint.png");
            AddCircleOnCircleConstraint(constraintMapper, Constraint2DNames.EqualRadiusCirclesFunction,
                                        "Equal Radius Circle and Circle",
                                        "perpendicular_constraint.png");
        }

        private static void SetLineToLineConstraints(ConstraintHighLevelDependencyMapping constraintMapper)
        {
            AddLineOnLineConstraint(constraintMapper, Constraint2DNames.ParallelFunction, "Parallel",
                                    "parallel_constraint.png");
            AddLineOnLineConstraint(constraintMapper, Constraint2DNames.PerpendicularFunction, "Perpendicular",
                                    "perpendicular_constraint.png");
            AddLineOnLineConstraint(constraintMapper, Constraint2DNames.ColinearFunction, "Colinear",
                                    "perpendicular_constraint.png");
            AddLineOnLineConstraint(constraintMapper, Constraint2DNames.EqualLengthFunction, "Same Length",
                                    "perpendicular_constraint.png");
        }

        private static void AddLineOnLineConstraint(ConstraintHighLevelDependencyMapping constraintMapper,
                                                    string constraintName, string descriptor, string iconName)
        {
            constraintMapper.Register(constraintName, descriptor, ResName(iconName),
                                      FunctionNames.LineTwoPoints, FunctionNames.LineTwoPoints);
        }

        private static void AddCircleOnCircleConstraint(ConstraintHighLevelDependencyMapping constraintMapper,
                                                        string constraintName, string descriptor, string iconName)
        {
            constraintMapper.Register(constraintName, descriptor, ResName(iconName),
                                      FunctionNames.Circle, FunctionNames.Circle);
        }

        private static void AddArcOnCircleConstraint(ConstraintHighLevelDependencyMapping constraintMapper,
                                                     string constraintName, string descriptor, string iconName)
        {
            constraintMapper.Register(constraintName, descriptor, ResName(iconName),
                                      FunctionNames.Arc, FunctionNames.Circle);
        }

        private static void AddArcOnArcConstraint(ConstraintHighLevelDependencyMapping constraintMapper,
                                                  string constraintName, string descriptor, string iconName)
        {
            constraintMapper.Register(constraintName, descriptor, ResName(iconName),
                                      FunctionNames.Arc, FunctionNames.Arc);
        }

        public static void SetupFunctions(ConstraintMappingList mappingList)
        {
            //Point to Point constraints
            mappingList.Register<PointOnPointConstraintRefMapper>(Constraint2DNames.PointOnPointFunction);

            //Line constraints
            mappingList.Register<OneLineConstraintRefMapper<HorizontalRef>>(Constraint2DNames.HorizontalFunction);
            mappingList.Register<OneLineConstraintRefMapper<VerticalRef>>(Constraint2DNames.VerticalFunction);

            //Line to Line constraints
            mappingList.Register<TwoLinesConstraintRefMapper<ParallelRef>>(Constraint2DNames.ParallelFunction);
            mappingList.Register<TwoLinesConstraintRefMapper<PerpendicularRef>>(Constraint2DNames.PerpendicularFunction);
            mappingList.Register<TwoLinesConstraintRefMapper<ColinearRef>>(Constraint2DNames.ColinearFunction);
            mappingList.Register<TwoLinesConstraintRefMapper<EqualLengthRef>>(Constraint2DNames.EqualLengthFunction);

            mappingList.Register<PointOnArcConstraintRefMapper>(Constraint2DNames.PointOnArcFunction);
            mappingList.Register<PointOnCircleConstraintRefMapper>(Constraint2DNames.PointOnCircleFunction);
            mappingList.Register<PointOnArcMidpointRefMapper>(Constraint2DNames.PointOnArcMidpointFunction);

            mappingList.Register<PointOnLineRefMapper>(Constraint2DNames.PointOnLineFunction);
            mappingList.Register<PointOnSegmentRefMapper>(Constraint2DNames.PointOnSegmentFunction);
            mappingList.Register<PointOnLineMidPointRefMapper>(Constraint2DNames.PointOnLineMidpointFunction);
            //Circle to Line constraints
            mappingList.Register<TangentToCircleRefMapper>(Constraint2DNames.TangentToCircleFunction);

            //Arc to Line constraints
            mappingList.Register<TangentToArcRefMapper>(Constraint2DNames.TangentToArcFunction);

            //Arc to Circle constraints
            mappingList.Register<EqualRadiusCircArcRefMapper>(Constraint2DNames.EqualRadiusCircArcFunction);
            mappingList.Register<ConcentricCirclesArcRefMapper>(Constraint2DNames.ConcentricCircArcFunction);

            //Arc to Arc constraints
            mappingList.Register<TwoArcsConstraintRefMapper<ConcentricArcsRef>>(Constraint2DNames.ConcentricArcsFunction);
            mappingList.Register<TwoArcsConstraintRefMapper<EqualRadiusArcsRef>>(Constraint2DNames.EqualRadiusArcsFunction);

            //Circle to Circle constraints
            mappingList.Register<TwoCirclesConstraintRefMapper<ConcentricCirclesRef>>(
                Constraint2DNames.ConcentricCirclesFunction);
            mappingList.Register<TwoCirclesConstraintRefMapper<EqualRadiusCirclesRef>>(
                Constraint2DNames.EqualRadiusCirclesFunction);

            //Point to value constraints
            mappingList.Register<PositionToCenterConstraintMapper>(Constraint2DNames.PositionToCenterFunction);


            mappingList.Register<CircleRadiusConstraintMapper>(Constraint2DNames.CircleRadiusFunction);
            mappingList.Register<LineLengthConstraintMapper>(Constraint2DNames.LineLengthFunction);
            mappingList.Register<ArcRadiusConstraintMapper>(Constraint2DNames.ArcRadiusFunction);
            mappingList.Register<ArcAnglesConstraintMapper>(Constraint2DNames.ArcAnglesFunction);

            mappingList.Register<PositiveParameterConstraintMapper>(Constraint2DNames.PositiveParameterFunction);
            //mappingList.Register<PointToPointDistanceConstraintRefMapper>(Constraint2DNames.P2PDistanceFunction);
        }

        private static string ResName(string iconName)
        {
            return "/Resources;component/Resources/" + iconName;
        }
    }
}