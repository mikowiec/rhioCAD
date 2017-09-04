#region Usings

using System;
using System.Linq;
using Naro.Infrastructure.Library.Qos;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
//using NaroCAD.SolverModule.Rules;
using NaroConstants.Names;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.Extrema;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAPI;
using NaroCppCore.Occ.GeomAdaptor;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using TreeData.AttributeInterpreter;
using log4net;
using System.Collections.Generic;
#endregion

namespace NaroSketchAdapter.Rules.Naro
{
    public class EdgeContinuationMatch : RuleBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (EdgeContinuationMatch));
        private readonly double _precision;

        public EdgeContinuationMatch(GeometricSolver solver, double precision) : base(solver)
        {
            _precision = precision;
        }

        /// <summary>
        ///   Detects if the point is on the curve that describes the edge.
        /// </summary>
        /// <param name = "planeOfTheView"></param>
        /// <param name = "point"></param>
        /// <returns></returns>
        public override List<SolverPreviewObject> InterestingShapeAroundPoint(gpPln planeOfTheView, Point3D point)
        {
            var qosLock = QosFactory.Instance.Get(QosNames.EdgeContinuationMatchLock);
            qosLock.Begin();
            foreach (var edge in LastGeometry.SelectMany(geometricObject => geometricObject.Edges))
            {
                // Calculate the distance from the point to the curve
                GeomCurve curve;
                double first = 0;
                double last = 0;
              //  unsafe
                {
                    curve = BRepTool.Curve(edge.Edge, ref first, ref last);
                }

                if (curve == null)
                    continue;

                ExtremaExtPC extrema = null;

                try
                {
                    var adaptor = new GeomAdaptorCurve(curve);
                    extrema = new ExtremaExtPC(point.GpPnt, adaptor, Precision.Confusion);
                }
                catch (Exception)
                {
                    Log.Debug("Exception on extract paralel axis");
                }

                if (extrema == null)
                    continue;

                if (!extrema.IsDone) continue;
                if (extrema.NbExt < 1) continue;
                // The point is on edge
                if (extrema.SquareDistance(1) >= _precision) continue;
                // Generate a point on the edge by projecting
                var projectionPoint = new GeomAPIProjectPointOnCurve(point.GpPnt, curve);
                if (projectionPoint.NbPoints <= 0) continue;
                var lastPoint = curve.Value(last);
               return new List<SolverPreviewObject>(){new SolverEdgeTwoPointsResult(new Point3D(projectionPoint.NearestPoint), new Point3D(lastPoint))
                    {Type = "Line Continuation"}};
            }
            qosLock.End();
            return new List<SolverPreviewObject>();
        }
    }
}