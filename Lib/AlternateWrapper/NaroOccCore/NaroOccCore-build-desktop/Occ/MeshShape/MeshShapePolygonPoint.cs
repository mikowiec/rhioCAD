#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.MeshShape
{
	public class MeshShapePolygonPoint : NativeInstancePtr
	{
		public MeshShapePolygonPoint()
 :
			base(MeshShape_PolygonPoint_Ctor() )
		{}
		public MeshShapePolygonPoint(double w,int Loc3d)
 :
			base(MeshShape_PolygonPoint_Ctor2935ABDE(w, Loc3d) )
		{}
		public double Parameter{
			get {
				return MeshShape_PolygonPoint_Parameter(Instance);
			}
		}
		public int Location3d{
			get {
				return MeshShape_PolygonPoint_Location3d(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MeshShape_PolygonPoint_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MeshShape_PolygonPoint_Ctor2935ABDE(double w,int Loc3d);
		[DllImport("NaroOccCore.dll")]
		private static extern double MeshShape_PolygonPoint_Parameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int MeshShape_PolygonPoint_Location3d(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public MeshShapePolygonPoint(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ MeshShapePolygonPoint_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void MeshShapePolygonPoint_Dtor(IntPtr instance);
	}
}
