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
    public class HorizontalLineMatch : RuleBase
    {
        #region Constructor

        private readonly double _range;

        public HorizontalLineMatch(GeometricSolver solver, double range)
            : base(solver)
        {
            _range = range;
        }

        #endregion

        public override List<SolverPreviewObject> InterestingShapeAroundPoint(gpPln planeOfTheView, Point3D point)
        {
            var qosLock = QosFactory.Instance.Get(QosNames.HorizontalLineMatchLock);
            qosLock.Begin();
            foreach (var solverGeometricObject in LastGeometry)
            {
                foreach (HorizontalLineSolverDataConstraint line in solverGeometricObject.HorizontalLines)
                {
                    var range = _range*CoreGlobalPreferencesSingleton.Instance.ZoomLevel;
                    if (Math.Abs(point.Y - line.Y) >= range) continue;
                    point.Y = line.Y;
                    line.Point = point;
                   return new List<SolverPreviewObject>{new SolverPointResult(point) {Text = "Horizontal Match"}};
                }
            }
            qosLock.End();

           return new List<SolverPreviewObject>();
        }
    }
}