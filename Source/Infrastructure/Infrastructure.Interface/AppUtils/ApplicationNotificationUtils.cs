namespace Naro.Infrastructure.Interface.AppUtils
{
    public class ApplicationNotificationUtils
    {
        #region Delegates

        public delegate void OnExitApplication();

        #endregion

        private static readonly ApplicationNotificationUtils SingletonInstance = new ApplicationNotificationUtils();
        public OnExitApplication ExitingApplication;

        private ApplicationNotificationUtils()
        {
        }

        public static ApplicationNotificationUtils Instance
        {
            get { return SingletonInstance; }
        }

        public void ExitApplication()
        {
            if (ExitingApplication != null)
                ExitingApplication();
        }
    }
}