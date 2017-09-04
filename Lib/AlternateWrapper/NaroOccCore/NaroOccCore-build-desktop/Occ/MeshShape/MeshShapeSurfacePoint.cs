#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.MeshShape
{
	public class MeshShapeSurfacePoint : NativeInstancePtr
	{
		public MeshShapeSurfacePoint()
 :
			base(MeshShape_SurfacePoint_Ctor() )
		{}
		public MeshShapeSurfacePoint(double u,double v,double x,double y,double z)
 :
			base(MeshShape_SurfacePoint_Ctor216AF150(u, v, x, y, z) )
		{}
		public MeshShapeSurfacePoint(gpXY uv,gpXYZ coord)
 :
			base(MeshShape_SurfacePoint_Ctor1957E281(uv.Instance, coord.Instance) )
		{}
		public MeshShapeSurfacePoint(double u,double v,gpXYZ coord)
 :
			base(MeshShape_SurfacePoint_CtorED84B375(u, v, coord.Instance) )
		{}
		public gpXY UV{
			get {
				return new gpXY(MeshShape_SurfacePoint_UV(Instance));
			}
		}
		public gpXYZ Coord{
			get {
				return new gpXYZ(MeshShape_SurfacePoint_Coord(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MeshShape_SurfacePoint_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MeshShape_SurfacePoint_Ctor216AF150(double u,double v,double x,double y,double z);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MeshShape_SurfacePoint_Ctor1957E281(IntPtr uv,IntPtr coord);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MeshShape_SurfacePoint_CtorED84B375(double u,double v,IntPtr coord);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MeshShape_SurfacePoint_UV(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MeshShape_SurfacePoint_Coord(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public MeshShapeSurfacePoint(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ MeshShapeSurfacePoint_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void MeshShapeSurfacePoint_Dtor(IntPtr instance);
	}
}
