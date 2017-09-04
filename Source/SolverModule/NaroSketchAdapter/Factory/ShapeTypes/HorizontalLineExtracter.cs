#region Usings

using NaroCAD.SolverModule.Factory.ShapeTypes;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroCppCore.Occ.BRepBuilderAPI;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroSketchAdapter.Factory.ShapeTypes
{
    public class HorizontalLineExtracter : SolverGeometryExtracter
    {
        #region Overriden methods

        protected override bool Extract(SolverGeometricObject data)
        {
            var builder = Builder;
            var firstPoint = builder[0].TransformedPoint3D.AddCoordinate(new Point3D(-1000, 0, 0));
            var secondPoint = firstPoint.AddCoordinate(new Point3D(2000, 0, 0));
            var edge = new BRepBuilderAPIMakeEdge(firstPoint.GpPnt, secondPoint.GpPnt).Edge;
            data.Edges.Add(new SolverEdge(edge));
            return true;
        }

        #endregion
    }
}