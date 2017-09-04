#include "TCollectionBaseSequence.h"
#include <TCollection_BaseSequence.hxx>


DECL_EXPORT void TCollection_BaseSequence_Reverse(void* instance)
{
	TCollection_BaseSequence* result = (TCollection_BaseSequence*)instance;
 	result->Reverse();
}
DECL_EXPORT void TCollection_BaseSequence_Exchange5107F6FE(
	void* instance,
	int I,
	int J)
{
	TCollection_BaseSequence* result = (TCollection_BaseSequence*)instance;
 	result->Exchange(			
I,			
J);
}
DECL_EXPORT bool TCollection_BaseSequence_IsEmpty(void* instance)
{
	TCollection_BaseSequence* result = (TCollection_BaseSequence*)instance;
	return 	result->IsEmpty();
}

DECL_EXPORT int TCollection_BaseSequence_Length(void* instance)
{
	TCollection_BaseSequence* result = (TCollection_BaseSequence*)instance;
	return 	result->Length();
}

DECL_EXPORT void TCollectionBaseSequence_Dtor(void* instance)
{
	delete (TCollection_BaseSequence*)instance;
}
