#region Usings

using System.Collections.Generic;
using Naro.Infrastructure.Interface.AppUtils;
using Naro.Infrastructure.Library.Qos;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSketchAdapter.Rules.Naro
{
    public class PointMatch : RuleBase
    {
        private readonly double _precision;

        public PointMatch(GeometricSolver solver, double coincidencePrecision)
            : base(solver)
        {
            _precision = coincidencePrecision;
        }

        public override List<SolverPreviewObject> InterestingShapeAroundPoint(gpPln planeOfTheView, Point3D point)
        {
            var normalOnViewPlane = planeOfTheView.Position.Direction;
            var normalLine = new gpLin(point.GpPnt, normalOnViewPlane);

            var qosLock = QosFactory.Instance.Get(QosNames.PointMatchLock);
            var zoom = CoreGlobalPreferencesSingleton.Instance.ZoomLevel*_precision;
            qosLock.Begin();
            var solutions = new SortedDictionary<double, SolverPointResult>();
            foreach (var geometricObject in LastGeometry)
            {
                // Test if the object contains any magic point
                foreach (var pnt in geometricObject.Points)
                {
                    var distance = normalLine.Distance(pnt.Point.GpPnt);
                    if (distance >= zoom) continue;
                    solutions[distance] = new SolverPointResult(pnt.Point, pnt.GeometryType) {Text = "Point match"};
                }
            }
            qosLock.End();
            if (solutions.Count == 0) return new List<SolverPreviewObject>();
            var SolverPreviewObjects = new List<SolverPreviewObject>();
            foreach (var s in solutions)
                SolverPreviewObjects.Add(s.Value);
            return SolverPreviewObjects;
        }
    }
}