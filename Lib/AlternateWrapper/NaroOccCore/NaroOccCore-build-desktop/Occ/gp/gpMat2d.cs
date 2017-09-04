#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpMat2d : NativeInstancePtr
	{
		public gpMat2d()
 :
			base(gp_Mat2d_Ctor() )
		{}
		public gpMat2d(gpXY Col1,gpXY Col2)
 :
			base(gp_Mat2d_Ctor80A5E281(Col1.Instance, Col2.Instance) )
		{}
			public void SetCol(int Col,gpXY Value)
				{
					gp_Mat2d_SetCol1FC91E6F(Instance, Col, Value.Instance);
				}
			public void SetCols(gpXY Col1,gpXY Col2)
				{
					gp_Mat2d_SetCols80A5E281(Instance, Col1.Instance, Col2.Instance);
				}
			public void SetDiagonal(double X1,double X2)
				{
					gp_Mat2d_SetDiagonal9F0E714F(Instance, X1, X2);
				}
			public void SetIdentity()
				{
					gp_Mat2d_SetIdentity(Instance);
				}
			public void SetRow(int Row,gpXY Value)
				{
					gp_Mat2d_SetRow1FC91E6F(Instance, Row, Value.Instance);
				}
			public void SetRows(gpXY Row1,gpXY Row2)
				{
					gp_Mat2d_SetRows80A5E281(Instance, Row1.Instance, Row2.Instance);
				}
			public void SetValue(int Row,int Col,double Value)
				{
					gp_Mat2d_SetValue83917674(Instance, Row, Col, Value);
				}
			public gpXY Column(int Col)
				{
					return new gpXY(gp_Mat2d_ColumnE8219145(Instance, Col));
				}
			public gpXY Diagonal()
				{
					return new gpXY(gp_Mat2d_Diagonal(Instance));
				}
			public gpXY Row(int Row)
				{
					return new gpXY(gp_Mat2d_RowE8219145(Instance, Row));
				}
			public double Value(int Row,int Col)
				{
					return gp_Mat2d_Value5107F6FE(Instance, Row, Col);
				}
			public double ChangeValue(int Row,int Col)
				{
					return gp_Mat2d_ChangeValue5107F6FE(Instance, Row, Col);
				}
			public void Add(gpMat2d Other)
				{
					gp_Mat2d_Add61A06211(Instance, Other.Instance);
				}
			public gpMat2d Added(gpMat2d Other)
				{
					return new gpMat2d(gp_Mat2d_Added61A06211(Instance, Other.Instance));
				}
			public void Divide(double Scalar)
				{
					gp_Mat2d_DivideD82819F3(Instance, Scalar);
				}
			public gpMat2d Divided(double Scalar)
				{
					return new gpMat2d(gp_Mat2d_DividedD82819F3(Instance, Scalar));
				}
			public void Invert()
				{
					gp_Mat2d_Invert(Instance);
				}
			public gpMat2d Multiplied(gpMat2d Other)
				{
					return new gpMat2d(gp_Mat2d_Multiplied61A06211(Instance, Other.Instance));
				}
			public void Multiply(gpMat2d Other)
				{
					gp_Mat2d_Multiply61A06211(Instance, Other.Instance);
				}
			public void PreMultiply(gpMat2d Other)
				{
					gp_Mat2d_PreMultiply61A06211(Instance, Other.Instance);
				}
			public gpMat2d Multiplied(double Scalar)
				{
					return new gpMat2d(gp_Mat2d_MultipliedD82819F3(Instance, Scalar));
				}
			public void Multiply(double Scalar)
				{
					gp_Mat2d_MultiplyD82819F3(Instance, Scalar);
				}
			public void Power(int N)
				{
					gp_Mat2d_PowerE8219145(Instance, N);
				}
			public gpMat2d Powered(int N)
				{
					return new gpMat2d(gp_Mat2d_PoweredE8219145(Instance, N));
				}
			public void Subtract(gpMat2d Other)
				{
					gp_Mat2d_Subtract61A06211(Instance, Other.Instance);
				}
			public gpMat2d Subtracted(gpMat2d Other)
				{
					return new gpMat2d(gp_Mat2d_Subtracted61A06211(Instance, Other.Instance));
				}
			public void Transpose()
				{
					gp_Mat2d_Transpose(Instance);
				}
		public double Rotation{
			set { 
				gp_Mat2d_SetRotation(Instance, value);
			}
		}
		public double Scale{
			set { 
				gp_Mat2d_SetScale(Instance, value);
			}
		}
		public double Determinant{
			get {
				return gp_Mat2d_Determinant(Instance);
			}
		}
		public bool IsSingular{
			get {
				return gp_Mat2d_IsSingular(Instance);
			}
		}
		public gpMat2d Inverted{
			get {
				return new gpMat2d(gp_Mat2d_Inverted(Instance));
			}
		}
		public gpMat2d Transposed{
			get {
				return new gpMat2d(gp_Mat2d_Transposed(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_Ctor80A5E281(IntPtr Col1,IntPtr Col2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_SetCol1FC91E6F(IntPtr instance, int Col,IntPtr Value);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_SetCols80A5E281(IntPtr instance, IntPtr Col1,IntPtr Col2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_SetDiagonal9F0E714F(IntPtr instance, double X1,double X2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_SetIdentity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_SetRow1FC91E6F(IntPtr instance, int Row,IntPtr Value);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_SetRows80A5E281(IntPtr instance, IntPtr Row1,IntPtr Row2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_SetValue83917674(IntPtr instance, int Row,int Col,double Value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_ColumnE8219145(IntPtr instance, int Col);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_Diagonal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_RowE8219145(IntPtr instance, int Row);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Mat2d_Value5107F6FE(IntPtr instance, int Row,int Col);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Mat2d_ChangeValue5107F6FE(IntPtr instance, int Row,int Col);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_Add61A06211(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_Added61A06211(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_DivideD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_DividedD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_Invert(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_Multiplied61A06211(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_Multiply61A06211(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_PreMultiply61A06211(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_MultipliedD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_MultiplyD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_PowerE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_PoweredE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_Subtract61A06211(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_Subtracted61A06211(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_Transpose(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_SetRotation(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat2d_SetScale(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Mat2d_Determinant(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Mat2d_IsSingular(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_Inverted(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat2d_Transposed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpMat2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpMat2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpMat2d_Dtor(IntPtr instance);
	}
}
