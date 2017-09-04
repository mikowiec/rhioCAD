#region Usings

using NaroBasicPipes.Actions;
using NaroCppCore.Occ.gp;
using ShapeFunctionsInterface.Utils;

#endregion

namespace InteractiveEditor.Handlers
{
    public class SplineLegEditingHandler : GenericEditingShapeHandler
    {
        public override gpAx2 GetPointLocation(int index)
        {
            if (index != 0) return base.GetPointLocation(index);
            var prevPoint = new NodeBuilder(Dependency[0].Reference).Dependency[3].TransformedPoint3D;
            var ax2 = new gpAx2();
            var axis = new gpAx1 {Location = (prevPoint.GpPnt)};
            ax2.Axis = (axis);
            return ax2;
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            if (index != 0) base.UpdatePointPosition(index, vertex);
            var prevLeg = new NodeBuilder(Dependency[0].Reference);
            prevLeg.Dependency[3].TransformedPoint3D = vertex.Point;
        }
    }
}