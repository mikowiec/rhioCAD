#region Usings

using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class Arc3PFunction : FunctionBase
    {
        public Arc3PFunction() : base(FunctionNames.Arc3P)
        {
            // First point of arc
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Second point of arc
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Third point of arc
            Dependency.AddAttributeType(InterpreterNames.Reference);
        }

        public override bool Execute()
        {
            var point1 = Dependency[0].ReferenceBuilder[1].TransformedPoint3D;
            var point2 = Dependency[1].ReferenceBuilder[1].TransformedPoint3D;
            var point3 = Dependency[2].ReferenceBuilder[1].TransformedPoint3D;

            var result = OccShapeCreatorCode.CreateArcShape(point1, point2, point3);
            if (result == null) return false;
            Shape = result;
            return true;
        }
    }
}