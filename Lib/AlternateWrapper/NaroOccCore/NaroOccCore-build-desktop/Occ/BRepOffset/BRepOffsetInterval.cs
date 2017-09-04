#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepOffset;

#endregion

namespace NaroCppCore.Occ.BRepOffset
{
	public class BRepOffsetInterval : NativeInstancePtr
	{
		public BRepOffsetInterval()
 :
			base(BRepOffset_Interval_Ctor() )
		{}
		public BRepOffsetInterval(double U1,double U2,BRepOffsetType Type)
 :
			base(BRepOffset_Interval_CtorF3B48FAD(U1, U2, (int)Type) )
		{}
			public void First(double U)
				{
					BRepOffset_Interval_FirstD82819F3(Instance, U);
				}
			public void Last(double U)
				{
					BRepOffset_Interval_LastD82819F3(Instance, U);
				}
			public void Type(BRepOffsetType T)
				{
					BRepOffset_Interval_TypeFFDE8065(Instance, (int)T);
				}
			public double First()
				{
					return BRepOffset_Interval_First(Instance);
				}
			public double Last()
				{
					return BRepOffset_Interval_Last(Instance);
				}
			public BRepOffsetType Type()
				{
					return (BRepOffsetType)BRepOffset_Interval_Type(Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffset_Interval_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffset_Interval_CtorF3B48FAD(double U1,double U2,int Type);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffset_Interval_FirstD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffset_Interval_LastD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffset_Interval_TypeFFDE8065(IntPtr instance, int T);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepOffset_Interval_First(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepOffset_Interval_Last(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepOffset_Interval_Type(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepOffsetInterval(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepOffsetInterval_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetInterval_Dtor(IntPtr instance);
	}
}
