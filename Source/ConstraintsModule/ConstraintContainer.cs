#region Usings

using System.Collections.Generic;

//using SketchSolve;

#endregion

namespace ConstraintsModule
{
    public class ConstraintContainer
    {
        private readonly List<ConstraintBase> _constraintList = new List<ConstraintBase>();

        public ConstraintBase this[int i]
        {
            get { return _constraintList[i]; }
        }


        public void Add(ConstraintBase constraint)
        {
            _constraintList.Add(constraint);
        }

        public void AddRange(IEnumerable<ConstraintBase> constraint)
        {
            _constraintList.AddRange(constraint);
        }

        public double Calc()
        {
            double result = 0;
            foreach (var constraint in _constraintList)
                result += constraint.Calc();
            return result;
        }
    }
}