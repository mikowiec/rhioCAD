#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.Adaptor3d;

#endregion

namespace NaroCppCore.Occ.Adaptor3d
{
	public class Adaptor3dCurve : NativeInstancePtr
	{
			public void Delete()
				{
					Adaptor3d_Curve_Delete(Instance);
				}
			public int NbIntervals(GeomAbsShape S)
				{
					return Adaptor3d_Curve_NbIntervals5ABD177E(Instance, (int)S);
				}
			public Adaptor3dHCurve Trim(double First,double Last,double Tol)
				{
					return new Adaptor3dHCurve(Adaptor3d_Curve_Trim9282A951(Instance, First, Last, Tol));
				}
			public gpPnt Value(double U)
				{
					return new gpPnt(Adaptor3d_Curve_ValueD82819F3(Instance, U));
				}
			public void D0(double U,gpPnt P)
				{
					Adaptor3d_Curve_D053A5A2C1(Instance, U, P.Instance);
				}
			public void D1(double U,gpPnt P,gpVec V)
				{
					Adaptor3d_Curve_D11387A81(Instance, U, P.Instance, V.Instance);
				}
			public void D2(double U,gpPnt P,gpVec V1,gpVec V2)
				{
					Adaptor3d_Curve_D227877840(Instance, U, P.Instance, V1.Instance, V2.Instance);
				}
			public void D3(double U,gpPnt P,gpVec V1,gpVec V2,gpVec V3)
				{
					Adaptor3d_Curve_D356E36E6F(Instance, U, P.Instance, V1.Instance, V2.Instance, V3.Instance);
				}
			public gpVec DN(double U,int N)
				{
					return new gpVec(Adaptor3d_Curve_DN2935ABDE(Instance, U, N));
				}
			public double Resolution(double R3d)
				{
					return Adaptor3d_Curve_ResolutionD82819F3(Instance, R3d);
				}
		public double FirstParameter{
			get {
				return Adaptor3d_Curve_FirstParameter(Instance);
			}
		}
		public double LastParameter{
			get {
				return Adaptor3d_Curve_LastParameter(Instance);
			}
		}
		public GeomAbsShape Continuity{
			get {
				return (GeomAbsShape)Adaptor3d_Curve_Continuity(Instance);
			}
		}
		public bool IsClosed{
			get {
				return Adaptor3d_Curve_IsClosed(Instance);
			}
		}
		public bool IsPeriodic{
			get {
				return Adaptor3d_Curve_IsPeriodic(Instance);
			}
		}
		public double Period{
			get {
				return Adaptor3d_Curve_Period(Instance);
			}
		}
		public GeomAbsCurveType GetType{
			get {
				return (GeomAbsCurveType)Adaptor3d_Curve_GetType(Instance);
			}
		}
		public gpLin Line{
			get {
				return new gpLin(Adaptor3d_Curve_Line(Instance));
			}
		}
		public gpCirc Circle{
			get {
				return new gpCirc(Adaptor3d_Curve_Circle(Instance));
			}
		}
		public gpElips Ellipse{
			get {
				return new gpElips(Adaptor3d_Curve_Ellipse(Instance));
			}
		}
		public gpHypr Hyperbola{
			get {
				return new gpHypr(Adaptor3d_Curve_Hyperbola(Instance));
			}
		}
		public gpParab Parabola{
			get {
				return new gpParab(Adaptor3d_Curve_Parabola(Instance));
			}
		}
		public int Degree{
			get {
				return Adaptor3d_Curve_Degree(Instance);
			}
		}
		public bool IsRational{
			get {
				return Adaptor3d_Curve_IsRational(Instance);
			}
		}
		public int NbPoles{
			get {
				return Adaptor3d_Curve_NbPoles(Instance);
			}
		}
		public int NbKnots{
			get {
				return Adaptor3d_Curve_NbKnots(Instance);
			}
		}
		public GeomBezierCurve Bezier{
			get {
				return new GeomBezierCurve(Adaptor3d_Curve_Bezier(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_Curve_Delete(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Curve_NbIntervals5ABD177E(IntPtr instance, int S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Curve_Trim9282A951(IntPtr instance, double First,double Last,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Curve_ValueD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_Curve_D053A5A2C1(IntPtr instance, double U,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_Curve_D11387A81(IntPtr instance, double U,IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_Curve_D227877840(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_Curve_D356E36E6F(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2,IntPtr V3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Curve_DN2935ABDE(IntPtr instance, double U,int N);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Curve_ResolutionD82819F3(IntPtr instance, double R3d);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Curve_FirstParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Curve_LastParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Curve_Continuity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor3d_Curve_IsClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor3d_Curve_IsPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Curve_Period(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Curve_GetType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Curve_Line(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Curve_Circle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Curve_Ellipse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Curve_Hyperbola(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Curve_Parabola(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Curve_Degree(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor3d_Curve_IsRational(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Curve_NbPoles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Curve_NbKnots(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Curve_Bezier(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Adaptor3dCurve() { } 

		public Adaptor3dCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Adaptor3dCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3dCurve_Dtor(IntPtr instance);
	}
}
