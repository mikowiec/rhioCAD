#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Standard;

#endregion

namespace NaroCppCore.Occ.Standard
{
	public class StandardGUID : NativeInstancePtr
	{
		public StandardGUID()
 :
			base(Standard_GUID_Ctor() )
		{}
		public StandardGUID(string aGuid)
 :
			base(Standard_GUID_Ctor9381D4D(aGuid) )
		{}
		public StandardGUID(int a32b,char a16b1,char a16b2,char a16b3,int a8b1,int a8b2,int a8b3,int a8b4,int a8b5,int a8b6)
 :
			base(Standard_GUID_Ctor8CF7F0B1(a32b, a16b1, a16b2, a16b3, a8b1, a8b2, a8b3, a8b4, a8b5, a8b6) )
		{}
		public StandardGUID(StandardGUID aGuid)
 :
			base(Standard_GUID_CtorD6AA2C7F(aGuid.Instance) )
		{}
			public bool IsSame(StandardGUID uid)
				{
					return Standard_GUID_IsSameD6AA2C7F(Instance, uid.Instance);
				}
			public bool IsNotSame(StandardGUID uid)
				{
					return Standard_GUID_IsNotSameD6AA2C7F(Instance, uid.Instance);
				}
			public static bool CheckGUIDFormat(string aGuid)
				{
					return Standard_GUID_CheckGUIDFormat9381D4D(aGuid);
				}
			public int Hash(int Upper)
				{
					return Standard_GUID_HashE8219145(Instance, Upper);
				}
			public static int HashCode(StandardGUID aguid,int Upper)
				{
					return Standard_GUID_HashCode5D88501F(aguid.Instance, Upper);
				}
			public static bool IsEqual(StandardGUID string1,StandardGUID string2)
				{
					return Standard_GUID_IsEqualD560E032(string1.Instance, string2.Instance);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Standard_GUID_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Standard_GUID_Ctor9381D4D(string aGuid);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Standard_GUID_Ctor8CF7F0B1(int a32b,char a16b1,char a16b2,char a16b3,int a8b1,int a8b2,int a8b3,int a8b4,int a8b5,int a8b6);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Standard_GUID_CtorD6AA2C7F(IntPtr aGuid);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Standard_GUID_IsSameD6AA2C7F(IntPtr instance, IntPtr uid);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Standard_GUID_IsNotSameD6AA2C7F(IntPtr instance, IntPtr uid);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Standard_GUID_CheckGUIDFormat9381D4D(string aGuid);
		[DllImport("NaroOccCore.dll")]
		private static extern int Standard_GUID_HashE8219145(IntPtr instance, int Upper);
		[DllImport("NaroOccCore.dll")]
		private static extern int Standard_GUID_HashCode5D88501F(IntPtr aguid,int Upper);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Standard_GUID_IsEqualD560E032(IntPtr string1,IntPtr string2);

		#region NativeInstancePtr Convert constructor

		public StandardGUID(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StandardGUID_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StandardGUID_Dtor(IntPtr instance);
	}
}
