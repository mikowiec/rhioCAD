#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Standard;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.CDM;

#endregion

namespace NaroCppCore.Occ.CDM
{
	public class CDMDocument : StandardTransient
	{
			public bool GetAlternativeDocument(TCollectionExtendedString aFormat,CDMDocument anAlternativeDocument)
				{
					return CDM_Document_GetAlternativeDocumentF38A10D6(Instance, aFormat.Instance, anAlternativeDocument.Instance);
				}
			public int CreateReference(CDMDocument anOtherDocument)
				{
					return CDM_Document_CreateReference3DDF553A(Instance, anOtherDocument.Instance);
				}
			public void RemoveReference(int aReferenceIdentifier)
				{
					CDM_Document_RemoveReferenceE8219145(Instance, aReferenceIdentifier);
				}
			public void RemoveAllReferences()
				{
					CDM_Document_RemoveAllReferences(Instance);
				}
			public CDMDocument Document(int aReferenceIdentifier)
				{
					return new CDMDocument(CDM_Document_DocumentE8219145(Instance, aReferenceIdentifier));
				}
			public bool IsInSession(int aReferenceIdentifier)
				{
					return CDM_Document_IsInSessionE8219145(Instance, aReferenceIdentifier);
				}
			public bool IsStored(int aReferenceIdentifier)
				{
					return CDM_Document_IsStoredE8219145(Instance, aReferenceIdentifier);
				}
			public TCollectionExtendedString Name(int aReferenceIdentifier)
				{
					return new TCollectionExtendedString(CDM_Document_NameE8219145(Instance, aReferenceIdentifier));
				}
			public bool ShallowReferences(CDMDocument aDocument)
				{
					return CDM_Document_ShallowReferences3DDF553A(Instance, aDocument.Instance);
				}
			public bool DeepReferences(CDMDocument aDocument)
				{
					return CDM_Document_DeepReferences3DDF553A(Instance, aDocument.Instance);
				}
			public int CopyReference(CDMDocument aFromDocument,int aReferenceIdentifier)
				{
					return CDM_Document_CopyReference706B147E(Instance, aFromDocument.Instance, aReferenceIdentifier);
				}
			public bool IsReadOnly()
				{
					return CDM_Document_IsReadOnly(Instance);
				}
			public bool IsReadOnly(int aReferenceIdentifier)
				{
					return CDM_Document_IsReadOnlyE8219145(Instance, aReferenceIdentifier);
				}
			public void SetIsReadOnly()
				{
					CDM_Document_SetIsReadOnly(Instance);
				}
			public void UnsetIsReadOnly()
				{
					CDM_Document_UnsetIsReadOnly(Instance);
				}
			public void Modify()
				{
					CDM_Document_Modify(Instance);
				}
			public void UnModify()
				{
					CDM_Document_UnModify(Instance);
				}
			public bool IsUpToDate(int aReferenceIdentifier)
				{
					return CDM_Document_IsUpToDateE8219145(Instance, aReferenceIdentifier);
				}
			public void SetIsUpToDate(int aReferenceIdentifier)
				{
					CDM_Document_SetIsUpToDateE8219145(Instance, aReferenceIdentifier);
				}
			public void AddComment(TCollectionExtendedString aComment)
				{
					CDM_Document_AddComment6EE6EE89(Instance, aComment.Instance);
				}
			public static CDMDocument FindFromPresentation(TCollectionExtendedString aPresentation)
				{
					return new CDMDocument(CDM_Document_FindFromPresentation6EE6EE89(aPresentation.Instance));
				}
			public static bool FindPresentation(TCollectionExtendedString aPresentation)
				{
					return CDM_Document_FindPresentation6EE6EE89(aPresentation.Instance);
				}
			public bool IsStored()
				{
					return CDM_Document_IsStored(Instance);
				}
			public void UnsetIsStored()
				{
					CDM_Document_UnsetIsStored(Instance);
				}
			public void UnsetRequestedPreviousVersion()
				{
					CDM_Document_UnsetRequestedPreviousVersion(Instance);
				}
			public void LoadResources()
				{
					CDM_Document_LoadResources(Instance);
				}
			public bool IsOpened()
				{
					return CDM_Document_IsOpened(Instance);
				}
			public void Open(CDMApplication anApplication)
				{
					CDM_Document_Open6724CADE(Instance, anApplication.Instance);
				}
			public void Close()
				{
					CDM_Document_Close(Instance);
				}
			public bool CanCloseReference(CDMDocument aDocument,int aReferenceIdentifier)
				{
					return CDM_Document_CanCloseReference706B147E(Instance, aDocument.Instance, aReferenceIdentifier);
				}
			public void CloseReference(CDMDocument aDocument,int aReferenceIdentifier)
				{
					CDM_Document_CloseReference706B147E(Instance, aDocument.Instance, aReferenceIdentifier);
				}
			public bool IsOpened(int aReferenceIdentifier)
				{
					return CDM_Document_IsOpenedE8219145(Instance, aReferenceIdentifier);
				}
			public void CreateReference(CDMMetaData aMetaData,int aReferenceIdentifier,CDMApplication anApplication,int aToDocumentVersion,bool UseStorageConfiguration)
				{
					CDM_Document_CreateReferenceA7DD6C1D(Instance, aMetaData.Instance, aReferenceIdentifier, anApplication.Instance, aToDocumentVersion, UseStorageConfiguration);
				}
			public int CreateReference(CDMMetaData aMetaData,CDMApplication anApplication,int aDocumentVersion,bool UseStorageConfiguration)
				{
					return CDM_Document_CreateReference8DBBF2BC(Instance, aMetaData.Instance, anApplication.Instance, aDocumentVersion, UseStorageConfiguration);
				}
		public int ToReferencesNumber{
			get {
				return CDM_Document_ToReferencesNumber(Instance);
			}
		}
		public int FromReferencesNumber{
			get {
				return CDM_Document_FromReferencesNumber(Instance);
			}
		}
		public int Modifications{
			get {
				return CDM_Document_Modifications(Instance);
			}
		}
		public TCollectionExtendedString Comment{
			set { 
				CDM_Document_SetComment(Instance, value.Instance);
			}
			get {
				return new TCollectionExtendedString(CDM_Document_Comment(Instance));
			}
		}
		public int StorageVersion{
			get {
				return CDM_Document_StorageVersion(Instance);
			}
		}
		public CDMMetaData MetaData{
			set { 
				CDM_Document_SetMetaData(Instance, value.Instance);
			}
			get {
				return new CDMMetaData(CDM_Document_MetaData(Instance));
			}
		}
		public TCollectionExtendedString Folder{
			get {
				return new TCollectionExtendedString(CDM_Document_Folder(Instance));
			}
		}
		public TCollectionExtendedString RequestedFolder{
			set { 
				CDM_Document_SetRequestedFolder(Instance, value.Instance);
			}
			get {
				return new TCollectionExtendedString(CDM_Document_RequestedFolder(Instance));
			}
		}
		public bool HasRequestedFolder{
			get {
				return CDM_Document_HasRequestedFolder(Instance);
			}
		}
		public TCollectionExtendedString RequestedName{
			set { 
				CDM_Document_SetRequestedName(Instance, value.Instance);
			}
			get {
				return new TCollectionExtendedString(CDM_Document_RequestedName(Instance));
			}
		}
		public bool HasRequestedPreviousVersion{
			get {
				return CDM_Document_HasRequestedPreviousVersion(Instance);
			}
		}
		public TCollectionExtendedString RequestedPreviousVersion{
			set { 
				CDM_Document_SetRequestedPreviousVersion(Instance, value.Instance);
			}
			get {
				return new TCollectionExtendedString(CDM_Document_RequestedPreviousVersion(Instance));
			}
		}
		public TCollectionExtendedString RequestedComment{
			set { 
				CDM_Document_SetRequestedComment(Instance, value.Instance);
			}
			get {
				return new TCollectionExtendedString(CDM_Document_RequestedComment(Instance));
			}
		}
		public bool FindFileExtension{
			get {
				return CDM_Document_FindFileExtension(Instance);
			}
		}
		public TCollectionExtendedString FileExtension{
			get {
				return new TCollectionExtendedString(CDM_Document_FileExtension(Instance));
			}
		}
		public bool FindDataType{
			get {
				return CDM_Document_FindDataType(Instance);
			}
		}
		public TCollectionExtendedString DataType{
			get {
				return new TCollectionExtendedString(CDM_Document_DataType(Instance));
			}
		}
		public bool FindVersionDataType{
			get {
				return CDM_Document_FindVersionDataType(Instance);
			}
		}
		public TCollectionExtendedString VersionDataType{
			get {
				return new TCollectionExtendedString(CDM_Document_VersionDataType(Instance));
			}
		}
		public bool FindDescription{
			get {
				return CDM_Document_FindDescription(Instance);
			}
		}
		public TCollectionExtendedString Description{
			get {
				return new TCollectionExtendedString(CDM_Document_Description(Instance));
			}
		}
		public bool FindDomain{
			get {
				return CDM_Document_FindDomain(Instance);
			}
		}
		public TCollectionExtendedString Domain{
			get {
				return new TCollectionExtendedString(CDM_Document_Domain(Instance));
			}
		}
		public bool FindStoragePlugin{
			get {
				return CDM_Document_FindStoragePlugin(Instance);
			}
		}
		public StandardGUID StoragePlugin{
			get {
				return new StandardGUID(CDM_Document_StoragePlugin(Instance));
			}
		}
		public bool IsModified{
			get {
				return CDM_Document_IsModified(Instance);
			}
		}
		public CDMCanCloseStatus CanClose{
			get {
				return (CDMCanCloseStatus)CDM_Document_CanClose(Instance);
			}
		}
		public CDMApplication Application{
			get {
				return new CDMApplication(CDM_Document_Application(Instance));
			}
		}
		public int ReferenceCounter{
			get {
				return CDM_Document_ReferenceCounter(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_GetAlternativeDocumentF38A10D6(IntPtr instance, IntPtr aFormat,IntPtr anAlternativeDocument);
		[DllImport("NaroOccCore.dll")]
		private static extern int CDM_Document_CreateReference3DDF553A(IntPtr instance, IntPtr anOtherDocument);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_RemoveReferenceE8219145(IntPtr instance, int aReferenceIdentifier);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_RemoveAllReferences(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_DocumentE8219145(IntPtr instance, int aReferenceIdentifier);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_IsInSessionE8219145(IntPtr instance, int aReferenceIdentifier);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_IsStoredE8219145(IntPtr instance, int aReferenceIdentifier);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_NameE8219145(IntPtr instance, int aReferenceIdentifier);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_ShallowReferences3DDF553A(IntPtr instance, IntPtr aDocument);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_DeepReferences3DDF553A(IntPtr instance, IntPtr aDocument);
		[DllImport("NaroOccCore.dll")]
		private static extern int CDM_Document_CopyReference706B147E(IntPtr instance, IntPtr aFromDocument,int aReferenceIdentifier);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_IsReadOnly(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_IsReadOnlyE8219145(IntPtr instance, int aReferenceIdentifier);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_SetIsReadOnly(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_UnsetIsReadOnly(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_Modify(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_UnModify(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_IsUpToDateE8219145(IntPtr instance, int aReferenceIdentifier);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_SetIsUpToDateE8219145(IntPtr instance, int aReferenceIdentifier);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_AddComment6EE6EE89(IntPtr instance, IntPtr aComment);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_FindFromPresentation6EE6EE89(IntPtr aPresentation);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_FindPresentation6EE6EE89(IntPtr aPresentation);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_IsStored(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_UnsetIsStored(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_UnsetRequestedPreviousVersion(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_LoadResources(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_IsOpened(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_Open6724CADE(IntPtr instance, IntPtr anApplication);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_Close(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_CanCloseReference706B147E(IntPtr instance, IntPtr aDocument,int aReferenceIdentifier);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_CloseReference706B147E(IntPtr instance, IntPtr aDocument,int aReferenceIdentifier);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_IsOpenedE8219145(IntPtr instance, int aReferenceIdentifier);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_CreateReferenceA7DD6C1D(IntPtr instance, IntPtr aMetaData,int aReferenceIdentifier,IntPtr anApplication,int aToDocumentVersion,bool UseStorageConfiguration);
		[DllImport("NaroOccCore.dll")]
		private static extern int CDM_Document_CreateReference8DBBF2BC(IntPtr instance, IntPtr aMetaData,IntPtr anApplication,int aDocumentVersion,bool UseStorageConfiguration);
		[DllImport("NaroOccCore.dll")]
		private static extern int CDM_Document_ToReferencesNumber(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int CDM_Document_FromReferencesNumber(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int CDM_Document_Modifications(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_SetComment(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_Comment(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int CDM_Document_StorageVersion(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_SetMetaData(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_MetaData(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_Folder(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_SetRequestedFolder(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_RequestedFolder(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_HasRequestedFolder(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_SetRequestedName(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_RequestedName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_HasRequestedPreviousVersion(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_SetRequestedPreviousVersion(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_RequestedPreviousVersion(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Document_SetRequestedComment(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_RequestedComment(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_FindFileExtension(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_FileExtension(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_FindDataType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_DataType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_FindVersionDataType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_VersionDataType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_FindDescription(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_Description(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_FindDomain(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_Domain(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_FindStoragePlugin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_StoragePlugin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Document_IsModified(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int CDM_Document_CanClose(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Document_Application(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int CDM_Document_ReferenceCounter(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public CDMDocument() { } 

		public CDMDocument(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ CDMDocument_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void CDMDocument_Dtor(IntPtr instance);
	}
}
