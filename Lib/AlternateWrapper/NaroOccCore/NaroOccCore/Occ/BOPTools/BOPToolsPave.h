#ifndef BOPTools_Pave_H
#define BOPTools_Pave_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOPTools_Pave_Ctor();
extern "C" DECL_EXPORT void* BOPTools_Pave_Ctor62B18AF(
	int Index,
	double aParam,
	int aType);
extern "C" DECL_EXPORT bool BOPTools_Pave_IsEqual3EED610E(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void BOPTools_Pave_SetParam(void* instance, double value);
extern "C" DECL_EXPORT double BOPTools_Pave_Param(void* instance);
extern "C" DECL_EXPORT void BOPTools_Pave_SetIndex(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_Pave_Index(void* instance);
extern "C" DECL_EXPORT void BOPTools_Pave_SetType(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_Pave_Type(void* instance);
extern "C" DECL_EXPORT void BOPTools_Pave_SetInterference(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_Pave_Interference(void* instance);
extern "C" DECL_EXPORT void BOPToolsPave_Dtor(void* instance);

#endif
