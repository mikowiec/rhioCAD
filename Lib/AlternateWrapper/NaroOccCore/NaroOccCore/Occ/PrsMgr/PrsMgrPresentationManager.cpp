#include "PrsMgrPresentationManager.h"
#include <PrsMgr_PresentationManager.hxx>

#include <PrsMgr_Presentation.hxx>

DECL_EXPORT void PrsMgr_PresentationManager_Display6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
 	result->Display(			
_aPresentableObject,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager_Erase6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
 	result->Erase(			
_aPresentableObject,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager_Clear6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
 	result->Clear(			
_aPresentableObject,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager_Highlight6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
 	result->Highlight(			
_aPresentableObject,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager_Unhighlight6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
 	result->Unhighlight(			
_aPresentableObject,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager_SetDisplayPriority46D23B97(
	void* instance,
	void* aPresentableObject,
	int amode,
	int aNewPrior)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
 	result->SetDisplayPriority(			
_aPresentableObject,			
amode,			
aNewPrior);
}
DECL_EXPORT int PrsMgr_PresentationManager_DisplayPriority6305B33D(
	void* instance,
	void* aPresentableObject,
	int amode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
	return  	result->DisplayPriority(			
_aPresentableObject,			
amode);
}
DECL_EXPORT void PrsMgr_PresentationManager_SetZLayer6305B33D(
	void* instance,
	void* thePresentableObject,
	int theLayerId)
{
		const Handle_PrsMgr_PresentableObject&  _thePresentableObject =*(const Handle_PrsMgr_PresentableObject *)thePresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
 	result->SetZLayer(			
_thePresentableObject,			
theLayerId);
}
DECL_EXPORT int PrsMgr_PresentationManager_GetZLayerF2913F8C(
	void* instance,
	void* thePresentableObject)
{
		const Handle_PrsMgr_PresentableObject&  _thePresentableObject =*(const Handle_PrsMgr_PresentableObject *)thePresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
	return  	result->GetZLayer(			
_thePresentableObject);
}
DECL_EXPORT bool PrsMgr_PresentationManager_IsDisplayed6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
	return  	result->IsDisplayed(			
_aPresentableObject,			
aMode);
}
DECL_EXPORT bool PrsMgr_PresentationManager_IsHighlighted6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
	return  	result->IsHighlighted(			
_aPresentableObject,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager_Update6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
 	result->Update(			
_aPresentableObject,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager_BeginDraw(void* instance)
{
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
 	result->BeginDraw();
}
DECL_EXPORT void PrsMgr_PresentationManager_Add6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
 	result->Add(			
_aPresentableObject,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager_Remove6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
 	result->Remove(			
_aPresentableObject,			
aMode);
}
DECL_EXPORT bool PrsMgr_PresentationManager_HasPresentation6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
	return  	result->HasPresentation(			
_aPresentableObject,			
aMode);
}
DECL_EXPORT void* PrsMgr_PresentationManager_Presentation6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
	return new Handle_PrsMgr_Presentation( 	result->Presentation(			
_aPresentableObject,			
aMode));
}
DECL_EXPORT bool PrsMgr_PresentationManager_IsImmediateModeOn(void* instance)
{
	PrsMgr_PresentationManager* result = (PrsMgr_PresentationManager*)(((Handle_PrsMgr_PresentationManager*)instance)->Access());
	return 	result->IsImmediateModeOn();
}

DECL_EXPORT void PrsMgrPresentationManager_Dtor(void* instance)
{
	delete (Handle_PrsMgr_PresentationManager*)instance;
}
