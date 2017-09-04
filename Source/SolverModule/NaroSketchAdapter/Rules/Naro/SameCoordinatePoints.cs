#region Usings

using System;
using System.Collections.Generic;
using System.Drawing;
using Naro.Infrastructure.Interface.AppUtils;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using OccCode;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSketchAdapter.Rules.Naro
{
    public class SameCoordinatePoints  : RuleBase
    {
        private readonly double _precision;

        public SameCoordinatePoints(GeometricSolver solver, double coincidencePrecision)
            : base(solver)
        {
            _precision = coincidencePrecision;
        }

        public override List<SolverPreviewObject> InterestingShapeAroundPoint(gpPln planeOfTheView, Point3D point)
        {
           //var qosLock = QosFactory.Instance.Get(QosNames.SameCoordinateMatchLock);
            var zoom = CoreGlobalPreferencesSingleton.Instance.ZoomLevel*_precision;
            //qosLock.Begin();
            var axis = new gpAx2();
            axis.Axis = (planeOfTheView.Axis);
            var pointOnPlane = GeomUtils.Point3DTo2D(axis, point);
            var solutions = new SortedDictionary<double, SolverEdgeTwoPointsResult>();
            foreach (var geometricObject in LastGeometry)
            {
                foreach (var pnt in geometricObject.Points)
                {
                    var result = GeomUtils.ProjectPointOnPlane(pnt.Point.GpPnt, planeOfTheView, Precision.Confusion);
                    if ( Math.Abs(result.X - pnt.Point.GpPnt.X) > Precision.Confusion || 
                        Math.Abs(result.Y - pnt.Point.GpPnt.Y) > Precision.Confusion ||
                        Math.Abs(result.Z - pnt.Point.GpPnt.Z) > Precision.Confusion) 
                    {
                        continue;
                    }

                    var planePnt = GeomUtils.Point3DTo2D(axis, pnt.Point);
                    var xDistance = Math.Abs(pointOnPlane.X - planePnt.X);
                    var solutionPointOnPlane = new gpPnt2d(pointOnPlane.X, pointOnPlane.Y);
                    var solutionPoint = new Point3D(point.GpPnt);
                   
                    if (xDistance <= zoom)
                    {
                        solutionPointOnPlane.X = (planePnt.X);
                        solutionPoint = new Point3D(GeomUtils.Point2DTo3D(axis, solutionPointOnPlane));
                        solutions[xDistance] = new SolverEdgeTwoPointsResult(solutionPoint, pnt.Point, Color.Blue) {Type = "Same coordinate match"};
                    }
                    else
                    {
                        var yDistance = Math.Abs(pointOnPlane.Y - planePnt.Y);
                        if (yDistance <= zoom)
                        {
                            solutionPointOnPlane.Y = (planePnt.Y);
                            solutionPoint = new Point3D(GeomUtils.Point2DTo3D(axis, solutionPointOnPlane));
                            solutions[yDistance] = new SolverEdgeTwoPointsResult(solutionPoint, pnt.Point, Color.Blue) { Type = "Same coordinate match" };
                        }
                    }
                }
            }
            //qosLock.End();

            if (solutions.Count == 0) return new List<SolverPreviewObject>();
            var SolverPreviewObjects = new List<SolverPreviewObject>();
            foreach (var s in solutions)
                SolverPreviewObjects.Add(s.Value);
            return SolverPreviewObjects;
        }
    }
}
