#region Usings

using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace InteractiveEditor.Handlers
{
    public class ArcEditingHandler : GenericEditingShapeHandler
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
            if (index < 0 || index > 2)
                return null;
            var ax2 = new gpAx2();
            var transform = NodeBuilderUtils.GetGlobalTransformation(new NodeBuilder(NodeBuilderUtils.FindSketchNode(Node)));
            var arcLocation = Dependency[index].RefTransformedPoint3D.GpPnt;
            var pointBuilder = Dependency[0].ReferenceBuilder;
            var arcNormal = pointBuilder[0].Reference.Children[1].Get<Axis3DInterpreter>().Axis.Direction;
            ax2.Axis = new gpAx1(arcLocation, new gpDir(arcNormal.GpPnt.XYZ).Transformed(transform));

            return ax2;
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            var transform = NodeBuilderUtils.GetGlobalTransformation(new NodeBuilder(NodeBuilderUtils.FindSketchNode(Node)));
            var pointBuilder2 = Dependency[0].ReferenceBuilder;
            var arcNormal = pointBuilder2[0].Reference.Children[1].Get<Axis3DInterpreter>().Axis;
            var circleLocation = Dependency[0].RefTransformedPoint3D.GpPnt;
      
            var projection = GeomUtils.ProjectPointOnArc(new gpAx1(circleLocation, new gpDir(arcNormal.Direction.GpPnt.XYZ).Transformed(transform)),
                                                         Dependency[1].RefTransformedPoint3D, vertex.Point, vertex.Point,
                                                         true);

            if (projection != null)
            {
                Dependency[index].RefTransformedPoint3D = new Point3D(projection);
            }

            //ArcMetaAction.ArcAnimation(_gizmoDocument, Dependency[0].TransformedAxis3D, Dependency[1].TransformedPoint3D, Dependency[2].TransformedPoint3D);
        }
    }
}