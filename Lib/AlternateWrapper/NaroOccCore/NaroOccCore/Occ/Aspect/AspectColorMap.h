#ifndef Aspect_ColorMap_H
#define Aspect_ColorMap_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT int Aspect_ColorMap_IndexE8219145(
	void* instance,
	int aColormapIndex);
extern "C" DECL_EXPORT void Aspect_ColorMap_Dump(void* instance);
extern "C" DECL_EXPORT void* Aspect_ColorMap_EntryE8219145(
	void* instance,
	int AColorMapIndex);
extern "C" DECL_EXPORT int Aspect_ColorMap_Type(void* instance);
extern "C" DECL_EXPORT int Aspect_ColorMap_Size(void* instance);
extern "C" DECL_EXPORT void AspectColorMap_Dtor(void* instance);

#endif
