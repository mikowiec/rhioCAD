#ifndef TopTools_ListOfShape_H
#define TopTools_ListOfShape_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TopTools_ListOfShape_Ctor();
extern "C" DECL_EXPORT void TopTools_ListOfShape_Assign49A1D41A(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void TopTools_ListOfShape_Prepend9EBAC0C0(
	void* instance,
	void* I);
extern "C" DECL_EXPORT void TopTools_ListOfShape_Prepend90A9D6CA(
	void* instance,
	void* I,
	void* theIt);
extern "C" DECL_EXPORT void TopTools_ListOfShape_Prepend49A1D41A(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void TopTools_ListOfShape_Append9EBAC0C0(
	void* instance,
	void* I);
extern "C" DECL_EXPORT void TopTools_ListOfShape_Append90A9D6CA(
	void* instance,
	void* I,
	void* theIt);
extern "C" DECL_EXPORT void TopTools_ListOfShape_Append49A1D41A(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void TopTools_ListOfShape_RemoveFirst(void* instance);
extern "C" DECL_EXPORT void TopTools_ListOfShape_RemoveB4C0FF7F(
	void* instance,
	void* It);
extern "C" DECL_EXPORT void TopTools_ListOfShape_InsertBefore90A9D6CA(
	void* instance,
	void* I,
	void* It);
extern "C" DECL_EXPORT void TopTools_ListOfShape_InsertBefore8F414405(
	void* instance,
	void* Other,
	void* It);
extern "C" DECL_EXPORT void TopTools_ListOfShape_InsertAfter90A9D6CA(
	void* instance,
	void* I,
	void* It);
extern "C" DECL_EXPORT void TopTools_ListOfShape_InsertAfter8F414405(
	void* instance,
	void* Other,
	void* It);
extern "C" DECL_EXPORT int TopTools_ListOfShape_Extent(void* instance);
extern "C" DECL_EXPORT bool TopTools_ListOfShape_IsEmpty(void* instance);
extern "C" DECL_EXPORT void* TopTools_ListOfShape_First(void* instance);
extern "C" DECL_EXPORT void* TopTools_ListOfShape_Last(void* instance);
extern "C" DECL_EXPORT void TopToolsListOfShape_Dtor(void* instance);

#endif
