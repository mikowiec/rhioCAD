#ifndef BOPTools_Interference_H
#define BOPTools_Interference_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOPTools_Interference_Ctor();
extern "C" DECL_EXPORT void* BOPTools_Interference_CtorF7A1D3E9(
	int aWith,
	int aType,
	int anIndex);
extern "C" DECL_EXPORT void BOPTools_Interference_SetWith(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_Interference_With(void* instance);
extern "C" DECL_EXPORT void BOPTools_Interference_SetType(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_Interference_Type(void* instance);
extern "C" DECL_EXPORT void BOPTools_Interference_SetIndex(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_Interference_Index(void* instance);
extern "C" DECL_EXPORT void BOPToolsInterference_Dtor(void* instance);

#endif
