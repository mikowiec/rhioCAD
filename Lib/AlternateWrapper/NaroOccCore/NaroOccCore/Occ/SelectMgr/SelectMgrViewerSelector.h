#ifndef SelectMgr_ViewerSelector_H
#define SelectMgr_ViewerSelector_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_ConvertD1B6659F(
	void* instance,
	void* aSelection);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_Clear(void* instance);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_UpdateConversion(void* instance);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_SetClippingC2777E0C(
	void* instance,
	double Xc,
	double Yc,
	double Height,
	double Width);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_SetClipping5D98465D(
	void* instance,
	void* aRectangle);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_InitSelect9F0E714F(
	void* instance,
	double Xr,
	double Yr);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_InitSelect5D98465D(
	void* instance,
	void* aRect);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_InitSelectC2777E0C(
	void* instance,
	double Xmin,
	double Ymin,
	double Xmax,
	double Ymax);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_SortResult(void* instance);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_Init(void* instance);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_Next(void* instance);
extern "C" DECL_EXPORT void* SelectMgr_ViewerSelector_Picked(void* instance);
extern "C" DECL_EXPORT void* SelectMgr_ViewerSelector_PickedE8219145(
	void* instance,
	int aRank);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_LastPosition9F0E714F(
	void* instance,
	double* Xr,
	double* Yr);
extern "C" DECL_EXPORT bool SelectMgr_ViewerSelector_ContainsCB355689(
	void* instance,
	void* aSelectableObject);
extern "C" DECL_EXPORT bool SelectMgr_ViewerSelector_IsActiveC6B3194D(
	void* instance,
	void* aSelectableObject,
	int aMode);
extern "C" DECL_EXPORT bool SelectMgr_ViewerSelector_IsInsideC6B3194D(
	void* instance,
	void* aSelectableObject,
	int aMode);
extern "C" DECL_EXPORT int SelectMgr_ViewerSelector_StatusD1B6659F(
	void* instance,
	void* aSelection);
extern "C" DECL_EXPORT void* SelectMgr_ViewerSelector_StatusCB355689(
	void* instance,
	void* aSelectableObject);
extern "C" DECL_EXPORT void* SelectMgr_ViewerSelector_Status(void* instance);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_UpdateSort(void* instance);
extern "C" DECL_EXPORT void* SelectMgr_ViewerSelector_PrimitiveE8219145(
	void* instance,
	int Rank);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_SetSensitivity(void* instance, double value);
extern "C" DECL_EXPORT double SelectMgr_ViewerSelector_Sensitivity(void* instance);
extern "C" DECL_EXPORT bool SelectMgr_ViewerSelector_More(void* instance);
extern "C" DECL_EXPORT void* SelectMgr_ViewerSelector_OnePicked(void* instance);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_SetPickClosest(void* instance, bool value);
extern "C" DECL_EXPORT int SelectMgr_ViewerSelector_NbPicked(void* instance);
extern "C" DECL_EXPORT bool SelectMgr_ViewerSelector_HasStored(void* instance);
extern "C" DECL_EXPORT void SelectMgr_ViewerSelector_SetUpdateSortPossible(void* instance, bool value);
extern "C" DECL_EXPORT bool SelectMgr_ViewerSelector_IsUpdateSortPossible(void* instance);
extern "C" DECL_EXPORT void SelectMgrViewerSelector_Dtor(void* instance);

#endif
