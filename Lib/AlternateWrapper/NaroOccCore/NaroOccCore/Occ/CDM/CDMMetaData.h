#ifndef CDM_MetaData_H
#define CDM_MetaData_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* CDM_MetaData_LookUpCBFE3648(
	void* aFolder,
	void* aName,
	void* aPath,
	void* aFileName,
	bool ReadOnly);
extern "C" DECL_EXPORT void* CDM_MetaData_LookUp52AB094A(
	void* aFolder,
	void* aName,
	void* aPath,
	void* aVersion,
	void* aFileName,
	bool ReadOnly);
extern "C" DECL_EXPORT void CDM_MetaData_UnsetDocument(void* instance);
extern "C" DECL_EXPORT bool CDM_MetaData_IsReadOnly(void* instance);
extern "C" DECL_EXPORT void CDM_MetaData_SetIsReadOnly(void* instance);
extern "C" DECL_EXPORT void CDM_MetaData_UnsetIsReadOnly(void* instance);
extern "C" DECL_EXPORT bool CDM_MetaData_IsRetrieved(void* instance);
extern "C" DECL_EXPORT void* CDM_MetaData_Document(void* instance);
extern "C" DECL_EXPORT void* CDM_MetaData_Folder(void* instance);
extern "C" DECL_EXPORT void* CDM_MetaData_Name(void* instance);
extern "C" DECL_EXPORT void* CDM_MetaData_Version(void* instance);
extern "C" DECL_EXPORT bool CDM_MetaData_HasVersion(void* instance);
extern "C" DECL_EXPORT void* CDM_MetaData_FileName(void* instance);
extern "C" DECL_EXPORT void* CDM_MetaData_Path(void* instance);
extern "C" DECL_EXPORT void CDMMetaData_Dtor(void* instance);

#endif
