#region Usings

using System.Windows.Forms;

#endregion

namespace Naro.Infrastructure.Interface.Views
{
    public delegate void OnClickHandler(string textButton);

    public interface IContextMenuManager
    {
        ContextMenu ContextMenu { get; }
        ImageBitmapCache ImageBitmapCache { get; set; }
        event OnClickHandler OnClick;

        void BuildShapeContext(string shapeName);
    }
}