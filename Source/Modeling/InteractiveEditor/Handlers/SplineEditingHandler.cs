#region Usings

using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;


#endregion

namespace InteractiveEditor.Handlers
{
    public class SplineEditingHandler : SplineBasedEditingHandler
    {
        public override int EditingPointsCount()
        {
            return Dependency.Count;
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
                               Location = (Dependency[index].TransformedPoint3D.GpPnt)
                           };
            return axis;
        }

        public override void DisplayHandles()
        {
            base.DisplayHandles();
            var legs = Dependency.Count - 1;
            for (var i = 0; i < legs; i++)
                DrawSplineLeg(i);
        }

        private void DrawSplineLeg(int i)
        {
            PreviewLine(i);
        }

        public override void UpdatePointPosition(int index, Mouse3DPosition vertex)
        {
            Document.Revert();
            DisplayHandles();
            Dependency[index].TransformedPoint3D = vertex.Point;
        }
    }
}