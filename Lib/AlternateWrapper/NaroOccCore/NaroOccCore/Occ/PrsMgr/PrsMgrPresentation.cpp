#include "PrsMgrPresentation.h"
#include <PrsMgr_Presentation.hxx>

#include <PrsMgr_PresentationManager.hxx>

DECL_EXPORT void* PrsMgr_Presentation_PresentationManager(void* instance)
{
	PrsMgr_Presentation* result = (PrsMgr_Presentation*)(((Handle_PrsMgr_Presentation*)instance)->Access());
	return 	new Handle_PrsMgr_PresentationManager(	result->PresentationManager());
}

DECL_EXPORT void PrsMgr_Presentation_SetUpdateStatus(void* instance, bool value)
{
	PrsMgr_Presentation* result = (PrsMgr_Presentation*)(((Handle_PrsMgr_Presentation*)instance)->Access());
		result->SetUpdateStatus(value);
}

DECL_EXPORT bool PrsMgr_Presentation_MustBeUpdated(void* instance)
{
	PrsMgr_Presentation* result = (PrsMgr_Presentation*)(((Handle_PrsMgr_Presentation*)instance)->Access());
	return 	result->MustBeUpdated();
}

DECL_EXPORT void PrsMgrPresentation_Dtor(void* instance)
{
	delete (Handle_PrsMgr_Presentation*)instance;
}
