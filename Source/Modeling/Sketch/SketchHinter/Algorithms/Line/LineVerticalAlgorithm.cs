#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.gp;


#endregion

namespace SketchHinter.Algorithms.Line
{
    internal class LineVerticalAlgorithm : LineParallelAxisHinterAlgorithm
    {
        public LineVerticalAlgorithm()
            : base(Constraint2DNames.VerticalFunction, gp.OY.Direction)
        {
        }
    }
}