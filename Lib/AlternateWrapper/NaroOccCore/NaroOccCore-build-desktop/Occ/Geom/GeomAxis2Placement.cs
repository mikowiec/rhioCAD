#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomAxis2Placement : GeomAxisPlacement
	{
		public GeomAxis2Placement(gpAx2 A2)
 :
			base(Geom_Axis2Placement_Ctor7895386A(A2.Instance) )
		{}
		public GeomAxis2Placement(gpPnt P,gpDir N,gpDir Vx)
 :
			base(Geom_Axis2Placement_CtorF36E9D55(P.Instance, N.Instance, Vx.Instance) )
		{}
			public void Transform(gpTrsf T)
				{
					Geom_Axis2Placement_Transform72D78650(Instance, T.Instance);
				}
		public gpDir Direction{
			set { 
				Geom_Axis2Placement_SetDirection(Instance, value.Instance);
			}
		}
		public gpAx2 Ax2{
			set { 
				Geom_Axis2Placement_SetAx2(Instance, value.Instance);
			}
			get {
				return new gpAx2(Geom_Axis2Placement_Ax2(Instance));
			}
		}
		public gpDir XDirection{
			set { 
				Geom_Axis2Placement_SetXDirection(Instance, value.Instance);
			}
			get {
				return new gpDir(Geom_Axis2Placement_XDirection(Instance));
			}
		}
		public gpDir YDirection{
			set { 
				Geom_Axis2Placement_SetYDirection(Instance, value.Instance);
			}
			get {
				return new gpDir(Geom_Axis2Placement_YDirection(Instance));
			}
		}
		public GeomGeometry Copy{
			get {
				return new GeomGeometry(Geom_Axis2Placement_Copy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Axis2Placement_Ctor7895386A(IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Axis2Placement_CtorF36E9D55(IntPtr P,IntPtr N,IntPtr Vx);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Axis2Placement_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Axis2Placement_SetDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Axis2Placement_SetAx2(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Axis2Placement_Ax2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Axis2Placement_SetXDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Axis2Placement_XDirection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Axis2Placement_SetYDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Axis2Placement_YDirection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Axis2Placement_Copy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomAxis2Placement() { } 

		public GeomAxis2Placement(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomAxis2Placement_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAxis2Placement_Dtor(IntPtr instance);
	}
}
