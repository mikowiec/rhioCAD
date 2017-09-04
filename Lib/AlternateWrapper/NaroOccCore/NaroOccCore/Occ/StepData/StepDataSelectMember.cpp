#include "StepDataSelectMember.h"
#include <StepData_SelectMember.hxx>


DECL_EXPORT void* StepData_SelectMember_Ctor()
{
	return new Handle_StepData_SelectMember(new StepData_SelectMember());
}
DECL_EXPORT Standard_CString StepData_SelectMember_Name(void* instance)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return  	result->Name();
}
DECL_EXPORT bool StepData_SelectMember_SetName9381D4D(
	void* instance,
	char* name)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return  	result->SetName(			
name);
}
DECL_EXPORT bool StepData_SelectMember_Matches9381D4D(
	void* instance,
	char* name)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return  	result->Matches(			
name);
}
DECL_EXPORT int StepData_SelectMember_Enum(void* instance)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return  	result->Enum();
}
DECL_EXPORT Standard_CString StepData_SelectMember_EnumText(void* instance)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return  	result->EnumText();
}
DECL_EXPORT void StepData_SelectMember_SetEnumC9F1A165(
	void* instance,
	int val,
	char* text)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
 	result->SetEnum(			
val,			
text);
}
DECL_EXPORT void StepData_SelectMember_SetEnumTextC9F1A165(
	void* instance,
	int val,
	char* text)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
 	result->SetEnumText(			
val,			
text);
}
DECL_EXPORT bool StepData_SelectMember_HasName(void* instance)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return 	result->HasName();
}

DECL_EXPORT void StepData_SelectMember_SetKind(void* instance, int value)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
		result->SetKind(value);
}

DECL_EXPORT int StepData_SelectMember_Kind(void* instance)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return 	result->Kind();
}

DECL_EXPORT int StepData_SelectMember_ParamType(void* instance)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return (int)	result->ParamType();
}

DECL_EXPORT void StepData_SelectMember_SetInt(void* instance, int value)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
		result->SetInt(value);
}

DECL_EXPORT int StepData_SelectMember_Int(void* instance)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return 	result->Int();
}

DECL_EXPORT void StepData_SelectMember_SetInteger(void* instance, int value)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
		result->SetInteger(value);
}

DECL_EXPORT int StepData_SelectMember_Integer(void* instance)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return 	result->Integer();
}

DECL_EXPORT void StepData_SelectMember_SetBoolean(void* instance, bool value)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
		result->SetBoolean(value);
}

DECL_EXPORT bool StepData_SelectMember_Boolean(void* instance)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return 	result->Boolean();
}

DECL_EXPORT void StepData_SelectMember_SetLogical(void* instance, int value)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
		result->SetLogical((const StepData_Logical)value);
}

DECL_EXPORT int StepData_SelectMember_Logical(void* instance)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return (int)	result->Logical();
}

DECL_EXPORT void StepData_SelectMember_SetReal(void* instance, double value)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
		result->SetReal(value);
}

DECL_EXPORT double StepData_SelectMember_Real(void* instance)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return 	result->Real();
}

DECL_EXPORT void StepData_SelectMember_SetString(void* instance, char* value)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
		result->SetString(value);
}

DECL_EXPORT Standard_CString StepData_SelectMember_String(void* instance)
{
	StepData_SelectMember* result = (StepData_SelectMember*)(((Handle_StepData_SelectMember*)instance)->Access());
	return 	result->String();
}

DECL_EXPORT void StepDataSelectMember_Dtor(void* instance)
{
	delete (Handle_StepData_SelectMember*)instance;
}
