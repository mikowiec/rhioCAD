#region Usings

using ErrorReportCommon.Messages;
using MetaActions;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Shapes
{
    public class SplineAddPoint : DrawingAction3D
    {
        private FunctionInterpreter _function;
        private bool _pointAdded;

        public SplineAddPoint() : base(ModifierNames.SplineAddPoint)
        {
        }

        public override void OnActivate()
        {
            _pointAdded = false;
            var firstShape = NodeBuilderUtils.IdentifySelectedObjectLabel(Document.Root);
            if (firstShape == null)
            {
                ErrorSplineSelected();
                return;
            }

            _function = firstShape.Get<FunctionInterpreter>();
            if (_function == null)
            {
                ErrorSplineSelected();
                return;
            }
            if (_function.Name != FunctionNames.Spline)
            {
                ErrorSplineSelected();
                return;
            }

            Document.Transact();
            _pointAdded = true;

            var mouseCursorInput = Inputs[InputNames.MouseCursorInput];
            mouseCursorInput.Send(NotificationNames.SetResourceManager, MetaActionResource.ResourceManager);
            mouseCursorInput.Send(NotificationNames.SetCursorName, "splineaddpoint.cur");
        }

        private void ErrorSplineSelected()
        {
            NaroMessage.Show(@"Please select a spline first");
            BackToNeutralModifier();
        }

        private void AddPointToSpline(Point3D destination)
        {
            var nodeBuilder = new NodeBuilder(_function.Parent);
            nodeBuilder.Dependency.AddAttributeType(InterpreterNames.Point3D);
            var itemCount = nodeBuilder.Count;
            nodeBuilder[itemCount - 1].TransformedPoint3D = destination;
            nodeBuilder.ExecuteFunction();
        }

        public override void OnDeactivate()
        {
            UpdateView();
            if (_pointAdded)
            {
                Document.Commit("Add point(s) to spline");
            }

            base.OnDeactivate();
        }

        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            if (Document == null) return;
            if (!mouseData.MouseDown) return;

            AddPointToSpline(mouseData.Point);
            UpdateView();
        }
    }
}