#include "StandardGUID.h"
#include <Standard_GUID.hxx>


DECL_EXPORT void* Standard_GUID_Ctor()
{
	return new Standard_GUID();
}
DECL_EXPORT void* Standard_GUID_Ctor9381D4D(
	char* aGuid)
{
	return new Standard_GUID(			
aGuid);
}
DECL_EXPORT void* Standard_GUID_Ctor8CF7F0B1(
	int a32b,
	char a16b1,
	char a16b2,
	char a16b3,
	int a8b1,
	int a8b2,
	int a8b3,
	int a8b4,
	int a8b5,
	int a8b6)
{
	return new Standard_GUID(			
a32b,			
a16b1,			
a16b2,			
a16b3,			
a8b1,			
a8b2,			
a8b3,			
a8b4,			
a8b5,			
a8b6);
}
DECL_EXPORT void* Standard_GUID_CtorD6AA2C7F(
	void* aGuid)
{
		const Standard_GUID &  _aGuid =*(const Standard_GUID *)aGuid;
	return new Standard_GUID(			
_aGuid);
}
DECL_EXPORT bool Standard_GUID_IsSameD6AA2C7F(
	void* instance,
	void* uid)
{
		const Standard_GUID &  _uid =*(const Standard_GUID *)uid;
	Standard_GUID* result = (Standard_GUID*)instance;
	return  	result->IsSame(			
_uid);
}
DECL_EXPORT bool Standard_GUID_IsNotSameD6AA2C7F(
	void* instance,
	void* uid)
{
		const Standard_GUID &  _uid =*(const Standard_GUID *)uid;
	Standard_GUID* result = (Standard_GUID*)instance;
	return  	result->IsNotSame(			
_uid);
}
DECL_EXPORT bool Standard_GUID_CheckGUIDFormat9381D4D(
	char* aGuid)
{
	return  Standard_GUID::CheckGUIDFormat(			
aGuid);
}
DECL_EXPORT int Standard_GUID_HashE8219145(
	void* instance,
	int Upper)
{
	Standard_GUID* result = (Standard_GUID*)instance;
	return  	result->Hash(			
Upper);
}
DECL_EXPORT int Standard_GUID_HashCode5D88501F(
	void* aguid,
	int Upper)
{
		const Standard_GUID &  _aguid =*(const Standard_GUID *)aguid;
	return  Standard_GUID::HashCode(			
_aguid,			
Upper);
}
DECL_EXPORT bool Standard_GUID_IsEqualD560E032(
	void* string1,
	void* string2)
{
		const Standard_GUID &  _string1 =*(const Standard_GUID *)string1;
		const Standard_GUID &  _string2 =*(const Standard_GUID *)string2;
	return  Standard_GUID::IsEqual(			
_string1,			
_string2);
}
DECL_EXPORT void StandardGUID_Dtor(void* instance)
{
	delete (Standard_GUID*)instance;
}
