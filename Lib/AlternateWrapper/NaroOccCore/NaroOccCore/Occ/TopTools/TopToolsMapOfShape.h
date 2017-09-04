#ifndef TopTools_MapOfShape_H
#define TopTools_MapOfShape_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TopTools_MapOfShape_CtorE8219145(
	int NbBuckets);
extern "C" DECL_EXPORT void* TopTools_MapOfShape_Assign5AADDC61(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void TopTools_MapOfShape_ReSizeE8219145(
	void* instance,
	int NbBuckets);
extern "C" DECL_EXPORT bool TopTools_MapOfShape_Add9EBAC0C0(
	void* instance,
	void* aKey);
extern "C" DECL_EXPORT bool TopTools_MapOfShape_Contains9EBAC0C0(
	void* instance,
	void* aKey);
extern "C" DECL_EXPORT bool TopTools_MapOfShape_Remove9EBAC0C0(
	void* instance,
	void* aKey);
extern "C" DECL_EXPORT void TopToolsMapOfShape_Dtor(void* instance);

#endif
