#include "GeomPlane.h"
#include <Geom_Plane.hxx>

#include <Geom_Curve.hxx>
#include <Geom_Geometry.hxx>
#include <gp_GTrsf2d.hxx>
#include <gp_Pln.hxx>
#include <gp_Vec.hxx>

DECL_EXPORT void* Geom_Plane_Ctor1B3CAD05(
	void* A3)
{
		const gp_Ax3 &  _A3 =*(const gp_Ax3 *)A3;
	return new Handle_Geom_Plane(new Geom_Plane(			
_A3));
}
DECL_EXPORT void* Geom_Plane_Ctor9914D2AD(
	void* Pl)
{
		const gp_Pln &  _Pl =*(const gp_Pln *)Pl;
	return new Handle_Geom_Plane(new Geom_Plane(			
_Pl));
}
DECL_EXPORT void* Geom_Plane_CtorE13B639C(
	void* P,
	void* V)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _V =*(const gp_Dir *)V;
	return new Handle_Geom_Plane(new Geom_Plane(			
_P,			
_V));
}
DECL_EXPORT void* Geom_Plane_CtorC2777E0C(
	double A,
	double B,
	double C,
	double D)
{
	return new Handle_Geom_Plane(new Geom_Plane(			
A,			
B,			
C,			
D));
}
DECL_EXPORT void Geom_Plane_UReverse(void* instance)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
 	result->UReverse();
}
DECL_EXPORT double Geom_Plane_UReversedParameterD82819F3(
	void* instance,
	double U)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
	return  	result->UReversedParameter(			
U);
}
DECL_EXPORT void Geom_Plane_VReverse(void* instance)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
 	result->VReverse();
}
DECL_EXPORT double Geom_Plane_VReversedParameterD82819F3(
	void* instance,
	double V)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
	return  	result->VReversedParameter(			
V);
}
DECL_EXPORT void Geom_Plane_TransformParametersFD94EFCC(
	void* instance,
	double* U,
	double* V,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
 	result->TransformParameters(			
*U,			
*V,			
_T);
}
DECL_EXPORT void* Geom_Plane_ParametricTransformation72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
	return new gp_GTrsf2d( 	result->ParametricTransformation(			
_T));
}
DECL_EXPORT void Geom_Plane_BoundsC2777E0C(
	void* instance,
	double* U1,
	double* U2,
	double* V1,
	double* V2)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
 	result->Bounds(			
*U1,			
*U2,			
*V1,			
*V2);
}
DECL_EXPORT void Geom_Plane_CoefficientsC2777E0C(
	void* instance,
	double* A,
	double* B,
	double* C,
	double* D)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
 	result->Coefficients(			
*A,			
*B,			
*C,			
*D);
}
DECL_EXPORT void* Geom_Plane_UIsoD82819F3(
	void* instance,
	double U)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
	return new Handle_Geom_Curve( 	result->UIso(			
U));
}
DECL_EXPORT void* Geom_Plane_VIsoD82819F3(
	void* instance,
	double V)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
	return new Handle_Geom_Curve( 	result->VIso(			
V));
}
DECL_EXPORT void Geom_Plane_D0C89A646B(
	void* instance,
	double U,
	double V,
	void* P)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
 	result->D0(			
U,			
V,			
_P);
}
DECL_EXPORT void Geom_Plane_D14153CD1A(
	void* instance,
	double U,
	double V,
	void* P,
	void* D1U,
	void* D1V)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _D1U =*(gp_Vec *)D1U;
		gp_Vec &  _D1V =*(gp_Vec *)D1V;
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
 	result->D1(			
U,			
V,			
_P,			
_D1U,			
_D1V);
}
DECL_EXPORT void Geom_Plane_D2E9F600EF(
	void* instance,
	double U,
	double V,
	void* P,
	void* D1U,
	void* D1V,
	void* D2U,
	void* D2V,
	void* D2UV)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _D1U =*(gp_Vec *)D1U;
		gp_Vec &  _D1V =*(gp_Vec *)D1V;
		gp_Vec &  _D2U =*(gp_Vec *)D2U;
		gp_Vec &  _D2V =*(gp_Vec *)D2V;
		gp_Vec &  _D2UV =*(gp_Vec *)D2UV;
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
 	result->D2(			
U,			
V,			
_P,			
_D1U,			
_D1V,			
_D2U,			
_D2V,			
_D2UV);
}
DECL_EXPORT void Geom_Plane_D3B100120D(
	void* instance,
	double U,
	double V,
	void* P,
	void* D1U,
	void* D1V,
	void* D2U,
	void* D2V,
	void* D2UV,
	void* D3U,
	void* D3V,
	void* D3UUV,
	void* D3UVV)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _D1U =*(gp_Vec *)D1U;
		gp_Vec &  _D1V =*(gp_Vec *)D1V;
		gp_Vec &  _D2U =*(gp_Vec *)D2U;
		gp_Vec &  _D2V =*(gp_Vec *)D2V;
		gp_Vec &  _D2UV =*(gp_Vec *)D2UV;
		gp_Vec &  _D3U =*(gp_Vec *)D3U;
		gp_Vec &  _D3V =*(gp_Vec *)D3V;
		gp_Vec &  _D3UUV =*(gp_Vec *)D3UUV;
		gp_Vec &  _D3UVV =*(gp_Vec *)D3UVV;
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
 	result->D3(			
U,			
V,			
_P,			
_D1U,			
_D1V,			
_D2U,			
_D2V,			
_D2UV,			
_D3U,			
_D3V,			
_D3UUV,			
_D3UVV);
}
DECL_EXPORT void* Geom_Plane_DN852507E(
	void* instance,
	double U,
	double V,
	int Nu,
	int Nv)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
	return new gp_Vec( 	result->DN(			
U,			
V,			
Nu,			
Nv));
}
DECL_EXPORT void Geom_Plane_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
 	result->Transform(			
_T);
}
DECL_EXPORT void Geom_Plane_SetPln(void* instance, void* value)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
		result->SetPln(*(const gp_Pln *)value);
}

DECL_EXPORT void* Geom_Plane_Pln(void* instance)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
	return 	new gp_Pln(	result->Pln());
}

DECL_EXPORT bool Geom_Plane_IsUClosed(void* instance)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
	return 	result->IsUClosed();
}

DECL_EXPORT bool Geom_Plane_IsVClosed(void* instance)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
	return 	result->IsVClosed();
}

DECL_EXPORT bool Geom_Plane_IsUPeriodic(void* instance)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
	return 	result->IsUPeriodic();
}

DECL_EXPORT bool Geom_Plane_IsVPeriodic(void* instance)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
	return 	result->IsVPeriodic();
}

DECL_EXPORT void* Geom_Plane_Copy(void* instance)
{
	Geom_Plane* result = (Geom_Plane*)(((Handle_Geom_Plane*)instance)->Access());
	return 	new Handle_Geom_Geometry(	result->Copy());
}

DECL_EXPORT void GeomPlane_Dtor(void* instance)
{
	delete (Handle_Geom_Plane*)instance;
}
