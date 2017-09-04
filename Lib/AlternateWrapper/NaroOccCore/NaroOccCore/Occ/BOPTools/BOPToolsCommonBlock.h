#ifndef BOPTools_CommonBlock_H
#define BOPTools_CommonBlock_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOPTools_CommonBlock_Ctor();
extern "C" DECL_EXPORT void* BOPTools_CommonBlock_CtorA5B57975(
	void* aPB1,
	void* aPB2);
extern "C" DECL_EXPORT void* BOPTools_CommonBlock_CtorE11775D8(
	void* aPB1,
	int aF);
extern "C" DECL_EXPORT void BOPTools_CommonBlock_SetPaveBlock136FC67E4(
	void* instance,
	void* aPB1);
extern "C" DECL_EXPORT void BOPTools_CommonBlock_SetPaveBlock236FC67E4(
	void* instance,
	void* aPB2);
extern "C" DECL_EXPORT void* BOPTools_CommonBlock_PaveBlock1(void* instance);
extern "C" DECL_EXPORT void* BOPTools_CommonBlock_PaveBlock1E8219145(
	void* instance,
	int anIndex);
extern "C" DECL_EXPORT void* BOPTools_CommonBlock_PaveBlock2(void* instance);
extern "C" DECL_EXPORT void* BOPTools_CommonBlock_PaveBlock2E8219145(
	void* instance,
	int anIndex);
extern "C" DECL_EXPORT void BOPTools_CommonBlock_SetFace(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_CommonBlock_Face(void* instance);
extern "C" DECL_EXPORT void BOPToolsCommonBlock_Dtor(void* instance);

#endif
