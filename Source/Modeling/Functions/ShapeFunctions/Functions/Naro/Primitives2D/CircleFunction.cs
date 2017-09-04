#region Usings

using NaroConstants.Names;
using OccCode;

using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.Precision;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class CircleFunction : FunctionBase
    {
        public CircleFunction() : base(FunctionNames.Circle)
        {
            // Circle center
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Circle radius
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            var radius = Dependency[1].Real;
            if (radius < Precision.Confusion)
                return false;
            var pointBuilder = Dependency[0].ReferenceBuilder;
            var sketchNode = pointBuilder.Dependency[0].ReferenceBuilder;
            var transformedAxis = NodeBuilderUtils.GetTransformedAxis(sketchNode);
          
            var centerAxis = new Axis
                                { 
                                     Location = pointBuilder[1].TransformedPoint3D,
                                     Direction = new Point3D(transformedAxis.Direction.X, transformedAxis.Direction.Y, transformedAxis.Direction.Z)
                                 };
            var topoShape = OccShapeCreatorCode.CreateWireCircle(centerAxis.GpAxis, radius);
            Shape = topoShape;

            return true;
        }
    }
}