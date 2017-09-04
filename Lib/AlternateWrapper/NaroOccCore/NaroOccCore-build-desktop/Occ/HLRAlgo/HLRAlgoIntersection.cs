#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopAbs;

#endregion

namespace NaroCppCore.Occ.HLRAlgo
{
	public class HLRAlgoIntersection : NativeInstancePtr
	{
		public HLRAlgoIntersection()
 :
			base(HLRAlgo_Intersection_Ctor() )
		{}
		public HLRAlgoIntersection(TopAbsOrientation Ori,int Lev,int SegInd,int Ind,double P,double Tol,TopAbsState S)
 :
			base(HLRAlgo_Intersection_CtorFF238ADF((int)Ori, Lev, SegInd, Ind, P, Tol, (int)S) )
		{}
			public void Orientation(TopAbsOrientation Ori)
				{
					HLRAlgo_Intersection_Orientation69EAD1AB(Instance, (int)Ori);
				}
			public TopAbsOrientation Orientation()
				{
					return (TopAbsOrientation)HLRAlgo_Intersection_Orientation(Instance);
				}
			public void Level(int Lev)
				{
					HLRAlgo_Intersection_LevelE8219145(Instance, Lev);
				}
			public int Level()
				{
					return HLRAlgo_Intersection_Level(Instance);
				}
			public void SegIndex(int SegInd)
				{
					HLRAlgo_Intersection_SegIndexE8219145(Instance, SegInd);
				}
			public int SegIndex()
				{
					return HLRAlgo_Intersection_SegIndex(Instance);
				}
			public void Index(int Ind)
				{
					HLRAlgo_Intersection_IndexE8219145(Instance, Ind);
				}
			public int Index()
				{
					return HLRAlgo_Intersection_Index(Instance);
				}
			public void Parameter(double P)
				{
					HLRAlgo_Intersection_ParameterD82819F3(Instance, P);
				}
			public double Parameter()
				{
					return HLRAlgo_Intersection_Parameter(Instance);
				}
			public void Tolerance(double T)
				{
					HLRAlgo_Intersection_ToleranceD82819F3(Instance, T);
				}
			public double Tolerance()
				{
					return HLRAlgo_Intersection_Tolerance(Instance);
				}
			public void State(TopAbsState S)
				{
					HLRAlgo_Intersection_StateD70DF52B(Instance, (int)S);
				}
			public TopAbsState State()
				{
					return (TopAbsState)HLRAlgo_Intersection_State(Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr HLRAlgo_Intersection_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr HLRAlgo_Intersection_CtorFF238ADF(int Ori,int Lev,int SegInd,int Ind,double P,double Tol,int S);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Intersection_Orientation69EAD1AB(IntPtr instance, int Ori);
		[DllImport("NaroOccCore.dll")]
		private static extern int HLRAlgo_Intersection_Orientation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Intersection_LevelE8219145(IntPtr instance, int Lev);
		[DllImport("NaroOccCore.dll")]
		private static extern int HLRAlgo_Intersection_Level(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Intersection_SegIndexE8219145(IntPtr instance, int SegInd);
		[DllImport("NaroOccCore.dll")]
		private static extern int HLRAlgo_Intersection_SegIndex(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Intersection_IndexE8219145(IntPtr instance, int Ind);
		[DllImport("NaroOccCore.dll")]
		private static extern int HLRAlgo_Intersection_Index(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Intersection_ParameterD82819F3(IntPtr instance, double P);
		[DllImport("NaroOccCore.dll")]
		private static extern double HLRAlgo_Intersection_Parameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Intersection_ToleranceD82819F3(IntPtr instance, double T);
		[DllImport("NaroOccCore.dll")]
		private static extern double HLRAlgo_Intersection_Tolerance(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Intersection_StateD70DF52B(IntPtr instance, int S);
		[DllImport("NaroOccCore.dll")]
		private static extern int HLRAlgo_Intersection_State(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public HLRAlgoIntersection(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ HLRAlgoIntersection_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgoIntersection_Dtor(IntPtr instance);
	}
}
