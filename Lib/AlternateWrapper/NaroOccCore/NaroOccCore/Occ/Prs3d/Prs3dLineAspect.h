#ifndef Prs3d_LineAspect_H
#define Prs3d_LineAspect_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Prs3d_LineAspect_Ctor1A9E9376(
	int aColor,
	int aType,
	double aWidth);
extern "C" DECL_EXPORT void* Prs3d_LineAspect_Ctor94ED4A31(
	void* aColor,
	int aType,
	double aWidth);
extern "C" DECL_EXPORT void Prs3d_LineAspect_SetColor8FD7F48(
	void* instance,
	void* aColor);
extern "C" DECL_EXPORT void Prs3d_LineAspect_SetColor48F4F471(
	void* instance,
	int aColor);
extern "C" DECL_EXPORT void Prs3d_LineAspect_SetTypeOfLine(void* instance, int value);
extern "C" DECL_EXPORT void Prs3d_LineAspect_SetWidth(void* instance, double value);
extern "C" DECL_EXPORT void Prs3dLineAspect_Dtor(void* instance);

#endif
