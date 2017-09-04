#include "GeomCircle.h"
#include <Geom_Circle.hxx>

#include <Geom_Geometry.hxx>
#include <gp_Circ.hxx>
#include <gp_Vec.hxx>

DECL_EXPORT void* Geom_Circle_Ctor727811A8(
	void* C)
{
		const gp_Circ &  _C =*(const gp_Circ *)C;
	return new Handle_Geom_Circle(new Geom_Circle(			
_C));
}
DECL_EXPORT void* Geom_Circle_Ctor673FA07D(
	void* A2,
	double Radius)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	return new Handle_Geom_Circle(new Geom_Circle(			
_A2,			
Radius));
}
DECL_EXPORT double Geom_Circle_ReversedParameterD82819F3(
	void* instance,
	double U)
{
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
	return  	result->ReversedParameter(			
U);
}
DECL_EXPORT void Geom_Circle_D053A5A2C1(
	void* instance,
	double U,
	void* P)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
 	result->D0(			
U,			
_P);
}
DECL_EXPORT void Geom_Circle_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V1)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
 	result->D1(			
U,			
_P,			
_V1);
}
DECL_EXPORT void Geom_Circle_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
		gp_Vec &  _V2 =*(gp_Vec *)V2;
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
 	result->D2(			
U,			
_P,			
_V1,			
_V2);
}
DECL_EXPORT void Geom_Circle_D356E36E6F(
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
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
 	result->D3(			
U,			
_P,			
_V1,			
_V2,			
_V3);
}
DECL_EXPORT void* Geom_Circle_DN2935ABDE(
	void* instance,
	double U,
	int N)
{
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
	return new gp_Vec( 	result->DN(			
U,			
N));
}
DECL_EXPORT void Geom_Circle_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
 	result->Transform(			
_T);
}
DECL_EXPORT void Geom_Circle_SetCirc(void* instance, void* value)
{
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
		result->SetCirc(*(const gp_Circ *)value);
}

DECL_EXPORT void* Geom_Circle_Circ(void* instance)
{
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
	return 	new gp_Circ(	result->Circ());
}

DECL_EXPORT void Geom_Circle_SetRadius(void* instance, double value)
{
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
		result->SetRadius(value);
}

DECL_EXPORT double Geom_Circle_Radius(void* instance)
{
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
	return 	result->Radius();
}

DECL_EXPORT double Geom_Circle_Eccentricity(void* instance)
{
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
	return 	result->Eccentricity();
}

DECL_EXPORT double Geom_Circle_FirstParameter(void* instance)
{
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
	return 	result->FirstParameter();
}

DECL_EXPORT double Geom_Circle_LastParameter(void* instance)
{
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
	return 	result->LastParameter();
}

DECL_EXPORT bool Geom_Circle_IsClosed(void* instance)
{
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
	return 	result->IsClosed();
}

DECL_EXPORT bool Geom_Circle_IsPeriodic(void* instance)
{
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
	return 	result->IsPeriodic();
}

DECL_EXPORT void* Geom_Circle_Copy(void* instance)
{
	Geom_Circle* result = (Geom_Circle*)(((Handle_Geom_Circle*)instance)->Access());
	return 	new Handle_Geom_Geometry(	result->Copy());
}

DECL_EXPORT void GeomCircle_Dtor(void* instance)
{
	delete (Handle_Geom_Circle*)instance;
}
