#region Usings

using Naro.Infrastructure.Interface.AppUtils;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using OccCode;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;
using ShapeFunctionsInterface.Utils;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class PointFunction : FunctionBase
    {
        public PointFunction() : base(FunctionNames.Point)
        {
            // Sketch reference
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Point
            Dependency.AddAttributeType(InterpreterNames.Point3D);
        }

        public override bool Execute()
        {
            var axis = NodeBuilderUtils.GetTransformedAxis(Dependency[0].ReferenceBuilder);
            var zoomLevel = CoreGlobalPreferencesSingleton.Instance.ZoomLevel;
            Shape = OccShapeCreatorCode.CreateCircle(axis, zoomLevel);
            return true;
        }
    }
}