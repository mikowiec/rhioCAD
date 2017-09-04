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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

#endregion

namespace AvalonDock
{
    internal class WindowInteropWrapper : IDisposable
    {
        private HwndSource _hwndSrc;
        private HwndSourceHook _hwndSrcHook;

        public WindowInteropWrapper(Window window)
        {
            if (window == null)
                throw new ArgumentNullException("window");

            WrappedWindow = window;
            if (WrappedWindow.IsLoaded)
                AttachWindow();
            else
                window.Loaded += (s, e) => AttachWindow();
            window.Unloaded += (s, e) => DetachWindow();
        }


        public Window WrappedWindow { get; private set; }

        #region IDisposable Members

        public void Dispose()
        {
            DetachWindow();
            GC.SuppressFinalize(this);
        }

        #endregion

        private void AttachWindow()
        {
            _hwndSrc = PresentationSource.FromDependencyObject(WrappedWindow) as HwndSource;
            _hwndSrcHook = new HwndSourceHook(HookHandler);
            _hwndSrc.AddHook(_hwndSrcHook);
        }

        private void DetachWindow()
        {
            if (_hwndSrc != null)
            {
                _hwndSrc.RemoveHook(_hwndSrcHook);
                _hwndSrc = null;
                _hwndSrcHook = null;
            }
        }

        //DependencyObject _attachedObject;

        //public DependencyObject AttachedObject
        //{
        //    get {return _attachedObject;}
        //    set
        //    {
        //        if (_attachedObject != value)
        //        {
        //            if (_attachedObject != null)
        //            {
        //                _hwndSrc.RemoveHook(_hwndSrcHook);
        //                //_hwndSrc.Dispose();
        //                _hwndSrc = null;
        //                _hwndSrcHook = null;
        //            }

        //            _attachedObject = value;

        //            if (_attachedObject != null)
        //            {
        //                _hwndSrc = HwndSource.FromDependencyObject(value) as HwndSource;
        //                _hwndSrcHook = new HwndSourceHook(this.HookHandler);
        //                _hwndSrc.AddHook(_hwndSrcHook);
        //            }
        //        }
        //    }
        //}

        private IntPtr HookHandler(
            IntPtr hwnd,
            int msg,
            IntPtr wParam,
            IntPtr lParam,
            ref bool handled
            )
        {
            handled = false;

            switch (msg)
            {
                case SC_MOVE:
                case WM_WINDOWPOSCHANGING:
                    SafeFireEvent(WindowPosChanging, EventArgs.Empty);
                    break;
                case WM_MOUSEACTIVATE:
                    {
                        var args = new CancelEventArgs();
                        SafeFireEvent(WindowActivating, args);
                        if (args.Cancel)
                        {
                            Debug.WriteLine("Cancelled");
                            handled = true;
                            return (IntPtr) MA_NOACTIVATE;
                        }
                    }
                    break;
                case WM_ACTIVATE:
                    {
                        if (((int) wParam & 0xFFFF) != WA_INACTIVE)
                        {
                            var args = new CancelEventArgs();
                            SafeFireEvent(WindowActivating, args);
                            if (args.Cancel)
                            {
                                if (lParam != IntPtr.Zero)
                                {
                                    SetActiveWindow(lParam);
                                }
                                Debug.WriteLine("Cancelled Activation");
                                handled = true;
                            }
                        }
                    }
                    break;
            }

            if (!handled)
            {
                var e = new FilterMessageEventArgs(
                    hwnd,
                    msg,
                    wParam,
                    lParam);

                SafeFireEvent(FilterMessage, e);

                handled = e.Handled;
            }

            return IntPtr.Zero;
        }

        public event EventHandler<EventArgs> WindowPosChanging;

        public event EventHandler<CancelEventArgs> WindowActivating;

        public event EventHandler<FilterMessageEventArgs> FilterMessage;

        private void SafeFireEvent<T>(EventHandler<T> eventToFireup, T e) where T : EventArgs
        {
            if (WrappedWindow != null &&
                PresentationSource.FromDependencyObject(WrappedWindow) != null)
            {
                if (eventToFireup != null)
                    eventToFireup(this, e);
            }
        }

        #region interop funtions and consts

        private const int WM_MOUSEACTIVATE = 0x0021, MA_NOACTIVATE = 0x0003;
        private const int WM_NCACTIVATE = 0x86;
        private const int WM_ACTIVATEAPP = 0x1c;
        private const int WM_ACTIVATE = 6;
        private const int WM_WINDOWPOSCHANGING = 70;
        private const int WM_WINDOWPOSCHANGED = 0x47;
        private const int WM_MOVE = 0x0003;
        private const int WM_SIZE = 0x0005;
        private const int WM_NCMOUSEMOVE = 0xa0;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int WM_NCLBUTTONUP = 0xA2;
        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        private const int WM_NCRBUTTONDOWN = 0xA4;
        private const int WM_NCRBUTTONUP = 0xA5;
        private const int HTCAPTION = 2;
        private const int SC_MOVE = 0xF010;
        private const int WM_SYSCOMMAND = 0x0112;


        private const int WA_INACTIVE = 0;

        [DllImport("user32.dll")]
        private static extern IntPtr SetActiveWindow(IntPtr handle);


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(HandleRef hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(IntPtr hWndLock);

        #endregion
    }


    public class FilterMessageEventArgs : EventArgs
    {
        public FilterMessageEventArgs(
            IntPtr hwnd,
            int msg,
            IntPtr wParam,
            IntPtr lParam)
        {
            Hwnd = hwnd;
            WParam = wParam;
            LParam = lParam;
            Msg = msg;
        }

        public IntPtr Hwnd { get; private set; }
        public IntPtr WParam { get; private set; }
        public IntPtr LParam { get; private set; }
        public int Msg { get; private set; }
        public bool Handled { get; set; }
    }
}