#ifndef Standard_Transient_H
#define Standard_Transient_H

#include "../../Export_Import.h"

//extern "C" DECL_EXPORT int Standard_Transient_HashCodeE8219145(
//	void* instance,
//	int Upper);
extern "C" DECL_EXPORT void Standard_Transient_Delete(void* instance);
extern "C" DECL_EXPORT bool Standard_Transient_IsInstanceE2B3EAC1(
	void* instance,
	void* TheType);
extern "C" DECL_EXPORT bool Standard_Transient_IsInstance9381D4D(
	void* instance,
	char* TheTypeName);
extern "C" DECL_EXPORT bool Standard_Transient_IsKindE2B3EAC1(
	void* instance,
	void* TheType);
extern "C" DECL_EXPORT bool Standard_Transient_IsKind9381D4D(
	void* instance,
	char* TheTypeName);
extern "C" DECL_EXPORT void* Standard_Transient_DynamicType(void* instance);
extern "C" DECL_EXPORT int Standard_Transient_GetRefCount(void* instance);
extern "C" DECL_EXPORT void StandardTransient_Dtor(void* instance);
extern "C" DECL_EXPORT bool Standard_Transient_IsSameTransientF411CB01(void* instance,
void* other);
extern "C" DECL_EXPORT void* StandardTransiemt_NewHandle(void* instance);
#endif
