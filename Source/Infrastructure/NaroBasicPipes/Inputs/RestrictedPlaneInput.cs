#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.BRepAdaptor;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.TopoDS;
using NaroPipes.Actions;
using OccCode;

using TreeData.AttributeInterpreter;

#endregion

namespace NaroBasicPipes.Inputs
{
    public class RestrictedPlaneInput : InputBase
    {
        private TopoDSFace _internalFace;

        public RestrictedPlaneInput()
            : base(InputNames.RestrictedPlane)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.SetData, OnSetPlane);
            AddNotificationHandler(NotificationNames.GetPlane, OnGetPlane);
        }

        private void LockPlane(TopoDSFace face)
        {
            if (face == null)
                return;
            _internalFace = null;
            var aFaceElementAdaptor = new BRepAdaptorSurface(face, true);
            var surfaceType = aFaceElementAdaptor.GetType;
            if (surfaceType != GeomAbsSurfaceType.GeomAbs_Plane)
                return;
            _internalFace = face;
        }

        public override void OnDisconnect()
        {
            _internalFace = null;
            base.OnDisconnect();
        }

        private void OnGetPlane(DataPackage data)
        {
            ReturnData = new DataPackage(_internalFace);
        }

        private void OnSetPlane(DataPackage dataPackage)
        {
            var entity = dataPackage.Get<SceneSelectedEntity>();
            LockPlane(GeomUtils.GetFace(entity));
        }
    }
}