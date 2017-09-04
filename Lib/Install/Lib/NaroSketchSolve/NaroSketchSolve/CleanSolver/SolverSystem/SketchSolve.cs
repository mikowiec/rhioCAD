using System;
using System.Collections.Generic;
using CleanSolver.Primitives;

namespace CleanSolver.SolverSystem
{
    public static class SketchSolve
    {
        private const int MaxIterations = 50;
        private const double PertMin = 1e-10;
        private const double ValidSolutionFine = 1e-12;
        private const double ValidSoltuionRough = 1e-4;

        private const double XconvergenceRough = 1e-8;
        private const double XconvergenceFine = 1e-10;
        private const double SmallF = 1e-20;
        private const double PertMag = 1e-6;

        static List<T> BuildSizedList<T>(int length) 
        {
            var result = new List<T>();
            for(var i = 0; i<length;i++)result.Add(default(T));
            return result;
        }

        public static int Solve(List<DoubleRefObject> originalData, ConstraintContainer cons, double isFine)
        {
            var xLength = originalData.Count;

            //Save the original parameters for later.
            var origSolution1 = new List<DoubleRefObject>();
            foreach (var element in originalData)
            {
                var auxVal = new DoubleRefObject(element.Value);
                origSolution1.Add(auxVal);
            }

            var convergence = isFine > 0 ? XconvergenceFine : XconvergenceRough;
            //integer to keep track of how many times calc is called
            var ftimes = 0;
            //Calculate Function at the starting point:
            var f0 = cons.Calc();
            if (f0 < SmallF) return 0;
            
            ftimes++;
            //Calculate the gradient at the starting point:

            //Calculate the gradient
            //gradF=x;
            var grad = BuildSizedList<double>(xLength); //The gradient vector (1xn)
            double first, second, temper; //The norm of the gradient vector
            double f1;
            double norm = 0;
            var pert = f0 * PertMag;
            for (var j = 0; j < xLength; j++)
            {
                temper = originalData[j].Value;
                originalData[j].Value = temper - pert;
                first = cons.Calc();
                originalData[j].Value = temper + pert;
                second = cons.Calc();
                grad[j] = .5 * (second - first) / pert;
                ftimes++;

                originalData[j].Value = temper;
                norm = norm + (grad[j] * grad[j]);
            }
            norm = Math.Sqrt(norm);
            //Estimate the norm of N

            //Initialize N and calculate s
            var s = BuildSizedList<double>(xLength); //The current search direction
            var n = BuildSizedList<List<double>>(xLength);
            for (var i = 0; i < xLength; i++)
                n[i] = BuildSizedList<double>(xLength);
            for (var i = 0; i < xLength; i++)
            {
                for (var j = 0; j < xLength; j++)
                {
                    if (i == j)
                    {
                        //N[i][j]=norm; //Calculate a scaled identity matrix as a Hessian inverse estimate
                        //N[i][j]=grad[i]/(norm+.001);
                        n[i][j] = 1;
                        s[i] = -grad[i]; //Calculate the initial search vector

                    }
                    else n[i][j] = 0;
                }
            }
            var fnew = f0 + 1;
            double alpha = 1; //Initial search vector multiplier

            var xold = new List<DoubleRefObject>(); //Storage for the previous design variables
            foreach (var element in originalData)
            {
                var auxValue = new DoubleRefObject(element.Value);
                xold.Add(auxValue);
            }

            ///////////////////////////////////////////////////////
            //  Start of line search
            ///////////////////////////////////////////////////////

            //Make the initial position alpha1
            double alpha1 = 0;
            f1 = f0;

            //Take a step of alpha=1 as alpha2
            double alpha2 = 1;
            for (int i = 0; i < xLength; i++)
            {
                originalData[i].Value = xold[i].Value + alpha2 * s[i];//calculate the new x
            }
            var f2 = cons.Calc();
            ftimes++;

            //Take a step of alpha 3 that is 2*alpha2
            var alpha3 = alpha * 2;
            for (var i = 0; i < xLength; i++)
            {
                originalData[i].Value = xold[i].Value + alpha3 * s[i];//calculate the new x
            }
            var f3 = cons.Calc();
            ftimes++;

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
                    for (var i = 0; i < xLength; i++)
                    {
                        originalData[i].Value = xold[i].Value + alpha2 * s[i];//calculate the new x
                    }
                    f2 = cons.Calc();
                    ftimes++;
                }

