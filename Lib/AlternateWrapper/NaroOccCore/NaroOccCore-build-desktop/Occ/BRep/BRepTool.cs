#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.Poly;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.GeomAbs;

#endregion

namespace NaroCppCore.Occ.BRep
{
	public class BRepTool : NativeInstancePtr
	{
			public static bool IsClosed(TopoDSShape S)
				{
					return BRep_Tool_IsClosed9EBAC0C0(S.Instance);
				}
			public static GeomSurface Surface(TopoDSFace F,TopLocLocation L)
				{
					return new GeomSurface(BRep_Tool_SurfaceCE8D63EE(F.Instance, L.Instance));
				}
			public static GeomSurface Surface(TopoDSFace F)
				{
					return new GeomSurface(BRep_Tool_SurfaceAEC70AC1(F.Instance));
				}
			public static PolyTriangulation Triangulation(TopoDSFace F,TopLocLocation L)
				{
					return new PolyTriangulation(BRep_Tool_TriangulationCE8D63EE(F.Instance, L.Instance));
				}
			public static double Tolerance(TopoDSFace F)
				{
					return BRep_Tool_ToleranceAEC70AC1(F.Instance);
				}
			public static bool NaturalRestriction(TopoDSFace F)
				{
					return BRep_Tool_NaturalRestrictionAEC70AC1(F.Instance);
				}
			public static bool IsGeometric(TopoDSEdge E)
				{
					return BRep_Tool_IsGeometric24263856(E.Instance);
				}
			public static GeomCurve Curve(TopoDSEdge E,TopLocLocation L,ref double First,ref double Last)
				{
					return new GeomCurve(BRep_Tool_CurveC0F32C66(E.Instance, L.Instance, ref First, ref Last));
				}
			public static GeomCurve Curve(TopoDSEdge E,ref double First,ref double Last)
				{
					return new GeomCurve(BRep_Tool_Curve218243EB(E.Instance, ref First, ref Last));
				}
			public static bool IsClosed(TopoDSEdge E,TopoDSFace F)
				{
					return BRep_Tool_IsClosed65EC701C(E.Instance, F.Instance);
				}
			public static bool IsClosed(TopoDSEdge E,GeomSurface S,TopLocLocation L)
				{
					return BRep_Tool_IsClosed492F2C78(E.Instance, S.Instance, L.Instance);
				}
			public static bool IsClosed(TopoDSEdge E,PolyTriangulation T)
				{
					return BRep_Tool_IsClosed3E433981(E.Instance, T.Instance);
				}
			public static double Tolerance(TopoDSEdge E)
				{
					return BRep_Tool_Tolerance24263856(E.Instance);
				}
			public static bool SameParameter(TopoDSEdge E)
				{
					return BRep_Tool_SameParameter24263856(E.Instance);
				}
			public static bool SameRange(TopoDSEdge E)
				{
					return BRep_Tool_SameRange24263856(E.Instance);
				}
			public static bool Degenerated(TopoDSEdge E)
				{
					return BRep_Tool_Degenerated24263856(E.Instance);
				}
			public static void Range(TopoDSEdge E,ref double First,ref double Last)
				{
					BRep_Tool_Range218243EB(E.Instance, ref First, ref Last);
				}
			public static void Range(TopoDSEdge E,GeomSurface S,TopLocLocation L,ref double First,ref double Last)
				{
					BRep_Tool_Range367873C2(E.Instance, S.Instance, L.Instance, ref First, ref Last);
				}
			public static void Range(TopoDSEdge E,TopoDSFace F,ref double First,ref double Last)
				{
					BRep_Tool_RangeF1087A9D(E.Instance, F.Instance, ref First, ref Last);
				}
			public static void UVPoints(TopoDSEdge E,GeomSurface S,TopLocLocation L,gpPnt2d PFirst,gpPnt2d PLast)
				{
					BRep_Tool_UVPointsCD33147E(E.Instance, S.Instance, L.Instance, PFirst.Instance, PLast.Instance);
				}
			public static void UVPoints(TopoDSEdge E,TopoDSFace F,gpPnt2d PFirst,gpPnt2d PLast)
				{
					BRep_Tool_UVPoints6AA8D466(E.Instance, F.Instance, PFirst.Instance, PLast.Instance);
				}
			public static void SetUVPoints(TopoDSEdge E,GeomSurface S,TopLocLocation L,gpPnt2d PFirst,gpPnt2d PLast)
				{
					BRep_Tool_SetUVPointsCD33147E(E.Instance, S.Instance, L.Instance, PFirst.Instance, PLast.Instance);
				}
			public static void SetUVPoints(TopoDSEdge E,TopoDSFace F,gpPnt2d PFirst,gpPnt2d PLast)
				{
					BRep_Tool_SetUVPoints6AA8D466(E.Instance, F.Instance, PFirst.Instance, PLast.Instance);
				}
			public static bool HasContinuity(TopoDSEdge E,TopoDSFace F1,TopoDSFace F2)
				{
					return BRep_Tool_HasContinuityA211568F(E.Instance, F1.Instance, F2.Instance);
				}
			public static GeomAbsShape Continuity(TopoDSEdge E,TopoDSFace F1,TopoDSFace F2)
				{
					return (GeomAbsShape)BRep_Tool_ContinuityA211568F(E.Instance, F1.Instance, F2.Instance);
				}
			public static bool HasContinuity(TopoDSEdge E,GeomSurface S1,GeomSurface S2,TopLocLocation L1,TopLocLocation L2)
				{
					return BRep_Tool_HasContinuityF876CD3E(E.Instance, S1.Instance, S2.Instance, L1.Instance, L2.Instance);
				}
			public static GeomAbsShape Continuity(TopoDSEdge E,GeomSurface S1,GeomSurface S2,TopLocLocation L1,TopLocLocation L2)
				{
					return (GeomAbsShape)BRep_Tool_ContinuityF876CD3E(E.Instance, S1.Instance, S2.Instance, L1.Instance, L2.Instance);
				}
			public static gpPnt Pnt(TopoDSVertex V)
				{
					return new gpPnt(BRep_Tool_Pnt3EF07F6A(V.Instance));
				}
			public static double Tolerance(TopoDSVertex V)
				{
					return BRep_Tool_Tolerance3EF07F6A(V.Instance);
				}
			public static double Parameter(TopoDSVertex V,TopoDSEdge E)
				{
					return BRep_Tool_ParameterF133D096(V.Instance, E.Instance);
				}
			public static double Parameter(TopoDSVertex V,TopoDSEdge E,TopoDSFace F)
				{
					return BRep_Tool_Parameter28AFE250(V.Instance, E.Instance, F.Instance);
				}
			public static double Parameter(TopoDSVertex V,TopoDSEdge E,GeomSurface S,TopLocLocation L)
				{
					return BRep_Tool_Parameter9ECB6476(V.Instance, E.Instance, S.Instance, L.Instance);
				}
			public static gpPnt2d Parameters(TopoDSVertex V,TopoDSFace F)
				{
					return new gpPnt2d(BRep_Tool_Parameters6DF2E67(V.Instance, F.Instance));
				}
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_Tool_IsClosed9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRep_Tool_SurfaceCE8D63EE(IntPtr F,IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRep_Tool_SurfaceAEC70AC1(IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRep_Tool_TriangulationCE8D63EE(IntPtr F,IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRep_Tool_ToleranceAEC70AC1(IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_Tool_NaturalRestrictionAEC70AC1(IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_Tool_IsGeometric24263856(IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRep_Tool_CurveC0F32C66(IntPtr E,IntPtr L,ref double First,ref double Last);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRep_Tool_Curve218243EB(IntPtr E,ref double First,ref double Last);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_Tool_IsClosed65EC701C(IntPtr E,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_Tool_IsClosed492F2C78(IntPtr E,IntPtr S,IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_Tool_IsClosed3E433981(IntPtr E,IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRep_Tool_Tolerance24263856(IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_Tool_SameParameter24263856(IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_Tool_SameRange24263856(IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_Tool_Degenerated24263856(IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Tool_Range218243EB(IntPtr E,ref double First,ref double Last);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Tool_Range367873C2(IntPtr E,IntPtr S,IntPtr L,ref double First,ref double Last);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Tool_RangeF1087A9D(IntPtr E,IntPtr F,ref double First,ref double Last);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Tool_UVPointsCD33147E(IntPtr E,IntPtr S,IntPtr L,IntPtr PFirst,IntPtr PLast);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Tool_UVPoints6AA8D466(IntPtr E,IntPtr F,IntPtr PFirst,IntPtr PLast);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Tool_SetUVPointsCD33147E(IntPtr E,IntPtr S,IntPtr L,IntPtr PFirst,IntPtr PLast);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Tool_SetUVPoints6AA8D466(IntPtr E,IntPtr F,IntPtr PFirst,IntPtr PLast);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_Tool_HasContinuityA211568F(IntPtr E,IntPtr F1,IntPtr F2);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRep_Tool_ContinuityA211568F(IntPtr E,IntPtr F1,IntPtr F2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRep_Tool_HasContinuityF876CD3E(IntPtr E,IntPtr S1,IntPtr S2,IntPtr L1,IntPtr L2);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRep_Tool_ContinuityF876CD3E(IntPtr E,IntPtr S1,IntPtr S2,IntPtr L1,IntPtr L2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRep_Tool_Pnt3EF07F6A(IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRep_Tool_Tolerance3EF07F6A(IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRep_Tool_ParameterF133D096(IntPtr V,IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRep_Tool_Parameter28AFE250(IntPtr V,IntPtr E,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRep_Tool_Parameter9ECB6476(IntPtr V,IntPtr E,IntPtr S,IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRep_Tool_Parameters6DF2E67(IntPtr V,IntPtr F);

		#region NativeInstancePtr Convert constructor

		public BRepTool() { } 

		public BRepTool(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepTool_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTool_Dtor(IntPtr instance);
	}
}
