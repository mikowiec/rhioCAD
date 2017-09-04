#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Standard;
using NaroCppCore.Occ.CDM;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.CDM
{
	public class CDMMetaData : StandardTransient
	{
			public static CDMMetaData LookUp(TCollectionExtendedString aFolder,TCollectionExtendedString aName,TCollectionExtendedString aPath,TCollectionExtendedString aFileName,bool ReadOnly)
				{
					return new CDMMetaData(CDM_MetaData_LookUpCBFE3648(aFolder.Instance, aName.Instance, aPath.Instance, aFileName.Instance, ReadOnly));
				}
			public static CDMMetaData LookUp(TCollectionExtendedString aFolder,TCollectionExtendedString aName,TCollectionExtendedString aPath,TCollectionExtendedString aVersion,TCollectionExtendedString aFileName,bool ReadOnly)
				{
					return new CDMMetaData(CDM_MetaData_LookUp52AB094A(aFolder.Instance, aName.Instance, aPath.Instance, aVersion.Instance, aFileName.Instance, ReadOnly));
				}
			public void UnsetDocument()
				{
					CDM_MetaData_UnsetDocument(Instance);
				}
			public bool IsReadOnly()
				{
					return CDM_MetaData_IsReadOnly(Instance);
				}
			public void SetIsReadOnly()
				{
					CDM_MetaData_SetIsReadOnly(Instance);
				}
			public void UnsetIsReadOnly()
				{
					CDM_MetaData_UnsetIsReadOnly(Instance);
				}
		public bool IsRetrieved{
			get {
				return CDM_MetaData_IsRetrieved(Instance);
			}
		}
		public CDMDocument Document{
			get {
				return new CDMDocument(CDM_MetaData_Document(Instance));
			}
		}
		public TCollectionExtendedString Folder{
			get {
				return new TCollectionExtendedString(CDM_MetaData_Folder(Instance));
			}
		}
		public TCollectionExtendedString Name{
			get {
				return new TCollectionExtendedString(CDM_MetaData_Name(Instance));
			}
		}
		public TCollectionExtendedString Version{
			get {
				return new TCollectionExtendedString(CDM_MetaData_Version(Instance));
			}
		}
		public bool HasVersion{
			get {
				return CDM_MetaData_HasVersion(Instance);
			}
		}
		public TCollectionExtendedString FileName{
			get {
				return new TCollectionExtendedString(CDM_MetaData_FileName(Instance));
			}
		}
		public TCollectionExtendedString Path{
			get {
				return new TCollectionExtendedString(CDM_MetaData_Path(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_MetaData_LookUpCBFE3648(IntPtr aFolder,IntPtr aName,IntPtr aPath,IntPtr aFileName,bool ReadOnly);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_MetaData_LookUp52AB094A(IntPtr aFolder,IntPtr aName,IntPtr aPath,IntPtr aVersion,IntPtr aFileName,bool ReadOnly);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_MetaData_UnsetDocument(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_MetaData_IsReadOnly(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_MetaData_SetIsReadOnly(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_MetaData_UnsetIsReadOnly(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_MetaData_IsRetrieved(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_MetaData_Document(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_MetaData_Folder(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_MetaData_Name(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_MetaData_Version(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_MetaData_HasVersion(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_MetaData_FileName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_MetaData_Path(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public CDMMetaData() { } 

		public CDMMetaData(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ CDMMetaData_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void CDMMetaData_Dtor(IntPtr instance);
	}
}
