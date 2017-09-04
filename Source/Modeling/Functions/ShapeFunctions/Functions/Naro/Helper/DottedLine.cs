#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.Prs3d;
using NaroCppCore.Occ.Quantity;

using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Helper
{
    public class DottedLine : FunctionBase
    {
        public DottedLine()
            : base(FunctionNames.DottedLine)
        {
            Dependency.AddAttributeType(InterpreterNames.Point3D);
            Dependency.AddAttributeType(InterpreterNames.Point3D);
        }

        public override bool Execute()
        {
            var first = Dependency[0].TransformedPoint3D;
            var second = Dependency[1].TransformedPoint3D;

            if (first.IsEqual(second))
                return false;
            var helperLine = new AISLine(new GeomCartesianPoint(first.GpPnt),
                                            new GeomCartesianPoint(second.GpPnt));
            var drawer = helperLine.Attributes;
            var lineAspect = new Prs3dLineAspect(QuantityNameOfColor.Quantity_NOC_RED,
                                                    AspectTypeOfLine.Aspect_TOL_DASH, 0.5);
            drawer.LineAspect=lineAspect;


            Interactive = helperLine;
            return true;
        }
    }
}