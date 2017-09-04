#region Usings

using Extensions.NotificationTree;
using Naro.PartModeling;
using ShapeFunctions.Constraints.RealSizeLimits;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Interpreters.Layers;
using TreeData.AttributeInterpreter;
using TreeData.Capabilities;
using TreeData.NaroDataViewer;

#endregion

namespace PartModellingLogic
{
    public static class DefaultInterpreters
    {
        public static void Setup()
        {
            AttributeInterpreterFactory.Register<IntegerInterpreter>();
            AttributeInterpreterFactory.Register<RealInterpreter>();
            AttributeInterpreterFactory.Register<LayerContainerInterpreter>();
            AttributeInterpreterFactory.Register<LayerVisibilityInterpreter>();
            AttributeInterpreterFactory.Register<InheritedCloneInterpreter>();
            AttributeInterpreterFactory.Register<MeshTopoShapeInterpreter>();
            AttributeInterpreterFactory.Register<InteractiveShapeInterpreter>();
            AttributeInterpreterFactory.Register<DrawingAttributesInterpreter>();
            AttributeInterpreterFactory.Register<ObjectInterpreter>();

            AttributeInterpreterFactory.Register<MetricsInterpreter>();
            AttributeInterpreterFactory.Register<NotificationInterpreter>();

            AttributeInterpreterFactory.Register<ConceptInterpreter>();

            AttributeInterpreterFactory.Register<Point3DInterpreter>();
            AttributeInterpreterFactory.Register<Axis3DInterpreter>();
            AttributeInterpreterFactory.Register<StringInterpreter>();
            AttributeInterpreterFactory.Register<ReferenceInterpreter>();
            AttributeInterpreterFactory.Register<ReferenceListInterpreter>();
            AttributeInterpreterFactory.Register<FunctionInterpreter>();
            AttributeInterpreterFactory.Register<DocumentContextInterpreter>();
            AttributeInterpreterFactory.Register<NamedShapeInterpreter>();
            AttributeInterpreterFactory.Register<TopoDsShapeInterpreter>();
            AttributeInterpreterFactory.Register<TransformationInterpreter>();
            AttributeInterpreterFactory.Register<TreeViewVisibilityInterpreter>();
            AttributeInterpreterFactory.Register<CustomShapeDataInterpreter>();
            AttributeInterpreterFactory.Register<NaroVersionFileFormatInterpreter>();

            AttributeInterpreterFactory.Register<DocumentUserConfigInterpreter>();
            AttributeInterpreterFactory.Register<DontOptimize>();

            AttributeInterpreterFactory.Register<ShapePointConstraint>();
            AttributeInterpreterFactory.Register<MiddleEdgeConstraint>();
            AttributeInterpreterFactory.Register<IndexPointConstraintInterpreter>();
            AttributeInterpreterFactory.Register<HorizontalLineConstraint>();
            AttributeInterpreterFactory.Register<VerticalLineConstraint>();
            AttributeInterpreterFactory.Register<ActionGraphInterpreter>();
        }
    }
}