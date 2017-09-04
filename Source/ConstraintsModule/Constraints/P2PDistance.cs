#region Usings

using System.Collections.Generic;

//using CleanSolver.SolverSystem;

#endregion

namespace ConstraintsModule.Constraints
{
    internal class P2PDistance : ConstraintBase
    {
        public override double Calc()
        {
            return (P1.X.Value - P2.X.Value)*(P1.X.Value - P2.X.Value) +
                   (P1.Y.Value - P2.Y.Value)*(P1.Y.Value - P2.Y.Value) - Distance*Distance;
        }
    }

    public class P2PDistanceRef : ConstraintRefBase
    {
        public override double Calc(List<double> parameters)
        {
            return (parameters[P1.X] - parameters[P2.X]) * (parameters[P1.X] - parameters[P2.X]) +
                    (parameters[P1.Y] - parameters[P2.Y]) * (parameters[P1.Y] - parameters[P2.Y]) - Distance * Distance;
        }

        public override double Grad(List<double> parameters, int index)
        {
            return 0;
        }
    }
}