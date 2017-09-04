#include "SelectMgrEntityOwner.h"
#include <SelectMgr_EntityOwner.hxx>

#include <SelectMgr_SelectableObject.hxx>
#include <TopLoc_Location.hxx>

DECL_EXPORT void* SelectMgr_EntityOwner_CtorE8219145(
	int aPriority)
{
	return new Handle_SelectMgr_EntityOwner(new SelectMgr_EntityOwner(			
aPriority));
}
DECL_EXPORT void* SelectMgr_EntityOwner_CtorC6B3194D(
	void* aSO,
	int aPriority)
{
		const Handle_SelectMgr_SelectableObject&  _aSO =*(const Handle_SelectMgr_SelectableObject *)aSO;
	return new Handle_SelectMgr_EntityOwner(new SelectMgr_EntityOwner(			
_aSO,			
aPriority));
}
DECL_EXPORT void SelectMgr_EntityOwner_SetCB355689(
	void* instance,
	void* aSO)
{
		const Handle_SelectMgr_SelectableObject&  _aSO =*(const Handle_SelectMgr_SelectableObject *)aSO;
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
 	result->Set(			
_aSO);
}
DECL_EXPORT void SelectMgr_EntityOwner_Hilight(void* instance)
{
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
 	result->Hilight();
}
DECL_EXPORT bool SelectMgr_EntityOwner_IsHilightedC5F895E9(
	void* instance,
	void* aPM,
	int aMode)
{
		const Handle_PrsMgr_PresentationManager&  _aPM =*(const Handle_PrsMgr_PresentationManager *)aPM;
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
	return  	result->IsHilighted(			
_aPM,			
aMode);
}
DECL_EXPORT void SelectMgr_EntityOwner_HilightC5F895E9(
	void* instance,
	void* aPM,
	int aMode)
{
		const Handle_PrsMgr_PresentationManager&  _aPM =*(const Handle_PrsMgr_PresentationManager *)aPM;
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
 	result->Hilight(			
_aPM,			
aMode);
}
DECL_EXPORT void SelectMgr_EntityOwner_HilightWithColor1D9F4508(
	void* instance,
	void* aPM,
	int aColor,
	int aMode)
{
		const Handle_PrsMgr_PresentationManager3d&  _aPM =*(const Handle_PrsMgr_PresentationManager3d *)aPM;
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
 	result->HilightWithColor(			
_aPM,			
_aColor,			
aMode);
}
DECL_EXPORT void SelectMgr_EntityOwner_UnhilightC5F895E9(
	void* instance,
	void* aPM,
	int aMode)
{
		const Handle_PrsMgr_PresentationManager&  _aPM =*(const Handle_PrsMgr_PresentationManager *)aPM;
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
 	result->Unhilight(			
_aPM,			
aMode);
}
DECL_EXPORT void SelectMgr_EntityOwner_ClearC5F895E9(
	void* instance,
	void* aPM,
	int aMode)
{
		const Handle_PrsMgr_PresentationManager&  _aPM =*(const Handle_PrsMgr_PresentationManager *)aPM;
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
 	result->Clear(			
_aPM,			
aMode);
}
DECL_EXPORT void SelectMgr_EntityOwner_ResetLocation(void* instance)
{
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
 	result->ResetLocation();
}
DECL_EXPORT void SelectMgr_EntityOwner_StateE8219145(
	void* instance,
	int aStatus)
{
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
 	result->State(			
aStatus);
}
DECL_EXPORT int SelectMgr_EntityOwner_State(void* instance)
{
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
	return  	result->State();
}
DECL_EXPORT void SelectMgr_EntityOwner_SetZLayerC5F895E9(
	void* instance,
	void* thePrsMgr,
	int theLayerId)
{
		const Handle_PrsMgr_PresentationManager&  _thePrsMgr =*(const Handle_PrsMgr_PresentationManager *)thePrsMgr;
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
 	result->SetZLayer(			
_thePrsMgr,			
theLayerId);
}
DECL_EXPORT bool SelectMgr_EntityOwner_HasSelectable(void* instance)
{
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
	return 	result->HasSelectable();
}

DECL_EXPORT void* SelectMgr_EntityOwner_Selectable(void* instance)
{
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
	return 	new Handle_SelectMgr_SelectableObject(	result->Selectable());
}

DECL_EXPORT bool SelectMgr_EntityOwner_HasLocation(void* instance)
{
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
	return 	result->HasLocation();
}

DECL_EXPORT void SelectMgr_EntityOwner_SetLocation(void* instance, void* value)
{
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
		result->SetLocation(*(const TopLoc_Location *)value);
}

DECL_EXPORT void* SelectMgr_EntityOwner_Location(void* instance)
{
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
	return 	new TopLoc_Location(	result->Location());
}

DECL_EXPORT bool SelectMgr_EntityOwner_IsAutoHilight(void* instance)
{
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
	return 	result->IsAutoHilight();
}

DECL_EXPORT bool SelectMgr_EntityOwner_IsForcedHilight(void* instance)
{
	SelectMgr_EntityOwner* result = (SelectMgr_EntityOwner*)(((Handle_SelectMgr_EntityOwner*)instance)->Access());
	return 	result->IsForcedHilight();
}

DECL_EXPORT void SelectMgrEntityOwner_Dtor(void* instance)
{
	delete (Handle_SelectMgr_EntityOwner*)instance;
}
