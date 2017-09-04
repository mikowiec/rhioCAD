#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Adaptor2d;

#endregion

namespace NaroCppCore.Occ.Adaptor2d
{
	public class Adaptor2dHCurve2d : MMgtTShared
	{
			public int NbIntervals(GeomAbsShape S)
				{
					return Adaptor2d_HCurve2d_NbIntervals5ABD177E(Instance, (int)S);
				}
			public Adaptor2dHCurve2d Trim(double First,double Last,double Tol)
				{
					return new Adaptor2dHCurve2d(Adaptor2d_HCurve2d_Trim9282A951(Instance, First, Last, Tol));
				}
			public gpPnt2d Value(double U)
				{
					return new gpPnt2d(Adaptor2d_HCurve2d_ValueD82819F3(Instance, U));
				}
			public void D0(double U,gpPnt2d P)
				{
					Adaptor2d_HCurve2d_D0F34E6A40(Instance, U, P.Instance);
				}
			public void D1(double U,gpPnt2d P,gpVec2d V)
				{
					Adaptor2d_HCurve2d_D1EF1CEF4A(Instance, U, P.Instance, V.Instance);
				}
			public void D2(double U,gpPnt2d P,gpVec2d V1,gpVec2d V2)
				{
					Adaptor2d_HCurve2d_D2DCE527F4(Instance, U, P.Instance, V1.Instance, V2.Instance);
				}
			public void D3(double U,gpPnt2d P,gpVec2d V1,gpVec2d V2,gpVec2d V3)
				{
					Adaptor2d_HCurve2d_D3A3CC6934(Instance, U, P.Instance, V1.Instance, V2.Instance, V3.Instance);
				}
			public gpVec2d DN(double U,int N)
				{
					return new gpVec2d(Adaptor2d_HCurve2d_DN2935ABDE(Instance, U, N));
				}
			public double Resolution(double R3d)
				{
					return Adaptor2d_HCurve2d_ResolutionD82819F3(Instance, R3d);
				}
		public double FirstParameter{
			get {
				return Adaptor2d_HCurve2d_FirstParameter(Instance);
			}
		}
		public double LastParameter{
			get {
				return Adaptor2d_HCurve2d_LastParameter(Instance);
			}
		}
		public GeomAbsShape Continuity{
			get {
				return (GeomAbsShape)Adaptor2d_HCurve2d_Continuity(Instance);
			}
		}
		public bool IsClosed{
			get {
				return Adaptor2d_HCurve2d_IsClosed(Instance);
			}
		}
		public bool IsPeriodic{
			get {
				return Adaptor2d_HCurve2d_IsPeriodic(Instance);
			}
		}
		public double Period{
			get {
				return Adaptor2d_HCurve2d_Period(Instance);
			}
		}
		public GeomAbsCurveType GetType{
			get {
				return (GeomAbsCurveType)Adaptor2d_HCurve2d_GetType(Instance);
			}
		}
		public gpLin2d Line{
			get {
				return new gpLin2d(Adaptor2d_HCurve2d_Line(Instance));
			}
		}
		public gpCirc2d Circle{
			get {
				return new gpCirc2d(Adaptor2d_HCurve2d_Circle(Instance));
			}
		}
		public gpElips2d Ellipse{
			get {
				return new gpElips2d(Adaptor2d_HCurve2d_Ellipse(Instance));
			}
		}
		public gpHypr2d Hyperbola{
			get {
				return new gpHypr2d(Adaptor2d_HCurve2d_Hyperbola(Instance));
			}
		}
		public gpParab2d Parabola{
			get {
				return new gpParab2d(Adaptor2d_HCurve2d_Parabola(Instance));
			}
		}
		public int Degree{
			get {
				return Adaptor2d_HCurve2d_Degree(Instance);
			}
		}
		public bool IsRational{
			get {
				return Adaptor2d_HCurve2d_IsRational(Instance);
			}
		}
		public int NbPoles{
			get {
				return Adaptor2d_HCurve2d_NbPoles(Instance);
			}
		}
		public int NbKnots{
			get {
				return Adaptor2d_HCurve2d_NbKnots(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor2d_HCurve2d_NbIntervals5ABD177E(IntPtr instance, int S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor2d_HCurve2d_Trim9282A951(IntPtr instance, double First,double Last,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor2d_HCurve2d_ValueD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor2d_HCurve2d_D0F34E6A40(IntPtr instance, double U,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor2d_HCurve2d_D1EF1CEF4A(IntPtr instance, double U,IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor2d_HCurve2d_D2DCE527F4(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor2d_HCurve2d_D3A3CC6934(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2,IntPtr V3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor2d_HCurve2d_DN2935ABDE(IntPtr instance, double U,int N);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor2d_HCurve2d_ResolutionD82819F3(IntPtr instance, double R3d);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor2d_HCurve2d_FirstParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor2d_HCurve2d_LastParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor2d_HCurve2d_Continuity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor2d_HCurve2d_IsClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor2d_HCurve2d_IsPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor2d_HCurve2d_Period(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor2d_HCurve2d_GetType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor2d_HCurve2d_Line(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor2d_HCurve2d_Circle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor2d_HCurve2d_Ellipse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor2d_HCurve2d_Hyperbola(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor2d_HCurve2d_Parabola(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor2d_HCurve2d_Degree(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor2d_HCurve2d_IsRational(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor2d_HCurve2d_NbPoles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor2d_HCurve2d_NbKnots(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Adaptor2dHCurve2d() { } 

		public Adaptor2dHCurve2d(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Adaptor2dHCurve2d_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor2dHCurve2d_Dtor(IntPtr instance);
	}
}
