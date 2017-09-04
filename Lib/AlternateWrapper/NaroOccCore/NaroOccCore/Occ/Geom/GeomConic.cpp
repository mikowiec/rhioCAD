#include "GeomConic.h"
#include <Geom_Conic.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax2.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void Geom_Conic_Reverse(void* instance)
{
	Geom_Conic* result = (Geom_Conic*)(((Handle_Geom_Conic*)instance)->Access());
 	result->Reverse();
}
DECL_EXPORT bool Geom_Conic_IsCNE8219145(
	void* instance,
	int N)
{
	Geom_Conic* result = (Geom_Conic*)(((Handle_Geom_Conic*)instance)->Access());
	return  	result->IsCN(			
N);
}
DECL_EXPORT void Geom_Conic_SetAxis(void* instance, void* value)
{
	Geom_Conic* result = (Geom_Conic*)(((Handle_Geom_Conic*)instance)->Access());
		result->SetAxis(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* Geom_Conic_Axis(void* instance)
{
	Geom_Conic* result = (Geom_Conic*)(((Handle_Geom_Conic*)instance)->Access());
	return 	new gp_Ax1(	result->Axis());
}

DECL_EXPORT void Geom_Conic_SetLocation(void* instance, void* value)
{
	Geom_Conic* result = (Geom_Conic*)(((Handle_Geom_Conic*)instance)->Access());
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* Geom_Conic_Location(void* instance)
{
	Geom_Conic* result = (Geom_Conic*)(((Handle_Geom_Conic*)instance)->Access());
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void Geom_Conic_SetPosition(void* instance, void* value)
{
	Geom_Conic* result = (Geom_Conic*)(((Handle_Geom_Conic*)instance)->Access());
		result->SetPosition(*(const gp_Ax2 *)value);
}

DECL_EXPORT void* Geom_Conic_Position(void* instance)
{
	Geom_Conic* result = (Geom_Conic*)(((Handle_Geom_Conic*)instance)->Access());
	return 	new gp_Ax2(	result->Position());
}

DECL_EXPORT void* Geom_Conic_XAxis(void* instance)
{
	Geom_Conic* result = (Geom_Conic*)(((Handle_Geom_Conic*)instance)->Access());
	return 	new gp_Ax1(	result->XAxis());
}

DECL_EXPORT void* Geom_Conic_YAxis(void* instance)
{
	Geom_Conic* result = (Geom_Conic*)(((Handle_Geom_Conic*)instance)->Access());
	return 	new gp_Ax1(	result->YAxis());
}

DECL_EXPORT int Geom_Conic_Continuity(void* instance)
{
	Geom_Conic* result = (Geom_Conic*)(((Handle_Geom_Conic*)instance)->Access());
	return (int)	result->Continuity();
}

DECL_EXPORT void GeomConic_Dtor(void* instance)
{
	delete (Handle_Geom_Conic*)instance;
}
