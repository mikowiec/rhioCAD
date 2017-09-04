#region Usings

using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using ShapeFunctionsInterface.Utils;

#endregion

namespace InteractiveEditor.Handlers
{
    public class Arc3PEditingHandler : GenericEditingShapeHandler
    {
        public override int EditingPointsCount()
        {
            return 3;
        }

        public override string GetHandleTypeAtIndex(int index)
        {
            return FunctionNames.BoxEditingHandle;
        }

        public override gpAx2 GetPointLocation(int index)
        {
            var ax2 = new gpAx2();
            var axis = new gpAx1();
            var point = new gpPnt();
            var transform = NodeBuilderUtils.GetGlobalTransformation(new NodeBuilder(NodeBuilderUtils.FindSketchNode(Node)));
            point = Dependency[0].Name == InterpreterNames.Reference ? Dependency[index].RefTransformedPoint3D.GpPnt : Dependency[index].TransformedPoint3D.GpPnt;
            axis.Location = (point);
            axis.Direction = axis.Direction.Transformed(transform);
            ax2.Axis = (axis);
            return ax2;
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            if (index == 0)
            {
                var secondPoint = Dependency[1].RefTransformedPoint3D;
                var thirdPoint = Dependency[2].RefTransformedPoint3D;
                Dependency[0].RefTransformedPoint3D = vertex.Point;
                Dependency[1].RefTransformedPoint3D = secondPoint;
                Dependency[2].RefTransformedPoint3D = thirdPoint;
            }
            else
            {
                Dependency[index].RefTransformedPoint3D = vertex.Point;
            }
        }
    }
}