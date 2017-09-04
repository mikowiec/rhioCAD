#ifndef SelectMgr_SelectableObject_H
#define SelectMgr_SelectableObject_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void SelectMgr_SelectableObject_UpdateSelection(void* instance);
extern "C" DECL_EXPORT void SelectMgr_SelectableObject_UpdateSelectionE8219145(
	void* instance,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_SelectableObject_AddSelection7C718F26(
	void* instance,
	void* aSelection,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_SelectableObject_ClearSelections461FC46A(
	void* instance,
	bool update);
extern "C" DECL_EXPORT void* SelectMgr_SelectableObject_SelectionE8219145(
	void* instance,
	int aMode);
extern "C" DECL_EXPORT bool SelectMgr_SelectableObject_HasSelectionE8219145(
	void* instance,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_SelectableObject_Init(void* instance);
extern "C" DECL_EXPORT void SelectMgr_SelectableObject_Next(void* instance);
extern "C" DECL_EXPORT void SelectMgr_SelectableObject_ResetLocation(void* instance);
extern "C" DECL_EXPORT void SelectMgr_SelectableObject_UpdateLocation(void* instance);
extern "C" DECL_EXPORT void SelectMgr_SelectableObject_ClearSelected(void* instance);
extern "C" DECL_EXPORT void SelectMgr_SelectableObject_HilightOwnerWithColor4EAE9125(
	void* instance,
	void* thePM,
	int theColor,
	void* theOwner);
extern "C" DECL_EXPORT void SelectMgr_SelectableObject_SetZLayerC5F895E9(
	void* instance,
	void* thePrsMgr,
	int theLayerId);
extern "C" DECL_EXPORT int SelectMgr_SelectableObject_NbPossibleSelection(void* instance);
extern "C" DECL_EXPORT bool SelectMgr_SelectableObject_More(void* instance);
extern "C" DECL_EXPORT void* SelectMgr_SelectableObject_CurrentSelection(void* instance);
extern "C" DECL_EXPORT bool SelectMgr_SelectableObject_IsAutoHilight(void* instance);
extern "C" DECL_EXPORT void SelectMgr_SelectableObject_SetAutoHilight(void* instance, bool value);
extern "C" DECL_EXPORT void SelectMgrSelectableObject_Dtor(void* instance);

#endif
