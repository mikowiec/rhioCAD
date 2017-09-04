#region Usings

using NaroCAD.SolverModule.Interface.Geometry;
using ShapeFunctions.Constraints.RealSizeLimits;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace NaroSketchAdapter.Factory.SolverLines
{
    public class VerticalLineSolverDataConstraint : SolverDataLineBase
    {
        #region Constructor

        public VerticalLineSolverDataConstraint(Node node)
        {
            Parent = node;
        }

        #endregion

        #region Overriden Methods

        public virtual void SetupNodeConstraint(Node node)
        {
            node.Set<VerticalLineConstraint>().Value = Parent;
        }

        #endregion

        #region Properties

        public double X
        {
            get { return new NodeBuilder(Parent)[0].TransformedPoint3D.X; }
        }

        #endregion

        #region Data members

        #endregion
    }
}