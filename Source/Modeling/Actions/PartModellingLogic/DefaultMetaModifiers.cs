#region Usings

using MetaActions.Shapes;
using MetaActions.Tools;
using MetaActions.View;
using MetaActionsInterface;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic
{
    public static class DefaultMetaModifiers
    {
        public static void Setup(CommandList modifierContainer)
        {
            //modifierContainer.Register(new DynamicRotation(workItem));
            modifierContainer.Register(ModifierNames.Axo, "axo", new AxoMetaAction());
            modifierContainer.Register(ModifierNames.Back, "back", new BackMetaAction());
            modifierContainer.Register(ModifierNames.Bottom, "bottom", new BottomMetaAction());
            modifierContainer.Register(ModifierNames.Front, "front", new FrontMetaAction());
            modifierContainer.Register(ModifierNames.Left, "left", new LeftMetaAction());
            modifierContainer.Register(ModifierNames.Reset, "reset", new ResetMetaAction());
            modifierContainer.Register(ModifierNames.Right, "right", new RightMetaAction());
            modifierContainer.Register(ModifierNames.Top, "top", new TopMetaAction());
            modifierContainer.Register(ModifierNames.AngleDraft, "angle_draft", new AngleDraftMetaAction());

            modifierContainer.Register(ModifierNames.Offset, "offset", new OffsetMetaAction());
            
            modifierContainer.Register(ModifierNames.HorizontalLine, "horizontal_line");
            modifierContainer.Register(ModifierNames.VerticalLine, "horizontal_line");

            modifierContainer.Register(ModifierNames.Spline, "spline", new SplineMetaAction());
            modifierContainer.Register(ModifierNames.Box, "box", new BoxMetaAction());

            modifierContainer.Register(ModifierNames.BooleanAdd, "boolean_add", new BooleanFuseMetaAction());
            modifierContainer.Register(ModifierNames.BooleanIntersect, "boolean_intersect",
                                       new BooleanIntersectMetaAction());
            modifierContainer.Register(ModifierNames.BooleanSubstract, "boolean_substract", new BooleanCutMetaAction());


            modifierContainer.Register(ModifierNames.Sphere, "sphere", new SphereMetaAction());
            modifierContainer.Register(ModifierNames.Cylinder, "cylinder", new CylinderMetaAction());
            modifierContainer.Register(ModifierNames.Cone, "cone", new ConeMetaAction());
            modifierContainer.Register(ModifierNames.Torus, "torus", new TorusMetaAction());

            //modifierContainer.Register(new DrawPolyline(workItem));

            modifierContainer.Register(ModifierNames.Translate, "translate", new TranslateMetaAction());
            //modifierContainer.Register(new SunflowRender(workItem));
            //modifierContainer.Register(new TagManager(workItem));
            //modifierContainer.Register(new TagShapeEditor(workItem));
            //modifierContainer.Register(new OptionsDialogManager(workItem));
            //modifierContainer.Register(new CommandLineAction(workItem));
        }
    }
}