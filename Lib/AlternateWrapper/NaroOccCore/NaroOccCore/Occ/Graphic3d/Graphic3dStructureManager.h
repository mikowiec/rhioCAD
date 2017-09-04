#ifndef Graphic3d_StructureManager_H
#define Graphic3d_StructureManager_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void Graphic3d_StructureManager_MinMaxValuesBC7A5786(
	void* instance,
	double* XMin,
	double* YMin,
	double* ZMin,
	double* XMax,
	double* YMax,
	double* ZMax);
extern "C" DECL_EXPORT int Graphic3d_StructureManager_Identification(void* instance);
extern "C" DECL_EXPORT void* Graphic3d_StructureManager_FillArea3dAspect(void* instance);
extern "C" DECL_EXPORT int Graphic3d_StructureManager_Limit();
extern "C" DECL_EXPORT void* Graphic3d_StructureManager_Text3dAspect(void* instance);
extern "C" DECL_EXPORT void Graphic3d_StructureManager_SetUpdateMode(void* instance, int value);
extern "C" DECL_EXPORT int Graphic3d_StructureManager_UpdateMode(void* instance);
extern "C" DECL_EXPORT int Graphic3d_StructureManager_CurrentId();
extern "C" DECL_EXPORT void* Graphic3d_StructureManager_GraphicDevice(void* instance);
extern "C" DECL_EXPORT void Graphic3dStructureManager_Dtor(void* instance);

#endif
