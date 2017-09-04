#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.IntTools
{
	public class IntToolsBaseRangeSample : NativeInstancePtr
	{
		public IntToolsBaseRangeSample()
 :
			base(IntTools_BaseRangeSample_Ctor() )
		{}
		public IntToolsBaseRangeSample(int theDepth)
 :
			base(IntTools_BaseRangeSample_CtorE8219145(theDepth) )
		{}
		public int Depth{
			set { 
				IntTools_BaseRangeSample_SetDepth(Instance, value);
			}
		}
		public int GetDepth{
			get {
				return IntTools_BaseRangeSample_GetDepth(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_BaseRangeSample_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_BaseRangeSample_CtorE8219145(int theDepth);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_BaseRangeSample_SetDepth(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_BaseRangeSample_GetDepth(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public IntToolsBaseRangeSample(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntToolsBaseRangeSample_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntToolsBaseRangeSample_Dtor(IntPtr instance);
	}
}
