#ifndef StepData_SelectMember_H
#define StepData_SelectMember_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* StepData_SelectMember_Ctor();
extern "C" DECL_EXPORT Standard_CString StepData_SelectMember_Name(void* instance);
extern "C" DECL_EXPORT bool StepData_SelectMember_SetName9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT bool StepData_SelectMember_Matches9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT int StepData_SelectMember_Enum(void* instance);
extern "C" DECL_EXPORT Standard_CString StepData_SelectMember_EnumText(void* instance);
extern "C" DECL_EXPORT void StepData_SelectMember_SetEnumC9F1A165(
	void* instance,
	int val,
	char* text);
extern "C" DECL_EXPORT void StepData_SelectMember_SetEnumTextC9F1A165(
	void* instance,
	int val,
	char* text);
extern "C" DECL_EXPORT bool StepData_SelectMember_HasName(void* instance);
extern "C" DECL_EXPORT void StepData_SelectMember_SetKind(void* instance, int value);
extern "C" DECL_EXPORT int StepData_SelectMember_Kind(void* instance);
extern "C" DECL_EXPORT int StepData_SelectMember_ParamType(void* instance);
extern "C" DECL_EXPORT void StepData_SelectMember_SetInt(void* instance, int value);
extern "C" DECL_EXPORT int StepData_SelectMember_Int(void* instance);
extern "C" DECL_EXPORT void StepData_SelectMember_SetInteger(void* instance, int value);
extern "C" DECL_EXPORT int StepData_SelectMember_Integer(void* instance);
extern "C" DECL_EXPORT void StepData_SelectMember_SetBoolean(void* instance, bool value);
extern "C" DECL_EXPORT bool StepData_SelectMember_Boolean(void* instance);
extern "C" DECL_EXPORT void StepData_SelectMember_SetLogical(void* instance, int value);
extern "C" DECL_EXPORT int StepData_SelectMember_Logical(void* instance);
extern "C" DECL_EXPORT void StepData_SelectMember_SetReal(void* instance, double value);
extern "C" DECL_EXPORT double StepData_SelectMember_Real(void* instance);
extern "C" DECL_EXPORT void StepData_SelectMember_SetString(void* instance, char* value);
extern "C" DECL_EXPORT Standard_CString StepData_SelectMember_String(void* instance);
extern "C" DECL_EXPORT void StepDataSelectMember_Dtor(void* instance);

#endif
