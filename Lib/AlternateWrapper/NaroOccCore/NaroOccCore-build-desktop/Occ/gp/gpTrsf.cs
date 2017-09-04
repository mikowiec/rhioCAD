#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gpTrsf : NativeInstancePtr
	{
		public gpTrsf()
 :
			base(gp_Trsf_Ctor() )
		{}
		public gpTrsf(gpTrsf2d T)
 :
			base(gp_Trsf_Ctor27621DCB(T.Instance) )
		{}
			public void SetMirror(gpPnt P)
				{
					gp_Trsf_SetMirror9EAECD5B(Instance, P.Instance);
				}
			public void SetMirror(gpAx1 A1)
				{
					gp_Trsf_SetMirror608B963B(Instance, A1.Instance);
				}
			public void SetMirror(gpAx2 A2)
				{
					gp_Trsf_SetMirror7895386A(Instance, A2.Instance);
				}
			public void SetRotation(gpAx1 A1,double Ang)
				{
					gp_Trsf_SetRotation827CB19A(Instance, A1.Instance, Ang);
				}
			public void SetScale(gpPnt P,double S)
				{
					gp_Trsf_SetScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public void SetDisplacement(gpAx3 FromSystem1,gpAx3 ToSystem2)
				{
					gp_Trsf_SetDisplacementB5D8FD04(Instance, FromSystem1.Instance, ToSystem2.Instance);
				}
			public void SetTransformation(gpAx3 FromSystem1,gpAx3 ToSystem2)
				{
					gp_Trsf_SetTransformationB5D8FD04(Instance, FromSystem1.Instance, ToSystem2.Instance);
				}
			public void SetTransformation(gpAx3 ToSystem)
				{
					gp_Trsf_SetTransformation1B3CAD05(Instance, ToSystem.Instance);
				}
			public void SetTranslation(gpVec V)
				{
					gp_Trsf_SetTranslation9BD9CFFE(Instance, V.Instance);
				}
			public void SetTranslation(gpPnt P1,gpPnt P2)
				{
					gp_Trsf_SetTranslation5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public void SetValues(double a11,double a12,double a13,double a14,double a21,double a22,double a23,double a24,double a31,double a32,double a33,double a34,double Tolang,double TolDist)
				{
					gp_Trsf_SetValues4D4A9FE3(Instance, a11, a12, a13, a14, a21, a22, a23, a24, a31, a32, a33, a34, Tolang, TolDist);
				}
			public bool GetRotation(gpXYZ theAxis,ref double theAngle)
				{
					return gp_Trsf_GetRotationAC21764D(Instance, theAxis.Instance, ref theAngle);
				}
			public double Value(int Row,int Col)
				{
					return gp_Trsf_Value5107F6FE(Instance, Row, Col);
				}
			public void Invert()
				{
					gp_Trsf_Invert(Instance);
				}
			public gpTrsf Multiplied(gpTrsf T)
				{
					return new gpTrsf(gp_Trsf_Multiplied72D78650(Instance, T.Instance));
				}
			public void Multiply(gpTrsf T)
				{
					gp_Trsf_Multiply72D78650(Instance, T.Instance);
				}
			public void PreMultiply(gpTrsf T)
				{
					gp_Trsf_PreMultiply72D78650(Instance, T.Instance);
				}
			public void Power(int N)
				{
					gp_Trsf_PowerE8219145(Instance, N);
				}
			public gpTrsf Powered(int N)
				{
					return new gpTrsf(gp_Trsf_PoweredE8219145(Instance, N));
				}
			public void Transforms(ref double X,ref double Y,ref double Z)
				{
					gp_Trsf_Transforms9282A951(Instance, ref X, ref Y, ref Z);
				}
			public void Transforms(gpXYZ Coord)
				{
					gp_Trsf_Transforms8EE42329(Instance, Coord.Instance);
				}
		public bool IsNegative{
			get {
				return gp_Trsf_IsNegative(Instance);
			}
		}
		public gpTrsfForm Form{
			get {
				return (gpTrsfForm)gp_Trsf_Form(Instance);
			}
		}
		public double ScaleFactor{
			set { 
				gp_Trsf_SetScaleFactor(Instance, value);
			}
			get {
				return gp_Trsf_ScaleFactor(Instance);
			}
		}
		public gpVec TranslationPart{
			set { 
				gp_Trsf_SetTranslationPart(Instance, value.Instance);
			}
			get {
				return new gpVec(gp_Trsf_TranslationPart(Instance));
			}
		}
		public gpMat VectorialPart{
			get {
				return new gpMat(gp_Trsf_VectorialPart(Instance));
			}
		}
		public gpMat HVectorialPart{
			get {
				return new gpMat(gp_Trsf_HVectorialPart(Instance));
			}
		}
		public gpTrsf Inverted{
			get {
				return new gpTrsf(gp_Trsf_Inverted(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf_Ctor27621DCB(IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetMirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetMirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetMirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetRotation827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetDisplacementB5D8FD04(IntPtr instance, IntPtr FromSystem1,IntPtr ToSystem2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetTransformationB5D8FD04(IntPtr instance, IntPtr FromSystem1,IntPtr ToSystem2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetTransformation1B3CAD05(IntPtr instance, IntPtr ToSystem);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetTranslation9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetTranslation5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetValues4D4A9FE3(IntPtr instance, double a11,double a12,double a13,double a14,double a21,double a22,double a23,double a24,double a31,double a32,double a33,double a34,double Tolang,double TolDist);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Trsf_GetRotationAC21764D(IntPtr instance, IntPtr theAxis,ref double theAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Trsf_Value5107F6FE(IntPtr instance, int Row,int Col);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_Invert(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf_Multiplied72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_Multiply72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_PreMultiply72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_PowerE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf_PoweredE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_Transforms9282A951(IntPtr instance, ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_Transforms8EE42329(IntPtr instance, IntPtr Coord);
		[DllImport("NaroOccCore.dll")]
		private static extern bool gp_Trsf_IsNegative(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int gp_Trsf_Form(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetScaleFactor(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Trsf_ScaleFactor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Trsf_SetTranslationPart(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf_TranslationPart(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf_VectorialPart(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf_HVectorialPart(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Trsf_Inverted(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public gpTrsf(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gpTrsf_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gpTrsf_Dtor(IntPtr instance);
	}
}
