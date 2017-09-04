namespace PluginEditor.UI
{
    public class PluginDescription
    {
        public PluginDescription()
        {
            Enabled = true;
        }

        public string Name { get; set; }
        public PluginState State { get; set; }
        public bool Enabled { get; set; }
    }
}