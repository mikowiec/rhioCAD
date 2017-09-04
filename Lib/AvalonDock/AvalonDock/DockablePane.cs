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
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

#endregion

namespace AvalonDock
{
    /// <summary>
    ///   Anchor types
    /// </summary>
    public enum AnchorStyle
    {
        /// <summary>
        ///   No anchor style, while content is hosted in a <see cref = "DocumentPane" /> or a <see cref = "FloatingWindow" />
        /// </summary>
        None,
        /// <summary>
        ///   Top border anchor
        /// </summary>
        Top,
        /// <summary>
        ///   Left border anchor
        /// </summary>
        Left,
        /// <summary>
        ///   Bottom border anchor
        /// </summary>
        Bottom,
        /// <summary>
        ///   Right border anchor
        /// </summary>
        Right
    }


    /// <summary>
    ///   Defines a pane that can contain contents of type <see cref = "DockableContent" />
    /// </summary>
    /// <remarks>
    ///   Usually a <see cref = "DockablePane" /> is used to arrange a series of <see cref = "DockableContent" /> in TabControl like model.
    ///   A DockablePane can be redocked to a border of the parent <see cref = "DockingManager" />, can be floated in an external window and can be autohidden.
    ///   When docked into a docking manager the <see cref = "DockablePane.Anchor" /> property gives the border to which it's docked.
    ///   See <see cref = "DockablePaneCommands" /> to get commands that are supported by DockablePane objects.
    /// </remarks>
    /// <seealso cref = "DockableContent" />
    /// <seealso cref = "DockingManager" />
    public class DockablePane : Pane
    {
        /// <summary>
        ///   This guid is saved with the dockable content so that can be restored in the case is 
        ///   referenced by a dockable content
        /// </summary>
        internal Guid ID = Guid.NewGuid();

        #region Dependency properties

        // Using a DependencyProperty as the backing store for ShowTabs.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowTabsProperty =
            DependencyProperty.Register("ShowTabs", typeof (bool), typeof (DockablePane), new UIPropertyMetadata(true));


        // Using a DependencyProperty as the backing store for Anchor.  This enables animation, styling, binding, etc...
        public static readonly DependencyPropertyKey AnchorPropertyKey =
            DependencyProperty.RegisterAttachedReadOnly("Anchor", typeof (AnchorStyle), typeof (DockablePane),
                                                        new UIPropertyMetadata(AnchorStyle.None));

        public bool ShowTabs
        {
            get { return (bool) GetValue(ShowTabsProperty); }
            set { SetValue(ShowTabsProperty, value); }
        }

        public AnchorStyle Anchor
        {
            get { return (AnchorStyle) GetValue(AnchorPropertyKey.DependencyProperty); }
            internal set { SetValue(AnchorPropertyKey, value); }
        }


        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (_partHeader != null)
            {
                _partHeader.MouseDown += OnHeaderMouseDown;
                _partHeader.MouseMove += OnHeaderMouseMove;
                _partHeader.MouseUp += OnHeaderMouseUp;
                _partHeader.MouseEnter += OnHeaderMouseEnter;
                _partHeader.MouseLeave += OnHeaderMouseLeave;

                _partHeader.MouseRightButtonDown += (s, e) =>
                                                        {
                                                            if (_partHeader.ContextMenu == null)
                                                            {
                                                                FocusContent();
                                                                if (_partHeader.ContextMenu == null)
                                                                {
                                                                    Dispatcher.BeginInvoke(DispatcherPriority.Input,
                                                                                           new ThreadStart(
                                                                                               delegate
                                                                                                   {
                                                                                                       OpenOptionsMenu(
                                                                                                           null);
                                                                                                   }));

                                                                    e.Handled = true;
                                                                }
                                                            }
                                                        };
            }

            var optionsMenuPopupElement = GetTemplateChild("PART_ShowContextMenuButton") as Border;

            if (optionsMenuPopupElement != null)
            {
                optionsMenuPopupElement.MouseLeftButtonDown += (s, e) =>
                                                                   {
                                                                       OpenOptionsMenu(s as UIElement);
                                                                       e.Handled = true;
                                                                   };
            }
        }

        #region CanAutohide

        /// <summary>
        ///   CanAutohide Read-Only Dependency Property
        /// </summary>
        private static readonly DependencyPropertyKey CanAutohidePropertyKey
            = DependencyProperty.RegisterReadOnly("CanAutohide", typeof (bool), typeof (DockablePane),
                                                  new FrameworkPropertyMetadata(false));

