#ifndef BOP_BlockIterator_H
#define BOP_BlockIterator_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BOP_BlockIterator_Ctor();
extern "C" DECL_EXPORT void* BOP_BlockIterator_Ctor5107F6FE(
	int Lower,
	int Upper);
extern "C" DECL_EXPORT void BOP_BlockIterator_Initialize(void* instance);
extern "C" DECL_EXPORT void BOP_BlockIterator_Next(void* instance);
extern "C" DECL_EXPORT bool BOP_BlockIterator_More(void* instance);
extern "C" DECL_EXPORT int BOP_BlockIterator_Value(void* instance);
extern "C" DECL_EXPORT int BOP_BlockIterator_Extent(void* instance);
extern "C" DECL_EXPORT void BOPBlockIterator_Dtor(void* instance);

#endif
