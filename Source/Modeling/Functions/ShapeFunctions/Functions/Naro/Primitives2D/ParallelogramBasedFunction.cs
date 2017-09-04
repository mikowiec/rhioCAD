#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using OccCode;

using ShapeFunctionsInterface.Functions;
using NaroCppCore.Occ.Precision;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class ParallelogramBasedFunction : FunctionBase
    {
        public ParallelogramBasedFunction(string functionName)
            : base(functionName)
        {
            // The rectangle is like the following:
            //   P2--------P3
            //   P1--------P4
            // vertex 1
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            // vertex 2
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            // vertex 3
            Dependency.AddAttributeType(InterpreterNames.Point3D);
        }

        private static bool AreInSamePlace(gpPnt startPoint, gpPnt endPoint)
        {
            return startPoint.IsEqual(endPoint, Precision.Confusion);
        }

        public override bool Execute()
        {
            // Get the values of dimension and position attributes 
            var firstPoint = Dependency[0].TransformedPoint3D;
            var secondPoint = Dependency[1].TransformedPoint3D;
            var thirdPoint = Dependency[2].TransformedPoint3D;

            var wire = OccShapeCreatorCode.BuildRectangle(firstPoint, secondPoint, thirdPoint);
            if ((wire == null) || (wire.IsNull))
            {
                return false;
            }

            // Make also the shape axis before the shape regeneration
            var axis = new gpAx1 {Location = firstPoint.GpPnt};
            Axis = axis;

            Shape = wire;

            return true;
        }
    }
}