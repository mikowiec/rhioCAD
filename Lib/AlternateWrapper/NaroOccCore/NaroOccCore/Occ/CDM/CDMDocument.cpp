#include "CDMDocument.h"
#include <CDM_Document.hxx>

#include <CDM_Application.hxx>
#include <CDM_Document.hxx>
#include <CDM_MetaData.hxx>
#include <Standard_GUID.hxx>
#include <TCollection_ExtendedString.hxx>

DECL_EXPORT bool CDM_Document_GetAlternativeDocumentF38A10D6(
	void* instance,
	void* aFormat,
	void* anAlternativeDocument)
{
		const TCollection_ExtendedString &  _aFormat =*(const TCollection_ExtendedString *)aFormat;
		 Handle_CDM_Document&  _anAlternativeDocument =*( Handle_CDM_Document *)anAlternativeDocument;
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->GetAlternativeDocument(			
_aFormat,			
_anAlternativeDocument);
}
DECL_EXPORT int CDM_Document_CreateReference3DDF553A(
	void* instance,
	void* anOtherDocument)
{
		const Handle_CDM_Document&  _anOtherDocument =*(const Handle_CDM_Document *)anOtherDocument;
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->CreateReference(			
_anOtherDocument);
}
DECL_EXPORT void CDM_Document_RemoveReferenceE8219145(
	void* instance,
	int aReferenceIdentifier)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->RemoveReference(			
aReferenceIdentifier);
}
DECL_EXPORT void CDM_Document_RemoveAllReferences(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->RemoveAllReferences();
}
DECL_EXPORT void* CDM_Document_DocumentE8219145(
	void* instance,
	int aReferenceIdentifier)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return new Handle_CDM_Document( 	result->Document(			
aReferenceIdentifier));
}
DECL_EXPORT bool CDM_Document_IsInSessionE8219145(
	void* instance,
	int aReferenceIdentifier)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->IsInSession(			
aReferenceIdentifier);
}
DECL_EXPORT bool CDM_Document_IsStoredE8219145(
	void* instance,
	int aReferenceIdentifier)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->IsStored(			
aReferenceIdentifier);
}
DECL_EXPORT void* CDM_Document_NameE8219145(
	void* instance,
	int aReferenceIdentifier)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return new TCollection_ExtendedString( 	result->Name(			
aReferenceIdentifier));
}
DECL_EXPORT bool CDM_Document_ShallowReferences3DDF553A(
	void* instance,
	void* aDocument)
{
		const Handle_CDM_Document&  _aDocument =*(const Handle_CDM_Document *)aDocument;
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->ShallowReferences(			
_aDocument);
}
DECL_EXPORT bool CDM_Document_DeepReferences3DDF553A(
	void* instance,
	void* aDocument)
{
		const Handle_CDM_Document&  _aDocument =*(const Handle_CDM_Document *)aDocument;
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->DeepReferences(			
_aDocument);
}
DECL_EXPORT int CDM_Document_CopyReference706B147E(
	void* instance,
	void* aFromDocument,
	int aReferenceIdentifier)
{
		const Handle_CDM_Document&  _aFromDocument =*(const Handle_CDM_Document *)aFromDocument;
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->CopyReference(			
_aFromDocument,			
aReferenceIdentifier);
}
DECL_EXPORT bool CDM_Document_IsReadOnly(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->IsReadOnly();
}
DECL_EXPORT bool CDM_Document_IsReadOnlyE8219145(
	void* instance,
	int aReferenceIdentifier)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->IsReadOnly(			
aReferenceIdentifier);
}
DECL_EXPORT void CDM_Document_SetIsReadOnly(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->SetIsReadOnly();
}
DECL_EXPORT void CDM_Document_UnsetIsReadOnly(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->UnsetIsReadOnly();
}
DECL_EXPORT void CDM_Document_Modify(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->Modify();
}
DECL_EXPORT void CDM_Document_UnModify(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->UnModify();
}
DECL_EXPORT bool CDM_Document_IsUpToDateE8219145(
	void* instance,
	int aReferenceIdentifier)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->IsUpToDate(			
aReferenceIdentifier);
}
DECL_EXPORT void CDM_Document_SetIsUpToDateE8219145(
	void* instance,
	int aReferenceIdentifier)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->SetIsUpToDate(			
aReferenceIdentifier);
}
DECL_EXPORT void CDM_Document_AddComment6EE6EE89(
	void* instance,
	void* aComment)
{
		const TCollection_ExtendedString &  _aComment =*(const TCollection_ExtendedString *)aComment;
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->AddComment(			
_aComment);
}
DECL_EXPORT void* CDM_Document_FindFromPresentation6EE6EE89(
	void* aPresentation)
{
		const TCollection_ExtendedString &  _aPresentation =*(const TCollection_ExtendedString *)aPresentation;
	return new Handle_CDM_Document( CDM_Document::FindFromPresentation(			
_aPresentation));
}
DECL_EXPORT bool CDM_Document_FindPresentation6EE6EE89(
	void* aPresentation)
{
		const TCollection_ExtendedString &  _aPresentation =*(const TCollection_ExtendedString *)aPresentation;
	return  CDM_Document::FindPresentation(			
_aPresentation);
}
DECL_EXPORT bool CDM_Document_IsStored(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->IsStored();
}
DECL_EXPORT void CDM_Document_UnsetIsStored(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->UnsetIsStored();
}
DECL_EXPORT void CDM_Document_UnsetRequestedPreviousVersion(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->UnsetRequestedPreviousVersion();
}
DECL_EXPORT void CDM_Document_LoadResources(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->LoadResources();
}
DECL_EXPORT bool CDM_Document_IsOpened(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->IsOpened();
}
DECL_EXPORT void CDM_Document_Open6724CADE(
	void* instance,
	void* anApplication)
{
		const Handle_CDM_Application&  _anApplication =*(const Handle_CDM_Application *)anApplication;
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->Open(			
_anApplication);
}
DECL_EXPORT void CDM_Document_Close(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->Close();
}
DECL_EXPORT bool CDM_Document_CanCloseReference706B147E(
	void* instance,
	void* aDocument,
	int aReferenceIdentifier)
{
		const Handle_CDM_Document&  _aDocument =*(const Handle_CDM_Document *)aDocument;
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->CanCloseReference(			
_aDocument,			
aReferenceIdentifier);
}
DECL_EXPORT void CDM_Document_CloseReference706B147E(
	void* instance,
	void* aDocument,
	int aReferenceIdentifier)
{
		const Handle_CDM_Document&  _aDocument =*(const Handle_CDM_Document *)aDocument;
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->CloseReference(			
_aDocument,			
aReferenceIdentifier);
}
DECL_EXPORT bool CDM_Document_IsOpenedE8219145(
	void* instance,
	int aReferenceIdentifier)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->IsOpened(			
aReferenceIdentifier);
}
DECL_EXPORT void CDM_Document_CreateReferenceA7DD6C1D(
	void* instance,
	void* aMetaData,
	int aReferenceIdentifier,
	void* anApplication,
	int aToDocumentVersion,
	bool UseStorageConfiguration)
{
		const Handle_CDM_MetaData&  _aMetaData =*(const Handle_CDM_MetaData *)aMetaData;
		const Handle_CDM_Application&  _anApplication =*(const Handle_CDM_Application *)anApplication;
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
 	result->CreateReference(			
_aMetaData,			
aReferenceIdentifier,			
_anApplication,			
aToDocumentVersion,			
UseStorageConfiguration);
}
DECL_EXPORT int CDM_Document_CreateReference8DBBF2BC(
	void* instance,
	void* aMetaData,
	void* anApplication,
	int aDocumentVersion,
	bool UseStorageConfiguration)
{
		const Handle_CDM_MetaData&  _aMetaData =*(const Handle_CDM_MetaData *)aMetaData;
		const Handle_CDM_Application&  _anApplication =*(const Handle_CDM_Application *)anApplication;
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return  	result->CreateReference(			
_aMetaData,			
_anApplication,			
aDocumentVersion,			
UseStorageConfiguration);
}
DECL_EXPORT int CDM_Document_ToReferencesNumber(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->ToReferencesNumber();
}

