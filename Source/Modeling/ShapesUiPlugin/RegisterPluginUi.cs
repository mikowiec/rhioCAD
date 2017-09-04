using NaroUiBuilder;
using ShapesUiPlugin.Booleans;
using ShapesUiPlugin.Features;
using ShapesUiPlugin.Selection;
using ShapesUiPlugin.Sketch;
using ShapesUiPlugin.Solid;
using ShapesUiPlugin.Tools;

namespace ShapesUiPlugin
{
    public class RegisterPluginUi
    {
        public static void Register(UiBuilder uiBuilder)
        {
            return;
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Sketch/Cursor", new CursorToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Sketch/Point", new PointToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Sketch/Rectangle", new RectangleToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Sketch/Line", new LineToolsSplitButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Sketch/Spline", new SplineToolsSplitButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Sketch/Circle", new CircleToolsSplitButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Sketch/Arc", new ArcToolsSplitButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Sketch/Dimension", new DimensionToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Sketch/Sketch", new LaunchSketchToolButton());

            uiBuilder.AddRibbonButton("Ribbon/Shapes/Solid/Box", new BoxButtonTool());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Solid/Cone", new ConeButtonTool());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Solid/Cylinder", new CylinderButtonTool());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Solid/Sphere", new SphereButtonTool());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Solid/Torus", new TorusButtonTool());

            uiBuilder.AddRibbonButton("Ribbon/Shapes/Selection/Selection", new SelectionToolsSplitButton());

            uiBuilder.AddRibbonButton("Ribbon/Shapes/Features/Extrude", new ExtrudeToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Features/Cut", new CutToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Features/Pipe", new PipeToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Features/Revolve", new RevolveToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Features/Fillet", new ChamferFilletToolsSplitButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Features/Sew", new SewToolButton());

            uiBuilder.AddRibbonButton("Ribbon/Shapes/Boolean/Fuse", new FuseToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Boolean/Intersect", new IntersectToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Boolean/Substract", new SubstractToolButton());

            uiBuilder.AddRibbonButton("Ribbon/Shapes/Tools/Translate", new TranslateToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Tools/Pattern", new PatternToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Tools/Offset2D", new Offset2DToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Shapes/Tools/Mirror", new MirrorToolsSplitButton());
        }
    }
}