        public static readonly DependencyProperty CanAutohideProperty
            = CanAutohidePropertyKey.DependencyProperty;

        /// <summary>
        ///   Gets the CanAutohide property.  This dependency property 
        ///   indicates if contents inside pane can be autohidden.
        /// </summary>
        public bool CanAutohide
        {
            get { return (bool) GetValue(CanAutohideProperty); }
        }

        /// <summary>
        ///   Provides a secure method for setting the CanAutohide property.  
        ///   This dependency property indicates if contents inside pane can be autohidden.
        /// </summary>
        /// <param name = "value">The new value for the property.</param>
        protected void SetCanAutohide(bool value)
        {
            SetValue(CanAutohidePropertyKey, value);
        }

        internal void UpdateCanAutohideProperty()
        {
            SetCanAutohide(
                Items.Cast<DockableContent>().All(c =>
                                                      {
                                                          var flag = c.State == DockableContentState.Docked ||
                                                                     c.State == DockableContentState.Document ||
                                                                     c.State == DockableContentState.AutoHide;

                                                          flag = flag &&
                                                                 ((c.DockableStyle & DockableStyle.AutoHide) > 0);
#if DEBUG
                                                          Debug.WriteLine(string.Format("{0} CanAutohide()= {1}",
                                                                                        c.Title, flag));
#endif
                                                          return flag;
                                                      })
                );
        }

        #endregion

        #endregion

        static DockablePane()
        {
            //This OverrideMetadata call tells the system that this element wants to provide a style that is different than its base class.
            //This style is defined in themes\generic.xaml
            DefaultStyleKeyProperty.OverrideMetadata(typeof (DockablePane),
                                                     new FrameworkPropertyMetadata(typeof (DockablePane)));
        }

        public DockablePane()
        {
            Loaded += DockablePane_Loaded;
            Unloaded += DockablePane_Unloaded;

            KeyboardNavigation.SetTabNavigation(this, KeyboardNavigationMode.Cycle);
        }

        protected override bool IsSurfaceVisible
        {
            get
            {
                foreach (ManagedContent managedContent in Items)
                {
                    if (managedContent is DocumentContent)
                        continue;

                    if (((DockableContent) managedContent).State == DockableContentState.Docked ||
                        ((DockableContent) managedContent).State == DockableContentState.None)
                        return true;
                }

                return false;
            }
        }

        public override bool IsDocked
        {
            get { return IsSurfaceVisible; }
        }

        public bool IsAutoHidden
        {
            get
            {
                return Items.Cast<DockableContent>().FirstOrDefault(c => c.State == DockableContentState.AutoHide) !=
                       null;
            }
        }

        #region OptionsContextMenu

        public override bool OpenOptionsMenu(UIElement menuTarget)
        {
            if (cxOptions == null)
            {
                cxOptions =
                    TryFindResource(new ComponentResourceKey(typeof (DockingManager), ContextMenuElement.DockablePane))
                    as ContextMenu;
            }

            return base.OpenOptionsMenu(menuTarget);
        }

        //ContextMenu cxOptions = null;

        ///// <summary>
        ///// Open the option context menu
        ///// </summary>
        ///// <param name="menuTarget">Target element under which context menu will be shown. Pass null if context menu
        ///// should be shown at mouse position.</param>
        ///// <returns>True if context menu resource was found and open, false otherwise.</returns>
        //public bool OpenOptionsMenu(UIElement menuTarget)
        //{
        //    if (cxOptions == null)
        //    {
        //        cxOptions = TryFindResource(new ComponentResourceKey(typeof(DockingManager), ContextMenuElement.DockablePane)) as ContextMenu;
        //        if (cxOptions != null)
        //        {
        //            cxOptions.Opened += (s, e) => UpdateIsOptionsMenuOpen();
        //            cxOptions.Closed += (s, e) => UpdateIsOptionsMenuOpen();
        //        }
        //    }

        //    if (cxOptions != null)
        //    {
        //        cxOptions.DataContext = this.SelectedItem as DockableContent;

        //        foreach (MenuItem menuItem in cxOptions.Items.OfType<MenuItem>())
        //            menuItem.CommandTarget = this.SelectedItem as DockableContent;

