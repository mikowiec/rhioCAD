#region Usings

using System.Collections.Generic;
using MetaActionsInterface;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public abstract class MirrorActionCommon : DrawingLiveShape
    {
        protected readonly List<Node> SelectedNodes = new List<Node>();
        private readonly string _functionName;
        protected NodeBuilder Builder;

        protected MirrorActionCommon(string modifierName, string functionName) : base(modifierName)
        {
            _functionName = functionName;
        }

        public override void OnActivate()
        {
            base.OnActivate();
            Inputs[InputNames.GeometricSolverPipe].Send(NotificationNames.DisableAll);
            Reset();
        }

        private void Reset()
        {
            Context.Select(true);
            SelectedNodes.Clear();
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

        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            Ensure.IsNotNull(Document);
            OnSceneShapePicked();
        }


        public override void OnDeactivate()
        {
            Builder = new NodeBuilder(null);
            base.OnDeactivate();
        }

        protected void UpdateShapeSelection()
        {
            if (SelectedNodes.Count < 2) return;
            InitSession();

            Builder = new NodeBuilder(Document, _functionName);


            Builder[0].Reference = SelectedNodes[0];
            Builder[1].Reference = SelectedNodes[1];

            if (Builder.ExecuteFunction())
            {
                Document.Root.Remove(Builder.Node.Index); 
                CommitFinal("Apply Mirror");
                UpdateView();
                RebuildTreeView();
            }

            BackToNeutralModifier();
        }

        protected abstract void OnShapePicked(Node node);
        protected abstract void AddShapeToScene();
    }
}