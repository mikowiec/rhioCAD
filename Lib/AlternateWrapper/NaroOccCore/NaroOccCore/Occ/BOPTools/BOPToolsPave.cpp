#include "BOPToolsPave.h"
#include <BOPTools_Pave.hxx>


DECL_EXPORT void* BOPTools_Pave_Ctor()
{
	return new BOPTools_Pave();
}
DECL_EXPORT void* BOPTools_Pave_Ctor62B18AF(
	int Index,
	double aParam,
	int aType)
{
		const BooleanOperations_KindOfInterference _aType =(const BooleanOperations_KindOfInterference )aType;
	return new BOPTools_Pave(			
Index,			
aParam,			
_aType);
}
DECL_EXPORT bool BOPTools_Pave_IsEqual3EED610E(
	void* instance,
	void* Other)
{
		const BOPTools_Pave &  _Other =*(const BOPTools_Pave *)Other;
	BOPTools_Pave* result = (BOPTools_Pave*)instance;
	return  	result->IsEqual(			
_Other);
}
DECL_EXPORT void BOPTools_Pave_SetParam(void* instance, double value)
{
	BOPTools_Pave* result = (BOPTools_Pave*)instance;
		result->SetParam(value);
}

DECL_EXPORT double BOPTools_Pave_Param(void* instance)
{
	BOPTools_Pave* result = (BOPTools_Pave*)instance;
	return 	result->Param();
}

DECL_EXPORT void BOPTools_Pave_SetIndex(void* instance, int value)
{
	BOPTools_Pave* result = (BOPTools_Pave*)instance;
		result->SetIndex(value);
}

DECL_EXPORT int BOPTools_Pave_Index(void* instance)
{
	BOPTools_Pave* result = (BOPTools_Pave*)instance;
	return 	result->Index();
}

DECL_EXPORT void BOPTools_Pave_SetType(void* instance, int value)
{
	BOPTools_Pave* result = (BOPTools_Pave*)instance;
		result->SetType((const BooleanOperations_KindOfInterference)value);
}

DECL_EXPORT int BOPTools_Pave_Type(void* instance)
{
	BOPTools_Pave* result = (BOPTools_Pave*)instance;
	return (int)	result->Type();
}

DECL_EXPORT void BOPTools_Pave_SetInterference(void* instance, int value)
{
	BOPTools_Pave* result = (BOPTools_Pave*)instance;
		result->SetInterference(value);
}

DECL_EXPORT int BOPTools_Pave_Interference(void* instance)
{
	BOPTools_Pave* result = (BOPTools_Pave*)instance;
	return 	result->Interference();
}

DECL_EXPORT void BOPToolsPave_Dtor(void* instance)
{
	delete (BOPTools_Pave*)instance;
}
