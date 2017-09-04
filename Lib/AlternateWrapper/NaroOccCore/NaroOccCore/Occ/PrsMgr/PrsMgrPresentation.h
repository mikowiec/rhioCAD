#ifndef PrsMgr_Presentation_H
#define PrsMgr_Presentation_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* PrsMgr_Presentation_PresentationManager(void* instance);
extern "C" DECL_EXPORT void PrsMgr_Presentation_SetUpdateStatus(void* instance, bool value);
extern "C" DECL_EXPORT bool PrsMgr_Presentation_MustBeUpdated(void* instance);
extern "C" DECL_EXPORT void PrsMgrPresentation_Dtor(void* instance);

#endif
