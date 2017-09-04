#region Usings

using System.Windows.Forms;
using NaroBasicPipes.Inputs.Layers;
using NaroConstants.Names;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.gp;
using NaroPipes.Actions;


#endregion

namespace NaroBasicPipes.Inputs
{
    public class ViewInput : InputBase
    {
        private readonly OcLayer2DManager _manager;
        private readonly V3dView _view;
        private readonly V3dViewer _viewer;


        public ViewInput(V3dView view, V3dViewer viewer, Control control)
            : base(InputNames.View)
        {
            _view = view;
            _viewer = viewer;
            _manager = new OcLayer2DManager(view, control);
        }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
            AddNotificationHandler(NotificationNames.RefreshView, OnRefresh);
            AddNotificationHandler(NotificationNames.Resize, OnResize);
            AddNotificationHandler(NotificationNames.GetLayerManager, OnGetLayerManager);
            AddNotificationHandler(NotificationNames.SwitchView, OnSwitchView);
        }

        public override void OnConnect()
        {
            AddData(new Items(_view, _viewer));
        }

        public override void OnDisconnect()
        {
            _manager.Clear();
            base.OnDisconnect();
        }

        private void OnGetLayerManager(DataPackage data)
        {
            ReturnData = new DataPackage(_manager);
        }

        private void OnResize(DataPackage data)
        {
            _view.MustBeResized();
        }

        private void OnRefresh(DataPackage data)
        {
            _manager.Draw();
            _viewer.Update();
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(new Items(_view, _viewer));
        }

        #region Nested type: Items

        public class Items
        {
            public Items(V3dView view, V3dViewer viewer)
            {
                View = view;
                Viewer = viewer;
            }

            public V3dView View { get; private set; }
            public V3dViewer Viewer { get; private set; }
        }

        #endregion

        private void OnSwitchView(DataPackage data)
        {
            var planeDirection = (data.Data as gpPln).Axis.Direction;
            _view.SetProj(planeDirection.X,planeDirection.Y,planeDirection.Z);
        }
    }
}