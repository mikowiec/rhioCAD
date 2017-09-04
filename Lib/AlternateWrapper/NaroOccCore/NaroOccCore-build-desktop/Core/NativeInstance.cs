#region Usages

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#endregion

namespace NaroCppCore.Core
{
    public static class MemMapper
    {
        private static readonly SortedDictionary<int, SortedDictionary<int, bool>> _instances = new SortedDictionary<int, SortedDictionary<int, bool>>();
        private static readonly SortedDictionary<int, int> _allocations = new SortedDictionary<int, int>();
        private static readonly SortedDictionary<int, Type> _desc = new SortedDictionary<int, Type>();

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void Push(Type type,int instance)
        {
            return;
            var hash = type.GetHashCode();
            if (!_allocations.ContainsKey(hash))
            {
                _allocations[hash] = 1;
            }
            else
            {
                _allocations[hash]++;
            }
            
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static bool Pop(Type type, int instance)
        {
            return true;
            var hash = type.GetHashCode();

            return true;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void DisplayLeaks()
        {
            var lines = new List<string>();
            foreach (var ins in _instances)
            {
                if (ins.Value.Count == 0) continue;
                lines.Add(_desc[ins.Key].Name + ": " + ins.Value + " " + _allocations[ins.Key]);
            }
            File.WriteAllLines("leaks.txt", lines.ToArray());
            //CppDisplayLeaks();
        }

        [DllImport("NaroOccCore.dll")]
        public static extern void CppDisplayLeaks();
    }
    public abstract class NativeInstancePtr : IDisposable
    {
        private IntPtr _instance;

        [MethodImpl(MethodImplOptions.Synchronized)]
        protected NativeInstancePtr()
        {
            if (_instance == IntPtr.Zero) return;
            MemMapper.Push(GetType(), _instance.ToInt32());
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        protected NativeInstancePtr(IntPtr instance)
        {
            MemMapper.Push(GetType(), instance.ToInt32());
            Instance = instance;
        }

        internal IntPtr Instance
        {
            get { return _instance; }
            set
            {
                if (_instance != IntPtr.Zero)
                {
                    DeleteSelf();
                    MemMapper.Pop(GetType(), _instance.ToInt32());
                }
                _instance = value;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            CleanInstance();
        }

        #endregion

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void CleanInstance()
        {
            if (Instance == IntPtr.Zero) return;
            GC.SuppressFinalize(this);
            Instance = IntPtr.Zero;
        }

        ~NativeInstancePtr()
        {
            CleanInstance();
        }

        protected virtual void DeleteSelf()
        {
        }
    }
}
