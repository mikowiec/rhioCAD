#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.TopAbs;

#endregion

namespace NaroCppCore.Occ.SelectMgr
{
	public class SelectMgrFilter : MMgtTShared
	{
			public bool ActsOn(TopAbsShapeEnum aStandardMode)
				{
					return SelectMgr_Filter_ActsOnC6FD32C4(Instance, (int)aStandardMode);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern bool SelectMgr_Filter_ActsOnC6FD32C4(IntPtr instance, int aStandardMode);

		#region NativeInstancePtr Convert constructor

		public SelectMgrFilter() { } 

		public SelectMgrFilter(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ SelectMgrFilter_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void SelectMgrFilter_Dtor(IntPtr instance);
	}
}
