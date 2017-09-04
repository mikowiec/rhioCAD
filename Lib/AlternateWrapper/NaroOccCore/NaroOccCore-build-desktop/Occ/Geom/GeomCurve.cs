#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomCurve : GeomGeometry
	{
			public double TransformedParameter(double U,gpTrsf T)
				{
					return Geom_Curve_TransformedParameter9B95D054(Instance, U, T.Instance);
				}
			public double ParametricTransformation(gpTrsf T)
				{
					return Geom_Curve_ParametricTransformation72D78650(Instance, T.Instance);
				}
			public gpPnt Value(double U)
				{
					return new gpPnt(Geom_Curve_ValueD82819F3(Instance, U));
				}
		public GeomCurve Reversed{
			get {
				return new GeomCurve(Geom_Curve_Reversed(Instance));
			}
		}
		public double Period{
			get {
				return Geom_Curve_Period(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Curve_TransformedParameter9B95D054(IntPtr instance, double U,IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Curve_ParametricTransformation72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Curve_ValueD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Curve_Reversed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Curve_Period(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomCurve() { } 

		public GeomCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomCurve_Dtor(IntPtr instance);
	}
}
