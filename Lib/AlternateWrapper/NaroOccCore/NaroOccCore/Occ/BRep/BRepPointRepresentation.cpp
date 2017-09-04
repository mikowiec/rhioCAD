#include "BRepPointRepresentation.h"
#include <BRep_PointRepresentation.hxx>

#include <Geom_Curve.hxx>
#include <Geom_Surface.hxx>
#include <TopLoc_Location.hxx>

DECL_EXPORT bool BRep_PointRepresentation_IsPointOnCurve(void* instance)
{
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
	return  	result->IsPointOnCurve();
}
DECL_EXPORT bool BRep_PointRepresentation_IsPointOnCurveOnSurface(void* instance)
{
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
	return  	result->IsPointOnCurveOnSurface();
}
DECL_EXPORT bool BRep_PointRepresentation_IsPointOnSurface(void* instance)
{
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
	return  	result->IsPointOnSurface();
}
DECL_EXPORT bool BRep_PointRepresentation_IsPointOnCurveB3769532(
	void* instance,
	void* C,
	void* L)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
	return  	result->IsPointOnCurve(			
_C,			
_L);
}
DECL_EXPORT bool BRep_PointRepresentation_IsPointOnSurface7C521807(
	void* instance,
	void* S,
	void* L)
{
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
	return  	result->IsPointOnSurface(			
_S,			
_L);
}
DECL_EXPORT void* BRep_PointRepresentation_Location(void* instance)
{
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
	return new TopLoc_Location( 	result->Location());
}
DECL_EXPORT void BRep_PointRepresentation_Location15DCA881(
	void* instance,
	void* L)
{
		const TopLoc_Location &  _L =*(const TopLoc_Location *)L;
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
 	result->Location(			
_L);
}
DECL_EXPORT double BRep_PointRepresentation_Parameter(void* instance)
{
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
	return  	result->Parameter();
}
DECL_EXPORT void BRep_PointRepresentation_ParameterD82819F3(
	void* instance,
	double P)
{
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
 	result->Parameter(			
P);
}
DECL_EXPORT double BRep_PointRepresentation_Parameter2(void* instance)
{
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
	return  	result->Parameter2();
}
DECL_EXPORT void BRep_PointRepresentation_Parameter2D82819F3(
	void* instance,
	double P)
{
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
 	result->Parameter2(			
P);
}
DECL_EXPORT void* BRep_PointRepresentation_Curve(void* instance)
{
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
	return new Handle_Geom_Curve( 	result->Curve());
}
DECL_EXPORT void BRep_PointRepresentation_CurveFF608AE4(
	void* instance,
	void* C)
{
		const Handle_Geom_Curve&  _C =*(const Handle_Geom_Curve *)C;
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
 	result->Curve(			
_C);
}
DECL_EXPORT void* BRep_PointRepresentation_Surface(void* instance)
{
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
	return new Handle_Geom_Surface( 	result->Surface());
}
DECL_EXPORT void BRep_PointRepresentation_Surface9001466F(
	void* instance,
	void* S)
{
		const Handle_Geom_Surface&  _S =*(const Handle_Geom_Surface *)S;
	BRep_PointRepresentation* result = (BRep_PointRepresentation*)(((Handle_BRep_PointRepresentation*)instance)->Access());
 	result->Surface(			
_S);
}
DECL_EXPORT void BRepPointRepresentation_Dtor(void* instance)
{
	delete (Handle_BRep_PointRepresentation*)instance;
}
