#ifndef TopTools_HSequenceOfShape_H
#define TopTools_HSequenceOfShape_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TopTools_HSequenceOfShape_Ctor();
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_Clear(void* instance);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_Append9EBAC0C0(
	void* instance,
	void* anItem);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_AppendE578D17E(
	void* instance,
	void* aSequence);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_Prepend9EBAC0C0(
	void* instance,
	void* anItem);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_PrependE578D17E(
	void* instance,
	void* aSequence);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_Reverse(void* instance);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_InsertBeforeA4F60BB8(
	void* instance,
	int anIndex,
	void* anItem);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_InsertBefore9D43C6B8(
	void* instance,
	int anIndex,
	void* aSequence);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_InsertAfterA4F60BB8(
	void* instance,
	int anIndex,
	void* anItem);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_InsertAfter9D43C6B8(
	void* instance,
	int anIndex,
	void* aSequence);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_Exchange5107F6FE(
	void* instance,
	int anIndex,
	int anOtherIndex);
extern "C" DECL_EXPORT void* TopTools_HSequenceOfShape_SplitE8219145(
	void* instance,
	int anIndex);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_SetValueA4F60BB8(
	void* instance,
	int anIndex,
	void* anItem);
extern "C" DECL_EXPORT void* TopTools_HSequenceOfShape_ValueE8219145(
	void* instance,
	int anIndex);
extern "C" DECL_EXPORT void* TopTools_HSequenceOfShape_ChangeValueE8219145(
	void* instance,
	int anIndex);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_RemoveE8219145(
	void* instance,
	int anIndex);
extern "C" DECL_EXPORT void TopTools_HSequenceOfShape_Remove5107F6FE(
	void* instance,
	int fromIndex,
	int toIndex);
extern "C" DECL_EXPORT bool TopTools_HSequenceOfShape_IsEmpty(void* instance);
extern "C" DECL_EXPORT int TopTools_HSequenceOfShape_Length(void* instance);
extern "C" DECL_EXPORT void* TopTools_HSequenceOfShape_ShallowCopy(void* instance);
extern "C" DECL_EXPORT void TopToolsHSequenceOfShape_Dtor(void* instance);

#endif
