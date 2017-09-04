#region Usings

using System;
using System.Drawing;
using System.Windows.Forms;
using Naro.Infrastructure.Interface.Views;
using TreeData.Capabilities;

#endregion

namespace PartModellingUi.Views
{
    public sealed partial class MultiView : UserControl, IOccContainerMultiView
    {
        /// <summary>
        ///   The presenter used by this view.
        /// </summary>
        public readonly MultiViewPresenter Presenter = new MultiViewPresenter();

        private Control _currentActiveView;
        private LayoutTypes _viewLayout = LayoutTypes.Single;

        public MultiView()
        {
            InitializeComponent();
            _currentActiveView = topLeftCustomControl;

            // Add mouse wheel events
            //multiviewTableLayoutPanel.MouseWheel += new MouseEventHandler(MouseWheelEvent);
            topLeftCustomControl.MouseWheel += MouseWheelEvent;
            bottomLeftCustomControl.MouseWheel += MouseWheelEvent;
            topRightCustomControl.MouseWheel += MouseWheelEvent;
            bottomRightCustomControl.MouseWheel += MouseWheelEvent;

            LayoutSplit(_viewLayout);
            CreateContextMenu();
        }

        #region IOccContainerMultiView Members

        public IContextMenuManager ContextManager { get; private set; }


        // implements the IMultiview interface
        public LayoutTypes ViewLayout
        {
            get { return _viewLayout; }
            set { _viewLayout = value; }
        }

        public Int32 VisibleViewCount
        {
            get
            {
                switch (_viewLayout)
                {
                    case LayoutTypes.Single:
                        return 1;
                    case LayoutTypes.TwoHorizontal:
                    case LayoutTypes.TwoVertical:
                        return 2;
                    case LayoutTypes.ThreeHorizontal:
                    case LayoutTypes.ThreeVertical:
                        return 3;
                    case LayoutTypes.FourView:
                        return 4;
                    default:
                        return 0;
                }
            }
        }

        public Int32 TotalViewCount
        {
            get { return 4; }
        }

        /// <summary>
        ///   Returns a handle to one of the four controls displayed on the form.
        /// </summary>
        /// <param name = "viewNumber">The number of the custom control to which the handle is needed.</param>
        /// <returns></returns>
        public Control GetView(Int32 viewNumber)
        {
            if ((viewNumber < 0) || (viewNumber > TotalViewCount))
            {
                return null;
            }

            switch (viewNumber)
            {
                case 0:
                    return topLeftCustomControl;
                case 1:
                    return topRightCustomControl;
                case 2:
                    return bottomLeftCustomControl;
                case 3:
                    return bottomRightCustomControl;
                default:
                    return null;
            }
        }

        /// <summary>
        ///   Returns true if the active user control has focus.
        /// </summary>
        /// <returns></returns>
        public bool ActiveControlFocused()
        {
            return _currentActiveView.Focused;
        }

        /// <summary>
        ///   Returns the View currently selected.
        /// </summary>
        /// <returns></returns>
        public Control GetActiveView()
        {
            return _currentActiveView;
        }

        public Int32 GetActiveViewNumber()
        {
            var activeViewNo = -1;
            if (_currentActiveView == topLeftCustomControl)
                activeViewNo = 0;
            else if (_currentActiveView == topRightCustomControl)
                activeViewNo = 1;
            else if (_currentActiveView == bottomLeftCustomControl)
                activeViewNo = 2;
            else if (_currentActiveView == bottomRightCustomControl)
                activeViewNo = 3;

            return activeViewNo;
        }

