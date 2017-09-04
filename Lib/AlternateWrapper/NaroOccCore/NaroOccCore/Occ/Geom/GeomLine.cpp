#include "GeomLine.h"
#include <Geom_Line.hxx>

#include <Geom_Geometry.hxx>
#include <gp_Ax1.hxx>
#include <gp_Lin.hxx>
#include <gp_Vec.hxx>

DECL_EXPORT void* Geom_Line_Ctor608B963B(
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	return new Handle_Geom_Line(new Geom_Line(			
_A1));
}
DECL_EXPORT void* Geom_Line_Ctor9917D291(
	void* L)
{
		const gp_Lin &  _L =*(const gp_Lin *)L;
	return new Handle_Geom_Line(new Geom_Line(			
_L));
}
DECL_EXPORT void* Geom_Line_CtorE13B639C(
	void* P,
	void* V)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _V =*(const gp_Dir *)V;
	return new Handle_Geom_Line(new Geom_Line(			
_P,			
_V));
}
DECL_EXPORT void Geom_Line_Reverse(void* instance)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
 	result->Reverse();
}
DECL_EXPORT double Geom_Line_ReversedParameterD82819F3(
	void* instance,
	double U)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return  	result->ReversedParameter(			
U);
}
DECL_EXPORT bool Geom_Line_IsCNE8219145(
	void* instance,
	int N)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return  	result->IsCN(			
N);
}
DECL_EXPORT void Geom_Line_D053A5A2C1(
	void* instance,
	double U,
	void* P)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
 	result->D0(			
U,			
_P);
}
DECL_EXPORT void Geom_Line_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V1)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
 	result->D1(			
U,			
_P,			
_V1);
}
DECL_EXPORT void Geom_Line_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
		gp_Vec &  _V2 =*(gp_Vec *)V2;
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
 	result->D2(			
U,			
_P,			
_V1,			
_V2);
}
DECL_EXPORT void Geom_Line_D356E36E6F(
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
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
 	result->D3(			
U,			
_P,			
_V1,			
_V2,			
_V3);
}
DECL_EXPORT void* Geom_Line_DN2935ABDE(
	void* instance,
	double U,
	int N)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return new gp_Vec( 	result->DN(			
U,			
N));
}
DECL_EXPORT void Geom_Line_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
 	result->Transform(			
_T);
}
DECL_EXPORT double Geom_Line_TransformedParameter9B95D054(
	void* instance,
	double U,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return  	result->TransformedParameter(			
U,			
_T);
}
DECL_EXPORT double Geom_Line_ParametricTransformation72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return  	result->ParametricTransformation(			
_T);
}
DECL_EXPORT void Geom_Line_SetDirection(void* instance, void* value)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
		result->SetDirection(*(const gp_Dir *)value);
}

DECL_EXPORT void Geom_Line_SetLocation(void* instance, void* value)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void Geom_Line_SetLin(void* instance, void* value)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
		result->SetLin(*(const gp_Lin *)value);
}

DECL_EXPORT void* Geom_Line_Lin(void* instance)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return 	new gp_Lin(	result->Lin());
}

DECL_EXPORT void Geom_Line_SetPosition(void* instance, void* value)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
		result->SetPosition(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* Geom_Line_Position(void* instance)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return 	new gp_Ax1(	result->Position());
}

DECL_EXPORT double Geom_Line_FirstParameter(void* instance)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return 	result->FirstParameter();
}

DECL_EXPORT double Geom_Line_LastParameter(void* instance)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return 	result->LastParameter();
}

DECL_EXPORT bool Geom_Line_IsClosed(void* instance)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return 	result->IsClosed();
}

DECL_EXPORT bool Geom_Line_IsPeriodic(void* instance)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return 	result->IsPeriodic();
}

DECL_EXPORT int Geom_Line_Continuity(void* instance)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return (int)	result->Continuity();
}

DECL_EXPORT void* Geom_Line_Copy(void* instance)
{
	Geom_Line* result = (Geom_Line*)(((Handle_Geom_Line*)instance)->Access());
	return 	new Handle_Geom_Geometry(	result->Copy());
}

DECL_EXPORT void GeomLine_Dtor(void* instance)
{
	delete (Handle_Geom_Line*)instance;
}
