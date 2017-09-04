#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpMat : NativeInstancePtr
	{
		public gpMat()
 :
			base(gp_Mat_Ctor() )
		{}
		public gpMat(double a11,double a12,double a13,double a21,double a22,double a23,double a31,double a32,double a33)
 :
			base(gp_Mat_CtorE32698D4(a11, a12, a13, a21, a22, a23, a31, a32, a33) )
		{}
		public gpMat(gpXYZ Col1,gpXYZ Col2,gpXYZ Col3)
 :
			base(gp_Mat_Ctor7DAAC47(Col1.Instance, Col2.Instance, Col3.Instance) )
		{}
			public void SetCol(int Col,gpXYZ Value)
				{
					gp_Mat_SetCol20231E6F(Instance, Col, Value.Instance);
				}
			public void SetCols(gpXYZ Col1,gpXYZ Col2,gpXYZ Col3)
				{
					gp_Mat_SetCols7DAAC47(Instance, Col1.Instance, Col2.Instance, Col3.Instance);
				}
			public void SetDiagonal(double X1,double X2,double X3)
				{
					gp_Mat_SetDiagonal9282A951(Instance, X1, X2, X3);
				}
			public void SetIdentity()
				{
					gp_Mat_SetIdentity(Instance);
				}
			public void SetRotation(gpXYZ Axis,double Ang)
				{
					gp_Mat_SetRotationAC21764D(Instance, Axis.Instance, Ang);
				}
			public void SetRow(int Row,gpXYZ Value)
				{
					gp_Mat_SetRow20231E6F(Instance, Row, Value.Instance);
				}
			public void SetRows(gpXYZ Row1,gpXYZ Row2,gpXYZ Row3)
				{
					gp_Mat_SetRows7DAAC47(Instance, Row1.Instance, Row2.Instance, Row3.Instance);
				}
			public void SetValue(int Row,int Col,double Value)
				{
					gp_Mat_SetValue83917674(Instance, Row, Col, Value);
				}
			public gpXYZ Column(int Col)
				{
					return new gpXYZ(gp_Mat_ColumnE8219145(Instance, Col));
				}
			public gpXYZ Diagonal()
				{
					return new gpXYZ(gp_Mat_Diagonal(Instance));
				}
			public gpXYZ Row(int Row)
				{
					return new gpXYZ(gp_Mat_RowE8219145(Instance, Row));
				}
			public double Value(int Row,int Col)
				{
					return gp_Mat_Value5107F6FE(Instance, Row, Col);
				}
			public double ChangeValue(int Row,int Col)
				{
					return gp_Mat_ChangeValue5107F6FE(Instance, Row, Col);
				}
			public void Add(gpMat Other)
				{
					gp_Mat_Add9EABCD40(Instance, Other.Instance);
				}
			public gpMat Added(gpMat Other)
				{
					return new gpMat(gp_Mat_Added9EABCD40(Instance, Other.Instance));
				}
			public void Divide(double Scalar)
				{
					gp_Mat_DivideD82819F3(Instance, Scalar);
				}
			public gpMat Divided(double Scalar)
				{
					return new gpMat(gp_Mat_DividedD82819F3(Instance, Scalar));
				}
			public void Invert()
				{
					gp_Mat_Invert(Instance);
				}
			public gpMat Multiplied(gpMat Other)
				{
					return new gpMat(gp_Mat_Multiplied9EABCD40(Instance, Other.Instance));
				}
			public void Multiply(gpMat Other)
				{
					gp_Mat_Multiply9EABCD40(Instance, Other.Instance);
				}
			public void PreMultiply(gpMat Other)
				{
					gp_Mat_PreMultiply9EABCD40(Instance, Other.Instance);
				}
			public gpMat Multiplied(double Scalar)
				{
					return new gpMat(gp_Mat_MultipliedD82819F3(Instance, Scalar));
				}
			public void Multiply(double Scalar)
				{
					gp_Mat_MultiplyD82819F3(Instance, Scalar);
				}
			public void Power(int N)
				{
					gp_Mat_PowerE8219145(Instance, N);
				}
			public gpMat Powered(int N)
				{
					return new gpMat(gp_Mat_PoweredE8219145(Instance, N));
				}
			public void Subtract(gpMat Other)
				{
					gp_Mat_Subtract9EABCD40(Instance, Other.Instance);
				}
			public gpMat Subtracted(gpMat Other)
				{
					return new gpMat(gp_Mat_Subtracted9EABCD40(Instance, Other.Instance));
				}
			public void Transpose()
				{
					gp_Mat_Transpose(Instance);
				}
		public gpXYZ Cross{
			set { 
				gp_Mat_SetCross(Instance, value.Instance);
			}
		}
		public gpXYZ Dot{
			set { 
				gp_Mat_SetDot(Instance, value.Instance);
			}
		}
		public double Scale{
			set { 
				gp_Mat_SetScale(Instance, value);
			}
		}
		public double Determinant{
			get {
				return gp_Mat_Determinant(Instance);
			}
		}
		public bool IsSingular{
			get {
				return gp_Mat_IsSingular(Instance);
			}
		}
		public gpMat Inverted{
			get {
				return new gpMat(gp_Mat_Inverted(Instance));
			}
		}
		public gpMat Transposed{
			get {
				return new gpMat(gp_Mat_Transposed(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_CtorE32698D4(double a11,double a12,double a13,double a21,double a22,double a23,double a31,double a32,double a33);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_Ctor7DAAC47(IntPtr Col1,IntPtr Col2,IntPtr Col3);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_SetCol20231E6F(IntPtr instance, int Col,IntPtr Value);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_SetCols7DAAC47(IntPtr instance, IntPtr Col1,IntPtr Col2,IntPtr Col3);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_SetDiagonal9282A951(IntPtr instance, double X1,double X2,double X3);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_SetIdentity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_SetRotationAC21764D(IntPtr instance, IntPtr Axis,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_SetRow20231E6F(IntPtr instance, int Row,IntPtr Value);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_SetRows7DAAC47(IntPtr instance, IntPtr Row1,IntPtr Row2,IntPtr Row3);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_SetValue83917674(IntPtr instance, int Row,int Col,double Value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_ColumnE8219145(IntPtr instance, int Col);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_Diagonal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_RowE8219145(IntPtr instance, int Row);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Mat_Value5107F6FE(IntPtr instance, int Row,int Col);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Mat_ChangeValue5107F6FE(IntPtr instance, int Row,int Col);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_Add9EABCD40(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_Added9EABCD40(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_DivideD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_DividedD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_Invert(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_Multiplied9EABCD40(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_Multiply9EABCD40(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_PreMultiply9EABCD40(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_MultipliedD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_MultiplyD82819F3(IntPtr instance, double Scalar);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_PowerE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_PoweredE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_Subtract9EABCD40(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_Subtracted9EABCD40(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_Transpose(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_SetCross(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_SetDot(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Mat_SetScale(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Mat_Determinant(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Mat_IsSingular(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_Inverted(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Mat_Transposed(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpMat(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpMat_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpMat_Dtor(IntPtr instance);
	}
}
