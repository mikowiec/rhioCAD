#region Usings

using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Functions;

#endregion

namespace TwoPointLinePlugin
{
    internal class TwoPointLineFunction : FunctionBase
    {
        public TwoPointLineFunction()
            : base(Names.FunctionName)
        {
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            Dependency.AddAttributeType(InterpreterNames.Point3D);
        }

        public override bool Execute()
        {
            // Get the two line points
            var firstPoint = Dependency[0].TransformedPoint3D;
            var secondPoint = Dependency[1].TransformedPoint3D;
            if (firstPoint.IsEqual(secondPoint))
                return false;

            var wire = OccShapeCreatorCode.CreateLineWire(firstPoint, secondPoint);
            Shape = wire;

            return true;
        }
    }
}