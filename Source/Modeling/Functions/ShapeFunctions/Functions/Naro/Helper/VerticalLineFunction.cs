#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Prs3d;
using NaroCppCore.Occ.Quantity;

using ShapeFunctionsInterface.Functions;

#endregion

namespace ShapeFunctions.Functions.Naro.Helper
{
    public class VerticalLineFunction : FunctionBase
    {
        public VerticalLineFunction() : base(FunctionNames.VerticalLine)
        {
            Dependency.AddAttributeType(InterpreterNames.Point3D);
        }

        public override bool Execute()
        {
            var point = Dependency[0].TransformedPoint3D;
            var firstPoint = point;
            var secondPoint = point;
            firstPoint.Y += 10000;
            secondPoint.Y -= 10000;

            var line = new GeomLine(firstPoint.GpPnt,
                                       new gpDir(new gpVec(secondPoint.X, secondPoint.Y, secondPoint.Z)));
            var helperLine = new AISLine(line);
            var drawer = helperLine.Attributes;
            drawer.LineAspect= (new Prs3dLineAspect(QuantityNameOfColor.Quantity_NOC_GRAY70,
                                                        AspectTypeOfLine.Aspect_TOL_DOT, 0.5));
            helperLine.Transparency=0.8;

            Interactive = helperLine;
            return true;
        }
    }
}