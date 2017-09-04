#region Usings

using NaroConstants.Names;
using NaroPipes.Constants;

#endregion

namespace PartModellingLogic.Modifiers.Helpers
{
    internal class VerticalLineAction : HelperLineAction
    {
        public VerticalLineAction()
            : base(ModifierNames.VerticalLine, FunctionNames.VerticalLine, "verticalline.cur")
        {
        }
    }
}