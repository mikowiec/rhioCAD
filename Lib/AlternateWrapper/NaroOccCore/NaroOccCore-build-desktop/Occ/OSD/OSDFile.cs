#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.OSD;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.OSD
{
	public class OSDFile : OSDFileNode
	{
		public OSDFile()
 :
			base(OSD_File_Ctor() )
		{}
		public OSDFile(OSDPath Name)
 :
			base(OSD_File_CtorF0BBCC0E(Name.Instance) )
		{}
			public void Build(OSDOpenMode Mode,OSDProtection Protect)
				{
					OSD_File_Build5E99AF11(Instance, (int)Mode, Protect.Instance);
				}
			public void Open(OSDOpenMode Mode,OSDProtection Protect)
				{
					OSD_File_Open5E99AF11(Instance, (int)Mode, Protect.Instance);
				}
			public void Append(OSDOpenMode Mode,OSDProtection Protect)
				{
					OSD_File_Append5E99AF11(Instance, (int)Mode, Protect.Instance);
				}
			public void ReadLine(TCollectionAsciiString Buffer,int NByte,ref int NbyteRead)
				{
					OSD_File_ReadLine10E3C1BB(Instance, Buffer.Instance, NByte, ref NbyteRead);
				}
			public void Seek(int Offset,OSDFromWhere Whence)
				{
					OSD_File_Seek1868D864(Instance, Offset, (int)Whence);
				}
			public void Close()
				{
					OSD_File_Close(Instance);
				}
			public void UnLock()
				{
					OSD_File_UnLock(Instance);
				}
			public void Print(OSDPrinter WhichPrinter)
				{
					OSD_File_Print21D3F920(Instance, WhichPrinter.Instance);
				}
			public bool ReadLastLine(TCollectionAsciiString aLine,int aDelay,int aNbTries)
				{
					return OSD_File_ReadLastLine10E3C1BB(Instance, aLine.Instance, aDelay, aNbTries);
				}
		public bool IsAtEnd{
			get {
				return OSD_File_IsAtEnd(Instance);
			}
		}
		public OSDKindFile KindOfFile{
			get {
				return (OSDKindFile)OSD_File_KindOfFile(Instance);
			}
		}
		public static OSDFile BuildTemporary{
			get {
				return new OSDFile(OSD_File_BuildTemporary());
			}
		}
		public OSDLockType Lock{
			set { 
				OSD_File_SetLock(Instance, (int)value);
			}
		}
		public OSDLockType GetLock{
			get {
				return (OSDLockType)OSD_File_GetLock(Instance);
			}
		}
		public bool IsLocked{
			get {
				return OSD_File_IsLocked(Instance);
			}
		}
		public int Size{
			get {
				return OSD_File_Size(Instance);
			}
		}
		public bool IsOpen{
			get {
				return OSD_File_IsOpen(Instance);
			}
		}
		public bool IsReadable{
			get {
				return OSD_File_IsReadable(Instance);
			}
		}
		public bool IsWriteable{
			get {
				return OSD_File_IsWriteable(Instance);
			}
		}
		public bool IsExecutable{
			get {
				return OSD_File_IsExecutable(Instance);
			}
		}
		public bool Edit{
			get {
				return OSD_File_Edit(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_File_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_File_CtorF0BBCC0E(IntPtr Name);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_File_Build5E99AF11(IntPtr instance, int Mode,IntPtr Protect);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_File_Open5E99AF11(IntPtr instance, int Mode,IntPtr Protect);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_File_Append5E99AF11(IntPtr instance, int Mode,IntPtr Protect);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_File_ReadLine10E3C1BB(IntPtr instance, IntPtr Buffer,int NByte,ref int NbyteRead);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_File_Seek1868D864(IntPtr instance, int Offset,int Whence);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_File_Close(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_File_UnLock(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_File_Print21D3F920(IntPtr instance, IntPtr WhichPrinter);
		[DllImport("NaroOccCore.dll")]
		private static extern bool OSD_File_ReadLastLine10E3C1BB(IntPtr instance, IntPtr aLine,int aDelay,int aNbTries);
		[DllImport("NaroOccCore.dll")]
		private static extern bool OSD_File_IsAtEnd(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_File_KindOfFile(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_File_BuildTemporary();
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_File_SetLock(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_File_GetLock(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool OSD_File_IsLocked(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_File_Size(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool OSD_File_IsOpen(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool OSD_File_IsReadable(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool OSD_File_IsWriteable(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool OSD_File_IsExecutable(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool OSD_File_Edit(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public OSDFile(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ OSDFile_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void OSDFile_Dtor(IntPtr instance);
	}
}
