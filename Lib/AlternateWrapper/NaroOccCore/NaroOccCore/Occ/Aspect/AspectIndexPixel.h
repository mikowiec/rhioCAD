#ifndef Aspect_IndexPixel_H
#define Aspect_IndexPixel_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Aspect_IndexPixel_Ctor();
extern "C" DECL_EXPORT void* Aspect_IndexPixel_CtorE8219145(
	int anIndex);
extern "C" DECL_EXPORT int Aspect_IndexPixel_HashCodeE8219145(
	void* instance,
	int Upper);
extern "C" DECL_EXPORT bool Aspect_IndexPixel_IsEqual24DA5CD5(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool Aspect_IndexPixel_IsNotEqual24DA5CD5(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void Aspect_IndexPixel_SetValue(void* instance, int value);
extern "C" DECL_EXPORT int Aspect_IndexPixel_Value(void* instance);
extern "C" DECL_EXPORT void AspectIndexPixel_Dtor(void* instance);

#endif
