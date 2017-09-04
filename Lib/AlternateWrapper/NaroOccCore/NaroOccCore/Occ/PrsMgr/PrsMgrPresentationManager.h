#ifndef PrsMgr_PresentationManager_H
#define PrsMgr_PresentationManager_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void PrsMgr_PresentationManager_Display6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager_Erase6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager_Clear6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager_Highlight6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager_Unhighlight6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager_SetDisplayPriority46D23B97(
	void* instance,
	void* aPresentableObject,
	int amode,
	int aNewPrior);
extern "C" DECL_EXPORT int PrsMgr_PresentationManager_DisplayPriority6305B33D(
	void* instance,
	void* aPresentableObject,
	int amode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager_SetZLayer6305B33D(
	void* instance,
	void* thePresentableObject,
	int theLayerId);
extern "C" DECL_EXPORT int PrsMgr_PresentationManager_GetZLayerF2913F8C(
	void* instance,
	void* thePresentableObject);
extern "C" DECL_EXPORT bool PrsMgr_PresentationManager_IsDisplayed6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT bool PrsMgr_PresentationManager_IsHighlighted6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager_Update6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager_BeginDraw(void* instance);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager_Add6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT void PrsMgr_PresentationManager_Remove6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT bool PrsMgr_PresentationManager_HasPresentation6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT void* PrsMgr_PresentationManager_Presentation6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode);
extern "C" DECL_EXPORT bool PrsMgr_PresentationManager_IsImmediateModeOn(void* instance);
extern "C" DECL_EXPORT void PrsMgrPresentationManager_Dtor(void* instance);

#endif
