#ifndef Aspect_WidthMapEntry_H
#define Aspect_WidthMapEntry_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Aspect_WidthMapEntry_Ctor();
extern "C" DECL_EXPORT void* Aspect_WidthMapEntry_CtorA80F21D5(
	int index,
	int style);
extern "C" DECL_EXPORT void* Aspect_WidthMapEntry_Ctor69F5FCCD(
	int index,
	double width);
extern "C" DECL_EXPORT void* Aspect_WidthMapEntry_Ctor290679CE(
	void* entry);
extern "C" DECL_EXPORT void Aspect_WidthMapEntry_SetValueA80F21D5(
	void* instance,
	int index,
	int style);
extern "C" DECL_EXPORT void Aspect_WidthMapEntry_SetValue69F5FCCD(
	void* instance,
	int index,
	double width);
extern "C" DECL_EXPORT void Aspect_WidthMapEntry_SetValue290679CE(
	void* instance,
	void* entry);
extern "C" DECL_EXPORT void Aspect_WidthMapEntry_Free(void* instance);
extern "C" DECL_EXPORT void Aspect_WidthMapEntry_Dump(void* instance);
extern "C" DECL_EXPORT void Aspect_WidthMapEntry_SetType(void* instance, int value);
extern "C" DECL_EXPORT int Aspect_WidthMapEntry_Type(void* instance);
extern "C" DECL_EXPORT void Aspect_WidthMapEntry_SetWidth(void* instance, double value);
extern "C" DECL_EXPORT double Aspect_WidthMapEntry_Width(void* instance);
extern "C" DECL_EXPORT void Aspect_WidthMapEntry_SetIndex(void* instance, int value);
extern "C" DECL_EXPORT int Aspect_WidthMapEntry_Index(void* instance);
extern "C" DECL_EXPORT bool Aspect_WidthMapEntry_IsAllocated(void* instance);
extern "C" DECL_EXPORT void AspectWidthMapEntry_Dtor(void* instance);

#endif
