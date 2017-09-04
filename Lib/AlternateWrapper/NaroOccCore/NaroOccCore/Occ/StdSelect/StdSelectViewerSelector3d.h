#ifndef StdSelect_ViewerSelector3d_H
#define StdSelect_ViewerSelector3d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* StdSelect_ViewerSelector3d_Ctor();
extern "C" DECL_EXPORT void StdSelect_ViewerSelector3d_ConvertD1B6659F(
	void* instance,
	void* aSelection);
extern "C" DECL_EXPORT void StdSelect_ViewerSelector3d_Pick556D776C(
	void* instance,
	int XPix,
	int YPix,
	void* aView);
extern "C" DECL_EXPORT void StdSelect_ViewerSelector3d_Pick12E48EEC(
	void* instance,
	int XPMin,
	int YPMin,
	int XPMax,
	int YPMax,
	void* aView);
extern "C" DECL_EXPORT void StdSelect_ViewerSelector3d_ReactivateProjector(void* instance);
extern "C" DECL_EXPORT void StdSelect_ViewerSelector3d_DisplayAreas36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT void StdSelect_ViewerSelector3d_ClearAreas36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT void StdSelect_ViewerSelector3d_DisplaySensitive36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT void StdSelect_ViewerSelector3d_ClearSensitive36A6FAB7(
	void* instance,
	void* aView);
extern "C" DECL_EXPORT void StdSelect_ViewerSelector3d_DisplaySensitiveE07C6821(
	void* instance,
	void* aSel,
	void* aView,
	bool ClearOthers);
extern "C" DECL_EXPORT void StdSelect_ViewerSelector3d_DisplayAreasE07C6821(
	void* instance,
	void* aSel,
	void* aView,
	bool ClearOthers);
extern "C" DECL_EXPORT void StdSelect_ViewerSelector3d_SetSensitivityMode(void* instance, int value);
extern "C" DECL_EXPORT int StdSelect_ViewerSelector3d_SensitivityMode(void* instance);
extern "C" DECL_EXPORT void StdSelect_ViewerSelector3d_SetPixelTolerance(void* instance, int value);
extern "C" DECL_EXPORT int StdSelect_ViewerSelector3d_PixelTolerance(void* instance);
extern "C" DECL_EXPORT void StdSelectViewerSelector3d_Dtor(void* instance);

#endif
