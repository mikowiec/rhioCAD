#region Usings

using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroDataViewer;

#endregion

namespace Naro.Infrastructure.Interface.Constraints
{
    public abstract class ConstraintBaseInterpterer : AttributeInterpreterBase
    {
        #region Protected methods

        protected void SetupPointCoordinate(Point3D coordinate)
        {
            var parent = Parent;
            NodeBuilderUtils.SetupNodePoint(parent, coordinate);
        }

        #endregion
    }
}