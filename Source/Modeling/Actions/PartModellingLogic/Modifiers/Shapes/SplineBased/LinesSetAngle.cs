#region Usings

using System;
using System.Collections.Generic;
using ErrorReportCommon.Messages;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.AppUtils;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Constants;
using NaroSetup;
using NaroSetup.Pages.Solver;
using PartModellingUi.Views.Tools;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Shapes.SplineBased
{
    internal class LinesSetAngle : DrawingLiveShape
    {
        private int _index;
        private List<CombinedLinesClassInfo> _listCommonPoints;
        private LineSetAngleView _view;
        private double _zoom;

        public LinesSetAngle()
            : base(ModifierNames.LinesSetAngle)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            GetOptions();

            _view = null;
            _index = -1;

            InitSession();

            var firstPoint = new SortedDictionary<int, Point3D>();
            var secondPoint = new SortedDictionary<int, Point3D>();
            var root = Document.Root;
            var shapeIndexes = root.Get<DocumentContextInterpreter>().ShapeManager.ShapeIndexes;
            foreach (var shapeIndex in shapeIndexes)
            {
                var builder = new NodeBuilder(root[shapeIndex]);
                if (builder.FunctionName != FunctionNames.LineTwoPoints) continue;
                firstPoint[shapeIndex] = builder[0].RefTransformedPoint3D;
                secondPoint[shapeIndex] = builder[1].RefTransformedPoint3D;
            }

            InitSession();
            var list = new List<int>();
            list.AddRange(firstPoint.Keys);
            _listCommonPoints = new List<CombinedLinesClassInfo>();
            for (var i = 0; i < list.Count - 1; i++)
                for (var j = i + 1; j < list.Count; j++)
                {
                    var commonPoint = CommonLinePoint(firstPoint, secondPoint, list[i], list[j]);
                    if (commonPoint == null) continue;
                    DrawPreviewPoint((Point3D) commonPoint);
                    var commonInfo = new CombinedLinesClassInfo((Point3D) commonPoint,
                                                                new NodeBuilder(root[list[i]]),
                                                                new NodeBuilder(root[list[j]]));
                    _listCommonPoints.Add(commonInfo);
                }
            if (_listCommonPoints.Count != 0) return;
            NaroMessage.Show("There are no lines with common points! Exiting");
            BackToNeutralModifier();
        }

        private void GetOptions()
        {
            var optionsSetup = ActionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);
            var precision = optionsSection.GetDoubleValue((int) HinterOptionFields.PointMatch);
            _zoom = CoreGlobalPreferencesSingleton.Instance.ZoomLevel*precision;
        }

        private void DrawPreviewPoint(Point3D pointOnLine)
        {
            var sphere = new NodeBuilder(Document, FunctionNames.Sphere);
            sphere[0].TransformedPoint3D = pointOnLine;
            sphere[1].Real = _zoom*2/3;
            sphere.ExecuteFunction();
        }

        private static Point3D? CommonLinePoint(IDictionary<int, Point3D> firstPoint,
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

        private bool ArePointsOutOfZoomRange(Point3D splineIntermediaryPoint, Point3D mousePoint)
        {
            return splineIntermediaryPoint.Distance(mousePoint) > _zoom;
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
            ShowHint(index != -1 ? "Click To Set Angle" : string.Empty);
            base.OnMouseMove3DAction(mouseData);
        }

        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            _index = GetSplineIndex(mouseData);
            if (_index == -1)
            {
                RibbonPanel.Children.Clear();
                return;
            }
            InitSession();
            if (_view != null) return;
            var angle = _listCommonPoints[_index].Angle;
            _view = new LineSetAngleView(angle/Math.PI*180);

            _view.Changed += Changed;
            _view.Closed += ViewClosed;
            RibbonPanel.Children.Add(_view);
        }

        private void ViewClosed()
        {
            PreviewLineAngle();
            if (_view.AcceptResult)
                CommitFinal("Angle Set");
            BackToNeutralModifier();
        }

        private void PreviewLineAngle()
        {
            InitSession();
            _listCommonPoints[_index].Combine(_view.Angle*Math.PI/180.0, _view.ReversedBase);

            UpdateView();
        }

        private void Changed()
        {
            PreviewLineAngle();
        }
    }
}