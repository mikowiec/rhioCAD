#region Usings

using NaroCAD.SolverModule.Interface.Geometry;
using NaroSetup;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace NaroSketchAdapter.Factory.ShapeTypes
{
    public abstract class SolverGeometryExtracter
    {
        #region Methods to implement

        protected abstract bool Extract(SolverGeometricObject data);

        #endregion

        #region Properties

        public Section SolverOptions { protected get; set; }
        protected NodeBuilder Builder { get; private set; }

        #endregion

        public static bool HasShapeOrInteractive(Node node)
        {
            var interpreter = node.Get<TopoDsShapeInterpreter>();
            var interactive = node.Get<InteractiveShapeInterpreter>();
            if (interpreter == null && interactive == null)
                return false;
            if (interpreter != null && interpreter.Shape != null)
                return true;
            if (interactive != null) return interactive.Interactive != null;
            return false;
        }

        #region Methods

        public SolverGeometricObject ExtractSolverGeometry(Node node)
        {
            var result = new SolverGeometricObject(node);
            if (!HasShapeOrInteractive(node))
            {
                return result;
            }
            Builder = new NodeBuilder(node);
            return Extract(result) ? result : null;
        }

        #endregion
    }
}