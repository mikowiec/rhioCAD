#region Usings

using TreeData.NaroData;

#endregion

namespace Naro.Infrastructure.Interface.GeomHelpers
{
    public enum GeometryType
    {
        None,
        EndPoint,
        MidPoint,
        Edge,
        Face,
        Center,
        Plane,
        Axis,
        Parallel,
        HorizontalLine,
        VerticalLine,
        EdgeIntersection
    }

    public abstract class GeometricObject
    {
        public GeometryType GeometryType { get; set; }

        public Node Parent { get; protected set; }
    }
}