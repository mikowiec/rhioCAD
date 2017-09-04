#region Usings

using Naro.Infrastructure.Library.Geometry;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepAlgoAPI;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    /// <summary>
    ///   Boolean functions
    /// </summary>
    public class BooleanFunction : FunctionBase
    {
        public BooleanFunction() : base(FunctionNames.Boolean)
        {
            // Reference shape on source shape
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Reference shape on destination shape
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Extrusion type
            Dependency.AddAttributeType(InterpreterNames.Integer);
        }

        public override bool Execute()
        {
            var firstShape = Dependency[0].ReferedShape;
            var secondShape = Dependency[1].ReferedShape;
            if (firstShape.IsSame(secondShape))
            {
                return false;
            }

            NodeUtils.Hide(Dependency[0].Reference);
            NodeUtils.Hide(Dependency[1].Reference);

            switch (Dependency[2].Integer)
            {
                case (int) BooleanOperations.Substract:
                    var cut = new BRepAlgoAPICut(firstShape, secondShape);
                    if (!cut.IsDone)
                        return false;
                    if ((cut.HasGenerated == false) && (cut.HasModified == false))
                        return false;
                    Shape = cut.Shape;
                    break;
                case (int) BooleanOperations.Add:
                    var fuse = new BRepAlgoAPIFuse(firstShape, secondShape);
                    if (!fuse.IsDone)
                        return false;
                    if ((fuse.HasGenerated == false) && (fuse.HasModified == false))
                        return false;
                    Shape = fuse.Shape;
                    break;
                case (int) BooleanOperations.Intersect:
                    var common = new BRepAlgoAPICommon(firstShape, secondShape);
                    if (!common.IsDone)
                        return false;
                    if ((common.HasGenerated == false) && (common.HasModified == false))
                        return false;
                    Shape = common.Shape;
                    break;
            }
            return true;
        }

        #region Nested type: BooleanOperations

        private enum BooleanOperations
        {
            Substract,
            Add,
            Intersect,
        }

        #endregion
    }
}