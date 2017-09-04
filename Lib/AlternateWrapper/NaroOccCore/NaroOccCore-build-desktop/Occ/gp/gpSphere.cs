#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpSphere : NativeInstancePtr
	{
		public gpSphere()
 :
			base(gp_Sphere_Ctor() )
		{}
		public gpSphere(gpAx3 A3,double Radius)
 :
			base(gp_Sphere_Ctor5C6D1CB8(A3.Instance, Radius) )
		{}
			public void Coefficients(ref double A1,ref double A2,ref double A3,ref double B1,ref double B2,ref double B3,ref double C1,ref double C2,ref double C3,ref double D)
				{
					gp_Sphere_CoefficientsCFCEAB36(Instance, ref A1, ref A2, ref A3, ref B1, ref B2, ref B3, ref C1, ref C2, ref C3, ref D);
				}
			public void UReverse()
				{
					gp_Sphere_UReverse(Instance);
				}
			public void VReverse()
				{
					gp_Sphere_VReverse(Instance);
				}
			public void Mirror(gpPnt P)
				{
					gp_Sphere_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpSphere Mirrored(gpPnt P)
				{
					return new gpSphere(gp_Sphere_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Sphere_Mirror608B963B(Instance, A1.Instance);
				}
			public gpSphere Mirrored(gpAx1 A1)
				{
					return new gpSphere(gp_Sphere_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Sphere_Mirror7895386A(Instance, A2.Instance);
				}
			public gpSphere Mirrored(gpAx2 A2)
				{
					return new gpSphere(gp_Sphere_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Sphere_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpSphere Rotated(gpAx1 A1,double Ang)
				{
					return new gpSphere(gp_Sphere_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Sphere_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpSphere Scaled(gpPnt P,double S)
				{
					return new gpSphere(gp_Sphere_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Sphere_Transform72D78650(Instance, T.Instance);
				}
			public gpSphere Transformed(gpTrsf T)
				{
					return new gpSphere(gp_Sphere_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Sphere_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpSphere Translated(gpVec V)
				{
					return new gpSphere(gp_Sphere_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Sphere_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpSphere Translated(gpPnt P1,gpPnt P2)
				{
					return new gpSphere(gp_Sphere_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public double Area{
			get {
				return gp_Sphere_Area(Instance);
			}
		}
		public bool Direct{
			get {
				return gp_Sphere_Direct(Instance);
			}
		}
		public gpPnt Location{
			set { 
				gp_Sphere_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Sphere_Location(Instance));
			}
		}
		public gpAx3 Position{
			set { 
				gp_Sphere_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx3(gp_Sphere_Position(Instance));
			}
		}
		public double Radius{
			set { 
				gp_Sphere_SetRadius(Instance, value);
			}
			get {
				return gp_Sphere_Radius(Instance);
			}
		}
		public double Volume{
			get {
				return gp_Sphere_Volume(Instance);
			}
		}
		public gpAx1 XAxis{
			get {
				return new gpAx1(gp_Sphere_XAxis(Instance));
			}
		}
		public gpAx1 YAxis{
			get {
				return new gpAx1(gp_Sphere_YAxis(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_Ctor5C6D1CB8(IntPtr A3,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_CoefficientsCFCEAB36(IntPtr instance, ref double A1,ref double A2,ref double A3,ref double B1,ref double B2,ref double B3,ref double C1,ref double C2,ref double C3,ref double D);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_UReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_VReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Sphere_Area(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Sphere_Direct(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Sphere_SetRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Sphere_Radius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Sphere_Volume(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Sphere_YAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpSphere(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpSphere_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpSphere_Dtor(IntPtr instance);
	}
}
