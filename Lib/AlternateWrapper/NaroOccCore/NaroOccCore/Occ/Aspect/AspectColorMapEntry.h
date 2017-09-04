#ifndef Aspect_ColorMapEntry_H
#define Aspect_ColorMapEntry_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Aspect_ColorMapEntry_Ctor();
extern "C" DECL_EXPORT void* Aspect_ColorMapEntry_Ctor8575C8EE(
	int index,
	void* rgb);
extern "C" DECL_EXPORT void* Aspect_ColorMapEntry_CtorE9FD56D3(
	void* entry);
extern "C" DECL_EXPORT void Aspect_ColorMapEntry_SetValue8575C8EE(
	void* instance,
	int index,
	void* rgb);
extern "C" DECL_EXPORT void Aspect_ColorMapEntry_SetValueE9FD56D3(
	void* instance,
	void* entry);
extern "C" DECL_EXPORT void Aspect_ColorMapEntry_Free(void* instance);
extern "C" DECL_EXPORT void Aspect_ColorMapEntry_Dump(void* instance);
extern "C" DECL_EXPORT void Aspect_ColorMapEntry_SetColor(void* instance, void* value);
extern "C" DECL_EXPORT void* Aspect_ColorMapEntry_Color(void* instance);
extern "C" DECL_EXPORT void Aspect_ColorMapEntry_SetIndex(void* instance, int value);
extern "C" DECL_EXPORT int Aspect_ColorMapEntry_Index(void* instance);
extern "C" DECL_EXPORT bool Aspect_ColorMapEntry_IsAllocated(void* instance);
extern "C" DECL_EXPORT void AspectColorMapEntry_Dtor(void* instance);

#endif
