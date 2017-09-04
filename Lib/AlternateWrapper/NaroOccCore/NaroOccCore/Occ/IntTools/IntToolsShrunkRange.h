#ifndef IntTools_ShrunkRange_H
#define IntTools_ShrunkRange_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntTools_ShrunkRange_Ctor();
extern "C" DECL_EXPORT void IntTools_ShrunkRange_Perform(void* instance);
extern "C" DECL_EXPORT void IntTools_ShrunkRange_SetShrunkRange(void* instance, void* value);
extern "C" DECL_EXPORT void* IntTools_ShrunkRange_ShrunkRange(void* instance);
extern "C" DECL_EXPORT void* IntTools_ShrunkRange_BndBox(void* instance);
extern "C" DECL_EXPORT void* IntTools_ShrunkRange_Edge(void* instance);
extern "C" DECL_EXPORT bool IntTools_ShrunkRange_IsDone(void* instance);
extern "C" DECL_EXPORT int IntTools_ShrunkRange_ErrorStatus(void* instance);
extern "C" DECL_EXPORT void IntToolsShrunkRange_Dtor(void* instance);

#endif
