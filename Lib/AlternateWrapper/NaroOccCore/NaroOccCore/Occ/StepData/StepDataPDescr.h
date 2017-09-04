#ifndef StepData_PDescr_H
#define StepData_PDescr_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* StepData_PDescr_Ctor();
extern "C" DECL_EXPORT void StepData_PDescr_SetSelect(void* instance);
extern "C" DECL_EXPORT void StepData_PDescr_AddMemberE5051D76(
	void* instance,
	void* member);
extern "C" DECL_EXPORT void StepData_PDescr_SetInteger(void* instance);
extern "C" DECL_EXPORT void StepData_PDescr_SetReal(void* instance);
extern "C" DECL_EXPORT void StepData_PDescr_SetString(void* instance);
extern "C" DECL_EXPORT void StepData_PDescr_SetBoolean(void* instance);
extern "C" DECL_EXPORT void StepData_PDescr_SetLogical(void* instance);
extern "C" DECL_EXPORT void StepData_PDescr_SetEnum(void* instance);
extern "C" DECL_EXPORT void StepData_PDescr_AddEnumDef9381D4D(
	void* instance,
	char* enumdef);
extern "C" DECL_EXPORT void StepData_PDescr_AddArityE8219145(
	void* instance,
	int arity);
extern "C" DECL_EXPORT void StepData_PDescr_SetField800FADE1(
	void* instance,
	char* name,
	int rank);
extern "C" DECL_EXPORT void* StepData_PDescr_Member9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT int StepData_PDescr_EnumValue9381D4D(
	void* instance,
	char* name);
extern "C" DECL_EXPORT Standard_CString StepData_PDescr_EnumTextE8219145(
	void* instance,
	int val);
extern "C" DECL_EXPORT bool StepData_PDescr_IsTypeE2B3EAC1(
	void* instance,
	void* atype);
extern "C" DECL_EXPORT bool StepData_PDescr_IsDescr67A25A8F(
	void* instance,
	void* descr);
extern "C" DECL_EXPORT void StepData_PDescr_SetName(void* instance, char* value);
extern "C" DECL_EXPORT Standard_CString StepData_PDescr_Name(void* instance);
extern "C" DECL_EXPORT void StepData_PDescr_SetMemberName(void* instance, char* value);
extern "C" DECL_EXPORT void StepData_PDescr_SetDescr(void* instance, char* value);
extern "C" DECL_EXPORT void StepData_PDescr_SetFrom(void* instance, void* value);
extern "C" DECL_EXPORT void StepData_PDescr_SetOptional(void* instance, bool value);
extern "C" DECL_EXPORT void StepData_PDescr_SetDerived(void* instance, bool value);
extern "C" DECL_EXPORT bool StepData_PDescr_IsSelect(void* instance);
extern "C" DECL_EXPORT bool StepData_PDescr_IsInteger(void* instance);
extern "C" DECL_EXPORT bool StepData_PDescr_IsReal(void* instance);
extern "C" DECL_EXPORT bool StepData_PDescr_IsString(void* instance);
extern "C" DECL_EXPORT bool StepData_PDescr_IsBoolean(void* instance);
extern "C" DECL_EXPORT bool StepData_PDescr_IsLogical(void* instance);
extern "C" DECL_EXPORT bool StepData_PDescr_IsEnum(void* instance);
extern "C" DECL_EXPORT int StepData_PDescr_EnumMax(void* instance);
extern "C" DECL_EXPORT bool StepData_PDescr_IsEntity(void* instance);
extern "C" DECL_EXPORT void StepData_PDescr_SetType(void* instance, void* value);
extern "C" DECL_EXPORT void* StepData_PDescr_Type(void* instance);
extern "C" DECL_EXPORT Standard_CString StepData_PDescr_DescrName(void* instance);
extern "C" DECL_EXPORT void StepData_PDescr_SetArity(void* instance, int value);
extern "C" DECL_EXPORT int StepData_PDescr_Arity(void* instance);
extern "C" DECL_EXPORT void* StepData_PDescr_Simple(void* instance);
extern "C" DECL_EXPORT bool StepData_PDescr_IsOptional(void* instance);
extern "C" DECL_EXPORT bool StepData_PDescr_IsDerived(void* instance);
extern "C" DECL_EXPORT bool StepData_PDescr_IsField(void* instance);
extern "C" DECL_EXPORT Standard_CString StepData_PDescr_FieldName(void* instance);
extern "C" DECL_EXPORT int StepData_PDescr_FieldRank(void* instance);
extern "C" DECL_EXPORT void StepDataPDescr_Dtor(void* instance);

#endif
