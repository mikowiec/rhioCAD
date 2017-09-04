#ifndef TopTools_IndexedMapOfShape_H
#define TopTools_IndexedMapOfShape_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TopTools_IndexedMapOfShape_CtorE8219145(
	int NbBuckets);
extern "C" DECL_EXPORT void TopTools_IndexedMapOfShape_ReSizeE8219145(
	void* instance,
	int NbBuckets);
extern "C" DECL_EXPORT int TopTools_IndexedMapOfShape_Add9EBAC0C0(
	void* instance,
	void* K);
extern "C" DECL_EXPORT void TopTools_IndexedMapOfShape_SubstituteA4F60BB8(
	void* instance,
	int I,
	void* K);
extern "C" DECL_EXPORT void TopTools_IndexedMapOfShape_RemoveLast(void* instance);
extern "C" DECL_EXPORT bool TopTools_IndexedMapOfShape_Contains9EBAC0C0(
	void* instance,
	void* K);
extern "C" DECL_EXPORT void* TopTools_IndexedMapOfShape_FindKeyE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT int TopTools_IndexedMapOfShape_FindIndex9EBAC0C0(
	void* instance,
	void* K);
extern "C" DECL_EXPORT void TopToolsIndexedMapOfShape_Dtor(void* instance);

#endif
