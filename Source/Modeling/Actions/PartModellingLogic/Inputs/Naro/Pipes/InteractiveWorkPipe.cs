#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroPipes.Actions;


#endregion

namespace PartModellingLogic.Inputs.Naro.Pipes
{
    public class InteractiveWorkPipe : ViewBasedPipe
    {
        protected bool InteractiveWorkSuspended = true;

        protected InteractiveWorkPipe(string name) : base(name)
        {
            InitializePipe();
        }

        protected TopAbsShapeEnum PreviousSelectionMode { get; set; }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.Suspend, NotificationSuspendHandler);
            AddNotificationHandler(NotificationNames.Resume, NotificationResumeHandler);
            AddNotificationHandler(NotificationNames.Cleanup, NotificationCleanupHandler);
        }

        private void InitializePipe()
        {
            PreviousSelectionMode = TopAbsShapeEnum.TopAbs_SOLID;
        }

        public override void OnConnect()
        {
            base.OnConnect();
            InteractiveWorkSuspended = true;
        }

        private void NotificationResumeHandler(DataPackage data)
        {
            if (!InteractiveWorkSuspended)
                return;
            StartInteractiveDetection();
            InteractiveWorkSuspended = false;
        }

        private void NotificationSuspendHandler(DataPackage data)
        {
            if (InteractiveWorkSuspended)
                return;
            StopInteractiveDetection();
            InteractiveWorkSuspended = true;
        }

        private void NotificationCleanupHandler(DataPackage data)
        {
            Cleanup();
        }

        protected virtual void StopInteractiveDetection()
        {
        }

        protected virtual void StartInteractiveDetection()
        {
        }

        protected virtual void Cleanup()
        {
        }
    }
}