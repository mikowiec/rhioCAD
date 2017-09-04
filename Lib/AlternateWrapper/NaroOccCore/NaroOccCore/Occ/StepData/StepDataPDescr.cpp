#include "StepDataPDescr.h"
#include <StepData_PDescr.hxx>

#include <Standard_Type.hxx>
#include <StepData_PDescr.hxx>

DECL_EXPORT void* StepData_PDescr_Ctor()
{
	return new Handle_StepData_PDescr(new StepData_PDescr());
}
DECL_EXPORT void StepData_PDescr_SetSelect(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
 	result->SetSelect();
}
DECL_EXPORT void StepData_PDescr_AddMemberE5051D76(
	void* instance,
	void* member)
{
		const Handle_StepData_PDescr&  _member =*(const Handle_StepData_PDescr *)member;
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
 	result->AddMember(			
_member);
}
DECL_EXPORT void StepData_PDescr_SetInteger(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
 	result->SetInteger();
}
DECL_EXPORT void StepData_PDescr_SetReal(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
 	result->SetReal();
}
DECL_EXPORT void StepData_PDescr_SetString(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
 	result->SetString();
}
DECL_EXPORT void StepData_PDescr_SetBoolean(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
 	result->SetBoolean();
}
DECL_EXPORT void StepData_PDescr_SetLogical(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
 	result->SetLogical();
}
DECL_EXPORT void StepData_PDescr_SetEnum(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
 	result->SetEnum();
}
DECL_EXPORT void StepData_PDescr_AddEnumDef9381D4D(
	void* instance,
	char* enumdef)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
 	result->AddEnumDef(			
enumdef);
}
DECL_EXPORT void StepData_PDescr_AddArityE8219145(
	void* instance,
	int arity)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
 	result->AddArity(			
arity);
}
DECL_EXPORT void StepData_PDescr_SetField800FADE1(
	void* instance,
	char* name,
	int rank)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
 	result->SetField(			
name,			
rank);
}
DECL_EXPORT void* StepData_PDescr_Member9381D4D(
	void* instance,
	char* name)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return new Handle_StepData_PDescr( 	result->Member(			
name));
}
DECL_EXPORT int StepData_PDescr_EnumValue9381D4D(
	void* instance,
	char* name)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return  	result->EnumValue(			
name);
}
DECL_EXPORT Standard_CString StepData_PDescr_EnumTextE8219145(
	void* instance,
	int val)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return  	result->EnumText(			
val);
}
DECL_EXPORT bool StepData_PDescr_IsTypeE2B3EAC1(
	void* instance,
	void* atype)
{
		const Handle_Standard_Type&  _atype =*(const Handle_Standard_Type *)atype;
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return  	result->IsType(			
_atype);
}
DECL_EXPORT bool StepData_PDescr_IsDescr67A25A8F(
	void* instance,
	void* descr)
{
		const Handle_StepData_EDescr&  _descr =*(const Handle_StepData_EDescr *)descr;
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return  	result->IsDescr(			
_descr);
}
DECL_EXPORT void StepData_PDescr_SetName(void* instance, char* value)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
		result->SetName(value);
}

DECL_EXPORT Standard_CString StepData_PDescr_Name(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->Name();
}

DECL_EXPORT void StepData_PDescr_SetMemberName(void* instance, char* value)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
		result->SetMemberName(value);
}

DECL_EXPORT void StepData_PDescr_SetDescr(void* instance, char* value)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
		result->SetDescr(value);
}

DECL_EXPORT void StepData_PDescr_SetFrom(void* instance, void* value)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
		result->SetFrom(*(const Handle_StepData_PDescr *)value);
}

DECL_EXPORT void StepData_PDescr_SetOptional(void* instance, bool value)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
		result->SetOptional(value);
}

DECL_EXPORT void StepData_PDescr_SetDerived(void* instance, bool value)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
		result->SetDerived(value);
}

DECL_EXPORT bool StepData_PDescr_IsSelect(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->IsSelect();
}

DECL_EXPORT bool StepData_PDescr_IsInteger(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->IsInteger();
}

DECL_EXPORT bool StepData_PDescr_IsReal(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->IsReal();
}

DECL_EXPORT bool StepData_PDescr_IsString(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->IsString();
}

DECL_EXPORT bool StepData_PDescr_IsBoolean(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->IsBoolean();
}

DECL_EXPORT bool StepData_PDescr_IsLogical(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->IsLogical();
}

DECL_EXPORT bool StepData_PDescr_IsEnum(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->IsEnum();
}

DECL_EXPORT int StepData_PDescr_EnumMax(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->EnumMax();
}

DECL_EXPORT bool StepData_PDescr_IsEntity(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->IsEntity();
}

DECL_EXPORT void StepData_PDescr_SetType(void* instance, void* value)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
		result->SetType(*(const Handle_Standard_Type *)value);
}

DECL_EXPORT void* StepData_PDescr_Type(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	new Handle_Standard_Type(	result->Type());
}

DECL_EXPORT Standard_CString StepData_PDescr_DescrName(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->DescrName();
}

DECL_EXPORT void StepData_PDescr_SetArity(void* instance, int value)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
		result->SetArity(value);
}

DECL_EXPORT int StepData_PDescr_Arity(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->Arity();
}

DECL_EXPORT void* StepData_PDescr_Simple(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	new Handle_StepData_PDescr(	result->Simple());
}

DECL_EXPORT bool StepData_PDescr_IsOptional(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->IsOptional();
}

DECL_EXPORT bool StepData_PDescr_IsDerived(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->IsDerived();
}

DECL_EXPORT bool StepData_PDescr_IsField(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->IsField();
}

DECL_EXPORT Standard_CString StepData_PDescr_FieldName(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->FieldName();
}

DECL_EXPORT int StepData_PDescr_FieldRank(void* instance)
{
	StepData_PDescr* result = (StepData_PDescr*)(((Handle_StepData_PDescr*)instance)->Access());
	return 	result->FieldRank();
}

DECL_EXPORT void StepDataPDescr_Dtor(void* instance)
{
	delete (Handle_StepData_PDescr*)instance;
}
