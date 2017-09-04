#include "PrsMgrPresentableObject.h"
#include <PrsMgr_PresentableObject.hxx>

#include <gp_Pnt.hxx>
#include <TopLoc_Location.hxx>

DECL_EXPORT void PrsMgr_PresentableObject_SetToUpdateE8219145(
	void* instance,
	int aMode)
{
	PrsMgr_PresentableObject* result = (PrsMgr_PresentableObject*)(((Handle_PrsMgr_PresentableObject*)instance)->Access());
 	result->SetToUpdate(			
aMode);
}
DECL_EXPORT void PrsMgr_PresentableObject_SetToUpdate(void* instance)
{
	PrsMgr_PresentableObject* result = (PrsMgr_PresentableObject*)(((Handle_PrsMgr_PresentableObject*)instance)->Access());
 	result->SetToUpdate();
}
DECL_EXPORT void PrsMgr_PresentableObject_ResetLocation(void* instance)
{
	PrsMgr_PresentableObject* result = (PrsMgr_PresentableObject*)(((Handle_PrsMgr_PresentableObject*)instance)->Access());
 	result->ResetLocation();
}
DECL_EXPORT void PrsMgr_PresentableObject_UpdateLocation(void* instance)
{
	PrsMgr_PresentableObject* result = (PrsMgr_PresentableObject*)(((Handle_PrsMgr_PresentableObject*)instance)->Access());
 	result->UpdateLocation();
}
DECL_EXPORT void PrsMgr_PresentableObject_SetZLayerC5F895E9(
	void* instance,
	void* thePrsMgr,
	int theLayerId)
{
		const Handle_PrsMgr_PresentationManager&  _thePrsMgr =*(const Handle_PrsMgr_PresentationManager *)thePrsMgr;
	PrsMgr_PresentableObject* result = (PrsMgr_PresentableObject*)(((Handle_PrsMgr_PresentableObject*)instance)->Access());
 	result->SetZLayer(			
_thePrsMgr,			
theLayerId);
}
DECL_EXPORT int PrsMgr_PresentableObject_GetZLayer56269ED1(
	void* instance,
	void* thePrsMgr)
{
		const Handle_PrsMgr_PresentationManager&  _thePrsMgr =*(const Handle_PrsMgr_PresentationManager *)thePrsMgr;
	PrsMgr_PresentableObject* result = (PrsMgr_PresentableObject*)(((Handle_PrsMgr_PresentableObject*)instance)->Access());
	return  	result->GetZLayer(			
_thePrsMgr);
}
DECL_EXPORT int PrsMgr_PresentableObject_TypeOfPresentation3d(void* instance)
{
	PrsMgr_PresentableObject* result = (PrsMgr_PresentableObject*)(((Handle_PrsMgr_PresentableObject*)instance)->Access());
	return (int)	result->TypeOfPresentation3d();
}

DECL_EXPORT void* PrsMgr_PresentableObject_GetTransformPersistencePoint(void* instance)
{
	PrsMgr_PresentableObject* result = (PrsMgr_PresentableObject*)(((Handle_PrsMgr_PresentableObject*)instance)->Access());
	return 	new gp_Pnt(	result->GetTransformPersistencePoint());
}

DECL_EXPORT void PrsMgr_PresentableObject_SetTypeOfPresentation(void* instance, int value)
{
	PrsMgr_PresentableObject* result = (PrsMgr_PresentableObject*)(((Handle_PrsMgr_PresentableObject*)instance)->Access());
		result->SetTypeOfPresentation((const PrsMgr_TypeOfPresentation3d)value);
}

DECL_EXPORT bool PrsMgr_PresentableObject_HasLocation(void* instance)
{
	PrsMgr_PresentableObject* result = (PrsMgr_PresentableObject*)(((Handle_PrsMgr_PresentableObject*)instance)->Access());
	return 	result->HasLocation();
}

DECL_EXPORT void PrsMgr_PresentableObject_SetLocation(void* instance, void* value)
{
	PrsMgr_PresentableObject* result = (PrsMgr_PresentableObject*)(((Handle_PrsMgr_PresentableObject*)instance)->Access());
		result->SetLocation(*(const TopLoc_Location *)value);
}

DECL_EXPORT void* PrsMgr_PresentableObject_Location(void* instance)
{
	PrsMgr_PresentableObject* result = (PrsMgr_PresentableObject*)(((Handle_PrsMgr_PresentableObject*)instance)->Access());
	return 	new TopLoc_Location(	result->Location());
}

DECL_EXPORT void PrsMgrPresentableObject_Dtor(void* instance)
{
	delete (Handle_PrsMgr_PresentableObject*)instance;
}
