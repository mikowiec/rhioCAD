#ifndef TopTools_IndexedDataMapOfShapeListOfShape_H
#define TopTools_IndexedDataMapOfShapeListOfShape_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TopTools_IndexedDataMapOfShapeListOfShape_CtorE8219145(
	int NbBuckets);
extern "C" DECL_EXPORT void TopTools_IndexedDataMapOfShapeListOfShape_ReSizeE8219145(
	void* instance,
	int NbBuckets);
extern "C" DECL_EXPORT int TopTools_IndexedDataMapOfShapeListOfShape_AddA97080D(
	void* instance,
	void* K,
	void* I);
extern "C" DECL_EXPORT void TopTools_IndexedDataMapOfShapeListOfShape_SubstituteF0D9ACDA(
	void* instance,
	int I,
	void* K,
	void* T);
extern "C" DECL_EXPORT void TopTools_IndexedDataMapOfShapeListOfShape_RemoveLast(void* instance);
extern "C" DECL_EXPORT bool TopTools_IndexedDataMapOfShapeListOfShape_Contains9EBAC0C0(
	void* instance,
	void* K);
extern "C" DECL_EXPORT void* TopTools_IndexedDataMapOfShapeListOfShape_FindKeyE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT void* TopTools_IndexedDataMapOfShapeListOfShape_FindFromIndexE8219145(
	void* instance,
	int I);
extern "C" DECL_EXPORT int TopTools_IndexedDataMapOfShapeListOfShape_FindIndex9EBAC0C0(
	void* instance,
	void* K);
extern "C" DECL_EXPORT void* TopTools_IndexedDataMapOfShapeListOfShape_FindFromKey19EBAC0C0(
	void* instance,
	void* K);
extern "C" DECL_EXPORT void* TopTools_IndexedDataMapOfShapeListOfShape_ChangeFromKey19EBAC0C0(
	void* instance,
	void* K);
extern "C" DECL_EXPORT void TopToolsIndexedDataMapOfShapeListOfShape_Dtor(void* instance);

#endif
