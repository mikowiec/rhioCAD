#include "GeomCurve.h"
#include <Geom_Curve.hxx>

#include <Geom_Curve.hxx>
#include <gp_Pnt.hxx>

DECL_EXPORT double Geom_Curve_TransformedParameter9B95D054(
	void* instance,
	double U,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Curve* result = (Geom_Curve*)(((Handle_Geom_Curve*)instance)->Access());
	return  	result->TransformedParameter(			
U,			
_T);
}
DECL_EXPORT double Geom_Curve_ParametricTransformation72D78650(
	void* instance,
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	Geom_Curve* result = (Geom_Curve*)(((Handle_Geom_Curve*)instance)->Access());
	return  	result->ParametricTransformation(			
_T);
}
DECL_EXPORT void* Geom_Curve_ValueD82819F3(
	void* instance,
	double U)
{
	Geom_Curve* result = (Geom_Curve*)(((Handle_Geom_Curve*)instance)->Access());
	return new gp_Pnt( 	result->Value(			
U));
}
DECL_EXPORT void* Geom_Curve_Reversed(void* instance)
{
	Geom_Curve* result = (Geom_Curve*)(((Handle_Geom_Curve*)instance)->Access());
	return 	new Handle_Geom_Curve(	result->Reversed());
}

DECL_EXPORT double Geom_Curve_Period(void* instance)
{
	Geom_Curve* result = (Geom_Curve*)(((Handle_Geom_Curve*)instance)->Access());
	return 	result->Period();
}

DECL_EXPORT void GeomCurve_Dtor(void* instance)
{
	delete (Handle_Geom_Curve*)instance;
}
