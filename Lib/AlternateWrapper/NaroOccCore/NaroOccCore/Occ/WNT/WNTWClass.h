#ifndef WNT_WClass_H
#define WNT_WClass_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT Standard_CString WNT_WClass_Name(void* instance);
extern "C" DECL_EXPORT void* WNT_WClass_Instance(void* instance);
extern "C" DECL_EXPORT void WNTWClass_Dtor(void* instance);

#endif
