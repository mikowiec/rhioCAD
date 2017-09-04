using System.Collections.Generic;

namespace NaroConstants.Names
{
    public static class Constraint2DNames
    {
        public const string ArcAnglesFunction = "ArcAnglesFunction";
        public const string ArcRadiusFunction = "ArcRadiusFunction";
        public const string ArcRulesFunction = "ArcRulesFunction";
        public const string CircleRadiusFunction = "CircleRadiusFunction";
        public const string ColinearFunction = "ColinearFunction";
        public const string ConcentricArcsFunction = "ConcentricArcsFunction";
        public const string ConcentricCircArcFunction = "ConcentricCircArcFunction";
        public const string ConcentricCirclesFunction = "ConcentricCirclesFunction";
        public const string EqualLengthFunction = "EqualLengthFunction";
        public const string EqualRadiusArcsFunction = "EqualRadiusArcsFunction";
        public const string EqualRadiusCircArcFunction = "EqualRadiusCircArcFunction";
        public const string EqualRadiusCirclesFunction = "EqualRadiusCirclesFunction";
        public const string ExternalAngleFunction = "ExternalAngleFunction";
        public const string HorizontalFunction = "HorizontalFunction";
        public const string InternalAngleFunction = "InternalAngleFunction";
        public const string LineLengthFunction = "LineLengthFunction";
        public const string P2LDistanceFunction = "P2LDistanceFunction";
        public const string P2LDistanceHorzFunction = "P2LDistanceHorzFunction";
        public const string P2LDistanceVertFunction = "P2LDistanceVertFunction";
        public const string P2PDistanceFunction = "P2PDistanceFunction";
        public const string P2PDistanceHorzFunction = "P2PDistanceHorzFunction";
        public const string P2PDistanceVertFunction = "P2PDistanceVertFunction";
        public const string ParallelFunction = "ParallelFunction";
        public const string PerpendicularFunction = "PerpendicularFunction";
        public const string PointOnArcFunction = "PointOnArcFunction";
        public const string PointOnArcMidpointFunction = "PointOnArcMidpointFunction";
        public const string PointOnCircleFunction = "PointOnCircleFunction";
        public const string PointOnCircleQuadFunction = "PointOnCircleQuadFunction";
        public const string PointOnLineFunction = "PointOnLineFunction";
        public const string PointOnSegmentFunction = "PointOnSegmentFunction";
        public const string PointOnLineMidpointFunction = "PointOnLineMidpointFunction";
        public const string PointOnPointFunction = "PointOnPointFunction";
        public const string SymmetricArcsFunction = "SymmetricArcsFunction";
        public const string SymmetricCirclesFunction = "SymmetricCirclesFunction";
        public const string SymmetricLinesFunction = "SymmetricLinesFunction";
        public const string SymmetricPointsFunction = "SymmetricPointsFunction";
        public const string TangentToArcFunction = "TangentToArcFunction";
        public const string TangentToCircleFunction = "TangentToCircleFunction";
        public const string VerticalFunction = "VerticalFunction";

        public const string PositionToCenterFunction = "PositionToCenterFunction";

        public const string PositiveParameterFunction = "PositiveParameterFunction";

        public static IEnumerable<string> GetConstraints()
        {
            yield return ArcAnglesFunction;
            yield return ArcRadiusFunction;
            yield return ArcRulesFunction;
            yield return CircleRadiusFunction;
            yield return ColinearFunction;
            yield return ConcentricArcsFunction;
            yield return ConcentricCircArcFunction;
            yield return ConcentricCirclesFunction;
            yield return EqualLengthFunction;
            yield return EqualRadiusArcsFunction;
            yield return EqualRadiusCircArcFunction;
            yield return EqualRadiusCirclesFunction;
            yield return ExternalAngleFunction;
            yield return HorizontalFunction;
            yield return InternalAngleFunction;
            yield return LineLengthFunction;
            yield return P2LDistanceFunction;
            yield return P2LDistanceHorzFunction;
            yield return P2LDistanceVertFunction;
            yield return P2PDistanceFunction;
            yield return P2PDistanceHorzFunction;
            yield return P2PDistanceVertFunction;
            yield return ParallelFunction;
            yield return PerpendicularFunction;
            yield return PointOnArcFunction;
            yield return PointOnArcMidpointFunction;
            yield return PointOnCircleFunction;
            yield return PointOnCircleQuadFunction;
            yield return PointOnLineFunction;
            yield return PointOnSegmentFunction;
            yield return PointOnLineMidpointFunction;
            yield return PointOnPointFunction;
            yield return SymmetricArcsFunction;
            yield return SymmetricCirclesFunction;
            yield return SymmetricLinesFunction;
            yield return SymmetricPointsFunction;
            yield return TangentToArcFunction;
            yield return TangentToCircleFunction;
            yield return VerticalFunction;
            yield return PositiveParameterFunction;
        }
    }
}