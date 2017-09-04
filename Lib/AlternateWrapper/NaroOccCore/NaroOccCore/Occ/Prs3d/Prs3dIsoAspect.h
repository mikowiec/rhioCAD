#ifndef Prs3d_IsoAspect_H
#define Prs3d_IsoAspect_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Prs3d_IsoAspect_CtorC2594F57(
	int aColor,
	int aType,
	double aWidth,
	int aNumber);
extern "C" DECL_EXPORT void* Prs3d_IsoAspect_CtorE8121D05(
	void* aColor,
	int aType,
	double aWidth,
	int aNumber);
extern "C" DECL_EXPORT void Prs3d_IsoAspect_SetNumber(void* instance, int value);
extern "C" DECL_EXPORT int Prs3d_IsoAspect_Number(void* instance);
extern "C" DECL_EXPORT void Prs3dIsoAspect_Dtor(void* instance);

#endif
