#region Usings

using NaroBasicPipes.Actions;
using NaroPipes.Constants;
using OccCode;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Shapes.SplineBased
{
    public class InterpolatedSpline : SplineBasedAction
    {
        /// <summary>
        ///   Is a value that is made that if you will use it and you put in middle of a square as points of spline, will result a cirle
        ///   More detals can be seen here:
        ///   http://www.tinaja.com/glib/ellipse4.pdf
        ///   The magic number is the presented magic number multiplied by sqrt(2.0)/2.0
        /// </summary>
        private const double MagicNumber = 0.3901702;

        public InterpolatedSpline()
            : base(ModifierNames.InterpolatedSpline)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            EditedPointIndex = -1;
        }

        private void SetLastPointAsMouse(Mouse3DPosition mouseData)
        {
            Points[Points.Count - 1] = mouseData.Point;
        }

        protected override void GenerateHandlerPointList()
        {
            var count = Points.Count*3 - 2;
            UpdateControlPointSize(count);
            DefinedPointCount = count - 2;

            UpdateBasePoint(Points.Count - 1);
            var i = Points.Count - 2;
            var leftParallel = GeomUtils.GetParallelPointOnDistance(Points[i + 1], Points[i - 1], Points[i],
                                                                    Points[i].Distance(Points[i - 1])*MagicNumber);
            SplineControlPoints[i*3 - 1] = leftParallel;

            var rightParallel = GeomUtils.GetParallelPointOnDistance(Points[i - 1], Points[i + 1], Points[i],
                                                                     Points[i].Distance(Points[i + 1])*MagicNumber);
            SplineControlPoints[i*3 + 1] = rightParallel;
            if (Points.Count == 3)
                SplineControlPoints[1] = GeomUtils.GetLastTrapezoidPoint(Points[0], Points[1], SplineControlPoints[2]);
            SplineControlPoints[SplineControlPoints.Count - 2] =
                GeomUtils.GetLastTrapezoidPoint(Points[Points.Count - 2],
                                                Points[Points.Count - 1],
                                                SplineControlPoints[Points.Count*3 - 5]);
        }

        private void UpdateBasePoint(int i)
        {
            UpdateControlPointSize(Points.Count*3 - 2);
            SplineControlPoints[i*3] = Points[i];
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            var pos = HandleEditingPoints(mouseData);
            if (pos != -1)
            {
                if (mouseData.ShiftDown && pos%3 == 0 && pos != Points.Count - 1)
                {
                    switch (pos)
                    {
                        case 0:
                            Points.RemoveAt(0);
                            SplineControlPoints.RemoveRange(0, 3);
                            break;
                        default:
                            Points.RemoveAt(pos/3);
                            SplineControlPoints.RemoveRange(pos - 1, 3);
                            break;
                    }
                    PreviewSpinePath();
                }
                EditedPointIndex = pos;
                ShowHint("Move mouse to set the coordinate");
                return;
            }
            if (Points.Count <= 2)
                UpdateBasePoint(Points.Count - 1);
            SetLastPointAsMouse(mouseData);
            PreviewSpinePath();
            Points.Add(new Point3D());
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            WriteTextOnPos(mouseData.Initial2Dx, mouseData.Initial2Dy, mouseData.Point.ToString());

            if (MouseMoveHandled(mouseData))
            {
                UpdateView();
                return;
            }
            ShowHint("Click to set the next spline point");
            SetLastPointAsMouse(mouseData);
            PreviewSpinePath();
          //  UpdateView();
        }


        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
        {
            base.OnMouseUpAction(mouseData);
            EditedPointIndex = -1;
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