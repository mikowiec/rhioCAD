#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.TopLoc;

#endregion

namespace NaroCppCore.Occ.BRep
{
	public class BRepPointRepresentation : MMgtTShared
	{
			public bool IsPointOnCurve()
				{
					return BRep_PointRepresentation_IsPointOnCurve(Instance);
				}
			public bool IsPointOnCurveOnSurface()
				{
					return BRep_PointRepresentation_IsPointOnCurveOnSurface(Instance);
				}
			public bool IsPointOnSurface()
				{
					return BRep_PointRepresentation_IsPointOnSurface(Instance);
				}
			public bool IsPointOnCurve(GeomCurve C,TopLocLocation L)
				{
					return BRep_PointRepresentation_IsPointOnCurveB3769532(Instance, C.Instance, L.Instance);
				}
			public bool IsPointOnSurface(GeomSurface S,TopLocLocation L)
				{
					return BRep_PointRepresentation_IsPointOnSurface7C521807(Instance, S.Instance, L.Instance);
				}
			public TopLocLocation Location()
				{
					return new TopLocLocation(BRep_PointRepresentation_Location(Instance));
				}
			public void Location(TopLocLocation L)
				{
					BRep_PointRepresentation_Location15DCA881(Instance, L.Instance);
				}
			public double Parameter()
				{
					return BRep_PointRepresentation_Parameter(Instance);
				}
			public void Parameter(double P)
				{
					BRep_PointRepresentation_ParameterD82819F3(Instance, P);
				}
			public double Parameter2()
				{
					return BRep_PointRepresentation_Parameter2(Instance);
				}
			public void Parameter2(double P)
				{
					BRep_PointRepresentation_Parameter2D82819F3(Instance, P);
				}
			public GeomCurve Curve()
				{
					return new GeomCurve(BRep_PointRepresentation_Curve(Instance));
				}
			public void Curve(GeomCurve C)
				{
					BRep_PointRepresentation_CurveFF608AE4(Instance, C.Instance);
				}
			public GeomSurface Surface()
				{
					return new GeomSurface(BRep_PointRepresentation_Surface(Instance));
				}
			public void Surface(GeomSurface S)
				{
					BRep_PointRepresentation_Surface9001466F(Instance, S.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_PointRepresentation_IsPointOnCurve(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_PointRepresentation_IsPointOnCurveOnSurface(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_PointRepresentation_IsPointOnSurface(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_PointRepresentation_IsPointOnCurveB3769532(IntPtr instance, IntPtr C,IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_PointRepresentation_IsPointOnSurface7C521807(IntPtr instance, IntPtr S,IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRep_PointRepresentation_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_PointRepresentation_Location15DCA881(IntPtr instance, IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRep_PointRepresentation_Parameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_PointRepresentation_ParameterD82819F3(IntPtr instance, double P);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRep_PointRepresentation_Parameter2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_PointRepresentation_Parameter2D82819F3(IntPtr instance, double P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRep_PointRepresentation_Curve(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_PointRepresentation_CurveFF608AE4(IntPtr instance, IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRep_PointRepresentation_Surface(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_PointRepresentation_Surface9001466F(IntPtr instance, IntPtr S);

		#region NativeInstancePtr Convert constructor

		public BRepPointRepresentation() { } 

		public BRepPointRepresentation(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepPointRepresentation_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPointRepresentation_Dtor(IntPtr instance);
	}
}