                else if (f2 > f3)
                {
                    //If f2 is greater than f3 then we length alpah2 and alpha3 closer to f1
                    //Effectively both are lengthened by a factor of two.
                    alpha2 = alpha3;
                    f2 = f3;
                    alpha3 = alpha3 * 2;
                    for (var i = 0; i < xLength; i++)
                    {
                        originalData[i].Value = xold[i].Value + alpha3 * s[i];//calculate the new x
                    }
                    f3 = cons.Calc();
                    ftimes++;

                }
            }
            // get the alpha for the minimum f of the quadratic approximation
            var alphaStar = alpha2 + ((alpha2 - alpha1) * (f1 - f3)) / (3 * (f1 - 2 * f2 + f3));

            //Guarantee that the new alphaStar is within the bracket
            if (alphaStar > alpha3 || alphaStar < alpha1) alphaStar = alpha2;

            // Set the values to alphaStar
            for (var i = 0; i < xLength; i++)
            {
                originalData[i].Value = xold[i].Value + alphaStar * s[i];//calculate the new x
            }
            fnew = cons.Calc();
            ftimes++;
            var fold = fnew;
           
            /////////////////////////////////////
            // end of line search
            /////////////////////////////////////






            var deltaX = BuildSizedList<double>(xLength);
            var gradnew = BuildSizedList<double>(xLength);
            var gamma = BuildSizedList<double>(xLength);
            var gammatDotN = BuildSizedList<double>(xLength);
            var firstSecond = BuildSizedList<List<double>>(xLength);
            var deltaXDotGammatDotN = BuildSizedList<List<double>>(xLength); ;
            var gammatDotDeltaXt = BuildSizedList<List<double>>(xLength);
            var nDotGammaDotDeltaXt = BuildSizedList<List<double>>(xLength);
            for (var i = 0; i < xLength; i++)
            {
                firstSecond[i] = BuildSizedList<double>(xLength);
                deltaXDotGammatDotN[i] = BuildSizedList<double>(xLength);
                gammatDotDeltaXt[i] = BuildSizedList<double>(xLength);
                nDotGammaDotDeltaXt[i] = BuildSizedList<double>(xLength);
            }
            double deltaXnorm = 1;

            var iterations = 1;

