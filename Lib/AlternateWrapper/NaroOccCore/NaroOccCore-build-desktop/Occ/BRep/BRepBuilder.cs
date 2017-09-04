#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.Poly;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BRep
{
	public class BRepBuilder : TopoDSBuilder
	{
			public void MakeFace(TopoDSFace F)
				{
					BRep_Builder_MakeFaceAEC70AC1(Instance, F.Instance);
				}
			public void MakeFace(TopoDSFace F,GeomSurface S,double Tol)
				{
					BRep_Builder_MakeFace7EEC8D91(Instance, F.Instance, S.Instance, Tol);
				}
			public void MakeFace(TopoDSFace F,GeomSurface S,TopLocLocation L,double Tol)
				{
					BRep_Builder_MakeFaceBAA765A3(Instance, F.Instance, S.Instance, L.Instance, Tol);
				}
			public void MakeFace(TopoDSFace F,PolyTriangulation T)
				{
					BRep_Builder_MakeFaceE5A9949B(Instance, F.Instance, T.Instance);
				}
			public void UpdateFace(TopoDSFace F,GeomSurface S,TopLocLocation L,double Tol)
				{
					BRep_Builder_UpdateFaceBAA765A3(Instance, F.Instance, S.Instance, L.Instance, Tol);
				}
			public void UpdateFace(TopoDSFace F,PolyTriangulation T)
				{
					BRep_Builder_UpdateFaceE5A9949B(Instance, F.Instance, T.Instance);
				}
			public void UpdateFace(TopoDSFace F,double Tol)
				{
					BRep_Builder_UpdateFace5D6B238E(Instance, F.Instance, Tol);
				}
			public void NaturalRestriction(TopoDSFace F,bool N)
				{
					BRep_Builder_NaturalRestriction4945DBAD(Instance, F.Instance, N);
				}
			public void MakeEdge(TopoDSEdge E)
				{
					BRep_Builder_MakeEdge24263856(Instance, E.Instance);
				}
			public void MakeEdge(TopoDSEdge E,GeomCurve C,double Tol)
				{
					BRep_Builder_MakeEdgeE5AE3CE7(Instance, E.Instance, C.Instance, Tol);
				}
			public void MakeEdge(TopoDSEdge E,GeomCurve C,TopLocLocation L,double Tol)
				{
					BRep_Builder_MakeEdge686D1199(Instance, E.Instance, C.Instance, L.Instance, Tol);
				}
			public void Continuity(TopoDSEdge E,TopoDSFace F1,TopoDSFace F2,GeomAbsShape C)
				{
					BRep_Builder_ContinuityD6A3B177(Instance, E.Instance, F1.Instance, F2.Instance, (int)C);
				}
			public void Continuity(TopoDSEdge E,GeomSurface S1,GeomSurface S2,TopLocLocation L1,TopLocLocation L2,GeomAbsShape C)
				{
					BRep_Builder_ContinuityBD255723(Instance, E.Instance, S1.Instance, S2.Instance, L1.Instance, L2.Instance, (int)C);
				}
			public void SameParameter(TopoDSEdge E,bool S)
				{
					BRep_Builder_SameParameter7F8C607A(Instance, E.Instance, S);
				}
			public void SameRange(TopoDSEdge E,bool S)
				{
					BRep_Builder_SameRange7F8C607A(Instance, E.Instance, S);
				}
			public void Degenerated(TopoDSEdge E,bool D)
				{
					BRep_Builder_Degenerated7F8C607A(Instance, E.Instance, D);
				}
			public void Range(TopoDSEdge E,double First,double Last,bool Only3d)
				{
					BRep_Builder_Range7522FA9B(Instance, E.Instance, First, Last, Only3d);
				}
			public void Range(TopoDSEdge E,GeomSurface S,TopLocLocation L,double First,double Last)
				{
					BRep_Builder_Range367873C2(Instance, E.Instance, S.Instance, L.Instance, First, Last);
				}
			public void Range(TopoDSEdge E,TopoDSFace F,double First,double Last)
				{
					BRep_Builder_RangeF1087A9D(Instance, E.Instance, F.Instance, First, Last);
				}
			public void Transfert(TopoDSEdge Ein,TopoDSEdge Eout)
				{
					BRep_Builder_Transfert4DFF7017(Instance, Ein.Instance, Eout.Instance);
				}
			public void MakeVertex(TopoDSVertex V)
				{
					BRep_Builder_MakeVertex3EF07F6A(Instance, V.Instance);
				}
			public void MakeVertex(TopoDSVertex V,gpPnt P,double Tol)
				{
					BRep_Builder_MakeVertex3B977AAF(Instance, V.Instance, P.Instance, Tol);
				}
			public void UpdateVertex(TopoDSVertex V,gpPnt P,double Tol)
				{
					BRep_Builder_UpdateVertex3B977AAF(Instance, V.Instance, P.Instance, Tol);
				}
			public void UpdateVertex(TopoDSVertex V,double P,TopoDSEdge E,double Tol)
				{
					BRep_Builder_UpdateVertex4056A7EF(Instance, V.Instance, P, E.Instance, Tol);
				}
			public void UpdateVertex(TopoDSVertex V,double P,TopoDSEdge E,TopoDSFace F,double Tol)
				{
					BRep_Builder_UpdateVertex7CBB7775(Instance, V.Instance, P, E.Instance, F.Instance, Tol);
				}
			public void UpdateVertex(TopoDSVertex V,double P,TopoDSEdge E,GeomSurface S,TopLocLocation L,double Tol)
				{
					BRep_Builder_UpdateVertex2BB581FE(Instance, V.Instance, P, E.Instance, S.Instance, L.Instance, Tol);
				}
			public void UpdateVertex(TopoDSVertex Ve,double U,double V,TopoDSFace F,double Tol)
				{
					BRep_Builder_UpdateVertex7A0EDB4B(Instance, Ve.Instance, U, V, F.Instance, Tol);
				}
			public void UpdateVertex(TopoDSVertex V,double Tol)
				{
					BRep_Builder_UpdateVertex729B627B(Instance, V.Instance, Tol);
				}
			public void Transfert(TopoDSEdge Ein,TopoDSEdge Eout,TopoDSVertex Vin,TopoDSVertex Vout)
				{
					BRep_Builder_Transfert41DFC03D(Instance, Ein.Instance, Eout.Instance, Vin.Instance, Vout.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_MakeFaceAEC70AC1(IntPtr instance, IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_MakeFace7EEC8D91(IntPtr instance, IntPtr F,IntPtr S,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_MakeFaceBAA765A3(IntPtr instance, IntPtr F,IntPtr S,IntPtr L,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_MakeFaceE5A9949B(IntPtr instance, IntPtr F,IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_UpdateFaceBAA765A3(IntPtr instance, IntPtr F,IntPtr S,IntPtr L,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_UpdateFaceE5A9949B(IntPtr instance, IntPtr F,IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_UpdateFace5D6B238E(IntPtr instance, IntPtr F,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_NaturalRestriction4945DBAD(IntPtr instance, IntPtr F,bool N);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_MakeEdge24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_MakeEdgeE5AE3CE7(IntPtr instance, IntPtr E,IntPtr C,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_MakeEdge686D1199(IntPtr instance, IntPtr E,IntPtr C,IntPtr L,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_ContinuityD6A3B177(IntPtr instance, IntPtr E,IntPtr F1,IntPtr F2,int C);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_ContinuityBD255723(IntPtr instance, IntPtr E,IntPtr S1,IntPtr S2,IntPtr L1,IntPtr L2,int C);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_SameParameter7F8C607A(IntPtr instance, IntPtr E,bool S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_SameRange7F8C607A(IntPtr instance, IntPtr E,bool S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_Degenerated7F8C607A(IntPtr instance, IntPtr E,bool D);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_Range7522FA9B(IntPtr instance, IntPtr E,double First,double Last,bool Only3d);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_Range367873C2(IntPtr instance, IntPtr E,IntPtr S,IntPtr L,double First,double Last);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_RangeF1087A9D(IntPtr instance, IntPtr E,IntPtr F,double First,double Last);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_Transfert4DFF7017(IntPtr instance, IntPtr Ein,IntPtr Eout);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_MakeVertex3EF07F6A(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_MakeVertex3B977AAF(IntPtr instance, IntPtr V,IntPtr P,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_UpdateVertex3B977AAF(IntPtr instance, IntPtr V,IntPtr P,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_UpdateVertex4056A7EF(IntPtr instance, IntPtr V,double P,IntPtr E,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_UpdateVertex7CBB7775(IntPtr instance, IntPtr V,double P,IntPtr E,IntPtr F,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_UpdateVertex2BB581FE(IntPtr instance, IntPtr V,double P,IntPtr E,IntPtr S,IntPtr L,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_UpdateVertex7A0EDB4B(IntPtr instance, IntPtr Ve,double U,double V,IntPtr F,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_UpdateVertex729B627B(IntPtr instance, IntPtr V,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRep_Builder_Transfert41DFC03D(IntPtr instance, IntPtr Ein,IntPtr Eout,IntPtr Vin,IntPtr Vout);

		#region NativeInstancePtr Convert constructor

		public BRepBuilder() { } 

		public BRepBuilder(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepBuilder_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepBuilder_Dtor(IntPtr instance);
	}
}
