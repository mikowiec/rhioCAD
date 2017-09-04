#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpCylinder : NativeInstancePtr
	{
		public gpCylinder()
 :
			base(gp_Cylinder_Ctor() )
		{}
		public gpCylinder(gpAx3 A3,double Radius)
 :
			base(gp_Cylinder_Ctor5C6D1CB8(A3.Instance, Radius) )
		{}
			public void UReverse()
				{
					gp_Cylinder_UReverse(Instance);
				}
			public void VReverse()
				{
					gp_Cylinder_VReverse(Instance);
				}
			public void Coefficients(ref double A1,ref double A2,ref double A3,ref double B1,ref double B2,ref double B3,ref double C1,ref double C2,ref double C3,ref double D)
				{
					gp_Cylinder_CoefficientsCFCEAB36(Instance, ref A1, ref A2, ref A3, ref B1, ref B2, ref B3, ref C1, ref C2, ref C3, ref D);
				}
			public void Mirror(gpPnt P)
				{
					gp_Cylinder_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpCylinder Mirrored(gpPnt P)
				{
					return new gpCylinder(gp_Cylinder_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Cylinder_Mirror608B963B(Instance, A1.Instance);
				}
			public gpCylinder Mirrored(gpAx1 A1)
				{
					return new gpCylinder(gp_Cylinder_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Cylinder_Mirror7895386A(Instance, A2.Instance);
				}
			public gpCylinder Mirrored(gpAx2 A2)
				{
					return new gpCylinder(gp_Cylinder_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Cylinder_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpCylinder Rotated(gpAx1 A1,double Ang)
				{
					return new gpCylinder(gp_Cylinder_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Cylinder_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpCylinder Scaled(gpPnt P,double S)
				{
					return new gpCylinder(gp_Cylinder_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Cylinder_Transform72D78650(Instance, T.Instance);
				}
			public gpCylinder Transformed(gpTrsf T)
				{
					return new gpCylinder(gp_Cylinder_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Cylinder_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpCylinder Translated(gpVec V)
				{
					return new gpCylinder(gp_Cylinder_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Cylinder_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpCylinder Translated(gpPnt P1,gpPnt P2)
				{
					return new gpCylinder(gp_Cylinder_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public bool Direct{
			get {
				return gp_Cylinder_Direct(Instance);
			}
		}
		public gpAx1 Axis{
			set { 
				gp_Cylinder_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(gp_Cylinder_Axis(Instance));
			}
		}
		public gpPnt Location{
			set { 
				gp_Cylinder_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Cylinder_Location(Instance));
			}
		}
		public gpAx3 Position{
			set { 
				gp_Cylinder_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx3(gp_Cylinder_Position(Instance));
			}
		}
		public double Radius{
			set { 
				gp_Cylinder_SetRadius(Instance, value);
			}
			get {
				return gp_Cylinder_Radius(Instance);
			}
		}
		public gpAx1 XAxis{
			get {
				return new gpAx1(gp_Cylinder_XAxis(Instance));
			}
		}
		public gpAx1 YAxis{
			get {
				return new gpAx1(gp_Cylinder_YAxis(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_Ctor5C6D1CB8(IntPtr A3,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_UReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_VReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_CoefficientsCFCEAB36(IntPtr instance, ref double A1,ref double A2,ref double A3,ref double B1,ref double B2,ref double B3,ref double C1,ref double C2,ref double C3,ref double D);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Cylinder_Direct(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cylinder_SetRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Cylinder_Radius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cylinder_YAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpCylinder(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpCylinder_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpCylinder_Dtor(IntPtr instance);
	}
}
