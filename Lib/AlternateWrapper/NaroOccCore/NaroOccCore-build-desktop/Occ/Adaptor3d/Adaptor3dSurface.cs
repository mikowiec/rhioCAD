#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.GeomAbs;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Adaptor3d;

#endregion

namespace NaroCppCore.Occ.Adaptor3d
{
	public class Adaptor3dSurface : NativeInstancePtr
	{
			public void Delete()
				{
					Adaptor3d_Surface_Delete(Instance);
				}
			public int NbUIntervals(GeomAbsShape S)
				{
					return Adaptor3d_Surface_NbUIntervals5ABD177E(Instance, (int)S);
				}
			public int NbVIntervals(GeomAbsShape S)
				{
					return Adaptor3d_Surface_NbVIntervals5ABD177E(Instance, (int)S);
				}
			public Adaptor3dHSurface UTrim(double First,double Last,double Tol)
				{
					return new Adaptor3dHSurface(Adaptor3d_Surface_UTrim9282A951(Instance, First, Last, Tol));
				}
			public Adaptor3dHSurface VTrim(double First,double Last,double Tol)
				{
					return new Adaptor3dHSurface(Adaptor3d_Surface_VTrim9282A951(Instance, First, Last, Tol));
				}
			public gpPnt Value(double U,double V)
				{
					return new gpPnt(Adaptor3d_Surface_Value9F0E714F(Instance, U, V));
				}
			public void D0(double U,double V,gpPnt P)
				{
					Adaptor3d_Surface_D0C89A646B(Instance, U, V, P.Instance);
				}
			public void D1(double U,double V,gpPnt P,gpVec D1U,gpVec D1V)
				{
					Adaptor3d_Surface_D14153CD1A(Instance, U, V, P.Instance, D1U.Instance, D1V.Instance);
				}
			public void D2(double U,double V,gpPnt P,gpVec D1U,gpVec D1V,gpVec D2U,gpVec D2V,gpVec D2UV)
				{
					Adaptor3d_Surface_D2E9F600EF(Instance, U, V, P.Instance, D1U.Instance, D1V.Instance, D2U.Instance, D2V.Instance, D2UV.Instance);
				}
			public void D3(double U,double V,gpPnt P,gpVec D1U,gpVec D1V,gpVec D2U,gpVec D2V,gpVec D2UV,gpVec D3U,gpVec D3V,gpVec D3UUV,gpVec D3UVV)
				{
					Adaptor3d_Surface_D3B100120D(Instance, U, V, P.Instance, D1U.Instance, D1V.Instance, D2U.Instance, D2V.Instance, D2UV.Instance, D3U.Instance, D3V.Instance, D3UUV.Instance, D3UVV.Instance);
				}
			public gpVec DN(double U,double V,int Nu,int Nv)
				{
					return new gpVec(Adaptor3d_Surface_DN852507E(Instance, U, V, Nu, Nv));
				}
			public double UResolution(double R3d)
				{
					return Adaptor3d_Surface_UResolutionD82819F3(Instance, R3d);
				}
			public double VResolution(double R3d)
				{
					return Adaptor3d_Surface_VResolutionD82819F3(Instance, R3d);
				}
		public double FirstUParameter{
			get {
				return Adaptor3d_Surface_FirstUParameter(Instance);
			}
		}
		public double LastUParameter{
			get {
				return Adaptor3d_Surface_LastUParameter(Instance);
			}
		}
		public double FirstVParameter{
			get {
				return Adaptor3d_Surface_FirstVParameter(Instance);
			}
		}
		public double LastVParameter{
			get {
				return Adaptor3d_Surface_LastVParameter(Instance);
			}
		}
		public GeomAbsShape UContinuity{
			get {
				return (GeomAbsShape)Adaptor3d_Surface_UContinuity(Instance);
			}
		}
		public GeomAbsShape VContinuity{
			get {
				return (GeomAbsShape)Adaptor3d_Surface_VContinuity(Instance);
			}
		}
		public bool IsUClosed{
			get {
				return Adaptor3d_Surface_IsUClosed(Instance);
			}
		}
		public bool IsVClosed{
			get {
				return Adaptor3d_Surface_IsVClosed(Instance);
			}
		}
		public bool IsUPeriodic{
			get {
				return Adaptor3d_Surface_IsUPeriodic(Instance);
			}
		}
		public double UPeriod{
			get {
				return Adaptor3d_Surface_UPeriod(Instance);
			}
		}
		public bool IsVPeriodic{
			get {
				return Adaptor3d_Surface_IsVPeriodic(Instance);
			}
		}
		public double VPeriod{
			get {
				return Adaptor3d_Surface_VPeriod(Instance);
			}
		}
		public GeomAbsSurfaceType GetType{
			get {
				return (GeomAbsSurfaceType)Adaptor3d_Surface_GetType(Instance);
			}
		}
		public gpPln Plane{
			get {
				return new gpPln(Adaptor3d_Surface_Plane(Instance));
			}
		}
		public gpCylinder Cylinder{
			get {
				return new gpCylinder(Adaptor3d_Surface_Cylinder(Instance));
			}
		}
		public gpCone Cone{
			get {
				return new gpCone(Adaptor3d_Surface_Cone(Instance));
			}
		}
		public gpSphere Sphere{
			get {
				return new gpSphere(Adaptor3d_Surface_Sphere(Instance));
			}
		}
		public gpTorus Torus{
			get {
				return new gpTorus(Adaptor3d_Surface_Torus(Instance));
			}
		}
		public int UDegree{
			get {
				return Adaptor3d_Surface_UDegree(Instance);
			}
		}
		public int NbUPoles{
			get {
				return Adaptor3d_Surface_NbUPoles(Instance);
			}
		}
		public int VDegree{
			get {
				return Adaptor3d_Surface_VDegree(Instance);
			}
		}
		public int NbVPoles{
			get {
				return Adaptor3d_Surface_NbVPoles(Instance);
			}
		}
		public int NbUKnots{
			get {
				return Adaptor3d_Surface_NbUKnots(Instance);
			}
		}
		public int NbVKnots{
			get {
				return Adaptor3d_Surface_NbVKnots(Instance);
			}
		}
		public bool IsURational{
			get {
				return Adaptor3d_Surface_IsURational(Instance);
			}
		}
		public bool IsVRational{
			get {
				return Adaptor3d_Surface_IsVRational(Instance);
			}
		}
		public gpAx1 AxeOfRevolution{
			get {
				return new gpAx1(Adaptor3d_Surface_AxeOfRevolution(Instance));
			}
		}
		public gpDir Direction{
			get {
				return new gpDir(Adaptor3d_Surface_Direction(Instance));
			}
		}
		public Adaptor3dHCurve BasisCurve{
			get {
				return new Adaptor3dHCurve(Adaptor3d_Surface_BasisCurve(Instance));
			}
		}
		public Adaptor3dHSurface BasisSurface{
			get {
				return new Adaptor3dHSurface(Adaptor3d_Surface_BasisSurface(Instance));
			}
		}
		public double OffsetValue{
			get {
				return Adaptor3d_Surface_OffsetValue(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_Surface_Delete(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Surface_NbUIntervals5ABD177E(IntPtr instance, int S);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Surface_NbVIntervals5ABD177E(IntPtr instance, int S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_UTrim9282A951(IntPtr instance, double First,double Last,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_VTrim9282A951(IntPtr instance, double First,double Last,double Tol);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_Value9F0E714F(IntPtr instance, double U,double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_Surface_D0C89A646B(IntPtr instance, double U,double V,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_Surface_D14153CD1A(IntPtr instance, double U,double V,IntPtr P,IntPtr D1U,IntPtr D1V);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_Surface_D2E9F600EF(IntPtr instance, double U,double V,IntPtr P,IntPtr D1U,IntPtr D1V,IntPtr D2U,IntPtr D2V,IntPtr D2UV);
		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3d_Surface_D3B100120D(IntPtr instance, double U,double V,IntPtr P,IntPtr D1U,IntPtr D1V,IntPtr D2U,IntPtr D2V,IntPtr D2UV,IntPtr D3U,IntPtr D3V,IntPtr D3UUV,IntPtr D3UVV);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_DN852507E(IntPtr instance, double U,double V,int Nu,int Nv);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Surface_UResolutionD82819F3(IntPtr instance, double R3d);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Surface_VResolutionD82819F3(IntPtr instance, double R3d);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Surface_FirstUParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Surface_LastUParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Surface_FirstVParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Surface_LastVParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Surface_UContinuity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Surface_VContinuity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor3d_Surface_IsUClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor3d_Surface_IsVClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor3d_Surface_IsUPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Surface_UPeriod(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor3d_Surface_IsVPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Surface_VPeriod(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Surface_GetType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_Plane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_Cylinder(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_Cone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_Sphere(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_Torus(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Surface_UDegree(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Surface_NbUPoles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Surface_VDegree(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Surface_NbVPoles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Surface_NbUKnots(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Adaptor3d_Surface_NbVKnots(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor3d_Surface_IsURational(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Adaptor3d_Surface_IsVRational(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_AxeOfRevolution(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_Direction(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_BasisCurve(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Adaptor3d_Surface_BasisSurface(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Adaptor3d_Surface_OffsetValue(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Adaptor3dSurface() { } 

		public Adaptor3dSurface(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Adaptor3dSurface_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Adaptor3dSurface_Dtor(IntPtr instance);
	}
}
