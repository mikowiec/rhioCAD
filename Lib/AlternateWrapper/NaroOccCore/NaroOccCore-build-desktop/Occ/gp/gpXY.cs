#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpXY : NativeInstancePtr
	{
		public gpXY()
 :
			base(gp_XY_Ctor() )
		{}
		public gpXY(double X,double Y)
 :
			base(gp_XY_Ctor9F0E714F(X, Y) )
		{}
			public void SetCoord(int Index,double Xi)
				{
					gp_XY_SetCoord69F5FCCD(Instance, Index, Xi);
				}
			public void SetCoord(double X,double Y)
				{
					gp_XY_SetCoord9F0E714F(Instance, X, Y);
				}
			public double Coord(int Index)
				{
					return gp_XY_CoordE8219145(Instance, Index);
				}
			public void Coord(ref double X,ref double Y)
				{
					gp_XY_Coord9F0E714F(Instance, ref X, ref Y);
				}
			public bool IsEqual(gpXY Other,double Tolerance)
				{
					return gp_XY_IsEqual8CB7F1D(Instance, Other.Instance, Tolerance);
				}
			public void Add(gpXY Other)
				{
					gp_XY_AddE051EF89(Instance, Other.Instance);
				}
			public gpXY Added(gpXY Other)
				{
					return new gpXY(gp_XY_AddedE051EF89(Instance, Other.Instance));
				}
			public double Crossed(gpXY Right)
				{
					return gp_XY_CrossedE051EF89(Instance, Right.Instance);
				}
			public double CrossMagnitude(gpXY Right)
				{
					return gp_XY_CrossMagnitudeE051EF89(Instance, Right.Instance);
				}
			public double CrossSquareMagnitude(gpXY Right)
				{
					return gp_XY_CrossSquareMagnitudeE051EF89(Instance, Right.Instance);
				}
			public void Divide(double Scalar)
				{
					gp_XY_DivideD82819F3(Instance, Scalar);
				}
			public gpXY Divided(double Scalar)
				{
					return new gpXY(gp_XY_DividedD82819F3(Instance, Scalar));
				}
			public double Dot(gpXY Other)
				{
					return gp_XY_DotE051EF89(Instance, Other.Instance);
				}
			public void Multiply(double Scalar)
				{
					gp_XY_MultiplyD82819F3(Instance, Scalar);
				}
			public void Multiply(gpXY Other)
				{
					gp_XY_MultiplyE051EF89(Instance, Other.Instance);
				}
			public void Multiply(gpMat2d Matrix)
				{
					gp_XY_Multiply61A06211(Instance, Matrix.Instance);
				}
			public gpXY Multiplied(double Scalar)
				{
					return new gpXY(gp_XY_MultipliedD82819F3(Instance, Scalar));
				}
			public gpXY Multiplied(gpXY Other)
				{
					return new gpXY(gp_XY_MultipliedE051EF89(Instance, Other.Instance));
				}
			public gpXY Multiplied(gpMat2d Matrix)
				{
					return new gpXY(gp_XY_Multiplied61A06211(Instance, Matrix.Instance));
				}
			public void Normalize()
				{
					gp_XY_Normalize(Instance);
				}
			public void Reverse()
				{
					gp_XY_Reverse(Instance);
				}
			public void SetLinearForm(double A1,gpXY XY1,double A2,gpXY XY2)
				{
					gp_XY_SetLinearFormAF67E18B(Instance, A1, XY1.Instance, A2, XY2.Instance);
				}
			public void SetLinearForm(double A1,gpXY XY1,double A2,gpXY XY2,gpXY XY3)
				{
					gp_XY_SetLinearForm5D640BC7(Instance, A1, XY1.Instance, A2, XY2.Instance, XY3.Instance);
				}
			public void SetLinearForm(double A1,gpXY XY1,gpXY XY2)
				{
					gp_XY_SetLinearFormDFE76FF8(Instance, A1, XY1.Instance, XY2.Instance);
				}
			public void SetLinearForm(gpXY XY1,gpXY XY2)
				{
					gp_XY_SetLinearForm80A5E281(Instance, XY1.Instance, XY2.Instance);
				}
			public void Subtract(gpXY Right)
				{
					gp_XY_SubtractE051EF89(Instance, Right.Instance);
				}
			public gpXY Subtracted(gpXY Right)
				{
					return new gpXY(gp_XY_SubtractedE051EF89(Instance, Right.Instance));
				}
		public double X{
			set { 
				gp_XY_SetX(Instance, value);
			}
			get {
				return gp_XY_X(Instance);
			}
		}
		public double Y{
			set { 
				gp_XY_SetY(Instance, value);
			}
			get {
				return gp_XY_Y(Instance);
			}
		}
		public double Modulus{
			get {
				return gp_XY_Modulus(Instance);
			}
		}
		public double SquareModulus{
			get {
				return gp_XY_SquareModulus(Instance);
			}
		}
		public gpXY Normalized{
			get {
				return new gpXY(gp_XY_Normalized(Instance));
			}
		}
		public gpXY Reversed{
			get {
				return new gpXY(gp_XY_Reversed(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XY_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XY_Ctor9F0E714F(double X,double Y);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_SetCoord69F5FCCD(IntPtr instance, int Index,double Xi);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_SetCoord9F0E714F(IntPtr instance, double X,double Y);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XY_CoordE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_Coord9F0E714F(IntPtr instance, ref double X,ref double Y);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_XY_IsEqual8CB7F1D(IntPtr instance, IntPtr Other,double Tolerance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_AddE051EF89(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XY_AddedE051EF89(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XY_CrossedE051EF89(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XY_CrossMagnitudeE051EF89(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XY_CrossSquareMagnitudeE051EF89(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_DivideD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XY_DividedD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XY_DotE051EF89(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_MultiplyD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_MultiplyE051EF89(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_Multiply61A06211(IntPtr instance, IntPtr Matrix);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XY_MultipliedD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XY_MultipliedE051EF89(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XY_Multiplied61A06211(IntPtr instance, IntPtr Matrix);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_Normalize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_SetLinearFormAF67E18B(IntPtr instance, double A1,IntPtr XY1,double A2,IntPtr XY2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_SetLinearForm5D640BC7(IntPtr instance, double A1,IntPtr XY1,double A2,IntPtr XY2,IntPtr XY3);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_SetLinearFormDFE76FF8(IntPtr instance, double A1,IntPtr XY1,IntPtr XY2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_SetLinearForm80A5E281(IntPtr instance, IntPtr XY1,IntPtr XY2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_SubtractE051EF89(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XY_SubtractedE051EF89(IntPtr instance, IntPtr Right);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_SetX(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XY_X(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_XY_SetY(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XY_Y(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XY_Modulus(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_XY_SquareModulus(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XY_Normalized(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XY_Reversed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpXY(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpXY_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpXY_Dtor(IntPtr instance);
	}
}
