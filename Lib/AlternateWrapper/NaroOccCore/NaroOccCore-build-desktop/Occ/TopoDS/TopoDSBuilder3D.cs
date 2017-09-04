#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDSBuilder3D : TopoDSBuilder
	{
			public void MakeShell(TopoDSShell S)
				{
					TopoDS_Builder3D_MakeShell41B0EE4D(Instance, S.Instance);
				}
			public void MakeSolid(TopoDSSolid S)
				{
					TopoDS_Builder3D_MakeSolid56111E92(Instance, S.Instance);
				}
			public void MakeCompSolid(TopoDSCompSolid C)
				{
					TopoDS_Builder3D_MakeCompSolid2CBA9E0B(Instance, C.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Builder3D_MakeShell41B0EE4D(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Builder3D_MakeSolid56111E92(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Builder3D_MakeCompSolid2CBA9E0B(IntPtr instance, IntPtr C);

		#region NativeInstancePtr Convert constructor

		public TopoDSBuilder3D() { } 

		public TopoDSBuilder3D(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDSBuilder3D_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDSBuilder3D_Dtor(IntPtr instance);
	}
}
