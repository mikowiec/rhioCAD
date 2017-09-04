#region Usings

using System.Windows.Controls;
using System.Windows.Input;

#endregion

namespace PartModellingUi.Layout
{
    public class AirspaceOverlay : Decorator
    {
        //private Window transparentInputWindow;
        //private Window rootWindow;

        //public AirspaceOverlay()
        //{
        //transparentInputWindow = new Window();

        ////Make the window itself transparent, with no style.
        //transparentInputWindow.Background = Brushes.Transparent;
        //transparentInputWindow.AllowsTransparency = true;
        //transparentInputWindow.WindowStyle = WindowStyle.None;

        ////Hide from taskbar until it becomes a child
        //transparentInputWindow.ShowInTaskbar = false;

        ////HACK: This window and it's child controls should never have focus, as window styling of an invisible window 
        ////will confuse user.
        //transparentInputWindow.Focusable = false;
        //transparentInputWindow.PreviewMouseDown += new MouseButtonEventHandler(transparentInputWindow_PreviewMouseDown);
        //}

        private void TransparentInputWindowPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //rootWindow.Focus();
        }

        //public object OverlayChild
        //{
        //    get
        //    {
        //        if (transparentInputWindow != null)
        //        {
        //            return transparentInputWindow.Content;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    set
        //    {
        //        if (transparentInputWindow != null)
        //        {
        //            transparentInputWindow.Content=value;
        //        }
        //    }
        //}

        //protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        //{
        //    base.OnRenderSizeChanged(sizeInfo);
        //    UpdateWindow();
        //}

        //protected override void OnRender(DrawingContext drawingContext)
        //{
        //    base.OnRender(drawingContext);
        //    if (transparentInputWindow.Visibility != Visibility.Visible)
        //    {
        //        //UpdateWindow();
        //        //transparentInputWindow.Show();
        //        //var parent = GetParentWindow(this);
        //        //rootWindow = GetRootParentWindow(parent);
        //        //transparentInputWindow.Owner = rootWindow;
        //        //rootWindow.LocationChanged += new EventHandler(parent_LocationChanged);
        //    }
        //}

        //private void parent_LocationChanged(object sender, EventArgs e)
        //{
        //    UpdateWindow();
        //}

        //private Window GetRootParentWindow(DependencyObject o)
        //{
        //    DependencyObject parent = VisualTreeHelper.GetParent(o);
        //    if (parent == null)
        //    {
        //        FrameworkElement fe = o as FrameworkElement;
        //        if (fe != null)
        //        {
        //            if (fe is Window)
        //            {
        //                return fe as Window;
        //            }
        //            else if (fe.Parent != null)
        //            {
        //                return GetRootParentWindow(fe.Parent);
        //            }
        //        }
        //        throw new ApplicationException("A window parent could not be found for " + o.ToString());
        //    }
        //    else
        //    {
        //        return GetRootParentWindow(parent);
        //    }
        //}

        //private DocumentPane GetParentWindow(DependencyObject o)
        //{
        //    DependencyObject parent = VisualTreeHelper.GetParent(o);
        //    if (parent == null)
        //    {
        //        throw new ApplicationException("A window parent could not be found for " + o.ToString());
        //    }
        //    if (parent is AvalonDock.DocumentPane)
        //    {
        //        return parent as AvalonDock.DocumentPane;
        //    }
        //    else
        //    {
        //        return GetParentWindow(parent);
        //    }
        //}

        private void UpdateWindow()
        {
            //var parent = GetParentWindow(this);

            //transparentInputWindow.Left = parent.SurfaceRectangle.Size.Height + parent.SurfaceRectangle.TopLeft.Y - 5;
            //transparentInputWindow.Top = parent.SurfaceRectangle.Size.Width + parent.SurfaceRectangle.TopLeft.X - 5;
            //transparentInputWindow.Width = parent.SurfaceRectangle.Size.Width;
            //transparentInputWindow.Height = parent.SurfaceRectangle.Size.Height;
        }
    }
}