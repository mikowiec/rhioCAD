#region Usings

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Standard;

#endregion

namespace NaroCppCore.Occ.Standard
{
    public class StandardTransient : NativeInstancePtr
    {
        public bool IsSameTransient(StandardTransient other)
        {
            return Standard_Transient_IsSameTransientF411CB01(Instance, other.Instance);
        }
        public T Convert<T>() where T : NativeInstancePtr
        {
            var t = typeof(T);
            var cInfo = t.GetConstructor(new[] { typeof(IntPtr) });
            var obj = cInfo.Invoke(new List<object> { StandardTransiemt_NewHandle(Instance) }.ToArray());
            var resultObj = (T)(obj);
            return resultObj;
        }

        [DllImport("NaroOccCore.dll")]
        private static extern IntPtr StandardTransiemt_NewHandle(IntPtr instance);

        [DllImport("NaroOccCore.dll")]
        private static extern bool Standard_Transient_IsSameTransientF411CB01(IntPtr instance, IntPtr other);

        #region NativeInstancePtr Convert constructor

        public StandardTransient() { }

        public StandardTransient(IntPtr instance) : base(instance) { }

        protected override void DeleteSelf()
        { StandardTransient_Dtor(Instance); }

        #endregion

        [DllImport("NaroOccCore.dll")]
        private static extern void StandardTransient_Dtor(IntPtr instance);
    }
}
