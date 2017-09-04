#ifndef CDM_Document_H
#define CDM_Document_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT bool CDM_Document_GetAlternativeDocumentF38A10D6(
	void* instance,
	void* aFormat,
	void* anAlternativeDocument);
extern "C" DECL_EXPORT int CDM_Document_CreateReference3DDF553A(
	void* instance,
	void* anOtherDocument);
extern "C" DECL_EXPORT void CDM_Document_RemoveReferenceE8219145(
	void* instance,
	int aReferenceIdentifier);
extern "C" DECL_EXPORT void CDM_Document_RemoveAllReferences(void* instance);
extern "C" DECL_EXPORT void* CDM_Document_DocumentE8219145(
	void* instance,
	int aReferenceIdentifier);
extern "C" DECL_EXPORT bool CDM_Document_IsInSessionE8219145(
	void* instance,
	int aReferenceIdentifier);
extern "C" DECL_EXPORT bool CDM_Document_IsStoredE8219145(
	void* instance,
	int aReferenceIdentifier);
extern "C" DECL_EXPORT void* CDM_Document_NameE8219145(
	void* instance,
	int aReferenceIdentifier);
extern "C" DECL_EXPORT bool CDM_Document_ShallowReferences3DDF553A(
	void* instance,
	void* aDocument);
extern "C" DECL_EXPORT bool CDM_Document_DeepReferences3DDF553A(
	void* instance,
	void* aDocument);
extern "C" DECL_EXPORT int CDM_Document_CopyReference706B147E(
	void* instance,
	void* aFromDocument,
	int aReferenceIdentifier);
extern "C" DECL_EXPORT bool CDM_Document_IsReadOnly(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_IsReadOnlyE8219145(
	void* instance,
	int aReferenceIdentifier);
extern "C" DECL_EXPORT void CDM_Document_SetIsReadOnly(void* instance);
extern "C" DECL_EXPORT void CDM_Document_UnsetIsReadOnly(void* instance);
extern "C" DECL_EXPORT void CDM_Document_Modify(void* instance);
extern "C" DECL_EXPORT void CDM_Document_UnModify(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_IsUpToDateE8219145(
	void* instance,
	int aReferenceIdentifier);
extern "C" DECL_EXPORT void CDM_Document_SetIsUpToDateE8219145(
	void* instance,
	int aReferenceIdentifier);
extern "C" DECL_EXPORT void CDM_Document_AddComment6EE6EE89(
	void* instance,
	void* aComment);
extern "C" DECL_EXPORT void* CDM_Document_FindFromPresentation6EE6EE89(
	void* aPresentation);
extern "C" DECL_EXPORT bool CDM_Document_FindPresentation6EE6EE89(
	void* aPresentation);
extern "C" DECL_EXPORT bool CDM_Document_IsStored(void* instance);
extern "C" DECL_EXPORT void CDM_Document_UnsetIsStored(void* instance);
extern "C" DECL_EXPORT void CDM_Document_UnsetRequestedPreviousVersion(void* instance);
extern "C" DECL_EXPORT void CDM_Document_LoadResources(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_IsOpened(void* instance);
extern "C" DECL_EXPORT void CDM_Document_Open6724CADE(
	void* instance,
	void* anApplication);
extern "C" DECL_EXPORT void CDM_Document_Close(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_CanCloseReference706B147E(
	void* instance,
	void* aDocument,
	int aReferenceIdentifier);
extern "C" DECL_EXPORT void CDM_Document_CloseReference706B147E(
	void* instance,
	void* aDocument,
	int aReferenceIdentifier);
extern "C" DECL_EXPORT bool CDM_Document_IsOpenedE8219145(
	void* instance,
	int aReferenceIdentifier);
extern "C" DECL_EXPORT void CDM_Document_CreateReferenceA7DD6C1D(
	void* instance,
	void* aMetaData,
	int aReferenceIdentifier,
	void* anApplication,
	int aToDocumentVersion,
	bool UseStorageConfiguration);
extern "C" DECL_EXPORT int CDM_Document_CreateReference8DBBF2BC(
	void* instance,
	void* aMetaData,
	void* anApplication,
	int aDocumentVersion,
	bool UseStorageConfiguration);
extern "C" DECL_EXPORT int CDM_Document_ToReferencesNumber(void* instance);
extern "C" DECL_EXPORT int CDM_Document_FromReferencesNumber(void* instance);
extern "C" DECL_EXPORT int CDM_Document_Modifications(void* instance);
extern "C" DECL_EXPORT void CDM_Document_SetComment(void* instance, void* value);
extern "C" DECL_EXPORT void* CDM_Document_Comment(void* instance);
extern "C" DECL_EXPORT int CDM_Document_StorageVersion(void* instance);
extern "C" DECL_EXPORT void CDM_Document_SetMetaData(void* instance, void* value);
extern "C" DECL_EXPORT void* CDM_Document_MetaData(void* instance);
extern "C" DECL_EXPORT void* CDM_Document_Folder(void* instance);
extern "C" DECL_EXPORT void CDM_Document_SetRequestedFolder(void* instance, void* value);
extern "C" DECL_EXPORT void* CDM_Document_RequestedFolder(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_HasRequestedFolder(void* instance);
extern "C" DECL_EXPORT void CDM_Document_SetRequestedName(void* instance, void* value);
extern "C" DECL_EXPORT void* CDM_Document_RequestedName(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_HasRequestedPreviousVersion(void* instance);
extern "C" DECL_EXPORT void CDM_Document_SetRequestedPreviousVersion(void* instance, void* value);
extern "C" DECL_EXPORT void* CDM_Document_RequestedPreviousVersion(void* instance);
extern "C" DECL_EXPORT void CDM_Document_SetRequestedComment(void* instance, void* value);
extern "C" DECL_EXPORT void* CDM_Document_RequestedComment(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_FindFileExtension(void* instance);
extern "C" DECL_EXPORT void* CDM_Document_FileExtension(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_FindDataType(void* instance);
extern "C" DECL_EXPORT void* CDM_Document_DataType(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_FindVersionDataType(void* instance);
extern "C" DECL_EXPORT void* CDM_Document_VersionDataType(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_FindDescription(void* instance);
extern "C" DECL_EXPORT void* CDM_Document_Description(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_FindDomain(void* instance);
extern "C" DECL_EXPORT void* CDM_Document_Domain(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_FindStoragePlugin(void* instance);
extern "C" DECL_EXPORT void* CDM_Document_StoragePlugin(void* instance);
extern "C" DECL_EXPORT bool CDM_Document_IsModified(void* instance);
extern "C" DECL_EXPORT int CDM_Document_CanClose(void* instance);
extern "C" DECL_EXPORT void* CDM_Document_Application(void* instance);
extern "C" DECL_EXPORT int CDM_Document_ReferenceCounter(void* instance);
extern "C" DECL_EXPORT void CDMDocument_Dtor(void* instance);

#endif
