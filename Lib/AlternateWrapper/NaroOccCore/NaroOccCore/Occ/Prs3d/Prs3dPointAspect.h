#ifndef Prs3d_PointAspect_H
#define Prs3d_PointAspect_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Prs3d_PointAspect_Ctor9BAF9396(
	int aType,
	void* aColor,
	double aScale);
extern "C" DECL_EXPORT void* Prs3d_PointAspect_CtorF00B8265(
	int aType,
	int aColor,
	double aScale);
extern "C" DECL_EXPORT void Prs3d_PointAspect_SetColor8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT void Prs3d_PointAspect_SetColor48F4F471(
	void* instance,
	int aColor);
extern "C" DECL_EXPORT void Prs3d_PointAspect_GetTextureSize5107F6FE(
	void* instance,
	int* AWidth,
	int* AHeight);
extern "C" DECL_EXPORT void Prs3d_PointAspect_SetTypeOfMarker(void* instance, int value);
extern "C" DECL_EXPORT void Prs3d_PointAspect_SetScale(void* instance, double value);
extern "C" DECL_EXPORT void Prs3dPointAspect_Dtor(void* instance);

#endif
