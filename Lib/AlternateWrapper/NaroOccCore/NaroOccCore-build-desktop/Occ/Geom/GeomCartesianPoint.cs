#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomCartesianPoint : GeomPoint
	{
		public GeomCartesianPoint(gpPnt P)
 :
			base(Geom_CartesianPoint_Ctor9EAECD5B(P.Instance) )
		{}
		public GeomCartesianPoint(double X,double Y,double Z)
 :
			base(Geom_CartesianPoint_Ctor9282A951(X, Y, Z) )
		{}
			public void SetCoord(double X,double Y,double Z)
				{
					Geom_CartesianPoint_SetCoord9282A951(Instance, X, Y, Z);
				}
			public void Coord(ref double X,ref double Y,ref double Z)
				{
					Geom_CartesianPoint_Coord9282A951(Instance, ref X, ref Y, ref Z);
				}
			public void Transform(gpTrsf T)
				{
					Geom_CartesianPoint_Transform72D78650(Instance, T.Instance);
				}
		public gpPnt Pnt{
			set { 
				Geom_CartesianPoint_SetPnt(Instance, value.Instance);
			}
			get {
				return new gpPnt(Geom_CartesianPoint_Pnt(Instance));
			}
		}
		public double X{
			set { 
				Geom_CartesianPoint_SetX(Instance, value);
			}
			get {
				return Geom_CartesianPoint_X(Instance);
			}
		}
		public double Y{
			set { 
				Geom_CartesianPoint_SetY(Instance, value);
			}
			get {
				return Geom_CartesianPoint_Y(Instance);
			}
		}
		public double Z{
			set { 
				Geom_CartesianPoint_SetZ(Instance, value);
			}
			get {
				return Geom_CartesianPoint_Z(Instance);
			}
		}
		public GeomGeometry Copy{
			get {
				return new GeomGeometry(Geom_CartesianPoint_Copy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_CartesianPoint_Ctor9EAECD5B(IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_CartesianPoint_Ctor9282A951(double X,double Y,double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_CartesianPoint_SetCoord9282A951(IntPtr instance, double X,double Y,double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_CartesianPoint_Coord9282A951(IntPtr instance, ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_CartesianPoint_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_CartesianPoint_SetPnt(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_CartesianPoint_Pnt(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_CartesianPoint_SetX(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_CartesianPoint_X(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_CartesianPoint_SetY(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_CartesianPoint_Y(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_CartesianPoint_SetZ(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_CartesianPoint_Z(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_CartesianPoint_Copy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomCartesianPoint() { } 

		public GeomCartesianPoint(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomCartesianPoint_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomCartesianPoint_Dtor(IntPtr instance);
	}
}
