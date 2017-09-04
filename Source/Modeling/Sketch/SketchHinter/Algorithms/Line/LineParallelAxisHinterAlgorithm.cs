#region Usings

using System.Drawing;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using ShapeFunctionsInterface.Utils;
using SketchHinter.Primitives;
using TreeData.AttributeInterpreter;

#endregion

namespace SketchHinter.Algorithms.Line
{
    internal abstract class LineParallelAxisHinterAlgorithm : SketchHinterAlgorithmBase
    {
        private readonly gpDir _axisDirection;
        private readonly string _function;

        protected LineParallelAxisHinterAlgorithm(string constraintFunction, gpDir axisDirection)
        {
            _function = constraintFunction;
            _axisDirection = axisDirection;
        }

        public override bool Apply(HinterShapeBase hinterShape)
        {
            if (hinterShape.Builder.FunctionName != FunctionNames.LineTwoPoints)
                return false;
            var lineShape = (LineHinterShape) hinterShape;

            var result = AxisParallel(lineShape.Point1, lineShape.Point2, Options.ParallelAngle);
            if (!result)
                return false;

            AddConstraint(lineShape, _function);

            var builder = new NodeBuilder(hinterShape.Builder.Node) {Color = Color.DarkOrange};
            builder.ExecuteFunction();
            return true;
        }

        private bool AxisParallel(Point3D currentPoint, Point3D initialPosition, double angleRange)
        {
            if (currentPoint.IsEqual(initialPosition))
                return false;
            var direction = new gpDir(new gpVec(initialPosition.GpPnt, currentPoint.GpPnt));
            return _axisDirection.IsParallel(direction, angleRange);
        }
    }
}