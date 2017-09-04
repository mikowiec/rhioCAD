#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.IntTools;

#endregion

namespace NaroCppCore.Occ.IntTools
{
	public class IntToolsSurfaceRangeSample : NativeInstancePtr
	{
		public IntToolsSurfaceRangeSample()
 :
			base(IntTools_SurfaceRangeSample_Ctor() )
		{}
		public IntToolsSurfaceRangeSample(int theIndexU,int theDepthU,int theIndexV,int theDepthV)
 :
			base(IntTools_SurfaceRangeSample_Ctor8C6D7843(theIndexU, theDepthU, theIndexV, theDepthV) )
		{}
		public IntToolsSurfaceRangeSample(IntToolsCurveRangeSample theRangeU,IntToolsCurveRangeSample theRangeV)
 :
			base(IntTools_SurfaceRangeSample_Ctor72DC087B(theRangeU.Instance, theRangeV.Instance) )
		{}
		public IntToolsSurfaceRangeSample(IntToolsSurfaceRangeSample Other)
 :
			base(IntTools_SurfaceRangeSample_Ctor7CD3FA85(Other.Instance) )
		{}
			public IntToolsSurfaceRangeSample Assign(IntToolsSurfaceRangeSample Other)
				{
					return new IntToolsSurfaceRangeSample(IntTools_SurfaceRangeSample_Assign7CD3FA85(Instance, Other.Instance));
				}
			public void SetRanges(IntToolsCurveRangeSample theRangeU,IntToolsCurveRangeSample theRangeV)
				{
					IntTools_SurfaceRangeSample_SetRanges72DC087B(Instance, theRangeU.Instance, theRangeV.Instance);
				}
			public void GetRanges(IntToolsCurveRangeSample theRangeU,IntToolsCurveRangeSample theRangeV)
				{
					IntTools_SurfaceRangeSample_GetRanges72DC087B(Instance, theRangeU.Instance, theRangeV.Instance);
				}
			public void SetIndexes(int theIndexU,int theIndexV)
				{
					IntTools_SurfaceRangeSample_SetIndexes5107F6FE(Instance, theIndexU, theIndexV);
				}
			public void GetIndexes(ref int theIndexU,ref int theIndexV)
				{
					IntTools_SurfaceRangeSample_GetIndexes5107F6FE(Instance, ref theIndexU, ref theIndexV);
				}
			public void GetDepths(ref int theDepthU,ref int theDepthV)
				{
					IntTools_SurfaceRangeSample_GetDepths5107F6FE(Instance, ref theDepthU, ref theDepthV);
				}
			public IntToolsRange GetRangeU(double theFirstU,double theLastU,int theNbSampleU)
				{
					return new IntToolsRange(IntTools_SurfaceRangeSample_GetRangeU89C01C9C(Instance, theFirstU, theLastU, theNbSampleU));
				}
			public IntToolsRange GetRangeV(double theFirstV,double theLastV,int theNbSampleV)
				{
					return new IntToolsRange(IntTools_SurfaceRangeSample_GetRangeV89C01C9C(Instance, theFirstV, theLastV, theNbSampleV));
				}
			public bool IsEqual(IntToolsSurfaceRangeSample Other)
				{
					return IntTools_SurfaceRangeSample_IsEqual7CD3FA85(Instance, Other.Instance);
				}
			public int GetRangeIndexUDeeper(int theNbSampleU)
				{
					return IntTools_SurfaceRangeSample_GetRangeIndexUDeeperE8219145(Instance, theNbSampleU);
				}
			public int GetRangeIndexVDeeper(int theNbSampleV)
				{
					return IntTools_SurfaceRangeSample_GetRangeIndexVDeeperE8219145(Instance, theNbSampleV);
				}
		public IntToolsCurveRangeSample SampleRangeU{
			set { 
				IntTools_SurfaceRangeSample_SetSampleRangeU(Instance, value.Instance);
			}
		}
		public IntToolsCurveRangeSample GetSampleRangeU{
			get {
				return new IntToolsCurveRangeSample(IntTools_SurfaceRangeSample_GetSampleRangeU(Instance));
			}
		}
		public IntToolsCurveRangeSample SampleRangeV{
			set { 
				IntTools_SurfaceRangeSample_SetSampleRangeV(Instance, value.Instance);
			}
		}
		public IntToolsCurveRangeSample GetSampleRangeV{
			get {
				return new IntToolsCurveRangeSample(IntTools_SurfaceRangeSample_GetSampleRangeV(Instance));
			}
		}
		public int IndexU{
			set { 
				IntTools_SurfaceRangeSample_SetIndexU(Instance, value);
			}
		}
		public int GetIndexU{
			get {
				return IntTools_SurfaceRangeSample_GetIndexU(Instance);
			}
		}
		public int IndexV{
			set { 
				IntTools_SurfaceRangeSample_SetIndexV(Instance, value);
			}
		}
		public int GetIndexV{
			get {
				return IntTools_SurfaceRangeSample_GetIndexV(Instance);
			}
		}
		public int DepthU{
			set { 
				IntTools_SurfaceRangeSample_SetDepthU(Instance, value);
			}
		}
		public int GetDepthU{
			get {
				return IntTools_SurfaceRangeSample_GetDepthU(Instance);
			}
		}
		public int DepthV{
			set { 
				IntTools_SurfaceRangeSample_SetDepthV(Instance, value);
			}
		}
		public int GetDepthV{
			get {
				return IntTools_SurfaceRangeSample_GetDepthV(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_SurfaceRangeSample_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_SurfaceRangeSample_Ctor8C6D7843(int theIndexU,int theDepthU,int theIndexV,int theDepthV);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_SurfaceRangeSample_Ctor72DC087B(IntPtr theRangeU,IntPtr theRangeV);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_SurfaceRangeSample_Ctor7CD3FA85(IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_SurfaceRangeSample_Assign7CD3FA85(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_SurfaceRangeSample_SetRanges72DC087B(IntPtr instance, IntPtr theRangeU,IntPtr theRangeV);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_SurfaceRangeSample_GetRanges72DC087B(IntPtr instance, IntPtr theRangeU,IntPtr theRangeV);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_SurfaceRangeSample_SetIndexes5107F6FE(IntPtr instance, int theIndexU,int theIndexV);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_SurfaceRangeSample_GetIndexes5107F6FE(IntPtr instance, ref int theIndexU,ref int theIndexV);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_SurfaceRangeSample_GetDepths5107F6FE(IntPtr instance, ref int theDepthU,ref int theDepthV);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_SurfaceRangeSample_GetRangeU89C01C9C(IntPtr instance, double theFirstU,double theLastU,int theNbSampleU);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_SurfaceRangeSample_GetRangeV89C01C9C(IntPtr instance, double theFirstV,double theLastV,int theNbSampleV);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_SurfaceRangeSample_IsEqual7CD3FA85(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_SurfaceRangeSample_GetRangeIndexUDeeperE8219145(IntPtr instance, int theNbSampleU);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_SurfaceRangeSample_GetRangeIndexVDeeperE8219145(IntPtr instance, int theNbSampleV);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_SurfaceRangeSample_SetSampleRangeU(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_SurfaceRangeSample_GetSampleRangeU(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_SurfaceRangeSample_SetSampleRangeV(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_SurfaceRangeSample_GetSampleRangeV(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_SurfaceRangeSample_SetIndexU(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_SurfaceRangeSample_GetIndexU(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_SurfaceRangeSample_SetIndexV(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_SurfaceRangeSample_GetIndexV(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_SurfaceRangeSample_SetDepthU(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_SurfaceRangeSample_GetDepthU(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_SurfaceRangeSample_SetDepthV(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_SurfaceRangeSample_GetDepthV(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public IntToolsSurfaceRangeSample(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntToolsSurfaceRangeSample_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntToolsSurfaceRangeSample_Dtor(IntPtr instance);
	}
}
