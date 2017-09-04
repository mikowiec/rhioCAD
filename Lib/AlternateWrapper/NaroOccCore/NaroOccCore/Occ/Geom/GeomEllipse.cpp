#include "GeomEllipse.h"
#include <Geom_Ellipse.hxx>

#include <Geom_Geometry.hxx>
#include <gp_Ax1.hxx>
#include <gp_Elips.hxx>
#include <gp_Pnt.hxx>
#include <gp_Vec.hxx>

DECL_EXPORT void* Geom_Ellipse_CtorAA0BF3BF(
	void* E)
{
		const gp_Elips &  _E =*(const gp_Elips *)E;
	return new Handle_Geom_Ellipse(new Geom_Ellipse(			
_E));
}
DECL_EXPORT void* Geom_Ellipse_CtorB1A3BD2A(
	void* A2,
	double MajorRadius,
	double MinorRadius)
{
		const gp_Ax2 &  _A2 =*(const gp_Ax2 *)A2;
	return new Handle_Geom_Ellipse(new Geom_Ellipse(			
_A2,			
MajorRadius,			
MinorRadius));
}
DECL_EXPORT double Geom_Ellipse_ReversedParameterD82819F3(
	void* instance,
	double U)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return  	result->ReversedParameter(			
U);
}
DECL_EXPORT void Geom_Ellipse_D053A5A2C1(
	void* instance,
	double U,
	void* P)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
 	result->D0(			
U,			
_P);
}
DECL_EXPORT void Geom_Ellipse_D11387A81(
	void* instance,
	double U,
	void* P,
	void* V1)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
 	result->D1(			
U,			
_P,			
_V1);
}
DECL_EXPORT void Geom_Ellipse_D227877840(
	void* instance,
	double U,
	void* P,
	void* V1,
	void* V2)
{
		gp_Pnt &  _P =*(gp_Pnt *)P;
		gp_Vec &  _V1 =*(gp_Vec *)V1;
		gp_Vec &  _V2 =*(gp_Vec *)V2;
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
 	result->D2(			
U,			
_P,			
_V1,			
_V2);
}
DECL_EXPORT void Geom_Ellipse_D356E36E6F(
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
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
 	result->D3(			
U,			
_P,			
_V1,			
_V2,			
_V3);
}
DECL_EXPORT void* Geom_Ellipse_DN2935ABDE(
	void* instance,
	double U,
	int N)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return new gp_Vec( 	result->DN(			
U,			
N));
}
DECL_EXPORT void Geom_Ellipse_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
 	result->Transform(			
_T);
}
DECL_EXPORT void Geom_Ellipse_SetElips(void* instance, void* value)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
		result->SetElips(*(const gp_Elips *)value);
}

DECL_EXPORT void* Geom_Ellipse_Elips(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	new gp_Elips(	result->Elips());
}

DECL_EXPORT void* Geom_Ellipse_Directrix1(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	new gp_Ax1(	result->Directrix1());
}

DECL_EXPORT void* Geom_Ellipse_Directrix2(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	new gp_Ax1(	result->Directrix2());
}

DECL_EXPORT double Geom_Ellipse_Eccentricity(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	result->Eccentricity();
}

DECL_EXPORT double Geom_Ellipse_Focal(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	result->Focal();
}

DECL_EXPORT void* Geom_Ellipse_Focus1(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	new gp_Pnt(	result->Focus1());
}

DECL_EXPORT void* Geom_Ellipse_Focus2(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	new gp_Pnt(	result->Focus2());
}

DECL_EXPORT void Geom_Ellipse_SetMajorRadius(void* instance, double value)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
		result->SetMajorRadius(value);
}

DECL_EXPORT double Geom_Ellipse_MajorRadius(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	result->MajorRadius();
}

DECL_EXPORT void Geom_Ellipse_SetMinorRadius(void* instance, double value)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
		result->SetMinorRadius(value);
}

DECL_EXPORT double Geom_Ellipse_MinorRadius(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	result->MinorRadius();
}

DECL_EXPORT double Geom_Ellipse_Parameter(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	result->Parameter();
}

DECL_EXPORT double Geom_Ellipse_FirstParameter(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	result->FirstParameter();
}

DECL_EXPORT double Geom_Ellipse_LastParameter(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	result->LastParameter();
}

DECL_EXPORT bool Geom_Ellipse_IsClosed(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	result->IsClosed();
}

DECL_EXPORT bool Geom_Ellipse_IsPeriodic(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	result->IsPeriodic();
}

DECL_EXPORT void* Geom_Ellipse_Copy(void* instance)
{
	Geom_Ellipse* result = (Geom_Ellipse*)(((Handle_Geom_Ellipse*)instance)->Access());
	return 	new Handle_Geom_Geometry(	result->Copy());
}

DECL_EXPORT void GeomEllipse_Dtor(void* instance)
{
	delete (Handle_Geom_Ellipse*)instance;
}