DECL_EXPORT int CDM_Document_FromReferencesNumber(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->FromReferencesNumber();
}

DECL_EXPORT int CDM_Document_Modifications(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->Modifications();
}

DECL_EXPORT void CDM_Document_SetComment(void* instance, void* value)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
		result->SetComment(*(const TCollection_ExtendedString *)value);
}

DECL_EXPORT void* CDM_Document_Comment(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->Comment());
}

DECL_EXPORT int CDM_Document_StorageVersion(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->StorageVersion();
}

DECL_EXPORT void CDM_Document_SetMetaData(void* instance, void* value)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
		result->SetMetaData(*(const Handle_CDM_MetaData *)value);
}

DECL_EXPORT void* CDM_Document_MetaData(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new Handle_CDM_MetaData(	result->MetaData());
}

DECL_EXPORT void* CDM_Document_Folder(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->Folder());
}

DECL_EXPORT void CDM_Document_SetRequestedFolder(void* instance, void* value)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
		result->SetRequestedFolder(*(const TCollection_ExtendedString *)value);
}

DECL_EXPORT void* CDM_Document_RequestedFolder(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->RequestedFolder());
}

DECL_EXPORT bool CDM_Document_HasRequestedFolder(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->HasRequestedFolder();
}

DECL_EXPORT void CDM_Document_SetRequestedName(void* instance, void* value)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
		result->SetRequestedName(*(const TCollection_ExtendedString *)value);
}

