#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;
using OccCode;

using TreeData.AttributeInterpreter;

#endregion

namespace NaroCAD.SolverModule.Interface.Geometry
{
    public class SolverParallelAxis : GeometricObject
    {
        public SolverParallelAxis(TopoDSEdge edge)
        {
            Point3D? firstPoint, lastPoint;
            GeomUtils.EdgeRange(edge, out firstPoint, out lastPoint);
            if (firstPoint == null || lastPoint == null) return;
            var first = (Point3D) firstPoint;
            var last = (Point3D) lastPoint;
            Vector = new gpVec(first.GpPnt, last.GpPnt);
        }

        public gpVec Vector { get; private set; }

        public bool IsParallel(gpVec axis, double anglePrecision)
        {
            return Vector.IsParallel(axis, anglePrecision);
        }
    }
}