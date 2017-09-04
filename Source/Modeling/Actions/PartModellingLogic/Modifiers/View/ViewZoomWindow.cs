#region Usings

using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Actions;
using NaroPipes.Constants;
using PartModellingLogic.Inputs.Naro.Pipes;

#endregion

namespace PartModellingLogic.Modifiers.View
{
    /// <summary>
    ///   Makes zoom on an area selected by the user.
    /// </summary>
    public class ViewZoomWindow : HandlingAction3D
    {
        public ViewZoomWindow() : base(ModifierNames.ViewZoomWindow)
        {
            DependsOn(InputNames.View3DRectanglePipe, OnSelectionUpdates);
        }

        private void OnSelectionUpdates(DataPackage data)
        {
            var position = data.Get<View3DRectanglePipe.RectanglePosition>();
            View.WindowFitAll(position.X1,
                              position.Y1,
                              position.X2,
                              position.Y2);

            UpdateOccView();
        }

        private void UpdateOccView()
        {
            Inputs[InputNames.View].Send(NotificationNames.RefreshView);
        }
    }
}