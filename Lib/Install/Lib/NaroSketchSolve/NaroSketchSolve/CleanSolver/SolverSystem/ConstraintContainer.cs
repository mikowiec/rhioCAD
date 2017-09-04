#region Usings

using System;
using System.Collections.Generic;
using CleanSolver.Constraints;

#endregion

namespace CleanSolver.SolverSystem
{
    public class ConstraintContainer
    {
        private readonly List<ConstraintBase> _constraintList = new List<ConstraintBase>();


        public void AddConstraint(ConstraintBase constraint)
        {
            _constraintList.Add(constraint);
        }

        public double Calc()
        {
            double result = 0;
            foreach (var constraint in _constraintList)
                result += constraint.Calc();
            return result;
        }

        public ConstraintBase this[int i]
        {
            get { return _constraintList[i]; }
        }
    }
}