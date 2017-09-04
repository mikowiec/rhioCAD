namespace PluginEditor.UI
{
    public class AppSettings
    {
        private static readonly AppSettings SingletonInstance = new AppSettings();
        public string StartFolder;

        public static AppSettings Instance
        {
            get { return SingletonInstance; }
        }
    }
}