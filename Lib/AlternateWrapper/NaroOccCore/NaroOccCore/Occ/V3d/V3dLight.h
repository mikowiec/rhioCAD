#ifndef V3d_Light_H
#define V3d_Light_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT int V3d_Light_Type(void* instance);
extern "C" DECL_EXPORT bool V3d_Light_Headlight(void* instance);
extern "C" DECL_EXPORT bool V3d_Light_IsDisplayed(void* instance);
extern "C" DECL_EXPORT void V3dLight_Dtor(void* instance);

#endif
