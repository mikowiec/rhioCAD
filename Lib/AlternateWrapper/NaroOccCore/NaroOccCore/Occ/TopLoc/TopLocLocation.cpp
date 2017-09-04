#include "TopLocLocation.h"
#include <TopLoc_Location.hxx>

#include <gp_Trsf.hxx>
#include <TopLoc_Datum3D.hxx>
#include <TopLoc_Location.hxx>

DECL_EXPORT void* TopLoc_Location_Ctor()
{
	return new TopLoc_Location();
}
DECL_EXPORT void* TopLoc_Location_Ctor72D78650(
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	return new TopLoc_Location(			
_T);
}
DECL_EXPORT void* TopLoc_Location_Ctor2F68E136(
	void* D)
{
		const Handle_TopLoc_Datum3D&  _D =*(const Handle_TopLoc_Datum3D *)D;
	return new TopLoc_Location(			
_D);
}
DECL_EXPORT void TopLoc_Location_Identity(void* instance)
{
	TopLoc_Location* result = (TopLoc_Location*)instance;
 	result->Identity();
}
DECL_EXPORT void* TopLoc_Location_Multiplied15DCA881(
	void* instance,
	void* Other)
{
		const TopLoc_Location &  _Other =*(const TopLoc_Location *)Other;
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return new TopLoc_Location( 	result->Multiplied(			
_Other));
}
DECL_EXPORT void* TopLoc_Location_Divided15DCA881(
	void* instance,
	void* Other)
{
		const TopLoc_Location &  _Other =*(const TopLoc_Location *)Other;
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return new TopLoc_Location( 	result->Divided(			
_Other));
}
DECL_EXPORT void* TopLoc_Location_Predivided15DCA881(
	void* instance,
	void* Other)
{
		const TopLoc_Location &  _Other =*(const TopLoc_Location *)Other;
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return new TopLoc_Location( 	result->Predivided(			
_Other));
}
DECL_EXPORT void* TopLoc_Location_PoweredE8219145(
	void* instance,
	int pwr)
{
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return new TopLoc_Location( 	result->Powered(			
pwr));
}
DECL_EXPORT int TopLoc_Location_HashCodeE8219145(
	void* instance,
	int Upper)
{
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return  	result->HashCode(			
Upper);
}
DECL_EXPORT bool TopLoc_Location_IsEqual15DCA881(
	void* instance,
	void* Other)
{
		const TopLoc_Location &  _Other =*(const TopLoc_Location *)Other;
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return  	result->IsEqual(			
_Other);
}
DECL_EXPORT bool TopLoc_Location_IsDifferent15DCA881(
	void* instance,
	void* Other)
{
		const TopLoc_Location &  _Other =*(const TopLoc_Location *)Other;
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return  	result->IsDifferent(			
_Other);
}
DECL_EXPORT bool TopLoc_Location_IsIdentity(void* instance)
{
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return 	result->IsIdentity();
}

DECL_EXPORT void* TopLoc_Location_FirstDatum(void* instance)
{
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return 	new Handle_TopLoc_Datum3D(	result->FirstDatum());
}

DECL_EXPORT int TopLoc_Location_FirstPower(void* instance)
{
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return 	result->FirstPower();
}

DECL_EXPORT void* TopLoc_Location_NextLocation(void* instance)
{
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return 	new TopLoc_Location(	result->NextLocation());
}

DECL_EXPORT void* TopLoc_Location_Transformation(void* instance)
{
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return 	new gp_Trsf(	result->Transformation());
}

DECL_EXPORT void* TopLoc_Location_Inverted(void* instance)
{
	TopLoc_Location* result = (TopLoc_Location*)instance;
	return 	new TopLoc_Location(	result->Inverted());
}

DECL_EXPORT void TopLocLocation_Dtor(void* instance)
{
	delete (TopLoc_Location*)instance;
}
