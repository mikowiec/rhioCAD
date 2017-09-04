#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.TCollection
{
	public class TCollectionAsciiString : NativeInstancePtr
	{
		public TCollectionAsciiString()
 :
			base(TCollection_AsciiString_Ctor() )
		{}
		public TCollectionAsciiString(string message)
 :
			base(TCollection_AsciiString_Ctor9381D4D(message) )
		{}
		public TCollectionAsciiString(string message,int aLen)
 :
			base(TCollection_AsciiString_Ctor800FADE1(message, aLen) )
		{}
		public TCollectionAsciiString(char aChar)
 :
			base(TCollection_AsciiString_CtorBCA09447(aChar) )
		{}
		public TCollectionAsciiString(int length,char filler)
 :
			base(TCollection_AsciiString_Ctor71824F83(length, filler) )
		{}
		public TCollectionAsciiString(int value)
 :
			base(TCollection_AsciiString_CtorE8219145(value) )
		{}
		public TCollectionAsciiString(double value)
 :
			base(TCollection_AsciiString_CtorD82819F3(value) )
		{}
		public TCollectionAsciiString(TCollectionAsciiString astring)
 :
			base(TCollection_AsciiString_Ctor66CFACD0(astring.Instance) )
		{}
		public TCollectionAsciiString(TCollectionAsciiString astring,char message)
 :
			base(TCollection_AsciiString_CtorD142C0D4(astring.Instance, message) )
		{}
		public TCollectionAsciiString(TCollectionAsciiString astring,string message)
 :
			base(TCollection_AsciiString_Ctor54DBAE97(astring.Instance, message) )
		{}
		public TCollectionAsciiString(TCollectionAsciiString astring,TCollectionAsciiString message)
 :
			base(TCollection_AsciiString_CtorB82186D3(astring.Instance, message.Instance) )
		{}
		public TCollectionAsciiString(TCollectionExtendedString astring,char replaceNonAscii)
 :
			base(TCollection_AsciiString_Ctor77E26705(astring.Instance, replaceNonAscii) )
		{}
			public void AssignCat(char other)
				{
					TCollection_AsciiString_AssignCatBCA09447(Instance, other);
				}
			public void AssignCat(int other)
				{
					TCollection_AsciiString_AssignCatE8219145(Instance, other);
				}
			public void AssignCat(double other)
				{
					TCollection_AsciiString_AssignCatD82819F3(Instance, other);
				}
			public void AssignCat(string other)
				{
					TCollection_AsciiString_AssignCat9381D4D(Instance, other);
				}
			public void AssignCat(TCollectionAsciiString other)
				{
					TCollection_AsciiString_AssignCat66CFACD0(Instance, other.Instance);
				}
			public void Capitalize()
				{
					TCollection_AsciiString_Capitalize(Instance);
				}
			public TCollectionAsciiString Cat(char other)
				{
					return new TCollectionAsciiString(TCollection_AsciiString_CatBCA09447(Instance, other));
				}
			public TCollectionAsciiString Cat(int other)
				{
					return new TCollectionAsciiString(TCollection_AsciiString_CatE8219145(Instance, other));
				}
			public TCollectionAsciiString Cat(double other)
				{
					return new TCollectionAsciiString(TCollection_AsciiString_CatD82819F3(Instance, other));
				}
			public TCollectionAsciiString Cat(string other)
				{
					return new TCollectionAsciiString(TCollection_AsciiString_Cat9381D4D(Instance, other));
				}
			public TCollectionAsciiString Cat(TCollectionAsciiString other)
				{
					return new TCollectionAsciiString(TCollection_AsciiString_Cat66CFACD0(Instance, other.Instance));
				}
			public void Center(int Width,char Filler)
				{
					TCollection_AsciiString_Center71824F83(Instance, Width, Filler);
				}
			public void ChangeAll(char aChar,char NewChar,bool CaseSensitive)
				{
					TCollection_AsciiString_ChangeAll4A8EEFF6(Instance, aChar, NewChar, CaseSensitive);
				}
			public void Clear()
				{
					TCollection_AsciiString_Clear(Instance);
				}
			public void Copy(string fromwhere)
				{
					TCollection_AsciiString_Copy9381D4D(Instance, fromwhere);
				}
			public void Copy(TCollectionAsciiString fromwhere)
				{
					TCollection_AsciiString_Copy66CFACD0(Instance, fromwhere.Instance);
				}
			public int FirstLocationInSet(TCollectionAsciiString Set,int FromIndex,int ToIndex)
				{
					return TCollection_AsciiString_FirstLocationInSet10E3C1BB(Instance, Set.Instance, FromIndex, ToIndex);
				}
			public int FirstLocationNotInSet(TCollectionAsciiString Set,int FromIndex,int ToIndex)
				{
					return TCollection_AsciiString_FirstLocationNotInSet10E3C1BB(Instance, Set.Instance, FromIndex, ToIndex);
				}
			public void Insert(int where,char what)
				{
					TCollection_AsciiString_Insert71824F83(Instance, where, what);
				}
			public void Insert(int where,string what)
				{
					TCollection_AsciiString_InsertC9F1A165(Instance, where, what);
				}
			public void Insert(int where,TCollectionAsciiString what)
				{
					TCollection_AsciiString_InsertFCE887E8(Instance, where, what.Instance);
				}
			public void InsertAfter(int Index,TCollectionAsciiString other)
				{
					TCollection_AsciiString_InsertAfterFCE887E8(Instance, Index, other.Instance);
				}
			public void InsertBefore(int Index,TCollectionAsciiString other)
				{
					TCollection_AsciiString_InsertBeforeFCE887E8(Instance, Index, other.Instance);
				}
			public bool IsEqual(string other)
				{
					return TCollection_AsciiString_IsEqual9381D4D(Instance, other);
				}
			public bool IsEqual(TCollectionAsciiString other)
				{
					return TCollection_AsciiString_IsEqual66CFACD0(Instance, other.Instance);
				}
			public bool IsDifferent(string other)
				{
					return TCollection_AsciiString_IsDifferent9381D4D(Instance, other);
				}
			public bool IsDifferent(TCollectionAsciiString other)
				{
					return TCollection_AsciiString_IsDifferent66CFACD0(Instance, other.Instance);
				}
			public bool IsLess(string other)
				{
					return TCollection_AsciiString_IsLess9381D4D(Instance, other);
				}
			public bool IsLess(TCollectionAsciiString other)
				{
					return TCollection_AsciiString_IsLess66CFACD0(Instance, other.Instance);
				}
			public bool IsGreater(string other)
				{
					return TCollection_AsciiString_IsGreater9381D4D(Instance, other);
				}
			public bool IsGreater(TCollectionAsciiString other)
				{
					return TCollection_AsciiString_IsGreater66CFACD0(Instance, other.Instance);
				}
			public void LeftAdjust()
				{
					TCollection_AsciiString_LeftAdjust(Instance);
				}
			public void LeftJustify(int Width,char Filler)
				{
					TCollection_AsciiString_LeftJustify71824F83(Instance, Width, Filler);
				}
			public int Location(TCollectionAsciiString other,int FromIndex,int ToIndex)
				{
					return TCollection_AsciiString_Location10E3C1BB(Instance, other.Instance, FromIndex, ToIndex);
				}
			public int Location(int N,char C,int FromIndex,int ToIndex)
				{
					return TCollection_AsciiString_LocationB9967886(Instance, N, C, FromIndex, ToIndex);
				}
			public void LowerCase()
				{
					TCollection_AsciiString_LowerCase(Instance);
				}
			public void Prepend(TCollectionAsciiString other)
				{
					TCollection_AsciiString_Prepend66CFACD0(Instance, other.Instance);
				}
			public void RemoveAll(char C,bool CaseSensitive)
				{
					TCollection_AsciiString_RemoveAll6D30D0F7(Instance, C, CaseSensitive);
				}
			public void RemoveAll(char what)
				{
					TCollection_AsciiString_RemoveAllBCA09447(Instance, what);
				}
			public void Remove(int where,int ahowmany)
				{
					TCollection_AsciiString_Remove5107F6FE(Instance, where, ahowmany);
				}
			public void RightAdjust()
				{
					TCollection_AsciiString_RightAdjust(Instance);
				}
			public void RightJustify(int Width,char Filler)
				{
					TCollection_AsciiString_RightJustify71824F83(Instance, Width, Filler);
				}
			public int Search(string what)
				{
					return TCollection_AsciiString_Search9381D4D(Instance, what);
				}
			public int Search(TCollectionAsciiString what)
				{
					return TCollection_AsciiString_Search66CFACD0(Instance, what.Instance);
				}
			public int SearchFromEnd(string what)
				{
					return TCollection_AsciiString_SearchFromEnd9381D4D(Instance, what);
				}
			public int SearchFromEnd(TCollectionAsciiString what)
				{
					return TCollection_AsciiString_SearchFromEnd66CFACD0(Instance, what.Instance);
				}
			public void SetValue(int where,char what)
				{
					TCollection_AsciiString_SetValue71824F83(Instance, where, what);
				}
			public void SetValue(int where,string what)
				{
					TCollection_AsciiString_SetValueC9F1A165(Instance, where, what);
				}
			public void SetValue(int where,TCollectionAsciiString what)
				{
					TCollection_AsciiString_SetValueFCE887E8(Instance, where, what.Instance);
				}
			public TCollectionAsciiString Split(int where)
				{
					return new TCollectionAsciiString(TCollection_AsciiString_SplitE8219145(Instance, where));
				}
			public TCollectionAsciiString SubString(int FromIndex,int ToIndex)
				{
					return new TCollectionAsciiString(TCollection_AsciiString_SubString5107F6FE(Instance, FromIndex, ToIndex));
				}
			public TCollectionAsciiString Token(string separators,int whichone)
				{
					return new TCollectionAsciiString(TCollection_AsciiString_Token800FADE1(Instance, separators, whichone));
				}
			public void Trunc(int ahowmany)
				{
					TCollection_AsciiString_TruncE8219145(Instance, ahowmany);
				}
			public void UpperCase()
				{
					TCollection_AsciiString_UpperCase(Instance);
				}
			public char Value(int where)
				{
					return TCollection_AsciiString_ValueE8219145(Instance, where);
				}
			public static int HashCode(TCollectionAsciiString astring,int Upper)
				{
					return TCollection_AsciiString_HashCodeCAFD1949(astring.Instance, Upper);
				}
			public static bool IsEqual(TCollectionAsciiString string1,TCollectionAsciiString string2)
				{
					return TCollection_AsciiString_IsEqualB82186D3(string1.Instance, string2.Instance);
				}
			public static bool IsEqual(TCollectionAsciiString string1,string string2)
				{
					return TCollection_AsciiString_IsEqual54DBAE97(string1.Instance, string2);
				}
			public static int HASHCODE(TCollectionAsciiString astring,int Upper)
				{
					return TCollection_AsciiString_HASHCODECAFD1949(astring.Instance, Upper);
				}
			public static bool ISSIMILAR(TCollectionAsciiString string1,TCollectionAsciiString string2)
				{
					return TCollection_AsciiString_ISSIMILARB82186D3(string1.Instance, string2.Instance);
				}
		public bool IsEmpty{
			get {
				return TCollection_AsciiString_IsEmpty(Instance);
			}
		}
		public int IntegerValue{
			get {
				return TCollection_AsciiString_IntegerValue(Instance);
			}
		}
		public bool IsIntegerValue{
			get {
				return TCollection_AsciiString_IsIntegerValue(Instance);
			}
		}
		public bool IsRealValue{
			get {
				return TCollection_AsciiString_IsRealValue(Instance);
			}
		}
		public bool IsAscii{
			get {
				return TCollection_AsciiString_IsAscii(Instance);
			}
		}
		public int Length{
			get {
				return TCollection_AsciiString_Length(Instance);
			}
		}
		public double RealValue{
			get {
				return TCollection_AsciiString_RealValue(Instance);
			}
		}
		public string ToCString{
			get {
				return TCollection_AsciiString_ToCString(Instance);
			}
		}
		public int UsefullLength{
			get {
				return TCollection_AsciiString_UsefullLength(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_Ctor9381D4D(string message);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_Ctor800FADE1(string message,int aLen);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_CtorBCA09447(char aChar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_Ctor71824F83(int length,char filler);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_CtorE8219145(int value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_CtorD82819F3(double value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_Ctor66CFACD0(IntPtr astring);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_CtorD142C0D4(IntPtr astring,char message);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_Ctor54DBAE97(IntPtr astring,string message);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_CtorB82186D3(IntPtr astring,IntPtr message);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_Ctor77E26705(IntPtr astring,char replaceNonAscii);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_AssignCatBCA09447(IntPtr instance, char other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_AssignCatE8219145(IntPtr instance, int other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_AssignCatD82819F3(IntPtr instance, double other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_AssignCat9381D4D(IntPtr instance, string other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_AssignCat66CFACD0(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_Capitalize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_CatBCA09447(IntPtr instance, char other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_CatE8219145(IntPtr instance, int other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_CatD82819F3(IntPtr instance, double other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_Cat9381D4D(IntPtr instance, string other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_Cat66CFACD0(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_Center71824F83(IntPtr instance, int Width,char Filler);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_ChangeAll4A8EEFF6(IntPtr instance, char aChar,char NewChar,bool CaseSensitive);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_Copy9381D4D(IntPtr instance, string fromwhere);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_Copy66CFACD0(IntPtr instance, IntPtr fromwhere);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_FirstLocationInSet10E3C1BB(IntPtr instance, IntPtr Set,int FromIndex,int ToIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_FirstLocationNotInSet10E3C1BB(IntPtr instance, IntPtr Set,int FromIndex,int ToIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_Insert71824F83(IntPtr instance, int where,char what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_InsertC9F1A165(IntPtr instance, int where,string what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_InsertFCE887E8(IntPtr instance, int where,IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_InsertAfterFCE887E8(IntPtr instance, int Index,IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_InsertBeforeFCE887E8(IntPtr instance, int Index,IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsEqual9381D4D(IntPtr instance, string other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsEqual66CFACD0(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsDifferent9381D4D(IntPtr instance, string other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsDifferent66CFACD0(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsLess9381D4D(IntPtr instance, string other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsLess66CFACD0(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsGreater9381D4D(IntPtr instance, string other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsGreater66CFACD0(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_LeftAdjust(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_LeftJustify71824F83(IntPtr instance, int Width,char Filler);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_Location10E3C1BB(IntPtr instance, IntPtr other,int FromIndex,int ToIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_LocationB9967886(IntPtr instance, int N,char C,int FromIndex,int ToIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_LowerCase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_Prepend66CFACD0(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_RemoveAll6D30D0F7(IntPtr instance, char C,bool CaseSensitive);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_RemoveAllBCA09447(IntPtr instance, char what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_Remove5107F6FE(IntPtr instance, int where,int ahowmany);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_RightAdjust(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_RightJustify71824F83(IntPtr instance, int Width,char Filler);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_Search9381D4D(IntPtr instance, string what);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_Search66CFACD0(IntPtr instance, IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_SearchFromEnd9381D4D(IntPtr instance, string what);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_SearchFromEnd66CFACD0(IntPtr instance, IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_SetValue71824F83(IntPtr instance, int where,char what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_SetValueC9F1A165(IntPtr instance, int where,string what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_SetValueFCE887E8(IntPtr instance, int where,IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_SplitE8219145(IntPtr instance, int where);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_SubString5107F6FE(IntPtr instance, int FromIndex,int ToIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_AsciiString_Token800FADE1(IntPtr instance, string separators,int whichone);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_TruncE8219145(IntPtr instance, int ahowmany);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_AsciiString_UpperCase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern char TCollection_AsciiString_ValueE8219145(IntPtr instance, int where);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_HashCodeCAFD1949(IntPtr astring,int Upper);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsEqualB82186D3(IntPtr string1,IntPtr string2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsEqual54DBAE97(IntPtr string1,string string2);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_HASHCODECAFD1949(IntPtr astring,int Upper);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_ISSIMILARB82186D3(IntPtr string1,IntPtr string2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsEmpty(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_IntegerValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsIntegerValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsRealValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_AsciiString_IsAscii(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_Length(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double TCollection_AsciiString_RealValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string TCollection_AsciiString_ToCString(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_AsciiString_UsefullLength(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TCollectionAsciiString(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TCollectionAsciiString_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TCollectionAsciiString_Dtor(IntPtr instance);
	}
}
