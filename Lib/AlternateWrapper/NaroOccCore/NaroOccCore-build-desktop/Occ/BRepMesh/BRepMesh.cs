#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BRepMesh
{
	public class BRepMesh : NativeInstancePtr
	{
			public static void Mesh(TopoDSShape S,double d)
				{
					BRepMesh_Mesh92EB56FA(S.Instance, d);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepMesh_Mesh92EB56FA(IntPtr S,double d);

		#region NativeInstancePtr Convert constructor

		public BRepMesh() { } 

		public BRepMesh(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepMesh_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepMesh_Dtor(IntPtr instance);
	}
}
