#region Usings

using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using TreeData.AttributeInterpreter;

#endregion

namespace InteractiveEditor.Handlers
{
    public class ConeEditingHandler : CircleEditingHandler
    {
        public override int EditingPointsCount()
        {
            return 4;
        }

        public override string GetHandleTypeAtIndex(int index)
        {
            if (index < 4)
                return base.GetHandleTypeAtIndex(index);

            return FunctionNames.BoxEditingHandle;
        }

        public override gpAx2 GetPointLocation(int index)
        {
            if (index < 4)
                return base.GetPointLocation(index);

            return new gpAx2();
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            if (index < 4)
            {
                base.UpdatePointPosition(index, vertex);
                return;
            }

            var transform = Node.Get<TransformationInterpreter>();
            if (index == 4)
            {
            }
        }
    }
}