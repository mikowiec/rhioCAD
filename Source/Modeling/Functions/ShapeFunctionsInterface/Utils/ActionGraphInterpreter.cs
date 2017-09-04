#region Usings

using NaroPipes.Actions;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace Naro.PartModeling
{
    public class ActionGraphInterpreter : AttributeInterpreterBase
    {
        public ActionsGraph ActionsGraph { get; set; }

        public override void Serialize(AttributeData data)
        {
        }

        public override void Deserialize(AttributeData data)
        {
        }
    }
}