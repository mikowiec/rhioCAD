#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomAxisPlacement : GeomGeometry
	{
			public double Angle(GeomAxisPlacement Other)
				{
					return Geom_AxisPlacement_AngleB4DE3BBC(Instance, Other.Instance);
				}
		public gpAx1 Axis{
			set { 
				Geom_AxisPlacement_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(Geom_AxisPlacement_Axis(Instance));
			}
		}
		public gpDir Direction{
			get {
				return new gpDir(Geom_AxisPlacement_Direction(Instance));
			}
		}
		public gpPnt Location{
			set { 
				Geom_AxisPlacement_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(Geom_AxisPlacement_Location(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_AxisPlacement_AngleB4DE3BBC(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_AxisPlacement_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_AxisPlacement_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_AxisPlacement_Direction(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_AxisPlacement_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_AxisPlacement_Location(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomAxisPlacement() { } 

		public GeomAxisPlacement(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomAxisPlacement_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAxisPlacement_Dtor(IntPtr instance);
	}
}
