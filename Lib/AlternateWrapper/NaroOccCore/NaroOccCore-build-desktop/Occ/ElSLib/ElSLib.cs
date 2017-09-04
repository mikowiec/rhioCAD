#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.ElSLib
{
	public class ElSLib : NativeInstancePtr
	{
			public static gpPnt Value(double U,double V,gpPln Pl)
				{
					return new gpPnt(ElSLib_ValueF8AFA8C9(U, V, Pl.Instance));
				}
			public static gpPnt Value(double U,double V,gpCone C)
				{
					return new gpPnt(ElSLib_Value2E3DA8BC(U, V, C.Instance));
				}
			public static gpPnt Value(double U,double V,gpCylinder C)
				{
					return new gpPnt(ElSLib_Value9C94886B(U, V, C.Instance));
				}
			public static gpPnt Value(double U,double V,gpSphere S)
				{
					return new gpPnt(ElSLib_ValueA6EAF455(U, V, S.Instance));
				}
			public static gpPnt Value(double U,double V,gpTorus T)
				{
					return new gpPnt(ElSLib_Value4E3B815B(U, V, T.Instance));
				}
			public static gpPnt PlaneValue(double U,double V,gpAx3 Pos)
				{
					return new gpPnt(ElSLib_PlaneValueCFBE1681(U, V, Pos.Instance));
				}
			public static gpPnt CylinderValue(double U,double V,gpAx3 Pos,double Radius)
				{
					return new gpPnt(ElSLib_CylinderValueBACDEA69(U, V, Pos.Instance, Radius));
				}
			public static gpPnt ConeValue(double U,double V,gpAx3 Pos,double Radius,double SAngle)
				{
					return new gpPnt(ElSLib_ConeValue5CAF831A(U, V, Pos.Instance, Radius, SAngle));
				}
			public static gpPnt SphereValue(double U,double V,gpAx3 Pos,double Radius)
				{
					return new gpPnt(ElSLib_SphereValueBACDEA69(U, V, Pos.Instance, Radius));
				}
			public static gpPnt TorusValue(double U,double V,gpAx3 Pos,double MajorRadius,double MinorRadius)
				{
					return new gpPnt(ElSLib_TorusValue5CAF831A(U, V, Pos.Instance, MajorRadius, MinorRadius));
				}
			public static void Parameters(gpPln Pl,gpPnt P,ref double U,ref double V)
				{
					ElSLib_Parameters26ED892A(Pl.Instance, P.Instance, ref U, ref V);
				}
			public static void Parameters(gpCylinder C,gpPnt P,ref double U,ref double V)
				{
					ElSLib_Parameters93A5F71D(C.Instance, P.Instance, ref U, ref V);
				}
			public static void Parameters(gpCone C,gpPnt P,ref double U,ref double V)
				{
					ElSLib_Parameters128A564F(C.Instance, P.Instance, ref U, ref V);
				}
			public static void Parameters(gpSphere S,gpPnt P,ref double U,ref double V)
				{
					ElSLib_Parameters70B953D6(S.Instance, P.Instance, ref U, ref V);
				}
			public static void Parameters(gpTorus T,gpPnt P,ref double U,ref double V)
				{
					ElSLib_Parameters820B077D(T.Instance, P.Instance, ref U, ref V);
				}
			public static void PlaneParameters(gpAx3 Pos,gpPnt P,ref double U,ref double V)
				{
					ElSLib_PlaneParametersC11F2078(Pos.Instance, P.Instance, ref U, ref V);
				}
			public static void CylinderParameters(gpAx3 Pos,double Radius,gpPnt P,ref double U,ref double V)
				{
					ElSLib_CylinderParameters2262D7A7(Pos.Instance, Radius, P.Instance, ref U, ref V);
				}
			public static void ConeParameters(gpAx3 Pos,double Radius,double SAngle,gpPnt P,ref double U,ref double V)
				{
					ElSLib_ConeParametersE2117665(Pos.Instance, Radius, SAngle, P.Instance, ref U, ref V);
				}
			public static void SphereParameters(gpAx3 Pos,double Radius,gpPnt P,ref double U,ref double V)
				{
					ElSLib_SphereParameters2262D7A7(Pos.Instance, Radius, P.Instance, ref U, ref V);
				}
			public static void TorusParameters(gpAx3 Pos,double MajorRadius,double MinorRadius,gpPnt P,ref double U,ref double V)
				{
					ElSLib_TorusParametersE2117665(Pos.Instance, MajorRadius, MinorRadius, P.Instance, ref U, ref V);
				}
			public static gpLin PlaneUIso(gpAx3 Pos,double U)
				{
					return new gpLin(ElSLib_PlaneUIso5C6D1CB8(Pos.Instance, U));
				}
			public static gpLin CylinderUIso(gpAx3 Pos,double Radius,double U)
				{
					return new gpLin(ElSLib_CylinderUIso32BF0691(Pos.Instance, Radius, U));
				}
			public static gpLin ConeUIso(gpAx3 Pos,double Radius,double SAngle,double U)
				{
					return new gpLin(ElSLib_ConeUIso649F02B6(Pos.Instance, Radius, SAngle, U));
				}
			public static gpCirc SphereUIso(gpAx3 Pos,double Radius,double U)
				{
					return new gpCirc(ElSLib_SphereUIso32BF0691(Pos.Instance, Radius, U));
				}
			public static gpCirc TorusUIso(gpAx3 Pos,double MajorRadius,double MinorRadius,double U)
				{
					return new gpCirc(ElSLib_TorusUIso649F02B6(Pos.Instance, MajorRadius, MinorRadius, U));
				}
			public static gpLin PlaneVIso(gpAx3 Pos,double V)
				{
					return new gpLin(ElSLib_PlaneVIso5C6D1CB8(Pos.Instance, V));
				}
			public static gpCirc CylinderVIso(gpAx3 Pos,double Radius,double V)
				{
					return new gpCirc(ElSLib_CylinderVIso32BF0691(Pos.Instance, Radius, V));
				}
			public static gpCirc ConeVIso(gpAx3 Pos,double Radius,double SAngle,double V)
				{
					return new gpCirc(ElSLib_ConeVIso649F02B6(Pos.Instance, Radius, SAngle, V));
				}
			public static gpCirc SphereVIso(gpAx3 Pos,double Radius,double V)
				{
					return new gpCirc(ElSLib_SphereVIso32BF0691(Pos.Instance, Radius, V));
				}
			public static gpCirc TorusVIso(gpAx3 Pos,double MajorRadius,double MinorRadius,double V)
				{
					return new gpCirc(ElSLib_TorusVIso649F02B6(Pos.Instance, MajorRadius, MinorRadius, V));
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_ValueF8AFA8C9(double U,double V,IntPtr Pl);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_Value2E3DA8BC(double U,double V,IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_Value9C94886B(double U,double V,IntPtr C);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_ValueA6EAF455(double U,double V,IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_Value4E3B815B(double U,double V,IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_PlaneValueCFBE1681(double U,double V,IntPtr Pos);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_CylinderValueBACDEA69(double U,double V,IntPtr Pos,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_ConeValue5CAF831A(double U,double V,IntPtr Pos,double Radius,double SAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_SphereValueBACDEA69(double U,double V,IntPtr Pos,double Radius);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_TorusValue5CAF831A(double U,double V,IntPtr Pos,double MajorRadius,double MinorRadius);
		[DllImport("NaroOccCore.dll")]
		private static extern void ElSLib_Parameters26ED892A(IntPtr Pl,IntPtr P,ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void ElSLib_Parameters93A5F71D(IntPtr C,IntPtr P,ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void ElSLib_Parameters128A564F(IntPtr C,IntPtr P,ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void ElSLib_Parameters70B953D6(IntPtr S,IntPtr P,ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void ElSLib_Parameters820B077D(IntPtr T,IntPtr P,ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void ElSLib_PlaneParametersC11F2078(IntPtr Pos,IntPtr P,ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void ElSLib_CylinderParameters2262D7A7(IntPtr Pos,double Radius,IntPtr P,ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void ElSLib_ConeParametersE2117665(IntPtr Pos,double Radius,double SAngle,IntPtr P,ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void ElSLib_SphereParameters2262D7A7(IntPtr Pos,double Radius,IntPtr P,ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void ElSLib_TorusParametersE2117665(IntPtr Pos,double MajorRadius,double MinorRadius,IntPtr P,ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_PlaneUIso5C6D1CB8(IntPtr Pos,double U);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_CylinderUIso32BF0691(IntPtr Pos,double Radius,double U);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_ConeUIso649F02B6(IntPtr Pos,double Radius,double SAngle,double U);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_SphereUIso32BF0691(IntPtr Pos,double Radius,double U);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_TorusUIso649F02B6(IntPtr Pos,double MajorRadius,double MinorRadius,double U);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_PlaneVIso5C6D1CB8(IntPtr Pos,double V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_CylinderVIso32BF0691(IntPtr Pos,double Radius,double V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_ConeVIso649F02B6(IntPtr Pos,double Radius,double SAngle,double V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_SphereVIso32BF0691(IntPtr Pos,double Radius,double V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ElSLib_TorusVIso649F02B6(IntPtr Pos,double MajorRadius,double MinorRadius,double V);

		#region NativeInstancePtr Convert constructor

		public ElSLib() { } 

		public ElSLib(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ ElSLib_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void ElSLib_Dtor(IntPtr instance);
	}
}
