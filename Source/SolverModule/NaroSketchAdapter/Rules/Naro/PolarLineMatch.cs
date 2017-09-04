#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroCppCore.Occ.gp;
using OccCode;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSketchAdapter.Rules.Naro
{
    public class PolarLineMatch : RuleBase
    {
        private readonly List<gpDir> _directions;
        private readonly double _precision;

        public PolarLineMatch(GeometricSolver solver, double getDoubleValue)
            : base(solver)
        {
            _directions = new List<gpDir>();
            for (var angle = 0.0; angle < 359; angle += getDoubleValue)
                _directions.Add(
                    new gpDir(new gpXYZ(Math.Cos(GeomUtils.DegreesToRadians(angle)),
                                              Math.Sin(GeomUtils.DegreesToRadians(angle)), 0)));

            _precision = 5.0/180*Math.PI;
        }

        /// <summary>
        ///   Detects paralellism with axis
        /// </summary>
        /// <param name = "currentPoint"></param>
        /// <param name = "initialPosition"></param>
        /// <returns></returns>
        private SolverPreviewObject AxisParallel(Point3D currentPoint, Point3D initialPosition)
        {
            var direction = new gpDir(new gpVec(initialPosition.GpPnt, currentPoint.GpPnt));

            foreach (var dir in _directions)
            {
                if (dir.IsParallel(direction, _precision))
                    return ParallelLineMatch.ProjectPointOnDirection(initialPosition, currentPoint, dir, Color.Black);
            }
            return null;
        }

        public override SolverPreviewObject InterestingShapeAroundPoint(gpPln planeOfTheView, Point3D currentPoint,
                                                                        Point3D initialPosition)
        {
            if (currentPoint.IsEqual(initialPosition)) return null;
            var result = AxisParallel(currentPoint, initialPosition);
            if (result == null)
                return null;
            result.Text = "";
            return result;
        }
    }
}