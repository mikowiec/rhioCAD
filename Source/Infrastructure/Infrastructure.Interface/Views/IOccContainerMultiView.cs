#region Usings

using System;
using System.Windows.Forms;

#endregion

namespace Naro.Infrastructure.Interface.Views
{
    public enum LayoutTypes
    {
        None = 0,
        Single,
        TwoVertical,
        TwoHorizontal,
        ThreeVertical,
        ThreeHorizontal,
        FourView
    }

    /// <summary>
    ///   Defines the operation needed to implement a MultiView window
    /// </summary>
    public interface IOccContainerMultiView
    {
        LayoutTypes ViewLayout { get; set; }

        Int32 VisibleViewCount { get; }

        Int32 TotalViewCount { get; }
        IContextMenuManager ContextManager { get; }

        Control GetView(Int32 viewNumber);
        Control GetActiveView();
        Int32 GetActiveViewNumber();
        void LayoutSplit(LayoutTypes newLayoutView);
        bool ActiveControlFocused();
    }
}