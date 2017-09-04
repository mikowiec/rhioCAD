    #region Usings

using System;
using System.Drawing;
using Naro.Infrastructure.Library.Qos;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAPI;
using NaroCppCore.Occ.gce;
using NaroCppCore.Occ.gp;
using TreeData.AttributeInterpreter;
using log4net;

#endregion

namespace NaroSketchAdapter.Rules.Naro
{
    /// <summary>
    ///   Detects while drawing if the drawn line is parallel with another existing drawing.
    /// </summary>
    public class ParallelLineMatch : RuleBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (ParallelLineMatch));
        private readonly gpDir _oxDir;
        private readonly gpDir _oyDir;
        private readonly gpDir _ozDir;
        private readonly double _precision;

        public ParallelLineMatch(GeometricSolver solver, double precision)
            : base(solver)
        {
            _precision = precision;
            _oxDir = gp.OX.Direction;
            _oyDir = gp.OY.Direction;
            _ozDir = gp.OZ.Direction;
        }

        /// <summary>
        ///   Detects if a set of points is valid for the algorithm
        /// </summary>
        /// <param name = "currentPoint"></param>
        /// <param name = "initialPosition"></param>
        /// <returns></returns>
        private static bool ValidPoints(Point3D currentPoint, Point3D initialPosition)
        {
            return !initialPosition.IsEqual(currentPoint);
        }

        /// <summary>
        ///   Detects paralellism with axis
        /// </summary>
        /// <param name = "currentPoint"></param>
        /// <param name = "initialPosition"></param>
        /// <returns></returns>
        public SolverPreviewObject AxisParallel(Point3D currentPoint, Point3D initialPosition)
        {
            var direction = new gpDir(new gpVec(initialPosition.GpPnt, currentPoint.GpPnt));

            var axisDirection = _oxDir;
            if (axisDirection.IsParallel(direction, _precision))
            {
                var point = GetOtherPoint(initialPosition, currentPoint, axisDirection);
                if (point == null)
                    return null;
                var solverPoint = new SolverEdgeTwoPointsResult(point.Value, initialPosition, Color.Red) { Type = "Parallel X" };
                return solverPoint;
            }
            axisDirection = _oyDir;
            if (axisDirection.IsParallel(direction, _precision))
            {
                //return ProjectPointOnDirection(initialPosition, currentPoint, axisDirection, Color.Green);
                var point = GetOtherPoint(initialPosition, currentPoint, axisDirection);
                if (point == null)
                    return null;
                var solverPoint = new SolverEdgeTwoPointsResult(point.Value, initialPosition, Color.Red) { Type = "Parallel Y" };
                return solverPoint;
            }
            axisDirection = _ozDir;
            if (axisDirection.IsParallel(direction, _precision))
            {
                //return ProjectPointOnDirection(initialPosition, currentPoint, axisDirection, Color.Blue);
                var point = GetOtherPoint(initialPosition, currentPoint, axisDirection);
                if (point == null)
                    return null;
                var solverPoint = new SolverEdgeTwoPointsResult(point.Value, initialPosition, Color.Red) { Type = "Parallel Z" };
                return solverPoint;
            }

            return null;
        }

        private Point3D? GetOtherPoint(Point3D firstLinePoint, Point3D secondLinePoint,
                                                                  gpDir direction)
        {
            // Make a parallel line with this line starting from the initial point
            var parallelLine = new gceMakeLin(firstLinePoint.GpPnt, direction).Value;
            var geomLine = new GeomLine(parallelLine);
            var projectionPoint = new GeomAPIProjectPointOnCurve(secondLinePoint.GpPnt, geomLine);

            if (projectionPoint.NbPoints <= 0)
                return null;
            return new Point3D(projectionPoint.NearestPoint);
        }

        /// <summary>
        ///   Calculates the projection of the second line point on the direction so that the line created from
        ///   [first point, projection] is parallel with direction.
        /// </summary>
        /// <param name = "firstLinePoint"></param>
        /// <param name = "secondLinePoint"></param>
        /// <param name = "direction"></param>
        /// <param name = "color"></param>
        /// <returns></returns>
        public static SolverPreviewObject ProjectPointOnDirection(Point3D firstLinePoint, Point3D secondLinePoint,
                                                                  gpDir direction, Color color)
        {
            // Make a parallel line with this line starting from the initial point
            var parallelLine = new gceMakeLin(firstLinePoint.GpPnt, direction).Value;
            var geomLine = new GeomLine(parallelLine);
            var projectionPoint = new GeomAPIProjectPointOnCurve(secondLinePoint.GpPnt, geomLine);

            if (projectionPoint.NbPoints <= 0)
                return null;
            var firstParallelPoint = new Point3D(projectionPoint.NearestPoint);
            var secondParallelPoint = firstLinePoint;
            var solverPoint = new SolverEdgeTwoPointsResult(firstParallelPoint, secondParallelPoint, color)
                                  {Type = "Parallel Line"};
            return solverPoint;
        }

        /// <summary>
        ///   Detects parallelism with other geometry points
        /// </summary>
        /// <param name = "currentPoint"></param>
        /// <param name = "initialPosition"></param>
        /// <returns></returns>
        public SolverPreviewObject GeometryParallel(Point3D currentPoint, Point3D initialPosition)
        {
            var qosLock = QosFactory.Instance.Get(QosNames.ParallelLineLock);
            qosLock.Begin();

            var vec = new gpVec(initialPosition.GpPnt, currentPoint.GpPnt);
            foreach (var solverGeometricObject in LastGeometry)
            {
                if (solverGeometricObject.ParallelAxis.Count == 0) continue;
                foreach (var axis in solverGeometricObject.ParallelAxis)
                {
                    if (vec.IsParallel(axis.Vector, _precision))
                        return ProjectPointOnDirection(initialPosition, currentPoint, new gpDir(axis.Vector), Color.Black);
                }
            }
            qosLock.End();

            return null;
        }

        /// <summary>
        ///   Tries to find paralelism between groups of points.
        /// </summary>
        /// <param name = "planeOfTheView"></param>
        /// <param name = "currentPoint"></param>
        /// <param name = "initialPosition"></param>
        /// <returns></returns>
        public override SolverPreviewObject InterestingShapeAroundPoint(gpPln planeOfTheView, Point3D currentPoint,
                                                                        Point3D initialPosition)
        {
            if (!ValidPoints(currentPoint, initialPosition))
                return null;

            try
            {
                // Try to find parallelism with the XYZ axis
                //if (initialPosition.GpPnt != new Point3D(0,0,0).GpPnt)
                //{
                var axisParallelPoint = AxisParallel(currentPoint, initialPosition);
                // Try to find parallel with other registered magic points
                return axisParallelPoint ?? GeometryParallel(currentPoint, initialPosition);
            }
            catch (Exception)
            {
                Log.Debug("Exception on extract paralel axis");
            }

            return null;
        }
    }
}