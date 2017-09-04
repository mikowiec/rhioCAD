using ConstraintsModule;
using ConstraintsModule.Helpers;

namespace NaroCAD.SolverModule
{
    public class DFPSolver : Sketch2DSolver
    {
        protected override Matrix CalculateUpdate(int freeValuesCount, int xLength, Vector originalData, ConstraintRefContainer cons, Matrix n, Vector grad, Vector deltaX)
        {
            var firstTerm = new Matrix(xLength, xLength);
     
            var gradnew = new Vector(xLength);

            for (var i = 0; i < freeValuesCount; i++)
            {
                gradnew[i] = cons.Grad(originalData, i);
            }

            Vector gamma = gradnew - grad;
            double bottom = deltaX * gamma;

            //make sure that bottom is never 0
            if (bottom < 1e-9) bottom = 1e-9;

            double gammatDotNDotGamma = 0.0;
            for (var i = 0; i < xLength; i++)
            {
                for (var j = 0; j < freeValuesCount; j++)
                {
                    gammatDotNDotGamma += gamma[j] * n[i, j] * gamma[i];
                }
            }

            if (gammatDotNDotGamma < 1e-9) gammatDotNDotGamma = 1e-9;

            var secondTerm = new Matrix(xLength, xLength);

            for (var i = 0; i < freeValuesCount; i++)
            {
                for (var j = 0; j < freeValuesCount; j++)
                {
                    firstTerm[i, j] = (deltaX[i] * deltaX[j]) / bottom;
                    secondTerm[i, j] = n[i, j] * gamma[i] * gamma[j] * n[i, j] * (1 / gammatDotNDotGamma);
                }
            }

            //Now calculate the DFP update on N
            n = n + firstTerm - secondTerm;
            return n;
        }
    }
}
