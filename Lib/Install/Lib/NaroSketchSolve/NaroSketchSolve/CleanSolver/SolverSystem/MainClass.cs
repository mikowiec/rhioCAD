using System;
using System.Collections.Generic;
using CleanSolver.Constraints;
using CleanSolver.Primitives;

namespace CleanSolver.SolverSystem
{
    class MainClass
    {
        private List<DoubleRefObject> parameters = new List<DoubleRefObject>()
                            {
                            new DoubleRefObject(0), new DoubleRefObject(0),
                            new DoubleRefObject(5), new DoubleRefObject(0),
                            new DoubleRefObject(6), new DoubleRefObject(5),
                            new DoubleRefObject(6), new DoubleRefObject(5)
                            };
        private double[] constants = new double[100];
        private List<DoubleRefObject> P;
        private double[] C;

        List<Point> points = new List<Point>();
        Line[] lines = new Line[100];

        Circle[] circles = new Circle[100];
        Arc[] arcs = new Arc[100];

        private const double Rough = 0;

        public static void Main()
        {
            var solverCore = new MainClass();
            solverCore.Run();
        }
        public void Run()
        {
            P = parameters;

            Point origin;


            constants[0] = 6;
            constants[1] = 6;
            constants[2] = 2;
            constants[3] = Math.PI / 3;
            constants[4] = 3;

            points.Add(new Point(parameters[0], parameters[1]));
            points.Add(new Point(parameters[2], parameters[3]));
            points.Add(new Point(parameters[4], parameters[5]));
            points.Add(new Point(parameters[6], parameters[7]));
            points.Add(new Point(new DoubleRefObject(constants[0]), new DoubleRefObject(constants[1])));

            lines[0].P1 = points[0];
            lines[0].P2 = points[1];
            lines[1].P1 = points[1];
            lines[1].P2 = points[2];

            var constraitns = new ConstraintContainer();
            constraitns.AddConstraint(new Horizontal()
            {
                L1 = lines[0]
            });
            constraitns.AddConstraint(new Vertical()
            {
                L1 = lines[1]
            });
            constraitns.AddConstraint(new PointOnPoint()
            {
                P1 = points[2],
                P2 = points[4]
            });

            constraitns.AddConstraint(new PointOnPoint()
            {
                P1 = points[3],
                P2 = points[4]
            });


            for (int i = 0; i < 1; i++)
            {
                parameters[0].Value = 0;//1x
                parameters[1].Value = 0;//y
                parameters[2].Value = 5;//x
                parameters[3].Value = 0;//y
                parameters[4].Value = 6;//xstart
                parameters[5].Value = 5;//y

                parameters[6].Value = 6;//xend
                parameters[7].Value = 5;//y


                var pparameters = new List<int>();

                for (var index = 0; index < 100; index++)
                {
                    pparameters.Add(index);
                }

                var sol = SketchSolve.Solve(parameters, constraitns, Rough);
                switch (sol)
                {
                    case 0:
                        Console.WriteLine("A good Solution was found");
                        break;
                    case 1:
                        Console.WriteLine("No valid Solutions were found from this start point");
                        break;
                }
                DisplayPoints();
                var hey = parameters[0].Value * parameters[2].Value + parameters[1].Value * parameters[3].Value;
                Console.WriteLine("dot product: " + hey);

                var gradF = new List<double>();
                List<int> ggradF = new List<int>();

                for (int index = 0; index < 20; index++)
                {
                    gradF.Add(0);
                    ggradF.Add(index);
                }

                SketchDerivative.derivatives(parameters, pparameters, gradF, 4, constraitns, 3);

                for (var index = 0; index < 4; index++)
                {
                    Console.WriteLine("GradF[" + index + "]: " + gradF[ggradF[index]]);
                }
            }


        }

        private void DisplayPoints()
        {
            for (var i = 0; i < 8; i++)
            {
                Console.WriteLine("Point" + parameters[i].Value);
            }
        }
    }
}
