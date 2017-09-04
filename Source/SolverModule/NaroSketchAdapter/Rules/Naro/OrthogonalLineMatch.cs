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

#endregion

namespace NaroSketchAdapter.Rules.Naro
{
    public class OrthogonalLineMatch : RuleBase
    {
        private readonly double _precision;

        public OrthogonalLineMatch(GeometricSolver solver, double precision)
            : base(solver)
        {
            _precision = precision;
        }

        public override SolverPreviewObject InterestingShapeAroundPoint(gpPln planeOfTheView, Point3D currentPoint,
                                                                        Point3D initialPosition)
        {
            if (currentPoint.IsEqual(initialPosition))
                return null;

            var qosLock = QosFactory.Instance.Get(QosNames.ParallelLineLock);
            qosLock.Begin();

            var vec = new gpVec(initialPosition.GpPnt, currentPoint.GpPnt);
            foreach (var solverGeometricObject in Geometry)
            {
                if (solverGeometricObject.ParallelAxis.Count == 0) continue;
                foreach (var axis in solverGeometricObject.ParallelAxis)
                {
                    if (vec.IsNormal(axis.Vector, _precision))
                    {
                        var planeNormal = vec.Crossed(axis.Vector);
                        var planeNormalAxis = new gpAx1(initialPosition.GpPnt, new gpDir(planeNormal));
                        gpVec v2 = axis.Vector.Normalized;
                        v2.Rotate(planeNormalAxis, Math.PI / 2.0);

                        var parallelLine = new gceMakeLin(initialPosition.GpPnt, new gpDir(v2)).Value;
                        var geomLine = new GeomLine(parallelLine);
                        var projectionPoint = new GeomAPIProjectPointOnCurve(currentPoint.GpPnt, geomLine);

                        if (projectionPoint.NbPoints <= 0)
                            return null;
                        var secondPoint = new Point3D(projectionPoint.NearestPoint);
                        var solverPoint = new SolverEdgeTwoPointsResult(secondPoint, initialPosition, Color.Black)
                            { Type = "Perpendicular Line" };
                        return solverPoint;
                    }
                }
            }
            qosLock.End();

            return null;
        }
    }
}