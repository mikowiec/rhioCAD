#ifndef GC_Root_H
#define GC_Root_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT bool GC_Root_IsDone(void* instance);
extern "C" DECL_EXPORT int GC_Root_Status(void* instance);
extern "C" DECL_EXPORT void GCRoot_Dtor(void* instance);

#endif
