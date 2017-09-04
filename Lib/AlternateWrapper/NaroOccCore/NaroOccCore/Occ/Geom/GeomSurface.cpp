#include "GeomSurface.h"
#include <Geom_Surface.hxx>

#include <Geom_Surface.hxx>
#include <gp_GTrsf2d.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT void Geom_Surface_TransformParametersFD94EFCC(
	void* instance,
	double* U,
	double* V,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Surface* result = (Geom_Surface*)(((Handle_Geom_Surface*)instance)->Access());
 	result->TransformParameters(			
*U,			
*V,			
_T);
}
DECL_EXPORT void* Geom_Surface_ParametricTransformation72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Surface* result = (Geom_Surface*)(((Handle_Geom_Surface*)instance)->Access());
	return new gp_GTrsf2d( 	result->ParametricTransformation(			
_T));
}
DECL_EXPORT void* Geom_Surface_Value9F0E714F(
	void* instance,
	double U,
	double V)
{
	Geom_Surface* result = (Geom_Surface*)(((Handle_Geom_Surface*)instance)->Access());
	return new gp_Pnt( 	result->Value(			
U,			
V));
}
DECL_EXPORT void* Geom_Surface_UReversed(void* instance)
{
	Geom_Surface* result = (Geom_Surface*)(((Handle_Geom_Surface*)instance)->Access());
	return 	new Handle_Geom_Surface(	result->UReversed());
}

DECL_EXPORT void* Geom_Surface_VReversed(void* instance)
{
	Geom_Surface* result = (Geom_Surface*)(((Handle_Geom_Surface*)instance)->Access());
	return 	new Handle_Geom_Surface(	result->VReversed());
}

DECL_EXPORT double Geom_Surface_UPeriod(void* instance)
{
	Geom_Surface* result = (Geom_Surface*)(((Handle_Geom_Surface*)instance)->Access());
	return 	result->UPeriod();
}

DECL_EXPORT double Geom_Surface_VPeriod(void* instance)
{
	Geom_Surface* result = (Geom_Surface*)(((Handle_Geom_Surface*)instance)->Access());
	return 	result->VPeriod();
}

DECL_EXPORT void GeomSurface_Dtor(void* instance)
{
	delete (Handle_Geom_Surface*)instance;
}
