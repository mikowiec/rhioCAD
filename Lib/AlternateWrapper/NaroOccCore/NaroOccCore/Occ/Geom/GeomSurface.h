#ifndef Geom_Surface_H
#define Geom_Surface_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void Geom_Surface_TransformParametersFD94EFCC(
	void* instance,
	double* U,
	double* V,
	void* T);
extern "C" DECL_EXPORT void* Geom_Surface_ParametricTransformation72D78650(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void* Geom_Surface_Value9F0E714F(
	void* instance,
	double U,
	double V);
extern "C" DECL_EXPORT void* Geom_Surface_UReversed(void* instance);
extern "C" DECL_EXPORT void* Geom_Surface_VReversed(void* instance);
extern "C" DECL_EXPORT double Geom_Surface_UPeriod(void* instance);
extern "C" DECL_EXPORT double Geom_Surface_VPeriod(void* instance);
extern "C" DECL_EXPORT void GeomSurface_Dtor(void* instance);

#endif
