#region Usings

using ErrorReportCommon.Messages;
using log4net;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.V3d;
using NaroPipes.Actions;


#endregion

namespace MetaActionFakesInterface.MockInputs
{
    public class FacePickerMockPipe : PipeBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (FacePickerMockPipe));

        private readonly AISInteractiveContext _context;
        private readonly V3dView _view;
        private TopoDSFace _face;
        private bool _facePickerSuspended;
        private bool _lockedPlane;

        public FacePickerMockPipe(AISInteractiveContext context, V3dView view)
            : base(InputNames.FacePickerPlane)
        {
            _context = context;
            _view = view;
        }

        private bool PreviousMouseDown { get; set; }

        private TopoDSFace Face
        {
            get { return _face; }
            set
            {
                if (_facePickerSuspended) return;
                if (_face == value)
                    return;

                if ((_face != null) && (!_face.IsNull) && (value != null) && (!value.IsNull) && _face.IsSame(value))
                    return;

                _face = value;

                AddData(_face);
            }
        }

        protected override void OnNotification(string name, DataPackage dataPackage)
        {
            switch (name)
            {
                case NotificationNames.Suspend:
                    if (_lockedPlane)
                        return;
                    if (_facePickerSuspended)
                        return;
                    if (!_facePickerSuspended)
                        _context.CloseAllContexts(true);
                    _facePickerSuspended = true;
                    Log.Info("FacePickerPlane - suspended");
                    break;
                case NotificationNames.LockPlane:
                    Send(NotificationNames.Suspend);
                    Face = dataPackage.Get<TopoDSFace>();
                    _lockedPlane = true;
                    break;
                case NotificationNames.Resume:
                    if (_lockedPlane)
                        return;
                    if (!_facePickerSuspended)
                        return;
                    _facePickerSuspended = false;
                    Face = null;
                    Log.Info("FacePickerPlane - resumed");

                    break;
                case NotificationNames.Cleanup:

                    break;
                default:
                    NaroMessage.Show(@"Object name: " + name + @" is not handled in input notification");
                    break;
            }
        }

        public override void OnConnect()
        {
            _facePickerSuspended = false;
            Face = null;
            _lockedPlane = false;
            if (Face != null)
                AddData(Face);
        }

        public override void OnRegister()
        {
        }

        protected override void SourceOnData(string inputName, DataPackage data)
        {
            if (!_facePickerSuspended) return;
            MouseHandler(data.Get<MouseEventData>());
        }

        private void MouseHandler(MouseEventData mouseData)
        {
            if (mouseData.MouseDown != PreviousMouseDown)
                _context.Select(true);
            else
                _context.MoveTo(mouseData.X, mouseData.Y, _view);

            PreviousMouseDown = mouseData.MouseDown;
        }
    }
}