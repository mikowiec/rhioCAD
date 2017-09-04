#ifndef Aspect_ColorPixel_H
#define Aspect_ColorPixel_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Aspect_ColorPixel_Ctor();
extern "C" DECL_EXPORT void* Aspect_ColorPixel_Ctor8FD7F48(
	void* aColor);
extern "C" DECL_EXPORT int Aspect_ColorPixel_HashCodeE8219145(
	void* instance,
	int Upper);
extern "C" DECL_EXPORT bool Aspect_ColorPixel_IsEqualBD406A6D(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool Aspect_ColorPixel_IsNotEqualBD406A6D(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void Aspect_ColorPixel_SetValue(void* instance, void* value);
extern "C" DECL_EXPORT void* Aspect_ColorPixel_Value(void* instance);
extern "C" DECL_EXPORT void AspectColorPixel_Dtor(void* instance);

#endif
