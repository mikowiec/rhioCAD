#region Usings

using System;
using System.Collections.Generic;
using ConstraintsModule;
using ConstraintsModule.Helpers;
using ConstraintsModule.Primitives;
//using CleanSolver.SolverSystem;

//using SketchSolve.Primitives;

#endregion

namespace NaroCAD.SolverModule
{
    public abstract class Sketch2DSolver
    {
        private const int MaxIterations = 50;
        private const double ValidSolutionFine = 1e-12;
        private const double ValidSoltuionRough = 1e-4;

        private const double XconvergenceRough = 1e-8;
        private const double XconvergenceFine = 1e-10;
        private const double SmallF = 1e-20;

        public int SolveRef(ref Vector originalData, int freeValuesCount, ConstraintRefContainer cons, double isFine)
        {
            var xLength = originalData.Count;

            //Save the original parameters for later.
            var origSolution1 = new Vector(originalData);

            var convergence = isFine > 0.1 ? XconvergenceFine : XconvergenceRough;
            //Calculate Function at the starting point:
            var f0 = cons.Calc(originalData);

            if (f0 < SmallF) return 0;

            //Calculate the gradient at the starting point:

            var grad = new Vector(xLength); //The gradient vector (1xn)
            for (var j = 0; j < freeValuesCount; j++)
            {
                grad[j] = cons.Grad(originalData, j);
            }

            //Initialize N and calculate s
            var n = Matrix.Identity(xLength, xLength);
          
            var s = -grad;
            var fnew = f0 + 1;

            var xold = new Vector(originalData); //Storage for the previous design variables

            /////////////////////////////////////////////////////////
            ////  Calculate first step
            /////////////////////////////////////////////////////////

            //Make the initial position alpha1
            double alpha1 = 0;

            ////Take a step of alpha=1 as alpha2
            double alpha2 = 1;
        
            double f1 = fnew;
            var alphaStar = LineSearch(cons, xold, s, f1, alpha2, alpha1);
           
             originalData = xold + alphaStar * s;

            fnew = cons.Calc(originalData);

            /////////////////////////////////////
            // end of first step
            /////////////////////////////////////

            var deltaX = new Vector(xLength);
            var gradnew = new Vector(xLength);

            double deltaXnorm = 1;

            var iterations = 1;

            deltaX = originalData - xold;
            while (deltaXnorm > convergence && fnew > SmallF && iterations < MaxIterations*xold.Count)
            {
                
                n = CalculateUpdate(freeValuesCount, xLength, originalData, cons, n, grad, deltaX);
                ////// line search + next steps /////
                for (var i = 0; i < freeValuesCount; i++)
                {
                    gradnew[i] = cons.Grad(originalData, i);
                }
                s = n*(-gradnew);

                //copy newest values to the xold
                xold = originalData;
                f1 = fnew;
                alphaStar = LineSearch(cons, xold, s, f1, alpha2, alpha1);
              
                originalData = xold + alphaStar * s;
                fnew = cons.Calc(originalData);
           
                deltaX = originalData - xold;
                grad = new Vector(gradnew);
                deltaXnorm = deltaX.Norm();
                iterations++;
            }
      
            // End of function
            double validSolution = isFine < 0.1 ? ValidSolutionFine : ValidSoltuionRough;
            if (fnew < validSolution) 
                return 0;
      
            originalData = origSolution1;
            return 1;
        }

        protected virtual Matrix CalculateUpdate(int freeValuesCount, int xLength, Vector originalData, ConstraintRefContainer cons, Matrix n, Vector grad, Vector deltaX)
        {
            return n;
        }

        private static double LineSearch(ConstraintRefContainer cons, Vector xold, Vector s, double f1, double alpha2, double alpha1)
        {
         //  //Take a step of alpha=1 as alpha2
            var originalData = xold + alpha2*s;
            var f2 = cons.Calc(originalData);

            //  //Take a step of alpha 3 that is 2*alpha2
            var alpha3 = alpha2 * 2;
         
            originalData = xold + alpha3*s;
            var f3 = cons.Calc(originalData);

            //Now reduce or lengthen alpha2 and alpha3 until the minimum is
            //Bracketed by the triplet f1>f2<f3
            while (f2 > f1 || f2 > f3)
            {
                if (f2 > f1)
                {
                    //If f2 is greater than f1 then we shorten alpha2 and alpha3 closer to f1
                    //Effectively both are shortened by a factor of two.
                    alpha3 = alpha2;
                    f3 = f2;
                    alpha2 = alpha2 / 2;
                   
                    originalData = xold + alpha2*s;
                    f2 = cons.Calc(originalData);
                }

                else if (f2 > f3)
                {
                    //If f2 is greater than f3 then we length alpah2 and alpha3 closer to f1
                    //Effectively both are lengthened by a factor of two.
                    alpha2 = alpha3;
                    f2 = f3;
                    alpha3 = alpha3 * 2;
                
                    originalData = xold + alpha3*s;
                    f3 = cons.Calc(originalData);
                }
            }

            // get the alpha for the minimum f of the quadratic approximation
            var denominator = f1 - 2*f2 + f3;
            denominator = denominator < 1e-13 ? 1e-13 : denominator;
            var alphaStar = alpha2 + ((alpha2 - alpha1) * (f1 - f3)) / (3 * denominator);

            //Guarantee that the new alphaStar is within the bracket
            if (alphaStar > alpha3 || alphaStar < alpha1)
                alphaStar = alpha2;
            return alphaStar;
        }
    }
}