#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BOPTools;

#endregion

namespace NaroCppCore.Occ.BOPTools
{
	public class BOPToolsCoupleOfInteger : NativeInstancePtr
	{
		public BOPToolsCoupleOfInteger()
 :
			base(BOPTools_CoupleOfInteger_Ctor() )
		{}
		public BOPToolsCoupleOfInteger(int aFirst,int aSecond)
 :
			base(BOPTools_CoupleOfInteger_Ctor5107F6FE(aFirst, aSecond) )
		{}
			public void SetCouple(int aFirst,int aSecond)
				{
					BOPTools_CoupleOfInteger_SetCouple5107F6FE(Instance, aFirst, aSecond);
				}
			public void Couple(ref int aFirst,ref int aSecond)
				{
					BOPTools_CoupleOfInteger_Couple5107F6FE(Instance, ref aFirst, ref aSecond);
				}
			public bool IsEqual(BOPToolsCoupleOfInteger aOther)
				{
					return BOPTools_CoupleOfInteger_IsEqual692F43DE(Instance, aOther.Instance);
				}
			public int HashCode(int Upper)
				{
					return BOPTools_CoupleOfInteger_HashCodeE8219145(Instance, Upper);
				}
		public int First{
			set { 
				BOPTools_CoupleOfInteger_SetFirst(Instance, value);
			}
			get {
				return BOPTools_CoupleOfInteger_First(Instance);
			}
		}
		public int Second{
			set { 
				BOPTools_CoupleOfInteger_SetSecond(Instance, value);
			}
			get {
				return BOPTools_CoupleOfInteger_Second(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_CoupleOfInteger_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_CoupleOfInteger_Ctor5107F6FE(int aFirst,int aSecond);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_CoupleOfInteger_SetCouple5107F6FE(IntPtr instance, int aFirst,int aSecond);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_CoupleOfInteger_Couple5107F6FE(IntPtr instance, ref int aFirst,ref int aSecond);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOPTools_CoupleOfInteger_IsEqual692F43DE(IntPtr instance, IntPtr aOther);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_CoupleOfInteger_HashCodeE8219145(IntPtr instance, int Upper);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_CoupleOfInteger_SetFirst(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_CoupleOfInteger_First(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_CoupleOfInteger_SetSecond(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_CoupleOfInteger_Second(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPToolsCoupleOfInteger(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPToolsCoupleOfInteger_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPToolsCoupleOfInteger_Dtor(IntPtr instance);
	}
}
