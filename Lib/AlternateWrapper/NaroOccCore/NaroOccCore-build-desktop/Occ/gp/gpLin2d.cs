#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpLin2d : NativeInstancePtr
	{
		public gpLin2d()
 :
			base(gp_Lin2d_Ctor() )
		{}
		public gpLin2d(gpAx2d A)
 :
			base(gp_Lin2d_Ctor90E1386A(A.Instance) )
		{}
		public gpLin2d(gpPnt2d P,gpDir2d V)
 :
			base(gp_Lin2d_Ctor2E9C6BD1(P.Instance, V.Instance) )
		{}
		public gpLin2d(double A,double B,double C)
 :
			base(gp_Lin2d_Ctor9282A951(A, B, C) )
		{}
			public void Reverse()
				{
					gp_Lin2d_Reverse(Instance);
				}
			public void Coefficients(ref double A,ref double B,ref double C)
				{
					gp_Lin2d_Coefficients9282A951(Instance, ref A, ref B, ref C);
				}
			public double Angle(gpLin2d Other)
				{
					return gp_Lin2d_Angle5D0C667A(Instance, Other.Instance);
				}
			public bool Contains(gpPnt2d P,double LinearTolerance)
				{
					return gp_Lin2d_ContainsE3062737(Instance, P.Instance, LinearTolerance);
				}
			public double Distance(gpPnt2d P)
				{
					return gp_Lin2d_Distance6203658C(Instance, P.Instance);
				}
			public double Distance(gpLin2d Other)
				{
					return gp_Lin2d_Distance5D0C667A(Instance, Other.Instance);
				}
			public double SquareDistance(gpPnt2d P)
				{
					return gp_Lin2d_SquareDistance6203658C(Instance, P.Instance);
				}
			public double SquareDistance(gpLin2d Other)
				{
					return gp_Lin2d_SquareDistance5D0C667A(Instance, Other.Instance);
				}
			public gpLin2d Normal(gpPnt2d P)
				{
					return new gpLin2d(gp_Lin2d_Normal6203658C(Instance, P.Instance));
				}
			public void Mirror(gpPnt2d P)
				{
					gp_Lin2d_Mirror6203658C(Instance, P.Instance);
				}
			public gpLin2d Mirrored(gpPnt2d P)
				{
					return new gpLin2d(gp_Lin2d_Mirrored6203658C(Instance, P.Instance));
				}
			public void Mirror(gpAx2d A)
				{
					gp_Lin2d_Mirror90E1386A(Instance, A.Instance);
				}
			public gpLin2d Mirrored(gpAx2d A)
				{
					return new gpLin2d(gp_Lin2d_Mirrored90E1386A(Instance, A.Instance));
				}
			public void Rotate(gpPnt2d P,double Ang)
				{
					gp_Lin2d_RotateE3062737(Instance, P.Instance, Ang);
				}
			public gpLin2d Rotated(gpPnt2d P,double Ang)
				{
					return new gpLin2d(gp_Lin2d_RotatedE3062737(Instance, P.Instance, Ang));
				}
			public void Scale(gpPnt2d P,double S)
				{
					gp_Lin2d_ScaleE3062737(Instance, P.Instance, S);
				}
			public gpLin2d Scaled(gpPnt2d P,double S)
				{
					return new gpLin2d(gp_Lin2d_ScaledE3062737(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf2d T)
				{
					gp_Lin2d_Transform27621DCB(Instance, T.Instance);
				}
			public gpLin2d Transformed(gpTrsf2d T)
				{
					return new gpLin2d(gp_Lin2d_Transformed27621DCB(Instance, T.Instance));
				}
			public void Translate(gpVec2d V)
				{
					gp_Lin2d_Translate5E4E66E7(Instance, V.Instance);
				}
			public gpLin2d Translated(gpVec2d V)
				{
					return new gpLin2d(gp_Lin2d_Translated5E4E66E7(Instance, V.Instance));
				}
			public void Translate(gpPnt2d P1,gpPnt2d P2)
				{
					gp_Lin2d_Translate5F54ADE3(Instance, P1.Instance, P2.Instance);
				}
			public gpLin2d Translated(gpPnt2d P1,gpPnt2d P2)
				{
					return new gpLin2d(gp_Lin2d_Translated5F54ADE3(Instance, P1.Instance, P2.Instance));
				}
		public gpLin2d Reversed{
			get {
				return new gpLin2d(gp_Lin2d_Reversed(Instance));
			}
		}
		public gpDir2d Direction{
			set { 
				gp_Lin2d_SetDirection(Instance, value.Instance);
			}
			get {
				return new gpDir2d(gp_Lin2d_Direction(Instance));
			}
		}
		public gpPnt2d Location{
			set { 
				gp_Lin2d_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt2d(gp_Lin2d_Location(Instance));
			}
		}
		public gpAx2d Position{
			set { 
				gp_Lin2d_SetPosition(Instance, value.Instance);
			}
			get {
				return new gpAx2d(gp_Lin2d_Position(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Ctor90E1386A(IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Ctor2E9C6BD1(IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Ctor9282A951(double A,double B,double C);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin2d_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin2d_Coefficients9282A951(IntPtr instance, ref double A,ref double B,ref double C);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Lin2d_Angle5D0C667A(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Lin2d_ContainsE3062737(IntPtr instance, IntPtr P,double LinearTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Lin2d_Distance6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Lin2d_Distance5D0C667A(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Lin2d_SquareDistance6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Lin2d_SquareDistance5D0C667A(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Normal6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin2d_Mirror6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Mirrored6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin2d_Mirror90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Mirrored90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin2d_RotateE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_RotatedE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin2d_ScaleE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_ScaledE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin2d_Transform27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Transformed27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin2d_Translate5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Translated5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin2d_Translate5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Translated5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Reversed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin2d_SetDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Direction(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin2d_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Lin2d_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Lin2d_Position(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpLin2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpLin2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpLin2d_Dtor(IntPtr instance);
	}
}
