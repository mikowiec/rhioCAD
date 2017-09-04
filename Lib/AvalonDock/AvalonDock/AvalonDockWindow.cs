#region Usings

using System.Windows;

#endregion

namespace AvalonDock
{
    public class AvalonDockWindow : Window
    {
        static AvalonDockWindow()
        {
            ShowInTaskbarProperty.OverrideMetadata(typeof (AvalonDockWindow), new FrameworkPropertyMetadata(false));
        }

        internal AvalonDockWindow()
        {
        }
    }
}