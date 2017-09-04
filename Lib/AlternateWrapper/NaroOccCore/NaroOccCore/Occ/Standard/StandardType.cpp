#include "StandardType.h"
#include <Standard_Type.hxx>


DECL_EXPORT void* Standard_Type_Ctor800FADE1(
	char* aName,
	int aSize)
{
	return new Handle_Standard_Type(new Standard_Type(			
aName,			
aSize));
}
DECL_EXPORT void* Standard_Type_Ctor29DC790D(
	char* aName,
	int aSize,
	int aNumberOfParent,
	void* aAncestors)
{
	return new Handle_Standard_Type(new Standard_Type(			
aName,			
aSize,			
aNumberOfParent,			
aAncestors));
}
DECL_EXPORT void* Standard_Type_CtorAF7BE74A(
	char* aName,
	int aSize,
	int aNumberOfElement,
	int aNumberOfParent,
	void* anAncestors,
	void* aElements)
{
	return new Handle_Standard_Type(new Standard_Type(			
aName,			
aSize,			
aNumberOfElement,			
aNumberOfParent,			
anAncestors,			
aElements));
}
DECL_EXPORT void* Standard_Type_Ctor23B9A32F(
	char* aName,
	int aSize,
	int aNumberOfParent,
	void* anAncestors,
	void* aFields)
{
	return new Handle_Standard_Type(new Standard_Type(			
aName,			
aSize,			
aNumberOfParent,			
anAncestors,			
aFields));
}
DECL_EXPORT bool Standard_Type_SubTypeE2B3EAC1(
	void* instance,
	void* aOther)
{
		const Handle_Standard_Type&  _aOther =*(const Handle_Standard_Type *)aOther;
	Standard_Type* result = (Standard_Type*)(((Handle_Standard_Type*)instance)->Access());
	return  	result->SubType(			
_aOther);
}
DECL_EXPORT bool Standard_Type_SubType9381D4D(
	void* instance,
	char* theName)
{
	Standard_Type* result = (Standard_Type*)(((Handle_Standard_Type*)instance)->Access());
	return  	result->SubType(			
theName);
}
DECL_EXPORT Standard_CString Standard_Type_Name(void* instance)
{
	Standard_Type* result = (Standard_Type*)(((Handle_Standard_Type*)instance)->Access());
	return 	result->Name();
}

DECL_EXPORT int Standard_Type_Size(void* instance)
{
	Standard_Type* result = (Standard_Type*)(((Handle_Standard_Type*)instance)->Access());
	return 	result->Size();
}

DECL_EXPORT bool Standard_Type_IsImported(void* instance)
{
	Standard_Type* result = (Standard_Type*)(((Handle_Standard_Type*)instance)->Access());
	return 	result->IsImported();
}

DECL_EXPORT bool Standard_Type_IsPrimitive(void* instance)
{
	Standard_Type* result = (Standard_Type*)(((Handle_Standard_Type*)instance)->Access());
	return 	result->IsPrimitive();
}

DECL_EXPORT bool Standard_Type_IsEnumeration(void* instance)
{
	Standard_Type* result = (Standard_Type*)(((Handle_Standard_Type*)instance)->Access());
	return 	result->IsEnumeration();
}

DECL_EXPORT bool Standard_Type_IsClass(void* instance)
{
	Standard_Type* result = (Standard_Type*)(((Handle_Standard_Type*)instance)->Access());
	return 	result->IsClass();
}

DECL_EXPORT int Standard_Type_NumberOfParent(void* instance)
{
	Standard_Type* result = (Standard_Type*)(((Handle_Standard_Type*)instance)->Access());
	return 	result->NumberOfParent();
}

DECL_EXPORT int Standard_Type_NumberOfAncestor(void* instance)
{
	Standard_Type* result = (Standard_Type*)(((Handle_Standard_Type*)instance)->Access());
	return 	result->NumberOfAncestor();
}

DECL_EXPORT void StandardType_Dtor(void* instance)
{
	delete (Handle_Standard_Type*)instance;
}
