#include "GeomAxis1Placement.h"
#include <Geom_Axis1Placement.hxx>

#include <Geom_Axis1Placement.hxx>
#include <Geom_Geometry.hxx>
#include <gp_Ax1.hxx>

DECL_EXPORT void* Geom_Axis1Placement_Ctor608B963B(
	void* A1)
{
		const gp_Ax1 &  _A1 =*(const gp_Ax1 *)A1;
	return new Handle_Geom_Axis1Placement(new Geom_Axis1Placement(			
_A1));
}
DECL_EXPORT void* Geom_Axis1Placement_CtorE13B639C(
	void* P,
	void* V)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
		const gp_Dir &  _V =*(const gp_Dir *)V;
	return new Handle_Geom_Axis1Placement(new Geom_Axis1Placement(			
_P,			
_V));
}
DECL_EXPORT void Geom_Axis1Placement_Reverse(void* instance)
{
	Geom_Axis1Placement* result = (Geom_Axis1Placement*)(((Handle_Geom_Axis1Placement*)instance)->Access());
 	result->Reverse();
}
DECL_EXPORT void Geom_Axis1Placement_Transform72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Axis1Placement* result = (Geom_Axis1Placement*)(((Handle_Geom_Axis1Placement*)instance)->Access());
 	result->Transform(			
_T);
}
DECL_EXPORT void* Geom_Axis1Placement_Ax1(void* instance)
{
	Geom_Axis1Placement* result = (Geom_Axis1Placement*)(((Handle_Geom_Axis1Placement*)instance)->Access());
	return 	new gp_Ax1(	result->Ax1());
}

DECL_EXPORT void* Geom_Axis1Placement_Reversed(void* instance)
{
	Geom_Axis1Placement* result = (Geom_Axis1Placement*)(((Handle_Geom_Axis1Placement*)instance)->Access());
	return 	new Handle_Geom_Axis1Placement(	result->Reversed());
}

DECL_EXPORT void Geom_Axis1Placement_SetDirection(void* instance, void* value)
{
	Geom_Axis1Placement* result = (Geom_Axis1Placement*)(((Handle_Geom_Axis1Placement*)instance)->Access());
		result->SetDirection(*(const gp_Dir *)value);
}

DECL_EXPORT void* Geom_Axis1Placement_Copy(void* instance)
{
	Geom_Axis1Placement* result = (Geom_Axis1Placement*)(((Handle_Geom_Axis1Placement*)instance)->Access());
	return 	new Handle_Geom_Geometry(	result->Copy());
}

DECL_EXPORT void GeomAxis1Placement_Dtor(void* instance)
{
	delete (Handle_Geom_Axis1Placement*)instance;
}
