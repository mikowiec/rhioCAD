using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanSolver.Constraints;
using CleanSolver.Primitives;

namespace CleanSolver.SolverSystem
{
    class SketchDerivative
    {
        public static void derivatives(List<DoubleRefObject> original, List<int> x, List<double> gradF, int xLength, ConstraintContainer cons, int consLength)
        {
            int position;

            for (int i = 0; i < consLength; i++)
            {
                var constraint = cons[i];
                //////////////////////////////////////
                //Point on Point Constraint derivative
                //////////////////////////////////////
                if (constraint is PointOnPoint)
                {
                    // Derivative with respect to p1x
                    position = (int)(constraint.P1.X.Value - x[0]);
                    if (position >= 0 & position < xLength)
                    {
                        gradF[position] += 2 * (constraint.P1.X.Value - constraint.P2.X.Value);
                    }

                    // Derivative with respect to p1y
                    position =(int)(constraint.P1.Y.Value - x[0]);
                    if (position >= 0 & position < xLength)
                    {
                        gradF[position] += 2 * (constraint.P1.Y.Value - constraint.P2.Y.Value);
                    }

                    // Derivative with respect to p2x
                    position = (int)(constraint.P2.X.Value - x[0]);
                    if (position >= 0 & position < xLength)
                    {
                        gradF[position] += -2 * (constraint.P1.X.Value - constraint.P2.X.Value);
                    }

                    // Derivative with respect to p2y
                    position = (int)(constraint.P2.Y.Value - x[0]);
                    if (position >= 0 & position < xLength)
                    {
                        gradF[position] += -2 * (constraint.P1.Y.Value - constraint.P2.Y.Value);
                    }
                }
                //.........................................
                // End Point On Point Constraint derivative
                //.........................................

                //////////////////////////////////////
                //Point to Point Distance Constraint derivative
                //////////////////////////////////////
                if (constraint is P2PDistance)
                {
                    // Derivative with respect to p1x
                    position = (int)(constraint.P1.X.Value - x[0]);
                    if (position >= 0 & position < xLength) 
                        gradF[position] += 2 * (constraint.P1.X.Value - constraint.P2.X.Value);

                    // Derivative with respect to p1y
                    position = (int)(constraint.P1.Y.Value - x[0]);
                    if (position >= 0 & position < xLength) 
                        gradF[position] += 2 * (constraint.P1.Y.Value - constraint.P2.Y.Value);

                    // Derivative with respect to p2x
                    position = (int)(constraint.P2.X.Value - x[0]);
                    if (position >= 0 & position < xLength) 
                        gradF[position] += -2 * (constraint.P1.X.Value - constraint.P2.X.Value);

                    // Derivative with respect to p2y
                    position = (int)(constraint.P2.Y.Value - x[0]);
                    if (position >= 0 & position < xLength)
                        gradF[position] += -2 * (constraint.P1.Y.Value - constraint.P2.Y.Value);

                    // Derivative with respect to distance
                    position = (int)(constraint.Distance - x[0]);
                    if (position >= 0 & position < xLength) gradF[position] += -2 * constraint.Distance;
                }
                //..................................................
                // End Point to Point distance Constraint derivative
                //..................................................

                //////////////////////////////////////
                //Point to Point Distance Vert Constraint derivative
                //////////////////////////////////////
                if (constraint is P2PDistanceVert)
                {

                    // Derivative with respect to p1y
                    position = (int)(constraint.P1.Y.Value - x[0]);
                    if (position >= 0 & position < xLength)
                        gradF[position] += 2 * (constraint.P1.Y.Value - constraint.P2.Y.Value);

                    // Derivative with respect to p2y
                    position = (int)(constraint.P2.Y.Value - x[0]);
                    if (position >= 0 & position < xLength)
                        gradF[position] += -2 * (constraint.P1.Y.Value - constraint.P2.Y.Value);

                    // Derivative with respect to distance
                    position = (int)(constraint.Distance - x[0]);
                    if (position >= 0 & position < xLength) gradF[position] += -2 * constraint.Distance;
                }
                //........................................................
                // End Point to Point Vert distance Constraint derivative
                //........................................................

                //////////////////////////////////////
                //Point to Point Horz Distance Constraint derivative
                //////////////////////////////////////
                if (constraint is P2PDistanceHorz)
                {
                    // Derivative with respect to p1x
                    position = (int)(constraint.P1.X.Value - x[0]);
                    if (position >= 0 & position < xLength) gradF[position] += 2 * (constraint.P1.X.Value - constraint.P2.X.Value);

                    // Derivative with respect to p2x
                    position = (int)(constraint.P2.X.Value - x[0]);
                    if (position >= 0 & position < xLength) gradF[position] += -2 * (constraint.P1.X.Value - constraint.P2.X.Value);

                    // Derivative with respect to distance
                    position = (int)(constraint.Distance - x[0]);
                    if (position >= 0 & position < xLength) gradF[position] += -2 * constraint.Distance;
                }
                //.......................................................
                // End Point to Point Horz distance Constraint derivative
                //.......................................................

                //////////////////////////////////////
                //Point on line Constraint derivatives
                //////////////////////////////////////
                if (constraint is PointOnLine)
                {
                    // Derivative with respect to p1x
                    position = (int)(constraint.P1.X.Value - x[0]);
                    if (position >= 0 & position < xLength) gradF[position] += 2 * (constraint.P1.X.Value - constraint.P2.X.Value);

                    // Derivative with respect to p2x
                    position = (int)(constraint.P2.X.Value - x[0]);
                    if (position >= 0 & position < xLength) gradF[position] += -2 * (constraint.P1.X.Value - constraint.P2.X.Value);

                    // Derivative with respect to distance
                    position = (int)(constraint.Distance - x[0]);
                    if (position >= 0 & position < xLength) gradF[position] += -2 * constraint.Distance;
                }
                //.......................................................
                // End Point to Point Horz distance Constraint derivative
                //.......................................................


            }
        }
    }
}
