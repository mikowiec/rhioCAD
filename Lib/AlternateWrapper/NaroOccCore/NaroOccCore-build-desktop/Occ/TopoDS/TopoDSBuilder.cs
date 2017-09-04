#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDSBuilder : NativeInstancePtr
	{
			public void MakeWire(TopoDSWire W)
				{
					TopoDS_Builder_MakeWire368EDFE5(Instance, W.Instance);
				}
			public void MakeShell(TopoDSShell S)
				{
					TopoDS_Builder_MakeShell41B0EE4D(Instance, S.Instance);
				}
			public void MakeSolid(TopoDSSolid S)
				{
					TopoDS_Builder_MakeSolid56111E92(Instance, S.Instance);
				}
			public void MakeCompSolid(TopoDSCompSolid C)
				{
					TopoDS_Builder_MakeCompSolid2CBA9E0B(Instance, C.Instance);
				}
			public void MakeCompound(TopoDSCompound C)
				{
					TopoDS_Builder_MakeCompoundF7963FEC(Instance, C.Instance);
				}
			public void Add(TopoDSShape S,TopoDSShape C)
				{
					TopoDS_Builder_Add877A736F(Instance, S.Instance, C.Instance);
				}
			public void Remove(TopoDSShape S,TopoDSShape C)
				{
					TopoDS_Builder_Remove877A736F(Instance, S.Instance, C.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Builder_MakeWire368EDFE5(IntPtr instance, IntPtr W);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Builder_MakeShell41B0EE4D(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Builder_MakeSolid56111E92(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Builder_MakeCompSolid2CBA9E0B(IntPtr instance, IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Builder_MakeCompoundF7963FEC(IntPtr instance, IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Builder_Add877A736F(IntPtr instance, IntPtr S,IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Builder_Remove877A736F(IntPtr instance, IntPtr S,IntPtr C);

		#region NativeInstancePtr Convert constructor

		public TopoDSBuilder() { } 

		public TopoDSBuilder(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDSBuilder_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDSBuilder_Dtor(IntPtr instance);
	}
}
