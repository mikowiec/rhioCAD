#include "BOPBlockIterator.h"
#include <BOP_BlockIterator.hxx>


DECL_EXPORT void* BOP_BlockIterator_Ctor()
{
	return new BOP_BlockIterator();
}
DECL_EXPORT void* BOP_BlockIterator_Ctor5107F6FE(
	int Lower,
	int Upper)
{
	return new BOP_BlockIterator(			
Lower,			
Upper);
}
DECL_EXPORT void BOP_BlockIterator_Initialize(void* instance)
{
	BOP_BlockIterator* result = (BOP_BlockIterator*)instance;
 	result->Initialize();
}
DECL_EXPORT void BOP_BlockIterator_Next(void* instance)
{
	BOP_BlockIterator* result = (BOP_BlockIterator*)instance;
 	result->Next();
}
DECL_EXPORT bool BOP_BlockIterator_More(void* instance)
{
	BOP_BlockIterator* result = (BOP_BlockIterator*)instance;
	return 	result->More();
}

DECL_EXPORT int BOP_BlockIterator_Value(void* instance)
{
	BOP_BlockIterator* result = (BOP_BlockIterator*)instance;
	return 	result->Value();
}

DECL_EXPORT int BOP_BlockIterator_Extent(void* instance)
{
	BOP_BlockIterator* result = (BOP_BlockIterator*)instance;
	return 	result->Extent();
}

DECL_EXPORT void BOPBlockIterator_Dtor(void* instance)
{
	delete (BOP_BlockIterator*)instance;
}
