#include "BOPToolsPointBetween.h"
#include <BOPTools_PointBetween.hxx>

#include <gp_Pnt.hxx>

DECL_EXPORT void* BOPTools_PointBetween_Ctor()
{
	return new BOPTools_PointBetween();
}
DECL_EXPORT void BOPTools_PointBetween_SetUV9F0E714F(
	void* instance,
	double U,
	double V)
{
	BOPTools_PointBetween* result = (BOPTools_PointBetween*)instance;
 	result->SetUV(			
U,			
V);
}
DECL_EXPORT void BOPTools_PointBetween_UV9F0E714F(
	void* instance,
	double* U,
	double* V)
{
	BOPTools_PointBetween* result = (BOPTools_PointBetween*)instance;
 	result->UV(			
*U,			
*V);
}
DECL_EXPORT void BOPTools_PointBetween_SetParameter(void* instance, double value)
{
	BOPTools_PointBetween* result = (BOPTools_PointBetween*)instance;
		result->SetParameter(value);
}

DECL_EXPORT double BOPTools_PointBetween_Parameter(void* instance)
{
	BOPTools_PointBetween* result = (BOPTools_PointBetween*)instance;
	return 	result->Parameter();
}

DECL_EXPORT void BOPTools_PointBetween_SetPnt(void* instance, void* value)
{
	BOPTools_PointBetween* result = (BOPTools_PointBetween*)instance;
		result->SetPnt(*(const gp_Pnt *)value);
}

DECL_EXPORT void* BOPTools_PointBetween_Pnt(void* instance)
{
	BOPTools_PointBetween* result = (BOPTools_PointBetween*)instance;
	return 	new gp_Pnt(	result->Pnt());
}

DECL_EXPORT void BOPToolsPointBetween_Dtor(void* instance)
{
	delete (BOPTools_PointBetween*)instance;
}
