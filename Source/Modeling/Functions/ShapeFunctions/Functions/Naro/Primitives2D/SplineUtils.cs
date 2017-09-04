#region Usings

using System.Collections.Generic;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.TColgp;
using NaroCppCore.Occ.TopoDS;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public static class SplineUtils
    {
        public static TopoDSWire BuildSplineWire(ICollection<Point3D> pointList)
        {
            var array = new TColgpArray1OfPnt(1, pointList.Count); // sizing array
            var index = 1;
            foreach (var point3D in pointList)
            {
                array.SetValue(index, point3D.GpPnt);
                index++;
            }

            var curve = new GeomBezierCurve(array);
            var edge = new BRepBuilderAPIMakeEdge(curve).Edge;
            return new BRepBuilderAPIMakeWire(edge).Wire;
        }
    }
}