namespace Naro.Infrastructure.Interface.AppUtils
{
    public class CoreGlobalPreferencesSingleton
    {
        private static readonly CoreGlobalPreferencesSingleton SingletoInstance = new CoreGlobalPreferencesSingleton();

        private CoreGlobalPreferencesSingleton()
        {
            ZoomLevel = 1/2.72;
        }

        private double _zoomLevel;

        public double ZoomLevel
        {
            get { return _zoomLevel; }
            set { 
                _zoomLevel = value;
                EditingHandlerZoom = value < 0.3 ? value * 4 : 1;
            }
        }
        public double EditingHandlerZoom { get; set; }
        public bool ShowTreeIcons { get; set; }
        public int StartTime { get; set; }

        public static CoreGlobalPreferencesSingleton Instance
        {
            get { return SingletoInstance; }
        }
    }
}