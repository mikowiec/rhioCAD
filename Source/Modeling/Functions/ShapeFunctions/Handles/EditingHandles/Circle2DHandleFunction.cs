#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using OccCode;


#endregion

namespace ShapeFunctions.Handles.EditingHandles
{
    public class Circle2DHandleFunction : HandleBaseFunction
    {
        public Circle2DHandleFunction() : base(FunctionNames.Circle2DHandle)
        {
        }

        public override bool Execute()
        {
            var mainAxis = Dependency[0].Axis3D.GpAxis;
            var radius = Dependency[2].Real;
            Shape = OccShapeCreatorCode.CreateCircle(mainAxis, radius);

            return true;
        }
    }
}