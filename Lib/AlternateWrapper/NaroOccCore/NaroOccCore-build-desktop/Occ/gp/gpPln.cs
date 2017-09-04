#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpPln : NativeInstancePtr
	{
		public gpPln()
 :
			base(gp_Pln_Ctor() )
		{}
		public gpPln(gpAx3 A3)
 :
			base(gp_Pln_Ctor1B3CAD05(A3.Instance) )
		{}
		public gpPln(gpPnt P,gpDir V)
 :
			base(gp_Pln_CtorE13B639C(P.Instance, V.Instance) )
		{}
		public gpPln(double A,double B,double C,double D)
 :
			base(gp_Pln_CtorC2777E0C(A, B, C, D) )
		{}
			public void Coefficients(ref double A,ref double B,ref double C,ref double D)
				{
					gp_Pln_CoefficientsC2777E0C(Instance, ref A, ref B, ref C, ref D);
				}
			public void UReverse()
				{
					gp_Pln_UReverse(Instance);
				}
			public void VReverse()
				{
					gp_Pln_VReverse(Instance);
				}
			public double Distance(gpPnt P)
				{
					return gp_Pln_Distance9EAECD5B(Instance, P.Instance);
				}
			public double Distance(gpLin L)
				{
					return gp_Pln_Distance9917D291(Instance, L.Instance);
				}
			public double Distance(gpPln Other)
				{
					return gp_Pln_Distance9914D2AD(Instance, Other.Instance);
				}
			public double SquareDistance(gpPnt P)
				{
					return gp_Pln_SquareDistance9EAECD5B(Instance, P.Instance);
				}
			public double SquareDistance(gpLin L)
				{
					return gp_Pln_SquareDistance9917D291(Instance, L.Instance);
				}
			public double SquareDistance(gpPln Other)
				{
					return gp_Pln_SquareDistance9914D2AD(Instance, Other.Instance);
				}
			public bool Contains(gpPnt P,double LinearTolerance)
				{
					return gp_Pln_ContainsF0D1E3E6(Instance, P.Instance, LinearTolerance);
				}
			public bool Contains(gpLin L,double LinearTolerance,double AngularTolerance)
				{
					return gp_Pln_Contains13A123E9(Instance, L.Instance, LinearTolerance, AngularTolerance);
				}
			public void Mirror(gpPnt P)
				{
					gp_Pln_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpPln Mirrored(gpPnt P)
				{
					return new gpPln(gp_Pln_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Pln_Mirror608B963B(Instance, A1.Instance);
				}
			public gpPln Mirrored(gpAx1 A1)
				{
					return new gpPln(gp_Pln_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Pln_Mirror7895386A(Instance, A2.Instance);
				}
			public gpPln Mirrored(gpAx2 A2)
				{
					return new gpPln(gp_Pln_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Pln_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpPln Rotated(gpAx1 A1,double Ang)
				{
					return new gpPln(gp_Pln_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Pln_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpPln Scaled(gpPnt P,double S)
				{
					return new gpPln(gp_Pln_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Pln_Transform72D78650(Instance, T.Instance);
				}
			public gpPln Transformed(gpTrsf T)
				{
					return new gpPln(gp_Pln_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Pln_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpPln Translated(gpVec V)
				{
					return new gpPln(gp_Pln_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Pln_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpPln Translated(gpPnt P1,gpPnt P2)
				{
					return new gpPln(gp_Pln_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public bool Direct{
			get {
				return gp_Pln_Direct(Instance);
			}
		}
		public gpAx1 Axis{
			set { 
				gp_Pln_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(gp_Pln_Axis(Instance));
			}
		}
		public gpPnt Location{
			set { 
				gp_Pln_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Pln_Location(Instance));
			}
		}
		public gpAx3 Position{
			set { 
				gp_Pln_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx3(gp_Pln_Position(Instance));
			}
		}
		public gpAx1 XAxis{
			get {
				return new gpAx1(gp_Pln_XAxis(Instance));
			}
		}
		public gpAx1 YAxis{
			get {
				return new gpAx1(gp_Pln_YAxis(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_Ctor1B3CAD05(IntPtr A3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_CtorE13B639C(IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_CtorC2777E0C(double A,double B,double C,double D);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_CoefficientsC2777E0C(IntPtr instance, ref double A,ref double B,ref double C,ref double D);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_UReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_VReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pln_Distance9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pln_Distance9917D291(IntPtr instance, IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pln_Distance9914D2AD(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pln_SquareDistance9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pln_SquareDistance9917D291(IntPtr instance, IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pln_SquareDistance9914D2AD(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Pln_ContainsF0D1E3E6(IntPtr instance, IntPtr P,double LinearTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Pln_Contains13A123E9(IntPtr instance, IntPtr L,double LinearTolerance,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Pln_Direct(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pln_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_Position(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_XAxis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pln_YAxis(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpPln(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpPln_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpPln_Dtor(IntPtr instance);
	}
}
