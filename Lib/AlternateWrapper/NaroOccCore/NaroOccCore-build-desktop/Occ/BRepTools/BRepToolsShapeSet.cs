#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopTools;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopAbs;

#endregion

namespace NaroCppCore.Occ.BRepTools
{
	public class BRepToolsShapeSet : TopToolsShapeSet
	{
		public BRepToolsShapeSet(bool isWithTriangles)
 :
			base(BRepTools_ShapeSet_Ctor461FC46A(isWithTriangles) )
		{}
		public BRepToolsShapeSet(BRepBuilder B,bool isWithTriangles)
 :
			base(BRepTools_ShapeSet_CtorC2019AEC(B.Instance, isWithTriangles) )
		{}
			public void Clear()
				{
					BRepTools_ShapeSet_Clear(Instance);
				}
			public void AddGeometry(TopoDSShape S)
				{
					BRepTools_ShapeSet_AddGeometry9EBAC0C0(Instance, S.Instance);
				}
			public void AddShapes(TopoDSShape S1,TopoDSShape S2)
				{
					BRepTools_ShapeSet_AddShapes877A736F(Instance, S1.Instance, S2.Instance);
				}
			public void Check(TopAbsShapeEnum T,TopoDSShape S)
				{
					BRepTools_ShapeSet_Check6E774DE2(Instance, (int)T, S.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepTools_ShapeSet_Ctor461FC46A(bool isWithTriangles);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepTools_ShapeSet_CtorC2019AEC(IntPtr B,bool isWithTriangles);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_ShapeSet_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_ShapeSet_AddGeometry9EBAC0C0(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_ShapeSet_AddShapes877A736F(IntPtr instance, IntPtr S1,IntPtr S2);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepTools_ShapeSet_Check6E774DE2(IntPtr instance, int T,IntPtr S);

		#region NativeInstancePtr Convert constructor

		public BRepToolsShapeSet() { } 

		public BRepToolsShapeSet(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepToolsShapeSet_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepToolsShapeSet_Dtor(IntPtr instance);
	}
}
