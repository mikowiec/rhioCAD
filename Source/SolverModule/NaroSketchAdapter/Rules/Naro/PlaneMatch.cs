#region Usings

using Naro.Infrastructure.Interface.AppUtils;
using Naro.Infrastructure.Library.Qos;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
//using NaroCAD.SolverModule.Rules;
using NaroConstants.Names;
using NaroCppCore.Occ.Extrema;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAPI;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using TreeData.AttributeInterpreter;
using System.Collections.Generic;
#endregion

namespace NaroSketchAdapter.Rules.Naro
{
    public class PlaneMatch : RuleBase
    {
        private readonly double _precision;

        public PlaneMatch(GeometricSolver solver, double precision) : base(solver)
        {
            _precision = precision;
        }

        public override List<SolverPreviewObject> InterestingShapeAroundPoint(gpPln planeOfTheView, Point3D point)
        {
            var qosLock = QosFactory.Instance.Get(QosNames.PlaneMatchLock);
            qosLock.Begin();

            foreach (var geometricObject in Geometry)
            {
                foreach (var pln in geometricObject.Planes)
                {
                    var distance = pln.Plane.Distance(point.GpPnt);
                    var precision = _precision*CoreGlobalPreferencesSingleton.Instance.ZoomLevel;
                    if (distance >= precision) continue;
                    var plane = new GeomPlane(pln.Plane);

                    var projectionPoint = new GeomAPIProjectPointOnSurf(point.GpPnt, plane, Precision.Confusion, ExtremaExtAlgo.Extrema_ExtAlgo_Grad);
                    if (projectionPoint.NbPoints <= 0) continue;
                    return new List<SolverPreviewObject>(){new SolverPointResult(new Point3D(projectionPoint.NearestPoint), pln.ParentIndex)};
                }
            }
            qosLock.End();

            return new List<SolverPreviewObject>();
        }
    }
}