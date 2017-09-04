#include "BOPToolsInterference.h"
#include <BOPTools_Interference.hxx>


DECL_EXPORT void* BOPTools_Interference_Ctor()
{
	return new BOPTools_Interference();
}
DECL_EXPORT void* BOPTools_Interference_CtorF7A1D3E9(
	int aWith,
	int aType,
	int anIndex)
{
		const BooleanOperations_KindOfInterference _aType =(const BooleanOperations_KindOfInterference )aType;
	return new BOPTools_Interference(			
aWith,			
_aType,			
anIndex);
}
DECL_EXPORT void BOPTools_Interference_SetWith(void* instance, int value)
{
	BOPTools_Interference* result = (BOPTools_Interference*)instance;
		result->SetWith(value);
}

DECL_EXPORT int BOPTools_Interference_With(void* instance)
{
	BOPTools_Interference* result = (BOPTools_Interference*)instance;
	return 	result->With();
}

DECL_EXPORT void BOPTools_Interference_SetType(void* instance, int value)
{
	BOPTools_Interference* result = (BOPTools_Interference*)instance;
		result->SetType((const BooleanOperations_KindOfInterference)value);
}

DECL_EXPORT int BOPTools_Interference_Type(void* instance)
{
	BOPTools_Interference* result = (BOPTools_Interference*)instance;
	return (int)	result->Type();
}

DECL_EXPORT void BOPTools_Interference_SetIndex(void* instance, int value)
{
	BOPTools_Interference* result = (BOPTools_Interference*)instance;
		result->SetIndex(value);
}

DECL_EXPORT int BOPTools_Interference_Index(void* instance)
{
	BOPTools_Interference* result = (BOPTools_Interference*)instance;
	return 	result->Index();
}

DECL_EXPORT void BOPToolsInterference_Dtor(void* instance)
{
	delete (BOPTools_Interference*)instance;
}
