#region Usings

using NaroCAD.SolverModule.Interface.Geometry;
using NaroCppCore.Occ.BRepBuilderAPI;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSketchAdapter.Factory.ShapeTypes
{
    public class VerticalLineExtracter : SolverGeometryExtracter
    {
        protected override bool Extract(SolverGeometricObject data)
        {
            var builder = Builder;
            var firstPoint = builder[0].TransformedPoint3D.AddCoordinate(new Point3D(0, -1000, 0));
            var secondPoint = firstPoint.AddCoordinate(new Point3D(0, 2000, 0));
            var edge = new BRepBuilderAPIMakeEdge(firstPoint.GpPnt, secondPoint.GpPnt).Edge;
            data.Edges.Add(new SolverEdge(edge));
            return true;
        }
    }
}