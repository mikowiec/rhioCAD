#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.Adaptor3d;

#endregion

namespace NaroCppCore.Occ.Adaptor3d
{
	public class Adaptor3dHCurve : MMgtTShared
	{
			public int NbIntervals(GeomAbsShape S)
				{
					return Adaptor3d_HCurve_NbIntervals5ABD177E(Instance, (int)S);
				}
			public Adaptor3dHCurve Trim(double First,double Last,double Tol)
				{
					return new Adaptor3dHCurve(Adaptor3d_HCurve_Trim9282A951(Instance, First, Last, Tol));
				}
			public gpPnt Value(double U)
				{
					return new gpPnt(Adaptor3d_HCurve_ValueD82819F3(Instance, U));
				}
			public void D0(double U,gpPnt P)
				{
					Adaptor3d_HCurve_D053A5A2C1(Instance, U, P.Instance);
				}
			public void D1(double U,gpPnt P,gpVec V)
				{
					Adaptor3d_HCurve_D11387A81(Instance, U, P.Instance, V.Instance);
				}
			public void D2(double U,gpPnt P,gpVec V1,gpVec V2)
				{
					Adaptor3d_HCurve_D227877840(Instance, U, P.Instance, V1.Instance, V2.Instance);
				}
			public void D3(double U,gpPnt P,gpVec V1,gpVec V2,gpVec V3)
				{
					Adaptor3d_HCurve_D356E36E6F(Instance, U, P.Instance, V1.Instance, V2.Instance, V3.Instance);
				}
			public gpVec DN(double U,int N)
				{
					return new gpVec(Adaptor3d_HCurve_DN2935ABDE(Instance, U, N));
				}
			public double Resolution(double R3d)
				{
					return Adaptor3d_HCurve_ResolutionD82819F3(Instance, R3d);
				}
		public double FirstParameter{
			get {
				return Adaptor3d_HCurve_FirstParameter(Instance);
			}
		}
		public double LastParameter{
			get {
				return Adaptor3d_HCurve_LastParameter(Instance);
			}
		}
		public GeomAbsShape Continuity{
			get {
				return (GeomAbsShape)Adaptor3d_HCurve_Continuity(Instance);
			}
		}
		public bool IsClosed{
			get {
				return Adaptor3d_HCurve_IsClosed(Instance);
			}
		}
		public bool IsPeriodic{
			get {
				return Adaptor3d_HCurve_IsPeriodic(Instance);
			}
		}
		public double Period{
			get {
				return Adaptor3d_HCurve_Period(Instance);
			}
		}
		public GeomAbsCurveType GetType{
			get {
				return (GeomAbsCurveType)Adaptor3d_HCurve_GetType(Instance);
			}
		}
		public gpLin Line{
			get {
				return new gpLin(Adaptor3d_HCurve_Line(Instance));
			}
		}
		public gpCirc Circle{
			get {
				return new gpCirc(Adaptor3d_HCurve_Circle(Instance));
			}
		}
		public gpElips Ellipse{
			get {
				return new gpElips(Adaptor3d_HCurve_Ellipse(Instance));
			}
		}
		public gpHypr Hyperbola{
			get {
				return new gpHypr(Adaptor3d_HCurve_Hyperbola(Instance));
			}
		}
		public gpParab Parabola{
			get {
				return new gpParab(Adaptor3d_HCurve_Parabola(Instance));
			}
		}
		public int Degree{
			get {
				return Adaptor3d_HCurve_Degree(Instance);
			}
		}
		public bool IsRational{
			get {
				return Adaptor3d_HCurve_IsRational(Instance);
			}
		}
		public int NbPoles{
			get {
				return Adaptor3d_HCurve_NbPoles(Instance);
			}
		}
		public int NbKnots{
			get {
				return Adaptor3d_HCurve_NbKnots(Instance);
			}
		}
		public GeomBezierCurve Bezier{
			get {
				return new GeomBezierCurve(Adaptor3d_HCurve_Bezier(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_HCurve_NbIntervals5ABD177E(IntPtr instance, int S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_HCurve_Trim9282A951(IntPtr instance, double First,double Last,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_HCurve_ValueD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_HCurve_D053A5A2C1(IntPtr instance, double U,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_HCurve_D11387A81(IntPtr instance, double U,IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_HCurve_D227877840(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_HCurve_D356E36E6F(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2,IntPtr V3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_HCurve_DN2935ABDE(IntPtr instance, double U,int N);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_HCurve_ResolutionD82819F3(IntPtr instance, double R3d);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_HCurve_FirstParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_HCurve_LastParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_HCurve_Continuity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor3d_HCurve_IsClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor3d_HCurve_IsPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_HCurve_Period(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_HCurve_GetType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_HCurve_Line(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_HCurve_Circle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_HCurve_Ellipse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_HCurve_Hyperbola(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_HCurve_Parabola(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_HCurve_Degree(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor3d_HCurve_IsRational(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_HCurve_NbPoles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_HCurve_NbKnots(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_HCurve_Bezier(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Adaptor3dHCurve() { } 

		public Adaptor3dHCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Adaptor3dHCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3dHCurve_Dtor(IntPtr instance);
	}
}
