#ifndef Visual3d_ViewManager_H
#define Visual3d_ViewManager_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_ViewManager_CtorAC5012C4(
	void* aDevice);
extern "C" DECL_EXPORT void Visual3d_ViewManager_Activate(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewManager_Deactivate(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewManager_Erase(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewManager_Redraw(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewManager_Remove(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewManager_Update(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewManager_ConvertCoord8C15567E(
	void* instance,
	void* AWindow,
	void* AVertex,
	int* AU,
	int* AV);
extern "C" DECL_EXPORT void* Visual3d_ViewManager_ConvertCoord6DDFCDA0(
	void* instance,
	void* AWindow,
	int AU,
	int AV);
extern "C" DECL_EXPORT void Visual3d_ViewManager_ConvertCoordWithProj4FF6C2D0(
	void* instance,
	void* AWindow,
	int AU,
	int AV,
	void* Point,
	void* Proj);
extern "C" DECL_EXPORT int Visual3d_ViewManager_Identification68FD189(
	void* instance,
	void* AView);
extern "C" DECL_EXPORT void Visual3d_ViewManager_UnIdentificationE8219145(
	void* instance,
	int aViewId);
extern "C" DECL_EXPORT int Visual3d_ViewManager_Identification(void* instance);
extern "C" DECL_EXPORT bool Visual3d_ViewManager_AddZLayerE8219145(
	void* instance,
	int* theLayerId);
extern "C" DECL_EXPORT bool Visual3d_ViewManager_RemoveZLayerE8219145(
	void* instance,
	int theLayerId);
extern "C" DECL_EXPORT void Visual3d_ViewManager_GetAllZLayersE22FA26(
	void* instance,
	void* theLayerSeq);
extern "C" DECL_EXPORT void Visual3d_ViewManager_UnHighlight(void* instance);
extern "C" DECL_EXPORT int Visual3d_ViewManager_MaxNumOfViews(void* instance);
extern "C" DECL_EXPORT void* Visual3d_ViewManager_UnderLayer(void* instance);
extern "C" DECL_EXPORT void* Visual3d_ViewManager_OverLayer(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewManager_SetTransparency(void* instance, bool value);
extern "C" DECL_EXPORT bool Visual3d_ViewManager_Transparency(void* instance);
extern "C" DECL_EXPORT void Visual3d_ViewManager_SetZBufferAuto(void* instance, bool value);
extern "C" DECL_EXPORT bool Visual3d_ViewManager_ZBufferAuto(void* instance);
extern "C" DECL_EXPORT void Visual3dViewManager_Dtor(void* instance);

#endif
