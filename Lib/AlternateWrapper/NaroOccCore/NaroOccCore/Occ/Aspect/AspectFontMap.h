#ifndef Aspect_FontMap_H
#define Aspect_FontMap_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Aspect_FontMap_Ctor();
extern "C" DECL_EXPORT void Aspect_FontMap_AddEntryF998EDD2(
	void* instance,
	void* AnEntry);
extern "C" DECL_EXPORT int Aspect_FontMap_AddEntry8E648131(
	void* instance,
	void* aStyle);
extern "C" DECL_EXPORT int Aspect_FontMap_IndexE8219145(
	void* instance,
	int aFontmapIndex);
extern "C" DECL_EXPORT void Aspect_FontMap_Dump(void* instance);
extern "C" DECL_EXPORT void* Aspect_FontMap_EntryE8219145(
	void* instance,
	int AnIndex);
extern "C" DECL_EXPORT int Aspect_FontMap_Size(void* instance);
extern "C" DECL_EXPORT void AspectFontMap_Dtor(void* instance);

#endif
