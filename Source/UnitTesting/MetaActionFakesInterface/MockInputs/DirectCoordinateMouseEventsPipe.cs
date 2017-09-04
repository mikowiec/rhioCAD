#region Usings

using log4net;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.WNT;
using NaroPipes.Actions;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActionFakesInterface.MockInputs
{
    public class DirectCoordinateMouseEventsPipe : PipeBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (DirectCoordinateMouseEventsPipe));

        private bool _mouseDown;

        public DirectCoordinateMouseEventsPipe(V3dView view)
            : base(InputNames.Mouse3DEventsPipe)
        {
            Plane = new gpPln(new gpAx3());

            var wnd = view.Window();
            WNTWindow wnt = wnd.Convert<WNTWindow>();
        }

        private gpPln Plane { get; set; }

        public override void OnRegister()
        {
            DependsOn(InputNames.MouseEventsInput);
        }

        protected override void SourceOnData(string inputName, DataPackage mouseData)
        {
            var data = mouseData.Get<MouseEventData>();
            // Convert the 2D coordinates into 3D located in the selected plane
            var x = data.X;
            var y = data.Y;
            const int z = 0;

            SendData(new Point3D(x, y, z), Plane.Axis, data.MouseDown, data.ShiftDown, data.ControlDown, x, y);
        }

        private void SendData(Point3D point, gpAx1 axis, bool mouseDown, bool shiftDown, bool controlDown, int x,
                              int y)
        {
            // Notify listeners about the mouse event
            AddData(new Mouse3DPosition(point, axis, mouseDown, shiftDown, controlDown, x, y));


            // Logs the coordinates where a mouse down/up event is generated
            if (_mouseDown == mouseDown) return;
            Log.InfoFormat("Mouse3dEventsPipe x:{0} y:{1} z:{2} mouse down:{3}", point.X, point.Y, point.Z, mouseDown);
            _mouseDown = mouseDown;
        }

        protected override void OnNotification(string name, DataPackage dataPackage)
        {
            switch (name)
            {
                case NotificationNames.SetPlane:
                    Plane = dataPackage.Get<gpPln>();
                    break;
            }
        }
    }
}