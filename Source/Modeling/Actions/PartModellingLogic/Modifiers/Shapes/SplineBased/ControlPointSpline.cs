#region Usings

using NaroBasicPipes.Actions;
using NaroPipes.Constants;
using OccCode;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Shapes.SplineBased
{
    public class ControlPointSpline : SplineBasedAction
    {
        public ControlPointSpline()
            : base(ModifierNames.ControlPointSpline)
        {
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            WriteTextOnPos(mouseData.Initial2Dx, mouseData.Initial2Dy, mouseData.Point.ToString());
            SetLastPointAsMouse(mouseData);
            PreviewSpinePath();

          //  UpdateView();
        }

        private void SetLastPointAsMouse(Mouse3DPosition mouseData)
        {
            Points[Points.Count - 1] = mouseData.Point;
        }

        protected override void GenerateHandlerPointList()
        {
            var newSize = (Points.Count - 2)/3*3 + 4;
            var index = (Points.Count - 2)%3;
            UpdateControlPointSize(newSize);
            var lastPoint = Points[Points.Count - 1];
            DefinedPointCount = Points.Count - 2;
            switch (index)
            {
                case 0:
                    var prevLastPoint = Points[Points.Count - 4];

                    SplineControlPoints[newSize - 1] = lastPoint;
                    SplineControlPoints[newSize - 3] = GeomUtils.BetweenValue(lastPoint, prevLastPoint, 0.3);
                    SplineControlPoints[newSize - 2] = GeomUtils.BetweenValue(lastPoint, prevLastPoint, 0.7);
                    break;
                case 1:
                    SplineControlPoints[newSize - 3] = lastPoint;
                    break;
                case 2:
                    SplineControlPoints[newSize - 2] = lastPoint;
                    break;
            }
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            if (Points.Count <= 2)
            {
                var index = Points.Count - 1;
                UpdateControlPointSize(1 + index*3);
                SplineControlPoints[index*3] = Points[index];
                if (Points.Count == 2)
                {
                    var lastPoint = Points[index];
                    var prevLastPoint = Points[0];

                    SplineControlPoints[1] = GeomUtils.BetweenValue(lastPoint, prevLastPoint, 0.3);
                    SplineControlPoints[2] = GeomUtils.BetweenValue(lastPoint, prevLastPoint, 0.7);
                }
            }
            SetLastPointAsMouse(mouseData);
            PreviewSpinePath();
            Points.Add(new Point3D());
        }


        public override void OnDeactivate()
        {
            if (Points.Count <= 3)
            {
                base.OnDeactivate();
                return;
            }
            Points.RemoveAt(Points.Count - 1);
            InitSession();
            var result = BuildSplineLogicalPoints(false);
            CommitFinal("Added Spline Path");
            AddNodeToTree(result.Node);
            UpdateView();
            base.OnDeactivate();
        }
    }
}