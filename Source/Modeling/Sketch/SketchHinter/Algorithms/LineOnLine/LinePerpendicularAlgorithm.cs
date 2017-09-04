#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.gp;

#endregion

namespace SketchHinter.Algorithms.LineOnLine
{
    internal class LinePerpendicularAlgorithm : LineOnLineHinterAlgorithmBase
    {
        public override void OnRegister()
        {
            FunctionName = Constraint2DNames.PerpendicularFunction;
            base.OnRegister();
        }

        protected override bool LinesAxisMatch(gpDir axisDir, gpDir direction, double angleRange)
        {
            return axisDir.IsNormal(direction, angleRange);
        }
    }
}