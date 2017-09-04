#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using Naro.Infrastructure.Interface.AppUtils;
using Naro.Infrastructure.Library.Qos;
using NaroCAD.SolverModule.Interface;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAPI;
using NaroCppCore.Occ.GeomAdaptor;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using OccCode;
using TreeData.AttributeInterpreter;
using log4net;
using NaroCppCore.Occ.Extrema;

#endregion

namespace NaroSketchAdapter.Rules.Naro
{
    /// <summary>
    ///   Detects if the point is placed on an edge of a shape
    /// </summary>
    public class EdgeMatch : RuleBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (EdgeMatch));
        private readonly double _precision;

        public EdgeMatch(GeometricSolver solver, double precision) : base(solver)
        {
            _precision = precision;
        }

        public override List<SolverPreviewObject> InterestingShapeAroundPoint(gpPln planeOfTheView, Point3D point)
        {
            var qosLock = QosFactory.Instance.Get(QosNames.EdgeMatchLock);
            qosLock.Begin();
           
            foreach (var edge in Geometry.SelectMany(geometricObject => geometricObject.Edges))
            {
                // Calculate the distance from the point to the curve
                GeomCurve curve;
                var first = 0.0;
                var last = 0.0; 
                unsafe
                {
                    curve = BRepTool.Curve(edge.Edge, ref first, ref last);
                }

                if (curve == null)
                    continue;

                // Add a curve domain protection
                if (first > last)
                    continue;

                ExtremaExtPC extrema = null;
                try
                {
                    var adaptor = new GeomAdaptorCurve(curve, first, last);
                    extrema = new ExtremaExtPC(point.GpPnt, adaptor, Precision.Confusion);
                }
                catch
                {
                    Log.Debug("Exception on generate extrema points");
                }

                if (extrema == null)
                {
                    continue;
                }

                if (!extrema.IsDone) continue;
                if (extrema.NbExt < 1) continue;
                // The point is on edge
                if (extrema.SquareDistance(1) >= CoreGlobalPreferencesSingleton.Instance.ZoomLevel * _precision) continue;
                // Generate a point on the edge by projecting
                var projectionPoint = new GeomAPIProjectPointOnCurve(point.GpPnt, curve);
                if (projectionPoint.NbPoints <= 0) continue;
                List<SolverGeometricObject> selectedEdge = Geometry.Where(geomObj => geomObj.Edges.Contains(edge)).ToList();
                
                //LastGeometry.Clear();
                //LastGeometry.AddRange(selectedEdge);
                var originPoint = new SolverGeometricObject(null);
                originPoint.AddPoint(new SolverDataPoint(new Point3D()));
                var result = GeomUtils.ProjectPointOnPlane(new Point3D().GpPnt, planeOfTheView, Precision.Confusion);
                //if(result == new gpPnt(0,0,0))
                //{
                //    LastGeometry.Add(originPoint);
                //}
                if (selectedEdge.Count > 0 && selectedEdge.First().Edges.Count > 0)
                    return new List<SolverPreviewObject>() { new SolverPointResult(new Point3D(projectionPoint.NearestPoint), selectedEdge.First().Edges.First().ParentIndex) };// {Text = "On Edge"};
                else
                    return new List<SolverPreviewObject>() {new SolverPointResult(new Point3D(projectionPoint.NearestPoint))};
            }
            qosLock.End();
            return new List<SolverPreviewObject>();
          
        }
    }
}