#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.IntAna
{
	public class IntAnaCurve : NativeInstancePtr
	{
		public IntAnaCurve()
 :
			base(IntAna_Curve_Ctor() )
		{}
			public void SetCylinderQuadValues(gpCylinder Cylinder,double Qxx,double Qyy,double Qzz,double Qxy,double Qxz,double Qyz,double Qx,double Qy,double Qz,double Q1,double Tol,double DomInf,double DomSup,bool TwoZForATheta,bool ZIsPositive)
				{
					IntAna_Curve_SetCylinderQuadValuesA2ABD1B0(Instance, Cylinder.Instance, Qxx, Qyy, Qzz, Qxy, Qxz, Qyz, Qx, Qy, Qz, Q1, Tol, DomInf, DomSup, TwoZForATheta, ZIsPositive);
				}
			public void SetConeQuadValues(gpCone Cone,double Qxx,double Qyy,double Qzz,double Qxy,double Qxz,double Qyz,double Qx,double Qy,double Qz,double Q1,double Tol,double DomInf,double DomSup,bool TwoZForATheta,bool ZIsPositive)
				{
					IntAna_Curve_SetConeQuadValuesEF30360(Instance, Cone.Instance, Qxx, Qyy, Qzz, Qxy, Qxz, Qyz, Qx, Qy, Qz, Q1, Tol, DomInf, DomSup, TwoZForATheta, ZIsPositive);
				}
			public void Domain(ref double Theta1,ref double Theta2)
				{
					IntAna_Curve_Domain9F0E714F(Instance, ref Theta1, ref Theta2);
				}
			public gpPnt Value(double Theta)
				{
					return new gpPnt(IntAna_Curve_ValueD82819F3(Instance, Theta));
				}
			public bool D1u(double Theta,gpPnt P,gpVec V)
				{
					return IntAna_Curve_D1u1387A81(Instance, Theta, P.Instance, V.Instance);
				}
			public bool FindParameter(gpPnt P,ref double Para)
				{
					return IntAna_Curve_FindParameterF0D1E3E6(Instance, P.Instance, ref Para);
				}
			public void InternalUVValue(double Param,ref double U,ref double V,ref double A,ref double B,ref double C,ref double Co,ref double Si,ref double Di)
				{
					IntAna_Curve_InternalUVValueE32698D4(Instance, Param, ref U, ref V, ref A, ref B, ref C, ref Co, ref Si, ref Di);
				}
			public void SetDomain(double Theta1,double Theta2)
				{
					IntAna_Curve_SetDomain9F0E714F(Instance, Theta1, Theta2);
				}
		public bool IsOpen{
			get {
				return IntAna_Curve_IsOpen(Instance);
			}
		}
		public bool IsConstant{
			get {
				return IntAna_Curve_IsConstant(Instance);
			}
		}
		public bool IsFirstOpen{
			set { 
				IntAna_Curve_SetIsFirstOpen(Instance, value);
			}
			get {
				return IntAna_Curve_IsFirstOpen(Instance);
			}
		}
		public bool IsLastOpen{
			set { 
				IntAna_Curve_SetIsLastOpen(Instance, value);
			}
			get {
				return IntAna_Curve_IsLastOpen(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntAna_Curve_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void IntAna_Curve_SetCylinderQuadValuesA2ABD1B0(IntPtr instance, IntPtr Cylinder,double Qxx,double Qyy,double Qzz,double Qxy,double Qxz,double Qyz,double Qx,double Qy,double Qz,double Q1,double Tol,double DomInf,double DomSup,bool TwoZForATheta,bool ZIsPositive);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntAna_Curve_SetConeQuadValuesEF30360(IntPtr instance, IntPtr Cone,double Qxx,double Qyy,double Qzz,double Qxy,double Qxz,double Qyz,double Qx,double Qy,double Qz,double Q1,double Tol,double DomInf,double DomSup,bool TwoZForATheta,bool ZIsPositive);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntAna_Curve_Domain9F0E714F(IntPtr instance, ref double Theta1,ref double Theta2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntAna_Curve_ValueD82819F3(IntPtr instance, double Theta);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntAna_Curve_D1u1387A81(IntPtr instance, double Theta,IntPtr P,IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntAna_Curve_FindParameterF0D1E3E6(IntPtr instance, IntPtr P,ref double Para);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntAna_Curve_InternalUVValueE32698D4(IntPtr instance, double Param,ref double U,ref double V,ref double A,ref double B,ref double C,ref double Co,ref double Si,ref double Di);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntAna_Curve_SetDomain9F0E714F(IntPtr instance, double Theta1,double Theta2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntAna_Curve_IsOpen(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntAna_Curve_IsConstant(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntAna_Curve_SetIsFirstOpen(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntAna_Curve_IsFirstOpen(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntAna_Curve_SetIsLastOpen(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntAna_Curve_IsLastOpen(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public IntAnaCurve(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntAnaCurve_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntAnaCurve_Dtor(IntPtr instance);
	}
}
