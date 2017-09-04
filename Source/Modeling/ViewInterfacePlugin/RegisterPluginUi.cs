#region Usings

using NaroUiBuilder;
using ViewInterfacePlugin.Constraints;
using ViewInterfacePlugin.Orientation;
using ViewInterfacePlugin.View;

#endregion

namespace ViewInterfacePlugin
{
    public static class RegisterPluginUi
    {
        public static void Register(UiBuilder uiBuilder)
        {
            uiBuilder.AddMapping("Ribbon/View/Orientation", new OrientationToolsMapping());
            uiBuilder.AddRibbonButton("Ribbon/View/View/Zoom", new ZoomToolsSplitButton());
            uiBuilder.AddRibbonButton("Ribbon/View/View/Pan", new PanningToolsSplitButton());
            uiBuilder.AddRibbonButton("Ribbon/View/View/Rotation", new RotationToolButton());
            uiBuilder.AddRibbonButton("Ribbon/View/View/FullScreen", new FullScreenToolButton());
            uiBuilder.AddMapping("Ribbon/View/View/HiddenOn", new HideOnToolButton());

            uiBuilder.AddMapping("Ribbon/Constraints/Constraints/ConstraintShapes", new ConstraintShapesToolButton());
            uiBuilder.AddMapping("Ribbon/Constraints/Constraints/PointToPoint", new PointToPointConstraintToolButton());
            uiBuilder.AddMapping("Ribbon/Constraints/Constraints/PointToEdge", new PointToEdgeConstraintToolButton());

            uiBuilder.AddMapping("Ribbon/Constraints/Constraints/Orthogonal", new OrthogonalCoordinates());
            uiBuilder.AddMapping("Ribbon/Constraints/Auto Apply/ApplyOneToolOnAnother",
                                 new ApplyOneToolOnAnotherButton());
            uiBuilder.AddMapping("Ribbon/Constraints/Auto Apply/CopyDeepTools", new CopyDeepToolsButton());
            uiBuilder.AddMapping("Ribbon/Constraints/Auto Apply/SynchronizeTools", new SynchronizeToolsButton());

            uiBuilder.AddMapping("Ribbon/Constraints/Drawing Area/DefineDrawingPlane", new DefineDrawingPlaneSplitButton());
            //uiBuilder.AddMapping("Ribbon/Constraints/Drawing Area/BlockPlane", new BlockPlaneButton());
            uiBuilder.AddMapping("Ribbon/Constraints/Drawing Area/DefineAxisSystem", new DefineAxisSystemSplitButton());
        }
    }
}