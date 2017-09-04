#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;

#endregion

namespace NaroCppCore.Occ.WNT
{
	public class WNTWClass : MMgtTShared
	{
		public string Name{
			get {
				return WNT_WClass_Name(Instance);
			}
		}
		public IntPtr Instance{
			get {
				return WNT_WClass_Instance(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern string WNT_WClass_Name(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr WNT_WClass_Instance(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public WNTWClass() { } 

		public WNTWClass(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ WNTWClass_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void WNTWClass_Dtor(IntPtr instance);
	}
}
