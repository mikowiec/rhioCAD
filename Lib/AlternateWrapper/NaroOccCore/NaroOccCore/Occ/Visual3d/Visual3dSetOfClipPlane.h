#ifndef Visual3d_SetOfClipPlane_H
#define Visual3d_SetOfClipPlane_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_SetOfClipPlane_Ctor();
extern "C" DECL_EXPORT void Visual3d_SetOfClipPlane_Clear(void* instance);
extern "C" DECL_EXPORT bool Visual3d_SetOfClipPlane_Add97234D4A(
	void* instance,
	void* T);
extern "C" DECL_EXPORT bool Visual3d_SetOfClipPlane_Remove97234D4A(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Visual3d_SetOfClipPlane_Union129D9308(
	void* instance,
	void* B);
extern "C" DECL_EXPORT void Visual3d_SetOfClipPlane_Intersection129D9308(
	void* instance,
	void* B);
extern "C" DECL_EXPORT void Visual3d_SetOfClipPlane_Difference129D9308(
	void* instance,
	void* B);
extern "C" DECL_EXPORT bool Visual3d_SetOfClipPlane_Contains97234D4A(
	void* instance,
	void* T);
extern "C" DECL_EXPORT bool Visual3d_SetOfClipPlane_IsASubset129D9308(
	void* instance,
	void* S);
extern "C" DECL_EXPORT bool Visual3d_SetOfClipPlane_IsAProperSubset129D9308(
	void* instance,
	void* S);
extern "C" DECL_EXPORT int Visual3d_SetOfClipPlane_Extent(void* instance);
extern "C" DECL_EXPORT bool Visual3d_SetOfClipPlane_IsEmpty(void* instance);
extern "C" DECL_EXPORT void Visual3dSetOfClipPlane_Dtor(void* instance);

#endif
