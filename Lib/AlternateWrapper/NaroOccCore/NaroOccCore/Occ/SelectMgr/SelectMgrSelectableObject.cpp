#include "SelectMgrSelectableObject.h"
#include <SelectMgr_SelectableObject.hxx>

#include <SelectMgr_Selection.hxx>

DECL_EXPORT void SelectMgr_SelectableObject_UpdateSelection(void* instance)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
 	result->UpdateSelection();
}
DECL_EXPORT void SelectMgr_SelectableObject_UpdateSelectionE8219145(
	void* instance,
	int aMode)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
 	result->UpdateSelection(			
aMode);
}
DECL_EXPORT void SelectMgr_SelectableObject_AddSelection7C718F26(
	void* instance,
	void* aSelection,
	int aMode)
{
		const Handle_SelectMgr_Selection&  _aSelection =*(const Handle_SelectMgr_Selection *)aSelection;
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
 	result->AddSelection(			
_aSelection,			
aMode);
}
DECL_EXPORT void SelectMgr_SelectableObject_ClearSelections461FC46A(
	void* instance,
	bool update)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
 	result->ClearSelections(			
update);
}
DECL_EXPORT void* SelectMgr_SelectableObject_SelectionE8219145(
	void* instance,
	int aMode)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
	return new Handle_SelectMgr_Selection( 	result->Selection(			
aMode));
}
DECL_EXPORT bool SelectMgr_SelectableObject_HasSelectionE8219145(
	void* instance,
	int aMode)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
	return  	result->HasSelection(			
aMode);
}
DECL_EXPORT void SelectMgr_SelectableObject_Init(void* instance)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
 	result->Init();
}
DECL_EXPORT void SelectMgr_SelectableObject_Next(void* instance)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
 	result->Next();
}
DECL_EXPORT void SelectMgr_SelectableObject_ResetLocation(void* instance)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
 	result->ResetLocation();
}
DECL_EXPORT void SelectMgr_SelectableObject_UpdateLocation(void* instance)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
 	result->UpdateLocation();
}
DECL_EXPORT void SelectMgr_SelectableObject_ClearSelected(void* instance)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
 	result->ClearSelected();
}
DECL_EXPORT void SelectMgr_SelectableObject_HilightOwnerWithColor4EAE9125(
	void* instance,
	void* thePM,
	int theColor,
	void* theOwner)
{
		const Handle_PrsMgr_PresentationManager3d&  _thePM =*(const Handle_PrsMgr_PresentationManager3d *)thePM;
		const Quantity_NameOfColor _theColor =(const Quantity_NameOfColor )theColor;
		const Handle_SelectMgr_EntityOwner&  _theOwner =*(const Handle_SelectMgr_EntityOwner *)theOwner;
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
 	result->HilightOwnerWithColor(			
_thePM,			
_theColor,			
_theOwner);
}
DECL_EXPORT void SelectMgr_SelectableObject_SetZLayerC5F895E9(
	void* instance,
	void* thePrsMgr,
	int theLayerId)
{
		const Handle_PrsMgr_PresentationManager&  _thePrsMgr =*(const Handle_PrsMgr_PresentationManager *)thePrsMgr;
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
 	result->SetZLayer(			
_thePrsMgr,			
theLayerId);
}
DECL_EXPORT int SelectMgr_SelectableObject_NbPossibleSelection(void* instance)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
	return 	result->NbPossibleSelection();
}

DECL_EXPORT bool SelectMgr_SelectableObject_More(void* instance)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
	return 	result->More();
}

DECL_EXPORT void* SelectMgr_SelectableObject_CurrentSelection(void* instance)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
	return 	new Handle_SelectMgr_Selection(	result->CurrentSelection());
}

DECL_EXPORT bool SelectMgr_SelectableObject_IsAutoHilight(void* instance)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
	return 	result->IsAutoHilight();
}

DECL_EXPORT void SelectMgr_SelectableObject_SetAutoHilight(void* instance, bool value)
{
	SelectMgr_SelectableObject* result = (SelectMgr_SelectableObject*)(((Handle_SelectMgr_SelectableObject*)instance)->Access());
		result->SetAutoHilight(value);
}

DECL_EXPORT void SelectMgrSelectableObject_Dtor(void* instance)
{
	delete (Handle_SelectMgr_SelectableObject*)instance;
}
