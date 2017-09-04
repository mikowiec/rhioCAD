#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpPnt2d : NativeInstancePtr
	{
		public gpPnt2d()
 :
			base(gp_Pnt2d_Ctor() )
		{}
		public gpPnt2d(gpXY Coord)
 :
			base(gp_Pnt2d_CtorE051EF89(Coord.Instance) )
		{}
		public gpPnt2d(double Xp,double Yp)
 :
			base(gp_Pnt2d_Ctor9F0E714F(Xp, Yp) )
		{}
			public void SetCoord(int Index,double Xi)
				{
					gp_Pnt2d_SetCoord69F5FCCD(Instance, Index, Xi);
				}
			public void SetCoord(double Xp,double Yp)
				{
					gp_Pnt2d_SetCoord9F0E714F(Instance, Xp, Yp);
				}
			public double Coord(int Index)
				{
					return gp_Pnt2d_CoordE8219145(Instance, Index);
				}
			public void Coord(ref double Xp,ref double Yp)
				{
					gp_Pnt2d_Coord9F0E714F(Instance, ref Xp, ref Yp);
				}
			public gpXY Coord()
				{
					return new gpXY(gp_Pnt2d_Coord(Instance));
				}
			public bool IsEqual(gpPnt2d Other,double LinearTolerance)
				{
					return gp_Pnt2d_IsEqualE3062737(Instance, Other.Instance, LinearTolerance);
				}
			public double Distance(gpPnt2d Other)
				{
					return gp_Pnt2d_Distance6203658C(Instance, Other.Instance);
				}
			public double SquareDistance(gpPnt2d Other)
				{
					return gp_Pnt2d_SquareDistance6203658C(Instance, Other.Instance);
				}
			public void Mirror(gpPnt2d P)
				{
					gp_Pnt2d_Mirror6203658C(Instance, P.Instance);
				}
			public gpPnt2d Mirrored(gpPnt2d P)
				{
					return new gpPnt2d(gp_Pnt2d_Mirrored6203658C(Instance, P.Instance));
				}
			public void Mirror(gpAx2d A)
				{
					gp_Pnt2d_Mirror90E1386A(Instance, A.Instance);
				}
			public gpPnt2d Mirrored(gpAx2d A)
				{
					return new gpPnt2d(gp_Pnt2d_Mirrored90E1386A(Instance, A.Instance));
				}
			public void Rotate(gpPnt2d P,double Ang)
				{
					gp_Pnt2d_RotateE3062737(Instance, P.Instance, Ang);
				}
			public gpPnt2d Rotated(gpPnt2d P,double Ang)
				{
					return new gpPnt2d(gp_Pnt2d_RotatedE3062737(Instance, P.Instance, Ang));
				}
			public void Scale(gpPnt2d P,double S)
				{
					gp_Pnt2d_ScaleE3062737(Instance, P.Instance, S);
				}
			public gpPnt2d Scaled(gpPnt2d P,double S)
				{
					return new gpPnt2d(gp_Pnt2d_ScaledE3062737(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf2d T)
				{
					gp_Pnt2d_Transform27621DCB(Instance, T.Instance);
				}
			public gpPnt2d Transformed(gpTrsf2d T)
				{
					return new gpPnt2d(gp_Pnt2d_Transformed27621DCB(Instance, T.Instance));
				}
			public void Translate(gpVec2d V)
				{
					gp_Pnt2d_Translate5E4E66E7(Instance, V.Instance);
				}
			public gpPnt2d Translated(gpVec2d V)
				{
					return new gpPnt2d(gp_Pnt2d_Translated5E4E66E7(Instance, V.Instance));
				}
			public void Translate(gpPnt2d P1,gpPnt2d P2)
				{
					gp_Pnt2d_Translate5F54ADE3(Instance, P1.Instance, P2.Instance);
				}
			public gpPnt2d Translated(gpPnt2d P1,gpPnt2d P2)
				{
					return new gpPnt2d(gp_Pnt2d_Translated5F54ADE3(Instance, P1.Instance, P2.Instance));
				}
		public double X{
			set { 
				gp_Pnt2d_SetX(Instance, value);
			}
			get {
				return gp_Pnt2d_X(Instance);
			}
		}
		public double Y{
			set { 
				gp_Pnt2d_SetY(Instance, value);
			}
			get {
				return gp_Pnt2d_Y(Instance);
			}
		}
		public gpXY XY{
			set { 
				gp_Pnt2d_SetXY(Instance, value.Instance);
			}
			get {
				return new gpXY(gp_Pnt2d_XY(Instance));
			}
		}
		public gpXY ChangeCoord{
			get {
				return new gpXY(gp_Pnt2d_ChangeCoord(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_CtorE051EF89(IntPtr Coord);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_Ctor9F0E714F(double Xp,double Yp);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_SetCoord69F5FCCD(IntPtr instance, int Index,double Xi);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_SetCoord9F0E714F(IntPtr instance, double Xp,double Yp);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pnt2d_CoordE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_Coord9F0E714F(IntPtr instance, ref double Xp,ref double Yp);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_Coord(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Pnt2d_IsEqualE3062737(IntPtr instance, IntPtr Other,double LinearTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pnt2d_Distance6203658C(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pnt2d_SquareDistance6203658C(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_Mirror6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_Mirrored6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_Mirror90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_Mirrored90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_RotateE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_RotatedE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_ScaleE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_ScaledE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_Transform27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_Transformed27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_Translate5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_Translated5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_Translate5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_Translated5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_SetX(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pnt2d_X(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_SetY(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pnt2d_Y(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt2d_SetXY(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_XY(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt2d_ChangeCoord(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpPnt2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpPnt2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpPnt2d_Dtor(IntPtr instance);
	}
}
