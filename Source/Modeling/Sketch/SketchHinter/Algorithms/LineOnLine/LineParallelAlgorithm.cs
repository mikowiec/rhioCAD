#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.gp;


#endregion

namespace SketchHinter.Algorithms.LineOnLine
{
    internal class LineParallelAlgorithm : LineOnLineHinterAlgorithmBase
    {
        public override void OnRegister()
        {
            FunctionName = Constraint2DNames.ParallelFunction;
            base.OnRegister();
        }

        protected override bool LinesAxisMatch(gpDir axisDir, gpDir direction, double angleRange)
        {
            return axisDir.IsParallel(direction, angleRange);
        }
    }
}