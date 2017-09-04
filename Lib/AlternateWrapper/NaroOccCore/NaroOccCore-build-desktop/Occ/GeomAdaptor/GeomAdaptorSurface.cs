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
	public class GeomAdaptorSurface : Adaptor3dSurface
	{
		public GeomAdaptorSurface()
 :
			base(GeomAdaptor_Surface_Ctor() )
		{}
		public GeomAdaptorSurface(GeomSurface S)
 :
			base(GeomAdaptor_Surface_Ctor9001466F(S.Instance) )
		{}
		public GeomAdaptorSurface(GeomSurface S,double UFirst,double ULast,double VFirst,double VLast,double TolU,double TolV)
 :
			base(GeomAdaptor_Surface_CtorBCD666D6(S.Instance, UFirst, ULast, VFirst, VLast, TolU, TolV) )
		{}
			public void Load(GeomSurface S)
				{
					GeomAdaptor_Surface_Load9001466F(Instance, S.Instance);
				}
			public void Load(GeomSurface S,double UFirst,double ULast,double VFirst,double VLast,double TolU,double TolV)
				{
					GeomAdaptor_Surface_LoadBCD666D6(Instance, S.Instance, UFirst, ULast, VFirst, VLast, TolU, TolV);
				}
			public int NbUIntervals(GeomAbsShape S)
				{
					return GeomAdaptor_Surface_NbUIntervals5ABD177E(Instance, (int)S);
				}
			public int NbVIntervals(GeomAbsShape S)
				{
					return GeomAdaptor_Surface_NbVIntervals5ABD177E(Instance, (int)S);
				}
			public Adaptor3dHSurface UTrim(double First,double Last,double Tol)
				{
					return new Adaptor3dHSurface(GeomAdaptor_Surface_UTrim9282A951(Instance, First, Last, Tol));
				}
			public Adaptor3dHSurface VTrim(double First,double Last,double Tol)
				{
					return new Adaptor3dHSurface(GeomAdaptor_Surface_VTrim9282A951(Instance, First, Last, Tol));
				}
			public gpPnt Value(double U,double V)
				{
					return new gpPnt(GeomAdaptor_Surface_Value9F0E714F(Instance, U, V));
				}
			public void D0(double U,double V,gpPnt P)
				{
					GeomAdaptor_Surface_D0C89A646B(Instance, U, V, P.Instance);
				}
			public void D1(double U,double V,gpPnt P,gpVec D1U,gpVec D1V)
				{
					GeomAdaptor_Surface_D14153CD1A(Instance, U, V, P.Instance, D1U.Instance, D1V.Instance);
				}
			public void D2(double U,double V,gpPnt P,gpVec D1U,gpVec D1V,gpVec D2U,gpVec D2V,gpVec D2UV)
				{
					GeomAdaptor_Surface_D2E9F600EF(Instance, U, V, P.Instance, D1U.Instance, D1V.Instance, D2U.Instance, D2V.Instance, D2UV.Instance);
				}
			public void D3(double U,double V,gpPnt P,gpVec D1U,gpVec D1V,gpVec D2U,gpVec D2V,gpVec D2UV,gpVec D3U,gpVec D3V,gpVec D3UUV,gpVec D3UVV)
				{
					GeomAdaptor_Surface_D3B100120D(Instance, U, V, P.Instance, D1U.Instance, D1V.Instance, D2U.Instance, D2V.Instance, D2UV.Instance, D3U.Instance, D3V.Instance, D3UUV.Instance, D3UVV.Instance);
				}
			public gpVec DN(double U,double V,int Nu,int Nv)
				{
					return new gpVec(GeomAdaptor_Surface_DN852507E(Instance, U, V, Nu, Nv));
				}
			public double UResolution(double R3d)
				{
					return GeomAdaptor_Surface_UResolutionD82819F3(Instance, R3d);
				}
			public double VResolution(double R3d)
				{
					return GeomAdaptor_Surface_VResolutionD82819F3(Instance, R3d);
				}
		public GeomSurface Surface{
			get {
				return new GeomSurface(GeomAdaptor_Surface_Surface(Instance));
			}
		}
		public double FirstUParameter{
			get {
				return GeomAdaptor_Surface_FirstUParameter(Instance);
			}
		}
		public double LastUParameter{
			get {
				return GeomAdaptor_Surface_LastUParameter(Instance);
			}
		}
		public double FirstVParameter{
			get {
				return GeomAdaptor_Surface_FirstVParameter(Instance);
			}
		}
		public double LastVParameter{
			get {
				return GeomAdaptor_Surface_LastVParameter(Instance);
			}
		}
		public GeomAbsShape UContinuity{
			get {
				return (GeomAbsShape)GeomAdaptor_Surface_UContinuity(Instance);
			}
		}
		public GeomAbsShape VContinuity{
			get {
				return (GeomAbsShape)GeomAdaptor_Surface_VContinuity(Instance);
			}
		}
		public bool IsUClosed{
			get {
				return GeomAdaptor_Surface_IsUClosed(Instance);
			}
		}
		public bool IsVClosed{
			get {
				return GeomAdaptor_Surface_IsVClosed(Instance);
			}
		}
		public bool IsUPeriodic{
			get {
				return GeomAdaptor_Surface_IsUPeriodic(Instance);
			}
		}
		public double UPeriod{
			get {
				return GeomAdaptor_Surface_UPeriod(Instance);
			}
		}
		public bool IsVPeriodic{
			get {
				return GeomAdaptor_Surface_IsVPeriodic(Instance);
			}
		}
		public double VPeriod{
			get {
				return GeomAdaptor_Surface_VPeriod(Instance);
			}
		}
		public GeomAbsSurfaceType GetType{
			get {
				return (GeomAbsSurfaceType)GeomAdaptor_Surface_GetType(Instance);
			}
		}
		public gpPln Plane{
			get {
				return new gpPln(GeomAdaptor_Surface_Plane(Instance));
			}
		}
		public gpCylinder Cylinder{
			get {
				return new gpCylinder(GeomAdaptor_Surface_Cylinder(Instance));
			}
		}
		public gpCone Cone{
			get {
				return new gpCone(GeomAdaptor_Surface_Cone(Instance));
			}
		}
		public gpSphere Sphere{
			get {
				return new gpSphere(GeomAdaptor_Surface_Sphere(Instance));
			}
		}
		public gpTorus Torus{
			get {
				return new gpTorus(GeomAdaptor_Surface_Torus(Instance));
			}
		}
		public int UDegree{
			get {
				return GeomAdaptor_Surface_UDegree(Instance);
			}
		}
		public int NbUPoles{
			get {
				return GeomAdaptor_Surface_NbUPoles(Instance);
			}
		}
		public int VDegree{
			get {
				return GeomAdaptor_Surface_VDegree(Instance);
			}
		}
		public int NbVPoles{
			get {
				return GeomAdaptor_Surface_NbVPoles(Instance);
			}
		}
		public int NbUKnots{
			get {
				return GeomAdaptor_Surface_NbUKnots(Instance);
			}
		}
		public int NbVKnots{
			get {
				return GeomAdaptor_Surface_NbVKnots(Instance);
			}
		}
		public bool IsURational{
			get {
				return GeomAdaptor_Surface_IsURational(Instance);
			}
		}
		public bool IsVRational{
			get {
				return GeomAdaptor_Surface_IsVRational(Instance);
			}
		}
		public gpAx1 AxeOfRevolution{
			get {
				return new gpAx1(GeomAdaptor_Surface_AxeOfRevolution(Instance));
			}
		}
		public gpDir Direction{
			get {
				return new gpDir(GeomAdaptor_Surface_Direction(Instance));
			}
		}
		public Adaptor3dHCurve BasisCurve{
			get {
				return new Adaptor3dHCurve(GeomAdaptor_Surface_BasisCurve(Instance));
			}
		}
		public Adaptor3dHSurface BasisSurface{
			get {
				return new Adaptor3dHSurface(GeomAdaptor_Surface_BasisSurface(Instance));
			}
		}
		public double OffsetValue{
			get {
				return GeomAdaptor_Surface_OffsetValue(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_Ctor9001466F(IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_CtorBCD666D6(IntPtr S,double UFirst,double ULast,double VFirst,double VLast,double TolU,double TolV);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptor_Surface_Load9001466F(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptor_Surface_LoadBCD666D6(IntPtr instance, IntPtr S,double UFirst,double ULast,double VFirst,double VLast,double TolU,double TolV);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Surface_NbUIntervals5ABD177E(IntPtr instance, int S);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Surface_NbVIntervals5ABD177E(IntPtr instance, int S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_UTrim9282A951(IntPtr instance, double First,double Last,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_VTrim9282A951(IntPtr instance, double First,double Last,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_Value9F0E714F(IntPtr instance, double U,double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptor_Surface_D0C89A646B(IntPtr instance, double U,double V,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptor_Surface_D14153CD1A(IntPtr instance, double U,double V,IntPtr P,IntPtr D1U,IntPtr D1V);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptor_Surface_D2E9F600EF(IntPtr instance, double U,double V,IntPtr P,IntPtr D1U,IntPtr D1V,IntPtr D2U,IntPtr D2V,IntPtr D2UV);
		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptor_Surface_D3B100120D(IntPtr instance, double U,double V,IntPtr P,IntPtr D1U,IntPtr D1V,IntPtr D2U,IntPtr D2V,IntPtr D2UV,IntPtr D3U,IntPtr D3V,IntPtr D3UUV,IntPtr D3UVV);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_DN852507E(IntPtr instance, double U,double V,int Nu,int Nv);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Surface_UResolutionD82819F3(IntPtr instance, double R3d);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Surface_VResolutionD82819F3(IntPtr instance, double R3d);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_Surface(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Surface_FirstUParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Surface_LastUParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Surface_FirstVParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Surface_LastVParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Surface_UContinuity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Surface_VContinuity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool GeomAdaptor_Surface_IsUClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool GeomAdaptor_Surface_IsVClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool GeomAdaptor_Surface_IsUPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Surface_UPeriod(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool GeomAdaptor_Surface_IsVPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Surface_VPeriod(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Surface_GetType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_Plane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_Cylinder(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_Cone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_Sphere(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_Torus(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Surface_UDegree(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Surface_NbUPoles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Surface_VDegree(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Surface_NbVPoles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Surface_NbUKnots(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int GeomAdaptor_Surface_NbVKnots(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool GeomAdaptor_Surface_IsURational(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool GeomAdaptor_Surface_IsVRational(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_AxeOfRevolution(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_Direction(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_BasisCurve(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr GeomAdaptor_Surface_BasisSurface(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double GeomAdaptor_Surface_OffsetValue(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomAdaptorSurface(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomAdaptorSurface_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomAdaptorSurface_Dtor(IntPtr instance);
	}
}
