#include "StandardTransient.h"
#include <Standard_Transient.hxx>

#include <Standard_Type.hxx>

//DECL_EXPORT int Standard_Transient_HashCodeE8219145(
//	void* instance,
//	int Upper)
//{
//	Standard_Transient* result = (Standard_Transient*)(((Handle_Standard_Transient*)instance)->Access());
//	return  	result->HashCode(			
//Upper);
//}
DECL_EXPORT void Standard_Transient_Delete(void* instance)
{
	Standard_Transient* result = (Standard_Transient*)(((Handle_Standard_Transient*)instance)->Access());
 	result->Delete();
}
DECL_EXPORT bool Standard_Transient_IsInstanceE2B3EAC1(
	void* instance,
	void* TheType)
{
		 Handle_Standard_Type&  _TheType =*( Handle_Standard_Type *)TheType;
	Standard_Transient* result = (Standard_Transient*)(((Handle_Standard_Transient*)instance)->Access());
	return  	result->IsInstance(			
_TheType);
}
DECL_EXPORT bool Standard_Transient_IsInstance9381D4D(
	void* instance,
	char* TheTypeName)
{
	Standard_Transient* result = (Standard_Transient*)(((Handle_Standard_Transient*)instance)->Access());
	return  	result->IsInstance(			
TheTypeName);
}
DECL_EXPORT bool Standard_Transient_IsKindE2B3EAC1(
	void* instance,
	void* TheType)
{
		 Handle_Standard_Type&  _TheType =*( Handle_Standard_Type *)TheType;
	Standard_Transient* result = (Standard_Transient*)(((Handle_Standard_Transient*)instance)->Access());
	return  	result->IsKind(			
_TheType);
}
DECL_EXPORT bool Standard_Transient_IsKind9381D4D(
	void* instance,
	char* TheTypeName)
{
	Standard_Transient* result = (Standard_Transient*)(((Handle_Standard_Transient*)instance)->Access());
	return  	result->IsKind(			
TheTypeName);
}
DECL_EXPORT void* Standard_Transient_DynamicType(void* instance)
{
	Standard_Transient* result = (Standard_Transient*)(((Handle_Standard_Transient*)instance)->Access());
	return 	new Handle_Standard_Type(	result->DynamicType());
}

DECL_EXPORT int Standard_Transient_GetRefCount(void* instance)
{
	Standard_Transient* result = (Standard_Transient*)(((Handle_Standard_Transient*)instance)->Access());
	return 	result->GetRefCount();
}

DECL_EXPORT bool Standard_Transient_IsSameTransientF411CB01(
	void* instance,
	void* other)
{
    Handle_Standard_Transient* result = (Handle_Standard_Transient*)instance;
    Handle_Standard_Transient* data = (Handle_Standard_Transient*)other;
	return *result == *data;
}

DECL_EXPORT void* StandardTransiemt_NewHandle(void* instance)
{
    Handle_Standard_Transient* result = (Handle_Standard_Transient*)instance;
    return new Handle_Standard_Transient(*result);
}

DECL_EXPORT void StandardTransient_Dtor(void* instance)
{
	delete (Handle_Standard_Transient*)instance;
}
