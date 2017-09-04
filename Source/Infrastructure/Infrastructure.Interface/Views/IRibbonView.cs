#region Usings

using System.Windows.Controls;

#endregion

namespace Naro.Infrastructure.Interface.Views
{
    public interface IRibbonView
    {
        Control RibbonControl { get; }
    }
}