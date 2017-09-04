#ifndef gce_Root_H
#define gce_Root_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT bool gce_Root_IsDone(void* instance);
extern "C" DECL_EXPORT int gce_Root_Status(void* instance);
extern "C" DECL_EXPORT void gceRoot_Dtor(void* instance);

#endif
