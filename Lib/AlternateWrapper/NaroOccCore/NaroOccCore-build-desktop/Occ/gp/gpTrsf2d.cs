#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpTrsf2d : NativeInstancePtr
	{
		public gpTrsf2d()
 :
			base(gp_Trsf2d_Ctor() )
		{}
		public gpTrsf2d(gpTrsf T)
 :
			base(gp_Trsf2d_Ctor72D78650(T.Instance) )
		{}
			public void SetMirror(gpPnt2d P)
				{
					gp_Trsf2d_SetMirror6203658C(Instance, P.Instance);
				}
			public void SetMirror(gpAx2d A)
				{
					gp_Trsf2d_SetMirror90E1386A(Instance, A.Instance);
				}
			public void SetRotation(gpPnt2d P,double Ang)
				{
					gp_Trsf2d_SetRotationE3062737(Instance, P.Instance, Ang);
				}
			public void SetScale(gpPnt2d P,double S)
				{
					gp_Trsf2d_SetScaleE3062737(Instance, P.Instance, S);
				}
			public void SetTransformation(gpAx2d FromSystem1,gpAx2d ToSystem2)
				{
					gp_Trsf2d_SetTransformation1A99B821(Instance, FromSystem1.Instance, ToSystem2.Instance);
				}
			public void SetTransformation(gpAx2d ToSystem)
				{
					gp_Trsf2d_SetTransformation90E1386A(Instance, ToSystem.Instance);
				}
			public void SetTranslation(gpVec2d V)
				{
					gp_Trsf2d_SetTranslation5E4E66E7(Instance, V.Instance);
				}
			public void SetTranslation(gpPnt2d P1,gpPnt2d P2)
				{
					gp_Trsf2d_SetTranslation5F54ADE3(Instance, P1.Instance, P2.Instance);
				}
			public double Value(int Row,int Col)
				{
					return gp_Trsf2d_Value5107F6FE(Instance, Row, Col);
				}
			public void Invert()
				{
					gp_Trsf2d_Invert(Instance);
				}
			public gpTrsf2d Multiplied(gpTrsf2d T)
				{
					return new gpTrsf2d(gp_Trsf2d_Multiplied27621DCB(Instance, T.Instance));
				}
			public void Multiply(gpTrsf2d T)
				{
					gp_Trsf2d_Multiply27621DCB(Instance, T.Instance);
				}
			public void PreMultiply(gpTrsf2d T)
				{
					gp_Trsf2d_PreMultiply27621DCB(Instance, T.Instance);
				}
			public void Power(int N)
				{
					gp_Trsf2d_PowerE8219145(Instance, N);
				}
			public gpTrsf2d Powered(int N)
				{
					return new gpTrsf2d(gp_Trsf2d_PoweredE8219145(Instance, N));
				}
			public void Transforms(ref double X,ref double Y)
				{
					gp_Trsf2d_Transforms9F0E714F(Instance, ref X, ref Y);
				}
			public void Transforms(gpXY Coord)
				{
					gp_Trsf2d_TransformsE051EF89(Instance, Coord.Instance);
				}
		public bool IsNegative{
			get {
				return gp_Trsf2d_IsNegative(Instance);
			}
		}
		public gpTrsfForm Form{
			get {
				return (gpTrsfForm)gp_Trsf2d_Form(Instance);
			}
		}
		public double ScaleFactor{
			set { 
				gp_Trsf2d_SetScaleFactor(Instance, value);
			}
			get {
				return gp_Trsf2d_ScaleFactor(Instance);
			}
		}
		public gpVec2d TranslationPart{
			set { 
				gp_Trsf2d_SetTranslationPart(Instance, value.Instance);
			}
			get {
				return new gpVec2d(gp_Trsf2d_TranslationPart(Instance));
			}
		}
		public gpMat2d VectorialPart{
			get {
				return new gpMat2d(gp_Trsf2d_VectorialPart(Instance));
			}
		}
		public gpMat2d HVectorialPart{
			get {
				return new gpMat2d(gp_Trsf2d_HVectorialPart(Instance));
			}
		}
		public double RotationPart{
			get {
				return gp_Trsf2d_RotationPart(Instance);
			}
		}
		public gpTrsf2d Inverted{
			get {
				return new gpTrsf2d(gp_Trsf2d_Inverted(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf2d_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf2d_Ctor72D78650(IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_SetMirror6203658C(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_SetMirror90E1386A(IntPtr instance, IntPtr A);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_SetRotationE3062737(IntPtr instance, IntPtr P,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_SetScaleE3062737(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_SetTransformation1A99B821(IntPtr instance, IntPtr FromSystem1,IntPtr ToSystem2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_SetTransformation90E1386A(IntPtr instance, IntPtr ToSystem);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_SetTranslation5E4E66E7(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_SetTranslation5F54ADE3(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Trsf2d_Value5107F6FE(IntPtr instance, int Row,int Col);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_Invert(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf2d_Multiplied27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_Multiply27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_PreMultiply27621DCB(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_PowerE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf2d_PoweredE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_Transforms9F0E714F(IntPtr instance, ref double X,ref double Y);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_TransformsE051EF89(IntPtr instance, IntPtr Coord);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Trsf2d_IsNegative(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int gp_Trsf2d_Form(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_SetScaleFactor(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Trsf2d_ScaleFactor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf2d_SetTranslationPart(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf2d_TranslationPart(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf2d_VectorialPart(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf2d_HVectorialPart(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Trsf2d_RotationPart(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf2d_Inverted(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpTrsf2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpTrsf2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpTrsf2d_Dtor(IntPtr instance);
	}
}
