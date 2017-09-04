#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using OccCode;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Solver
{
    public class SolverLineMarker : DottedLineCommon
    {
        public SolverLineMarker()
            : base(FunctionNames.SolverLineMarker)
        {
        }

        public override bool Execute()
        {
            if (Dependency[1].TransformedPoint3D.IsEqual(new Point3D(0, 0, 0)))
                return false;

            var Line = new AISLine(new GeomCartesianPoint(Dependency[0].TransformedPoint3D.GpPnt),
                                           new GeomCartesianPoint(Dependency[1].TransformedPoint3D.GpPnt));
            var helperLine = OccShapeCreatorCode.BuildDottedLine(Line);

            Interactive = helperLine;
            return true;
        }
    }
}