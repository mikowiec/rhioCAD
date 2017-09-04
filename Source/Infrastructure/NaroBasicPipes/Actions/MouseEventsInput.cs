#region Usings

using log4net;
using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace NaroBasicPipes.Actions
{
    public class MouseEventsInput : InputBase
    {
        private static readonly ILog Log = LogManager.GetLogger("Mouse3DEventsPipe");
        private MouseEventData _lastData;

        public MouseEventsInput()
            : base(InputNames.MouseEventsInput)
        {
        }

        public void MouseDown(int x, int y, int clicks, bool shiftDown, bool controlDown)
        {
            _lastData = new MouseEventData(x, y, clicks, true, shiftDown, controlDown);
            AddData(_lastData);
        }

        public void MouseMove(int x, int y, bool isMouseDown, bool shiftDown, bool controlDown)
        {
            _lastData = new MouseEventData(x, y, isMouseDown, shiftDown, controlDown);
            AddData(_lastData);
        }

        public void MouseUp(int x, int y, bool shiftDown, bool controlDown)
        {
            _lastData = new MouseEventData(x, y, false, shiftDown, controlDown);
            AddData(_lastData);
        }

        protected override void OnNotification(string name, DataPackage dataPackage)
        {
            switch (name)
            {
                case NotificationNames.LastValue:
                    ReturnData = new DataPackage(_lastData);
                    break;
            }
        }
    }
}