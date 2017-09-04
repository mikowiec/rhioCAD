#include "CDMMetaData.h"
#include <CDM_MetaData.hxx>

#include <CDM_Document.hxx>
#include <CDM_MetaData.hxx>
#include <TCollection_ExtendedString.hxx>

DECL_EXPORT void* CDM_MetaData_LookUpCBFE3648(
	void* aFolder,
	void* aName,
	void* aPath,
	void* aFileName,
	bool ReadOnly)
{
		const TCollection_ExtendedString &  _aFolder =*(const TCollection_ExtendedString *)aFolder;
		const TCollection_ExtendedString &  _aName =*(const TCollection_ExtendedString *)aName;
		const TCollection_ExtendedString &  _aPath =*(const TCollection_ExtendedString *)aPath;
		const TCollection_ExtendedString &  _aFileName =*(const TCollection_ExtendedString *)aFileName;
	return new Handle_CDM_MetaData( CDM_MetaData::LookUp(			
_aFolder,			
_aName,			
_aPath,			
_aFileName,			
ReadOnly));
}
DECL_EXPORT void* CDM_MetaData_LookUp52AB094A(
	void* aFolder,
	void* aName,
	void* aPath,
	void* aVersion,
	void* aFileName,
	bool ReadOnly)
{
		const TCollection_ExtendedString &  _aFolder =*(const TCollection_ExtendedString *)aFolder;
		const TCollection_ExtendedString &  _aName =*(const TCollection_ExtendedString *)aName;
		const TCollection_ExtendedString &  _aPath =*(const TCollection_ExtendedString *)aPath;
		const TCollection_ExtendedString &  _aVersion =*(const TCollection_ExtendedString *)aVersion;
		const TCollection_ExtendedString &  _aFileName =*(const TCollection_ExtendedString *)aFileName;
	return new Handle_CDM_MetaData( CDM_MetaData::LookUp(			
_aFolder,			
_aName,			
_aPath,			
_aVersion,			
_aFileName,			
ReadOnly));
}
DECL_EXPORT void CDM_MetaData_UnsetDocument(void* instance)
{
	CDM_MetaData* result = (CDM_MetaData*)(((Handle_CDM_MetaData*)instance)->Access());
 	result->UnsetDocument();
}
DECL_EXPORT bool CDM_MetaData_IsReadOnly(void* instance)
{
	CDM_MetaData* result = (CDM_MetaData*)(((Handle_CDM_MetaData*)instance)->Access());
	return  	result->IsReadOnly();
}
DECL_EXPORT void CDM_MetaData_SetIsReadOnly(void* instance)
{
	CDM_MetaData* result = (CDM_MetaData*)(((Handle_CDM_MetaData*)instance)->Access());
 	result->SetIsReadOnly();
}
DECL_EXPORT void CDM_MetaData_UnsetIsReadOnly(void* instance)
{
	CDM_MetaData* result = (CDM_MetaData*)(((Handle_CDM_MetaData*)instance)->Access());
 	result->UnsetIsReadOnly();
}
DECL_EXPORT bool CDM_MetaData_IsRetrieved(void* instance)
{
	CDM_MetaData* result = (CDM_MetaData*)(((Handle_CDM_MetaData*)instance)->Access());
	return 	result->IsRetrieved();
}

DECL_EXPORT void* CDM_MetaData_Document(void* instance)
{
	CDM_MetaData* result = (CDM_MetaData*)(((Handle_CDM_MetaData*)instance)->Access());
	return 	new Handle_CDM_Document(	result->Document());
}

DECL_EXPORT void* CDM_MetaData_Folder(void* instance)
{
	CDM_MetaData* result = (CDM_MetaData*)(((Handle_CDM_MetaData*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->Folder());
}

DECL_EXPORT void* CDM_MetaData_Name(void* instance)
{
	CDM_MetaData* result = (CDM_MetaData*)(((Handle_CDM_MetaData*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->Name());
}

DECL_EXPORT void* CDM_MetaData_Version(void* instance)
{
	CDM_MetaData* result = (CDM_MetaData*)(((Handle_CDM_MetaData*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->Version());
}

DECL_EXPORT bool CDM_MetaData_HasVersion(void* instance)
{
	CDM_MetaData* result = (CDM_MetaData*)(((Handle_CDM_MetaData*)instance)->Access());
	return 	result->HasVersion();
}

DECL_EXPORT void* CDM_MetaData_FileName(void* instance)
{
	CDM_MetaData* result = (CDM_MetaData*)(((Handle_CDM_MetaData*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->FileName());
}

DECL_EXPORT void* CDM_MetaData_Path(void* instance)
{
	CDM_MetaData* result = (CDM_MetaData*)(((Handle_CDM_MetaData*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->Path());
}

DECL_EXPORT void CDMMetaData_Dtor(void* instance)
{
	delete (Handle_CDM_MetaData*)instance;
}
