#region Usings

using System.Collections.Generic;
using NaroCAD.SolverModule.Factory.ShapeTypes;
using NaroCAD.SolverModule.Interface.Geometry;
using NaroConstants.Names;
using NaroSetup;
using NaroSketchAdapter.Factory.ShapeTypes;
using ShapeFunctionsInterface.Interpreters.Layers;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroSketchAdapter.Factory
{
    public class SolverConstraintFactory
    {
        #region Constructor

        private SolverConstraintFactory()
        {
            _genericExtracter = new GenericGeometryExtracter();
            GeometryExtracters = new SortedDictionary<string, SolverGeometryExtracter>();

            Setup();
        }

        #endregion

        #region Properties

        private SortedDictionary<string, SolverGeometryExtracter> GeometryExtracters { get; set; }

        public static SolverConstraintFactory Instance
        {
            get { return InternalInstance; }
        }

        public Section SolverOptions
        {
            set
            {
                _genericExtracter.SolverOptions = value;
                foreach (var solverGeometryExtracter in GeometryExtracters.Values)
                {
                    solverGeometryExtracter.SolverOptions = value;
                }
            }
        }

        #endregion

        #region Methods

        public SolverGeometricObject ExtractGeometry(Node node)
        {
            if (!SolverGeometryExtracter.HasShapeOrInteractive(node)) return null;
            var functionName = FunctionUtils.GetFunctionName(node);
            if (string.IsNullOrEmpty(functionName)) return null;
            if (IsHidden(node)) return null;
            SolverGeometryExtracter extracter;
            var tryExtracter = GeometryExtracters.TryGetValue(functionName, out extracter);
            return !tryExtracter
                       ? _genericExtracter.ExtractSolverGeometry(node)
                       : extracter.ExtractSolverGeometry(node);
        }

        private static bool IsHidden(Node node)
        {
            var builder = new NodeBuilder(node);
            return builder.Visibility == ObjectVisibility.Hidden ||
                   !builder.Node.Get<LayerVisibilityInterpreter>().IsVisible;
        }

        private void Setup()
        {
            RegisterExtracter(FunctionNames.Circle, new CircleGeometryExtracter());
            RegisterExtracter(FunctionNames.Arc, new CircleGeometryExtracter());
            RegisterExtracter(FunctionNames.Ellipse, new EllipseGeometryExtracter());
            RegisterExtracter(FunctionNames.Cone, new CircleGeometryExtracter());
            RegisterExtracter(FunctionNames.Cylinder, new CircleGeometryExtracter());
            RegisterExtracter(FunctionNames.Torus, new CircleGeometryExtracter());
            RegisterExtracter(FunctionNames.SplinePath, new SplinePathGeometryExtracter());

            RegisterExtracter(FunctionNames.HorizontalLine, new HorizontalLineExtracter());
            RegisterExtracter(FunctionNames.VerticalLine, new VerticalLineExtracter());
        }

        private void RegisterExtracter(string shapeType, SolverGeometryExtracter extracter)
        {
            GeometryExtracters[shapeType] = extracter;
        }

        #endregion

        #region Data members

        private static readonly SolverConstraintFactory InternalInstance = new SolverConstraintFactory();
        private readonly GenericGeometryExtracter _genericExtracter;

        #endregion
    }
}