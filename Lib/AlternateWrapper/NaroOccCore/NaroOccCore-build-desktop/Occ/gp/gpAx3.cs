#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpAx3 : NativeInstancePtr
	{
		public gpAx3()
 :
			base(gp_Ax3_Ctor() )
		{}
		public gpAx3(gpAx2 A)
 :
			base(gp_Ax3_Ctor7895386A(A.Instance) )
		{}
		public gpAx3(gpPnt P,gpDir N,gpDir Vx)
 :
			base(gp_Ax3_CtorF36E9D55(P.Instance, N.Instance, Vx.Instance) )
		{}
		public gpAx3(gpPnt P,gpDir V)
 :
			base(gp_Ax3_CtorE13B639C(P.Instance, V.Instance) )
		{}
			public void XReverse()
				{
					gp_Ax3_XReverse(Instance);
				}
			public void YReverse()
				{
					gp_Ax3_YReverse(Instance);
				}
			public void ZReverse()
				{
					gp_Ax3_ZReverse(Instance);
				}
			public double Angle(gpAx3 Other)
				{
					return gp_Ax3_Angle1B3CAD05(Instance, Other.Instance);
				}
			public bool IsCoplanar(gpAx3 Other,double LinearTolerance,double AngularTolerance)
				{
					return gp_Ax3_IsCoplanar32BF0691(Instance, Other.Instance, LinearTolerance, AngularTolerance);
				}
			public bool IsCoplanar(gpAx1 A1,double LinearTolerance,double AngularTolerance)
				{
					return gp_Ax3_IsCoplanar5FECE277(Instance, A1.Instance, LinearTolerance, AngularTolerance);
				}
			public void Mirror(gpPnt P)
				{
					gp_Ax3_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpAx3 Mirrored(gpPnt P)
				{
					return new gpAx3(gp_Ax3_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Ax3_Mirror608B963B(Instance, A1.Instance);
				}
			public gpAx3 Mirrored(gpAx1 A1)
				{
					return new gpAx3(gp_Ax3_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Ax3_Mirror7895386A(Instance, A2.Instance);
				}
			public gpAx3 Mirrored(gpAx2 A2)
				{
					return new gpAx3(gp_Ax3_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Ax3_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpAx3 Rotated(gpAx1 A1,double Ang)
				{
					return new gpAx3(gp_Ax3_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Ax3_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpAx3 Scaled(gpPnt P,double S)
				{
					return new gpAx3(gp_Ax3_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Ax3_Transform72D78650(Instance, T.Instance);
				}
			public gpAx3 Transformed(gpTrsf T)
				{
					return new gpAx3(gp_Ax3_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Ax3_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpAx3 Translated(gpVec V)
				{
					return new gpAx3(gp_Ax3_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Ax3_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpAx3 Translated(gpPnt P1,gpPnt P2)
				{
					return new gpAx3(gp_Ax3_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public gpAx1 Axis{
			set { 
				gp_Ax3_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(gp_Ax3_Axis(Instance));
			}
		}
		public gpAx2 Ax2{
			get {
				return new gpAx2(gp_Ax3_Ax2(Instance));
			}
		}
		public gpDir Direction{
			set { 
				gp_Ax3_SetDirection(Instance, value.Instance);
			}
			get {
				return new gpDir(gp_Ax3_Direction(Instance));
			}
		}
		public gpPnt Location{
			set { 
				gp_Ax3_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Ax3_Location(Instance));
			}
		}
		public gpDir XDirection{
			set { 
				gp_Ax3_SetXDirection(Instance, value.Instance);
			}
			get {
				return new gpDir(gp_Ax3_XDirection(Instance));
			}
		}
		public gpDir YDirection{
			set { 
				gp_Ax3_SetYDirection(Instance, value.Instance);
			}
			get {
				return new gpDir(gp_Ax3_YDirection(Instance));
			}
		}
		public bool Direct{
			get {
				return gp_Ax3_Direct(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Ctor7895386A(IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_CtorF36E9D55(IntPtr P,IntPtr N,IntPtr Vx);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_CtorE13B639C(IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_XReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_YReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_ZReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Ax3_Angle1B3CAD05(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax3_IsCoplanar32BF0691(IntPtr instance, IntPtr Other,double LinearTolerance,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax3_IsCoplanar5FECE277(IntPtr instance, IntPtr A1,double LinearTolerance,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Ax2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_SetDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Direction(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_SetXDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_XDirection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax3_SetYDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax3_YDirection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax3_Direct(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpAx3(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpAx3_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpAx3_Dtor(IntPtr instance);
	}
}
