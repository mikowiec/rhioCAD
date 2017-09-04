#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using NaroCppCore.Occ.Geom;
using TreeData.NaroData;

#endregion

namespace NaroCAD.SolverModule.Interface.Geometry
{
    public class SolverSurface : GeometricObject
    {
        public SolverSurface(GeomSurface surface)
        {
            Surface = surface;
            GeometryType = GeometryType.None;
        }

        public SolverSurface(GeomSurface surface, GeometryType type)
        {
            Surface = surface;
            GeometryType = type;
        }

        public GeomSurface Surface { get; set; }

        public virtual void Preview(Document document)
        {
        }
    }
}