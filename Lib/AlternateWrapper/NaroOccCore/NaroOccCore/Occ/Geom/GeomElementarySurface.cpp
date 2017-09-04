#include "GeomElementarySurface.h"
#include <Geom_ElementarySurface.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax3.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void Geom_ElementarySurface_UReverse(void* instance)
{
	Geom_ElementarySurface* result = (Geom_ElementarySurface*)(((Handle_Geom_ElementarySurface*)instance)->Access());
 	result->UReverse();
}
DECL_EXPORT void Geom_ElementarySurface_VReverse(void* instance)
{
	Geom_ElementarySurface* result = (Geom_ElementarySurface*)(((Handle_Geom_ElementarySurface*)instance)->Access());
 	result->VReverse();
}
DECL_EXPORT bool Geom_ElementarySurface_IsCNuE8219145(
	void* instance,
	int N)
{
	Geom_ElementarySurface* result = (Geom_ElementarySurface*)(((Handle_Geom_ElementarySurface*)instance)->Access());
	return  	result->IsCNu(			
N);
}
DECL_EXPORT bool Geom_ElementarySurface_IsCNvE8219145(
	void* instance,
	int N)
{
	Geom_ElementarySurface* result = (Geom_ElementarySurface*)(((Handle_Geom_ElementarySurface*)instance)->Access());
	return  	result->IsCNv(			
N);
}
DECL_EXPORT void Geom_ElementarySurface_SetAxis(void* instance, void* value)
{
	Geom_ElementarySurface* result = (Geom_ElementarySurface*)(((Handle_Geom_ElementarySurface*)instance)->Access());
		result->SetAxis(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* Geom_ElementarySurface_Axis(void* instance)
{
	Geom_ElementarySurface* result = (Geom_ElementarySurface*)(((Handle_Geom_ElementarySurface*)instance)->Access());
	return 	new gp_Ax1(	result->Axis());
}

DECL_EXPORT void Geom_ElementarySurface_SetLocation(void* instance, void* value)
{
	Geom_ElementarySurface* result = (Geom_ElementarySurface*)(((Handle_Geom_ElementarySurface*)instance)->Access());
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* Geom_ElementarySurface_Location(void* instance)
{
	Geom_ElementarySurface* result = (Geom_ElementarySurface*)(((Handle_Geom_ElementarySurface*)instance)->Access());
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void Geom_ElementarySurface_SetPosition(void* instance, void* value)
{
	Geom_ElementarySurface* result = (Geom_ElementarySurface*)(((Handle_Geom_ElementarySurface*)instance)->Access());
		result->SetPosition(*(const gp_Ax3 *)value);
}

DECL_EXPORT void* Geom_ElementarySurface_Position(void* instance)
{
	Geom_ElementarySurface* result = (Geom_ElementarySurface*)(((Handle_Geom_ElementarySurface*)instance)->Access());
	return 	new gp_Ax3(	result->Position());
}

DECL_EXPORT int Geom_ElementarySurface_Continuity(void* instance)
{
	Geom_ElementarySurface* result = (Geom_ElementarySurface*)(((Handle_Geom_ElementarySurface*)instance)->Access());
	return (int)	result->Continuity();
}

DECL_EXPORT void GeomElementarySurface_Dtor(void* instance)
{
	delete (Handle_Geom_ElementarySurface*)instance;
}
