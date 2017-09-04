#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomTrimmedCurve : GeomBoundedCurve
	{
		public GeomTrimmedCurve(GeomCurve C,double U1,double U2,bool Sense)
 :
			base(Geom_TrimmedCurve_Ctor39C18CEB(C.Instance, U1, U2, Sense) )
		{}
			public void Reverse()
				{
					Geom_TrimmedCurve_Reverse(Instance);
				}
			public double ReversedParameter(double U)
				{
					return Geom_TrimmedCurve_ReversedParameterD82819F3(Instance, U);
				}
			public void SetTrim(double U1,double U2,bool Sense)
				{
					Geom_TrimmedCurve_SetTrim947352B1(Instance, U1, U2, Sense);
				}
			public bool IsCN(int N)
				{
					return Geom_TrimmedCurve_IsCNE8219145(Instance, N);
				}
			public void D0(double U,gpPnt P)
				{
					Geom_TrimmedCurve_D053A5A2C1(Instance, U, P.Instance);
				}
			public void D1(double U,gpPnt P,gpVec V1)
				{
					Geom_TrimmedCurve_D11387A81(Instance, U, P.Instance, V1.Instance);
				}
			public void D2(double U,gpPnt P,gpVec V1,gpVec V2)
				{
					Geom_TrimmedCurve_D227877840(Instance, U, P.Instance, V1.Instance, V2.Instance);
				}
			public void D3(double U,gpPnt P,gpVec V1,gpVec V2,gpVec V3)
				{
					Geom_TrimmedCurve_D356E36E6F(Instance, U, P.Instance, V1.Instance, V2.Instance, V3.Instance);
				}
			public gpVec DN(double U,int N)
				{
					return new gpVec(Geom_TrimmedCurve_DN2935ABDE(Instance, U, N));
				}
			public void Transform(gpTrsf T)
				{
					Geom_TrimmedCurve_Transform72D78650(Instance, T.Instance);
				}
			public double TransformedParameter(double U,gpTrsf T)
				{
					return Geom_TrimmedCurve_TransformedParameter9B95D054(Instance, U, T.Instance);
				}
			public double ParametricTransformation(gpTrsf T)
				{
					return Geom_TrimmedCurve_ParametricTransformation72D78650(Instance, T.Instance);
				}
		public GeomCurve BasisCurve{
			get {
				return new GeomCurve(Geom_TrimmedCurve_BasisCurve(Instance));
			}
		}
		public GeomAbsShape Continuity{
			get {
				return (GeomAbsShape)Geom_TrimmedCurve_Continuity(Instance);
			}
		}
		public gpPnt EndPoint{
			get {
				return new gpPnt(Geom_TrimmedCurve_EndPoint(Instance));
			}
		}
		public double FirstParameter{
			get {
				return Geom_TrimmedCurve_FirstParameter(Instance);
			}
		}
		public bool IsClosed{
			get {
				return Geom_TrimmedCurve_IsClosed(Instance);
			}
		}
		public bool IsPeriodic{
			get {
				return Geom_TrimmedCurve_IsPeriodic(Instance);
			}
		}
		public double Period{
			get {
				return Geom_TrimmedCurve_Period(Instance);
			}
		}
		public double LastParameter{
			get {
				return Geom_TrimmedCurve_LastParameter(Instance);
			}
		}
		public gpPnt StartPoint{
			get {
				return new gpPnt(Geom_TrimmedCurve_StartPoint(Instance));
			}
		}
		public GeomGeometry Copy{
			get {
				return new GeomGeometry(Geom_TrimmedCurve_Copy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_TrimmedCurve_Ctor39C18CEB(IntPtr C,double U1,double U2,bool Sense);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_TrimmedCurve_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_TrimmedCurve_ReversedParameterD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_TrimmedCurve_SetTrim947352B1(IntPtr instance, double U1,double U2,bool Sense);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_TrimmedCurve_IsCNE8219145(IntPtr instance, int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_TrimmedCurve_D053A5A2C1(IntPtr instance, double U,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_TrimmedCurve_D11387A81(IntPtr instance, double U,IntPtr P,IntPtr V1);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_TrimmedCurve_D227877840(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_TrimmedCurve_D356E36E6F(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2,IntPtr V3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_TrimmedCurve_DN2935ABDE(IntPtr instance, double U,int N);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_TrimmedCurve_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_TrimmedCurve_TransformedParameter9B95D054(IntPtr instance, double U,IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_TrimmedCurve_ParametricTransformation72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_TrimmedCurve_BasisCurve(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Geom_TrimmedCurve_Continuity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_TrimmedCurve_EndPoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_TrimmedCurve_FirstParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_TrimmedCurve_IsClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_TrimmedCurve_IsPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_TrimmedCurve_Period(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_TrimmedCurve_LastParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_TrimmedCurve_StartPoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_TrimmedCurve_Copy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomTrimmedCurve() { } 

		public GeomTrimmedCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomTrimmedCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomTrimmedCurve_Dtor(IntPtr instance);
	}
}
