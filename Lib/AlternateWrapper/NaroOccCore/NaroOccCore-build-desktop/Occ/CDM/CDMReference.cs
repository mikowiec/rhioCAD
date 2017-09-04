#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Standard;
using NaroCppCore.Occ.CDM;

#endregion

namespace NaroCppCore.Occ.CDM
{
	public class CDMReference : StandardTransient
	{
		public CDMDocument FromDocument{
			get {
				return new CDMDocument(CDM_Reference_FromDocument(Instance));
			}
		}
		public CDMDocument ToDocument{
			get {
				return new CDMDocument(CDM_Reference_ToDocument(Instance));
			}
		}
		public int ReferenceIdentifier{
			get {
				return CDM_Reference_ReferenceIdentifier(Instance);
			}
		}
		public int DocumentVersion{
			get {
				return CDM_Reference_DocumentVersion(Instance);
			}
		}
		public bool IsReadOnly{
			get {
				return CDM_Reference_IsReadOnly(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Reference_FromDocument(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Reference_ToDocument(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int CDM_Reference_ReferenceIdentifier(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int CDM_Reference_DocumentVersion(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool CDM_Reference_IsReadOnly(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public CDMReference() { } 

		public CDMReference(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ CDMReference_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void CDMReference_Dtor(IntPtr instance);
	}
}
