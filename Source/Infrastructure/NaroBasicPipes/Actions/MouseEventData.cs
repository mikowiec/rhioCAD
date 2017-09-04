namespace NaroBasicPipes.Actions
{
    public class MouseEventData
    {
        public MouseEventData(int x, int y, int clicks, bool mouseDown, bool shiftDown, bool controlDown)
        {
            X = x;
            Y = y;
            Clicks = clicks;
            MouseDown = mouseDown;
            ShiftDown = shiftDown;
            ControlDown = controlDown;
        }

        public MouseEventData(int x, int y, bool mouseDown, bool shiftDown, bool controlDown)
        {
            X = x;
            Y = y;
            Clicks = 1;
            MouseDown = mouseDown;
            ShiftDown = shiftDown;
            ControlDown = controlDown;
        }

        public bool MouseDown { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Clicks { get; private set; }
        public bool ShiftDown { get; private set; }
        public bool ControlDown { get; private set; }
    }
}