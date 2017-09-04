#region Usings

using NaroCppCore.Occ.gp;

using TreeData.AttributeInterpreter;

#endregion

namespace NaroBasicPipes.Actions
{
    /// <summary>
    ///   Class that keeps the a 3D position and mouse down status
    /// </summary>
    public class Mouse3DPosition
    {
        /// <summary>
        ///   Set the 3D position and the mouse status
        /// </summary>
        /// <param name = "pnt">OpenCascade 3D position gpPnt</param>
        /// <param name = "axis">Axis describing the 3D point</param>
        /// <param name = "mouseDown">Mouse button pressed status</param>
        /// <param name = "shiftDown">true if shift key was pressed while mouse clicked</param>
        /// <param name = "controlDown">true if ctrl key was pressed while mouse clicked</param>
        /// <param name = "initial2Dx">Initial 2D x coordinate from which the 3D coordinate was generated</param>
        /// <param name = "initial2Dy">Initial 2D Y coordinate from which the 3D coordinate was generated</param>
        public Mouse3DPosition(Point3D pnt, gpAx1 axis, bool mouseDown, bool shiftDown, bool controlDown,
                               int initial2Dx, int initial2Dy)
        {
            Point = pnt;
            MouseDown = mouseDown;
            ShiftDown = shiftDown;
            ControlDown = controlDown;
            Axis = axis;
            Initial2Dx = initial2Dx;
            Initial2Dy = initial2Dy;
            Clicks = 1;
        }

        public Mouse3DPosition(Point3D pnt, gpAx1 axis, bool mouseDown, bool shiftDown, bool controlDown,
                              int initial2Dx, int initial2Dy, int clicks)
        {
            Point = pnt;
            MouseDown = mouseDown;
            ShiftDown = shiftDown;
            ControlDown = controlDown;
            Axis = axis;
            Initial2Dx = initial2Dx;
            Initial2Dy = initial2Dy;
            Clicks = clicks;
        }

        public Mouse3DPosition(Mouse3DPosition mouse3D)
        {
            Point = new Point3D(mouse3D.Point.GpPnt);
            MouseDown = mouse3D.MouseDown;
            ShiftDown = mouse3D.ShiftDown;
            ControlDown = mouse3D.ControlDown;
            Axis = new gpAx1 {Direction = (mouse3D.Axis.Direction), Location = (mouse3D.Axis.Location)};
            Initial2Dx = mouse3D.Initial2Dx;
            Initial2Dy = mouse3D.Initial2Dy;
            Clicks = 1;
        }

        /// <summary>
        ///   Gets the 2D mouse position from which 3D was generated
        /// </summary>
        public int Initial2Dx { get; private set; }

        public int Initial2Dy { get; private set; }

        public int Clicks { get; private set; }

        /// <summary>
        ///   Gets the 3D mouse position
        /// </summary>
        public Point3D Point { get; set; }

        /// <summary>
        ///   Gets the mouse button pressed status
        /// </summary>
        public bool MouseDown { get; set; }

        /// <summary>
        ///   Axis that describes the 3D point
        /// </summary>
        public gpAx1 Axis { get; set; }

        public bool ShiftDown { get; set; }
        public bool ControlDown { get; set; }
    }
}