        public void LayoutSplit(LayoutTypes newLayoutView)
        {
            // Temporary disabled the layout split with more than one view
            // Also in the MultiViewWorkItemController only onew View3d is built
            if (newLayoutView != LayoutTypes.Single)
            {
                return;
            }

            multiviewTableLayoutPanel.Controls.Clear();

            multiviewTableLayoutPanel.SetRowSpan(topLeftCustomControl, 1);
            multiviewTableLayoutPanel.SetColumnSpan(topLeftCustomControl, 1);
            multiviewTableLayoutPanel.SetRowSpan(topRightCustomControl, 1);
            multiviewTableLayoutPanel.SetColumnSpan(topRightCustomControl, 1);
            multiviewTableLayoutPanel.SetRowSpan(bottomLeftCustomControl, 1);
            multiviewTableLayoutPanel.SetColumnSpan(bottomLeftCustomControl, 1);
            multiviewTableLayoutPanel.SetRowSpan(bottomRightCustomControl, 1);
            multiviewTableLayoutPanel.SetColumnSpan(bottomRightCustomControl, 1);

            multiviewTableLayoutPanel.Controls.Add(topLeftCustomControl, 0, 0);

            switch (newLayoutView)
            {
                case LayoutTypes.Single:
                    {
                        multiviewTableLayoutPanel.SetRowSpan(topLeftCustomControl, 2);
                        multiviewTableLayoutPanel.SetColumnSpan(topLeftCustomControl, 2);
                        _currentActiveView = topLeftCustomControl;
                    }
                    break;
                case LayoutTypes.TwoVertical:
                    {
                        multiviewTableLayoutPanel.Controls.Add(topRightCustomControl, 1, 0);
                        multiviewTableLayoutPanel.SetRowSpan(topLeftCustomControl, 2);
                        multiviewTableLayoutPanel.SetRowSpan(topRightCustomControl, 2);
                        if (_currentActiveView == bottomLeftCustomControl)
                        {
                            _currentActiveView = topLeftCustomControl;
                        }
                        if (_currentActiveView == bottomRightCustomControl)
                        {
                            _currentActiveView = topRightCustomControl;
                        }
                    }
                    break;
                case LayoutTypes.TwoHorizontal:
                    {
                        multiviewTableLayoutPanel.Controls.Add(bottomLeftCustomControl, 0, 1);
                        multiviewTableLayoutPanel.SetColumnSpan(topLeftCustomControl, 2);
                        multiviewTableLayoutPanel.SetColumnSpan(bottomLeftCustomControl, 2);
                        if (_currentActiveView == topRightCustomControl)
                        {
                            _currentActiveView = topLeftCustomControl;
                        }
                        if (_currentActiveView == bottomRightCustomControl)
                        {
                            _currentActiveView = bottomLeftCustomControl;
                        }
                    }
                    break;
                case LayoutTypes.ThreeVertical:
                    {
                        multiviewTableLayoutPanel.Controls.Add(topRightCustomControl, 1, 0);
                        multiviewTableLayoutPanel.Controls.Add(bottomRightCustomControl, 1, 1);
                        multiviewTableLayoutPanel.SetRowSpan(topLeftCustomControl, 2);
                        if (_currentActiveView == bottomLeftCustomControl)
                        {
                            _currentActiveView = topLeftCustomControl;
                        }
                    }
                    break;
                case LayoutTypes.ThreeHorizontal:
                    {
                        multiviewTableLayoutPanel.Controls.Add(bottomLeftCustomControl, 0, 1);
                        multiviewTableLayoutPanel.Controls.Add(bottomRightCustomControl, 1, 1);
                        multiviewTableLayoutPanel.SetColumnSpan(topLeftCustomControl, 2);
                        if (_currentActiveView == topRightCustomControl)
                        {
                            _currentActiveView = topLeftCustomControl;
                        }
                    }
                    break;
                case LayoutTypes.FourView:
                    {
                        multiviewTableLayoutPanel.Controls.Add(topRightCustomControl, 1, 0);
                        multiviewTableLayoutPanel.Controls.Add(bottomLeftCustomControl, 0, 1);
                        multiviewTableLayoutPanel.Controls.Add(bottomRightCustomControl, 1, 1);
                    }
                    break;
            }
            multiviewTableLayoutPanel.PerformLayout();
            multiviewTableLayoutPanel.Refresh();
            Presenter.ResizeHandler(this, null);
        }

        #endregion

        private void CreateContextMenu()
        {
            var globalCapabities = new CapabilitiesCollection();
            ContextManager = new ContextMenuManager(globalCapabities);
            ContextMenu = ContextManager.ContextMenu;
        }

        protected override void OnLoad(EventArgs e)
        {
            Presenter.OnViewReady();
            base.OnLoad(e);
        }

        private void ViewPaint(object sender, PaintEventArgs e)
        {
            // Notify listeners that the View or one of the Custom Controls needs repainting
            Presenter.ResizeHandler(sender, e);
        }

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            // Check if the active view changed
            if ((sender != _currentActiveView) &&
                ((sender == topLeftCustomControl) || (sender == topRightCustomControl) ||
                 (sender == bottomLeftCustomControl) || (sender == bottomRightCustomControl)))
            {
                _currentActiveView = sender as Control;

                multiviewTableLayoutPanel.Invalidate();
            }

            // Notify listeners that a mouse down event occured
            Presenter.MouseDownHandler(sender, e);

            // Set focus on the active view
            if (_currentActiveView != null)
                _currentActiveView.Focus();
        }

        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (sender == _currentActiveView)
                Presenter.MouseMoveHandler(sender, e);
        }

        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            if (sender == _currentActiveView)
                Presenter.MouseUpHandler(sender, e);
        }

        private void MouseWheelEvent(object sender, MouseEventArgs e)
        {
            if (sender == _currentActiveView)
                Presenter.MouseWheelHandler(sender, e);
        }

        private void ResizeEvent(object sender, EventArgs e)
        {
            Presenter.ResizeHandler(sender, e);
        }

        private void MultiviewTableCellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var rc = e.CellBounds;
            if (_currentActiveView == topLeftCustomControl && e.Row == 0 && e.Column == 0)
            {
                if (multiviewTableLayoutPanel.GetRowSpan(topLeftCustomControl) == 2)
                    rc.Height = e.ClipRectangle.Height - 2;

                if (multiviewTableLayoutPanel.GetColumnSpan(topLeftCustomControl) == 2)
                    rc.Width = e.ClipRectangle.Width - 2;
                rc.Inflate(-1, -1);
                e.Graphics.FillRectangle(Brushes.DarkRed, rc);
            }
            else if (_currentActiveView == topRightCustomControl && e.Row == 0 && e.Column == 1)
            {
                if (multiviewTableLayoutPanel.GetRowSpan(topRightCustomControl) == 2)
                    rc.Height = e.ClipRectangle.Height - 2;
                rc.Inflate(-1, -1);
                e.Graphics.FillRectangle(Brushes.DarkRed, rc);
            }
            else if (_currentActiveView == bottomLeftCustomControl && e.Row == 1 && e.Column == 0)
            {
                if (multiviewTableLayoutPanel.GetColumnSpan(bottomLeftCustomControl) == 2)
                    rc.Width = e.ClipRectangle.Width - 2;
                rc.Inflate(-1, -1);
                e.Graphics.FillRectangle(Brushes.DarkRed, rc);
            }
            else if (_currentActiveView == bottomRightCustomControl && e.Row == 1 && e.Column == 1)
            {
                rc.Inflate(-1, -1);
                e.Graphics.FillRectangle(Brushes.DarkRed, rc);
            }
        }
    }
}