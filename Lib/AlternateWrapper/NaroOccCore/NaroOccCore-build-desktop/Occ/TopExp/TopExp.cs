#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopTools;

#endregion

namespace NaroCppCore.Occ.TopExp
{
	public class TopExp : NativeInstancePtr
	{
			public static void MapShapes(TopoDSShape S,TopAbsShapeEnum T,TopToolsIndexedMapOfShape M)
				{
					TopExp_MapShapes9B2ADE8F(S.Instance, (int)T, M.Instance);
				}
			public static void MapShapes(TopoDSShape S,TopToolsIndexedMapOfShape M)
				{
					TopExp_MapShapesBBDCAF89(S.Instance, M.Instance);
				}
			public static void MapShapesAndAncestors(TopoDSShape S,TopAbsShapeEnum TS,TopAbsShapeEnum TA,TopToolsIndexedDataMapOfShapeListOfShape M)
				{
					TopExp_MapShapesAndAncestors1E6131DC(S.Instance, (int)TS, (int)TA, M.Instance);
				}
			public static TopoDSVertex FirstVertex(TopoDSEdge E,bool CumOri)
				{
					return new TopoDSVertex(TopExp_FirstVertex7F8C607A(E.Instance, CumOri));
				}
			public static TopoDSVertex LastVertex(TopoDSEdge E,bool CumOri)
				{
					return new TopoDSVertex(TopExp_LastVertex7F8C607A(E.Instance, CumOri));
				}
			public static void Vertices(TopoDSEdge E,TopoDSVertex Vfirst,TopoDSVertex Vlast,bool CumOri)
				{
					TopExp_VerticesCB378621(E.Instance, Vfirst.Instance, Vlast.Instance, CumOri);
				}
			public static void Vertices(TopoDSWire W,TopoDSVertex Vfirst,TopoDSVertex Vlast)
				{
					TopExp_Vertices1DDDA71C(W.Instance, Vfirst.Instance, Vlast.Instance);
				}
			public static bool CommonVertex(TopoDSEdge E1,TopoDSEdge E2,TopoDSVertex V)
				{
					return TopExp_CommonVertexE5EE178A(E1.Instance, E2.Instance, V.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern void TopExp_MapShapes9B2ADE8F(IntPtr S,int T,IntPtr M);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopExp_MapShapesBBDCAF89(IntPtr S,IntPtr M);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopExp_MapShapesAndAncestors1E6131DC(IntPtr S,int TS,int TA,IntPtr M);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopExp_FirstVertex7F8C607A(IntPtr E,bool CumOri);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopExp_LastVertex7F8C607A(IntPtr E,bool CumOri);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopExp_VerticesCB378621(IntPtr E,IntPtr Vfirst,IntPtr Vlast,bool CumOri);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopExp_Vertices1DDDA71C(IntPtr W,IntPtr Vfirst,IntPtr Vlast);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopExp_CommonVertexE5EE178A(IntPtr E1,IntPtr E2,IntPtr V);

		#region NativeInstancePtr Convert constructor

		public TopExp() { } 

		public TopExp(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopExp_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopExp_Dtor(IntPtr instance);
	}
}
