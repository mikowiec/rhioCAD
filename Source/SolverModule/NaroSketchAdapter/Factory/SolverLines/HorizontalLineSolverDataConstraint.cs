#region Usings

using NaroCAD.SolverModule.Interface.Geometry;
using ShapeFunctions.Constraints.RealSizeLimits;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;

#endregion

namespace NaroSketchAdapter.Factory.SolverLines
{
    public class HorizontalLineSolverDataConstraint : SolverDataLineBase
    {
        #region Constructor

        public HorizontalLineSolverDataConstraint(Node node)
        {
            Parent = node;
        }

        #endregion

        #region Overriden methods

        public virtual void SetupNodeConstraint(Node node)
        {
            node.Set<HorizontalLineConstraint>().Value = Parent;
        }

        #endregion

        #region Properties

        public double Y
        {
            get { return new NodeBuilder(Parent)[0].TransformedPoint3D.Y; }
        }

        #endregion

        #region Data members

        #endregion
    }
}