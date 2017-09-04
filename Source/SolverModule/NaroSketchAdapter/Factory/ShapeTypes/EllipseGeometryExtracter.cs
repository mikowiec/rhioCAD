#region Usings

using NaroCAD.SolverModule.Factory.ShapeTypes;
using NaroCAD.SolverModule.Interface.Geometry;

#endregion

namespace NaroSketchAdapter.Factory.ShapeTypes
{
    public class EllipseGeometryExtracter : GenericGeometryExtracter
    {
        protected override bool Extract(SolverGeometricObject data)
        {
            data.Points.Add(new SolverDataPoint(data.Builder[0].RefTransformedPoint3D));
            return base.Extract(data);
        }
    }
}