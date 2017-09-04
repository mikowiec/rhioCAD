#region Usings

using System.Drawing;
using NaroConstants.Names;
using OccCode;
using ShapeFunctions.Utils;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using SketchHinter.Primitives;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace SketchHinter.Algorithms.PointOnLine
{
    internal class PointOnLineAlgorithm : SketchHinterAlgorithmBase
    {
        private ShapeGraph _graph;

        public override bool Apply(HinterShapeBase hinterShape)
        {
            if (hinterShape.Builder.FunctionName != FunctionNames.Point)
                return false;
            var pointShape = (PointHinterShape) hinterShape;
            var sourcePoint = pointShape.Position;
            var refByList = _graph.GetReferredBy(hinterShape.Builder.Node);
            foreach (var shape in Hinter2D.HinterShapes.Values)
            {
                if (shape.Builder.FunctionName != FunctionNames.LineTwoPoints)
                    continue;
                var line = (LineHinterShape) shape;
                if (refByList.Contains(shape.Builder.Node.Index))
                    continue;
                var result = CheckAndApplyPointMiddleOfLine(pointShape, line, sourcePoint);
                if (result) return true;
            }
            return false;
        }

        public override void OnPopulate()
        {
            base.OnPopulate();
            _graph = Hinter2D.Document.Root.Get<DocumentContextInterpreter>().ShapesGraph;
        }

        private bool CheckAndApplyPointMiddleOfLine(PointHinterShape pointShape, LineHinterShape line,
                                                    Point3D sourcePoint)
        {
            var linePoint1 = line.Point1;
            var linePoint2 = line.Point2;
            var builder = new NodeBuilder(line.Builder.Node);
            var midPoint = DimensionUtils.ComputeMiddlePoint(linePoint1, linePoint2);
            if (midPoint.Distance(sourcePoint) >= Options.PointRange)
            {
                var edges = GeomUtils.ExtractEdges(line.Builder.Shape);
                if(edges.Count != 1)
                return false;
                if (GeomUtils.PointIsOnEdge(edges[0], sourcePoint))
                {
                    AddConstraint(line.Builder.Node, pointShape.Builder.Node, Constraint2DNames.PointOnLineFunction);
                    builder.Color = Color.Tomato;
                    builder.ExecuteFunction();
                    return true;
                }
                return false;
            }
            AddConstraint(line.Builder.Node, pointShape.Builder.Node, Constraint2DNames.PointOnLineMidpointFunction);
            builder.Color = Color.Violet;
            builder.ExecuteFunction();
            return true;
        }
    }
}