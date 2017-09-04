#ifndef V3d_PerspectiveView_H
#define V3d_PerspectiveView_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* V3d_PerspectiveView_Ctor79560492(
	void* VM);
extern "C" DECL_EXPORT void* V3d_PerspectiveView_Ctor4E6B6F5D(
	void* VM,
	void* V);
extern "C" DECL_EXPORT void* V3d_PerspectiveView_Ctor4B0A5FC8(
	void* VM,
	void* V);
extern "C" DECL_EXPORT void V3d_PerspectiveView_SetPerspectiveC2777E0C(
	void* instance,
	double Angle,
	double UVRatio,
	double ZNear,
	double ZFar);
extern "C" DECL_EXPORT void* V3d_PerspectiveView_Copy(void* instance);
extern "C" DECL_EXPORT void V3d_PerspectiveView_SetAngle(void* instance, double value);
extern "C" DECL_EXPORT double V3d_PerspectiveView_Angle(void* instance);
extern "C" DECL_EXPORT void V3dPerspectiveView_Dtor(void* instance);

#endif
