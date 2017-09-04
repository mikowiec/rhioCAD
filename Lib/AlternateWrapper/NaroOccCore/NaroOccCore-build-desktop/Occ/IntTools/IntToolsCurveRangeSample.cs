#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.IntTools;

#endregion

namespace NaroCppCore.Occ.IntTools
{
	public class IntToolsCurveRangeSample : IntToolsBaseRangeSample
	{
		public IntToolsCurveRangeSample()
 :
			base(IntTools_CurveRangeSample_Ctor() )
		{}
		public IntToolsCurveRangeSample(int theIndex)
 :
			base(IntTools_CurveRangeSample_CtorE8219145(theIndex) )
		{}
			public bool IsEqual(IntToolsCurveRangeSample Other)
				{
					return IntTools_CurveRangeSample_IsEqual6A019644(Instance, Other.Instance);
				}
			public IntToolsRange GetRange(double theFirst,double theLast,int theNbSample)
				{
					return new IntToolsRange(IntTools_CurveRangeSample_GetRange89C01C9C(Instance, theFirst, theLast, theNbSample));
				}
			public int GetRangeIndexDeeper(int theNbSample)
				{
					return IntTools_CurveRangeSample_GetRangeIndexDeeperE8219145(Instance, theNbSample);
				}
		public int RangeIndex{
			set { 
				IntTools_CurveRangeSample_SetRangeIndex(Instance, value);
			}
		}
		public int GetRangeIndex{
			get {
				return IntTools_CurveRangeSample_GetRangeIndex(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_CurveRangeSample_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_CurveRangeSample_CtorE8219145(int theIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_CurveRangeSample_IsEqual6A019644(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_CurveRangeSample_GetRange89C01C9C(IntPtr instance, double theFirst,double theLast,int theNbSample);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_CurveRangeSample_GetRangeIndexDeeperE8219145(IntPtr instance, int theNbSample);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_CurveRangeSample_SetRangeIndex(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_CurveRangeSample_GetRangeIndex(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public IntToolsCurveRangeSample(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntToolsCurveRangeSample_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntToolsCurveRangeSample_Dtor(IntPtr instance);
	}
}
