#region Usings

using System.Collections.Generic;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;

using SketchHinter.Primitives;
using TreeData.AttributeInterpreter;

#endregion

namespace SketchHinter.Algorithms.LineOnLine
{
    internal abstract class LineOnLineHinterAlgorithmBase : SketchHinterAlgorithmBase
    {
        protected string FunctionName;
        private SortedDictionary<int, gpDir> _lineDirections;

        public override void OnPopulate()
        {
            ExtractDirections();
        }

        private void ExtractDirections()
        {
            _lineDirections = new SortedDictionary<int, gpDir>();
            foreach (var hinterShape in Hinter2D.HinterShapes.Values)
            {
                if (hinterShape.Builder.FunctionName != FunctionNames.LineTwoPoints)
                    continue;
                var lineShape = (LineHinterShape) hinterShape;
                var lineIndex = lineShape.Builder.Node.Index;
                if (lineShape.Point1.IsEqual(lineShape.Point2))
                    continue;
                var direction = GetPointsDirection(lineShape.Point1, lineShape.Point2);
                _lineDirections[lineIndex] = direction;
            }
        }

        private static gpDir GetPointsDirection(Point3D currentPoint, Point3D initialPosition)
        {
            return new gpDir(new gpVec(initialPosition.GpPnt, currentPoint.GpPnt));
        }

        protected abstract bool LinesAxisMatch(gpDir axisDir, gpDir direction, double angleRange);

        public override bool Apply(HinterShapeBase hinterShape)
        {
            if (hinterShape.Builder.FunctionName != FunctionNames.LineTwoPoints)
                return false;
            var lineShape = (LineHinterShape) hinterShape;
            if (lineShape.Point1.IsEqual(lineShape.Point2))
                return false;
            var axisDir = GetPointsDirection(lineShape.Point1, lineShape.Point2);
            foreach (var direction in _lineDirections)
            {
                if (hinterShape.Builder.Node.Index == direction.Key) continue;
                var result = LinesAxisMatch(axisDir, direction.Value, Options.ParallelAngle);
                if (!result) continue;
                var constraint = AddConstraint(lineShape, Hinter2D.HinterShapes[direction.Key], FunctionName);
                if(constraint != null)
                    constraintNodes.Add(constraint);
                return true;
            }
            return false;
        }
    }
}