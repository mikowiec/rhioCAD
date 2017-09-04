#region Usings

using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public class MeasureDistance : DrawingLiveShape
    {
        private bool _firstCoordinateSet;

        public MeasureDistance()
            : base(ModifierNames.MeasureDistance)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            _firstCoordinateSet = false;
            Points.Clear();
        }

        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            if (Points.Count == 0)
            {
                Points.Add(mouseData.Point);
                _firstCoordinateSet = true;
                Points.Add(new Point3D());
                return;
            }
            if (Points.Count == 2)
            {
                InitSession();
                var sketchCreator = new SketchCreator(Document);
                var normalOnPlane = sketchCreator.NormalOnSketch.Value.GpAxis;

                var builder = NodeBuilderUtils.BuildLineInDocument(Document, false, normalOnPlane, Points[0], Points[1]);

                NodeBuilderUtils.BuildDimensionForLine(Document, builder, Points[0], Points[1]);
                UpdateView();
                Points.Clear();
                AddNodeToTree(builder.Node);
                RebuildTreeView();
                Document.Commit("Added Dimension");
            }
        }

        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            if (!_firstCoordinateSet || Points.Count <2) return;

            Points[1] = mouseData.Point;
            if (Points[0].IsEqual(Points[1])) return;
            InitSession();
            var sketchCreator = new SketchCreator(Document);
            var normalOnPlane = sketchCreator.NormalOnSketch.Value.GpAxis;

            var builder = NodeBuilderUtils.BuildLineInDocument(Document, false, normalOnPlane, Points[0], Points[1]);

            NodeBuilderUtils.BuildDimensionForLine(Document, builder, Points[0], Points[1]);
            UpdateView();
        }

        public override void OnDeactivate()
        {
            InitSession();
            UpdateView();
            base.OnDeactivate();
        }
    }
}