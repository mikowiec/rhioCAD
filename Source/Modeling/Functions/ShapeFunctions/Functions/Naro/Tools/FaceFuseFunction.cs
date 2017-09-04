#region Usings

using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using OccCode;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    public class FaceFuseFunction : FunctionBase
    {
        public FaceFuseFunction() : base(FunctionNames.FaceFuse)
        {
            // All drawn candidate faces that will be fused and split
            Dependency.AddAttributeType(InterpreterNames.ReferenceList);
        }

        public override bool Execute()
        {
            var bigFace = GeomUtils.FuseShapeList(Dependency[0].ReferenceList);

            // Failed fusing the coliding shapes
            if (bigFace == null ||  bigFace.IsNull)
            {
                return false;
            }

            // Set the new face
            Shape = bigFace;


            // Hide the coliding shapes
            foreach (var colidingShape in Dependency[0].ReferenceList)
            {
                NodeUtils.Hide(colidingShape.Node);
            }

            return true;
        }
    }
}