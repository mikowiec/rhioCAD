#region Usings

using TreeData.NaroData;
using log4net;
using NaroBasicPipes.Actions;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.WNT;
using NaroPipes.Actions;
using OccCode;

using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.Precision;

#endregion

namespace PartModellingLogic.Inputs.Naro.Pipes
{
    public class SelectionInfo
    {
        public Node selectedNode;
        public int face;

    }
    /// <summary>
    ///   Converts the 2d mouse coordinatesd into 3D coordinates by projecting it into the plane Plane.
    /// </summary>
    public class Mouse3DEventsPipe : PipeBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (Mouse3DEventsPipe));
        private bool _ignorePlanes;

        private bool _mouseDown;
        private V3dView _view;

        public Mouse3DEventsPipe() : base(InputNames.Mouse3DEventsPipe)
        {
            Plane = new gpPln(new gpAx3());
        }

        private gpPln Plane { get; set; }

        private SelectionInfo SelectedItem;
        private gpPln ExcludedPlane { get; set; }

        public override void OnRegister()
        {
            DependsOn(InputNames.MouseEventsInput, MouseEventHandler);
            DependsOn(InputNames.View, UpdateViewData);
        }

        private void UpdateViewData(DataPackage data)
        {
            _view = data.Get<ViewInput.Items>().View;
        }

        private void MouseEventHandler(DataPackage data)
        {
            var mouseData = data.Get<MouseEventData>();

            if (((null != Plane) && (ExcludedPlane == null)) ||
                ((null != Plane) && (null != ExcludedPlane) && (Plane.Distance(ExcludedPlane) > Precision.Confusion)))
            {
                // Convert the 2D coordinates into 3D located in the selected plane
                double x = 0;
                double y = 0;
                double z = 0;
                var isOnPlane = GeomUtils.ConvertToPlane(_view, Plane, mouseData.X, mouseData.Y, ref x, ref y, ref z);
                if (isOnPlane)
                {
                    SendData(new Point3D(x, y, z), Plane.Axis, mouseData.MouseDown, mouseData.ShiftDown,
                             mouseData.ControlDown,
                             mouseData.X, mouseData.Y, mouseData.Clicks);
                }
            }
            else
            {
                // COnvert 2D coordinates into 3D located in the view space
                var point = GeomUtils.ConvertClickToPoint(mouseData.X, mouseData.Y, _view);
                SendData(point, new gpAx1(), mouseData.MouseDown, mouseData.ShiftDown, mouseData.ControlDown,
                         mouseData.X, mouseData.Y, mouseData.Clicks);
            }
        }

        private void SendData(Point3D point, gpAx1 axis, bool mouseDown, bool shiftDown, bool controlDown,
                              int initial2Dx, int initial2Dy, int clicks)
        {
            // Notify listeners about the mouse event
            AddData(new Mouse3DPosition(point, axis, mouseDown, shiftDown, controlDown, initial2Dx, initial2Dy, clicks));

            // Logs the coordinates where a mouse down/up event is generated
            if (_mouseDown == mouseDown) return;
            Log.InfoFormat("Mouse3dEventsPipe x:{0} y:{1} z:{2} mouse down:{3}", point.X, point.Y, point.Z, mouseDown);
            _mouseDown = mouseDown;
        }

        protected override void OnNotification(string name, DataPackage dataPackage)
        {
            switch (name)
            {
                case NotificationNames.SetFace:
                    SelectedItem = dataPackage.Get<SelectionInfo>();
                    break;
                case NotificationNames.SetPlane:
                    if (_ignorePlanes) return;
                    Plane = dataPackage.Get<gpPln>();
                    break;
                case NotificationNames.ExcludedPlane:
                    if (_ignorePlanes) return;
                    ExcludedPlane = dataPackage.Get<gpPln>();
                    break;
                case NotificationNames.GetPlane:
                    ReturnData = new DataPackage(Plane);
                    break;
                case NotificationNames.GetFace:
                    ReturnData = new DataPackage(SelectedItem);
                    break;
                case NotificationNames.Suspend:
                    _ignorePlanes = true;
                    break;
                case NotificationNames.Resume:
                    _ignorePlanes = false;
                    break;
            }
        }
    }
}