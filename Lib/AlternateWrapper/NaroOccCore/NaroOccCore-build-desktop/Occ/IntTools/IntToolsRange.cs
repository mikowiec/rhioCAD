#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.IntTools
{
	public class IntToolsRange : NativeInstancePtr
	{
		public IntToolsRange()
 :
			base(IntTools_Range_Ctor() )
		{}
		public IntToolsRange(double aFirst,double aLast)
 :
			base(IntTools_Range_Ctor9F0E714F(aFirst, aLast) )
		{}
			public void Range(ref double aFirst,ref double aLast)
				{
					IntTools_Range_Range9F0E714F(Instance, ref aFirst, ref aLast);
				}
		public double First{
			set { 
				IntTools_Range_SetFirst(Instance, value);
			}
			get {
				return IntTools_Range_First(Instance);
			}
		}
		public double Last{
			set { 
				IntTools_Range_SetLast(Instance, value);
			}
			get {
				return IntTools_Range_Last(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_Range_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_Range_Ctor9F0E714F(double aFirst,double aLast);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_Range_Range9F0E714F(IntPtr instance, ref double aFirst,ref double aLast);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_Range_SetFirst(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double IntTools_Range_First(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_Range_SetLast(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double IntTools_Range_Last(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public IntToolsRange(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntToolsRange_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntToolsRange_Dtor(IntPtr instance);
	}
}
