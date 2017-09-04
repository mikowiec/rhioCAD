#region Usings

using NaroPipes.Actions;
using PartModellingLogic.Modifiers.Constraints;
using PartModellingLogic.Modifiers.DocumentAction;
using PartModellingLogic.Modifiers.EditingActions;
using PartModellingLogic.Modifiers.Helpers;
using PartModellingLogic.Modifiers.Infrastructure;
using PartModellingLogic.Modifiers.Shapes;
using PartModellingLogic.Modifiers.Shapes.SplineBased;
using PartModellingLogic.Modifiers.Tools;
using PartModellingLogic.Modifiers.Tools.AutoTools;
using PartModellingLogic.Modifiers.Tools.ChamferFillet;
using PartModellingLogic.Modifiers.View;
#endregion

namespace PartModellingLogic
{
    public static class DefaultModifiers
    {
        public static void Setup(ModifiersFactory modifierContainer)
        {
            modifierContainer.Register<DynamicRotation>();
            modifierContainer.Register<Axo>();
            modifierContainer.Register<Back>();
            modifierContainer.Register<Bottom>();
            modifierContainer.Register<FitAll>();
            modifierContainer.Register<Front>();
            modifierContainer.Register<Left>();
            modifierContainer.Register<Reset>();
            modifierContainer.Register<Right>();
            modifierContainer.Register<Top>();
            modifierContainer.Register<None>();
            //modifierContainer.Register<Extrude(workItem));
            modifierContainer.Register<Cut>();
            modifierContainer.Register<Fillet>();
            modifierContainer.Register<Chamfer>();
            modifierContainer.Register<Fillet2D>();
            modifierContainer.Register<Chamfer2D>();
            modifierContainer.Register<Dimension>();
            modifierContainer.Register<Direction>();
            modifierContainer.Register<Offset>();
            modifierContainer.Register<Delete>();
            modifierContainer.Register<DeleteHidden>();
            modifierContainer.Register<EditingAction>();
            modifierContainer.Register<LineNormal>();
            modifierContainer.Register<Offset3D>();
            modifierContainer.Register<AddSelectedTool>();

            modifierContainer.Register<Translate>();
            modifierContainer.Register<Copy>();
            modifierContainer.Register<MeasureDistance>();
            modifierContainer.Register<MirrorPointAction>();
            modifierContainer.Register<MirrorLineAction>();
            modifierContainer.Register<MirrorPlaneAction>();
            modifierContainer.Register<RotateAroundAxisAction>();
            modifierContainer.Register<CircularPatternAction>();
            modifierContainer.Register<ArrayPatternAction>();
            modifierContainer.Register<DefineDrawingPlane>();

            modifierContainer.Register<NaroFileNew>();
            modifierContainer.Register<NaroLoad>();
            modifierContainer.Register<NaroStartup>();
            modifierContainer.Register<NaroSave>();
            modifierContainer.Register<NaroSaveAs>();
            modifierContainer.Register<NaroExit>();
            modifierContainer.Register<NaroRestart>();
            modifierContainer.Register<NaroUndo>();
            modifierContainer.Register<NaroRedo>();
            modifierContainer.Register<ExportToStep>();
            modifierContainer.Register<ExportToNaroXml>();
            modifierContainer.Register<ImportFromBrep>();
            modifierContainer.Register<ImportFromStep>();
            modifierContainer.Register<ImportFromNaroXml>();
            modifierContainer.Register<NaroDocumentCut>();
            modifierContainer.Register<NaroDocumentCopy>();
            modifierContainer.Register<NaroDocumentPaste>();

            modifierContainer.Register<ViewZoomWindow>();
            modifierContainer.Register<ViewDynamicZooming>();
            modifierContainer.Register<ViewDynamicPanning>();
            modifierContainer.Register<ViewGlobalPanning>();

            modifierContainer.Register<BlockPlane>();
            modifierContainer.Register<UnblockPlane>();
            modifierContainer.Register<StartSketch>();
            modifierContainer.Register<EndSketch>();
            modifierContainer.Register<ArcCenterStartEndAction>();
            //modifierContainer.Register<ArcStartEndRadius>();

            modifierContainer.Register<MakeFace>();
            modifierContainer.Register<ExplodeFace>();
            modifierContainer.Register<Pipe>();
            modifierContainer.Register<Sew>();
            modifierContainer.Register<Revolve>();
            modifierContainer.Register<Extrude>();
            //modifierContainer.Register<ExtrudeSketch>();

            modifierContainer.Register<AngleDraftAction>();

            modifierContainer.Register<InterpolatedSpline>();
            modifierContainer.Register<ControlPointSpline>();
            modifierContainer.Register<SplitSpline>();
            modifierContainer.Register<CombineSplines>();
            modifierContainer.Register<SplineAddPoint>();
          //  modifierContainer.Register<LineAction>();
            modifierContainer.Register<FourLinesRectangle>();
            modifierContainer.Register<ThreePointsRectangle>();
            modifierContainer.Register<CircleAction>();
            modifierContainer.Register<EllipseAction>();
            modifierContainer.Register<PointAction>();
            modifierContainer.Register<ArcCenterStartEndAction>();
            modifierContainer.Register<ArcStartEndRadiusAction>();
            modifierContainer.Register<TrimAction>();
            modifierContainer.Register<LineInPolylineMode>();
            modifierContainer.Register<LinesSetAngle>();

            modifierContainer.Register<SunflowRender>();
            modifierContainer.Register<OptionsDialogManager>();

            modifierContainer.Register<EdgeDistanceConstraintModifier>();
            modifierContainer.Register<PointToPointConstraintAction>();
            modifierContainer.Register<PointToEdgeConstraintAction>();
            modifierContainer.Register<ConstraintShapeAction>();
            modifierContainer.Register<SketchConstraintMapperAction>();

            modifierContainer.Register<HorizontalLineAction>();
            modifierContainer.Register<VerticalLineAction>();

            modifierContainer.Register<HiddenOnAction>();
            modifierContainer.Register<HiddenOffAction>();

            modifierContainer.Register<HandleDraggingAction>();

            modifierContainer.Register<ApplyOneToolOnAnotherModifier>();
            modifierContainer.Register<SyncronizeToolValues>();
            modifierContainer.Register<CopyDeepToolsModifier>();

            modifierContainer.Register<GuardPointFromMovingAction>();
        }
    }
}