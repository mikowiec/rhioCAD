#ifndef Visual3d_ContextPick_H
#define Visual3d_ContextPick_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_ContextPick_Ctor();
extern "C" DECL_EXPORT void* Visual3d_ContextPick_CtorA3634D78(
	double Aperture,
	int Depth,
	int Order);
extern "C" DECL_EXPORT void Visual3d_ContextPick_SetAperture(void* instance, double value);
extern "C" DECL_EXPORT double Visual3d_ContextPick_Aperture(void* instance);
extern "C" DECL_EXPORT void Visual3d_ContextPick_SetDepth(void* instance, int value);
extern "C" DECL_EXPORT int Visual3d_ContextPick_Depth(void* instance);
extern "C" DECL_EXPORT void Visual3d_ContextPick_SetOrder(void* instance, int value);
extern "C" DECL_EXPORT int Visual3d_ContextPick_Order(void* instance);
extern "C" DECL_EXPORT void Visual3dContextPick_Dtor(void* instance);

#endif
