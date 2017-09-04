#ifndef Visual3d_SetOfView_H
#define Visual3d_SetOfView_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_SetOfView_Ctor();
extern "C" DECL_EXPORT void Visual3d_SetOfView_Clear(void* instance);
extern "C" DECL_EXPORT bool Visual3d_SetOfView_Add68FD189(
	void* instance,
	void* T);
extern "C" DECL_EXPORT bool Visual3d_SetOfView_Remove68FD189(
	void* instance,
	void* T);
extern "C" DECL_EXPORT void Visual3d_SetOfView_UnionF34A7047(
	void* instance,
	void* B);
extern "C" DECL_EXPORT void Visual3d_SetOfView_IntersectionF34A7047(
	void* instance,
	void* B);
extern "C" DECL_EXPORT void Visual3d_SetOfView_DifferenceF34A7047(
	void* instance,
	void* B);
extern "C" DECL_EXPORT bool Visual3d_SetOfView_Contains68FD189(
	void* instance,
	void* T);
extern "C" DECL_EXPORT bool Visual3d_SetOfView_IsASubsetF34A7047(
	void* instance,
	void* S);
extern "C" DECL_EXPORT bool Visual3d_SetOfView_IsAProperSubsetF34A7047(
	void* instance,
	void* S);
extern "C" DECL_EXPORT int Visual3d_SetOfView_Extent(void* instance);
extern "C" DECL_EXPORT bool Visual3d_SetOfView_IsEmpty(void* instance);
extern "C" DECL_EXPORT void Visual3dSetOfView_Dtor(void* instance);

#endif
