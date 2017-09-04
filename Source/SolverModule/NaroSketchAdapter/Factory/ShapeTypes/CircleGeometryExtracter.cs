#region Usings

using NaroCAD.SolverModule.Interface.Geometry;
using NaroConstants.Names;
using NaroSketchAdapter.Factory.ShapeTypes;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroCAD.SolverModule.Factory.ShapeTypes
{
    public class CircleGeometryExtracter : GenericGeometryExtracter
    {
        protected override bool Extract(SolverGeometricObject data)
        {
            if (data.Builder[0].Name == FunctionNames.Point)
            {
                data.Points.Add(new SolverDataPoint(data.Builder[0].RefTransformedPoint3D));
            }
            if (data.Builder[0].Name == FunctionNames.AxisHandle)
            {
                data.Points.Add(new SolverDataPoint(data.Builder[0].Axis3D.Location));
            }
            return base.Extract(data);
        }
    }
}