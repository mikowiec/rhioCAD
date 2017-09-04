#ifndef Visual3d_ViewMapping_H
#define Visual3d_ViewMapping_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_ViewMapping_Ctor();
extern "C" DECL_EXPORT void* Visual3d_ViewMapping_Ctor65BCDE62(
	int AType,
	void* PRP,
	double BPD,
	double FPD,
	double VPD,
	double WUmin,
	double WVmin,
	double WUmax,
	double WVmax);
extern "C" DECL_EXPORT void Visual3d_ViewMapping_SetWindowLimitC2777E0C(
	void* instance,
	double Umin,
	double Vmin,
	double Umax,
	double Vmax);
extern "C" DECL_EXPORT void Visual3d_ViewMapping_WindowLimitC2777E0C(
	void* instance,
	double* Umin,
	double* Vmin,
	double* Umax,
	double* Vmax);
extern "C" DECL_EXPORT void Visual3d_ViewMapping_SetBackPlaneDistance(void* instance, double value);
extern "C" DECL_EXPORT double Visual3d_ViewMapping_BackPlaneDistance(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewMapping_SetFrontPlaneDistance(void* instance, double value);
extern "C" DECL_EXPORT double Visual3d_ViewMapping_FrontPlaneDistance(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewMapping_SetProjection(void* instance, int value);
extern "C" DECL_EXPORT int Visual3d_ViewMapping_Projection(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewMapping_SetProjectionReferencePoint(void* instance, void* value);
extern "C" DECL_EXPORT void* Visual3d_ViewMapping_ProjectionReferencePoint(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewMapping_SetViewPlaneDistance(void* instance, double value);
extern "C" DECL_EXPORT double Visual3d_ViewMapping_ViewPlaneDistance(void* instance);
extern "C" DECL_EXPORT bool Visual3d_ViewMapping_IsCustomMatrix(void* instance);
extern "C" DECL_EXPORT void Visual3dViewMapping_Dtor(void* instance);

#endif
