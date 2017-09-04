#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.OSD;

#endregion

namespace NaroCppCore.Occ.OSD
{
	public class OSDProtection : NativeInstancePtr
	{
		public OSDProtection()
 :
			base(OSD_Protection_Ctor() )
		{}
		public OSDProtection(OSDSingleProtection System,OSDSingleProtection User,OSDSingleProtection Group,OSDSingleProtection World)
 :
			base(OSD_Protection_Ctor4B0D101E((int)System, (int)User, (int)Group, (int)World) )
		{}
		public OSDSingleProtection System{
			set { 
				OSD_Protection_SetSystem(Instance, (int)value);
			}
			get {
				return (OSDSingleProtection)OSD_Protection_System(Instance);
			}
		}
		public OSDSingleProtection User{
			set { 
				OSD_Protection_SetUser(Instance, (int)value);
			}
			get {
				return (OSDSingleProtection)OSD_Protection_User(Instance);
			}
		}
		public OSDSingleProtection Group{
			set { 
				OSD_Protection_SetGroup(Instance, (int)value);
			}
			get {
				return (OSDSingleProtection)OSD_Protection_Group(Instance);
			}
		}
		public OSDSingleProtection World{
			set { 
				OSD_Protection_SetWorld(Instance, (int)value);
			}
			get {
				return (OSDSingleProtection)OSD_Protection_World(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Protection_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Protection_Ctor4B0D101E(int System,int User,int Group,int World);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Protection_SetSystem(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_Protection_System(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Protection_SetUser(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_Protection_User(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Protection_SetGroup(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_Protection_Group(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Protection_SetWorld(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_Protection_World(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public OSDProtection(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ OSDProtection_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void OSDProtection_Dtor(IntPtr instance);
	}
}
