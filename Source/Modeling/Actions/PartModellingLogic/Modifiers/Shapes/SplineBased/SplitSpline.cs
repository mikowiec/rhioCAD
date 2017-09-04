#region Usings

using System.Collections.Generic;
using Naro.Infrastructure.Interface.GeomHelpers;
using Naro.Infrastructure.Library.Geometry;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAdaptor;
using NaroPipes.Constants;
using OccCode;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Shapes.SplineBased
{
    internal class SplitSpline : SplineBasedTool
    {
        private SortedDictionary<Point3D, int> _splinePoints;

        public SplitSpline()
            : base(ModifierNames.SplitSpline)
        {
        }

        List<NodeBuilder> splines = new List<NodeBuilder>();

        public override void OnActivate()
        {
            base.OnActivate();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            _splinePoints = new SortedDictionary<Point3D, int>(new GeomUtils.PointComparer());

            var root = Document.Root;
            var shapeIndexes = root.Get<DocumentContextInterpreter>().ShapeManager.ShapeIndexes;
            foreach (var shapeIndex in shapeIndexes)
            {
                var builder = new NodeBuilder(root[shapeIndex]);
                if (builder.FunctionName != FunctionNames.SplinePath) continue;
                splines.Add(builder);
                var pointCount = builder[0].Integer/3 + 1;
                for (var i = 1; i < pointCount - 1; ++i)
                {
                    var index = 1 + i*3;
                    var pointInSpline = builder[index].TransformedPoint3D;
                    _splinePoints[pointInSpline] = shapeIndex;
                    DrawPreviewPoint(pointInSpline);
                }
            }
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            var index = GetSplineIndex(mouseData);
            if(index != -1)
                ShowHint("Click To Split");
            //ShowHint(index != -1 ? "Click To Split" : string.Empty);
            base.OnMouseMove3DAction(mouseData);
        }

        private int GetSplineIndex(Mouse3DPosition mouseData)
        {
            var index = -1;
            foreach (var splinePoint in _splinePoints)
            {
                if (ArePointsOutOfZoomRange(splinePoint.Key, mouseData.Point)) continue;
                index = splinePoint.Value;
            }
            return index;
        }

        private static void SplitListPoint(IEnumerable<Point3D> sourceShape, int splitIndex,
                                           ICollection<Point3D> firstList, ICollection<Point3D> secondList)
        {
            firstList.Clear();
            secondList.Clear();
            var pos = 0;
            foreach (var point3D in sourceShape)
            {
                if (pos < splitIndex)
                    firstList.Add(point3D);
                else
                    secondList.Add(point3D);
                pos++;
                if (pos == splitIndex)
                    secondList.Add(point3D);
            }
        }

        private void SplitSplineLogic(NodeBuilder builder, int splitIndex)
        {
            var splineAllPoints = ExtractSplineAllPoints(builder);
            NodeBuilderUtils.DeleteNode(builder.Node, Document);
            var firstList = new List<Point3D>();
            var secondList = new List<Point3D>();
            SplitListPoint(splineAllPoints, splitIndex, firstList, secondList);
            Ensure.IsTrue(BuildSplineFromPoints(Document, firstList));
            Ensure.IsTrue(BuildSplineFromPoints(Document, secondList));
        }


        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            var shapeIndex = GetSplineIndex(mouseData);
            var sketch = Document.Root.Get<DocumentContextInterpreter>().ActiveSketch;
             var sketchBuilder = new SketchCreator(Document);

            var nodeBuilder = new NodeBuilder(sketchBuilder.CurrentSketch);
            nodeBuilder[0].TransformedAxis3D = sketchBuilder.NormalOnSketch.Value.GpAxis;
            
            if (shapeIndex == -1)
                return;
            var root = Document.Root;
            var builder = new NodeBuilder(root[shapeIndex]);
            var pointCount = builder[0].Integer;
            var subIndex = -1;
            for (var i = 1; i < pointCount - 1; ++i)
            {
                var pointInSpline = builder[i].TransformedPoint3D;
                if (ArePointsOutOfZoomRange(pointInSpline, mouseData.Point))
                    subIndex = i - 1;
            }
            Ensure.IsNotTrue(subIndex == -1);
            InitSession();
            SplitSplineLogic(builder, subIndex);
            CommitFinal("Split Spline");
            UpdateView();
            ActionsGraph.SwitchAction(ModifierNames.SplitSpline);
        }

        public override void OnDeactivate()
        {
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.EnableAll);
            InitSession();
            RebuildTreeView();
            base.OnDeactivate();
        }
    }
}