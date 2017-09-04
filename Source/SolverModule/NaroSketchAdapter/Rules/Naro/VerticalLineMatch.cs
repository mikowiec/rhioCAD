#region Usings

using System;
using Naro.Infrastructure.Interface.AppUtils;
using Naro.Infrastructure.Library.Qos;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroSketchAdapter.Factory.SolverLines;
using TreeData.AttributeInterpreter;
using System.Collections.Generic;
#endregion

namespace NaroSketchAdapter.Rules.Naro
{
    public class VerticalLineMatch : RuleBase
    {
        private readonly double _range = 3;

        public VerticalLineMatch(GeometricSolver solver, double range) : base(solver)
        {
            _range = range;
        }

        public override List<SolverPreviewObject> InterestingShapeAroundPoint(gpPln planeOfTheView, Point3D point)
        {
            var qosLock = QosFactory.Instance.Get(QosNames.VerticalLineMatchLock);
            qosLock.Begin();
            foreach (var solverGeometricObject in Geometry)
            {
                foreach (VerticalLineSolverDataConstraint line in solverGeometricObject.VerticalLines)
                {
                    var range = _range*CoreGlobalPreferencesSingleton.Instance.ZoomLevel;
                    if (Math.Abs(point.X - line.X) >= range) continue;
                    point.X = line.X;
                    line.Point = point;
                    return new List<SolverPreviewObject> {new SolverPointResult(point) {Text = "On Vertical Line"}};
                }
            }
            qosLock.End();
            return new List<SolverPreviewObject>();
        }
    }
}