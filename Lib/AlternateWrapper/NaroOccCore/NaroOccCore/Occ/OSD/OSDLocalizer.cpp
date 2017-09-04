#include "OSDLocalizer.h"
#include <OSD_Localizer.hxx>


DECL_EXPORT void* OSD_Localizer_CtorC9F1A165(
	int Category,
	char* Locale)
{
	return new OSD_Localizer(			
Category,			
Locale);
}
DECL_EXPORT void OSD_Localizer_Restore(void* instance)
{
	OSD_Localizer* result = (OSD_Localizer*)instance;
 	result->Restore();
}
DECL_EXPORT void OSD_Localizer_SetLocaleC9F1A165(
	void* instance,
	int Category,
	char* Locale)
{
	OSD_Localizer* result = (OSD_Localizer*)instance;
 	result->SetLocale(			
Category,			
Locale);
}
DECL_EXPORT Standard_CString OSD_Localizer_Locale(void* instance)
{
	OSD_Localizer* result = (OSD_Localizer*)instance;
	return  	result->Locale();
}
DECL_EXPORT int OSD_Localizer_Category(void* instance)
{
	OSD_Localizer* result = (OSD_Localizer*)instance;
	return 	result->Category();
}

DECL_EXPORT void OSDLocalizer_Dtor(void* instance)
{
	delete (OSD_Localizer*)instance;
}
