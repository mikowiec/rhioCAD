#ifndef Standard_Persistent_H
#define Standard_Persistent_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void Standard_Persistent_Delete(void* instance);
extern "C" DECL_EXPORT bool Standard_Persistent_IsInstanceE2B3EAC1(
	void* instance,
	void* TheType);
extern "C" DECL_EXPORT bool Standard_Persistent_IsKindE2B3EAC1(
	void* instance,
	void* TheType);
extern "C" DECL_EXPORT void* Standard_Persistent_DynamicType(void* instance);
extern "C" DECL_EXPORT void StandardPersistent_Dtor(void* instance);

#endif
