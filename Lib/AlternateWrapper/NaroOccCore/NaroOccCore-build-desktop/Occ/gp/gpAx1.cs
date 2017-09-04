#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpAx1 : NativeInstancePtr
	{
		public gpAx1()
 :
			base(gp_Ax1_Ctor() )
		{}
		public gpAx1(gpPnt P,gpDir V)
 :
			base(gp_Ax1_CtorE13B639C(P.Instance, V.Instance) )
		{}
			public bool IsCoaxial(gpAx1 Other,double AngularTolerance,double LinearTolerance)
				{
					return gp_Ax1_IsCoaxial5FECE277(Instance, Other.Instance, AngularTolerance, LinearTolerance);
				}
			public bool IsNormal(gpAx1 Other,double AngularTolerance)
				{
					return gp_Ax1_IsNormal827CB19A(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsOpposite(gpAx1 Other,double AngularTolerance)
				{
					return gp_Ax1_IsOpposite827CB19A(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsParallel(gpAx1 Other,double AngularTolerance)
				{
					return gp_Ax1_IsParallel827CB19A(Instance, Other.Instance, AngularTolerance);
				}
			public double Angle(gpAx1 Other)
				{
					return gp_Ax1_Angle608B963B(Instance, Other.Instance);
				}
			public void Reverse()
				{
					gp_Ax1_Reverse(Instance);
				}
			public void Mirror(gpPnt P)
				{
					gp_Ax1_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpAx1 Mirrored(gpPnt P)
				{
					return new gpAx1(gp_Ax1_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Ax1_Mirror608B963B(Instance, A1.Instance);
				}
			public gpAx1 Mirrored(gpAx1 A1)
				{
					return new gpAx1(gp_Ax1_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Ax1_Mirror7895386A(Instance, A2.Instance);
				}
			public gpAx1 Mirrored(gpAx2 A2)
				{
					return new gpAx1(gp_Ax1_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Ax1_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpAx1 Rotated(gpAx1 A1,double Ang)
				{
					return new gpAx1(gp_Ax1_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Ax1_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpAx1 Scaled(gpPnt P,double S)
				{
					return new gpAx1(gp_Ax1_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Ax1_Transform72D78650(Instance, T.Instance);
				}
			public gpAx1 Transformed(gpTrsf T)
				{
					return new gpAx1(gp_Ax1_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Ax1_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpAx1 Translated(gpVec V)
				{
					return new gpAx1(gp_Ax1_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Ax1_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpAx1 Translated(gpPnt P1,gpPnt P2)
				{
					return new gpAx1(gp_Ax1_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public gpDir Direction{
			set { 
				gp_Ax1_SetDirection(Instance, value.Instance);
			}
			get {
				return new gpDir(gp_Ax1_Direction(Instance));
			}
		}
		public gpPnt Location{
			set { 
				gp_Ax1_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt(gp_Ax1_Location(Instance));
			}
		}
		public gpAx1 Reversed{
			get {
				return new gpAx1(gp_Ax1_Reversed(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_CtorE13B639C(IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax1_IsCoaxial5FECE277(IntPtr instance, IntPtr Other,double AngularTolerance,double LinearTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax1_IsNormal827CB19A(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax1_IsOpposite827CB19A(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax1_IsParallel827CB19A(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Ax1_Angle608B963B(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax1_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax1_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax1_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax1_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax1_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax1_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax1_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax1_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax1_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax1_SetDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_Direction(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax1_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax1_Reversed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpAx1(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpAx1_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpAx1_Dtor(IntPtr instance);
	}
}
