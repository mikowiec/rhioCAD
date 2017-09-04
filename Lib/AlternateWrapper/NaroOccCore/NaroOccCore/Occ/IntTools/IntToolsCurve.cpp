#include "IntToolsCurve.h"
#include <IntTools_Curve.hxx>

#include <Geom_Curve.hxx>

DECL_EXPORT void* IntTools_Curve_Ctor()
{
	return new IntTools_Curve();
}
DECL_EXPORT void IntTools_Curve_BoundsB51F241F(
	void* instance,
	double* aT1,
	double* aT2,
	void* aP1,
	void* aP2)
{
		 gp_Pnt &  _aP1 =*( gp_Pnt *)aP1;
		 gp_Pnt &  _aP2 =*( gp_Pnt *)aP2;
	IntTools_Curve* result = (IntTools_Curve*)instance;
 	result->Bounds(			
*aT1,			
*aT2,			
_aP1,			
_aP2);
}
DECL_EXPORT bool IntTools_Curve_D053A5A2C1(
	void* instance,
	double* aT1,
	void* aP1)
{
		 gp_Pnt &  _aP1 =*( gp_Pnt *)aP1;
	IntTools_Curve* result = (IntTools_Curve*)instance;
	return  	result->D0(			
*aT1,			
_aP1);
}
DECL_EXPORT void IntTools_Curve_SetCurve(void* instance, void* value)
{
	IntTools_Curve* result = (IntTools_Curve*)instance;
		result->SetCurve(*(const Handle_Geom_Curve *)value);
}

DECL_EXPORT void* IntTools_Curve_Curve(void* instance)
{
	IntTools_Curve* result = (IntTools_Curve*)instance;
	return 	new Handle_Geom_Curve(	result->Curve());
}

DECL_EXPORT bool IntTools_Curve_HasBounds(void* instance)
{
	IntTools_Curve* result = (IntTools_Curve*)instance;
	return 	result->HasBounds();
}

DECL_EXPORT int IntTools_Curve_Type(void* instance)
{
	IntTools_Curve* result = (IntTools_Curve*)instance;
	return (int)	result->Type();
}

DECL_EXPORT void IntToolsCurve_Dtor(void* instance)
{
	delete (IntTools_Curve*)instance;
}
