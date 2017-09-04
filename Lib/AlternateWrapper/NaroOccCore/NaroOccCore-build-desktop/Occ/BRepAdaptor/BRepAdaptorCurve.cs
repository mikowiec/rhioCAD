#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Adaptor3d;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.GeomAdaptor;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.Geom;

#endregion

namespace NaroCppCore.Occ.BRepAdaptor
{
	public class BRepAdaptorCurve : Adaptor3dCurve
	{
		public BRepAdaptorCurve()
 :
			base(BRepAdaptor_Curve_Ctor() )
		{}
		public BRepAdaptorCurve(TopoDSEdge E)
 :
			base(BRepAdaptor_Curve_Ctor24263856(E.Instance) )
		{}
		public BRepAdaptorCurve(TopoDSEdge E,TopoDSFace F)
 :
			base(BRepAdaptor_Curve_Ctor65EC701C(E.Instance, F.Instance) )
		{}
			public void Initialize(TopoDSEdge E)
				{
					BRepAdaptor_Curve_Initialize24263856(Instance, E.Instance);
				}
			public void Initialize(TopoDSEdge E,TopoDSFace F)
				{
					BRepAdaptor_Curve_Initialize65EC701C(Instance, E.Instance, F.Instance);
				}
			public int NbIntervals(GeomAbsShape S)
				{
					return BRepAdaptor_Curve_NbIntervals5ABD177E(Instance, (int)S);
				}
			public Adaptor3dHCurve Trim(double First,double Last,double Tol)
				{
					return new Adaptor3dHCurve(BRepAdaptor_Curve_Trim9282A951(Instance, First, Last, Tol));
				}
			public gpPnt Value(double U)
				{
					return new gpPnt(BRepAdaptor_Curve_ValueD82819F3(Instance, U));
				}
			public gpVec DN(double U,int N)
				{
					return new gpVec(BRepAdaptor_Curve_DN2935ABDE(Instance, U, N));
				}
			public double Resolution(double R3d)
				{
					return BRepAdaptor_Curve_ResolutionD82819F3(Instance, R3d);
				}
		public gpTrsf Trsf{
			get {
				return new gpTrsf(BRepAdaptor_Curve_Trsf(Instance));
			}
		}
		public bool Is3DCurve{
			get {
				return BRepAdaptor_Curve_Is3DCurve(Instance);
			}
		}
		public bool IsCurveOnSurface{
			get {
				return BRepAdaptor_Curve_IsCurveOnSurface(Instance);
			}
		}
		public GeomAdaptorCurve Curve{
			get {
				return new GeomAdaptorCurve(BRepAdaptor_Curve_Curve(Instance));
			}
		}
		public TopoDSEdge Edge{
			get {
				return new TopoDSEdge(BRepAdaptor_Curve_Edge(Instance));
			}
		}
		public double Tolerance{
			get {
				return BRepAdaptor_Curve_Tolerance(Instance);
			}
		}
		public double FirstParameter{
			get {
				return BRepAdaptor_Curve_FirstParameter(Instance);
			}
		}
		public double LastParameter{
			get {
				return BRepAdaptor_Curve_LastParameter(Instance);
			}
		}
		public GeomAbsShape Continuity{
			get {
				return (GeomAbsShape)BRepAdaptor_Curve_Continuity(Instance);
			}
		}
		public bool IsClosed{
			get {
				return BRepAdaptor_Curve_IsClosed(Instance);
			}
		}
		public bool IsPeriodic{
			get {
				return BRepAdaptor_Curve_IsPeriodic(Instance);
			}
		}
		public double Period{
			get {
				return BRepAdaptor_Curve_Period(Instance);
			}
		}
		public GeomAbsCurveType GetType{
			get {
				return (GeomAbsCurveType)BRepAdaptor_Curve_GetType(Instance);
			}
		}
		public gpLin Line{
			get {
				return new gpLin(BRepAdaptor_Curve_Line(Instance));
			}
		}
		public gpCirc Circle{
			get {
				return new gpCirc(BRepAdaptor_Curve_Circle(Instance));
			}
		}
		public gpElips Ellipse{
			get {
				return new gpElips(BRepAdaptor_Curve_Ellipse(Instance));
			}
		}
		public gpHypr Hyperbola{
			get {
				return new gpHypr(BRepAdaptor_Curve_Hyperbola(Instance));
			}
		}
		public gpParab Parabola{
			get {
				return new gpParab(BRepAdaptor_Curve_Parabola(Instance));
			}
		}
		public int Degree{
			get {
				return BRepAdaptor_Curve_Degree(Instance);
			}
		}
		public bool IsRational{
			get {
				return BRepAdaptor_Curve_IsRational(Instance);
			}
		}
		public int NbPoles{
			get {
				return BRepAdaptor_Curve_NbPoles(Instance);
			}
		}
		public int NbKnots{
			get {
				return BRepAdaptor_Curve_NbKnots(Instance);
			}
		}
		public GeomBezierCurve Bezier{
			get {
				return new GeomBezierCurve(BRepAdaptor_Curve_Bezier(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Ctor24263856(IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Ctor65EC701C(IntPtr E,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAdaptor_Curve_Initialize24263856(IntPtr instance, IntPtr E);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAdaptor_Curve_Initialize65EC701C(IntPtr instance, IntPtr E,IntPtr F);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepAdaptor_Curve_NbIntervals5ABD177E(IntPtr instance, int S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Trim9282A951(IntPtr instance, double First,double Last,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_ValueD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_DN2935ABDE(IntPtr instance, double U,int N);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepAdaptor_Curve_ResolutionD82819F3(IntPtr instance, double R3d);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Trsf(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAdaptor_Curve_Is3DCurve(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAdaptor_Curve_IsCurveOnSurface(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Curve(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Edge(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepAdaptor_Curve_Tolerance(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepAdaptor_Curve_FirstParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepAdaptor_Curve_LastParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepAdaptor_Curve_Continuity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAdaptor_Curve_IsClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAdaptor_Curve_IsPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double BRepAdaptor_Curve_Period(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepAdaptor_Curve_GetType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Line(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Circle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Ellipse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Hyperbola(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Parabola(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepAdaptor_Curve_Degree(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAdaptor_Curve_IsRational(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepAdaptor_Curve_NbPoles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepAdaptor_Curve_NbKnots(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAdaptor_Curve_Bezier(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepAdaptorCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepAdaptorCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAdaptorCurve_Dtor(IntPtr instance);
	}
}
