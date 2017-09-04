#ifndef Aspect_WidthMap_H
#define Aspect_WidthMap_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Aspect_WidthMap_Ctor();
extern "C" DECL_EXPORT void Aspect_WidthMap_AddEntry290679CE(
	void* instance,
	void* AnEntry);
extern "C" DECL_EXPORT int Aspect_WidthMap_AddEntry82DA6A16(
	void* instance,
	int aStyle);
extern "C" DECL_EXPORT int Aspect_WidthMap_AddEntryD82819F3(
	void* instance,
	double aStyle);
extern "C" DECL_EXPORT int Aspect_WidthMap_IndexE8219145(
	void* instance,
	int aWidthmapIndex);
extern "C" DECL_EXPORT void* Aspect_WidthMap_EntryE8219145(
	void* instance,
	int AnIndex);
extern "C" DECL_EXPORT void Aspect_WidthMap_Dump(void* instance);
extern "C" DECL_EXPORT int Aspect_WidthMap_Size(void* instance);
extern "C" DECL_EXPORT void AspectWidthMap_Dtor(void* instance);

#endif
