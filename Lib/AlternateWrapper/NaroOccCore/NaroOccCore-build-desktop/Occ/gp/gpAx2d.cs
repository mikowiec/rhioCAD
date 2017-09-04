#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpAx2d : NativeInstancePtr
	{
		public gpAx2d()
 :
			base(gp_Ax2d_Ctor() )
		{}
		public gpAx2d(gpPnt2d P,gpDir2d V)
 :
			base(gp_Ax2d_Ctor2E9C6BD1(P.Instance, V.Instance) )
		{}
			public bool IsCoaxial(gpAx2d Other,double AngularTolerance,double LinearTolerance)
				{
					return gp_Ax2d_IsCoaxial4745308(Instance, Other.Instance, AngularTolerance, LinearTolerance);
				}
			public bool IsNormal(gpAx2d Other,double AngularTolerance)
				{
					return gp_Ax2d_IsNormalF4E58768(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsOpposite(gpAx2d Other,double AngularTolerance)
				{
					return gp_Ax2d_IsOppositeF4E58768(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsParallel(gpAx2d Other,double AngularTolerance)
				{
					return gp_Ax2d_IsParallelF4E58768(Instance, Other.Instance, AngularTolerance);
				}
			public double Angle(gpAx2d Other)
				{
					return gp_Ax2d_Angle90E1386A(Instance, Other.Instance);
				}
			public void Reverse()
				{
					gp_Ax2d_Reverse(Instance);
				}
			public void Mirror(gpPnt2d P)
				{
					gp_Ax2d_Mirror6203658C(Instance, P.Instance);
				}
			public gpAx2d Mirrored(gpPnt2d P)
				{
					return new gpAx2d(gp_Ax2d_Mirrored6203658C(Instance, P.Instance));
				}
			public void Mirror(gpAx2d A)
				{
					gp_Ax2d_Mirror90E1386A(Instance, A.Instance);
				}
			public gpAx2d Mirrored(gpAx2d A)
				{
					return new gpAx2d(gp_Ax2d_Mirrored90E1386A(Instance, A.Instance));
				}
			public void Rotate(gpPnt2d P,double Ang)
				{
					gp_Ax2d_RotateE3062737(Instance, P.Instance, Ang);
				}
			public gpAx2d Rotated(gpPnt2d P,double Ang)
				{
					return new gpAx2d(gp_Ax2d_RotatedE3062737(Instance, P.Instance, Ang));
				}
			public void Scale(gpPnt2d P,double S)
				{
					gp_Ax2d_ScaleE3062737(Instance, P.Instance, S);
				}
			public gpAx2d Scaled(gpPnt2d P,double S)
				{
					return new gpAx2d(gp_Ax2d_ScaledE3062737(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf2d T)
				{
					gp_Ax2d_Transform27621DCB(Instance, T.Instance);
				}
			public gpAx2d Transformed(gpTrsf2d T)
				{
					return new gpAx2d(gp_Ax2d_Transformed27621DCB(Instance, T.Instance));
				}
			public void Translate(gpVec2d V)
				{
					gp_Ax2d_Translate5E4E66E7(Instance, V.Instance);
				}
			public gpAx2d Translated(gpVec2d V)
				{
					return new gpAx2d(gp_Ax2d_Translated5E4E66E7(Instance, V.Instance));
				}
			public void Translate(gpPnt2d P1,gpPnt2d P2)
				{
					gp_Ax2d_Translate5F54ADE3(Instance, P1.Instance, P2.Instance);
				}
			public gpAx2d Translated(gpPnt2d P1,gpPnt2d P2)
				{
					return new gpAx2d(gp_Ax2d_Translated5F54ADE3(Instance, P1.Instance, P2.Instance));
				}
		public gpPnt2d Location{
			set { 
				gp_Ax2d_SetLocation(Instance, value.Instance);
			}
			get {
				return new gpPnt2d(gp_Ax2d_Location(Instance));
			}
		}
		public gpDir2d Direction{
			set { 
				gp_Ax2d_SetDirection(Instance, value.Instance);
			}
			get {
				return new gpDir2d(gp_Ax2d_Direction(Instance));
			}
		}
		public gpAx2d Reversed{
			get {
				return new gpAx2d(gp_Ax2d_Reversed(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2d_Ctor2E9C6BD1(IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax2d_IsCoaxial4745308(IntPtr instance, IntPtr Other,double AngularTolerance,double LinearTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax2d_IsNormalF4E58768(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax2d_IsOppositeF4E58768(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Ax2d_IsParallelF4E58768(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Ax2d_Angle90E1386A(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2d_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2d_Mirror6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2d_Mirrored6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2d_Mirror90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2d_Mirrored90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2d_RotateE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2d_RotatedE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2d_ScaleE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2d_ScaledE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2d_Transform27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2d_Transformed27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2d_Translate5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2d_Translated5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2d_Translate5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2d_Translated5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2d_SetLocation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2d_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Ax2d_SetDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2d_Direction(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Ax2d_Reversed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpAx2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpAx2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpAx2d_Dtor(IntPtr instance);
	}
}
