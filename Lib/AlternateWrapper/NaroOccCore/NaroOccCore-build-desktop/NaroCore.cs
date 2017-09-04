#region Usings

using System.Runtime.InteropServices;

#endregion

namespace NaroCppCore
{
    public class NaroCore
    {
        [DllImport("NaroOccCore.dll")]
        private static extern int naro_core_init();

        public static int Init()
        {
            return naro_core_init();
        }
    }
}