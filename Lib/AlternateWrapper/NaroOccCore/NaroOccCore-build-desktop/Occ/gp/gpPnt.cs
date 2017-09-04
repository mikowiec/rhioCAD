#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpPnt : NativeInstancePtr
	{
		public gpPnt()
 :
			base(gp_Pnt_Ctor() )
		{}
		public gpPnt(gpXYZ Coord)
 :
			base(gp_Pnt_Ctor8EE42329(Coord.Instance) )
		{}
		public gpPnt(double Xp,double Yp,double Zp)
 :
			base(gp_Pnt_Ctor9282A951(Xp, Yp, Zp) )
		{}
			public void SetCoord(int Index,double Xi)
				{
					gp_Pnt_SetCoord69F5FCCD(Instance, Index, Xi);
				}
			public void SetCoord(double Xp,double Yp,double Zp)
				{
					gp_Pnt_SetCoord9282A951(Instance, Xp, Yp, Zp);
				}
			public double Coord(int Index)
				{
					return gp_Pnt_CoordE8219145(Instance, Index);
				}
			public void Coord(ref double Xp,ref double Yp,ref double Zp)
				{
					gp_Pnt_Coord9282A951(Instance, ref Xp, ref Yp, ref Zp);
				}
			public gpXYZ Coord()
				{
					return new gpXYZ(gp_Pnt_Coord(Instance));
				}
			public void BaryCenter(double Alpha,gpPnt P,double Beta)
				{
					gp_Pnt_BaryCenterED1E08EC(Instance, Alpha, P.Instance, Beta);
				}
			public bool IsEqual(gpPnt Other,double LinearTolerance)
				{
					return gp_Pnt_IsEqualF0D1E3E6(Instance, Other.Instance, LinearTolerance);
				}
			public double Distance(gpPnt Other)
				{
					return gp_Pnt_Distance9EAECD5B(Instance, Other.Instance);
				}
			public double SquareDistance(gpPnt Other)
				{
					return gp_Pnt_SquareDistance9EAECD5B(Instance, Other.Instance);
				}
			public void Mirror(gpPnt P)
				{
					gp_Pnt_Mirror9EAECD5B(Instance, P.Instance);
				}
			public gpPnt Mirrored(gpPnt P)
				{
					return new gpPnt(gp_Pnt_Mirrored9EAECD5B(Instance, P.Instance));
				}
			public void Mirror(gpAx1 A1)
				{
					gp_Pnt_Mirror608B963B(Instance, A1.Instance);
				}
			public gpPnt Mirrored(gpAx1 A1)
				{
					return new gpPnt(gp_Pnt_Mirrored608B963B(Instance, A1.Instance));
				}
			public void Mirror(gpAx2 A2)
				{
					gp_Pnt_Mirror7895386A(Instance, A2.Instance);
				}
			public gpPnt Mirrored(gpAx2 A2)
				{
					return new gpPnt(gp_Pnt_Mirrored7895386A(Instance, A2.Instance));
				}
			public void Rotate(gpAx1 A1,double Ang)
				{
					gp_Pnt_Rotate827CB19A(Instance, A1.Instance, Ang);
				}
			public gpPnt Rotated(gpAx1 A1,double Ang)
				{
					return new gpPnt(gp_Pnt_Rotated827CB19A(Instance, A1.Instance, Ang));
				}
			public void Scale(gpPnt P,double S)
				{
					gp_Pnt_ScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public gpPnt Scaled(gpPnt P,double S)
				{
					return new gpPnt(gp_Pnt_ScaledF0D1E3E6(Instance, P.Instance, S));
				}
			public void Transform(gpTrsf T)
				{
					gp_Pnt_Transform72D78650(Instance, T.Instance);
				}
			public gpPnt Transformed(gpTrsf T)
				{
					return new gpPnt(gp_Pnt_Transformed72D78650(Instance, T.Instance));
				}
			public void Translate(gpVec V)
				{
					gp_Pnt_Translate9BD9CFFE(Instance, V.Instance);
				}
			public gpPnt Translated(gpVec V)
				{
					return new gpPnt(gp_Pnt_Translated9BD9CFFE(Instance, V.Instance));
				}
			public void Translate(gpPnt P1,gpPnt P2)
				{
					gp_Pnt_Translate5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public gpPnt Translated(gpPnt P1,gpPnt P2)
				{
					return new gpPnt(gp_Pnt_Translated5C63477E(Instance, P1.Instance, P2.Instance));
				}
		public double X{
			set { 
				gp_Pnt_SetX(Instance, value);
			}
			get {
				return gp_Pnt_X(Instance);
			}
		}
		public double Y{
			set { 
				gp_Pnt_SetY(Instance, value);
			}
			get {
				return gp_Pnt_Y(Instance);
			}
		}
		public double Z{
			set { 
				gp_Pnt_SetZ(Instance, value);
			}
			get {
				return gp_Pnt_Z(Instance);
			}
		}
		public gpXYZ XYZ{
			set { 
				gp_Pnt_SetXYZ(Instance, value.Instance);
			}
			get {
				return new gpXYZ(gp_Pnt_XYZ(Instance));
			}
		}
		public gpXYZ ChangeCoord{
			get {
				return new gpXYZ(gp_Pnt_ChangeCoord(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_Ctor8EE42329(IntPtr Coord);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_Ctor9282A951(double Xp,double Yp,double Zp);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_SetCoord69F5FCCD(IntPtr instance, int Index,double Xi);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_SetCoord9282A951(IntPtr instance, double Xp,double Yp,double Zp);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pnt_CoordE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_Coord9282A951(IntPtr instance, ref double Xp,ref double Yp,ref double Zp);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_Coord(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_BaryCenterED1E08EC(IntPtr instance, double Alpha,IntPtr P,double Beta);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Pnt_IsEqualF0D1E3E6(IntPtr instance, IntPtr Other,double LinearTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pnt_Distance9EAECD5B(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pnt_SquareDistance9EAECD5B(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_Mirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_Mirrored9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_Mirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_Mirrored608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_Mirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_Mirrored7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_Rotate827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_Rotated827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_ScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_ScaledF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_Transformed72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_Translate9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_Translated9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_Translate5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_Translated5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_SetX(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pnt_X(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_SetY(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pnt_Y(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_SetZ(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Pnt_Z(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Pnt_SetXYZ(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_XYZ(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Pnt_ChangeCoord(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpPnt(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpPnt_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpPnt_Dtor(IntPtr instance);
	}
}
