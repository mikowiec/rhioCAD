#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using NaroCppCore.Occ.gp;

using TreeData.NaroData;

#endregion

namespace NaroCAD.SolverModule.Interface.Geometry
{
    public class SolverPlane : GeometricObject
    {
        public SolverPlane(gpPln plane)
        {
            Plane = plane;
            GeometryType = GeometryType.None;
        }

        public SolverPlane(gpPln plane, GeometryType type)
        {
            Plane = plane;
            GeometryType = type;
        }

        public SolverPlane(gpPln plane, GeometryType type, Node Parent)
        {   
            Plane = plane;
            GeometryType = type;
            ParentIndex = Parent.Index;
        }

        public gpPln Plane { get; set; }
        public int ParentIndex { get; private set; }

        public virtual void Preview(Document document)
        {
        }
    }
}