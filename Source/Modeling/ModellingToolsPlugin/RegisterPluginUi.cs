#region Usings

using ModellingToolsPlugin.Booleans;
using ModellingToolsPlugin.Features;
using ModellingToolsPlugin.Selection;
using ModellingToolsPlugin.Sketch;
using ModellingToolsPlugin.Solid;
using ModellingToolsPlugin.Tools;
using NaroUiBuilder;
using NaroUiBuilder.RibbonMapping;

#endregion

namespace ModellingToolsPlugin
{
    public static class RegisterPluginUi
    {
        public static void Register(UiBuilder uiBuilder)
        {
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Cursor/Cursor", new CursorToolButton());

            SetSketchButtons(uiBuilder);

            //uiBuilder.AddRibbonButton("Ribbon/Modelling/Sketch/Selection", new SelectionToolsSplitButton());

            uiBuilder.AddMapping("Ribbon/Modelling/Solid", new SolidsToolsGroup());

            uiBuilder.AddRibbonButton("Ribbon/Modelling/Gizmos/GizmoNone", new GizmoTypeNoneButton());
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Gizmos/GizmoTranslate", new GizmoTypeTranslateButton());
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Gizmos/GizmoRotate", new GizmoTypeRotateButton());
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Gizmos/GizmoScale", new GizmoTypeScaleButton());

            uiBuilder.AddRibbonButton("Ribbon/Modelling/Boolean/Fuse", new FuseToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Boolean/Intersect", new IntersectToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Boolean/Substract", new SubstractToolButton());

            uiBuilder.AddRibbonButton("Ribbon/Modelling/Tools/Translate", new TranslateToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Tools/Copy", new CopyToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Tools/RotateAxis", new RotateAroundAxisButton());
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Tools/CircularPattern", new CircularPatternButton());
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Tools/ArrayPattern", new ArrayPatternButton());
            //uiBuilder.AddRibbonButton("Ribbon/Modelling/Tools/Measure", new MeasureDistanceToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Tools/Offset2D", new Offset2DToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Tools/Mirror", new MirrorToolsSplitButton());
        }

        private static void SetSketchButtons(UiBuilder uiBuilder)
        {
            var sketchButton = new SketchButton();
            uiBuilder.AddMapping("Ribbon/Modelling/Sketch/Sketch", sketchButton);

            SketchButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Sketch/Point", new PointToolButton());
            SketchButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Sketch/RectangleTools",
                              new RectangleToolsSplitButton());
            /*uiBuilder.AddRibbonButton("Ribbon/Modelling/Sketch/RectangleThreePoints", new Rectangle2ToolButton());
            uiBuilder.AddRibbonButton("Ribbon/Modelling/Sketch/RectangleThreePoints", new Rectangle2ToolButton());*/
            SketchButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Sketch/Line", new LineToolsSplitButton());
            SketchButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Sketch/Spline", new SplineToolsSplitButton());
            SketchButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Sketch/Circle", new CircleToolsSplitButton());
            SketchButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Sketch/Arc", new ArcToolsSplitButton());
            SketchButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Sketch/Dimension", new DimensionToolButton());
            SketchButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Sketch/Trim", new TrimToolButton());
            SketchButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Sketch/Fillet", new ChamferFillet2DToolsSplitButton());
        //    SketchButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Sketch/BlockPlane", new BlockPlaneButton());

            FeatureButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Features/Extrude", new ExtrudeToolButton());
            FeatureButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Features/Cut", new CutToolButton());
            FeatureButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Features/Pipe", new PipeToolButton());
            FeatureButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Features/Revolve", new RevolveToolButton());
            FeatureButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Features/Fillet", new ChamferFilletToolsSplitButton());
            FeatureButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Features/Sew", new SewToolButton());
            FeatureButtonSetup(uiBuilder, sketchButton, "Ribbon/Modelling/Features/AngleDraft", new AngleDraftToolButton());


            //SketchButtonSetup(uiBuilder, sketchButton, "Ribbon/Constraints/Sketch/SketchConstraintMapper",
            //                  new SketchConstraintToolButton());
            SketchButtonSetup(uiBuilder, sketchButton, "Ribbon/Constraints/Sketch/SketchConstraintPoint",
                              new SketchConstraintPointsButton());
        }

        private static void SketchButtonSetup(UiBuilder uiBuilder, SketchButton sketchButton, string pointPath,
                                              RibbonSplitButtonMapping pointToolButton)
        {
            uiBuilder.AddRibbonButton(pointPath, pointToolButton);
            sketchButton.SketchUi(pointToolButton);
        }

        private static void SketchButtonSetup(UiBuilder uiBuilder, SketchButton sketchButton, string pointPath,
                                              RibbonButtonMapping pointToolButton)
        {
            uiBuilder.AddRibbonButton(pointPath, pointToolButton);
            sketchButton.SketchUi(pointToolButton);
        }

        private static void SketchButtonSetup(UiBuilder uiBuilder, SketchButton sketchButton, string pointPath,
                                              ToggleButtonMapping pointToolButton)
        {
            uiBuilder.AddMapping(pointPath, pointToolButton);
            sketchButton.SketchUi(pointToolButton);
        }

        private static void FeatureButtonSetup(UiBuilder uiBuilder, SketchButton sketchButton, string pointPath,
                                               RibbonSplitButtonMapping pointToolButton)
        {
            uiBuilder.AddRibbonButton(pointPath, pointToolButton);
            sketchButton.FeatureUi(pointToolButton);
        }

        private static void FeatureButtonSetup(UiBuilder uiBuilder, SketchButton sketchButton, string pointPath,
                                               RibbonButtonMapping pointToolButton)
        {
            uiBuilder.AddRibbonButton(pointPath, pointToolButton);
            sketchButton.FeatureUi(pointToolButton);
        }
    }
}