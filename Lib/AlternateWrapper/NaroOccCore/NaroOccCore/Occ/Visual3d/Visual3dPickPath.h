#ifndef Visual3d_PickPath_H
#define Visual3d_PickPath_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_PickPath_Ctor();
extern "C" DECL_EXPORT void Visual3d_PickPath_SetElementNumber(void* instance, int value);
extern "C" DECL_EXPORT int Visual3d_PickPath_ElementNumber(void* instance);
extern "C" DECL_EXPORT void Visual3d_PickPath_SetPickIdentifier(void* instance, int value);
extern "C" DECL_EXPORT int Visual3d_PickPath_PickIdentifier(void* instance);
extern "C" DECL_EXPORT void Visual3dPickPath_Dtor(void* instance);

#endif
