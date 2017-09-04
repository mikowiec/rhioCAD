#ifndef TopExp_Explorer_H
#define TopExp_Explorer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TopExp_Explorer_Ctor();
extern "C" DECL_EXPORT void* TopExp_Explorer_CtorBEBE8016(
	void* S,
	int ToFind,
	int ToAvoid);
extern "C" DECL_EXPORT void TopExp_Explorer_InitBEBE8016(
	void* instance,
	void* S,
	int ToFind,
	int ToAvoid);
extern "C" DECL_EXPORT void TopExp_Explorer_Next(void* instance);
extern "C" DECL_EXPORT void TopExp_Explorer_ReInit(void* instance);
extern "C" DECL_EXPORT void TopExp_Explorer_Clear(void* instance);
extern "C" DECL_EXPORT bool TopExp_Explorer_More(void* instance);
extern "C" DECL_EXPORT void* TopExp_Explorer_Current(void* instance);
extern "C" DECL_EXPORT int TopExp_Explorer_Depth(void* instance);
extern "C" DECL_EXPORT void TopExpExplorer_Dtor(void* instance);

#endif
