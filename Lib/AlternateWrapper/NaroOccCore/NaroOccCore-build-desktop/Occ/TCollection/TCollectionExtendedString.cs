#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.TCollection
{
	public class TCollectionExtendedString : NativeInstancePtr
	{
		public TCollectionExtendedString()
 :
			base(TCollection_ExtendedString_Ctor() )
		{}
		public TCollectionExtendedString(string astring,bool isMultiByte)
 :
			base(TCollection_ExtendedString_CtorDE32234A(astring, isMultiByte) )
		{}
		public TCollectionExtendedString(string astring)
 :
			base(TCollection_ExtendedString_Ctor9381D4D(astring) )
		{}
		public TCollectionExtendedString(char aChar)
 :
			base(TCollection_ExtendedString_CtorBCA09447(aChar) )
		{}
		public TCollectionExtendedString(int length,char filler)
 :
			base(TCollection_ExtendedString_Ctor71824F83(length, filler) )
		{}
		public TCollectionExtendedString(int value)
 :
			base(TCollection_ExtendedString_CtorE8219145(value) )
		{}
		public TCollectionExtendedString(double value)
 :
			base(TCollection_ExtendedString_CtorD82819F3(value) )
		{}
		public TCollectionExtendedString(TCollectionExtendedString astring)
 :
			base(TCollection_ExtendedString_Ctor6EE6EE89(astring.Instance) )
		{}
		public TCollectionExtendedString(TCollectionAsciiString astring)
 :
			base(TCollection_ExtendedString_Ctor66CFACD0(astring.Instance) )
		{}
			public void AssignCat(TCollectionExtendedString other)
				{
					TCollection_ExtendedString_AssignCat6EE6EE89(Instance, other.Instance);
				}
			public TCollectionExtendedString Cat(TCollectionExtendedString other)
				{
					return new TCollectionExtendedString(TCollection_ExtendedString_Cat6EE6EE89(Instance, other.Instance));
				}
			public void ChangeAll(char aChar,char NewChar)
				{
					TCollection_ExtendedString_ChangeAllF70B733C(Instance, aChar, NewChar);
				}
			public void Clear()
				{
					TCollection_ExtendedString_Clear(Instance);
				}
			public void Copy(TCollectionExtendedString fromwhere)
				{
					TCollection_ExtendedString_Copy6EE6EE89(Instance, fromwhere.Instance);
				}
			public void Insert(int where,char what)
				{
					TCollection_ExtendedString_Insert71824F83(Instance, where, what);
				}
			public void Insert(int where,TCollectionExtendedString what)
				{
					TCollection_ExtendedString_Insert682EC762(Instance, where, what.Instance);
				}
			public bool IsEqual(string other)
				{
					return TCollection_ExtendedString_IsEqual9381D4D(Instance, other);
				}
			public bool IsEqual(TCollectionExtendedString other)
				{
					return TCollection_ExtendedString_IsEqual6EE6EE89(Instance, other.Instance);
				}
			public bool IsDifferent(string other)
				{
					return TCollection_ExtendedString_IsDifferent9381D4D(Instance, other);
				}
			public bool IsDifferent(TCollectionExtendedString other)
				{
					return TCollection_ExtendedString_IsDifferent6EE6EE89(Instance, other.Instance);
				}
			public bool IsLess(string other)
				{
					return TCollection_ExtendedString_IsLess9381D4D(Instance, other);
				}
			public bool IsLess(TCollectionExtendedString other)
				{
					return TCollection_ExtendedString_IsLess6EE6EE89(Instance, other.Instance);
				}
			public bool IsGreater(string other)
				{
					return TCollection_ExtendedString_IsGreater9381D4D(Instance, other);
				}
			public bool IsGreater(TCollectionExtendedString other)
				{
					return TCollection_ExtendedString_IsGreater6EE6EE89(Instance, other.Instance);
				}
			public void RemoveAll(char what)
				{
					TCollection_ExtendedString_RemoveAllBCA09447(Instance, what);
				}
			public void Remove(int where,int ahowmany)
				{
					TCollection_ExtendedString_Remove5107F6FE(Instance, where, ahowmany);
				}
			public int Search(TCollectionExtendedString what)
				{
					return TCollection_ExtendedString_Search6EE6EE89(Instance, what.Instance);
				}
			public int SearchFromEnd(TCollectionExtendedString what)
				{
					return TCollection_ExtendedString_SearchFromEnd6EE6EE89(Instance, what.Instance);
				}
			public void SetValue(int where,char what)
				{
					TCollection_ExtendedString_SetValue71824F83(Instance, where, what);
				}
			public void SetValue(int where,TCollectionExtendedString what)
				{
					TCollection_ExtendedString_SetValue682EC762(Instance, where, what.Instance);
				}
			public TCollectionExtendedString Split(int where)
				{
					return new TCollectionExtendedString(TCollection_ExtendedString_SplitE8219145(Instance, where));
				}
			public void Trunc(int ahowmany)
				{
					TCollection_ExtendedString_TruncE8219145(Instance, ahowmany);
				}
			public char Value(int where)
				{
					return TCollection_ExtendedString_ValueE8219145(Instance, where);
				}
			public static int HashCode(TCollectionExtendedString astring,int Upper)
				{
					return TCollection_ExtendedString_HashCode6F67650A(astring.Instance, Upper);
				}
			public static bool IsEqual(TCollectionExtendedString string1,TCollectionExtendedString string2)
				{
					return TCollection_ExtendedString_IsEqual39BDF64A(string1.Instance, string2.Instance);
				}
		public bool IsAscii{
			get {
				return TCollection_ExtendedString_IsAscii(Instance);
			}
		}
		public int Length{
			get {
				return TCollection_ExtendedString_Length(Instance);
			}
		}
		public int LengthOfCString{
			get {
				return TCollection_ExtendedString_LengthOfCString(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_ExtendedString_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_ExtendedString_CtorDE32234A(string astring,bool isMultiByte);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_ExtendedString_Ctor9381D4D(string astring);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_ExtendedString_CtorBCA09447(char aChar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_ExtendedString_Ctor71824F83(int length,char filler);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_ExtendedString_CtorE8219145(int value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_ExtendedString_CtorD82819F3(double value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_ExtendedString_Ctor6EE6EE89(IntPtr astring);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_ExtendedString_Ctor66CFACD0(IntPtr astring);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_ExtendedString_AssignCat6EE6EE89(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_ExtendedString_Cat6EE6EE89(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_ExtendedString_ChangeAllF70B733C(IntPtr instance, char aChar,char NewChar);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_ExtendedString_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_ExtendedString_Copy6EE6EE89(IntPtr instance, IntPtr fromwhere);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_ExtendedString_Insert71824F83(IntPtr instance, int where,char what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_ExtendedString_Insert682EC762(IntPtr instance, int where,IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_ExtendedString_IsEqual9381D4D(IntPtr instance, string other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_ExtendedString_IsEqual6EE6EE89(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_ExtendedString_IsDifferent9381D4D(IntPtr instance, string other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_ExtendedString_IsDifferent6EE6EE89(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_ExtendedString_IsLess9381D4D(IntPtr instance, string other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_ExtendedString_IsLess6EE6EE89(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_ExtendedString_IsGreater9381D4D(IntPtr instance, string other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_ExtendedString_IsGreater6EE6EE89(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_ExtendedString_RemoveAllBCA09447(IntPtr instance, char what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_ExtendedString_Remove5107F6FE(IntPtr instance, int where,int ahowmany);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_ExtendedString_Search6EE6EE89(IntPtr instance, IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_ExtendedString_SearchFromEnd6EE6EE89(IntPtr instance, IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_ExtendedString_SetValue71824F83(IntPtr instance, int where,char what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_ExtendedString_SetValue682EC762(IntPtr instance, int where,IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_ExtendedString_SplitE8219145(IntPtr instance, int where);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_ExtendedString_TruncE8219145(IntPtr instance, int ahowmany);
		[DllImport("NaroOccCore.dll")]
		private static extern char TCollection_ExtendedString_ValueE8219145(IntPtr instance, int where);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_ExtendedString_HashCode6F67650A(IntPtr astring,int Upper);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_ExtendedString_IsEqual39BDF64A(IntPtr string1,IntPtr string2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_ExtendedString_IsAscii(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_ExtendedString_Length(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_ExtendedString_LengthOfCString(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TCollectionExtendedString(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TCollectionExtendedString_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TCollectionExtendedString_Dtor(IntPtr instance);
	}
}
