using ConstraintsModule;
using ConstraintsModule.Helpers;

namespace NaroCAD.SolverModule
{
   public class BFGSSolver : Sketch2DSolver
   {
       protected override Matrix CalculateUpdate(int freeValuesCount, int xLength, Vector originalData, ConstraintRefContainer cons, Matrix n, Vector grad, Vector deltaX)
       {
           var gammatDotN = new Vector(xLength);
           var firstSecond = new Matrix(xLength, xLength);
           var deltaXDotGammatDotN = new Matrix(xLength, xLength);

           var gammatDotDeltaXt = new Matrix(xLength, xLength);
           var gradnew = new Vector(xLength);

           for (var i = 0; i < freeValuesCount; i++)
           {
               gradnew[i] = cons.Grad(originalData, i);
           }

           Vector gamma = gradnew - grad;
           double bottom = deltaX * gamma;

           //make sure that bottom is never 0
           if (bottom < 1e-9) bottom = 1e-9;

           for (var i = 0; i < xLength; i++)
           {
               gammatDotN[i] = 0;
               for (var j = 0; j < freeValuesCount; j++)
                   gammatDotN[i] += gamma[j] * n[i, j];
           }

           double gammatDotNDotGamma = gammatDotN * gamma;

           var firstTerm = 1 + gammatDotNDotGamma / bottom;

           for (var i = 0; i < freeValuesCount; i++)
           {
               for (var j = 0; j < freeValuesCount; j++)
               {
                   firstSecond[i, j] = ((deltaX[j] * deltaX[i]) / bottom) * firstTerm;
                   deltaXDotGammatDotN[i, j] = deltaX[i] * gammatDotN[j];
                   gammatDotDeltaXt[i, j] = gamma[i] * deltaX[j];
               }
           }

           Matrix nDotGammaDotDeltaXt = n * gammatDotDeltaXt;

           //Now calculate the BFGS update on N
           n = n + firstSecond - (deltaXDotGammatDotN + nDotGammaDotDeltaXt) * (1 / bottom);
           return n;
       }
   }
}
