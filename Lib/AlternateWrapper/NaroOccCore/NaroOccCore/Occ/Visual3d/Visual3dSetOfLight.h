#ifndef Visual3d_SetOfLight_H
#define Visual3d_SetOfLight_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_SetOfLight_Ctor();
extern "C" DECL_EXPORT void Visual3d_SetOfLight_Clear(void* instance);
extern "C" DECL_EXPORT bool Visual3d_SetOfLight_Add279ABABC(
	void* instance,
	void* T);
extern "C" DECL_EXPORT bool Visual3d_SetOfLight_Remove279ABABC(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Visual3d_SetOfLight_Union4AF300FE(
	void* instance,
	void* B);
extern "C" DECL_EXPORT void Visual3d_SetOfLight_Intersection4AF300FE(
	void* instance,
	void* B);
extern "C" DECL_EXPORT void Visual3d_SetOfLight_Difference4AF300FE(
	void* instance,
	void* B);
extern "C" DECL_EXPORT bool Visual3d_SetOfLight_Contains279ABABC(
	void* instance,
	void* T);
extern "C" DECL_EXPORT bool Visual3d_SetOfLight_IsASubset4AF300FE(
	void* instance,
	void* S);
extern "C" DECL_EXPORT bool Visual3d_SetOfLight_IsAProperSubset4AF300FE(
	void* instance,
	void* S);
extern "C" DECL_EXPORT int Visual3d_SetOfLight_Extent(void* instance);
extern "C" DECL_EXPORT bool Visual3d_SetOfLight_IsEmpty(void* instance);
extern "C" DECL_EXPORT void Visual3dSetOfLight_Dtor(void* instance);

#endif
