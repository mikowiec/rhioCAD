#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpVec2d : NativeInstancePtr
	{
		public gpVec2d()
 :
			base(gp_Vec2d_Ctor() )
		{}
		public gpVec2d(gpDir2d V)
 :
			base(gp_Vec2d_Ctor92BBA68E(V.Instance) )
		{}
		public gpVec2d(gpXY Coord)
 :
			base(gp_Vec2d_CtorE051EF89(Coord.Instance) )
		{}
		public gpVec2d(double Xv,double Yv)
 :
			base(gp_Vec2d_Ctor9F0E714F(Xv, Yv) )
		{}
		public gpVec2d(gpPnt2d P1,gpPnt2d P2)
 :
			base(gp_Vec2d_Ctor5F54ADE3(P1.Instance, P2.Instance) )
		{}
			public void SetCoord(int Index,double Xi)
				{
					gp_Vec2d_SetCoord69F5FCCD(Instance, Index, Xi);
				}
			public void SetCoord(double Xv,double Yv)
				{
					gp_Vec2d_SetCoord9F0E714F(Instance, Xv, Yv);
				}
			public double Coord(int Index)
				{
					return gp_Vec2d_CoordE8219145(Instance, Index);
				}
			public void Coord(ref double Xv,ref double Yv)
				{
					gp_Vec2d_Coord9F0E714F(Instance, ref Xv, ref Yv);
				}
			public bool IsEqual(gpVec2d Other,double LinearTolerance,double AngularTolerance)
				{
					return gp_Vec2d_IsEqual1F89D6DF(Instance, Other.Instance, LinearTolerance, AngularTolerance);
				}
			public bool IsNormal(gpVec2d Other,double AngularTolerance)
				{
					return gp_Vec2d_IsNormalC1B831C6(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsOpposite(gpVec2d Other,double AngularTolerance)
				{
					return gp_Vec2d_IsOppositeC1B831C6(Instance, Other.Instance, AngularTolerance);
				}
			public bool IsParallel(gpVec2d Other,double AngularTolerance)
				{
					return gp_Vec2d_IsParallelC1B831C6(Instance, Other.Instance, AngularTolerance);
				}
			public double Angle(gpVec2d Other)
				{
					return gp_Vec2d_Angle5E4E66E7(Instance, Other.Instance);
				}
			public void Add(gpVec2d Other)
				{
					gp_Vec2d_Add5E4E66E7(Instance, Other.Instance);
				}
			public gpVec2d Added(gpVec2d Other)
				{
					return new gpVec2d(gp_Vec2d_Added5E4E66E7(Instance, Other.Instance));
				}
			public double Crossed(gpVec2d Right)
				{
					return gp_Vec2d_Crossed5E4E66E7(Instance, Right.Instance);
				}
			public double CrossMagnitude(gpVec2d Right)
				{
					return gp_Vec2d_CrossMagnitude5E4E66E7(Instance, Right.Instance);
				}
			public double CrossSquareMagnitude(gpVec2d Right)
				{
					return gp_Vec2d_CrossSquareMagnitude5E4E66E7(Instance, Right.Instance);
				}
			public void Divide(double Scalar)
				{
					gp_Vec2d_DivideD82819F3(Instance, Scalar);
				}
			public gpVec2d Divided(double Scalar)
				{
					return new gpVec2d(gp_Vec2d_DividedD82819F3(Instance, Scalar));
				}
			public double Dot(gpVec2d Other)
				{
					return gp_Vec2d_Dot5E4E66E7(Instance, Other.Instance);
				}
			public void Multiply(double Scalar)
				{
					gp_Vec2d_MultiplyD82819F3(Instance, Scalar);
				}
			public gpVec2d Multiplied(double Scalar)
				{
					return new gpVec2d(gp_Vec2d_MultipliedD82819F3(Instance, Scalar));
				}
			public void Normalize()
				{
					gp_Vec2d_Normalize(Instance);
				}
			public void Reverse()
				{
					gp_Vec2d_Reverse(Instance);
				}
			public void Subtract(gpVec2d Right)
				{
					gp_Vec2d_Subtract5E4E66E7(Instance, Right.Instance);
				}
			public gpVec2d Subtracted(gpVec2d Right)
				{
					return new gpVec2d(gp_Vec2d_Subtracted5E4E66E7(Instance, Right.Instance));
				}
			public void SetLinearForm(double A1,gpVec2d V1,double A2,gpVec2d V2,gpVec2d V3)
				{
					gp_Vec2d_SetLinearForm98ABEE74(Instance, A1, V1.Instance, A2, V2.Instance, V3.Instance);
				}
			public void SetLinearForm(double A1,gpVec2d V1,double A2,gpVec2d V2)
				{
					gp_Vec2d_SetLinearForm39A7F68A(Instance, A1, V1.Instance, A2, V2.Instance);
				}
			public void SetLinearForm(double A1,gpVec2d V1,gpVec2d V2)
				{
					gp_Vec2d_SetLinearForm7874D091(Instance, A1, V1.Instance, V2.Instance);
				}
			public void SetLinearForm(gpVec2d Left,gpVec2d Right)
				{
					gp_Vec2d_SetLinearFormE2FF8249(Instance, Left.Instance, Right.Instance);
				}
			public void Mirror(gpVec2d V)
				{
					gp_Vec2d_Mirror5E4E66E7(Instance, V.Instance);
				}
			public gpVec2d Mirrored(gpVec2d V)
				{
					return new gpVec2d(gp_Vec2d_Mirrored5E4E66E7(Instance, V.Instance));
				}
			public void Mirror(gpAx2d A1)
				{
					gp_Vec2d_Mirror90E1386A(Instance, A1.Instance);
				}
			public gpVec2d Mirrored(gpAx2d A1)
				{
					return new gpVec2d(gp_Vec2d_Mirrored90E1386A(Instance, A1.Instance));
				}
			public void Rotate(double Ang)
				{
					gp_Vec2d_RotateD82819F3(Instance, Ang);
				}
			public gpVec2d Rotated(double Ang)
				{
					return new gpVec2d(gp_Vec2d_RotatedD82819F3(Instance, Ang));
				}
			public void Scale(double S)
				{
					gp_Vec2d_ScaleD82819F3(Instance, S);
				}
			public gpVec2d Scaled(double S)
				{
					return new gpVec2d(gp_Vec2d_ScaledD82819F3(Instance, S));
				}
			public void Transform(gpTrsf2d T)
				{
					gp_Vec2d_Transform27621DCB(Instance, T.Instance);
				}
			public gpVec2d Transformed(gpTrsf2d T)
				{
					return new gpVec2d(gp_Vec2d_Transformed27621DCB(Instance, T.Instance));
				}
		public double X{
			set { 
				gp_Vec2d_SetX(Instance, value);
			}
			get {
				return gp_Vec2d_X(Instance);
			}
		}
		public double Y{
			set { 
				gp_Vec2d_SetY(Instance, value);
			}
			get {
				return gp_Vec2d_Y(Instance);
			}
		}
		public gpXY XY{
			set { 
				gp_Vec2d_SetXY(Instance, value.Instance);
			}
			get {
				return new gpXY(gp_Vec2d_XY(Instance));
			}
		}
		public double Magnitude{
			get {
				return gp_Vec2d_Magnitude(Instance);
			}
		}
		public double SquareMagnitude{
			get {
				return gp_Vec2d_SquareMagnitude(Instance);
			}
		}
		public gpVec2d Normalized{
			get {
				return new gpVec2d(gp_Vec2d_Normalized(Instance));
			}
		}
		public gpVec2d Reversed{
			get {
				return new gpVec2d(gp_Vec2d_Reversed(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_Ctor92BBA68E(IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_CtorE051EF89(IntPtr Coord);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_Ctor9F0E714F(double Xv,double Yv);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_Ctor5F54ADE3(IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_SetCoord69F5FCCD(IntPtr instance, int Index,double Xi);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_SetCoord9F0E714F(IntPtr instance, double Xv,double Yv);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec2d_CoordE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_Coord9F0E714F(IntPtr instance, ref double Xv,ref double Yv);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Vec2d_IsEqual1F89D6DF(IntPtr instance, IntPtr Other,double LinearTolerance,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Vec2d_IsNormalC1B831C6(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Vec2d_IsOppositeC1B831C6(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Vec2d_IsParallelC1B831C6(IntPtr instance, IntPtr Other,double AngularTolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec2d_Angle5E4E66E7(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_Add5E4E66E7(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_Added5E4E66E7(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec2d_Crossed5E4E66E7(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec2d_CrossMagnitude5E4E66E7(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec2d_CrossSquareMagnitude5E4E66E7(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_DivideD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_DividedD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec2d_Dot5E4E66E7(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_MultiplyD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_MultipliedD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_Normalize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_Subtract5E4E66E7(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_Subtracted5E4E66E7(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_SetLinearForm98ABEE74(IntPtr instance, double A1,IntPtr V1,double A2,IntPtr V2,IntPtr V3);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_SetLinearForm39A7F68A(IntPtr instance, double A1,IntPtr V1,double A2,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_SetLinearForm7874D091(IntPtr instance, double A1,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_SetLinearFormE2FF8249(IntPtr instance, IntPtr Left,IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_Mirror5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_Mirrored5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_Mirror90E1386A(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_Mirrored90E1386A(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_RotateD82819F3(IntPtr instance, double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_RotatedD82819F3(IntPtr instance, double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_ScaleD82819F3(IntPtr instance, double S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_ScaledD82819F3(IntPtr instance, double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_Transform27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_Transformed27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_SetX(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec2d_X(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_SetY(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec2d_Y(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Vec2d_SetXY(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_XY(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec2d_Magnitude(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Vec2d_SquareMagnitude(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_Normalized(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Vec2d_Reversed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpVec2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpVec2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpVec2d_Dtor(IntPtr instance);
	}
}
