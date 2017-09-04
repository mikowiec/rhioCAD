#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpGTrsf2d : NativeInstancePtr
	{
		public gpGTrsf2d()
 :
			base(gp_GTrsf2d_Ctor() )
		{}
		public gpGTrsf2d(gpTrsf2d T)
 :
			base(gp_GTrsf2d_Ctor27621DCB(T.Instance) )
		{}
		public gpGTrsf2d(gpMat2d M,gpXY V)
 :
			base(gp_GTrsf2d_CtorA0E23F93(M.Instance, V.Instance) )
		{}
			public void SetAffinity(gpAx2d A,double Ratio)
				{
					gp_GTrsf2d_SetAffinityF4E58768(Instance, A.Instance, Ratio);
				}
			public void SetValue(int Row,int Col,double Value)
				{
					gp_GTrsf2d_SetValue83917674(Instance, Row, Col, Value);
				}
			public double Value(int Row,int Col)
				{
					return gp_GTrsf2d_Value5107F6FE(Instance, Row, Col);
				}
			public void Invert()
				{
					gp_GTrsf2d_Invert(Instance);
				}
			public void Multiply(gpGTrsf2d T)
				{
					gp_GTrsf2d_Multiply34614B5D(Instance, T.Instance);
				}
			public gpGTrsf2d Multiplied(gpGTrsf2d T)
				{
					return new gpGTrsf2d(gp_GTrsf2d_Multiplied34614B5D(Instance, T.Instance));
				}
			public void PreMultiply(gpGTrsf2d T)
				{
					gp_GTrsf2d_PreMultiply34614B5D(Instance, T.Instance);
				}
			public void Power(int N)
				{
					gp_GTrsf2d_PowerE8219145(Instance, N);
				}
			public gpGTrsf2d Powered(int N)
				{
					return new gpGTrsf2d(gp_GTrsf2d_PoweredE8219145(Instance, N));
				}
			public void Transforms(gpXY Coord)
				{
					gp_GTrsf2d_TransformsE051EF89(Instance, Coord.Instance);
				}
			public gpXY Transformed(gpXY Coord)
				{
					return new gpXY(gp_GTrsf2d_TransformedE051EF89(Instance, Coord.Instance));
				}
			public void Transforms(ref double X,ref double Y)
				{
					gp_GTrsf2d_Transforms9F0E714F(Instance, ref X, ref Y);
				}
		public bool IsNegative{
			get {
				return gp_GTrsf2d_IsNegative(Instance);
			}
		}
		public bool IsSingular{
			get {
				return gp_GTrsf2d_IsSingular(Instance);
			}
		}
		public gpTrsfForm Form{
			get {
				return (gpTrsfForm)gp_GTrsf2d_Form(Instance);
			}
		}
		public gpXY TranslationPart{
			set { 
				gp_GTrsf2d_SetTranslationPart(Instance, value.Instance);
			}
			get {
				return new gpXY(gp_GTrsf2d_TranslationPart(Instance));
			}
		}
		public gpMat2d VectorialPart{
			set { 
				gp_GTrsf2d_SetVectorialPart(Instance, value.Instance);
			}
			get {
				return new gpMat2d(gp_GTrsf2d_VectorialPart(Instance));
			}
		}
		public gpGTrsf2d Inverted{
			get {
				return new gpGTrsf2d(gp_GTrsf2d_Inverted(Instance));
			}
		}
		public gpTrsf2d Trsf2d{
			set { 
				gp_GTrsf2d_SetTrsf2d(Instance, value.Instance);
			}
			get {
				return new gpTrsf2d(gp_GTrsf2d_Trsf2d(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf2d_Ctor27621DCB(IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf2d_CtorA0E23F93(IntPtr M,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf2d_SetAffinityF4E58768(IntPtr instance, IntPtr A,double Ratio);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf2d_SetValue83917674(IntPtr instance, int Row,int Col,double Value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_GTrsf2d_Value5107F6FE(IntPtr instance, int Row,int Col);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf2d_Invert(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf2d_Multiply34614B5D(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf2d_Multiplied34614B5D(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf2d_PreMultiply34614B5D(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf2d_PowerE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf2d_PoweredE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf2d_TransformsE051EF89(IntPtr instance, IntPtr Coord);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf2d_TransformedE051EF89(IntPtr instance, IntPtr Coord);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf2d_Transforms9F0E714F(IntPtr instance, ref double X,ref double Y);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_GTrsf2d_IsNegative(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_GTrsf2d_IsSingular(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int gp_GTrsf2d_Form(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf2d_SetTranslationPart(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf2d_TranslationPart(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf2d_SetVectorialPart(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf2d_VectorialPart(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf2d_Inverted(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_GTrsf2d_SetTrsf2d(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_GTrsf2d_Trsf2d(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpGTrsf2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpGTrsf2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpGTrsf2d_Dtor(IntPtr instance);
	}
}
