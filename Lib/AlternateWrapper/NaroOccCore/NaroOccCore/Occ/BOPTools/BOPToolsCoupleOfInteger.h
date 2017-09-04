#ifndef BOPTools_CoupleOfInteger_H
#define BOPTools_CoupleOfInteger_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOPTools_CoupleOfInteger_Ctor();
extern "C" DECL_EXPORT void* BOPTools_CoupleOfInteger_Ctor5107F6FE(
	int aFirst,
	int aSecond);
extern "C" DECL_EXPORT void BOPTools_CoupleOfInteger_SetCouple5107F6FE(
	void* instance,
	int aFirst,
	int aSecond);
extern "C" DECL_EXPORT void BOPTools_CoupleOfInteger_Couple5107F6FE(
	void* instance,
	int* aFirst,
	int* aSecond);
extern "C" DECL_EXPORT bool BOPTools_CoupleOfInteger_IsEqual692F43DE(
	void* instance,
	void* aOther);
extern "C" DECL_EXPORT int BOPTools_CoupleOfInteger_HashCodeE8219145(
	void* instance,
	int Upper);
extern "C" DECL_EXPORT void BOPTools_CoupleOfInteger_SetFirst(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_CoupleOfInteger_First(void* instance);
extern "C" DECL_EXPORT void BOPTools_CoupleOfInteger_SetSecond(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_CoupleOfInteger_Second(void* instance);
extern "C" DECL_EXPORT void BOPToolsCoupleOfInteger_Dtor(void* instance);

#endif
