#ifndef BOPTools_PaveBlock_H
#define BOPTools_PaveBlock_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOPTools_PaveBlock_Ctor();
extern "C" DECL_EXPORT void* BOPTools_PaveBlock_Ctor9182DAFF(
	int anEdge,
	void* aPave1,
	void* aPave2);
extern "C" DECL_EXPORT bool BOPTools_PaveBlock_IsEqual36FC67E4(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void BOPTools_PaveBlock_Parameters9F0E714F(
	void* instance,
	double* aT1,
	double* aT2);
extern "C" DECL_EXPORT bool BOPTools_PaveBlock_IsInBlock3EED610E(
	void* instance,
	void* aPaveX);
extern "C" DECL_EXPORT void BOPTools_PaveBlock_SetEdge(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_PaveBlock_Edge(void* instance);
extern "C" DECL_EXPORT void BOPTools_PaveBlock_SetOriginalEdge(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_PaveBlock_OriginalEdge(void* instance);
extern "C" DECL_EXPORT void BOPTools_PaveBlock_SetPave1(void* instance, void* value);
extern "C" DECL_EXPORT void* BOPTools_PaveBlock_Pave1(void* instance);
extern "C" DECL_EXPORT void BOPTools_PaveBlock_SetPave2(void* instance, void* value);
extern "C" DECL_EXPORT void* BOPTools_PaveBlock_Pave2(void* instance);
extern "C" DECL_EXPORT bool BOPTools_PaveBlock_IsValid(void* instance);
extern "C" DECL_EXPORT void* BOPTools_PaveBlock_Range(void* instance);
extern "C" DECL_EXPORT void BOPTools_PaveBlock_SetShrunkRange(void* instance, void* value);
extern "C" DECL_EXPORT void* BOPTools_PaveBlock_ShrunkRange(void* instance);
extern "C" DECL_EXPORT void BOPTools_PaveBlock_SetPointBetween(void* instance, void* value);
extern "C" DECL_EXPORT void* BOPTools_PaveBlock_PointBetween(void* instance);
extern "C" DECL_EXPORT void BOPTools_PaveBlock_SetCurve(void* instance, void* value);
extern "C" DECL_EXPORT void* BOPTools_PaveBlock_Curve(void* instance);
extern "C" DECL_EXPORT void BOPTools_PaveBlock_SetFace1(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_PaveBlock_Face1(void* instance);
extern "C" DECL_EXPORT void BOPTools_PaveBlock_SetFace2(void* instance, int value);
extern "C" DECL_EXPORT int BOPTools_PaveBlock_Face2(void* instance);
extern "C" DECL_EXPORT void BOPToolsPaveBlock_Dtor(void* instance);

#endif
