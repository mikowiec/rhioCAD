#include "PrsMgrPresentation3d.h"
#include <PrsMgr_Presentation3d.hxx>


DECL_EXPORT int PrsMgr_Presentation3d_KindOfPresentation(void* instance)
{
	PrsMgr_Presentation3d* result = (PrsMgr_Presentation3d*)(((Handle_PrsMgr_Presentation3d*)instance)->Access());
	return (int)	result->KindOfPresentation();
}

DECL_EXPORT void PrsMgrPresentation3d_Dtor(void* instance)
{
	delete (Handle_PrsMgr_Presentation3d*)instance;
}
