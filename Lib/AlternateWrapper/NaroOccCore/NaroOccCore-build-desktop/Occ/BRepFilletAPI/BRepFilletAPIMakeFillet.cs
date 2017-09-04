#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepFilletAPI;
using NaroCppCore.Occ.ChFi3d;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.Law;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.ChFiDS;

#endregion

namespace NaroCppCore.Occ.BRepFilletAPI
{
	public class BRepFilletAPIMakeFillet : BRepFilletAPILocalOperation
	{
		public BRepFilletAPIMakeFillet(TopoDSShape S,ChFi3dFilletShape FShape)
 :
			base(BRepFilletAPI_MakeFillet_Ctor64E28302(S.Instance, (int)FShape) )
		{}
			public void SetParams(double Tang,double Tesp,double T2d,double TApp3d,double TolApp2d,double Fleche)
				{
					BRepFilletAPI_MakeFillet_SetParamsBC7A5786(Instance, Tang, Tesp, T2d, TApp3d, TolApp2d, Fleche);
				}
			public void SetContinuity(GeomAbsShape InternalContinuity,double AngularTolerance)
				{
					BRepFilletAPI_MakeFillet_SetContinuity25CDA01E(Instance, (int)InternalContinuity, AngularTolerance);
				}
			public void Add(TopoDSEdge E)
				{
					BRepFilletAPI_MakeFillet_Add24263856(Instance, E.Instance);
				}
			public void Add(double Radius,TopoDSEdge E)
				{
					BRepFilletAPI_MakeFillet_Add4236945C(Instance, Radius, E.Instance);
				}
			public void Add(double R1,double R2,TopoDSEdge E)
				{
					BRepFilletAPI_MakeFillet_AddA7A851FF(Instance, R1, R2, E.Instance);
				}
			public void Add(LawFunction L,TopoDSEdge E)
				{
					BRepFilletAPI_MakeFillet_Add1E23979B(Instance, L.Instance, E.Instance);
				}
			public void SetRadius(double Radius,int IC,int IinC)
				{
					BRepFilletAPI_MakeFillet_SetRadius6B6E73CA(Instance, Radius, IC, IinC);
				}
			public void SetRadius(double R1,double R2,int IC,int IinC)
				{
					BRepFilletAPI_MakeFillet_SetRadius852507E(Instance, R1, R2, IC, IinC);
				}
			public void SetRadius(LawFunction L,int IC,int IinC)
				{
					BRepFilletAPI_MakeFillet_SetRadiusE982E75B(Instance, L.Instance, IC, IinC);
				}
			public void ResetContour(int IC)
				{
					BRepFilletAPI_MakeFillet_ResetContourE8219145(Instance, IC);
				}
			public bool IsConstant(int IC)
				{
					return BRepFilletAPI_MakeFillet_IsConstantE8219145(Instance, IC);
				}
			public double Radius(int IC)
				{
					return BRepFilletAPI_MakeFillet_RadiusE8219145(Instance, IC);
				}
			public bool IsConstant(int IC,TopoDSEdge E)
				{
					return BRepFilletAPI_MakeFillet_IsConstant9ED07AFD(Instance, IC, E.Instance);
				}
			public double Radius(int IC,TopoDSEdge E)
				{
					return BRepFilletAPI_MakeFillet_Radius9ED07AFD(Instance, IC, E.Instance);
				}
			public void SetRadius(double Radius,int IC,TopoDSEdge E)
				{
					BRepFilletAPI_MakeFillet_SetRadius3B769637(Instance, Radius, IC, E.Instance);
				}
			public void SetRadius(double Radius,int IC,TopoDSVertex V)
				{
					BRepFilletAPI_MakeFillet_SetRadiusD24B0016(Instance, Radius, IC, V.Instance);
				}
			public bool GetBounds(int IC,TopoDSEdge E,ref double F,ref double L)
				{
					return BRepFilletAPI_MakeFillet_GetBoundsD04B1C17(Instance, IC, E.Instance, ref F, ref L);
				}
			public LawFunction GetLaw(int IC,TopoDSEdge E)
				{
					return new LawFunction(BRepFilletAPI_MakeFillet_GetLaw9ED07AFD(Instance, IC, E.Instance));
				}
			public void SetLaw(int IC,TopoDSEdge E,LawFunction L)
				{
					BRepFilletAPI_MakeFillet_SetLawB084795E(Instance, IC, E.Instance, L.Instance);
				}
			public int Contour(TopoDSEdge E)
				{
					return BRepFilletAPI_MakeFillet_Contour24263856(Instance, E.Instance);
				}
			public int NbEdges(int I)
				{
					return BRepFilletAPI_MakeFillet_NbEdgesE8219145(Instance, I);
				}
			public TopoDSEdge Edge(int I,int J)
				{
					return new TopoDSEdge(BRepFilletAPI_MakeFillet_Edge5107F6FE(Instance, I, J));
				}
			public void Remove(TopoDSEdge E)
				{
					BRepFilletAPI_MakeFillet_Remove24263856(Instance, E.Instance);
				}
			public double Length(int IC)
				{
					return BRepFilletAPI_MakeFillet_LengthE8219145(Instance, IC);
				}
			public TopoDSVertex FirstVertex(int IC)
				{
					return new TopoDSVertex(BRepFilletAPI_MakeFillet_FirstVertexE8219145(Instance, IC));
				}
			public TopoDSVertex LastVertex(int IC)
				{
					return new TopoDSVertex(BRepFilletAPI_MakeFillet_LastVertexE8219145(Instance, IC));
				}
			public double Abscissa(int IC,TopoDSVertex V)
				{
					return BRepFilletAPI_MakeFillet_Abscissa680D393(Instance, IC, V.Instance);
				}
			public double RelativeAbscissa(int IC,TopoDSVertex V)
				{
					return BRepFilletAPI_MakeFillet_RelativeAbscissa680D393(Instance, IC, V.Instance);
				}
			public bool ClosedAndTangent(int IC)
				{
					return BRepFilletAPI_MakeFillet_ClosedAndTangentE8219145(Instance, IC);
				}
			public bool Closed(int IC)
				{
					return BRepFilletAPI_MakeFillet_ClosedE8219145(Instance, IC);
				}
			public void Build()
				{
					BRepFilletAPI_MakeFillet_Build(Instance);
				}
			public void Reset()
				{
					BRepFilletAPI_MakeFillet_Reset(Instance);
				}
			public bool IsDeleted(TopoDSShape F)
				{
					return BRepFilletAPI_MakeFillet_IsDeleted9EBAC0C0(Instance, F.Instance);
				}
			public void Simulate(int IC)
				{
					BRepFilletAPI_MakeFillet_SimulateE8219145(Instance, IC);
				}
			public int NbSurf(int IC)
				{
					return BRepFilletAPI_MakeFillet_NbSurfE8219145(Instance, IC);
				}
			public int FaultyContour(int I)
				{
					return BRepFilletAPI_MakeFillet_FaultyContourE8219145(Instance, I);
				}
			public int NbComputedSurfaces(int IC)
				{
					return BRepFilletAPI_MakeFillet_NbComputedSurfacesE8219145(Instance, IC);
				}
			public GeomSurface ComputedSurface(int IC,int IS)
				{
					return new GeomSurface(BRepFilletAPI_MakeFillet_ComputedSurface5107F6FE(Instance, IC, IS));
				}
			public TopoDSVertex FaultyVertex(int IV)
				{
					return new TopoDSVertex(BRepFilletAPI_MakeFillet_FaultyVertexE8219145(Instance, IV));
				}
			public ChFiDSErrorStatus StripeStatus(int IC)
				{
					return (ChFiDSErrorStatus)BRepFilletAPI_MakeFillet_StripeStatusE8219145(Instance, IC);
				}
		public ChFi3dFilletShape FilletShape{
			set { 
				BRepFilletAPI_MakeFillet_SetFilletShape(Instance, (int)value);
			}
		}
		public ChFi3dFilletShape GetFilletShape{
			get {
				return (ChFi3dFilletShape)BRepFilletAPI_MakeFillet_GetFilletShape(Instance);
			}
		}
		public int NbContours{
			get {
				return BRepFilletAPI_MakeFillet_NbContours(Instance);
			}
		}
		public int NbSurfaces{
			get {
				return BRepFilletAPI_MakeFillet_NbSurfaces(Instance);
			}
		}
		public int NbFaultyContours{
			get {
				return BRepFilletAPI_MakeFillet_NbFaultyContours(Instance);
			}
		}
		public int NbFaultyVertices{
			get {
				return BRepFilletAPI_MakeFillet_NbFaultyVertices(Instance);
			}
		}
		public bool HasResult{
			get {
				return BRepFilletAPI_MakeFillet_HasResult(Instance);
			}
		}
		public TopoDSShape BadShape{
			get {
				return new TopoDSShape(BRepFilletAPI_MakeFillet_BadShape(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet_Ctor64E28302(IntPtr S,int FShape);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_SetParamsBC7A5786(IntPtr instance, double Tang,double Tesp,double T2d,double TApp3d,double TolApp2d,double Fleche);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_SetContinuity25CDA01E(IntPtr instance, int InternalContinuity,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_Add24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_Add4236945C(IntPtr instance, double Radius,IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_AddA7A851FF(IntPtr instance, double R1,double R2,IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_Add1E23979B(IntPtr instance, IntPtr L,IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_SetRadius6B6E73CA(IntPtr instance, double Radius,int IC,int IinC);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_SetRadius852507E(IntPtr instance, double R1,double R2,int IC,int IinC);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_SetRadiusE982E75B(IntPtr instance, IntPtr L,int IC,int IinC);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_ResetContourE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeFillet_IsConstantE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepFilletAPI_MakeFillet_RadiusE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeFillet_IsConstant9ED07AFD(IntPtr instance, int IC,IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepFilletAPI_MakeFillet_Radius9ED07AFD(IntPtr instance, int IC,IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_SetRadius3B769637(IntPtr instance, double Radius,int IC,IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_SetRadiusD24B0016(IntPtr instance, double Radius,int IC,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeFillet_GetBoundsD04B1C17(IntPtr instance, int IC,IntPtr E,ref double F,ref double L);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet_GetLaw9ED07AFD(IntPtr instance, int IC,IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_SetLawB084795E(IntPtr instance, int IC,IntPtr E,IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet_Contour24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet_NbEdgesE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet_Edge5107F6FE(IntPtr instance, int I,int J);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_Remove24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepFilletAPI_MakeFillet_LengthE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet_FirstVertexE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet_LastVertexE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepFilletAPI_MakeFillet_Abscissa680D393(IntPtr instance, int IC,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepFilletAPI_MakeFillet_RelativeAbscissa680D393(IntPtr instance, int IC,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeFillet_ClosedAndTangentE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeFillet_ClosedE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_Build(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_Reset(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeFillet_IsDeleted9EBAC0C0(IntPtr instance, IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_SimulateE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet_NbSurfE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet_FaultyContourE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet_NbComputedSurfacesE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet_ComputedSurface5107F6FE(IntPtr instance, int IC,int IS);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet_FaultyVertexE8219145(IntPtr instance, int IV);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet_StripeStatusE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeFillet_SetFilletShape(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet_GetFilletShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet_NbContours(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet_NbSurfaces(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet_NbFaultyContours(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeFillet_NbFaultyVertices(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeFillet_HasResult(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeFillet_BadShape(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepFilletAPIMakeFillet() { } 

		public BRepFilletAPIMakeFillet(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepFilletAPIMakeFillet_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPIMakeFillet_Dtor(IntPtr instance);
	}
}