            //Calculate deltaX
            for (var i = 0; i < xLength; i++)
            {
                deltaX[i] = originalData[i].Value - xold[i].Value;//Calculate the difference in x for the Hessian update
            }
            double maxIterNumber = MaxIterations * xLength;
            while (deltaXnorm > convergence && fnew > SmallF && iterations < maxIterNumber)
            {
                /////////////////////////////////////////////////////////////////////
                //Start of main loop!!!!
                /////////////////////////////////////////////////////////////////////
                double bottom = 0;
                double deltaXtDotGamma = 0;
                pert = fnew * PertMag;
                if (pert < PertMin) pert = PertMin;
                for (var i = 0; i < xLength; i++)
                {
                    //Calculate the new gradient vector
                    temper = originalData[i].Value;
                    originalData[i].Value = temper - pert;
                    first = cons.Calc();
                    originalData[i].Value = temper + pert;
                    second = cons.Calc();
                    gradnew[i] = .5 * (second - first) / pert;
                    ftimes++;
                    originalData[i].Value = temper;
                    //Calculate the change in the gradient
                    gamma[i] = gradnew[i] - grad[i];
                    bottom += deltaX[i] * gamma[i];

                    deltaXtDotGamma += deltaX[i] * gamma[i];
                }

                //make sure that bottom is never 0
                if (bottom == 0) bottom = 1e-9;

                //calculate all (1xn).(nxn)

                for (var i = 0; i < xLength; i++)
                {
                    gammatDotN[i] = 0;
                    for (var j = 0; j < xLength; j++)
                        gammatDotN[i] += gamma[j]*n[i][j]; //This is gammatDotN transpose
                }
                //calculate all (1xn).(nx1)

                double gammatDotNDotGamma = 0;
                for (var i = 0; i < xLength; i++)
                    gammatDotNDotGamma += gammatDotN[i]*gamma[i];

                //Calculate the first term

                var firstTerm = 1 + gammatDotNDotGamma / bottom;

                //Calculate all (nx1).(1xn) matrices
                for (var i = 0; i < xLength; i++)
                {
                    for (var j = 0; j < xLength; j++)
                    {
                        firstSecond[i][j] = ((deltaX[j] * deltaX[i]) / bottom) * firstTerm;
                        deltaXDotGammatDotN[i][j] = deltaX[i] * gammatDotN[j];
                        gammatDotDeltaXt[i][j] = gamma[i] * deltaX[j];
                    }
                }

                //Calculate all (nxn).(nxn) matrices

                for (var i = 0; i < xLength; i++)
                    for (var j = 0; j < xLength; j++)
                    {
                        nDotGammaDotDeltaXt[i][j] = 0;
                        for (var k = 0; k < xLength; k++)
                            nDotGammaDotDeltaXt[i][j] += n[i][k]*gammatDotDeltaXt[k][j];
                    }
                //Now calculate the BFGS update on N
                //cout<<"N:"<<endl;
                for (var i = 0; i < xLength; i++)
                    for (var j = 0; j < xLength; j++)
                        n[i][j] = n[i][j] + firstSecond[i][j] -
                                  (deltaXDotGammatDotN[i][j] + nDotGammaDotDeltaXt[i][j])/bottom;

                //Calculate s
                for (var i = 0; i < xLength; i++)
                {
                    s[i] = 0;
                    for (var j = 0; j < xLength; j++)
                        s[i] += -n[i][j]*gradnew[j];
                }

                alpha = 1; //Initial search vector multiplier


                //copy newest values to the xold
                xold.Clear();
                foreach (var element in originalData)
                {
                    var auxValue = new DoubleRefObject(element.Value);
                    xold.Add(auxValue);//Copy last values to xold
                }

                ///////////////////////////////////////////////////////
                //  Start of line search
                ///////////////////////////////////////////////////////

                //Make the initial position alpha1
                alpha1 = 0;
                f1 = fnew;

                //Take a step of alpha=1 as alpha2
                alpha2 = 1;
                for (var i = 0; i < xLength; i++)
                {
                    originalData[i].Value = xold[i].Value + alpha2 * s[i];//calculate the new x
                }
                f2 = cons.Calc(); 
                ftimes++;

                //Take a step of alpha 3 that is 2*alpha2
                alpha3 = alpha2 * 2;
                for (int i = 0; i < xLength; i++)
                {
                    originalData[i].Value = xold[i].Value + alpha3 * s[i];//calculate the new x
                }
                f3 = cons.Calc();
                ftimes++;

                //Now reduce or lengthen alpha2 and alpha3 until the minimum is
                //Bracketed by the triplet f1>f2<f3
                var steps = 0;
                while (f2 > f1 || f2 > f3)
                {
                    if (f2 > f1)
                    {
                        //If f2 is greater than f1 then we shorten alpha2 and alpha3 closer to f1
                        //Effectively both are shortened by a factor of two.
                        alpha3 = alpha2;
                        f3 = f2;
                        alpha2 = alpha2 / 2;
                        for (int i = 0; i < xLength; i++)
                        {
                            originalData[i].Value = xold[i].Value + alpha2 * s[i];//calculate the new x
                        }
                        f2 = cons.Calc();
                        ftimes++;
                    }

                    else if (f2 > f3)
                    {
                        //If f2 is greater than f3 then we length alpah2 and alpha3 closer to f1
                        //Effectively both are lengthened by a factor of two.
                        alpha2 = alpha3;
                        f2 = f3;
                        alpha3 = alpha3 * 2;
                        for (int i = 0; i < xLength; i++)
                        {
                            originalData[i].Value = xold[i].Value + alpha3 * s[i];//calculate the new x
                        }
                        f3 = cons.Calc();
                        ftimes++;
                    }
                    steps = steps + 1;
                }

                // get the alpha for the minimum f of the quadratic approximation
                alphaStar = alpha2 + ((alpha2 - alpha1) * (f1 - f3)) / (3 * (f1 - 2 * f2 + f3));


                //Guarantee that the new alphaStar is within the bracket
                if (alphaStar >= alpha3 || alphaStar <= alpha1)
                    alphaStar = alpha2;

                // Set the values to alphaStar
                for (var i = 0; i < xLength; i++)
                {
                    originalData[i].Value = xold[i].Value + alphaStar * s[i];//calculate the new x
                }
                fnew = cons.Calc();
                ftimes++;


                /////////////////////////////////////
                // end of line search
                ////////////////////////////////////

                deltaXnorm = 0;
                for (int i = 0; i < xLength; i++)
                {
                    deltaX[i] = originalData[i].Value - xold[i].Value;//Calculate the difference in x for the hessian update
                    deltaXnorm += deltaX[i] * deltaX[i];
                    grad[i] = gradnew[i];
                }
                deltaXnorm = Math.Sqrt(deltaXnorm);
                iterations++;
                /////////////////////////////////////////////////////////////
                // End of Main loop
                /////////////////////////////////////////////////////////////
            }

            // End of function
            double validSolution;
            if (isFine == 1) validSolution = ValidSolutionFine;
            else validSolution = ValidSoltuionRough;
            if (fnew < validSolution)
                return 0;
            //Replace the bad numbers with the last result
            for (var i = 0; i < xLength; i++)
            {
                originalData[i] = origSolution1[i];
            }
            return 1;
            
        }
    }
}
