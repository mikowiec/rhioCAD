#region Usings

using System;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using log4net;
using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace NaroBasicPipes.Inputs
{
    public class MouseCursorInput : InputBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (MouseCursorInput));
        private readonly Control _control;
        private ResourceManager _resourceManager;

        public MouseCursorInput(Control parent)
            : base(InputNames.MouseCursorInput)
        {
            _control = parent;
        }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.SetCursor, OnSetCursor);
            AddNotificationHandler(NotificationNames.SetResourceManager, OnSetResourceManager);
            AddNotificationHandler(NotificationNames.SetCursorName, OnSetCursorName);
            AddNotificationHandler(NotificationNames.Reset, OnReset);
        }

        private void OnReset(DataPackage data)
        {
            if (_control != null) _control.Cursor = Cursors.Default;
        }

        private void OnSetCursorName(DataPackage dataPackage)
        {
            var cursorName = dataPackage.Text;
            SetCursorByName(cursorName);
        }

        private void OnSetResourceManager(DataPackage dataPackage)
        {
            _resourceManager = dataPackage.Get<ResourceManager>();
        }

        private void OnSetCursor(DataPackage dataPackage)
        {
            _control.Cursor = dataPackage.Get<Cursor>();
        }

        private void SetCursorByName(string cursorName)
        {
            Cursor cursor = null;
            try
            {
                if (_resourceManager != null)
                {
                    var data = (byte[]) _resourceManager.GetObject(cursorName);
                    if (data != null)
                    {
                        var ms = new MemoryStream(data);
                        cursor = new Cursor(ms);
                    }
                }
            }
            catch (Exception)
            {
                Log.Info("Cannot load cursor");
            }
            try
            {
                if (cursor == null)
                    cursor = new Cursor(cursorName);
            }
            catch (Exception)
            {
                Log.Info("Cannot setup mouse cursor");
            }
            try
            {
                if (_control != null)
                    _control.Cursor = cursor;
            }
            catch (Exception)
            {
                Log.Info("Error on cursor setup");
            }
        }

        public override void OnDisconnect()
        {
            if (_control != null)
                _control.Cursor = Cursors.Default;
        }
    }
}