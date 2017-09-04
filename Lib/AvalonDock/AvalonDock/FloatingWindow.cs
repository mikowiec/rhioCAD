//Copyright (c) 2007-2010, Adolfo Marinucci
//All rights reserved.

//Redistribution and use in source and binary forms, with or without modification, 
//are permitted provided that the following conditions are met:
//
//* Redistributions of source code must retain the above copyright notice, 
//  this list of conditions and the following disclaimer.
//* Redistributions in binary form must reproduce the above copyright notice, 
//  this list of conditions and the following disclaimer in the documentation 
//  and/or other materials provided with the distribution.
//* Neither the name of Adolfo Marinucci nor the names of its contributors may 
//  be used to endorse or promote products derived from this software without 
//  specific prior written permission.
//
//THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
//AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
//WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
//IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
//INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, 
//PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) 
//HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, 
//OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, 
//EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

#region Usings

using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;

#endregion

namespace AvalonDock
{
    /// <summary>
    ///   Represents the base class for <see cref = "DockableFloatingWindow" /> and <see cref = "DocumentFloatingWindow" /> classes
    /// </summary>
    /// <remarks>
    ///   Provides base services for floating windows
    /// </remarks>
    public abstract class FloatingWindow : AvalonDockWindow
    {
        private readonly DockingManager _manager;

        static FloatingWindow()
        {
            ShowInTaskbarProperty.OverrideMetadata(typeof (FloatingWindow), new FrameworkPropertyMetadata(false));
            WindowStyleProperty.OverrideMetadata(typeof (FloatingWindow),
                                                 new FrameworkPropertyMetadata(WindowStyle.ToolWindow));

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(FloatingWindow), new FrameworkPropertyMetadata(typeof(FloatingWindow)));
        }


        internal FloatingWindow()
        {
            Loaded += OnLoaded;
            Unloaded += OnUnloaded;

            SizeChanged += FloatingWindow_SizeChanged;
        }

        internal FloatingWindow(DockingManager manager)
            : this()
        {
            //save manager ref
            _manager = manager;
        }

        internal DockingManager Manager
        {
            get { return _manager; }
        }

        public Pane HostedPane
        {
            get { return Content as Pane; }
        }

        #region ContentTitle

        /// <summary>
        ///   ContentTitle Read-Only Dependency Property
        /// </summary>
        private static readonly DependencyPropertyKey ContentTitlePropertyKey
            = DependencyProperty.RegisterReadOnly("ContentTitle", typeof (object), typeof (FloatingWindow),
                                                  new FrameworkPropertyMetadata((object) null));

        public static readonly DependencyProperty ContentTitleProperty
            = ContentTitlePropertyKey.DependencyProperty;

        /// <summary>
        ///   Gets the ContentTitle property.  This dependency property 
        ///   indicates title of the content currectly hosted in the floating window.
        /// </summary>
        public object ContentTitle
        {
            get { return GetValue(ContentTitleProperty); }
        }

        /// <summary>
        ///   Provides a secure method for setting the ContentTitle property.  
        ///   This dependency property indicates title of the content currectly hosted in the floating window.
        /// </summary>
        /// <param name = "value">The new value for the property.</param>
        protected void SetContentTitle(object value)
        {
            SetValue(ContentTitlePropertyKey, value);
        }


        private void UpdateContentTitle()
        {
            if (HostedPane == null)
                return;

            var cnt = HostedPane.SelectedItem as ManagedContent;
            if (cnt != null)
                SetContentTitle(cnt.Title);
        }

        #endregion

