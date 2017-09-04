#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.OSD;

#endregion

namespace NaroCppCore.Occ.OSD
{
	public class OSDPath : NativeInstancePtr
	{
		public OSDPath()
 :
			base(OSD_Path_Ctor() )
		{}
		public OSDPath(TCollectionAsciiString aDependentName,OSDSysType aSysType)
 :
			base(OSD_Path_Ctor6DB22F5E(aDependentName.Instance, (int)aSysType) )
		{}
		public OSDPath(TCollectionAsciiString aNode,TCollectionAsciiString aUsername,TCollectionAsciiString aPassword,TCollectionAsciiString aDisk,TCollectionAsciiString aTrek,TCollectionAsciiString aName,TCollectionAsciiString anExtension)
 :
			base(OSD_Path_CtorA8CFE3FC(aNode.Instance, aUsername.Instance, aPassword.Instance, aDisk.Instance, aTrek.Instance, aName.Instance, anExtension.Instance) )
		{}
			public void Values(TCollectionAsciiString aNode,TCollectionAsciiString aUsername,TCollectionAsciiString aPassword,TCollectionAsciiString aDisk,TCollectionAsciiString aTrek,TCollectionAsciiString aName,TCollectionAsciiString anExtension)
				{
					OSD_Path_ValuesA8CFE3FC(Instance, aNode.Instance, aUsername.Instance, aPassword.Instance, aDisk.Instance, aTrek.Instance, aName.Instance, anExtension.Instance);
				}
			public void SetValues(TCollectionAsciiString aNode,TCollectionAsciiString aUsername,TCollectionAsciiString aPassword,TCollectionAsciiString aDisk,TCollectionAsciiString aTrek,TCollectionAsciiString aName,TCollectionAsciiString anExtension)
				{
					OSD_Path_SetValuesA8CFE3FC(Instance, aNode.Instance, aUsername.Instance, aPassword.Instance, aDisk.Instance, aTrek.Instance, aName.Instance, anExtension.Instance);
				}
			public void SystemName(TCollectionAsciiString FullName,OSDSysType aType)
				{
					OSD_Path_SystemName6DB22F5E(Instance, FullName.Instance, (int)aType);
				}
			public void ExpandedName(TCollectionAsciiString aName)
				{
					OSD_Path_ExpandedName66CFACD0(Instance, aName.Instance);
				}
			public bool IsValid(TCollectionAsciiString aDependentName,OSDSysType aSysType)
				{
					return OSD_Path_IsValid6DB22F5E(Instance, aDependentName.Instance, (int)aSysType);
				}
			public void UpTrek()
				{
					OSD_Path_UpTrek(Instance);
				}
			public void DownTrek(TCollectionAsciiString aName)
				{
					OSD_Path_DownTrek66CFACD0(Instance, aName.Instance);
				}
			public void RemoveATrek(int where)
				{
					OSD_Path_RemoveATrekE8219145(Instance, where);
				}
			public void RemoveATrek(TCollectionAsciiString aName)
				{
					OSD_Path_RemoveATrek66CFACD0(Instance, aName.Instance);
				}
			public TCollectionAsciiString TrekValue(int where)
				{
					return new TCollectionAsciiString(OSD_Path_TrekValueE8219145(Instance, where));
				}
			public void InsertATrek(TCollectionAsciiString aName,int where)
				{
					OSD_Path_InsertATrekCAFD1949(Instance, aName.Instance, where);
				}
			public static TCollectionAsciiString RelativePath(TCollectionAsciiString DirPath,TCollectionAsciiString AbsFilePath)
				{
					return new TCollectionAsciiString(OSD_Path_RelativePathB82186D3(DirPath.Instance, AbsFilePath.Instance));
				}
			public static TCollectionAsciiString AbsolutePath(TCollectionAsciiString DirPath,TCollectionAsciiString RelFilePath)
				{
					return new TCollectionAsciiString(OSD_Path_AbsolutePathB82186D3(DirPath.Instance, RelFilePath.Instance));
				}
		public int TrekLength{
			get {
				return OSD_Path_TrekLength(Instance);
			}
		}
		public TCollectionAsciiString Node{
			set { 
				OSD_Path_SetNode(Instance, value.Instance);
			}
			get {
				return new TCollectionAsciiString(OSD_Path_Node(Instance));
			}
		}
		public TCollectionAsciiString UserName{
			set { 
				OSD_Path_SetUserName(Instance, value.Instance);
			}
			get {
				return new TCollectionAsciiString(OSD_Path_UserName(Instance));
			}
		}
		public TCollectionAsciiString Password{
			set { 
				OSD_Path_SetPassword(Instance, value.Instance);
			}
			get {
				return new TCollectionAsciiString(OSD_Path_Password(Instance));
			}
		}
		public TCollectionAsciiString Disk{
			set { 
				OSD_Path_SetDisk(Instance, value.Instance);
			}
			get {
				return new TCollectionAsciiString(OSD_Path_Disk(Instance));
			}
		}
		public TCollectionAsciiString Trek{
			set { 
				OSD_Path_SetTrek(Instance, value.Instance);
			}
			get {
				return new TCollectionAsciiString(OSD_Path_Trek(Instance));
			}
		}
		public TCollectionAsciiString Name{
			set { 
				OSD_Path_SetName(Instance, value.Instance);
			}
			get {
				return new TCollectionAsciiString(OSD_Path_Name(Instance));
			}
		}
		public TCollectionAsciiString Extension{
			set { 
				OSD_Path_SetExtension(Instance, value.Instance);
			}
			get {
				return new TCollectionAsciiString(OSD_Path_Extension(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_Ctor6DB22F5E(IntPtr aDependentName,int aSysType);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_CtorA8CFE3FC(IntPtr aNode,IntPtr aUsername,IntPtr aPassword,IntPtr aDisk,IntPtr aTrek,IntPtr aName,IntPtr anExtension);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_ValuesA8CFE3FC(IntPtr instance, IntPtr aNode,IntPtr aUsername,IntPtr aPassword,IntPtr aDisk,IntPtr aTrek,IntPtr aName,IntPtr anExtension);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_SetValuesA8CFE3FC(IntPtr instance, IntPtr aNode,IntPtr aUsername,IntPtr aPassword,IntPtr aDisk,IntPtr aTrek,IntPtr aName,IntPtr anExtension);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_SystemName6DB22F5E(IntPtr instance, IntPtr FullName,int aType);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_ExpandedName66CFACD0(IntPtr instance, IntPtr aName);
		[DllImport("NaroOccCore.dll")]
		private static extern bool OSD_Path_IsValid6DB22F5E(IntPtr instance, IntPtr aDependentName,int aSysType);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_UpTrek(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_DownTrek66CFACD0(IntPtr instance, IntPtr aName);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_RemoveATrekE8219145(IntPtr instance, int where);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_RemoveATrek66CFACD0(IntPtr instance, IntPtr aName);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_TrekValueE8219145(IntPtr instance, int where);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_InsertATrekCAFD1949(IntPtr instance, IntPtr aName,int where);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_RelativePathB82186D3(IntPtr DirPath,IntPtr AbsFilePath);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_AbsolutePathB82186D3(IntPtr DirPath,IntPtr RelFilePath);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_Path_TrekLength(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_SetNode(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_Node(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_SetUserName(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_UserName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_SetPassword(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_Password(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_SetDisk(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_Disk(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_SetTrek(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_Trek(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_SetName(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_Name(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Path_SetExtension(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Path_Extension(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public OSDPath(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ OSDPath_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void OSDPath_Dtor(IntPtr instance);
	}
}
