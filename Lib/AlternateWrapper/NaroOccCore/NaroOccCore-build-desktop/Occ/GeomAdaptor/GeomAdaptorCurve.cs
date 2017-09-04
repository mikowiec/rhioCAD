#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Adaptor3d;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.GeomAdaptor
{
	public class GeomAdaptorCurve : Adaptor3dCurve
	{
		public GeomAdaptorCurve()
 :
			base(GeomAdaptor_Curve_Ctor() )
		{}
		public GeomAdaptorCurve(GeomCurve C)
 :
			base(GeomAdaptor_Curve_CtorFF608AE4(C.Instance) )
		{}
		public GeomAdaptorCurve(GeomCurve C,double UFirst,double ULast)
 :
			base(GeomAdaptor_Curve_CtorED53F64D(C.Instance, UFirst, ULast) )
		{}
			public void Load(GeomCurve C)
				{
					GeomAdaptor_Curve_LoadFF608AE4(Instance, C.Instance);
				}
			public void Load(GeomCurve C,double UFirst,double ULast)
				{
					GeomAdaptor_Curve_LoadED53F64D(Instance, C.Instance, UFirst, ULast);
				}
			public int NbIntervals(GeomAbsShape S)
				{
					return GeomAdaptor_Curve_NbIntervals5ABD177E(Instance, (int)S);
				}
			public Adaptor3dHCurve Trim(double First,double Last,double Tol)
				{
					return new Adaptor3dHCurve(GeomAdaptor_Curve_Trim9282A951(Instance, First, Last, Tol));
				}
			public gpPnt Value(double U)
				{
					return new gpPnt(GeomAdaptor_Curve_ValueD82819F3(Instance, U));
				}
			public void D0(double U,gpPnt P)
				{
					GeomAdaptor_Curve_D053A5A2C1(Instance, U, P.Instance);
				}
			public void D1(double U,gpPnt P,gpVec V)
				{
					GeomAdaptor_Curve_D11387A81(Instance, U, P.Instance, V.Instance);
				}
			public void D2(double U,gpPnt P,gpVec V1,gpVec V2)
				{
					GeomAdaptor_Curve_D227877840(Instance, U, P.Instance, V1.Instance, V2.Instance);
				}
			public void D3(double U,gpPnt P,gpVec V1,gpVec V2,gpVec V3)
				{
					GeomAdaptor_Curve_D356E36E6F(Instance, U, P.Instance, V1.Instance, V2.Instance, V3.Instance);
				}
			public gpVec DN(double U,int N)
				{
					return new gpVec(GeomAdaptor_Curve_DN2935ABDE(Instance, U, N));
				}
			public double Resolution(double R3d)
				{
					return GeomAdaptor_Curve_ResolutionD82819F3(Instance, R3d);
				}
		public GeomCurve Curve{
			get {
				return new GeomCurve(GeomAdaptor_Curve_Curve(Instance));
			}
		}
		public double FirstParameter{
			get {
				return GeomAdaptor_Curve_FirstParameter(Instance);
			}
		}
		public double LastParameter{
			get {
				return GeomAdaptor_Curve_LastParameter(Instance);
			}
		}
		public GeomAbsShape Continuity{
			get {
				return (GeomAbsShape)GeomAdaptor_Curve_Continuity(Instance);
			}
		}
		public bool IsClosed{
			get {
				return GeomAdaptor_Curve_IsClosed(Instance);
			}
		}
		public bool IsPeriodic{
			get {
				return GeomAdaptor_Curve_IsPeriodic(Instance);
			}
		}
		public double Period{
			get {
				return GeomAdaptor_Curve_Period(Instance);
			}
		}
		public GeomAbsCurveType GetType{
			get {
				return (GeomAbsCurveType)GeomAdaptor_Curve_GetType(Instance);
			}
		}
		public gpLin Line{
			get {
				return new gpLin(GeomAdaptor_Curve_Line(Instance));
			}
		}
		public gpCirc Circle{
			get {
				return new gpCirc(GeomAdaptor_Curve_Circle(Instance));
			}
		}
		public gpElips Ellipse{
			get {
				return new gpElips(GeomAdaptor_Curve_Ellipse(Instance));
			}
		}
		public gpHypr Hyperbola{
			get {
				return new gpHypr(GeomAdaptor_Curve_Hyperbola(Instance));
			}
		}
		public gpParab Parabola{
			get {
				return new gpParab(GeomAdaptor_Curve_Parabola(Instance));
			}
		}
		public int Degree{
			get {
				return GeomAdaptor_Curve_Degree(Instance);
			}
		}
		public bool IsRational{
			get {
				return GeomAdaptor_Curve_IsRational(Instance);
			}
		}
		public int NbPoles{
			get {
				return GeomAdaptor_Curve_NbPoles(Instance);
			}
		}
		public int NbKnots{
			get {
				return GeomAdaptor_Curve_NbKnots(Instance);
			}
		}
		public GeomBezierCurve Bezier{
			get {
				return new GeomBezierCurve(GeomAdaptor_Curve_Bezier(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_CtorFF608AE4(IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_CtorED53F64D(IntPtr C,double UFirst,double ULast);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptor_Curve_LoadFF608AE4(IntPtr instance, IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptor_Curve_LoadED53F64D(IntPtr instance, IntPtr C,double UFirst,double ULast);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Curve_NbIntervals5ABD177E(IntPtr instance, int S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_Trim9282A951(IntPtr instance, double First,double Last,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_ValueD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptor_Curve_D053A5A2C1(IntPtr instance, double U,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptor_Curve_D11387A81(IntPtr instance, double U,IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptor_Curve_D227877840(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptor_Curve_D356E36E6F(IntPtr instance, double U,IntPtr P,IntPtr V1,IntPtr V2,IntPtr V3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_DN2935ABDE(IntPtr instance, double U,int N);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Curve_ResolutionD82819F3(IntPtr instance, double R3d);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_Curve(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Curve_FirstParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Curve_LastParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Curve_Continuity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool GeomAdaptor_Curve_IsClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool GeomAdaptor_Curve_IsPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Curve_Period(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Curve_GetType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_Line(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_Circle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_Ellipse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_Hyperbola(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_Parabola(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Curve_Degree(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool GeomAdaptor_Curve_IsRational(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Curve_NbPoles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Curve_NbKnots(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Curve_Bezier(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomAdaptorCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomAdaptorCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptorCurve_Dtor(IntPtr instance);
	}
}
