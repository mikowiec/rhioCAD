#include "TransferFinder.h"
#include <Transfer_Finder.hxx>

#include <Dico_DictionaryOfTransient.hxx>
#include <Standard_Transient.hxx>
#include <Standard_Type.hxx>

DECL_EXPORT void Transfer_Finder_SetAttributeD637E227(
	void* instance,
	char* name,
	void* val)
{
		const Handle_Standard_Transient&  _val =*(const Handle_Standard_Transient *)val;
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
 	result->SetAttribute(			
name,			
_val);
}
DECL_EXPORT bool Transfer_Finder_RemoveAttribute9381D4D(
	void* instance,
	char* name)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return  	result->RemoveAttribute(			
name);
}
DECL_EXPORT bool Transfer_Finder_GetAttributeCBA201FA(
	void* instance,
	char* name,
	void* type,
	void* val)
{
		const Handle_Standard_Type&  _type =*(const Handle_Standard_Type *)type;
		 Handle_Standard_Transient&  _val =*( Handle_Standard_Transient *)val;
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return  	result->GetAttribute(			
name,			
_type,			
_val);
}
DECL_EXPORT void* Transfer_Finder_Attribute9381D4D(
	void* instance,
	char* name)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return new Handle_Standard_Transient( 	result->Attribute(			
name));
}
DECL_EXPORT int Transfer_Finder_AttributeType9381D4D(
	void* instance,
	char* name)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return  	result->AttributeType(			
name);
}
DECL_EXPORT void Transfer_Finder_SetIntegerAttribute800FADE1(
	void* instance,
	char* name,
	int val)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
 	result->SetIntegerAttribute(			
name,			
val);
}
DECL_EXPORT bool Transfer_Finder_GetIntegerAttribute800FADE1(
	void* instance,
	char* name,
	int* val)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return  	result->GetIntegerAttribute(			
name,			
*val);
}
DECL_EXPORT int Transfer_Finder_IntegerAttribute9381D4D(
	void* instance,
	char* name)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return  	result->IntegerAttribute(			
name);
}
DECL_EXPORT void Transfer_Finder_SetRealAttribute28A665C3(
	void* instance,
	char* name,
	double val)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
 	result->SetRealAttribute(			
name,			
val);
}
DECL_EXPORT bool Transfer_Finder_GetRealAttribute28A665C3(
	void* instance,
	char* name,
	double* val)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return  	result->GetRealAttribute(			
name,			
*val);
}
DECL_EXPORT double Transfer_Finder_RealAttribute9381D4D(
	void* instance,
	char* name)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return  	result->RealAttribute(			
name);
}
DECL_EXPORT void Transfer_Finder_SetStringAttribute8A1B7C71(
	void* instance,
	char* name,
	char* val)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
 	result->SetStringAttribute(			
name,			
val);
}
DECL_EXPORT bool Transfer_Finder_GetStringAttribute8A1B7C71(
	void* instance,
	char* name,
	char** val)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return  	result->GetStringAttribute(			
name,			
(Standard_CString&)*val);
}
DECL_EXPORT Standard_CString Transfer_Finder_StringAttribute9381D4D(
	void* instance,
	char* name)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return  	result->StringAttribute(			
name);
}
DECL_EXPORT void Transfer_Finder_SameAttributes62F97174(
	void* instance,
	void* other)
{
		const Handle_Transfer_Finder&  _other =*(const Handle_Transfer_Finder *)other;
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
 	result->SameAttributes(			
_other);
}
DECL_EXPORT void Transfer_Finder_GetAttributesDA2BDE8C(
	void* instance,
	void* other,
	char* fromname,
	bool copied)
{
		const Handle_Transfer_Finder&  _other =*(const Handle_Transfer_Finder *)other;
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
 	result->GetAttributes(			
_other,			
fromname,			
copied);
}
DECL_EXPORT int Transfer_Finder_GetHashCode(void* instance)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return 	result->GetHashCode();
}

DECL_EXPORT void* Transfer_Finder_ValueType(void* instance)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return 	new Handle_Standard_Type(	result->ValueType());
}

DECL_EXPORT Standard_CString Transfer_Finder_ValueTypeName(void* instance)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return 	result->ValueTypeName();
}

DECL_EXPORT void* Transfer_Finder_AttrList(void* instance)
{
	Transfer_Finder* result = (Transfer_Finder*)(((Handle_Transfer_Finder*)instance)->Access());
	return 	new Handle_Dico_DictionaryOfTransient(	result->AttrList());
}

DECL_EXPORT void TransferFinder_Dtor(void* instance)
{
	delete (Handle_Transfer_Finder*)instance;
}
