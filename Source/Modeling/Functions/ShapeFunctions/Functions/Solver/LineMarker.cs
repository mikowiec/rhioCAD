#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using OccCode;


#endregion

namespace ShapeFunctions.Functions.Solver
{
    public class LineMarker : DottedLineCommon
    {
        public LineMarker()
            : base(FunctionNames.LineMarker)
        {
        }

        public override bool Execute()
        {
            var position = Dependency[0].TransformedPoint3D;
            var direction = new gpDir(Dependency[1].TransformedPoint3D.GpPnt.XYZ);

            var line = new GeomLine(new gpLin(position.GpPnt, direction));
            var helperLine = OccShapeCreatorCode.BuildDottedLine(line);

            Interactive = helperLine;
            return true;
        }
    }
}