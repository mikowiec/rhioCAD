#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.TopLoc;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.Utils;

#endregion

namespace ShapeFunctions.Functions.Naro.Mirroring
{
    public class MirrorPlaneFunction : MirrorFunctionsCommon
    {
        public MirrorPlaneFunction() : base(FunctionNames.MirrorPlane)
        {
            // Profile
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Reference
            Dependency.AddAttributeType(InterpreterNames.Reference);
        }

        public override bool Execute()
        {
            var sourceBuilder = new NodeBuilder(Dependency[0].Reference);
            var targetBuilder = new NodeBuilder(Dependency[1].Reference);
            var profile = sourceBuilder.TransformedShape;

            var targetFace = targetBuilder.TransformedShape;

            Ensure.IsTrue(ShapeUtils.IsPlanarFace(targetFace));
            var plane = ShapeUtils.ExtractPlaneFromFaceShape(targetFace);

            var referenceTransformation = Dependency[0].Reference.Get<TransformationInterpreter>().CurrTransform;
            var mirroredShape = profile.Located(new TopLocLocation(referenceTransformation));

            var transformation = Parent.Set<TransformationInterpreter>();
         //   transformation.CurrTransform.SetMirror(plane.Position.Ax2);

            Shape = mirroredShape;
            return Shape != null;
        }
    }
}