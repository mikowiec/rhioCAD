#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpAx2 : NativeInstancePtr
	{
		public gpAx2()
 :
			base(gp_Ax2_Ctor() )
		{}
		public gpAx2(gpPnt P,gpDir N,gpDir Vx)
 :
			base(gp_Ax2_CtorF36E9D55(P.Instance, N.Instance, Vx.Instance) )
		{}
		public gpAx2(gpPnt P,gpDir V)
 :
			base(gp_Ax2_CtorE13B639C(P.Instance, V.Instance) )
		{}
			public double Angle(gpAx2 Other)
				{
					return gp_Ax2_Angle7895386A(Instance, Other.Instance);
				}
			public bool IsCoplanar(gpAx2 Other,double LinearTolerance,double AngularTolerance)
				{
					return gp_Ax2_IsCoplanarB1A3BD2A(Instance, Other.Instance, LinearTolerance, AngularTolerance);
				}
			public bool IsCoplanar(gpAx1 A1,double LinearTolerance,double AngularTolerance)
				{
					return gp_Ax2_IsCoplanar5FECE277(Instance, A1.Instance, LinearTolerance, AngularTolerance);
				}
			public void Mirror(gpPnt P)
				{
					gp_Ax2_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpAx2 Mirrored(gpPnt P)
				{
					return new gpAx2(gp_Ax2_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Ax2_Mirror608B963B(Instance, A1.Instance);
				}
			public gpAx2 Mirrored(gpAx1 A1)
				{
					return new gpAx2(gp_Ax2_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Ax2_Mirror7895386A(Instance, A2.Instance);
				}
			public gpAx2 Mirrored(gpAx2 A2)
				{
					return new gpAx2(gp_Ax2_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Ax2_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpAx2 Rotated(gpAx1 A1,double Ang)
				{
					return new gpAx2(gp_Ax2_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Ax2_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpAx2 Scaled(gpPnt P,double S)
				{
					return new gpAx2(gp_Ax2_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Ax2_Transform72D78650(Instance, T.Instance);
				}
			public gpAx2 Transformed(gpTrsf T)
				{
					return new gpAx2(gp_Ax2_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Ax2_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpAx2 Translated(gpVec V)
				{
					return new gpAx2(gp_Ax2_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Ax2_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpAx2 Translated(gpPnt P1,gpPnt P2)
				{
					return new gpAx2(gp_Ax2_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public gpAx1 Axis{
			set { 
				gp_Ax2_SetAxis(Instance, value.Instance);
			}
			get {
				return new gpAx1(gp_Ax2_Axis(Instance));
			}
		}
		public gpDir Direction{
			set { 
				gp_Ax2_SetDirection(Instance, value.Instance);
			}
			get {
				return new gpDir(gp_Ax2_Direction(Instance));
			}
		}
		public gpPnt Location{
			set { 
				gp_Ax2_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Ax2_Location(Instance));
			}
		}
		public gpDir XDirection{
			set { 
				gp_Ax2_SetXDirection(Instance, value.Instance);
			}
			get {
				return new gpDir(gp_Ax2_XDirection(Instance));
			}
		}
		public gpDir YDirection{
			set { 
				gp_Ax2_SetYDirection(Instance, value.Instance);
			}
			get {
				return new gpDir(gp_Ax2_YDirection(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_CtorF36E9D55(IntPtr P,IntPtr N,IntPtr Vx);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_CtorE13B639C(IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Ax2_Angle7895386A(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax2_IsCoplanarB1A3BD2A(IntPtr instance, IntPtr Other,double LinearTolerance,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax2_IsCoplanar5FECE277(IntPtr instance, IntPtr A1,double LinearTolerance,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_SetAxis(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_Axis(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_SetDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_Direction(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_SetXDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_XDirection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2_SetYDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2_YDirection(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpAx2(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpAx2_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpAx2_Dtor(IntPtr instance);
	}
}
