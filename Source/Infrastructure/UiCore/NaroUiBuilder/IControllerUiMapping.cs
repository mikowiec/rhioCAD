#region Usings

using System.Windows.Controls;

#endregion

namespace NaroUiBuilder
{
    public interface IControllerUiMapping
    {
        void SetUiBuilder(UiBuilder uiBuilder);
        Control GetControl();
    }
}