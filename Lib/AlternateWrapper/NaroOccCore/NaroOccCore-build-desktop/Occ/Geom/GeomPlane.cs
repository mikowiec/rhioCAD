#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.Geom
{
	public class GeomPlane : GeomElementarySurface
	{
		public GeomPlane(gpAx3 A3)
 :
			base(Geom_Plane_Ctor1B3CAD05(A3.Instance) )
		{}
		public GeomPlane(gpPln Pl)
 :
			base(Geom_Plane_Ctor9914D2AD(Pl.Instance) )
		{}
		public GeomPlane(gpPnt P,gpDir V)
 :
			base(Geom_Plane_CtorE13B639C(P.Instance, V.Instance) )
		{}
		public GeomPlane(double A,double B,double C,double D)
 :
			base(Geom_Plane_CtorC2777E0C(A, B, C, D) )
		{}
			public void UReverse()
				{
					Geom_Plane_UReverse(Instance);
				}
			public double UReversedParameter(double U)
				{
					return Geom_Plane_UReversedParameterD82819F3(Instance, U);
				}
			public void VReverse()
				{
					Geom_Plane_VReverse(Instance);
				}
			public double VReversedParameter(double V)
				{
					return Geom_Plane_VReversedParameterD82819F3(Instance, V);
				}
			public void TransformParameters(ref double U,ref double V,gpTrsf T)
				{
					Geom_Plane_TransformParametersFD94EFCC(Instance, ref U, ref V, T.Instance);
				}
			public gpGTrsf2d ParametricTransformation(gpTrsf T)
				{
					return new gpGTrsf2d(Geom_Plane_ParametricTransformation72D78650(Instance, T.Instance));
				}
			public void Bounds(ref double U1,ref double U2,ref double V1,ref double V2)
				{
					Geom_Plane_BoundsC2777E0C(Instance, ref U1, ref U2, ref V1, ref V2);
				}
			public void Coefficients(ref double A,ref double B,ref double C,ref double D)
				{
					Geom_Plane_CoefficientsC2777E0C(Instance, ref A, ref B, ref C, ref D);
				}
			public GeomCurve UIso(double U)
				{
					return new GeomCurve(Geom_Plane_UIsoD82819F3(Instance, U));
				}
			public GeomCurve VIso(double V)
				{
					return new GeomCurve(Geom_Plane_VIsoD82819F3(Instance, V));
				}
			public void D0(double U,double V,gpPnt P)
				{
					Geom_Plane_D0C89A646B(Instance, U, V, P.Instance);
				}
			public void D1(double U,double V,gpPnt P,gpVec D1U,gpVec D1V)
				{
					Geom_Plane_D14153CD1A(Instance, U, V, P.Instance, D1U.Instance, D1V.Instance);
				}
			public void D2(double U,double V,gpPnt P,gpVec D1U,gpVec D1V,gpVec D2U,gpVec D2V,gpVec D2UV)
				{
					Geom_Plane_D2E9F600EF(Instance, U, V, P.Instance, D1U.Instance, D1V.Instance, D2U.Instance, D2V.Instance, D2UV.Instance);
				}
			public void D3(double U,double V,gpPnt P,gpVec D1U,gpVec D1V,gpVec D2U,gpVec D2V,gpVec D2UV,gpVec D3U,gpVec D3V,gpVec D3UUV,gpVec D3UVV)
				{
					Geom_Plane_D3B100120D(Instance, U, V, P.Instance, D1U.Instance, D1V.Instance, D2U.Instance, D2V.Instance, D2UV.Instance, D3U.Instance, D3V.Instance, D3UUV.Instance, D3UVV.Instance);
				}
			public gpVec DN(double U,double V,int Nu,int Nv)
				{
					return new gpVec(Geom_Plane_DN852507E(Instance, U, V, Nu, Nv));
				}
			public void Transform(gpTrsf T)
				{
					Geom_Plane_Transform72D78650(Instance, T.Instance);
				}
		public gpPln Pln{
			set { 
				Geom_Plane_SetPln(Instance, value.Instance);
			}
			get {
				return new gpPln(Geom_Plane_Pln(Instance));
			}
		}
		public bool IsUClosed{
			get {
				return Geom_Plane_IsUClosed(Instance);
			}
		}
		public bool IsVClosed{
			get {
				return Geom_Plane_IsVClosed(Instance);
			}
		}
		public bool IsUPeriodic{
			get {
				return Geom_Plane_IsUPeriodic(Instance);
			}
		}
		public bool IsVPeriodic{
			get {
				return Geom_Plane_IsVPeriodic(Instance);
			}
		}
		public GeomGeometry Copy{
			get {
				return new GeomGeometry(Geom_Plane_Copy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Plane_Ctor1B3CAD05(IntPtr A3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Plane_Ctor9914D2AD(IntPtr Pl);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Plane_CtorE13B639C(IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Plane_CtorC2777E0C(double A,double B,double C,double D);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Plane_UReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Plane_UReversedParameterD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Plane_VReverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Geom_Plane_VReversedParameterD82819F3(IntPtr instance, double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Plane_TransformParametersFD94EFCC(IntPtr instance, ref double U,ref double V,IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Plane_ParametricTransformation72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Plane_BoundsC2777E0C(IntPtr instance, ref double U1,ref double U2,ref double V1,ref double V2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Plane_CoefficientsC2777E0C(IntPtr instance, ref double A,ref double B,ref double C,ref double D);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Plane_UIsoD82819F3(IntPtr instance, double U);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Plane_VIsoD82819F3(IntPtr instance, double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Plane_D0C89A646B(IntPtr instance, double U,double V,IntPtr P);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Plane_D14153CD1A(IntPtr instance, double U,double V,IntPtr P,IntPtr D1U,IntPtr D1V);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Plane_D2E9F600EF(IntPtr instance, double U,double V,IntPtr P,IntPtr D1U,IntPtr D1V,IntPtr D2U,IntPtr D2V,IntPtr D2UV);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Plane_D3B100120D(IntPtr instance, double U,double V,IntPtr P,IntPtr D1U,IntPtr D1V,IntPtr D2U,IntPtr D2V,IntPtr D2UV,IntPtr D3U,IntPtr D3V,IntPtr D3UUV,IntPtr D3UVV);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Plane_DN852507E(IntPtr instance, double U,double V,int Nu,int Nv);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Plane_Transform72D78650(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Geom_Plane_SetPln(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Plane_Pln(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Plane_IsUClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Plane_IsVClosed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Plane_IsUPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Geom_Plane_IsVPeriodic(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Geom_Plane_Copy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public GeomPlane() { } 

		public GeomPlane(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ GeomPlane_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void GeomPlane_Dtor(IntPtr instance);
	}
}
