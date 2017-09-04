#include "TopLocDatum3D.h"
#include <TopLoc_Datum3D.hxx>

#include <gp_Trsf.hxx>

DECL_EXPORT void* TopLoc_Datum3D_Ctor()
{
	return new Handle_TopLoc_Datum3D(new TopLoc_Datum3D());
}
DECL_EXPORT void* TopLoc_Datum3D_Ctor72D78650(
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	return new Handle_TopLoc_Datum3D(new TopLoc_Datum3D(			
_T));
}
DECL_EXPORT void* TopLoc_Datum3D_Transformation(void* instance)
{
	TopLoc_Datum3D* result = (TopLoc_Datum3D*)(((Handle_TopLoc_Datum3D*)instance)->Access());
	return 	new gp_Trsf(	result->Transformation());
}

DECL_EXPORT void TopLocDatum3D_Dtor(void* instance)
{
	delete (Handle_TopLoc_Datum3D*)instance;
}
