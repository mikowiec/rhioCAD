#include "WNTWClass.h"
#include <WNT_WClass.hxx>


DECL_EXPORT Standard_CString WNT_WClass_Name(void* instance)
{
	WNT_WClass* result = (WNT_WClass*)(((Handle_WNT_WClass*)instance)->Access());
	return 	result->Name();
}

DECL_EXPORT void* WNT_WClass_Instance(void* instance)
{
	WNT_WClass* result = (WNT_WClass*)(((Handle_WNT_WClass*)instance)->Access());
	return 	result->Instance();
}

DECL_EXPORT void WNTWClass_Dtor(void* instance)
{
	delete (Handle_WNT_WClass*)instance;
}