        //        if (menuTarget != null)
        //        {
        //            cxOptions.Placement = PlacementMode.Bottom;
        //            cxOptions.PlacementTarget = menuTarget;
        //        }
        //        else
        //        {
        //            cxOptions.Placement = PlacementMode.MousePoint;
        //            cxOptions.PlacementTarget = this;
        //        }

        //        FocusContent();
        //        cxOptions.IsOpen = true;
        //    }

        //    return (cxOptions != null && cxOptions.IsOpen);
        //}

        ///// <summary>
        ///// Close the options context menu
        ///// </summary>
        //public void CloseOptionsMenu()
        //{
        //    if (cxOptions != null)
        //    {
        //        cxOptions.IsOpen = false;
        //        cxOptions = null;
        //    }
        //}

        ///// <summary>
        ///// Gets a value indicating if the options context menu is open
        ///// </summary>
        //public bool IsOptionsMenuOpen
        //{
        //    get { return (bool)GetValue(IsOptionsMenuOpenProperty); }
        //    protected set { SetValue(IsOptionsMenuOpenPropertyKey, value); }
        //}

        //// Using a DependencyProperty as the backing store for IsOptionsMenuOpen.  This enables animation, styling, binding, etc...
        //static readonly DependencyPropertyKey IsOptionsMenuOpenPropertyKey =
        //    DependencyProperty.RegisterReadOnly("IsOptionsMenuOpen", typeof(bool), typeof(DockablePane), new UIPropertyMetadata(false));

        //public static readonly DependencyProperty IsOptionsMenuOpenProperty = IsOptionsMenuOpenPropertyKey.DependencyProperty;

        //void UpdateIsOptionsMenuOpen()
        //{
        //    if (cxOptions != null)
        //    {
        //        var selectedContent = cxOptions.DataContext as DockableContent;

        //        if (selectedContent != null)
        //        {
        //            (selectedContent.ContainerPane as DockablePane).IsOptionsMenuOpen =
        //                cxOptions.IsOpen;
        //        }
        //    }            
        //}

        #endregion

        #region Mouse management

        private bool isMouseDown;
        private Point ptStartDrag;

