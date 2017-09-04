#ifndef OSD_Localizer_H
#define OSD_Localizer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* OSD_Localizer_CtorC9F1A165(
	int Category,
	char* Locale);
extern "C" DECL_EXPORT void OSD_Localizer_Restore(void* instance);
extern "C" DECL_EXPORT void OSD_Localizer_SetLocaleC9F1A165(
	void* instance,
	int Category,
	char* Locale);
extern "C" DECL_EXPORT Standard_CString OSD_Localizer_Locale(void* instance);
extern "C" DECL_EXPORT int OSD_Localizer_Category(void* instance);
extern "C" DECL_EXPORT void OSDLocalizer_Dtor(void* instance);

#endif
