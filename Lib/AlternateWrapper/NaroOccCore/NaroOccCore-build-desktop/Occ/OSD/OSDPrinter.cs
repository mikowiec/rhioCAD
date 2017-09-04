#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.OSD
{
	public class OSDPrinter : NativeInstancePtr
	{
		public OSDPrinter(TCollectionAsciiString Name)
 :
			base(OSD_Printer_Ctor66CFACD0(Name.Instance) )
		{}
			public void SetName(TCollectionAsciiString Name)
				{
					OSD_Printer_SetName66CFACD0(Instance, Name.Instance);
				}
			public void Name(TCollectionAsciiString Name)
				{
					OSD_Printer_Name66CFACD0(Instance, Name.Instance);
				}
			public void Reset()
				{
					OSD_Printer_Reset(Instance);
				}
			public void Perror()
				{
					OSD_Printer_Perror(Instance);
				}
		public bool Failed{
			get {
				return OSD_Printer_Failed(Instance);
			}
		}
		public int Error{
			get {
				return OSD_Printer_Error(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Printer_Ctor66CFACD0(IntPtr Name);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Printer_SetName66CFACD0(IntPtr instance, IntPtr Name);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Printer_Name66CFACD0(IntPtr instance, IntPtr Name);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Printer_Reset(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Printer_Perror(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool OSD_Printer_Failed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_Printer_Error(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public OSDPrinter() { } 

		public OSDPrinter(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ OSDPrinter_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void OSDPrinter_Dtor(IntPtr instance);
	}
}
