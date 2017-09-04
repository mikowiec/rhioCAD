#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Geom;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomTransformation : MMgtTShared
	{
		public GeomTransformation()
 :
			base(Geom_Transformation_Ctor() )
		{}
		public GeomTransformation(gpTrsf T)
 :
			base(Geom_Transformation_Ctor72D78650(T.Instance) )
		{}
			public void SetMirror(gpPnt P)
				{
					Geom_Transformation_SetMirror9EAECD5B(Instance, P.Instance);
				}
			public void SetMirror(gpAx1 A1)
				{
					Geom_Transformation_SetMirror608B963B(Instance, A1.Instance);
				}
			public void SetMirror(gpAx2 A2)
				{
					Geom_Transformation_SetMirror7895386A(Instance, A2.Instance);
				}
			public void SetRotation(gpAx1 A1,double Ang)
				{
					Geom_Transformation_SetRotation827CB19A(Instance, A1.Instance, Ang);
				}
			public void SetScale(gpPnt P,double S)
				{
					Geom_Transformation_SetScaleF0D1E3E6(Instance, P.Instance, S);
				}
			public void SetTransformation(gpAx3 FromSystem1,gpAx3 ToSystem2)
				{
					Geom_Transformation_SetTransformationB5D8FD04(Instance, FromSystem1.Instance, ToSystem2.Instance);
				}
			public void SetTransformation(gpAx3 ToSystem)
				{
					Geom_Transformation_SetTransformation1B3CAD05(Instance, ToSystem.Instance);
				}
			public void SetTranslation(gpVec V)
				{
					Geom_Transformation_SetTranslation9BD9CFFE(Instance, V.Instance);
				}
			public void SetTranslation(gpPnt P1,gpPnt P2)
				{
					Geom_Transformation_SetTranslation5C63477E(Instance, P1.Instance, P2.Instance);
				}
			public double Value(int Row,int Col)
				{
					return Geom_Transformation_Value5107F6FE(Instance, Row, Col);
				}
			public void Invert()
				{
					Geom_Transformation_Invert(Instance);
				}
			public GeomTransformation Multiplied(GeomTransformation Other)
				{
					return new GeomTransformation(Geom_Transformation_Multiplied23447582(Instance, Other.Instance));
				}
			public void Multiply(GeomTransformation Other)
				{
					Geom_Transformation_Multiply23447582(Instance, Other.Instance);
				}
			public void Power(int N)
				{
					Geom_Transformation_PowerE8219145(Instance, N);
				}
			public GeomTransformation Powered(int N)
				{
					return new GeomTransformation(Geom_Transformation_PoweredE8219145(Instance, N));
				}
			public void PreMultiply(GeomTransformation Other)
				{
					Geom_Transformation_PreMultiply23447582(Instance, Other.Instance);
				}
			public void Transforms(ref double X,ref double Y,ref double Z)
				{
					Geom_Transformation_Transforms9282A951(Instance, ref X, ref Y, ref Z);
				}
		public bool IsNegative{
			get {
				return Geom_Transformation_IsNegative(Instance);
			}
		}
		public gpTrsfForm Form{
			get {
				return (gpTrsfForm)Geom_Transformation_Form(Instance);
			}
		}
		public double ScaleFactor{
			get {
				return Geom_Transformation_ScaleFactor(Instance);
			}
		}
		public gpTrsf Trsf{
			set { 
				Geom_Transformation_SetTrsf(Instance, value.Instance);
			}
			get {
				return new gpTrsf(Geom_Transformation_Trsf(Instance));
			}
		}
		public GeomTransformation Inverted{
			get {
				return new GeomTransformation(Geom_Transformation_Inverted(Instance));
			}
		}
		public GeomTransformation Copy{
			get {
				return new GeomTransformation(Geom_Transformation_Copy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Transformation_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Transformation_Ctor72D78650(IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_SetMirror9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_SetMirror608B963B(IntPtr instance, IntPtr A1);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_SetMirror7895386A(IntPtr instance, IntPtr A2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_SetRotation827CB19A(IntPtr instance, IntPtr A1,double Ang);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_SetScaleF0D1E3E6(IntPtr instance, IntPtr P,double S);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_SetTransformationB5D8FD04(IntPtr instance, IntPtr FromSystem1,IntPtr ToSystem2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_SetTransformation1B3CAD05(IntPtr instance, IntPtr ToSystem);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_SetTranslation9BD9CFFE(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_SetTranslation5C63477E(IntPtr instance, IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Transformation_Value5107F6FE(IntPtr instance, int Row,int Col);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_Invert(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Transformation_Multiplied23447582(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_Multiply23447582(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_PowerE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Transformation_PoweredE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_PreMultiply23447582(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_Transforms9282A951(IntPtr instance, ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Transformation_IsNegative(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Geom_Transformation_Form(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Transformation_ScaleFactor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Transformation_SetTrsf(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Transformation_Trsf(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Transformation_Inverted(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Transformation_Copy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomTransformation(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomTransformation_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomTransformation_Dtor(IntPtr instance);
	}
}
