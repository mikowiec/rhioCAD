#ifndef Aspect_FontMapEntry_H
#define Aspect_FontMapEntry_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Aspect_FontMapEntry_Ctor();
extern "C" DECL_EXPORT void* Aspect_FontMapEntry_Ctor387C7A2F(
	int index,
	void* style);
extern "C" DECL_EXPORT void* Aspect_FontMapEntry_CtorF998EDD2(
	void* entry);
extern "C" DECL_EXPORT void Aspect_FontMapEntry_SetValue387C7A2F(
	void* instance,
	int index,
	void* style);
extern "C" DECL_EXPORT void Aspect_FontMapEntry_SetValueF998EDD2(
	void* instance,
	void* entry);
extern "C" DECL_EXPORT void Aspect_FontMapEntry_Free(void* instance);
extern "C" DECL_EXPORT void Aspect_FontMapEntry_Dump(void* instance);
extern "C" DECL_EXPORT void Aspect_FontMapEntry_SetType(void* instance, void* value);
extern "C" DECL_EXPORT void* Aspect_FontMapEntry_Type(void* instance);
extern "C" DECL_EXPORT void Aspect_FontMapEntry_SetIndex(void* instance, int value);
extern "C" DECL_EXPORT int Aspect_FontMapEntry_Index(void* instance);
extern "C" DECL_EXPORT bool Aspect_FontMapEntry_IsAllocated(void* instance);
extern "C" DECL_EXPORT void AspectFontMapEntry_Dtor(void* instance);

#endif
