#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.Bnd;
using NaroCppCore.Occ.TopTools;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.BRep;

#endregion

namespace NaroCppCore.Occ.BRepTools
{
	public class BRepTools : NativeInstancePtr
	{
			public static void UVBounds(TopoDSFace F,ref double UMin,ref double UMax,ref double VMin,ref double VMax)
				{
					BRepTools_UVBounds443C7451(F.Instance, ref UMin, ref UMax, ref VMin, ref VMax);
				}
			public static void UVBounds(TopoDSFace F,TopoDSWire W,ref double UMin,ref double UMax,ref double VMin,ref double VMax)
				{
					BRepTools_UVBoundsEF82485C(F.Instance, W.Instance, ref UMin, ref UMax, ref VMin, ref VMax);
				}
			public static void UVBounds(TopoDSFace F,TopoDSEdge E,ref double UMin,ref double UMax,ref double VMin,ref double VMax)
				{
					BRepTools_UVBounds5F413ED6(F.Instance, E.Instance, ref UMin, ref UMax, ref VMin, ref VMax);
				}
			public static void AddUVBounds(TopoDSFace F,BndBox2d B)
				{
					BRepTools_AddUVBounds38403D27(F.Instance, B.Instance);
				}
			public static void AddUVBounds(TopoDSFace F,TopoDSWire W,BndBox2d B)
				{
					BRepTools_AddUVBounds3ADDD719(F.Instance, W.Instance, B.Instance);
				}
			public static void AddUVBounds(TopoDSFace F,TopoDSEdge E,BndBox2d B)
				{
					BRepTools_AddUVBounds5756543C(F.Instance, E.Instance, B.Instance);
				}
			public static void Update(TopoDSVertex V)
				{
					BRepTools_Update3EF07F6A(V.Instance);
				}
			public static void Update(TopoDSEdge E)
				{
					BRepTools_Update24263856(E.Instance);
				}
			public static void Update(TopoDSWire W)
				{
					BRepTools_Update368EDFE5(W.Instance);
				}
			public static void Update(TopoDSFace F)
				{
					BRepTools_UpdateAEC70AC1(F.Instance);
				}
			public static void Update(TopoDSShell S)
				{
					BRepTools_Update41B0EE4D(S.Instance);
				}
			public static void Update(TopoDSSolid S)
				{
					BRepTools_Update56111E92(S.Instance);
				}
			public static void Update(TopoDSCompSolid C)
				{
					BRepTools_Update2CBA9E0B(C.Instance);
				}
			public static void Update(TopoDSCompound C)
				{
					BRepTools_UpdateF7963FEC(C.Instance);
				}
			public static void Update(TopoDSShape S)
				{
					BRepTools_Update9EBAC0C0(S.Instance);
				}
			public static void UpdateFaceUVPoints(TopoDSFace F)
				{
					BRepTools_UpdateFaceUVPointsAEC70AC1(F.Instance);
				}
			public static void Clean(TopoDSShape S)
				{
					BRepTools_Clean9EBAC0C0(S.Instance);
				}
			public static void RemoveUnusedPCurves(TopoDSShape S)
				{
					BRepTools_RemoveUnusedPCurves9EBAC0C0(S.Instance);
				}
			public static bool Triangulation(TopoDSShape S,double deflec)
				{
					return BRepTools_Triangulation92EB56FA(S.Instance, deflec);
				}
			public static bool Compare(TopoDSVertex V1,TopoDSVertex V2)
				{
					return BRepTools_Compare17F57B4B(V1.Instance, V2.Instance);
				}
			public static bool Compare(TopoDSEdge E1,TopoDSEdge E2)
				{
					return BRepTools_Compare4DFF7017(E1.Instance, E2.Instance);
				}
			public static TopoDSWire OuterWire(TopoDSFace F)
				{
					return new TopoDSWire(BRepTools_OuterWireAEC70AC1(F.Instance));
				}
			public static TopoDSShell OuterShell(TopoDSSolid S)
				{
					return new TopoDSShell(BRepTools_OuterShell56111E92(S.Instance));
				}
			public static void Map3DEdges(TopoDSShape S,TopToolsIndexedMapOfShape M)
				{
					BRepTools_Map3DEdgesBBDCAF89(S.Instance, M.Instance);
				}
			public static bool IsReallyClosed(TopoDSEdge E,TopoDSFace F)
				{
					return BRepTools_IsReallyClosed65EC701C(E.Instance, F.Instance);
				}
			public static bool Write(TopoDSShape Sh,string File,MessageProgressIndicator PR)
				{
					return BRepTools_Write4AF8BC88(Sh.Instance, File, PR.Instance);
				}
			public static bool Read(TopoDSShape Sh,string File,BRepBuilder B,MessageProgressIndicator PR)
				{
					return BRepTools_ReadEBEE9A3E(Sh.Instance, File, B.Instance, PR.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_UVBounds443C7451(IntPtr F,ref double UMin,ref double UMax,ref double VMin,ref double VMax);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_UVBoundsEF82485C(IntPtr F,IntPtr W,ref double UMin,ref double UMax,ref double VMin,ref double VMax);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_UVBounds5F413ED6(IntPtr F,IntPtr E,ref double UMin,ref double UMax,ref double VMin,ref double VMax);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_AddUVBounds38403D27(IntPtr F,IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_AddUVBounds3ADDD719(IntPtr F,IntPtr W,IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_AddUVBounds5756543C(IntPtr F,IntPtr E,IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_Update3EF07F6A(IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_Update24263856(IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_Update368EDFE5(IntPtr W);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_UpdateAEC70AC1(IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_Update41B0EE4D(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_Update56111E92(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_Update2CBA9E0B(IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_UpdateF7963FEC(IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_Update9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_UpdateFaceUVPointsAEC70AC1(IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_Clean9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_RemoveUnusedPCurves9EBAC0C0(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepTools_Triangulation92EB56FA(IntPtr S,double deflec);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepTools_Compare17F57B4B(IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepTools_Compare4DFF7017(IntPtr E1,IntPtr E2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepTools_OuterWireAEC70AC1(IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepTools_OuterShell56111E92(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_Map3DEdgesBBDCAF89(IntPtr S,IntPtr M);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepTools_IsReallyClosed65EC701C(IntPtr E,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepTools_Write4AF8BC88(IntPtr Sh,string File,IntPtr PR);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepTools_ReadEBEE9A3E(IntPtr Sh,string File,IntPtr B,IntPtr PR);

		#region NativeInstancePtr Convert constructor

		public BRepTools() { } 

		public BRepTools(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepTools_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_Dtor(IntPtr instance);
	}
}
