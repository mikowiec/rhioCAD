#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.OSD;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.OSD
{
	public class OSDFileNode : NativeInstancePtr
	{
			public void Path(OSDPath Name)
				{
					OSD_FileNode_PathF0BBCC0E(Instance, Name.Instance);
				}
			public void SetPath(OSDPath Name)
				{
					OSD_FileNode_SetPathF0BBCC0E(Instance, Name.Instance);
				}
			public void Remove()
				{
					OSD_FileNode_Remove(Instance);
				}
			public void Move(OSDPath NewPath)
				{
					OSD_FileNode_MoveF0BBCC0E(Instance, NewPath.Instance);
				}
			public void Copy(OSDPath ToPath)
				{
					OSD_FileNode_CopyF0BBCC0E(Instance, ToPath.Instance);
				}
			public void Reset()
				{
					OSD_FileNode_Reset(Instance);
				}
			public void Perror()
				{
					OSD_FileNode_Perror(Instance);
				}
		public bool Exists{
			get {
				return OSD_FileNode_Exists(Instance);
			}
		}
		public OSDProtection Protection{
			set { 
				OSD_FileNode_SetProtection(Instance, value.Instance);
			}
			get {
				return new OSDProtection(OSD_FileNode_Protection(Instance));
			}
		}
		public QuantityDate AccessMoment{
			get {
				return new QuantityDate(OSD_FileNode_AccessMoment(Instance));
			}
		}
		public QuantityDate CreationMoment{
			get {
				return new QuantityDate(OSD_FileNode_CreationMoment(Instance));
			}
		}
		public int UserId{
			get {
				return OSD_FileNode_UserId(Instance);
			}
		}
		public int GroupId{
			get {
				return OSD_FileNode_GroupId(Instance);
			}
		}
		public bool Failed{
			get {
				return OSD_FileNode_Failed(Instance);
			}
		}
		public int Error{
			get {
				return OSD_FileNode_Error(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_FileNode_PathF0BBCC0E(IntPtr instance, IntPtr Name);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_FileNode_SetPathF0BBCC0E(IntPtr instance, IntPtr Name);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_FileNode_Remove(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_FileNode_MoveF0BBCC0E(IntPtr instance, IntPtr NewPath);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_FileNode_CopyF0BBCC0E(IntPtr instance, IntPtr ToPath);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_FileNode_Reset(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_FileNode_Perror(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool OSD_FileNode_Exists(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_FileNode_SetProtection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_FileNode_Protection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_FileNode_AccessMoment(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_FileNode_CreationMoment(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_FileNode_UserId(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_FileNode_GroupId(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool OSD_FileNode_Failed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_FileNode_Error(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public OSDFileNode() { } 

		public OSDFileNode(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ OSDFileNode_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void OSDFileNode_Dtor(IntPtr instance);
	}
}
