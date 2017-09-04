#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpDir2d : NativeInstancePtr
	{
		public gpDir2d()
 :
			base(gp_Dir2d_Ctor() )
		{}
		public gpDir2d(gpVec2d V)
 :
			base(gp_Dir2d_Ctor5E4E66E7(V.Instance) )
		{}
		public gpDir2d(gpXY Coord)
 :
			base(gp_Dir2d_CtorE051EF89(Coord.Instance) )
		{}
		public gpDir2d(double Xv,double Yv)
 :
			base(gp_Dir2d_Ctor9F0E714F(Xv, Yv) )
		{}
			public void SetCoord(int Index,double Xi)
				{
					gp_Dir2d_SetCoord69F5FCCD(Instance, Index, Xi);
				}
			public void SetCoord(double Xv,double Yv)
				{
					gp_Dir2d_SetCoord9F0E714F(Instance, Xv, Yv);
				}
			public double Coord(int Index)
				{
					return gp_Dir2d_CoordE8219145(Instance, Index);
				}
			public void Coord(ref double Xv,ref double Yv)
				{
					gp_Dir2d_Coord9F0E714F(Instance, ref Xv, ref Yv);
				}
			public bool IsEqual(gpDir2d Other,double AngularTolerance)
				{
					return gp_Dir2d_IsEqualD488E15(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsNormal(gpDir2d Other,double AngularTolerance)
				{
					return gp_Dir2d_IsNormalD488E15(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsOpposite(gpDir2d Other,double AngularTolerance)
				{
					return gp_Dir2d_IsOppositeD488E15(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsParallel(gpDir2d Other,double AngularTolerance)
				{
					return gp_Dir2d_IsParallelD488E15(Instance, Other.Instance, AngularTolerance);
				}
			public double Angle(gpDir2d Other)
				{
					return gp_Dir2d_Angle92BBA68E(Instance, Other.Instance);
				}
			public double Crossed(gpDir2d Right)
				{
					return gp_Dir2d_Crossed92BBA68E(Instance, Right.Instance);
				}
			public double Dot(gpDir2d Other)
				{
					return gp_Dir2d_Dot92BBA68E(Instance, Other.Instance);
				}
			public void Reverse()
				{
					gp_Dir2d_Reverse(Instance);
				}
			public void Mirror(gpDir2d V)
				{
					gp_Dir2d_Mirror92BBA68E(Instance, V.Instance);
				}
			public gpDir2d Mirrored(gpDir2d V)
				{
					return new gpDir2d(gp_Dir2d_Mirrored92BBA68E(Instance, V.Instance));
				}
			public void Mirror(gpAx2d A)
				{
					gp_Dir2d_Mirror90E1386A(Instance, A.Instance);
				}
			public gpDir2d Mirrored(gpAx2d A)
				{
					return new gpDir2d(gp_Dir2d_Mirrored90E1386A(Instance, A.Instance));
				}
			public void Rotate(double Ang)
				{
					gp_Dir2d_RotateD82819F3(Instance, Ang);
				}
			public gpDir2d Rotated(double Ang)
				{
					return new gpDir2d(gp_Dir2d_RotatedD82819F3(Instance, Ang));
				}
			public void Transform(gpTrsf2d T)
				{
					gp_Dir2d_Transform27621DCB(Instance, T.Instance);
				}
			public gpDir2d Transformed(gpTrsf2d T)
				{
					return new gpDir2d(gp_Dir2d_Transformed27621DCB(Instance, T.Instance));
				}
		public double X{
			set { 
				gp_Dir2d_SetX(Instance, value);
			}
			get {
				return gp_Dir2d_X(Instance);
			}
		}
		public double Y{
			set { 
				gp_Dir2d_SetY(Instance, value);
			}
			get {
				return gp_Dir2d_Y(Instance);
			}
		}
		public gpXY XY{
			set { 
				gp_Dir2d_SetXY(Instance, value.Instance);
			}
			get {
				return new gpXY(gp_Dir2d_XY(Instance));
			}
		}
		public gpDir2d Reversed{
			get {
				return new gpDir2d(gp_Dir2d_Reversed(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir2d_Ctor5E4E66E7(IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir2d_CtorE051EF89(IntPtr Coord);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir2d_Ctor9F0E714F(double Xv,double Yv);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir2d_SetCoord69F5FCCD(IntPtr instance, int Index,double Xi);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir2d_SetCoord9F0E714F(IntPtr instance, double Xv,double Yv);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir2d_CoordE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir2d_Coord9F0E714F(IntPtr instance, ref double Xv,ref double Yv);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Dir2d_IsEqualD488E15(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Dir2d_IsNormalD488E15(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Dir2d_IsOppositeD488E15(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Dir2d_IsParallelD488E15(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir2d_Angle92BBA68E(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir2d_Crossed92BBA68E(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir2d_Dot92BBA68E(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir2d_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir2d_Mirror92BBA68E(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir2d_Mirrored92BBA68E(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir2d_Mirror90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir2d_Mirrored90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir2d_RotateD82819F3(IntPtr instance, double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir2d_RotatedD82819F3(IntPtr instance, double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir2d_Transform27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir2d_Transformed27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir2d_SetX(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir2d_X(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir2d_SetY(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Dir2d_Y(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dir2d_SetXY(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir2d_XY(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Dir2d_Reversed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpDir2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpDir2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpDir2d_Dtor(IntPtr instance);
	}
}
