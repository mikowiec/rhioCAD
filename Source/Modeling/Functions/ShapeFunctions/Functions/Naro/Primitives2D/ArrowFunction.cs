#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Prs3d;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.TopAbs;
using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Primitives2D
{
    public class ArrowFunction : FunctionBase
    {
        public ArrowFunction()
            : base(FunctionNames.Arrow)
        {
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            Dependency.AddAttributeType(InterpreterNames.Integer);
        }


        /// <summary>
        ///   Assigns a different color line to different orientations
        /// </summary>
        /// <param name = "orientation"></param>
        /// <returns></returns>
        private static QuantityNameOfColor ColorOrientation(TopAbsOrientation orientation)
        {
            switch (orientation)
            {
                case TopAbsOrientation.TopAbs_FORWARD:
                    return QuantityNameOfColor.Quantity_NOC_RED;
                case TopAbsOrientation.TopAbs_REVERSED:
                    return QuantityNameOfColor.Quantity_NOC_BLUE1;
                case TopAbsOrientation.TopAbs_EXTERNAL:
                    return QuantityNameOfColor.Quantity_NOC_ROSYBROWN;
                case TopAbsOrientation.TopAbs_INTERNAL:
                    return QuantityNameOfColor.Quantity_NOC_ORANGE;
            }

            return QuantityNameOfColor.Quantity_NOC_RED;
        }


        public override bool Execute()
        {
            var firstPoint = Dependency[0].TransformedPoint3D;
            var secondPoint = Dependency[1].TransformedPoint3D;
            var colorOrientation = Dependency[2].Integer;
            var color = QuantityNameOfColor.Quantity_NOC_RED;
            var aEdge = new BRepBuilderAPIMakeEdge(firstPoint.GpPnt, secondPoint.GpPnt).Edge;
            var wire = new BRepBuilderAPIMakeWire(aEdge).Wire;
            var temporaryShape = new AISShape(wire);
            var drawer = temporaryShape.Attributes;
            //need fixed the coloring
       //     drawer.WireAspect = (new Prs3dLineAspect(color, AspectTypeOfLine.Aspect_TOL_DOT,3));

            Interactive = temporaryShape;
            return true;
        }
    }
}