        protected virtual void OnHeaderMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!e.Handled && SelectedItem != null)
            {
                FocusContent();

                if (((DockableContent) SelectedItem).State != DockableContentState.AutoHide)
                {
                    //ptStartDrag = e.MouseDevice.GetPosition(this);
                    ptStartDrag = e.GetPosition((IInputElement) VisualTreeHelper.GetParent(this));

                    isMouseDown = true;
                }
            }
        }

        protected virtual void OnHeaderMouseMove(object sender, MouseEventArgs e)
        {
            //Point ptMouseMove = e.GetPosition(this);
            var ptMouseMove = e.GetPosition((IInputElement) VisualTreeHelper.GetParent(this));


            if (!e.Handled && isMouseDown && e.LeftButton == MouseButtonState.Pressed)
            {
                if (_partHeader != null &&
                    _partHeader.IsMouseOver)
                {
                    var manager = GetManager();
                    if (!manager.DragPaneServices.IsDragging &&
                        !IsMouseCaptured)
                    {
                        if (Math.Abs(ptMouseMove.X - ptStartDrag.X) > SystemParameters.MinimumHorizontalDragDistance ||
                            Math.Abs(ptMouseMove.Y - ptStartDrag.Y) > SystemParameters.MinimumVerticalDragDistance)
                        {
                            isMouseDown = false;
                            ReleaseMouseCapture();

                            manager.Drag(this, this.PointToScreenDPI(e.GetPosition(this)), e.GetPosition(this));
                            e.Handled = true;
                        }
                    }
                }
            }
        }

        protected virtual void OnHeaderMouseUp(object sender, MouseButtonEventArgs e)
        {
            isMouseDown = false;
            ReleaseMouseCapture();
        }

        protected virtual void OnHeaderMouseEnter(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        protected virtual void OnHeaderMouseLeave(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        #endregion

        #region Commands

        protected override void OnExecuteCommand(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == DockablePaneCommands.Close)
            {
                Close();
                e.Handled = true;
            }
            else if (e.Command == DockablePaneCommands.Hide)
            {
                Hide();
                e.Handled = true;
            }
            else if (e.Command == DockablePaneCommands.ToggleAutoHide)
            {
                ToggleAutoHide();
                e.Handled = true;
            }
            //else if (e.Command == ShowOptionsCommand)
            //{
            //    OpenOptionsContextMenu();
            //    e.Handled = true;
            //}
        }

        protected override void OnCanExecuteCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        /// <summary>
        ///   Retrive a value indicating if the command can be executed based to the dockable content state
        /// </summary>
        /// <param name = "command"></param>
        /// <returns></returns>
        protected virtual bool CanExecuteCommand(ICommand command)
        {
            //Test by DockableStyle
            if (command == DockablePaneCommands.Close)
            {
                return true;
            }
            else if (command == DockablePaneCommands.Hide)
            {
                return true;
            }
            else if (command == DockablePaneCommands.ToggleAutoHide)
            {
                return true;
            }


            return true;
        }

        #endregion

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            CommandBindings.Add(
                new CommandBinding(DockablePaneCommands.ToggleAutoHide, OnExecuteCommand, OnCanExecuteCommand));
            CommandBindings.Add(
                new CommandBinding(DockablePaneCommands.Close, OnExecuteCommand, OnCanExecuteCommand));
        }

        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e)
        {
            Items.Cast<DockableContent>().ForEach(c =>
                                                      {
                                                          if (c.State == DockableContentState.None)
                                                              c.SetStateToDock();
                                                      });

            UpdateCanAutohideProperty();
            base.OnItemsChanged(e);
        }


        private void DockablePane_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void DockablePane_Unloaded(object sender, RoutedEventArgs e)
        {
            CloseOptionsMenu();
        }


        public DockableStyle GetCumulativeDockableStyle()
        {
            var style = DockableStyle.Dockable;

            if (Items.Count == 1 &&
                Items[0] is DocumentContent)
                style = DockableStyle.Document;
            else
            {
                foreach (DockableContent content in Items)
                {
                    style &= content.DockableStyle;
                }
            }

            return style;
        }

        internal override ManagedContent RemoveContent(int index)
        {
            var content = base.RemoveContent(index);
            var dockableContent = content as DockableContent;

            if (((dockableContent == null)
                 || (dockableContent != null && dockableContent.SavedStateAndPosition == null)
                 || (dockableContent != null && dockableContent.SavedStateAndPosition.ContainerPane != this))
                && Items.Count == 0)
            {
                var containerPanel = Parent as ResizingPanel;
                if (containerPanel != null)
                    containerPanel.RemoveChild(this);
            }

            return content;
        }

        protected override void CheckItems(IList newItems)
        {
            foreach (var newItem in newItems)
            {
                if (!(newItem is DockableContent))
                    throw new InvalidOperationException("DockablePane can contain only DockableContents!");
            }
        }

        #region Dockable Pane operations

        /// <summary>
        ///   Toggle auto hide state to all content inside the pane
        /// </summary>
        public virtual void ToggleAutoHide()
        {
            var flag =
                Items.OfType<DockableContent>().FirstOrDefault(c => (c.DockableStyle & DockableStyle.AutoHide) == 0) ==
                null;

            if (flag && GetManager() != null)
                GetManager().ToggleAutoHide(this);
        }

        /// <summary>
        ///   Close pane and all contained contents
        /// </summary>
        /// <returns>True if all content has been closed, false if at least one content couldn't be closed.</returns>
        /// <remarks>
        /// </remarks>
        public virtual bool Close()
        {
            var cntsToClose = Items.OfType<DockableContent>().ToArray();
            var res = true;
            foreach (var cnt in cntsToClose)
            {
                if (!cnt.Close())
                    res = false;
            }

            return res;
        }


        /// <summary>
        ///   Close pane and hide all contained contents
        /// </summary>
        /// <returns>True if all content has been hidden, false if at least one content couldn't be hidden.</returns>
        /// <remarks>
        /// </remarks>
        public virtual bool Hide()
        {
            var cntsToClose = Items.OfType<DockableContent>().ToArray();
            var res = true;
            foreach (var cnt in cntsToClose)
            {
                if (!cnt.Hide())
                    res = false;
            }

            return res;
        }


        /// <summary>
        ///   Closes or hides current content depending on HideOnClose property
        /// </summary>
        internal void CloseOrHideCurrentContent()
        {
            (SelectedItem as DockableContent).CloseOrHide(false);
        }

        #endregion
    }
}