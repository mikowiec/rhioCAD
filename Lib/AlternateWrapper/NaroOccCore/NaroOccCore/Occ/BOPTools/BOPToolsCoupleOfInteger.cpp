#include "BOPToolsCoupleOfInteger.h"
#include <BOPTools_CoupleOfInteger.hxx>


DECL_EXPORT void* BOPTools_CoupleOfInteger_Ctor()
{
	return new BOPTools_CoupleOfInteger();
}
DECL_EXPORT void* BOPTools_CoupleOfInteger_Ctor5107F6FE(
	int aFirst,
	int aSecond)
{
	return new BOPTools_CoupleOfInteger(			
aFirst,			
aSecond);
}
DECL_EXPORT void BOPTools_CoupleOfInteger_SetCouple5107F6FE(
	void* instance,
	int aFirst,
	int aSecond)
{
	BOPTools_CoupleOfInteger* result = (BOPTools_CoupleOfInteger*)instance;
 	result->SetCouple(			
aFirst,			
aSecond);
}
DECL_EXPORT void BOPTools_CoupleOfInteger_Couple5107F6FE(
	void* instance,
	int* aFirst,
	int* aSecond)
{
	BOPTools_CoupleOfInteger* result = (BOPTools_CoupleOfInteger*)instance;
 	result->Couple(			
*aFirst,			
*aSecond);
}
DECL_EXPORT bool BOPTools_CoupleOfInteger_IsEqual692F43DE(
	void* instance,
	void* aOther)
{
		const BOPTools_CoupleOfInteger &  _aOther =*(const BOPTools_CoupleOfInteger *)aOther;
	BOPTools_CoupleOfInteger* result = (BOPTools_CoupleOfInteger*)instance;
	return  	result->IsEqual(			
_aOther);
}
DECL_EXPORT int BOPTools_CoupleOfInteger_HashCodeE8219145(
	void* instance,
	int Upper)
{
	BOPTools_CoupleOfInteger* result = (BOPTools_CoupleOfInteger*)instance;
	return  	result->HashCode(			
Upper);
}
DECL_EXPORT void BOPTools_CoupleOfInteger_SetFirst(void* instance, int value)
{
	BOPTools_CoupleOfInteger* result = (BOPTools_CoupleOfInteger*)instance;
		result->SetFirst(value);
}

DECL_EXPORT int BOPTools_CoupleOfInteger_First(void* instance)
{
	BOPTools_CoupleOfInteger* result = (BOPTools_CoupleOfInteger*)instance;
	return 	result->First();
}

DECL_EXPORT void BOPTools_CoupleOfInteger_SetSecond(void* instance, int value)
{
	BOPTools_CoupleOfInteger* result = (BOPTools_CoupleOfInteger*)instance;
		result->SetSecond(value);
}

DECL_EXPORT int BOPTools_CoupleOfInteger_Second(void* instance)
{
	BOPTools_CoupleOfInteger* result = (BOPTools_CoupleOfInteger*)instance;
	return 	result->Second();
}

DECL_EXPORT void BOPToolsCoupleOfInteger_Dtor(void* instance)
{
	delete (BOPTools_CoupleOfInteger*)instance;
}
