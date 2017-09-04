#region Usings

using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;


#endregion

namespace InteractiveEditor.Handlers
{
    public class SplinePathEditingHandler : SplineBasedEditingHandler
    {
        public override int EditingPointsCount()
        {
            return Dependency[0].Integer;
        }

        public override string GetHandleTypeAtIndex(int index)
        {
            return FunctionNames.BoxEditingHandle;
        }

        public override gpAx2 GetPointLocation(int index)
        {
            var axis = new gpAx2
                           {
                               Direction = (gp.OZ.Direction),
                               Location = (Dependency[index + 1].TransformedPoint3D.GpPnt)
                           };
            return axis;
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            Document.Revert();
            DisplayHandles();
            Dependency[index + 1].TransformedPoint3D = vertex.Point;
        }

        public override void DisplayHandles()
        {
            base.DisplayHandles();
            var legs = Dependency[0].Integer/3;
            for (var i = 0; i < legs; i++)
                DrawSplineLeg(i);
        }

        private void DrawSplineLeg(int i)
        {
            var firstIndex = 1 + i*3;
            PreviewLine(firstIndex);
            PreviewLine(firstIndex + 2);
        }
    }
}