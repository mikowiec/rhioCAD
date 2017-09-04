#ifndef CDM_Application_H
#define CDM_Application_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void CDM_Application_BeginOfUpdate3DDF553A(
	void* instance,
	void* aDocument);
extern "C" DECL_EXPORT void CDM_Application_EndOfUpdateE3A9B7F3(
	void* instance,
	void* aDocument,
	bool Status,
	void* ErrorString);
extern "C" DECL_EXPORT void CDM_Application_Write9381D4D(
	void* instance,
	char* aString);
extern "C" DECL_EXPORT void* CDM_Application_MessageDriver(void* instance);
extern "C" DECL_EXPORT void CDMApplication_Dtor(void* instance);

#endif
