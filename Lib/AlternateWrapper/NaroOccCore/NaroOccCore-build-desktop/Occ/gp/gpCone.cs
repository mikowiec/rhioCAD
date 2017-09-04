#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpCone : NativeInstancePtr
	{
		public gpCone()
 :
			base(gp_Cone_Ctor() )
		{}
		public gpCone(gpAx3 A3,double Ang,double Radius)
 :
			base(gp_Cone_Ctor32BF0691(A3.Instance, Ang, Radius) )
		{}
			public void UReverse()
				{
					gp_Cone_UReverse(Instance);
				}
			public void VReverse()
				{
					gp_Cone_VReverse(Instance);
				}
			public void Coefficients(ref double A1,ref double A2,ref double A3,ref double B1,ref double B2,ref double B3,ref double C1,ref double C2,ref double C3,ref double D)
				{
					gp_Cone_CoefficientsCFCEAB36(Instance, ref A1, ref A2, ref A3, ref B1, ref B2, ref B3, ref C1, ref C2, ref C3, ref D);
				}
			public void Mirror(gpPnt P)
				{
					gp_Cone_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpCone Mirrored(gpPnt P)
				{
					return new gpCone(gp_Cone_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Cone_Mirror608B963B(Instance, A1.Instance);
				}
			public gpCone Mirrored(gpAx1 A1)
				{
					return new gpCone(gp_Cone_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Cone_Mirror7895386A(Instance, A2.Instance);
				}
			public gpCone Mirrored(gpAx2 A2)
				{
					return new gpCone(gp_Cone_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Cone_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpCone Rotated(gpAx1 A1,double Ang)
				{
					return new gpCone(gp_Cone_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Cone_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpCone Scaled(gpPnt P,double S)
				{
					return new gpCone(gp_Cone_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Cone_Transform72D78650(Instance, T.Instance);
				}
			public gpCone Transformed(gpTrsf T)
				{
					return new gpCone(gp_Cone_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Cone_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpCone Translated(gpVec V)
				{
					return new gpCone(gp_Cone_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Cone_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpCone Translated(gpPnt P1,gpPnt P2)
				{
					return new gpCone(gp_Cone_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public double Radius{
			set { 
				gp_Cone_SetRadius(Instance, value);
			}
		}
		public gpPnt Apex{
			get {
				return new gpPnt(gp_Cone_Apex(Instance));
			}
		}
		public bool Direct{
			get {
				return gp_Cone_Direct(Instance);
			}
		}
		public gpAx1 Axis{
			set { 
				gp_Cone_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(gp_Cone_Axis(Instance));
			}
		}
		public gpPnt Location{
			set { 
				gp_Cone_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Cone_Location(Instance));
			}
		}
		public gpAx3 Position{
			set { 
				gp_Cone_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx3(gp_Cone_Position(Instance));
			}
		}
		public double RefRadius{
			get {
				return gp_Cone_RefRadius(Instance);
			}
		}
		public double SemiAngle{
			set { 
				gp_Cone_SetSemiAngle(Instance, value);
			}
			get {
				return gp_Cone_SemiAngle(Instance);
			}
		}
		public gpAx1 XAxis{
			get {
				return new gpAx1(gp_Cone_XAxis(Instance));
			}
		}
		public gpAx1 YAxis{
			get {
				return new gpAx1(gp_Cone_YAxis(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Ctor32BF0691(IntPtr A3,double Ang,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_UReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_VReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_CoefficientsCFCEAB36(IntPtr instance, ref double A1,ref double A2,ref double A3,ref double B1,ref double B2,ref double B3,ref double C1,ref double C2,ref double C3,ref double D);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_SetRadius(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Apex(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Cone_Direct(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Cone_RefRadius(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Cone_SetSemiAngle(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Cone_SemiAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Cone_YAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpCone(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpCone_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpCone_Dtor(IntPtr instance);
	}
}
