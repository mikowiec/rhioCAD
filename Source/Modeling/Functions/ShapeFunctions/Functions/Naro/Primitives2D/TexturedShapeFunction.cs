#region Usings

using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class TexturedShapeFunction : FunctionBase
    {
        public TexturedShapeFunction()
            : base(FunctionNames.TexturedShape)
        {
            AddDependency(InterpreterNames.Reference);
            AddDependency(InterpreterNames.Text);
        }

        public override bool Execute()
        {
            Interactive = OccShapeCreatorCode.TextureShape(Builder[0].ReferenceBuilder.Shape, Dependency[1].Text, Parent);
            return true;
        }
    }
}