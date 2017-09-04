#ifndef Visual3d_LayerItem_H
#define Visual3d_LayerItem_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_LayerItem_Ctor();
extern "C" DECL_EXPORT void Visual3d_LayerItem_ComputeLayerPrs(void* instance);
extern "C" DECL_EXPORT void Visual3d_LayerItem_RedrawLayerPrs(void* instance);
extern "C" DECL_EXPORT bool Visual3d_LayerItem_IsNeedToRecompute(void* instance);
extern "C" DECL_EXPORT void Visual3d_LayerItem_SetNeedToRecompute(void* instance, bool value);
extern "C" DECL_EXPORT void Visual3dLayerItem_Dtor(void* instance);

#endif
