#ifndef IntTools_BaseRangeSample_H
#define IntTools_BaseRangeSample_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntTools_BaseRangeSample_Ctor();
extern "C" DECL_EXPORT void* IntTools_BaseRangeSample_CtorE8219145(
	int theDepth);
extern "C" DECL_EXPORT void IntTools_BaseRangeSample_SetDepth(void* instance, int value);
extern "C" DECL_EXPORT int IntTools_BaseRangeSample_GetDepth(void* instance);
extern "C" DECL_EXPORT void IntToolsBaseRangeSample_Dtor(void* instance);

#endif
