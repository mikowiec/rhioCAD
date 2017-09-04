#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gce;

#endregion

namespace NaroCppCore.Occ.gce
{
	public class gceRoot : NativeInstancePtr
	{
		public bool IsDone{
			get {
				return gce_Root_IsDone(Instance);
			}
		}
		public gceErrorType Status{
			get {
				return (gceErrorType)gce_Root_Status(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern bool gce_Root_IsDone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int gce_Root_Status(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gceRoot() { } 

		public gceRoot(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gceRoot_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gceRoot_Dtor(IntPtr instance);
	}
}
