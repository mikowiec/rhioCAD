#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomAxis1Placement : GeomAxisPlacement
	{
		public GeomAxis1Placement(gpAx1 A1)
 :
			base(Geom_Axis1Placement_Ctor608B963B(A1.Instance) )
		{}
		public GeomAxis1Placement(gpPnt P,gpDir V)
 :
			base(Geom_Axis1Placement_CtorE13B639C(P.Instance, V.Instance) )
		{}
			public void Reverse()
				{
					Geom_Axis1Placement_Reverse(Instance);
				}
			public void Transform(gpTrsf T)
				{
					Geom_Axis1Placement_Transform72D78650(Instance, T.Instance);
				}
		public gpAx1 Ax1{
			get {
				return new gpAx1(Geom_Axis1Placement_Ax1(Instance));
			}
		}
		public GeomAxis1Placement Reversed{
			get {
				return new GeomAxis1Placement(Geom_Axis1Placement_Reversed(Instance));
			}
		}
		public gpDir Direction{
			set { 
				Geom_Axis1Placement_SetDirection(Instance, value.Instance);
			}
		}
		public GeomGeometry Copy{
			get {
				return new GeomGeometry(Geom_Axis1Placement_Copy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Axis1Placement_Ctor608B963B(IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Axis1Placement_CtorE13B639C(IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Axis1Placement_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Axis1Placement_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Axis1Placement_Ax1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Axis1Placement_Reversed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Axis1Placement_SetDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Axis1Placement_Copy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomAxis1Placement() { } 

		public GeomAxis1Placement(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomAxis1Placement_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAxis1Placement_Dtor(IntPtr instance);
	}
}
