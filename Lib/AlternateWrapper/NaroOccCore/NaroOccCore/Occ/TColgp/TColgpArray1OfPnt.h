#ifndef TColgp_Array1OfPnt_H
#define TColgp_Array1OfPnt_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TColgp_Array1OfPnt_Ctor5107F6FE(
	int Low,
	int Up);
extern "C" DECL_EXPORT void* TColgp_Array1OfPnt_CtorABE6CB63(
	void* Item,
	int Low,
	int Up);
extern "C" DECL_EXPORT void TColgp_Array1OfPnt_Init9EAECD5B(
	void* instance,
	void* V);
extern "C" DECL_EXPORT void* TColgp_Array1OfPnt_AssignFABD0F95(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void TColgp_Array1OfPnt_SetValue7B5D1E58(
	void* instance,
	int Index,
	void* Value);
extern "C" DECL_EXPORT void* TColgp_Array1OfPnt_ValueE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT void* TColgp_Array1OfPnt_ChangeValueE8219145(
	void* instance,
	int Index);
extern "C" DECL_EXPORT bool TColgp_Array1OfPnt_IsAllocated(void* instance);
extern "C" DECL_EXPORT int TColgp_Array1OfPnt_Length(void* instance);
extern "C" DECL_EXPORT int TColgp_Array1OfPnt_Lower(void* instance);
extern "C" DECL_EXPORT int TColgp_Array1OfPnt_Upper(void* instance);
extern "C" DECL_EXPORT void TColgpArray1OfPnt_Dtor(void* instance);

#endif
