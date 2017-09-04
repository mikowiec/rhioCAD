#region Usings

using NaroConstants.Names;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.Helpers
{
    public class HorizontalLineAction : HelperLineAction
    {
        public HorizontalLineAction()
            : base(ModifierNames.HorizontalLine, FunctionNames.HorizontalLine, "horizontalline.cur")
        {
        }
    }
}