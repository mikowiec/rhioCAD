#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpGTrsf : NativeInstancePtr
	{
		public gpGTrsf()
 :
			base(gp_GTrsf_Ctor() )
		{}
		public gpGTrsf(gpTrsf T)
 :
			base(gp_GTrsf_Ctor72D78650(T.Instance) )
		{}
		public gpGTrsf(gpMat M,gpXYZ V)
 :
			base(gp_GTrsf_CtorD1BD2BB9(M.Instance, V.Instance) )
		{}
			public void SetAffinity(gpAx1 A1,double Ratio)
				{
					gp_GTrsf_SetAffinity827CB19A(Instance, A1.Instance, Ratio);
				}
			public void SetAffinity(gpAx2 A2,double Ratio)
				{
					gp_GTrsf_SetAffinity673FA07D(Instance, A2.Instance, Ratio);
				}
			public void SetValue(int Row,int Col,double Value)
				{
					gp_GTrsf_SetValue83917674(Instance, Row, Col, Value);
				}
			public gpTrsfForm Form()
				{
					return (gpTrsfForm)gp_GTrsf_Form(Instance);
				}
			public void SetForm()
				{
					gp_GTrsf_SetForm(Instance);
				}
			public double Value(int Row,int Col)
				{
					return gp_GTrsf_Value5107F6FE(Instance, Row, Col);
				}
			public void Invert()
				{
					gp_GTrsf_Invert(Instance);
				}
			public void Multiply(gpGTrsf T)
				{
					gp_GTrsf_MultiplyD8FBA6AB(Instance, T.Instance);
				}
			public gpGTrsf Multiplied(gpGTrsf T)
				{
					return new gpGTrsf(gp_GTrsf_MultipliedD8FBA6AB(Instance, T.Instance));
				}
			public void PreMultiply(gpGTrsf T)
				{
					gp_GTrsf_PreMultiplyD8FBA6AB(Instance, T.Instance);
				}
			public void Power(int N)
				{
					gp_GTrsf_PowerE8219145(Instance, N);
				}
			public gpGTrsf Powered(int N)
				{
					return new gpGTrsf(gp_GTrsf_PoweredE8219145(Instance, N));
				}
			public void Transforms(gpXYZ Coord)
				{
					gp_GTrsf_Transforms8EE42329(Instance, Coord.Instance);
				}
			public void Transforms(ref double X,ref double Y,ref double Z)
				{
					gp_GTrsf_Transforms9282A951(Instance, ref X, ref Y, ref Z);
				}
		public bool IsNegative{
			get {
				return gp_GTrsf_IsNegative(Instance);
			}
		}
		public bool IsSingular{
			get {
				return gp_GTrsf_IsSingular(Instance);
			}
		}
		public gpXYZ TranslationPart{
			set { 
				gp_GTrsf_SetTranslationPart(Instance, value.Instance);
			}
			get {
				return new gpXYZ(gp_GTrsf_TranslationPart(Instance));
			}
		}
		public gpMat VectorialPart{
			set { 
				gp_GTrsf_SetVectorialPart(Instance, value.Instance);
			}
			get {
				return new gpMat(gp_GTrsf_VectorialPart(Instance));
			}
		}
		public gpGTrsf Inverted{
			get {
				return new gpGTrsf(gp_GTrsf_Inverted(Instance));
			}
		}
		public gpTrsf Trsf{
			set { 
				gp_GTrsf_SetTrsf(Instance, value.Instance);
			}
			get {
				return new gpTrsf(gp_GTrsf_Trsf(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf_Ctor72D78650(IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf_CtorD1BD2BB9(IntPtr M,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_SetAffinity827CB19A(IntPtr instance, IntPtr A1,double Ratio);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_SetAffinity673FA07D(IntPtr instance, IntPtr A2,double Ratio);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_SetValue83917674(IntPtr instance, int Row,int Col,double Value);
		[DllImport("NaroOccCore.dll")]
		private static extern int gp_GTrsf_Form(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_SetForm(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_GTrsf_Value5107F6FE(IntPtr instance, int Row,int Col);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_Invert(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_MultiplyD8FBA6AB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf_MultipliedD8FBA6AB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_PreMultiplyD8FBA6AB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_PowerE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf_PoweredE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_Transforms8EE42329(IntPtr instance, IntPtr Coord);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_Transforms9282A951(IntPtr instance, ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_GTrsf_IsNegative(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_GTrsf_IsSingular(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_SetTranslationPart(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf_TranslationPart(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_SetVectorialPart(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf_VectorialPart(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf_Inverted(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf_SetTrsf(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf_Trsf(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpGTrsf(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpGTrsf_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpGTrsf_Dtor(IntPtr instance);
	}
}
