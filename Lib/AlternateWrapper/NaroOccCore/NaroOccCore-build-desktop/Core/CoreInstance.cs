using System;
using System.Runtime.InteropServices;

namespace NaroCppCore.Core
{
    public abstract class CoreInstance : IDisposable
    {
        protected IntPtr Instance;
        protected int TypeId;
        protected CoreInstance(int typeId)
        {
            TypeId = typeId;
        }
        public void Dispose()
        {
            DeleteInstance();
        }

        ~CoreInstance()
        {
            DeleteInstance();
        }

        private void DeleteInstance()
        {
            Instance = IntPtr.Zero;
        }
    }
}
