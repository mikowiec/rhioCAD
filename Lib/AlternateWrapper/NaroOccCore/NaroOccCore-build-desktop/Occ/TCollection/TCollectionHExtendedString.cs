#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.TCollection
{
	public class TCollectionHExtendedString : MMgtTShared
	{
		public TCollectionHExtendedString()
 :
			base(TCollection_HExtendedString_Ctor() )
		{}
		public TCollectionHExtendedString(string message)
 :
			base(TCollection_HExtendedString_Ctor9381D4D(message) )
		{}
		public TCollectionHExtendedString(char aChar)
 :
			base(TCollection_HExtendedString_CtorBCA09447(aChar) )
		{}
		public TCollectionHExtendedString(int length,char filler)
 :
			base(TCollection_HExtendedString_Ctor71824F83(length, filler) )
		{}
		public TCollectionHExtendedString(TCollectionExtendedString aString)
 :
			base(TCollection_HExtendedString_Ctor6EE6EE89(aString.Instance) )
		{}
		public TCollectionHExtendedString(TCollectionHAsciiString aString)
 :
			base(TCollection_HExtendedString_CtorB439B3D5(aString.Instance) )
		{}
		public TCollectionHExtendedString(TCollectionHExtendedString aString)
 :
			base(TCollection_HExtendedString_Ctor4C6BF532(aString.Instance) )
		{}
			public void AssignCat(TCollectionHExtendedString other)
				{
					TCollection_HExtendedString_AssignCat4C6BF532(Instance, other.Instance);
				}
			public TCollectionHExtendedString Cat(TCollectionHExtendedString other)
				{
					return new TCollectionHExtendedString(TCollection_HExtendedString_Cat4C6BF532(Instance, other.Instance));
				}
			public void ChangeAll(char aChar,char NewChar)
				{
					TCollection_HExtendedString_ChangeAllF70B733C(Instance, aChar, NewChar);
				}
			public void Clear()
				{
					TCollection_HExtendedString_Clear(Instance);
				}
			public void Insert(int where,char what)
				{
					TCollection_HExtendedString_Insert71824F83(Instance, where, what);
				}
			public void Insert(int where,TCollectionHExtendedString what)
				{
					TCollection_HExtendedString_Insert2BBF075E(Instance, where, what.Instance);
				}
			public bool IsLess(TCollectionHExtendedString other)
				{
					return TCollection_HExtendedString_IsLess4C6BF532(Instance, other.Instance);
				}
			public bool IsGreater(TCollectionHExtendedString other)
				{
					return TCollection_HExtendedString_IsGreater4C6BF532(Instance, other.Instance);
				}
			public void Remove(int where,int ahowmany)
				{
					TCollection_HExtendedString_Remove5107F6FE(Instance, where, ahowmany);
				}
			public void RemoveAll(char what)
				{
					TCollection_HExtendedString_RemoveAllBCA09447(Instance, what);
				}
			public void SetValue(int where,char what)
				{
					TCollection_HExtendedString_SetValue71824F83(Instance, where, what);
				}
			public void SetValue(int where,TCollectionHExtendedString what)
				{
					TCollection_HExtendedString_SetValue2BBF075E(Instance, where, what.Instance);
				}
			public TCollectionHExtendedString Split(int where)
				{
					return new TCollectionHExtendedString(TCollection_HExtendedString_SplitE8219145(Instance, where));
				}
			public int Search(TCollectionHExtendedString what)
				{
					return TCollection_HExtendedString_Search4C6BF532(Instance, what.Instance);
				}
			public int SearchFromEnd(TCollectionHExtendedString what)
				{
					return TCollection_HExtendedString_SearchFromEnd4C6BF532(Instance, what.Instance);
				}
			public void Trunc(int ahowmany)
				{
					TCollection_HExtendedString_TruncE8219145(Instance, ahowmany);
				}
			public char Value(int where)
				{
					return TCollection_HExtendedString_ValueE8219145(Instance, where);
				}
			public bool IsSameState(TCollectionHExtendedString other)
				{
					return TCollection_HExtendedString_IsSameState4C6BF532(Instance, other.Instance);
				}
		public bool IsEmpty{
			get {
				return TCollection_HExtendedString_IsEmpty(Instance);
			}
		}
		public bool IsAscii{
			get {
				return TCollection_HExtendedString_IsAscii(Instance);
			}
		}
		public int Length{
			get {
				return TCollection_HExtendedString_Length(Instance);
			}
		}
		public TCollectionExtendedString String{
			get {
				return new TCollectionExtendedString(TCollection_HExtendedString_String(Instance));
			}
		}
		public TCollectionHExtendedString ShallowCopy{
			get {
				return new TCollectionHExtendedString(TCollection_HExtendedString_ShallowCopy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HExtendedString_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HExtendedString_Ctor9381D4D(string message);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HExtendedString_CtorBCA09447(char aChar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HExtendedString_Ctor71824F83(int length,char filler);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HExtendedString_Ctor6EE6EE89(IntPtr aString);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HExtendedString_CtorB439B3D5(IntPtr aString);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HExtendedString_Ctor4C6BF532(IntPtr aString);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HExtendedString_AssignCat4C6BF532(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HExtendedString_Cat4C6BF532(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HExtendedString_ChangeAllF70B733C(IntPtr instance, char aChar,char NewChar);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HExtendedString_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HExtendedString_Insert71824F83(IntPtr instance, int where,char what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HExtendedString_Insert2BBF075E(IntPtr instance, int where,IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HExtendedString_IsLess4C6BF532(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HExtendedString_IsGreater4C6BF532(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HExtendedString_Remove5107F6FE(IntPtr instance, int where,int ahowmany);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HExtendedString_RemoveAllBCA09447(IntPtr instance, char what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HExtendedString_SetValue71824F83(IntPtr instance, int where,char what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HExtendedString_SetValue2BBF075E(IntPtr instance, int where,IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HExtendedString_SplitE8219145(IntPtr instance, int where);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HExtendedString_Search4C6BF532(IntPtr instance, IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HExtendedString_SearchFromEnd4C6BF532(IntPtr instance, IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HExtendedString_TruncE8219145(IntPtr instance, int ahowmany);
		[DllImport("NaroOccCore.dll")]
		private static extern char TCollection_HExtendedString_ValueE8219145(IntPtr instance, int where);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HExtendedString_IsSameState4C6BF532(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HExtendedString_IsEmpty(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HExtendedString_IsAscii(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HExtendedString_Length(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HExtendedString_String(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HExtendedString_ShallowCopy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TCollectionHExtendedString(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TCollectionHExtendedString_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TCollectionHExtendedString_Dtor(IntPtr instance);
	}
}
