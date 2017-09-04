#region Usings

using System;
using NaroConstants.Names;
using NaroCppCore.Occ.BRepOffset;
using NaroCppCore.Occ.BRepOffsetAPI;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.TopoDS;
using OccCode;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    public class Offset3DFunction : FunctionBase
    {
        public Offset3DFunction() : base(FunctionNames.Offset3D)
        {
            // Reference shape on which offset applies
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // Offset length
            Dependency.AddAttributeType(InterpreterNames.Real);
        }

        public override bool Execute()
        {
            // Get the extrusion referenece shape, height and extrusion type
            var sourceShape = Dependency[0].ReferedShape;
            var offsetLength = Dependency[1].Real;

            // Don't allow 0 offset
            if (Math.Abs(offsetLength) < Precision.Confusion)
            {
                return false;
            }

            //var resultShape = OffsetShape(sourceShape, offsetLength);

            //if ((resultShape == null) || (resultShape.IsNull))
            //    return false;

           // Shape = resultShape;

            return true;
        }

        /// <summary>
        ///   Offsets a solid shape
        /// </summary>
        /// <param name = "sourceShape"></param>
        /// <param name = "offsetValue"></param>
        /// <returns></returns>
        //private static TopoDSShape OffsetShape(TopoDSShape sourceShape, double offsetValue)
        //{
        //    //var offset = new BRepOffsetMakeOffset();
        //    //offset.Initialize(sourceShape, offsetValue, Precision.Confusion, BRepOffsetMode.BRepOffset_Skin,
        //    //                  true, false, GeomAbsJoinType.GeomAbs_Intersection);
        //    //var faces = GeomUtils.ExtractFaces(sourceShape);
        //    //if (faces.Count <= 0)
        //    //{
        //    //    return null;
        //    //}

        //    //offset.MakeThickSolid();
        //    //return offset.IsDone ? offset.Shape : null;
        //}
    }
}