#region Usings

using System;
using System.Collections.Generic;
using ErrorReportCommon.Messages;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Shapes.SplineBased
{
    internal class CombineSplines : SplineBasedTool
    {
        private List<CombinedClassInfo> _listCommonPoints;

        public CombineSplines() : base(ModifierNames.CombineSplines)
        {
        }

        public override void OnDeactivate()
        {
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.EnableAll);
            InitSession();
            RebuildTreeView();
            base.OnDeactivate();
        }

        public override void OnActivate()
        {
            base.OnActivate();
            GetOptions();
            InitSession();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            var firstPoint = new SortedDictionary<int, Point3D>();
            var secondPoint = new SortedDictionary<int, Point3D>();
            var root = Document.Root;
            var shapeIndexes = root.Get<DocumentContextInterpreter>().ShapeManager.ShapeIndexes;
            foreach (var shapeIndex in shapeIndexes)
            {
                var builder = new NodeBuilder(root[shapeIndex]);
                if (builder.FunctionName != FunctionNames.SplinePath) continue;
                firstPoint[shapeIndex] = builder[1].TransformedPoint3D;
                secondPoint[shapeIndex] = builder[builder[0].Integer].TransformedPoint3D;
            }

            InitSession();
            var list = new List<int>();
            list.AddRange(firstPoint.Keys);
            _listCommonPoints = new List<CombinedClassInfo>();
            for (var i = 0; i < list.Count - 1; i++)
                for (var j = i + 1; j < list.Count; j++)
                {
                    var commonPoint = CommonSplinePoint(firstPoint, secondPoint, list[i], list[j]);
                    if (commonPoint == null) continue;
                    DrawPreviewPoint((Point3D) commonPoint);
                    var commonInfo = new CombinedClassInfo((Point3D) commonPoint,
                                                           new NodeBuilder(root[list[i]]),
                                                           new NodeBuilder(root[list[j]]));
                    _listCommonPoints.Add(commonInfo);
                }
            if (_listCommonPoints.Count != 0) return;
     //       NaroMessage.Show("There are no splines with common points! Exiting");
            BackToNeutralModifier();
        }


        private static Point3D? CommonSplinePoint(IDictionary<int, Point3D> firstPoint,
                                                  IDictionary<int, Point3D> secondPoint, int firstSpline,
                                                  int secondSpline)
        {
            var pointS1P1 = firstPoint[firstSpline];
            var pointS1P2 = secondPoint[firstSpline];

            var pointS2P1 = firstPoint[secondSpline];
            var pointS2P2 = secondPoint[secondSpline];

            if (pointS1P1.IsEqual(pointS2P1)) return pointS1P1;
            if (pointS1P1.IsEqual(pointS2P2)) return pointS1P1;

            if (pointS1P2.IsEqual(pointS2P1)) return pointS1P2;
            if (pointS1P2.IsEqual(pointS2P2)) return pointS1P2;
            return null;
        }

        private int GetSplineIndex(Mouse3DPosition mouseData)
        {
            var index = -1;
            foreach (var splinePoint in _listCommonPoints)
            {
                index++;
                if (ArePointsOutOfZoomRange(splinePoint.CommonPoint, mouseData.Point)) continue;
                return index;
            }
            return -1;
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            var index = GetSplineIndex(mouseData);
            ShowHint(index != -1 ? "Click To Combine" : string.Empty);
            base.OnMouseMove3DAction(mouseData);
        }

        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            var index = GetSplineIndex(mouseData);
            if (index == -1) return;
            InitSession();
            _listCommonPoints[index].Combine(Document);
            CommitFinal("Combined splines");
            UpdateView();
            RebuildTreeView();
            ActionsGraph.SwitchAction(ModifierNames.CombineSplines);
        }

        #region Nested type: CombinedClassInfo

        private class CombinedClassInfo
        {
            public readonly Point3D CommonPoint;
            private readonly NodeBuilder _destSpline;
            private readonly bool _firstReversed;
            private readonly bool _secondReversed;
            private readonly NodeBuilder _sourceSpline;

            public CombinedClassInfo(Point3D commonPoint, NodeBuilder sourceSpline, NodeBuilder destSpline)
            {
                CommonPoint = commonPoint;
                _sourceSpline = sourceSpline;
                _destSpline = destSpline;
                _firstReversed = CommonPoint.IsEqual(sourceSpline[1].TransformedPoint3D);
                _secondReversed = !CommonPoint.IsEqual(destSpline[1].TransformedPoint3D);
            }

            public void Combine(Document document)
            {
                var sourceList = GetOrderedSplinePoints(_sourceSpline, _firstReversed);
                var destList = GetOrderedSplinePoints(_destSpline, _secondReversed);
                Ensure.IsTrue(sourceList[sourceList.Count - 1].IsEqual(destList[0]));
                destList.RemoveAt(0);
                sourceList.AddRange(destList);

                NodeBuilderUtils.DeleteNode(_sourceSpline.Node, document);
                NodeBuilderUtils.DeleteNode(_destSpline.Node, document);

                Ensure.IsTrue(BuildSplineFromPoints(document, sourceList));
            }

            private static List<Point3D> GetOrderedSplinePoints(NodeBuilder splineBuilder, bool reversed)
            {
                var sourceSplinePoints = ExtractSplineAllPoints(splineBuilder).ToArray();
                if (reversed) Array.Reverse(sourceSplinePoints);
                return new List<Point3D>(sourceSplinePoints);
            }
        }

        #endregion
    }
}