#region Usings

using System.Collections.Generic;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Constants;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    /// <summary>
    ///   Implements the Revolve modifier.
    /// </summary>
    public class MirrorPointAction : MirrorActionCommon
    {
        public MirrorPointAction()
            : base(ModifierNames.MirrorPoint, FunctionNames.MirrorPoint)
        {
        }

        protected override void OnMouseClick3DAction(Mouse3DPosition mouseData)
        {
            Ensure.IsNotNull(Document);
            OnSceneShapePicked();
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

        protected override void OnShapePicked(Node node)
        {
            if (SelectedNodes.Count > 0 && SelectedNodes[0].Index == node.Index)
                return;
            SelectShape(node);
            SelectedNodes.Add(node);
            UpdateShapeSelection();
        }

        protected override void AddShapeToScene()
        {
            var axisBuilder = new NodeBuilder(SelectedNodes[1]);
        //    var point = ShapeUtils.ConvertShapeToPoint(axisBuilder.TransformedShape);
            Builder[1].Reference = SelectedNodes[1];
        }
    }
}