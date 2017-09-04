#region Usings

using System;

#endregion

namespace PluginInterface
{
    public class NaroRegisterAttribute : Attribute
    {
        public NaroRegisterAttribute()
        {
            OnAppStartup = false;
            OnDocumentSpawn = true;
        }

        public bool OnAppStartup { get; set; }
        public bool OnDocumentSpawn { get; set; }
    }
}