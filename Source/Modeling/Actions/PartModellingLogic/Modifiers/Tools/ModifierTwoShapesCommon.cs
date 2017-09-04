#region Usings

using System.Collections.Generic;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Utils;
using log4net;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public abstract class ModifierTwoShapesCommon : DrawingLiveShape
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (ModifierTwoShapesCommon));

        private readonly List<string> _messagesList = new List<string>(2);
        private readonly List<Node> _selectedNodes = new List<Node>();

        protected ModifierTwoShapesCommon(string name)
            : base(name)
        {
            _messagesList.Add(string.Empty);
            _messagesList.Add(string.Empty);
            SetHintText();
        }

        protected Node FirstShape
        {
            get { return _selectedNodes.Count > 0 ? _selectedNodes[0] : null; }
        }

        protected Node SecondShape
        {
            get { return _selectedNodes.Count > 1 ? _selectedNodes[1] : null; }
        }

        protected string FirstMessage
        {
            set { _messagesList[0] = value; }
        }

        protected string SecondMessage
        {
            set { _messagesList[1] = value; }
        }

        private void SetHintText()
        {
            FirstMessage = "Select first shape";
            SecondMessage = "Select second shape";
        }

        protected override void OnTreeNodeSelect(Node node)
        {
            OnShapePicked(node);
        }

        private void OnSceneShapePicked()
        {
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            if (entities.Count <= 0)
                return;
            OnShapePicked(entities[0].Node);
        }

        protected virtual bool IsNodeValid(int dependencyIndex, Node node)
        {
            return true;
        }

        private void OnShapePicked(Node node)
        {
            if (!IsNodeValid(_selectedNodes.Count, node))
                return;
            if (_selectedNodes.Count > 0 && _selectedNodes[0].Index == node.Index)
                return;
            SelectShape(node);
            _selectedNodes.Add(node);
            UpdateShapeSelection();
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            Ensure.IsNotNull(Document);

            OnSceneShapePicked();
        }

        private void UpdateShapeSelection()
        {
            if (_selectedNodes.Count < 2) return;
            Log.Info("Two Shapes Inputs operation finished");

            Document.Transact();
            if (ApplyFunction())
                DocumentCommitReason();
            else
                Document.Revert();
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.Cleanup);
            UpdateView();
            BackToNeutralModifier();
        }

        protected abstract void DocumentCommitReason();
        protected abstract bool ApplyFunction();

        private void Reset()
        {
            Context.Select(true);
            _selectedNodes.Clear();
        }

        public override void OnDeactivate()
        {
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.EnableAll);
            Document.Revert();
            base.OnDeactivate();
        }

        public override void OnActivate()
        {
            base.OnActivate();
            var sketchBuilder = new SketchCreator(Document, false);
            var sketchNode = sketchBuilder.CurrentSketch;
            if (sketchNode != null)
            {
                ActionsGraph.SwitchAction(ModifierNames.EndSketch, ModifierNames.Cut);
                return;
            }
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            ShowHint(_messagesList[0]);
            Reset();
        }
    }
}