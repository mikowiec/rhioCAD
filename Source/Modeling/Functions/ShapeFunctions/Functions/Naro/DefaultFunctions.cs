#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using ShapeFunctions.Constraints.Naro;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes2D;
using ShapeFunctions.Constraints.Naro.ConstraintsShapes3D;
using ShapeFunctions.Constraints.RealSizeLimits;
using ShapeFunctions.Functions.Naro.Helper;
using ShapeFunctions.Functions.Naro.Mirroring;
using ShapeFunctions.Functions.Naro.Primitives2D;
using ShapeFunctions.Functions.Naro.Primitives3D;
using ShapeFunctions.Functions.Naro.Sketch;
using ShapeFunctions.Functions.Naro.Tools;
using ShapeFunctions.Functions.Solver;
using ShapeFunctions.Handles.EditingHandles;
using ShapeFunctions.Handles.Gizmos;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro
{
    public static class DefaultFunctions
    {
        public static void Setup(ActionsGraph actionsGraph)
        {
            var functionFactory =
                actionsGraph[InputNames.FunctionFactoryInput].GetData(NotificationNames.GetValue).Get<IFunctionFactory>();
            SetupShapes(functionFactory);

            SetupTools(functionFactory);

            SetupConstraints(functionFactory);

            SetupEditingHandles(functionFactory);
            SetupSolverMarkers(functionFactory);
            SetupSketch(functionFactory);
        }

        private static void SetupSolverMarkers(IFunctionFactory functionFactory)
        {
            functionFactory.Register<SolverPointMarker>();
            functionFactory.Register<SolverLineMarker>();
            functionFactory.Register<LineMarker>();
        }

        private static void SetupConstraints(IFunctionFactory functionFactory)
        {
            functionFactory.Register<FixedSizeConstraint>();
            functionFactory.Register<CoLocationConstraint>();
            functionFactory.Register<RangeSizeConstraint>();

            functionFactory.Register<CircleRangeConstraint>();
            functionFactory.Register<RectangleWidthConstraint>();
            functionFactory.Register<RectangleHeightConstraint>();
//            functionFactory.Register<LineLengthConstraint>();
            functionFactory.Register<EdgeDistanceConstraint>();
            functionFactory.Register<PointToPointConstraint>();
            
            functionFactory.Register<EllipseMajorRadiusConstraint>();
            functionFactory.Register<EllipseMinorRadiusConstraint>();

            functionFactory.Register<TorusMinorRangeConstraint>();
            functionFactory.Register<TorusMajorRadiusConstraint>();

            functionFactory.Register<ConeHeightConstraint>();
            functionFactory.Register<ConeMinorRadiusConstraint>();
            functionFactory.Register<ConeMajorRadiusConstraint>();

            functionFactory.Register<CylinderRadiusConstraint>();
            functionFactory.Register<CylinderHeightConstraint>();

            functionFactory.Register<SphereRadiusConstraint>();

            functionFactory.Register<BoxHeightConstraint>();

            functionFactory.Register<ExtrudeHeightConstraint>();
            functionFactory.Register<CutHeightConstraint>();
        }

        private static void SetupTools(IFunctionFactory functionFactory)
        {
            functionFactory.Register<MirrorPointFunction>();
            functionFactory.Register<MirrorLineFunction>();
            functionFactory.Register<MirrorPlaneFunction>();

            functionFactory.Register<HorizontalLineFunction>();
            functionFactory.Register<DottedLine>();
            functionFactory.Register<VerticalLineFunction>();

            functionFactory.Register<SubShapeFunction>();
            functionFactory.Register<FilletFunction>();
            functionFactory.Register<Fillet2DFunction>();
            functionFactory.Register<ExtrudeFunction>();
            functionFactory.Register<BooleanFunction>();
            functionFactory.Register<PointFunction>();
            functionFactory.Register<MeshFunction>();
            functionFactory.Register<CutFunction>();
            functionFactory.Register<PipeFunction>();
            functionFactory.Register<EvolvedFunction>();
            functionFactory.Register<SewingFunction>();
            functionFactory.Register<RevolveFunction>();
            functionFactory.Register<MakeFaceFunction>();
            functionFactory.Register<FaceFuseFunction>();
            functionFactory.Register<DimensionFunction>();
            functionFactory.Register<PointsDimensionFunction>();
            functionFactory.Register<OffsetFunction>();
            functionFactory.Register<Offset3DFunction>();
            functionFactory.Register<AngleDraftFunction>();
            functionFactory.Register<TrimFunction>();
        }

        private static void SetupShapes(IFunctionFactory functionFactory)
        {
            functionFactory.Register<Arc3PFunction>();
            functionFactory.Register<ArrowFunction>();
            functionFactory.Register<BoxFunction>();
            functionFactory.Register<Box1PFunction>();
            functionFactory.Register<CircleFunction>();
            functionFactory.Register<RectangleFunction>();
            functionFactory.Register<ParallelogramFunction>();
            functionFactory.Register<LineTwoPointsFunction>();
            functionFactory.Register<WireTwoPointsFunction>();
            functionFactory.Register<LineHintsFunction>();
            functionFactory.Register<PointHintsFunction>();
            functionFactory.Register<EllipseFunction>();
            functionFactory.Register<SplineFunction>();
            functionFactory.Register<SphereFunction>();
            functionFactory.Register<SplinePathFunction>();
            functionFactory.Register<PolylineFunction>();
            functionFactory.Register<CylinderFunction>();
            functionFactory.Register<PlaneFunction>();
            functionFactory.Register<ConeFunction>();
            functionFactory.Register<TorusFunction>();
            functionFactory.Register<ArcFunction>();
            functionFactory.Register<PointFunction>();
            functionFactory.Register<TexturedShapeFunction>();
        }

        private static void SetupEditingHandles(IFunctionFactory functionFactory)
        {
            functionFactory.Register<BoxHandleFunction>();
            functionFactory.Register<ArrowHandleFunction>();
            functionFactory.Register<AxisHandleFunction>();
            functionFactory.Register<PlaneHandleFunction>();
            functionFactory.Register<TriangleHandleFunction>();
            functionFactory.Register<CircleHandleFunction>();
            functionFactory.Register<Circle2DHandleFunction>();
            functionFactory.Register<Rectangle2DHandleFunction>();
            functionFactory.Register<Triangle2DEditingHandle>();
        }

        private static void SetupSketch(IFunctionFactory functionFactory)
        {
            functionFactory.Register<SketchFunction>();
        }
    }
}