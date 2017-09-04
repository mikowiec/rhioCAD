#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.Extrema;

#endregion

namespace NaroCppCore.Occ.GeomAPI
{
	public class GeomAPIProjectPointOnSurf : NativeInstancePtr
	{
		public GeomAPIProjectPointOnSurf()
 :
			base(GeomAPI_ProjectPointOnSurf_Ctor() )
		{}
		public GeomAPIProjectPointOnSurf(gpPnt P,GeomSurface Surface,ExtremaExtAlgo Algo)
 :
			base(GeomAPI_ProjectPointOnSurf_Ctor491C84E1(P.Instance, Surface.Instance, (int)Algo) )
		{}
		public GeomAPIProjectPointOnSurf(gpPnt P,GeomSurface Surface,double Tolerance,ExtremaExtAlgo Algo)
 :
			base(GeomAPI_ProjectPointOnSurf_Ctor72869244(P.Instance, Surface.Instance, Tolerance, (int)Algo) )
		{}
		public GeomAPIProjectPointOnSurf(gpPnt P,GeomSurface Surface,double Umin,double Usup,double Vmin,double Vsup,double Tolerance,ExtremaExtAlgo Algo)
 :
			base(GeomAPI_ProjectPointOnSurf_CtorBF455401(P.Instance, Surface.Instance, Umin, Usup, Vmin, Vsup, Tolerance, (int)Algo) )
		{}
		public GeomAPIProjectPointOnSurf(gpPnt P,GeomSurface Surface,double Umin,double Usup,double Vmin,double Vsup,ExtremaExtAlgo Algo)
 :
			base(GeomAPI_ProjectPointOnSurf_CtorCC109054(P.Instance, Surface.Instance, Umin, Usup, Vmin, Vsup, (int)Algo) )
		{}
			public void Init(gpPnt P,GeomSurface Surface,double Tolerance,ExtremaExtAlgo Algo)
				{
					GeomAPI_ProjectPointOnSurf_Init72869244(Instance, P.Instance, Surface.Instance, Tolerance, (int)Algo);
				}
			public void Init(gpPnt P,GeomSurface Surface,ExtremaExtAlgo Algo)
				{
					GeomAPI_ProjectPointOnSurf_Init491C84E1(Instance, P.Instance, Surface.Instance, (int)Algo);
				}
			public void Init(gpPnt P,GeomSurface Surface,double Umin,double Usup,double Vmin,double Vsup,double Tolerance,ExtremaExtAlgo Algo)
				{
					GeomAPI_ProjectPointOnSurf_InitBF455401(Instance, P.Instance, Surface.Instance, Umin, Usup, Vmin, Vsup, Tolerance, (int)Algo);
				}
			public void Init(gpPnt P,GeomSurface Surface,double Umin,double Usup,double Vmin,double Vsup,ExtremaExtAlgo Algo)
				{
					GeomAPI_ProjectPointOnSurf_InitCC109054(Instance, P.Instance, Surface.Instance, Umin, Usup, Vmin, Vsup, (int)Algo);
				}
			public void Init(GeomSurface Surface,double Umin,double Usup,double Vmin,double Vsup,double Tolerance,ExtremaExtAlgo Algo)
				{
					GeomAPI_ProjectPointOnSurf_InitC925CD84(Instance, Surface.Instance, Umin, Usup, Vmin, Vsup, Tolerance, (int)Algo);
				}
			public void Init(GeomSurface Surface,double Umin,double Usup,double Vmin,double Vsup,ExtremaExtAlgo Algo)
				{
					GeomAPI_ProjectPointOnSurf_Init702736C(Instance, Surface.Instance, Umin, Usup, Vmin, Vsup, (int)Algo);
				}
			public void Perform(gpPnt P)
				{
					GeomAPI_ProjectPointOnSurf_Perform9EAECD5B(Instance, P.Instance);
				}
			public gpPnt Point(int Index)
				{
					return new gpPnt(GeomAPI_ProjectPointOnSurf_PointE8219145(Instance, Index));
				}
			public void Parameters(int Index,ref double U,ref double V)
				{
					GeomAPI_ProjectPointOnSurf_Parameters306E0DFB(Instance, Index, ref U, ref V);
				}
			public double Distance(int Index)
				{
					return GeomAPI_ProjectPointOnSurf_DistanceE8219145(Instance, Index);
				}
			public void LowerDistanceParameters(ref double U,ref double V)
				{
					GeomAPI_ProjectPointOnSurf_LowerDistanceParameters9F0E714F(Instance, ref U, ref V);
				}
		public bool IsDone{
			get {
				return GeomAPI_ProjectPointOnSurf_IsDone(Instance);
			}
		}
		public int NbPoints{
			get {
				return GeomAPI_ProjectPointOnSurf_NbPoints(Instance);
			}
		}
		public gpPnt NearestPoint{
			get {
				return new gpPnt(GeomAPI_ProjectPointOnSurf_NearestPoint(Instance));
			}
		}
		public double LowerDistance{
			get {
				return GeomAPI_ProjectPointOnSurf_LowerDistance(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAPI_ProjectPointOnSurf_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAPI_ProjectPointOnSurf_Ctor491C84E1(IntPtr P,IntPtr Surface,int Algo);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAPI_ProjectPointOnSurf_Ctor72869244(IntPtr P,IntPtr Surface,double Tolerance,int Algo);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAPI_ProjectPointOnSurf_CtorBF455401(IntPtr P,IntPtr Surface,double Umin,double Usup,double Vmin,double Vsup,double Tolerance,int Algo);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAPI_ProjectPointOnSurf_CtorCC109054(IntPtr P,IntPtr Surface,double Umin,double Usup,double Vmin,double Vsup,int Algo);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnSurf_Init72869244(IntPtr instance, IntPtr P,IntPtr Surface,double Tolerance,int Algo);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnSurf_Init491C84E1(IntPtr instance, IntPtr P,IntPtr Surface,int Algo);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnSurf_InitBF455401(IntPtr instance, IntPtr P,IntPtr Surface,double Umin,double Usup,double Vmin,double Vsup,double Tolerance,int Algo);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnSurf_InitCC109054(IntPtr instance, IntPtr P,IntPtr Surface,double Umin,double Usup,double Vmin,double Vsup,int Algo);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnSurf_InitC925CD84(IntPtr instance, IntPtr Surface,double Umin,double Usup,double Vmin,double Vsup,double Tolerance,int Algo);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnSurf_Init702736C(IntPtr instance, IntPtr Surface,double Umin,double Usup,double Vmin,double Vsup,int Algo);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnSurf_Perform9EAECD5B(IntPtr instance, IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAPI_ProjectPointOnSurf_PointE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnSurf_Parameters306E0DFB(IntPtr instance, int Index,ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAPI_ProjectPointOnSurf_DistanceE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPI_ProjectPointOnSurf_LowerDistanceParameters9F0E714F(IntPtr instance, ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern bool GeomAPI_ProjectPointOnSurf_IsDone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAPI_ProjectPointOnSurf_NbPoints(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAPI_ProjectPointOnSurf_NearestPoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAPI_ProjectPointOnSurf_LowerDistance(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomAPIProjectPointOnSurf(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomAPIProjectPointOnSurf_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAPIProjectPointOnSurf_Dtor(IntPtr instance);
	}
}
