#ifndef V3d_LayerMgr_H
#define V3d_LayerMgr_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* V3d_LayerMgr_Ctor36A6FAB7(
	void* aView);
extern "C" DECL_EXPORT void V3d_LayerMgr_ColorScaleDisplay(void* instance);
extern "C" DECL_EXPORT void V3d_LayerMgr_ColorScaleErase(void* instance);
extern "C" DECL_EXPORT void V3d_LayerMgr_Compute(void* instance);
extern "C" DECL_EXPORT void V3d_LayerMgr_Resized(void* instance);
extern "C" DECL_EXPORT void* V3d_LayerMgr_Overlay(void* instance);
extern "C" DECL_EXPORT void* V3d_LayerMgr_View(void* instance);
extern "C" DECL_EXPORT bool V3d_LayerMgr_ColorScaleIsDisplayed(void* instance);
extern "C" DECL_EXPORT void V3dLayerMgr_Dtor(void* instance);

#endif
