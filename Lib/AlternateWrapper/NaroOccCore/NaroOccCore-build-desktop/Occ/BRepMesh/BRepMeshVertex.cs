#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.BRepMesh;

#endregion

namespace NaroCppCore.Occ.BRepMesh
{
	public class BRepMeshVertex : NativeInstancePtr
	{
		public BRepMeshVertex()
 :
			base(BRepMesh_Vertex_Ctor() )
		{}
		public BRepMeshVertex(gpXY UV,int Locat3d,BRepMeshDegreeOfFreedom Move)
 :
			base(BRepMesh_Vertex_CtorE385E6C0(UV.Instance, Locat3d, (int)Move) )
		{}
		public BRepMeshVertex(double U,double V,BRepMeshDegreeOfFreedom Move)
 :
			base(BRepMesh_Vertex_Ctor7460CC1A(U, V, (int)Move) )
		{}
			public void Initialize(gpXY UV,int Locat3d,BRepMeshDegreeOfFreedom Move)
				{
					BRepMesh_Vertex_InitializeE385E6C0(Instance, UV.Instance, Locat3d, (int)Move);
				}
			public int HashCode(int Upper)
				{
					return BRepMesh_Vertex_HashCodeE8219145(Instance, Upper);
				}
			public bool IsEqual(BRepMeshVertex Other)
				{
					return BRepMesh_Vertex_IsEqualFA897224(Instance, Other.Instance);
				}
		public gpXY Coord{
			get {
				return new gpXY(BRepMesh_Vertex_Coord(Instance));
			}
		}
		public int Location3d{
			get {
				return BRepMesh_Vertex_Location3d(Instance);
			}
		}
		public BRepMeshDegreeOfFreedom Movability{
			set { 
				BRepMesh_Vertex_SetMovability(Instance, (int)value);
			}
			get {
				return (BRepMeshDegreeOfFreedom)BRepMesh_Vertex_Movability(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepMesh_Vertex_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepMesh_Vertex_CtorE385E6C0(IntPtr UV,int Locat3d,int Move);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepMesh_Vertex_Ctor7460CC1A(double U,double V,int Move);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepMesh_Vertex_InitializeE385E6C0(IntPtr instance, IntPtr UV,int Locat3d,int Move);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepMesh_Vertex_HashCodeE8219145(IntPtr instance, int Upper);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepMesh_Vertex_IsEqualFA897224(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepMesh_Vertex_Coord(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepMesh_Vertex_Location3d(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepMesh_Vertex_SetMovability(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepMesh_Vertex_Movability(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepMeshVertex(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepMeshVertex_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepMeshVertex_Dtor(IntPtr instance);
	}
}
