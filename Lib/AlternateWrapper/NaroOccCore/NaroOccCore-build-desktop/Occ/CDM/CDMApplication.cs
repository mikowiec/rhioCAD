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
	public class CDMApplication : StandardTransient
	{
			public void BeginOfUpdate(CDMDocument aDocument)
				{
					CDM_Application_BeginOfUpdate3DDF553A(Instance, aDocument.Instance);
				}
			public void EndOfUpdate(CDMDocument aDocument,bool Status,TCollectionExtendedString ErrorString)
				{
					CDM_Application_EndOfUpdateE3A9B7F3(Instance, aDocument.Instance, Status, ErrorString.Instance);
				}
			public void Write(string aString)
				{
					CDM_Application_Write9381D4D(Instance, aString);
				}
		public CDMMessageDriver MessageDriver{
			get {
				return new CDMMessageDriver(CDM_Application_MessageDriver(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Application_BeginOfUpdate3DDF553A(IntPtr instance, IntPtr aDocument);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Application_EndOfUpdateE3A9B7F3(IntPtr instance, IntPtr aDocument,bool Status,IntPtr ErrorString);
		[DllImport("NaroOccCore.dll")]
		private static extern void CDM_Application_Write9381D4D(IntPtr instance, string aString);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr CDM_Application_MessageDriver(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public CDMApplication() { } 

		public CDMApplication(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ CDMApplication_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void CDMApplication_Dtor(IntPtr instance);
	}
}
