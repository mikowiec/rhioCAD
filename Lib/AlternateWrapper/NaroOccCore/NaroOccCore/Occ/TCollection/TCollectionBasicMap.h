#ifndef TCollection_BasicMap_H
#define TCollection_BasicMap_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT int TCollection_BasicMap_NbBuckets(void* instance);
extern "C" DECL_EXPORT int TCollection_BasicMap_Extent(void* instance);
extern "C" DECL_EXPORT bool TCollection_BasicMap_IsEmpty(void* instance);
extern "C" DECL_EXPORT void TCollectionBasicMap_Dtor(void* instance);

#endif
