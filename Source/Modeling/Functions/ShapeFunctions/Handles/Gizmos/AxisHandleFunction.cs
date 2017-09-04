#region Usings

using Naro.Infrastructure.Interface.AppUtils;
using NaroConstants.Names;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.BRepAlgoAPI;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;
using OccCode;


#endregion

namespace ShapeFunctions.Handles.Gizmos
{
    public class AxisHandleFunction : HandleBaseFunction
    {
        public AxisHandleFunction() : base(FunctionNames.AxisHandle)
        {
        }

        public override bool Execute()
        {
            var xAxis = Dependency[0].Axis3D.GpAxis;
            var arrowLength = Dependency[2].Real * CoreGlobalPreferencesSingleton.Instance.EditingHandlerZoom;
            var arrowWidth = Dependency[3].Real * CoreGlobalPreferencesSingleton.Instance.EditingHandlerZoom;

            Shape = BuildAxisShapeHandle(xAxis, arrowLength, arrowWidth);

            return true;
        }

        private static TopoDSShape BuildAxisShapeHandle(gpAx1 mainAxis, double arrowLength, double arrowWidth)
        {
            var cylinderShape = GeomUtils.MakeCylinder(mainAxis, arrowWidth, arrowLength * 3/4,
                                                       GeomUtils.DegreesToRadians(360));
            var coneVector = new gpVec(mainAxis.Direction);
            coneVector.Multiply(arrowLength * 3 / 4);
            var coneLocation = mainAxis.Translated(coneVector);
            var cone = GeomUtils.MakeCone(coneLocation, arrowWidth * 1.5, 0, arrowLength / 4,
                                          GeomUtils.DegreesToRadians(360));

            var fuse = new BRepAlgoAPIFuse(cylinderShape, cone);

            return fuse.Shape;
        }
    }
}