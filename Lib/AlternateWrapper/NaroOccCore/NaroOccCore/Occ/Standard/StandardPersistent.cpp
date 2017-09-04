#include "StandardPersistent.h"
#include <Standard_Persistent.hxx>

#include <Standard_Type.hxx>

DECL_EXPORT void Standard_Persistent_Delete(void* instance)
{
	Standard_Persistent* result = (Standard_Persistent*)instance;
 	result->Delete();
}
DECL_EXPORT bool Standard_Persistent_IsInstanceE2B3EAC1(
	void* instance,
	void* TheType)
{
		const Handle_Standard_Type&  _TheType =*(const Handle_Standard_Type *)TheType;
	Standard_Persistent* result = (Standard_Persistent*)instance;
	return  	result->IsInstance(			
_TheType);
}
DECL_EXPORT bool Standard_Persistent_IsKindE2B3EAC1(
	void* instance,
	void* TheType)
{
		const Handle_Standard_Type&  _TheType =*(const Handle_Standard_Type *)TheType;
	Standard_Persistent* result = (Standard_Persistent*)instance;
	return  	result->IsKind(			
_TheType);
}
DECL_EXPORT void* Standard_Persistent_DynamicType(void* instance)
{
	Standard_Persistent* result = (Standard_Persistent*)instance;
	return 	new Handle_Standard_Type(	result->DynamicType());
}

DECL_EXPORT void StandardPersistent_Dtor(void* instance)
{
	delete (Standard_Persistent*)instance;
}
