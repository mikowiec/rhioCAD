#region Usings

using NaroConstants.Names;
using NaroPipes.Constants;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public class MirrorPlaneAction : MirrorActionCommon
    {
        public MirrorPlaneAction()
            : base(ModifierNames.MirrorPlane, FunctionNames.MirrorPlane)
        {
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
            Builder[1].ReferenceData = new SceneSelectedEntity(SelectedNodes[1]);
        }
    }
}