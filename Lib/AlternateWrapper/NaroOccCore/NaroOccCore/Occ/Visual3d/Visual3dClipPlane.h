#ifndef Visual3d_ClipPlane_H
#define Visual3d_ClipPlane_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_ClipPlane_CtorC2777E0C(
	double ACoefA,
	double ACoefB,
	double ACoefC,
	double ACoefD);
extern "C" DECL_EXPORT void Visual3d_ClipPlane_SetPlaneC2777E0C(
	void* instance,
	double ACoefA,
	double ACoefB,
	double ACoefC,
	double ACoefD);
extern "C" DECL_EXPORT void Visual3d_ClipPlane_PlaneC2777E0C(
	void* instance,
	double* ACoefA,
	double* ACoefB,
	double* ACoefC,
	double* ACoefD);
extern "C" DECL_EXPORT int Visual3d_ClipPlane_Limit();
extern "C" DECL_EXPORT void Visual3dClipPlane_Dtor(void* instance);

#endif
