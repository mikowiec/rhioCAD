#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.gp;


#endregion

namespace SketchHinter.Algorithms.Line
{
    internal class LineHorizontalAlgorithm : LineParallelAxisHinterAlgorithm
    {
        public LineHorizontalAlgorithm()
            : base(Constraint2DNames.HorizontalFunction, gp.OX.Direction)
        {
        }
    }
}