        private void FloatingWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (HostedPane != null)
            {
                foreach (ManagedContent c in HostedPane.Items)
                    c.FloatingWindowSize = new Size(Width, Height);

                ResizingPanel.SetEffectiveSize(HostedPane, new Size(Width, Height));
            }
        }

        //#region HostedPane

        ///// <summary>
        ///// HostedPane Read-Only Dependency Property
        ///// </summary>
        //private static readonly DependencyPropertyKey HostedPanePropertyKey
        //    = DependencyProperty.RegisterReadOnly("HostedPane", typeof(Pane), typeof(FloatingWindow),
        //        new FrameworkPropertyMetadata((Pane)null,
        //            new PropertyChangedCallback(OnHostedPaneChanged)));

        //public static readonly DependencyProperty HostedPaneProperty
        //    = HostedPanePropertyKey.DependencyProperty;

        ///// <summary>
        ///// Gets the HostedPane property.  This dependency property 
        ///// indicates the hosted pane contained into the floating window (an hosted pane can be of type <see cref="FloatingDocumentPane"/> or type <see cref="FloatingDockablePane"/>.
        ///// </summary>
        //public Pane HostedPane
        //{
        //    get { return (Pane)GetValue(HostedPaneProperty); }
        //}

        ///// <summary>
        ///// Provides a secure method for setting the HostedPane property.  
        ///// This dependency property indicates the hosted pane contained into the floating window (an hosted pane can be of type <see cref="FloatingDocumentPane"/> or type <see cref="FloatingDockablePane"/>.
        ///// </summary>
        ///// <param name="value">The new value for the property.</param>
        //protected void SetHostedPane(Pane value)
        //{
        //    SetValue(HostedPanePropertyKey, value);
        //}

        ///// <summary>
        ///// Handles changes to the HostedPane property.
        ///// </summary>
        //private static void OnHostedPaneChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    ((FloatingWindow)d).OnHostedPaneChanged(e);
        //}

        ///// <summary>
        ///// Provides derived classes an opportunity to handle changes to the HostedPane property.
        ///// </summary>
        //protected virtual void OnHostedPaneChanged(DependencyPropertyChangedEventArgs e)
        //{
        //}

        //#endregion

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
        }

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            base.OnContentChanged(oldContent, newContent);

            if (_manager != null)
            {
                _manager.RegisterFloatingWindow(this);
                _manager.RefreshContents();
            }

            UpdateContentTitle();
        }


        internal virtual void OnEndDrag()
        {
        }

        internal virtual void OnShowSelectionBox()
        {
        }

        internal virtual void OnHideSelectionBox()
        {
        }

        public abstract Pane ClonePane();

        internal void CheckContents()
        {
            if (HostedPane == null)
                return;

            var cntsToCheck = HostedPane.Items.Cast<ManagedContent>().ToArray();

            cntsToCheck.ForEach(cnt =>
                                    {
                                        if (cnt.Manager == null ||
                                            cnt.Manager != Manager ||
                                            (!cnt.Manager.DockableContents.Contains(cnt as DockableContent) &&
                                             !cnt.Manager.Documents.Contains(cnt as DocumentContent)))
                                            cnt.ContainerPane.RemoveContent(cnt);
                                    });
        }

        #region Enable/Disable window Close Button

        private const Int32 MF_BYPOSITION = 0x400;
        private const Int32 MF_ENABLED = 0x0000;
        private const Int32 MF_GRAYED = 0x0001;
        private const Int32 MF_DISABLED = 0x0002;

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetSystemMenu(
            IntPtr hWnd,
            Int32 bRevert
            );

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern int GetMenuItemCount(
            IntPtr hMenu
            );

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern int DrawMenuBar(
            IntPtr hWnd
            );

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern bool EnableMenuItem(
            IntPtr hMenu,
            Int32 uIDEnableItem,
            Int32 uEnable
            );

        private void EnableXButton()
        {
            var helper = new WindowInteropHelper(this);
            var hMenu = GetSystemMenu(helper.Handle, 0);

            var menuItemCount = GetMenuItemCount(hMenu);

            EnableMenuItem(hMenu, menuItemCount - 1, MF_BYPOSITION | MF_ENABLED);
            DrawMenuBar(helper.Handle);
        }

        private void DisableXButton()
        {
            var helper = new WindowInteropHelper(this);
            var hMenu = GetSystemMenu(helper.Handle, 0);

            var menuItemCount = GetMenuItemCount(hMenu);

            EnableMenuItem(hMenu, menuItemCount - 1, MF_BYPOSITION | MF_DISABLED | MF_GRAYED);
            DrawMenuBar(helper.Handle);
        }

        #endregion

        #region Non-Client area management

        protected const int WM_MOVE = 0x0003;
        protected const int WM_SIZE = 0x0005;
        protected const int WM_NCMOUSEMOVE = 0xa0;
        protected const int WM_NCLBUTTONDOWN = 0xA1;
        protected const int WM_NCLBUTTONUP = 0xA2;
        protected const int WM_NCLBUTTONDBLCLK = 0xA3;
        protected const int WM_NCRBUTTONDOWN = 0xA4;
        protected const int WM_NCRBUTTONUP = 0xA5;
        protected const int HTCAPTION = 2;
        protected const int SC_MOVE = 0xF010;
        protected const int WM_SYSCOMMAND = 0x0112;

        #region Load/Unload window events

        protected void OnLoaded(object sender, EventArgs e)
        {
            var wih = new WindowInteropWrapper(this);

            //wih.WindowActivating += (s, ce) => ce.Cancel = true;//prevent window activating
            wih.FilterMessage += FilterMessage;

            if (HostedPane.Items.Count > 0)
            {
                var cntHosted = HostedPane.Items[0] as ManagedContent;
                if (!cntHosted.IsCloseable)
                {
                    DisableXButton();
                }
            }
        }

        protected void OnUnloaded(object sender, EventArgs e)
        {
        }

        #endregion

        protected virtual void FilterMessage(object sender, FilterMessageEventArgs e)
        {
            if (e.Handled)
                return;

            if (Manager == null)
                return;

            switch (e.Msg)
            {
                case WM_SIZE:
                case WM_MOVE:
                    break;
                case WM_NCRBUTTONDOWN: //Right button click on title area -> show context menu
                    if (e.WParam.ToInt32() == HTCAPTION)
                    {
                        var x = (short) ((e.LParam.ToInt32() & 0xFFFF));
                        var y = (short) ((e.LParam.ToInt32() >> 16));
                        OpenContextMenu(null, new Point(x, y));
                        e.Handled = true;
                    }
                    break;
                case WM_NCRBUTTONUP: //set as handled right button click on title area (after showing context menu)
                    if (e.WParam.ToInt32() == HTCAPTION)
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        #endregion

        #region Floating/dockable window state

        /// <summary>
        ///   Redock contained <see cref = "ManagedContent" /> object to the <see cref = "DcokingManager" />
        /// </summary>
        public virtual void Dock()
        {
        }

        #endregion

        #region Move/Resize

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var resLeftAnchor = GetTemplateChild("PART_LeftAnchor") as Resizer;
            var resTopAnchor = GetTemplateChild("PART_TopAnchor") as Resizer;
            var resBottomAnchor = GetTemplateChild("PART_BottomAnchor") as Resizer;
            var resRightAnchor = GetTemplateChild("PART_RightAnchor") as Resizer;

            var resLeftTopAnchor = GetTemplateChild("PART_LeftTopAnchor") as Resizer;
            var resLeftBottomAnchor = GetTemplateChild("PART_LeftBottomAnchor") as Resizer;

            var resRightTopAnchor = GetTemplateChild("PART_RightTopAnchor") as Resizer;
            var resRightBottomAnchor = GetTemplateChild("PART_RightBottomAnchor") as Resizer;

            //Resizer resMoveAnchor = GetTemplateChild("PART_MoveAnchor") as Resizer;
            var resMoveAnchor = GetTemplateChild("PART_MoveAnchor") as Border;

            if (resLeftAnchor != null)
                resLeftAnchor.DragDelta += (s, e) =>
                                               {
                                                   var delta = Math.Max(MinWidth, Width - e.HorizontalChange) - Width;
                                                   Left -= delta;
                                                   Width += delta;
                                               };
            if (resRightAnchor != null)
                resRightAnchor.DragDelta += (s, e) =>
                                                {
                                                    var delta = Math.Max(MinWidth, Width + e.HorizontalChange) - Width;
                                                    Width += delta;
                                                };
            if (resTopAnchor != null)
                resTopAnchor.DragDelta += (s, e) =>
                                              {
                                                  var delta = Math.Max(MinHeight, Height - e.VerticalChange) - Height;
                                                  Top -= delta;
                                                  Height += delta;
                                              };
            if (resBottomAnchor != null)
                resBottomAnchor.DragDelta += (s, e) =>
                                                 {
                                                     var delta = Math.Max(MinHeight, Height + e.VerticalChange) - Height;
                                                     Height += delta;
                                                 };

            if (resLeftTopAnchor != null)
                resLeftTopAnchor.DragDelta += (s, e) =>
                                                  {
                                                      var delta = Math.Max(MinWidth, Width - e.HorizontalChange) - Width;
                                                      Left -= delta;
                                                      Width += delta;

                                                      delta = Math.Max(MinHeight, Height - e.VerticalChange) - Height;
                                                      Top -= delta;
                                                      Height += delta;
                                                  };
            if (resLeftBottomAnchor != null)
                resLeftBottomAnchor.DragDelta += (s, e) =>
                                                     {
                                                         var delta = Math.Max(MinWidth, Width - e.HorizontalChange) -
                                                                     Width;
                                                         Left -= delta;
                                                         Width += delta;

                                                         delta = Math.Max(MinHeight, Height + e.VerticalChange) - Height;
                                                         Height += delta;
                                                     };
            if (resRightTopAnchor != null)
                resRightTopAnchor.DragDelta += (s, e) =>
                                                   {
                                                       var delta = Math.Max(MinWidth, Width + e.HorizontalChange) -
                                                                   Width;
                                                       Width += delta;

                                                       delta = Math.Max(MinHeight, Height - e.VerticalChange) - Height;
                                                       Top -= delta;
                                                       Height += delta;
                                                   };
            if (resRightBottomAnchor != null)
                resRightBottomAnchor.DragDelta += (s, e) =>
                                                      {
                                                          var delta = Math.Max(MinWidth, Width + e.HorizontalChange) -
                                                                      Width;
                                                          Width += delta;

                                                          delta = Math.Max(MinHeight, Height + e.VerticalChange) -
                                                                  Height;
                                                          Height += delta;
                                                      };

            if (resMoveAnchor != null)
            {
                var isMouseDown = false;
                var ptStartDrag = new Point();
                resMoveAnchor.MouseLeftButtonDown += (s, e) =>
                                                         {
                                                             isMouseDown = true;
                                                             ptStartDrag = e.GetPosition(s as IInputElement);
                                                             resMoveAnchor.CaptureMouse();
                                                         };

                resMoveAnchor.MouseMove += (s, e) =>
                                               {
                                                   if (isMouseDown && resMoveAnchor.IsMouseCaptured)
                                                   {
                                                       var ptMouseMove = e.GetPosition(s as IInputElement);
                                                       if (Math.Abs(ptMouseMove.X - ptStartDrag.X) >
                                                           SystemParameters.MinimumHorizontalDragDistance ||
                                                           Math.Abs(ptMouseMove.Y - ptStartDrag.Y) >
                                                           SystemParameters.MinimumVerticalDragDistance)
                                                       {
                                                           isMouseDown = false;
                                                           resMoveAnchor.ReleaseMouseCapture();
                                                           HandleMove();
                                                       }
                                                   }
                                               };

                resMoveAnchor.MouseLeftButtonUp += (s, e) =>
                                                       {
                                                           isMouseDown = false;
                                                           resMoveAnchor.ReleaseMouseCapture();
                                                       };
            }

            var pupupButton = GetTemplateChild("PART_ShowContextMenuButton") as FrameworkElement;

            if (pupupButton != null)
                pupupButton.MouseLeftButtonDown +=
                    (s, e) => { e.Handled = OpenContextMenu(s as Border, e.GetPosition(s as IInputElement)); };

            var titleAnchor = GetTemplateChild("PART_MoveAnchor") as FrameworkElement;
            if (titleAnchor != null)
                titleAnchor.MouseRightButtonDown +=
                    (s, e) => { e.Handled = OpenContextMenu(s as Border, e.GetPosition(s as IInputElement)); };


            base.OnApplyTemplate();
        }

        protected virtual bool OpenContextMenu(UIElement popupButton, Point ptMouse)
        {
            return false;
        }

        protected virtual void HandleMove()
        {
            var mousePosition = PointToScreen(Mouse.GetPosition(null));
            var clickPoint = this.TransformToDeviceDPI(mousePosition);
            if (!Manager.DragPaneServices.IsDragging)
                Manager.Drag(this, clickPoint, new Point(clickPoint.X - Left, clickPoint.Y - Top));
        }

        #endregion

        #region Active Content Management

        private ManagedContent lastActiveContent;

        protected override void OnActivated(EventArgs e)
        {
            if (Manager != null)
            {
                lastActiveContent = Manager.ActiveContent;
                Manager.ActiveContent = HostedPane.SelectedItem as ManagedContent;
            }

            base.OnActivated(e);
        }

        protected override void OnDeactivated(EventArgs e)
        {
            if (Manager != null && lastActiveContent != null)
            {
                Manager.ActiveContent = lastActiveContent;
            }
            base.OnDeactivated(e);
        }

        #endregion

        #region IsClosing Flag Management

        protected bool ForcedClosing { get; private set; }

        internal bool IsClosing { get; private set; }

        /// <summary>
        ///   Closes the window regardless of result of contents CanClose method call
        /// </summary>
        /// <param name = "force"></param>
        internal void Close(bool force)
        {
            ForcedClosing = force;
            base.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            IsClosing = true;

            if (HostedPane.Items.Count > 0)
            {
                var contentsToClose = HostedPane.Items.Cast<ManagedContent>().ToArray();
                foreach (var cntToClose in contentsToClose)
                {
                    //if even a content can't close than cancel the close process, but continue try closing other contents
                    if (!cntToClose.Close())
                    {
                        //forced closing continues the window close process
                        if (!ForcedClosing)
                            e.Cancel = true;
                    }
                }
            }

            if (e.Cancel)
                IsClosing = false;
            else if (_manager != null)
            {
                _manager.UnregisterFloatingWindow(this);
            }

            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            IsClosing = false;
            base.OnClosed(e);
        }

        #endregion
    }
}