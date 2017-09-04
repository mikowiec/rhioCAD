#ifndef TCollection_BaseSequence_H
#define TCollection_BaseSequence_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void TCollection_BaseSequence_Reverse(void* instance);
extern "C" DECL_EXPORT void TCollection_BaseSequence_Exchange5107F6FE(
	void* instance,
	int I,
	int J);
extern "C" DECL_EXPORT bool TCollection_BaseSequence_IsEmpty(void* instance);
extern "C" DECL_EXPORT int TCollection_BaseSequence_Length(void* instance);
extern "C" DECL_EXPORT void TCollectionBaseSequence_Dtor(void* instance);

#endif
