#include "SelectMgrSelectionManager.h"
#include <SelectMgr_SelectionManager.hxx>

#include <TCollection_AsciiString.hxx>

DECL_EXPORT void* SelectMgr_SelectionManager_Ctor()
{
	return new Handle_SelectMgr_SelectionManager(new SelectMgr_SelectionManager());
}
DECL_EXPORT void SelectMgr_SelectionManager_Add14225620(
	void* instance,
	void* aSelector)
{
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Add(			
_aSelector);
}
DECL_EXPORT void SelectMgr_SelectionManager_Remove14225620(
	void* instance,
	void* aSelector)
{
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Remove(			
_aSelector);
}
DECL_EXPORT bool SelectMgr_SelectionManager_Contains14225620(
	void* instance,
	void* aSelector)
{
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
	return  	result->Contains(			
_aSelector);
}
DECL_EXPORT bool SelectMgr_SelectionManager_ContainsCB355689(
	void* instance,
	void* aSelectableObject)
{
		const Handle_SelectMgr_SelectableObject&  _aSelectableObject =*(const Handle_SelectMgr_SelectableObject *)aSelectableObject;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
	return  	result->Contains(			
_aSelectableObject);
}
DECL_EXPORT void SelectMgr_SelectionManager_LoadC6B3194D(
	void* instance,
	void* anObject,
	int aMode)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Load(			
_anObject,			
aMode);
}
DECL_EXPORT void SelectMgr_SelectionManager_Load55B1618F(
	void* instance,
	void* anObject,
	void* aSelector,
	int aMode)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Load(			
_anObject,			
_aSelector,			
aMode);
}
DECL_EXPORT void SelectMgr_SelectionManager_RemoveCB355689(
	void* instance,
	void* anObject)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Remove(			
_anObject);
}
DECL_EXPORT void SelectMgr_SelectionManager_Remove6CD936C3(
	void* instance,
	void* anObject,
	void* aSelector)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Remove(			
_anObject,			
_aSelector);
}
DECL_EXPORT void SelectMgr_SelectionManager_Activate6947D965(
	void* instance,
	void* anObject,
	int aMode,
	bool AutomaticProj)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Activate(			
_anObject,			
aMode,			
AutomaticProj);
}
DECL_EXPORT void SelectMgr_SelectionManager_Activate271DDBB2(
	void* instance,
	void* anObject,
	int aMode,
	void* aSelector,
	bool AutomaticProj)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Activate(			
_anObject,			
aMode,			
_aSelector,			
AutomaticProj);
}
DECL_EXPORT void SelectMgr_SelectionManager_DeactivateCB355689(
	void* instance,
	void* anObject)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Deactivate(			
_anObject);
}
DECL_EXPORT void SelectMgr_SelectionManager_DeactivateC6B3194D(
	void* instance,
	void* anObject,
	int aMode)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Deactivate(			
_anObject,			
aMode);
}
DECL_EXPORT void SelectMgr_SelectionManager_Deactivate9FE1369E(
	void* instance,
	void* anObject,
	int aMode,
	void* aSelector)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Deactivate(			
_anObject,			
aMode,			
_aSelector);
}
DECL_EXPORT void SelectMgr_SelectionManager_Deactivate6CD936C3(
	void* instance,
	void* anObject,
	void* aSelector)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Deactivate(			
_anObject,			
_aSelector);
}
DECL_EXPORT void SelectMgr_SelectionManager_Sleep14225620(
	void* instance,
	void* aSelector)
{
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Sleep(			
_aSelector);
}
DECL_EXPORT void SelectMgr_SelectionManager_SleepCB355689(
	void* instance,
	void* anObject)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Sleep(			
_anObject);
}
DECL_EXPORT void SelectMgr_SelectionManager_Sleep6CD936C3(
	void* instance,
	void* anObject,
	void* aSelector)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Sleep(			
_anObject,			
_aSelector);
}
DECL_EXPORT void SelectMgr_SelectionManager_AwakeC739D92A(
	void* instance,
	void* aSelector,
	bool AutomaticProj)
{
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Awake(			
_aSelector,			
AutomaticProj);
}
DECL_EXPORT void SelectMgr_SelectionManager_AwakeD97CA70B(
	void* instance,
	void* anObject,
	bool AutomaticProj)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Awake(			
_anObject,			
AutomaticProj);
}
DECL_EXPORT void SelectMgr_SelectionManager_Awake40EFAF9D(
	void* instance,
	void* anObject,
	void* aSelector,
	bool AutomaticProj)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Awake(			
_anObject,			
_aSelector,			
AutomaticProj);
}
DECL_EXPORT bool SelectMgr_SelectionManager_IsActivatedCB355689(
	void* instance,
	void* anObject)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
	return  	result->IsActivated(			
_anObject);
}
DECL_EXPORT bool SelectMgr_SelectionManager_IsActivatedC6B3194D(
	void* instance,
	void* anObject,
	int aMode)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
	return  	result->IsActivated(			
_anObject,			
aMode);
}
DECL_EXPORT bool SelectMgr_SelectionManager_IsActivated55B1618F(
	void* instance,
	void* anObject,
	void* aSelector,
	int aMode)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
	return  	result->IsActivated(			
_anObject,			
_aSelector,			
aMode);
}
DECL_EXPORT void SelectMgr_SelectionManager_RecomputeSelectionF3DAC1BB(
	void* instance,
	void* anIObj,
	bool ForceUpdate,
	int aMode)
{
		const Handle_SelectMgr_SelectableObject&  _anIObj =*(const Handle_SelectMgr_SelectableObject *)anIObj;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->RecomputeSelection(			
_anIObj,			
ForceUpdate,			
aMode);
}
DECL_EXPORT void SelectMgr_SelectionManager_UpdateD97CA70B(
	void* instance,
	void* anObject,
	bool ForceUpdate)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Update(			
_anObject,			
ForceUpdate);
}
DECL_EXPORT void SelectMgr_SelectionManager_Update40EFAF9D(
	void* instance,
	void* anObject,
	void* aSelector,
	bool ForceUpdate)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
		const Handle_SelectMgr_ViewerSelector&  _aSelector =*(const Handle_SelectMgr_ViewerSelector *)aSelector;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->Update(			
_anObject,			
_aSelector,			
ForceUpdate);
}
DECL_EXPORT void SelectMgr_SelectionManager_SetUpdateModeC91DC767(
	void* instance,
	void* anObject,
	int aType)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
		const SelectMgr_TypeOfUpdate _aType =(const SelectMgr_TypeOfUpdate )aType;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->SetUpdateMode(			
_anObject,			
_aType);
}
DECL_EXPORT void SelectMgr_SelectionManager_SetUpdateMode25D61FEE(
	void* instance,
	void* anObject,
	int aSelMode,
	int aType)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
		const SelectMgr_TypeOfUpdate _aType =(const SelectMgr_TypeOfUpdate )aType;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
 	result->SetUpdateMode(			
_anObject,			
aSelMode,			
_aType);
}
DECL_EXPORT void* SelectMgr_SelectionManager_Status(void* instance)
{
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
	return new TCollection_AsciiString( 	result->Status());
}
DECL_EXPORT void* SelectMgr_SelectionManager_StatusCB355689(
	void* instance,
	void* anObject)
{
		const Handle_SelectMgr_SelectableObject&  _anObject =*(const Handle_SelectMgr_SelectableObject *)anObject;
	SelectMgr_SelectionManager* result = (SelectMgr_SelectionManager*)(((Handle_SelectMgr_SelectionManager*)instance)->Access());
	return new TCollection_AsciiString( 	result->Status(			
_anObject));
}
DECL_EXPORT void SelectMgrSelectionManager_Dtor(void* instance)
{
	delete (Handle_SelectMgr_SelectionManager*)instance;
}
