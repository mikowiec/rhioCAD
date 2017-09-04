#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using NaroCppCore.Occ.TopoDS;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace NaroCAD.SolverModule.Interface.Geometry
{
    public class SolverEdge : GeometricObject
    {
        public SolverEdge(TopoDSEdge edge)
        {
            Edge = edge;
            GeometryType = GeometryType.None;
        }

        public SolverEdge(TopoDSEdge edge, GeometryType type)
        {
            Edge = edge;
            GeometryType = type;
        }

        public SolverEdge(TopoDSEdge edge, GeometryType type, Node parent)
        {
            Edge = edge;
            GeometryType = type;
            ParentIndex = parent.Index;
        }

        public TopoDSEdge Edge { get; private set; }
        public int ParentIndex { get; private set; }
    }
}