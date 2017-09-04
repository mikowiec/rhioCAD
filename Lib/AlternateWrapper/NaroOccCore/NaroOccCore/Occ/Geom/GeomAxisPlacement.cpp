#include "GeomAxisPlacement.h"
#include <Geom_AxisPlacement.hxx>

#include <gp_Ax1.hxx>
#include <gp_Dir.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT double Geom_AxisPlacement_AngleB4DE3BBC(
	void* instance,
	void* Other)
{
		const Handle_Geom_AxisPlacement&  _Other =*(const Handle_Geom_AxisPlacement *)Other;
	Geom_AxisPlacement* result = (Geom_AxisPlacement*)(((Handle_Geom_AxisPlacement*)instance)->Access());
	return  	result->Angle(			
_Other);
}
DECL_EXPORT void Geom_AxisPlacement_SetAxis(void* instance, void* value)
{
	Geom_AxisPlacement* result = (Geom_AxisPlacement*)(((Handle_Geom_AxisPlacement*)instance)->Access());
		result->SetAxis(*(const gp_Ax1 *)value);
}

DECL_EXPORT void* Geom_AxisPlacement_Axis(void* instance)
{
	Geom_AxisPlacement* result = (Geom_AxisPlacement*)(((Handle_Geom_AxisPlacement*)instance)->Access());
	return 	new gp_Ax1(	result->Axis());
}

DECL_EXPORT void* Geom_AxisPlacement_Direction(void* instance)
{
	Geom_AxisPlacement* result = (Geom_AxisPlacement*)(((Handle_Geom_AxisPlacement*)instance)->Access());
	return 	new gp_Dir(	result->Direction());
}

DECL_EXPORT void Geom_AxisPlacement_SetLocation(void* instance, void* value)
{
	Geom_AxisPlacement* result = (Geom_AxisPlacement*)(((Handle_Geom_AxisPlacement*)instance)->Access());
		result->SetLocation(*(const gp_Pnt *)value);
}

DECL_EXPORT void* Geom_AxisPlacement_Location(void* instance)
{
	Geom_AxisPlacement* result = (Geom_AxisPlacement*)(((Handle_Geom_AxisPlacement*)instance)->Access());
	return 	new gp_Pnt(	result->Location());
}

DECL_EXPORT void GeomAxisPlacement_Dtor(void* instance)
{
	delete (Handle_Geom_AxisPlacement*)instance;
}
