#ifndef SelectMgr_SelectionManager_H
#define SelectMgr_SelectionManager_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* SelectMgr_SelectionManager_Ctor();
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_Add14225620(
	void* instance,
	void* aSelector);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_Remove14225620(
	void* instance,
	void* aSelector);
extern "C" DECL_EXPORT bool SelectMgr_SelectionManager_Contains14225620(
	void* instance,
	void* aSelector);
extern "C" DECL_EXPORT bool SelectMgr_SelectionManager_ContainsCB355689(
	void* instance,
	void* aSelectableObject);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_LoadC6B3194D(
	void* instance,
	void* anObject,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_Load55B1618F(
	void* instance,
	void* anObject,
	void* aSelector,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_RemoveCB355689(
	void* instance,
	void* anObject);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_Remove6CD936C3(
	void* instance,
	void* anObject,
	void* aSelector);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_Activate6947D965(
	void* instance,
	void* anObject,
	int aMode,
	bool AutomaticProj);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_Activate271DDBB2(
	void* instance,
	void* anObject,
	int aMode,
	void* aSelector,
	bool AutomaticProj);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_DeactivateCB355689(
	void* instance,
	void* anObject);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_DeactivateC6B3194D(
	void* instance,
	void* anObject,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_Deactivate9FE1369E(
	void* instance,
	void* anObject,
	int aMode,
	void* aSelector);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_Deactivate6CD936C3(
	void* instance,
	void* anObject,
	void* aSelector);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_Sleep14225620(
	void* instance,
	void* aSelector);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_SleepCB355689(
	void* instance,
	void* anObject);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_Sleep6CD936C3(
	void* instance,
	void* anObject,
	void* aSelector);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_AwakeC739D92A(
	void* instance,
	void* aSelector,
	bool AutomaticProj);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_AwakeD97CA70B(
	void* instance,
	void* anObject,
	bool AutomaticProj);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_Awake40EFAF9D(
	void* instance,
	void* anObject,
	void* aSelector,
	bool AutomaticProj);
extern "C" DECL_EXPORT bool SelectMgr_SelectionManager_IsActivatedCB355689(
	void* instance,
	void* anObject);
extern "C" DECL_EXPORT bool SelectMgr_SelectionManager_IsActivatedC6B3194D(
	void* instance,
	void* anObject,
	int aMode);
extern "C" DECL_EXPORT bool SelectMgr_SelectionManager_IsActivated55B1618F(
	void* instance,
	void* anObject,
	void* aSelector,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_RecomputeSelectionF3DAC1BB(
	void* instance,
	void* anIObj,
	bool ForceUpdate,
	int aMode);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_UpdateD97CA70B(
	void* instance,
	void* anObject,
	bool ForceUpdate);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_Update40EFAF9D(
	void* instance,
	void* anObject,
	void* aSelector,
	bool ForceUpdate);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_SetUpdateModeC91DC767(
	void* instance,
	void* anObject,
	int aType);
extern "C" DECL_EXPORT void SelectMgr_SelectionManager_SetUpdateMode25D61FEE(
	void* instance,
	void* anObject,
	int aSelMode,
	int aType);
extern "C" DECL_EXPORT void* SelectMgr_SelectionManager_Status(void* instance);
extern "C" DECL_EXPORT void* SelectMgr_SelectionManager_StatusCB355689(
	void* instance,
	void* anObject);
extern "C" DECL_EXPORT void SelectMgrSelectionManager_Dtor(void* instance);

#endif
