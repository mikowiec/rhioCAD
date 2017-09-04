#region Usings

using NaroCAD.SolverModule.Interface.Geometry;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSketchAdapter.Factory.ShapeTypes
{
    public class SplinePathGeometryExtracter : SolverGeometryExtracter
    {
        protected override bool Extract(SolverGeometricObject data)
        {
            if (!ShapeUtils.HasShape(data.Parent))
                return false;
            var pointCount = data.Builder[0].Integer;
            for (var i = 1; i <= pointCount; i++)
                data.Points.Add(new SolverDataPoint(data.Builder[i].TransformedPoint3D));
            return true;
        }
    }
}