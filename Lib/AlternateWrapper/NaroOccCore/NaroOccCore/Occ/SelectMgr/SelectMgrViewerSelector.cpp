#include "SelectMgrViewerSelector.h"
#include <SelectMgr_ViewerSelector.hxx>

#include <SelectBasics_SensitiveEntity.hxx>
#include <SelectMgr_EntityOwner.hxx>
#include <TCollection_AsciiString.hxx>

DECL_EXPORT void SelectMgr_ViewerSelector_ConvertD1B6659F(
	void* instance,
	void* aSelection)
{
		const Handle_SelectMgr_Selection&  _aSelection =*(const Handle_SelectMgr_Selection *)aSelection;
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->Convert(			
_aSelection);
}
DECL_EXPORT void SelectMgr_ViewerSelector_Clear(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->Clear();
}
DECL_EXPORT void SelectMgr_ViewerSelector_UpdateConversion(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->UpdateConversion();
}
DECL_EXPORT void SelectMgr_ViewerSelector_SetClippingC2777E0C(
	void* instance,
	double Xc,
	double Yc,
	double Height,
	double Width)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->SetClipping(			
Xc,			
Yc,			
Height,			
Width);
}
DECL_EXPORT void SelectMgr_ViewerSelector_SetClipping5D98465D(
	void* instance,
	void* aRectangle)
{
		const Bnd_Box2d &  _aRectangle =*(const Bnd_Box2d *)aRectangle;
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->SetClipping(			
_aRectangle);
}
DECL_EXPORT void SelectMgr_ViewerSelector_InitSelect9F0E714F(
	void* instance,
	double Xr,
	double Yr)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->InitSelect(			
Xr,			
Yr);
}
DECL_EXPORT void SelectMgr_ViewerSelector_InitSelect5D98465D(
	void* instance,
	void* aRect)
{
		const Bnd_Box2d &  _aRect =*(const Bnd_Box2d *)aRect;
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->InitSelect(			
_aRect);
}
DECL_EXPORT void SelectMgr_ViewerSelector_InitSelectC2777E0C(
	void* instance,
	double Xmin,
	double Ymin,
	double Xmax,
	double Ymax)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->InitSelect(			
Xmin,			
Ymin,			
Xmax,			
Ymax);
}
DECL_EXPORT void SelectMgr_ViewerSelector_SortResult(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->SortResult();
}
DECL_EXPORT void SelectMgr_ViewerSelector_Init(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->Init();
}
DECL_EXPORT void SelectMgr_ViewerSelector_Next(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->Next();
}
DECL_EXPORT void* SelectMgr_ViewerSelector_Picked(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return new Handle_SelectMgr_EntityOwner( 	result->Picked());
}
DECL_EXPORT void* SelectMgr_ViewerSelector_PickedE8219145(
	void* instance,
	int aRank)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return new Handle_SelectMgr_EntityOwner( 	result->Picked(			
aRank));
}
DECL_EXPORT void SelectMgr_ViewerSelector_LastPosition9F0E714F(
	void* instance,
	double* Xr,
	double* Yr)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->LastPosition(			
*Xr,			
*Yr);
}
DECL_EXPORT bool SelectMgr_ViewerSelector_ContainsCB355689(
	void* instance,
	void* aSelectableObject)
{
		const Handle_SelectMgr_SelectableObject&  _aSelectableObject =*(const Handle_SelectMgr_SelectableObject *)aSelectableObject;
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return  	result->Contains(			
_aSelectableObject);
}
DECL_EXPORT bool SelectMgr_ViewerSelector_IsActiveC6B3194D(
	void* instance,
	void* aSelectableObject,
	int aMode)
{
		const Handle_SelectMgr_SelectableObject&  _aSelectableObject =*(const Handle_SelectMgr_SelectableObject *)aSelectableObject;
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return  	result->IsActive(			
_aSelectableObject,			
aMode);
}
DECL_EXPORT bool SelectMgr_ViewerSelector_IsInsideC6B3194D(
	void* instance,
	void* aSelectableObject,
	int aMode)
{
		const Handle_SelectMgr_SelectableObject&  _aSelectableObject =*(const Handle_SelectMgr_SelectableObject *)aSelectableObject;
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return  	result->IsInside(			
_aSelectableObject,			
aMode);
}
DECL_EXPORT int SelectMgr_ViewerSelector_StatusD1B6659F(
	void* instance,
	void* aSelection)
{
		const Handle_SelectMgr_Selection&  _aSelection =*(const Handle_SelectMgr_Selection *)aSelection;
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return  	result->Status(			
_aSelection);
}
DECL_EXPORT void* SelectMgr_ViewerSelector_StatusCB355689(
	void* instance,
	void* aSelectableObject)
{
		const Handle_SelectMgr_SelectableObject&  _aSelectableObject =*(const Handle_SelectMgr_SelectableObject *)aSelectableObject;
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return new TCollection_AsciiString( 	result->Status(			
_aSelectableObject));
}
DECL_EXPORT void* SelectMgr_ViewerSelector_Status(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return new TCollection_AsciiString( 	result->Status());
}
DECL_EXPORT void SelectMgr_ViewerSelector_UpdateSort(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
 	result->UpdateSort();
}
DECL_EXPORT void* SelectMgr_ViewerSelector_PrimitiveE8219145(
	void* instance,
	int Rank)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return new Handle_SelectBasics_SensitiveEntity( 	result->Primitive(			
Rank));
}
DECL_EXPORT void SelectMgr_ViewerSelector_SetSensitivity(void* instance, double value)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
		result->SetSensitivity(value);
}

DECL_EXPORT double SelectMgr_ViewerSelector_Sensitivity(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return 	result->Sensitivity();
}

DECL_EXPORT bool SelectMgr_ViewerSelector_More(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return 	result->More();
}

DECL_EXPORT void* SelectMgr_ViewerSelector_OnePicked(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return 	new Handle_SelectMgr_EntityOwner(	result->OnePicked());
}

DECL_EXPORT void SelectMgr_ViewerSelector_SetPickClosest(void* instance, bool value)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
		result->SetPickClosest(value);
}

DECL_EXPORT int SelectMgr_ViewerSelector_NbPicked(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return 	result->NbPicked();
}

DECL_EXPORT bool SelectMgr_ViewerSelector_HasStored(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return 	result->HasStored();
}

DECL_EXPORT void SelectMgr_ViewerSelector_SetUpdateSortPossible(void* instance, bool value)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
		result->SetUpdateSortPossible(value);
}

DECL_EXPORT bool SelectMgr_ViewerSelector_IsUpdateSortPossible(void* instance)
{
	SelectMgr_ViewerSelector* result = (SelectMgr_ViewerSelector*)(((Handle_SelectMgr_ViewerSelector*)instance)->Access());
	return 	result->IsUpdateSortPossible();
}

DECL_EXPORT void SelectMgrViewerSelector_Dtor(void* instance)
{
	delete (Handle_SelectMgr_ViewerSelector*)instance;
}