DECL_EXPORT void* CDM_Document_RequestedName(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->RequestedName());
}

DECL_EXPORT bool CDM_Document_HasRequestedPreviousVersion(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->HasRequestedPreviousVersion();
}

DECL_EXPORT void CDM_Document_SetRequestedPreviousVersion(void* instance, void* value)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
		result->SetRequestedPreviousVersion(*(const TCollection_ExtendedString *)value);
}

DECL_EXPORT void* CDM_Document_RequestedPreviousVersion(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->RequestedPreviousVersion());
}

DECL_EXPORT void CDM_Document_SetRequestedComment(void* instance, void* value)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
		result->SetRequestedComment(*(const TCollection_ExtendedString *)value);
}

DECL_EXPORT void* CDM_Document_RequestedComment(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->RequestedComment());
}

DECL_EXPORT bool CDM_Document_FindFileExtension(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->FindFileExtension();
}

DECL_EXPORT void* CDM_Document_FileExtension(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->FileExtension());
}

DECL_EXPORT bool CDM_Document_FindDataType(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->FindDataType();
}

DECL_EXPORT void* CDM_Document_DataType(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->DataType());
}

DECL_EXPORT bool CDM_Document_FindVersionDataType(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->FindVersionDataType();
}

DECL_EXPORT void* CDM_Document_VersionDataType(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->VersionDataType());
}

DECL_EXPORT bool CDM_Document_FindDescription(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->FindDescription();
}

DECL_EXPORT void* CDM_Document_Description(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->Description());
}

DECL_EXPORT bool CDM_Document_FindDomain(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->FindDomain();
}

DECL_EXPORT void* CDM_Document_Domain(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->Domain());
}

DECL_EXPORT bool CDM_Document_FindStoragePlugin(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->FindStoragePlugin();
}

DECL_EXPORT void* CDM_Document_StoragePlugin(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new Standard_GUID(	result->StoragePlugin());
}

DECL_EXPORT bool CDM_Document_IsModified(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->IsModified();
}

DECL_EXPORT int CDM_Document_CanClose(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return (int)	result->CanClose();
}

DECL_EXPORT void* CDM_Document_Application(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	new Handle_CDM_Application(	result->Application());
}

DECL_EXPORT int CDM_Document_ReferenceCounter(void* instance)
{
	CDM_Document* result = (CDM_Document*)(((Handle_CDM_Document*)instance)->Access());
	return 	result->ReferenceCounter();
}

DECL_EXPORT void CDMDocument_Dtor(void* instance)
{
	delete (Handle_CDM_Document*)instance;
}
