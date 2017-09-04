#region Usings

using ShapeFunctionsInterface.Utils;

#endregion

namespace SketchHinter.Primitives
{
    public abstract class HinterShapeCreatorBase
    {
        public HinterShapeBase Create(NodeBuilder builder)
        {
            var result = Build(builder);
            result.Builder = builder;
            return result;
        }

        public abstract HinterShapeBase Build(NodeBuilder builder);
    }
}