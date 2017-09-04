#ifndef Viewer_Viewer_H
#define Viewer_Viewer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Viewer_Viewer_Device(void* instance);
extern "C" DECL_EXPORT Standard_CString Viewer_Viewer_Domain(void* instance);
extern "C" DECL_EXPORT void ViewerViewer_Dtor(void* instance);

#endif
