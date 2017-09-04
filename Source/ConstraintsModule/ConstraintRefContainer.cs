using System.Collections.Generic;
using System.Linq;
using ConstraintsModule.Helpers;

namespace ConstraintsModule
{
    public class ConstraintRefContainer
    {
        public readonly List<ConstraintRefBase> _constraintList = new List<ConstraintRefBase>();

        public ConstraintRefBase this[int i]
        {
            get { return _constraintList[i]; }
        }

        public int Size
        {
            get { return _constraintList.Count; }
        }


        public void Add(ConstraintRefBase constraint)
        {
            _constraintList.Add(constraint);
        }

        public void AddRange(IEnumerable<ConstraintRefBase> constraint)
        {
            _constraintList.AddRange(constraint);
        }

        public double Calc(List<double> parameters)
        {
            double result = 0;
            foreach (var constraint in _constraintList)
                result += constraint.Calc(parameters) *constraint.Calc(parameters);
            return result;///2;
        }

        public double Grad(List<double> parameters, int index)
        {
            double result = 0;
            //foreach (var constraint in _constraintList)
            //{
            //    result += 2 * constraint.Grad(parameters, index) *constraint.Calc(parameters);
            //}
            return GetGradient(parameters.ToArray(), index);
           // return result;
        }

        /// <summary>
        /// Use to check the grad values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public double GetGradient(double[] x, int index)
        {
            var xList = x.ToList();
            var grad = 0.0;
            var originalData = xList;
            var pert = 1e-3;
            foreach (var constraint in _constraintList)
            {
                var temper = x[index];
                originalData[index] = temper - pert;
                var first = constraint.Calc(originalData) * constraint.Calc(originalData);///2;
                originalData[index] = temper + pert;
                var second = constraint.Calc(originalData) * constraint.Calc(originalData);///2;
                originalData[index] = temper;
                var gradOld = .5 * (second - first) / pert;
                //var gradNew = 2 * constraint.Grad(x.ToList(), index)*constraint.Calc(x.ToList());
                //var gradNew2 = 2 * constraint.Grad(x.ToList(), index) * constraint.Calc(x.ToList());
                grad += gradOld;

            }
            return grad;
        }
    }
}