#region Usings

using System.Collections.Generic;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.gp;
using NaroSketchAdapter.Views;
using OccCode;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace InteractiveEditor.Handlers
{
    public class LineEditingHandler : GenericEditingShapeHandler
    {
        public override int EditingPointsCount()
        {
            return 2;
        }

        public override string GetHandleTypeAtIndex(int index)
        {
            return FunctionNames.Circle2DHandle;
        }

        public override gpAx2 GetPointLocation(int index)
        {
            var transform = NodeBuilderUtils.GetGlobalTransformation(new NodeBuilder(NodeBuilderUtils.FindSketchNode(Node)));
            var nodeAxis = Dependency[0].ReferenceBuilder[0].ReferenceBuilder[0].Node;
            var sketchAxis = nodeAxis.Get<Axis3DInterpreter>().Axis.GpAxis;
            sketchAxis.Direction = sketchAxis.Direction.Transformed(transform);
            var ax2 = new gpAx2();
            if (index == 0)
            {
                sketchAxis.Location = (Dependency[0].RefTransformedPoint3D.GpPnt);
                ax2.Axis = (sketchAxis);
                return ax2;
            }
            if (index == 1)
            {
                sketchAxis.Location = (Dependency[1].RefTransformedPoint3D.GpPnt);
                ax2.Axis = (sketchAxis);
                return ax2;
            }

            return null;
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            
            var sketchNode = Dependency[0].ReferenceBuilder[0].ReferenceBuilder[0].Node;
            var transform = NodeBuilderUtils.GetGlobalTransformation(new NodeBuilder(NodeBuilderUtils.FindSketchNode(Node)));
            var sketchAx2 = new gpAx2 {Axis = (sketchNode.Get<Axis3DInterpreter>().Axis.GpAxis)};
            sketchAx2.Direction = sketchAx2.Direction.Transformed(transform);
            var sketchPlane = new gpPln(new gpAx3(sketchAx2));
            var projectedPoint = GeomUtils.ProjectPointOnPlane(vertex.Point.GpPnt, sketchPlane, Precision.Confusion);
            var originalFirstPoint = Dependency[0].RefTransformedPoint3D;
            var originalSecondPoint = Dependency[1].RefTransformedPoint3D;
            if (index == 0)
            {
                var secondPoint = Dependency[1].RefTransformedPoint3D;
                Dependency[0].RefTransformedPoint3D = new Point3D(projectedPoint);
                Dependency[1].RefTransformedPoint3D = secondPoint;
            }
            if (index == 1)
                Dependency[1].RefTransformedPoint3D = new Point3D(projectedPoint);
            var document = Dependency[0].Node.Root.Get<DocumentContextInterpreter>().Document;
            var constraintMapper =
                new ConstraintDocumentHelper(document,
                                             sketchNode);
            constraintMapper.SetMousePosition(Dependency[index].Reference.Index);
            var error = constraintMapper.ImpactAndSolve(Dependency[0].Node.Parent);

            if (error == 1)
            {
                Dependency[0].RefTransformedPoint3D = originalFirstPoint;
                Dependency[1].RefTransformedPoint3D = originalSecondPoint;
            }
        }
    }
}