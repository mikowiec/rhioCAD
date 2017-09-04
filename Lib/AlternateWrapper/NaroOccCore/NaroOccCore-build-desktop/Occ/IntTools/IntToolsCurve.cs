#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.IntTools
{
	public class IntToolsCurve : NativeInstancePtr
	{
		public IntToolsCurve()
 :
			base(IntTools_Curve_Ctor() )
		{}
			public void Bounds(ref double aT1,ref double aT2,gpPnt aP1,gpPnt aP2)
				{
					IntTools_Curve_BoundsB51F241F(Instance, ref aT1, ref aT2, aP1.Instance, aP2.Instance);
				}
			public bool D0(ref double aT1,gpPnt aP1)
				{
					return IntTools_Curve_D053A5A2C1(Instance, ref aT1, aP1.Instance);
				}
		public GeomCurve Curve{
			set { 
				IntTools_Curve_SetCurve(Instance, value.Instance);
			}
			get {
				return new GeomCurve(IntTools_Curve_Curve(Instance));
			}
		}
		public bool HasBounds{
			get {
				return IntTools_Curve_HasBounds(Instance);
			}
		}
		public GeomAbsCurveType Type{
			get {
				return (GeomAbsCurveType)IntTools_Curve_Type(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_Curve_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_Curve_BoundsB51F241F(IntPtr instance, ref double aT1,ref double aT2,IntPtr aP1,IntPtr aP2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_Curve_D053A5A2C1(IntPtr instance, ref double aT1,IntPtr aP1);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_Curve_SetCurve(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_Curve_Curve(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_Curve_HasBounds(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_Curve_Type(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public IntToolsCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntToolsCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntToolsCurve_Dtor(IntPtr instance);
	}
}
