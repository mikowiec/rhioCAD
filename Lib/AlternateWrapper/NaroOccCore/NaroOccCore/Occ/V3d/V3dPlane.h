#ifndef V3d_Plane_H
#define V3d_Plane_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* V3d_Plane_CtorC2777E0C(
	double A,
	double B,
	double C,
	double D);
extern "C" DECL_EXPORT void V3d_Plane_SetPlaneC2777E0C(
	void* instance,
	double A,
	double B,
	double C,
	double D);
extern "C" DECL_EXPORT void V3d_Plane_Display8A383826(
	void* instance,
	void* aView,
	void* aColor);
extern "C" DECL_EXPORT void V3d_Plane_Erase(void* instance);
extern "C" DECL_EXPORT void V3d_Plane_PlaneC2777E0C(
	void* instance,
	double* A,
	double* B,
	double* C,
	double* D);
extern "C" DECL_EXPORT bool V3d_Plane_IsDisplayed(void* instance);
extern "C" DECL_EXPORT void V3dPlane_Dtor(void* instance);

#endif
