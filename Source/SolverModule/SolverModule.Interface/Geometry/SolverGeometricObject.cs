#region Usings

using System.Collections.Generic;
using Naro.Infrastructure.Interface.GeomHelpers;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace NaroCAD.SolverModule.Interface.Geometry
{
    /// <summary>
    ///   Class that describes a geometric entity. Contains descriptions about
    ///   vertexes that it might have, edges and surfaces that it might contain.
    /// </summary>
    public class SolverGeometricObject : GeometricObject
    {
        #region Constructor

        public SolverGeometricObject(Node parent)
        {
            Parent = parent;
            Points = new List<SolverDataPoint>();
            Planes = new List<SolverPlane>();
            Surfaces = new List<SolverSurface>();
            Edges = new List<SolverEdge>();
            HorizontalLines = new List<SolverDataLineBase>();
            VerticalLines = new List<SolverDataLineBase>();
            ParallelAxis = new List<SolverParallelAxis>();
        }

        #endregion

        #region Properties

        public List<SolverDataPoint> Points { get; private set; }
        public List<SolverPlane> Planes { get; private set; }
        public List<SolverSurface> Surfaces { get; private set; }
        public List<SolverEdge> Edges { get; private set; }
        public List<SolverParallelAxis> ParallelAxis { get; private set; }
        public List<SolverDataLineBase> HorizontalLines { get; private set; }
        public List<SolverDataLineBase> VerticalLines { get; private set; }

        public bool IsEmpty
        {
            get
            {
                return Points.Count == 0 &&
                       Planes.Count == 0 &&
                       Surfaces.Count == 0 &&
                       Edges.Count == 0 &&
                       HorizontalLines.Count == 0 &&
                       VerticalLines.Count == 0;
            }
        }

        public NodeBuilder Builder
        {
            get { return new NodeBuilder(Parent); }
        }

        #endregion

        #region Methods

        /// <summary>
        ///   Adds a dataPoint specific information
        /// </summary>
        /// <param name = "dataPoint"></param>
        public void AddPoint(SolverDataPoint dataPoint)
        {
            Points.Add(dataPoint);
        }

        #endregion

        public virtual void Preview(Document document)
        {
            //
        }
    }
}