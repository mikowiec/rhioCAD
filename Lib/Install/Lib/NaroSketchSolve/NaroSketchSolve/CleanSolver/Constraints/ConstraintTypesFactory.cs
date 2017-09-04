namespace CleanSolver.Constraints
{
    internal class ConstraintFactory
    {
        public static ConstraintBase Create(ConstraintTypes constraint)
        {
            switch (constraint)
            {
                case ConstraintTypes.None:
                    return null;
                case ConstraintTypes.ArcRadius:
                    return new ArcRadius();
                case ConstraintTypes.ArcRules:
                    return new ArcRules();
                case ConstraintTypes.P2LDistance:
                    return new P2LDistance();
                case ConstraintTypes.P2PDistance:
                    return new P2PDistance();
                case ConstraintTypes.P2PDistanceHorz:
                    return new P2PDistanceHorz();
                case ConstraintTypes.P2PDistanceVert:
                    return new P2PDistanceVert();
                case ConstraintTypes.PointOnLine:
                    return new PointOnLine();
                case ConstraintTypes.PointOnPoint:
                    return new PointOnPoint();
                case ConstraintTypes.SymmetricPoints:
                    return new SymmetricPoints();
                case ConstraintTypes.PointOnArc:
                    return new PointOnArc();
                case ConstraintTypes.Horizontal:
                    return new Horizontal();
                case ConstraintTypes.CircleRadius:
                    return new CircleRadius();
                case ConstraintTypes.Vertical:
                    return new Vertical();
                case ConstraintTypes.InternalAngle:
                    return new InternalAngle();
                case ConstraintTypes.ExternalAngle:
                    return new ExternalAngle();
                case ConstraintTypes.TangentToArc:
                    return new TangentToArc();
                case ConstraintTypes.TangentToCircle:
                    return new TangentToCircle();
                case ConstraintTypes.LineLength:
                    return new LineLength();
                case ConstraintTypes.EqualLegnth:
                    return new EqualLegnth();
                case ConstraintTypes.P2LDistanceVert:
                    return new P2LDistanceVert();
                case ConstraintTypes.P2LDistanceHorz:
                    return new P2LDistanceHorz();
                case ConstraintTypes.EqualRadiusArcs:
                    return new EqualRadiusArcs();
                case ConstraintTypes.EqualRadiusCircles:
                    return new EqualRadiusCircles();
                case ConstraintTypes.EqualRadiusCircArc:
                    return new EqualRadiusCircArc();
                case ConstraintTypes.ConcentricArcs:
                    return new ConcentricArcs();
                case ConstraintTypes.ConcentricCircles:
                    return new ConcentricCircles();
                case ConstraintTypes.ConcentricCircArc:
                    return new ConcentricCircArc();
                case ConstraintTypes.Parallel:
                    return new Parallel();
                case ConstraintTypes.Colinear:
                    return new Colinear();
                case ConstraintTypes.Perpendicular:
                    return new Perpendicular();
                case ConstraintTypes.PointOnCircle:
                    return new PointOnCircle();
                case ConstraintTypes.PointOnLineMidpoint:
                    return new PointOnLineMidpoint();
            }
            return null;
        }
    }
}