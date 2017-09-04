#ifndef SelectMgr_EntityOwner_H
#define SelectMgr_EntityOwner_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* SelectMgr_EntityOwner_CtorE8219145(
	int aPriority);
extern "C" DECL_EXPORT void* SelectMgr_EntityOwner_CtorC6B3194D(
	void* aSO,
	int aPriority);
extern "C" DECL_EXPORT void SelectMgr_EntityOwner_SetCB355689(
	void* instance,
	void* aSO);
extern "C" DECL_EXPORT void SelectMgr_EntityOwner_Hilight(void* instance);
extern "C" DECL_EXPORT bool SelectMgr_EntityOwner_IsHilightedC5F895E9(
	void* instance,
	void* aPM,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_EntityOwner_HilightC5F895E9(
	void* instance,
	void* aPM,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_EntityOwner_HilightWithColor1D9F4508(
	void* instance,
	void* aPM,
	int aColor,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_EntityOwner_UnhilightC5F895E9(
	void* instance,
	void* aPM,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_EntityOwner_ClearC5F895E9(
	void* instance,
	void* aPM,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_EntityOwner_ResetLocation(void* instance);
extern "C" DECL_EXPORT void SelectMgr_EntityOwner_StateE8219145(
	void* instance,
	int aStatus);
extern "C" DECL_EXPORT int SelectMgr_EntityOwner_State(void* instance);
extern "C" DECL_EXPORT void SelectMgr_EntityOwner_SetZLayerC5F895E9(
	void* instance,
	void* thePrsMgr,
	int theLayerId);
extern "C" DECL_EXPORT bool SelectMgr_EntityOwner_HasSelectable(void* instance);
extern "C" DECL_EXPORT void* SelectMgr_EntityOwner_Selectable(void* instance);
extern "C" DECL_EXPORT bool SelectMgr_EntityOwner_HasLocation(void* instance);
extern "C" DECL_EXPORT void SelectMgr_EntityOwner_SetLocation(void* instance, void* value);
extern "C" DECL_EXPORT void* SelectMgr_EntityOwner_Location(void* instance);
extern "C" DECL_EXPORT bool SelectMgr_EntityOwner_IsAutoHilight(void* instance);
extern "C" DECL_EXPORT bool SelectMgr_EntityOwner_IsForcedHilight(void* instance);
extern "C" DECL_EXPORT void SelectMgrEntityOwner_Dtor(void* instance);

#endif
