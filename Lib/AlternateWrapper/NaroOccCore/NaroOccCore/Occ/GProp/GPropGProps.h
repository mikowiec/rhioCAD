#ifndef GProp_GProps_H
#define GProp_GProps_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* GProp_GProps_Ctor();
extern "C" DECL_EXPORT void* GProp_GProps_Ctor9EAECD5B(
	void* SystemLocation);
extern "C" DECL_EXPORT void GProp_GProps_Add38D0113A(
	void* instance,
	void* Item,
	double Density);
extern "C" DECL_EXPORT void GProp_GProps_StaticMoments9282A951(
	void* instance,
	double* Ix,
	double* Iy,
	double* Iz);
extern "C" DECL_EXPORT double GProp_GProps_MomentOfInertia608B963B(
	void* instance,
	void* A);
extern "C" DECL_EXPORT double GProp_GProps_RadiusOfGyration608B963B(
	void* instance,
	void* A);
extern "C" DECL_EXPORT double GProp_GProps_Mass(void* instance);
extern "C" DECL_EXPORT void* GProp_GProps_CentreOfMass(void* instance);
extern "C" DECL_EXPORT void* GProp_GProps_MatrixOfInertia(void* instance);
extern "C" DECL_EXPORT void GPropGProps_Dtor(void* instance);

#endif
