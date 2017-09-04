#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Geom;

#endregion

namespace NaroCppCore.Occ.GeomAPI
{
	public class GeomAPIProjectPointOnCurve : NativeInstancePtr
	{
		public GeomAPIProjectPointOnCurve()
 :
			base(GeomAPI_ProjectPointOnCurve_Ctor() )
		{}
		public GeomAPIProjectPointOnCurve(gpPnt P,GeomCurve Curve)
 :
			base(GeomAPI_ProjectPointOnCurve_Ctor36F2535D(P.Instance, Curve.Instance) )
		{}
		public GeomAPIProjectPointOnCurve(gpPnt P,GeomCurve Curve,double Umin,double Usup)
 :
			base(GeomAPI_ProjectPointOnCurve_CtorFD13CCB9(P.Instance, Curve.Instance, Umin, Usup) )
		{}
			public void Init(gpPnt P,GeomCurve Curve)
				{
					GeomAPI_ProjectPointOnCurve_Init36F2535D(Instance, P.Instance, Curve.Instance);
				}
			public void Init(gpPnt P,GeomCurve Curve,double Umin,double Usup)
				{
					GeomAPI_ProjectPointOnCurve_InitFD13CCB9(Instance, P.Instance, Curve.Instance, Umin, Usup);
				}
			public void Init(GeomCurve Curve,double Umin,double Usup)
				{
					GeomAPI_ProjectPointOnCurve_InitED53F64D(Instance, Curve.Instance, Umin, Usup);
				}
			public void Perform(gpPnt P)
				{
					GeomAPI_ProjectPointOnCurve_Perform9EAECD5B(Instance, P.Instance);
				}
			public gpPnt Point(int Index)
				{
					return new gpPnt(GeomAPI_ProjectPointOnCurve_PointE8219145(Instance, Index));
				}
			public double Parameter(int Index)
				{
					return GeomAPI_ProjectPointOnCurve_ParameterE8219145(Instance, Index);
				}
			public void Parameter(int Index,ref double U)
				{
					GeomAPI_ProjectPointOnCurve_Parameter69F5FCCD(Instance, Index, ref U);
				}
			public double Distance(int Index)
				{
					return GeomAPI_ProjectPointOnCurve_DistanceE8219145(Instance, Index);
				}
		public int NbPoints{
			get {
				return GeomAPI_ProjectPointOnCurve_NbPoints(Instance);
			}
		}
		public gpPnt NearestPoint{
			get {
				return new gpPnt(GeomAPI_ProjectPointOnCurve_NearestPoint(Instance));
			}
		}
		public double LowerDistanceParameter{
			get {
				return GeomAPI_ProjectPointOnCurve_LowerDistanceParameter(Instance);
			}
		}
		public double LowerDistance{
			get {
				return GeomAPI_ProjectPointOnCurve_LowerDistance(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAPI_ProjectPointOnCurve_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAPI_ProjectPointOnCurve_Ctor36F2535D(IntPtr P,IntPtr Curve);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAPI_ProjectPointOnCurve_CtorFD13CCB9(IntPtr P,IntPtr Curve,double Umin,double Usup);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnCurve_Init36F2535D(IntPtr instance, IntPtr P,IntPtr Curve);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnCurve_InitFD13CCB9(IntPtr instance, IntPtr P,IntPtr Curve,double Umin,double Usup);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnCurve_InitED53F64D(IntPtr instance, IntPtr Curve,double Umin,double Usup);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnCurve_Perform9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAPI_ProjectPointOnCurve_PointE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAPI_ProjectPointOnCurve_ParameterE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnCurve_Parameter69F5FCCD(IntPtr instance, int Index,ref double U);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAPI_ProjectPointOnCurve_DistanceE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAPI_ProjectPointOnCurve_NbPoints(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAPI_ProjectPointOnCurve_NearestPoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAPI_ProjectPointOnCurve_LowerDistanceParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAPI_ProjectPointOnCurve_LowerDistance(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomAPIProjectPointOnCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomAPIProjectPointOnCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPIProjectPointOnCurve_Dtor(IntPtr instance);
	}
}
