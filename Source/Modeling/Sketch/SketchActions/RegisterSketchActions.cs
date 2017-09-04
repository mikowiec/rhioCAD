#region Usings

using NaroPipes.Actions;

#endregion

namespace SketchActions
{
    public static class RegisterSketchActions
    {
        public static void Register(ModifiersFactory modifierContainer)
        {
            modifierContainer.Register<SketchLineAction>();
        }
    }
}