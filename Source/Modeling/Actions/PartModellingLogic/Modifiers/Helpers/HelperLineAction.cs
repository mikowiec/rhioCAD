#region Usings

using MetaActions;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Helpers
{
    public class HelperLineAction : DrawingLiveShape
    {
        private readonly string _cursorName;

        private readonly string _functionName;

        protected HelperLineAction(string actionName, string functionName, string cursorName)
            : base(actionName)
        {
            _cursorName = cursorName;
            _functionName = functionName;
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Reset();

            var mouseCursorInput = Inputs[InputNames.MouseCursorInput];
            mouseCursorInput.Send(NotificationNames.SetResourceManager, MetaActionResource.ResourceManager);
            mouseCursorInput.Send(NotificationNames.SetCursorName, _cursorName);
        }

        private void Reset()
        {
            // Suspend the face picker
            Inputs[InputNames.FacePickerPlane].Send(NotificationNames.Suspend);
            Points.Clear();
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            // At mouse down pick the selected edge
            if (!mouseData.MouseDown)
                return;

            InitSession();

            var builder = DrawDimension(mouseData.Point);

            if (!builder.ExecuteFunction())
            {
                Document.Revert();
                BackToNeutralModifier();
                return;
            }
            AddNodeToTree(builder.Node);
            // Finish the transaction
            CommitFinal("Apply helper line");

            // Prepare for a new dimension
            Reset();
        }


        private NodeBuilder DrawDimension(Point3D mousePoint)
        {
            var builder = CreateTemporaryBuilder(_functionName);
            builder[0].TransformedPoint3D = mousePoint;
            builder.ExecuteFunction();
            return builder;
        }

        /// <summary>
        ///   Receives mouse move events. The mouse move can be made having a button pressed or not
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
        {
            // Display the temporary dimension
            InitSession();
            DrawDimension(mouseData.Point);
            UpdateView();
        }
    }
}