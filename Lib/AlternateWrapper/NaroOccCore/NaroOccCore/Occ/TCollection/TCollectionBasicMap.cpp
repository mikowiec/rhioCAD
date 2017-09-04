#include "TCollectionBasicMap.h"
#include <TCollection_BasicMap.hxx>


DECL_EXPORT int TCollection_BasicMap_NbBuckets(void* instance)
{
	TCollection_BasicMap* result = (TCollection_BasicMap*)instance;
	return 	result->NbBuckets();
}

DECL_EXPORT int TCollection_BasicMap_Extent(void* instance)
{
	TCollection_BasicMap* result = (TCollection_BasicMap*)instance;
	return 	result->Extent();
}

DECL_EXPORT bool TCollection_BasicMap_IsEmpty(void* instance)
{
	TCollection_BasicMap* result = (TCollection_BasicMap*)instance;
	return 	result->IsEmpty();
}

DECL_EXPORT void TCollectionBasicMap_Dtor(void* instance)
{
	delete (TCollection_BasicMap*)instance;
}
