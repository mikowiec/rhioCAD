#include "GeomTrimmedCurve.h"
#include <Geom_TrimmedCurve.hxx>

#include <Geom_Curve.hxx>
#include <Geom_Geometry.hxx>
#include <gp_Pnt.hxx>
#include <gp_Vec.hxx>

DECL_EXPORT void* Geom_TrimmedCurve_Ctor39C18CEB(
	void* C,
	double U1,
	double U2,
	bool Sense)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
	return new Handle_Geom_TrimmedCurve(new Geom_TrimmedCurve(			
_C,			
U1,			
U2,			
Sense));
}
DECL_EXPORT void Geom_TrimmedCurve_Reverse(void* instance)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
 	result->Reverse();
}
DECL_EXPORT double Geom_TrimmedCurve_ReversedParameterD82819F3(
	void* instance,
	double U)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return  	result->ReversedParameter(			
U);
}
DECL_EXPORT void Geom_TrimmedCurve_SetTrim947352B1(
	void* instance,
	double U1,
	double U2,
	bool Sense)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
 	result->SetTrim(			
U1,			
U2,			
Sense);
}
DECL_EXPORT bool Geom_TrimmedCurve_IsCNE8219145(
	void* instance,
	int N)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return  	result->IsCN(			
N);
}
DECL_EXPORT void Geom_TrimmedCurve_D053A5A2C1(
	void* instance,
	double U,
	void* P)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
 	result->D0(			
U,			
_P);
}
DECL_EXPORT void Geom_TrimmedCurve_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V1)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
 	result->D1(			
U,			
_P,			
_V1);
}
DECL_EXPORT void Geom_TrimmedCurve_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
		gp_Vec &  _V2 =*(gp_Vec *)V2;
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
 	result->D2(			
U,			
_P,			
_V1,			
_V2);
}
DECL_EXPORT void Geom_TrimmedCurve_D356E36E6F(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2,
	void* V3)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
		gp_Vec &  _V2 =*(gp_Vec *)V2;
		gp_Vec &  _V3 =*(gp_Vec *)V3;
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
 	result->D3(			
U,			
_P,			
_V1,			
_V2,			
_V3);
}
DECL_EXPORT void* Geom_TrimmedCurve_DN2935ABDE(
	void* instance,
	double U,
	int N)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return new gp_Vec( 	result->DN(			
U,			
N));
}
DECL_EXPORT void Geom_TrimmedCurve_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
 	result->Transform(			
_T);
}
DECL_EXPORT double Geom_TrimmedCurve_TransformedParameter9B95D054(
	void* instance,
	double U,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return  	result->TransformedParameter(			
U,			
_T);
}
DECL_EXPORT double Geom_TrimmedCurve_ParametricTransformation72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return  	result->ParametricTransformation(			
_T);
}
DECL_EXPORT void* Geom_TrimmedCurve_BasisCurve(void* instance)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return 	new Handle_Geom_Curve(	result->BasisCurve());
}

DECL_EXPORT int Geom_TrimmedCurve_Continuity(void* instance)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return (int)	result->Continuity();
}

DECL_EXPORT void* Geom_TrimmedCurve_EndPoint(void* instance)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return 	new gp_Pnt(	result->EndPoint());
}

DECL_EXPORT double Geom_TrimmedCurve_FirstParameter(void* instance)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return 	result->FirstParameter();
}

DECL_EXPORT bool Geom_TrimmedCurve_IsClosed(void* instance)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return 	result->IsClosed();
}

DECL_EXPORT bool Geom_TrimmedCurve_IsPeriodic(void* instance)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return 	result->IsPeriodic();
}

DECL_EXPORT double Geom_TrimmedCurve_Period(void* instance)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return 	result->Period();
}

DECL_EXPORT double Geom_TrimmedCurve_LastParameter(void* instance)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return 	result->LastParameter();
}

DECL_EXPORT void* Geom_TrimmedCurve_StartPoint(void* instance)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return 	new gp_Pnt(	result->StartPoint());
}

DECL_EXPORT void* Geom_TrimmedCurve_Copy(void* instance)
{
	Geom_TrimmedCurve* result = (Geom_TrimmedCurve*)(((Handle_Geom_TrimmedCurve*)instance)->Access());
	return 	new Handle_Geom_Geometry(	result->Copy());
}

DECL_EXPORT void GeomTrimmedCurve_Dtor(void* instance)
{
	delete (Handle_Geom_TrimmedCurve*)instance;
}
