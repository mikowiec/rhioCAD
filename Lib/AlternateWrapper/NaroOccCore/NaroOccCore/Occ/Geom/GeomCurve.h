#ifndef Geom_Curve_H
#define Geom_Curve_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT double Geom_Curve_TransformedParameter9B95D054(
	void* instance,
	double U,
	void* T);
extern "C" DECL_EXPORT double Geom_Curve_ParametricTransformation72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* Geom_Curve_ValueD82819F3(
	void* instance,
	double U);
extern "C" DECL_EXPORT void* Geom_Curve_Reversed(void* instance);
extern "C" DECL_EXPORT double Geom_Curve_Period(void* instance);
extern "C" DECL_EXPORT void GeomCurve_Dtor(void* instance);

#endif
