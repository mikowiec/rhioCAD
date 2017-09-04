#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gce;

#endregion

namespace NaroCppCore.Occ.GC
{
	public class GCRoot : NativeInstancePtr
	{
		public bool IsDone{
			get {
				return GC_Root_IsDone(Instance);
			}
		}
		public gceErrorType Status{
			get {
				return (gceErrorType)GC_Root_Status(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern bool GC_Root_IsDone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GC_Root_Status(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GCRoot() { } 

		public GCRoot(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GCRoot_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GCRoot_Dtor(IntPtr instance);
	}
}
