#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpXYZ : NativeInstancePtr
	{
		public gpXYZ()
 :
			base(gp_XYZ_Ctor() )
		{}
		public gpXYZ(double X,double Y,double Z)
 :
			base(gp_XYZ_Ctor9282A951(X, Y, Z) )
		{}
			public void SetCoord(double X,double Y,double Z)
				{
					gp_XYZ_SetCoord9282A951(Instance, X, Y, Z);
				}
			public void SetCoord(int Index,double Xi)
				{
					gp_XYZ_SetCoord69F5FCCD(Instance, Index, Xi);
				}
			public double Coord(int Index)
				{
					return gp_XYZ_CoordE8219145(Instance, Index);
				}
			public void Coord(ref double X,ref double Y,ref double Z)
				{
					gp_XYZ_Coord9282A951(Instance, ref X, ref Y, ref Z);
				}
			public bool IsEqual(gpXYZ Other,double Tolerance)
				{
					return gp_XYZ_IsEqualAC21764D(Instance, Other.Instance, Tolerance);
				}
			public void Add(gpXYZ Other)
				{
					gp_XYZ_Add8EE42329(Instance, Other.Instance);
				}
			public gpXYZ Added(gpXYZ Other)
				{
					return new gpXYZ(gp_XYZ_Added8EE42329(Instance, Other.Instance));
				}
			public void Cross(gpXYZ Right)
				{
					gp_XYZ_Cross8EE42329(Instance, Right.Instance);
				}
			public gpXYZ Crossed(gpXYZ Right)
				{
					return new gpXYZ(gp_XYZ_Crossed8EE42329(Instance, Right.Instance));
				}
			public double CrossMagnitude(gpXYZ Right)
				{
					return gp_XYZ_CrossMagnitude8EE42329(Instance, Right.Instance);
				}
			public double CrossSquareMagnitude(gpXYZ Right)
				{
					return gp_XYZ_CrossSquareMagnitude8EE42329(Instance, Right.Instance);
				}
			public void CrossCross(gpXYZ Coord1,gpXYZ Coord2)
				{
					gp_XYZ_CrossCross610ADE9D(Instance, Coord1.Instance, Coord2.Instance);
				}
			public gpXYZ CrossCrossed(gpXYZ Coord1,gpXYZ Coord2)
				{
					return new gpXYZ(gp_XYZ_CrossCrossed610ADE9D(Instance, Coord1.Instance, Coord2.Instance));
				}
			public void Divide(double Scalar)
				{
					gp_XYZ_DivideD82819F3(Instance, Scalar);
				}
			public gpXYZ Divided(double Scalar)
				{
					return new gpXYZ(gp_XYZ_DividedD82819F3(Instance, Scalar));
				}
			public double Dot(gpXYZ Other)
				{
					return gp_XYZ_Dot8EE42329(Instance, Other.Instance);
				}
			public double DotCross(gpXYZ Coord1,gpXYZ Coord2)
				{
					return gp_XYZ_DotCross610ADE9D(Instance, Coord1.Instance, Coord2.Instance);
				}
			public void Multiply(double Scalar)
				{
					gp_XYZ_MultiplyD82819F3(Instance, Scalar);
				}
			public void Multiply(gpXYZ Other)
				{
					gp_XYZ_Multiply8EE42329(Instance, Other.Instance);
				}
			public void Multiply(gpMat Matrix)
				{
					gp_XYZ_Multiply9EABCD40(Instance, Matrix.Instance);
				}
			public gpXYZ Multiplied(double Scalar)
				{
					return new gpXYZ(gp_XYZ_MultipliedD82819F3(Instance, Scalar));
				}
			public gpXYZ Multiplied(gpXYZ Other)
				{
					return new gpXYZ(gp_XYZ_Multiplied8EE42329(Instance, Other.Instance));
				}
			public gpXYZ Multiplied(gpMat Matrix)
				{
					return new gpXYZ(gp_XYZ_Multiplied9EABCD40(Instance, Matrix.Instance));
				}
			public void Normalize()
				{
					gp_XYZ_Normalize(Instance);
				}
			public void Reverse()
				{
					gp_XYZ_Reverse(Instance);
				}
			public void Subtract(gpXYZ Right)
				{
					gp_XYZ_Subtract8EE42329(Instance, Right.Instance);
				}
			public gpXYZ Subtracted(gpXYZ Right)
				{
					return new gpXYZ(gp_XYZ_Subtracted8EE42329(Instance, Right.Instance));
				}
			public void SetLinearForm(double A1,gpXYZ XYZ1,double A2,gpXYZ XYZ2,double A3,gpXYZ XYZ3,gpXYZ XYZ4)
				{
					gp_XYZ_SetLinearFormF220B60(Instance, A1, XYZ1.Instance, A2, XYZ2.Instance, A3, XYZ3.Instance, XYZ4.Instance);
				}
			public void SetLinearForm(double A1,gpXYZ XYZ1,double A2,gpXYZ XYZ2,double A3,gpXYZ XYZ3)
				{
					gp_XYZ_SetLinearFormF4A81B86(Instance, A1, XYZ1.Instance, A2, XYZ2.Instance, A3, XYZ3.Instance);
				}
			public void SetLinearForm(double A1,gpXYZ XYZ1,double A2,gpXYZ XYZ2,gpXYZ XYZ3)
				{
					gp_XYZ_SetLinearFormD61C07A0(Instance, A1, XYZ1.Instance, A2, XYZ2.Instance, XYZ3.Instance);
				}
			public void SetLinearForm(double A1,gpXYZ XYZ1,double A2,gpXYZ XYZ2)
				{
					gp_XYZ_SetLinearForm6062D8AE(Instance, A1, XYZ1.Instance, A2, XYZ2.Instance);
				}
			public void SetLinearForm(double A1,gpXYZ XYZ1,gpXYZ XYZ2)
				{
					gp_XYZ_SetLinearForm628B7A49(Instance, A1, XYZ1.Instance, XYZ2.Instance);
				}
			public void SetLinearForm(gpXYZ XYZ1,gpXYZ XYZ2)
				{
					gp_XYZ_SetLinearForm610ADE9D(Instance, XYZ1.Instance, XYZ2.Instance);
				}
		public double X{
			set { 
				gp_XYZ_SetX(Instance, value);
			}
			get {
				return gp_XYZ_X(Instance);
			}
		}
		public double Y{
			set { 
				gp_XYZ_SetY(Instance, value);
			}
			get {
				return gp_XYZ_Y(Instance);
			}
		}
		public double Z{
			set { 
				gp_XYZ_SetZ(Instance, value);
			}
			get {
				return gp_XYZ_Z(Instance);
			}
		}
		public double Modulus{
			get {
				return gp_XYZ_Modulus(Instance);
			}
		}
		public double SquareModulus{
			get {
				return gp_XYZ_SquareModulus(Instance);
			}
		}
		public gpXYZ Normalized{
			get {
				return new gpXYZ(gp_XYZ_Normalized(Instance));
			}
		}
		public gpXYZ Reversed{
			get {
				return new gpXYZ(gp_XYZ_Reversed(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XYZ_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XYZ_Ctor9282A951(double X,double Y,double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_SetCoord9282A951(IntPtr instance, double X,double Y,double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_SetCoord69F5FCCD(IntPtr instance, int Index,double Xi);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XYZ_CoordE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_Coord9282A951(IntPtr instance, ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_XYZ_IsEqualAC21764D(IntPtr instance, IntPtr Other,double Tolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_Add8EE42329(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XYZ_Added8EE42329(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_Cross8EE42329(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XYZ_Crossed8EE42329(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XYZ_CrossMagnitude8EE42329(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XYZ_CrossSquareMagnitude8EE42329(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_CrossCross610ADE9D(IntPtr instance, IntPtr Coord1,IntPtr Coord2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XYZ_CrossCrossed610ADE9D(IntPtr instance, IntPtr Coord1,IntPtr Coord2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_DivideD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XYZ_DividedD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XYZ_Dot8EE42329(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XYZ_DotCross610ADE9D(IntPtr instance, IntPtr Coord1,IntPtr Coord2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_MultiplyD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_Multiply8EE42329(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_Multiply9EABCD40(IntPtr instance, IntPtr Matrix);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XYZ_MultipliedD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XYZ_Multiplied8EE42329(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XYZ_Multiplied9EABCD40(IntPtr instance, IntPtr Matrix);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_Normalize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_Subtract8EE42329(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XYZ_Subtracted8EE42329(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_SetLinearFormF220B60(IntPtr instance, double A1,IntPtr XYZ1,double A2,IntPtr XYZ2,double A3,IntPtr XYZ3,IntPtr XYZ4);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_SetLinearFormF4A81B86(IntPtr instance, double A1,IntPtr XYZ1,double A2,IntPtr XYZ2,double A3,IntPtr XYZ3);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_SetLinearFormD61C07A0(IntPtr instance, double A1,IntPtr XYZ1,double A2,IntPtr XYZ2,IntPtr XYZ3);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_SetLinearForm6062D8AE(IntPtr instance, double A1,IntPtr XYZ1,double A2,IntPtr XYZ2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_SetLinearForm628B7A49(IntPtr instance, double A1,IntPtr XYZ1,IntPtr XYZ2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_SetLinearForm610ADE9D(IntPtr instance, IntPtr XYZ1,IntPtr XYZ2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_SetX(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XYZ_X(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_SetY(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XYZ_Y(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XYZ_SetZ(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XYZ_Z(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XYZ_Modulus(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XYZ_SquareModulus(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XYZ_Normalized(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XYZ_Reversed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpXYZ(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpXYZ_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpXYZ_Dtor(IntPtr instance);
	}
}
