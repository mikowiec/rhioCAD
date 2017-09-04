#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepFilletAPI;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BRepFilletAPI
{
	public class BRepFilletAPIMakeChamfer : BRepFilletAPILocalOperation
	{
		public BRepFilletAPIMakeChamfer(TopoDSShape S)
 :
			base(BRepFilletAPI_MakeChamfer_Ctor9EBAC0C0(S.Instance) )
		{}
			public void Add(TopoDSEdge E)
				{
					BRepFilletAPI_MakeChamfer_Add24263856(Instance, E.Instance);
				}
			public void Add(double Dis,TopoDSEdge E,TopoDSFace F)
				{
					BRepFilletAPI_MakeChamfer_Add36F68A5F(Instance, Dis, E.Instance, F.Instance);
				}
			public void SetDist(double Dis,int IC,TopoDSFace F)
				{
					BRepFilletAPI_MakeChamfer_SetDist264F3866(Instance, Dis, IC, F.Instance);
				}
			public void GetDist(int IC,ref double Dis)
				{
					BRepFilletAPI_MakeChamfer_GetDist69F5FCCD(Instance, IC, ref Dis);
				}
			public void Add(double Dis1,double Dis2,TopoDSEdge E,TopoDSFace F)
				{
					BRepFilletAPI_MakeChamfer_Add17BBF1FC(Instance, Dis1, Dis2, E.Instance, F.Instance);
				}
			public void SetDists(double Dis1,double Dis2,int IC,TopoDSFace F)
				{
					BRepFilletAPI_MakeChamfer_SetDists5071FCAE(Instance, Dis1, Dis2, IC, F.Instance);
				}
			public void Dists(int IC,ref double Dis1,ref double Dis2)
				{
					BRepFilletAPI_MakeChamfer_Dists306E0DFB(Instance, IC, ref Dis1, ref Dis2);
				}
			public void AddDA(double Dis,double Angle,TopoDSEdge E,TopoDSFace F)
				{
					BRepFilletAPI_MakeChamfer_AddDA17BBF1FC(Instance, Dis, Angle, E.Instance, F.Instance);
				}
			public void SetDistAngle(double Dis,double Angle,int IC,TopoDSFace F)
				{
					BRepFilletAPI_MakeChamfer_SetDistAngle5071FCAE(Instance, Dis, Angle, IC, F.Instance);
				}
			public bool IsSymetric(int IC)
				{
					return BRepFilletAPI_MakeChamfer_IsSymetricE8219145(Instance, IC);
				}
			public bool IsTwoDistances(int IC)
				{
					return BRepFilletAPI_MakeChamfer_IsTwoDistancesE8219145(Instance, IC);
				}
			public bool IsDistanceAngle(int IC)
				{
					return BRepFilletAPI_MakeChamfer_IsDistanceAngleE8219145(Instance, IC);
				}
			public void ResetContour(int IC)
				{
					BRepFilletAPI_MakeChamfer_ResetContourE8219145(Instance, IC);
				}
			public int Contour(TopoDSEdge E)
				{
					return BRepFilletAPI_MakeChamfer_Contour24263856(Instance, E.Instance);
				}
			public int NbEdges(int I)
				{
					return BRepFilletAPI_MakeChamfer_NbEdgesE8219145(Instance, I);
				}
			public TopoDSEdge Edge(int I,int J)
				{
					return new TopoDSEdge(BRepFilletAPI_MakeChamfer_Edge5107F6FE(Instance, I, J));
				}
			public void Remove(TopoDSEdge E)
				{
					BRepFilletAPI_MakeChamfer_Remove24263856(Instance, E.Instance);
				}
			public double Length(int IC)
				{
					return BRepFilletAPI_MakeChamfer_LengthE8219145(Instance, IC);
				}
			public TopoDSVertex FirstVertex(int IC)
				{
					return new TopoDSVertex(BRepFilletAPI_MakeChamfer_FirstVertexE8219145(Instance, IC));
				}
			public TopoDSVertex LastVertex(int IC)
				{
					return new TopoDSVertex(BRepFilletAPI_MakeChamfer_LastVertexE8219145(Instance, IC));
				}
			public double Abscissa(int IC,TopoDSVertex V)
				{
					return BRepFilletAPI_MakeChamfer_Abscissa680D393(Instance, IC, V.Instance);
				}
			public double RelativeAbscissa(int IC,TopoDSVertex V)
				{
					return BRepFilletAPI_MakeChamfer_RelativeAbscissa680D393(Instance, IC, V.Instance);
				}
			public bool ClosedAndTangent(int IC)
				{
					return BRepFilletAPI_MakeChamfer_ClosedAndTangentE8219145(Instance, IC);
				}
			public bool Closed(int IC)
				{
					return BRepFilletAPI_MakeChamfer_ClosedE8219145(Instance, IC);
				}
			public void Build()
				{
					BRepFilletAPI_MakeChamfer_Build(Instance);
				}
			public void Reset()
				{
					BRepFilletAPI_MakeChamfer_Reset(Instance);
				}
			public bool IsDeleted(TopoDSShape F)
				{
					return BRepFilletAPI_MakeChamfer_IsDeleted9EBAC0C0(Instance, F.Instance);
				}
			public void Simulate(int IC)
				{
					BRepFilletAPI_MakeChamfer_SimulateE8219145(Instance, IC);
				}
			public int NbSurf(int IC)
				{
					return BRepFilletAPI_MakeChamfer_NbSurfE8219145(Instance, IC);
				}
		public int NbContours{
			get {
				return BRepFilletAPI_MakeChamfer_NbContours(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeChamfer_Ctor9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_Add24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_Add36F68A5F(IntPtr instance, double Dis,IntPtr E,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_SetDist264F3866(IntPtr instance, double Dis,int IC,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_GetDist69F5FCCD(IntPtr instance, int IC,ref double Dis);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_Add17BBF1FC(IntPtr instance, double Dis1,double Dis2,IntPtr E,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_SetDists5071FCAE(IntPtr instance, double Dis1,double Dis2,int IC,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_Dists306E0DFB(IntPtr instance, int IC,ref double Dis1,ref double Dis2);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_AddDA17BBF1FC(IntPtr instance, double Dis,double Angle,IntPtr E,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_SetDistAngle5071FCAE(IntPtr instance, double Dis,double Angle,int IC,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeChamfer_IsSymetricE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeChamfer_IsTwoDistancesE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeChamfer_IsDistanceAngleE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_ResetContourE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeChamfer_Contour24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeChamfer_NbEdgesE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeChamfer_Edge5107F6FE(IntPtr instance, int I,int J);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_Remove24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepFilletAPI_MakeChamfer_LengthE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeChamfer_FirstVertexE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepFilletAPI_MakeChamfer_LastVertexE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepFilletAPI_MakeChamfer_Abscissa680D393(IntPtr instance, int IC,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepFilletAPI_MakeChamfer_RelativeAbscissa680D393(IntPtr instance, int IC,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeChamfer_ClosedAndTangentE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeChamfer_ClosedE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_Build(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_Reset(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepFilletAPI_MakeChamfer_IsDeleted9EBAC0C0(IntPtr instance, IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPI_MakeChamfer_SimulateE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeChamfer_NbSurfE8219145(IntPtr instance, int IC);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepFilletAPI_MakeChamfer_NbContours(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepFilletAPIMakeChamfer() { } 

		public BRepFilletAPIMakeChamfer(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepFilletAPIMakeChamfer_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepFilletAPIMakeChamfer_Dtor(IntPtr instance);
	}
}
