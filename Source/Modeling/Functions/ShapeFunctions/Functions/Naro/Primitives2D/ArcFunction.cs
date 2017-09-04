#region Usings

using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class ArcFunction : FunctionBase
    {
        public ArcFunction() : base(FunctionNames.Arc)
        {
            // Point node that describes the arc center
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Arc starting point
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Arc end point
            Dependency.AddAttributeType(InterpreterNames.Reference);
        }

        public override bool Execute()
        {
            var pointBuilder = Dependency[0].ReferenceBuilder;
            var sketchNode = pointBuilder.Dependency[0].ReferenceBuilder;
            var sketchAxis = NodeBuilderUtils.GetTransformedAxis(sketchNode);
            var centerAxis = new Axis
                                 {
                                     Location = pointBuilder[1].TransformedPoint3D,
                                     Direction = new Point3D(sketchAxis.Direction.X, sketchAxis.Direction.Y, sketchAxis.Direction.Z)
                                 };
            var startPoint = Dependency[1].ReferenceBuilder[1].TransformedPoint3D;
            var endPoint = Dependency[2].ReferenceBuilder[1].TransformedPoint3D;

            var topoShape = GeomUtils.CreateArcWire(centerAxis.GpAxis, startPoint, endPoint, true);
            Shape = topoShape;

            return true;
        }
    }
}