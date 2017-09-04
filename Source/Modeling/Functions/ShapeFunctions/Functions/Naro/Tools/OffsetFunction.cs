#region Usings

using System;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopAbs;
using OccCode;

using ShapeFunctionsInterface.Functions;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    public class OffsetFunction : FunctionBase
    {
        public OffsetFunction() : base(FunctionNames.Offset)
        {
            // Reference shapes on which offset applies
            //Dependency.AddAttributeType(InterpreterNames.ReferenceList);
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Offset length
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            // Get the extrusion referenece shape, height and extrusion type
            var offsetShape = Dependency[0].ReferedShape;
            var offsetLength = Dependency[1].Real;

            // Don't allow 0 offset
            if (Math.Abs(offsetLength) < Precision.Confusion)
            {
                return false;
            }

            //TopoDSShape resultShape = NodeUtils.GenerateWireOffset(offsetShapes, offsetLength);
            // ! Currently only offset on 2D closed shapes of type Face can be made
            if (offsetShape.ShapeType != TopAbsShapeEnum.TopAbs_FACE)
            {
                return false;
            }

            var face = TopoDS.Face(offsetShape);
            var resultShape = GeomUtils.GenerateFaceOffset(face, offsetLength);

            if ((resultShape == null) || (resultShape.IsNull))
            {
                return false;
            }

            var wire = TopoDS.Wire(resultShape);
            var offsetFace = new BRepBuilderAPIMakeFace(wire, false).Face;
            if (offsetFace.IsNull)
            {
                return false;
            }

            // Set the result in the NamedShapeInterpreter and make the shape visible
            Shape = offsetFace;

            return true;
        }
    }
}