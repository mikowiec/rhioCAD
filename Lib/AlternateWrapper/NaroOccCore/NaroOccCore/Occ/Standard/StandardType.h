#ifndef Standard_Type_H
#define Standard_Type_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Standard_Type_Ctor800FADE1(
	char* aName,
	int aSize);
extern "C" DECL_EXPORT void* Standard_Type_Ctor29DC790D(
	char* aName,
	int aSize,
	int aNumberOfParent,
	void* aAncestors);
extern "C" DECL_EXPORT void* Standard_Type_CtorAF7BE74A(
	char* aName,
	int aSize,
	int aNumberOfElement,
	int aNumberOfParent,
	void* anAncestors,
	void* aElements);
extern "C" DECL_EXPORT void* Standard_Type_Ctor23B9A32F(
	char* aName,
	int aSize,
	int aNumberOfParent,
	void* anAncestors,
	void* aFields);
extern "C" DECL_EXPORT bool Standard_Type_SubTypeE2B3EAC1(
	void* instance,
	void* aOther);
extern "C" DECL_EXPORT bool Standard_Type_SubType9381D4D(
	void* instance,
	char* theName);
extern "C" DECL_EXPORT Standard_CString Standard_Type_Name(void* instance);
extern "C" DECL_EXPORT int Standard_Type_Size(void* instance);
extern "C" DECL_EXPORT bool Standard_Type_IsImported(void* instance);
extern "C" DECL_EXPORT bool Standard_Type_IsPrimitive(void* instance);
extern "C" DECL_EXPORT bool Standard_Type_IsEnumeration(void* instance);
extern "C" DECL_EXPORT bool Standard_Type_IsClass(void* instance);
extern "C" DECL_EXPORT int Standard_Type_NumberOfParent(void* instance);
extern "C" DECL_EXPORT int Standard_Type_NumberOfAncestor(void* instance);
extern "C" DECL_EXPORT void StandardType_Dtor(void* instance);

#endif
