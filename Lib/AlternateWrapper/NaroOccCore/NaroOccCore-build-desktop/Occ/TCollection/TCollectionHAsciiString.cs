#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.TCollection
{
	public class TCollectionHAsciiString : MMgtTShared
	{
		public TCollectionHAsciiString()
 :
			base(TCollection_HAsciiString_Ctor() )
		{}
		public TCollectionHAsciiString(string message)
 :
			base(TCollection_HAsciiString_Ctor9381D4D(message) )
		{}
		public TCollectionHAsciiString(char aChar)
 :
			base(TCollection_HAsciiString_CtorBCA09447(aChar) )
		{}
		public TCollectionHAsciiString(int length,char filler)
 :
			base(TCollection_HAsciiString_Ctor71824F83(length, filler) )
		{}
		public TCollectionHAsciiString(int value)
 :
			base(TCollection_HAsciiString_CtorE8219145(value) )
		{}
		public TCollectionHAsciiString(double value)
 :
			base(TCollection_HAsciiString_CtorD82819F3(value) )
		{}
		public TCollectionHAsciiString(TCollectionAsciiString aString)
 :
			base(TCollection_HAsciiString_Ctor66CFACD0(aString.Instance) )
		{}
		public TCollectionHAsciiString(TCollectionHAsciiString aString)
 :
			base(TCollection_HAsciiString_CtorB439B3D5(aString.Instance) )
		{}
		public TCollectionHAsciiString(TCollectionHExtendedString aString,char replaceNonAscii)
 :
			base(TCollection_HAsciiString_CtorB5FFA54(aString.Instance, replaceNonAscii) )
		{}
			public void AssignCat(string other)
				{
					TCollection_HAsciiString_AssignCat9381D4D(Instance, other);
				}
			public void AssignCat(TCollectionHAsciiString other)
				{
					TCollection_HAsciiString_AssignCatB439B3D5(Instance, other.Instance);
				}
			public void Capitalize()
				{
					TCollection_HAsciiString_Capitalize(Instance);
				}
			public TCollectionHAsciiString Cat(string other)
				{
					return new TCollectionHAsciiString(TCollection_HAsciiString_Cat9381D4D(Instance, other));
				}
			public TCollectionHAsciiString Cat(TCollectionHAsciiString other)
				{
					return new TCollectionHAsciiString(TCollection_HAsciiString_CatB439B3D5(Instance, other.Instance));
				}
			public void Center(int Width,char Filler)
				{
					TCollection_HAsciiString_Center71824F83(Instance, Width, Filler);
				}
			public void ChangeAll(char aChar,char NewChar,bool CaseSensitive)
				{
					TCollection_HAsciiString_ChangeAll4A8EEFF6(Instance, aChar, NewChar, CaseSensitive);
				}
			public void Clear()
				{
					TCollection_HAsciiString_Clear(Instance);
				}
			public int FirstLocationInSet(TCollectionHAsciiString Set,int FromIndex,int ToIndex)
				{
					return TCollection_HAsciiString_FirstLocationInSet2FE6ADDB(Instance, Set.Instance, FromIndex, ToIndex);
				}
			public int FirstLocationNotInSet(TCollectionHAsciiString Set,int FromIndex,int ToIndex)
				{
					return TCollection_HAsciiString_FirstLocationNotInSet2FE6ADDB(Instance, Set.Instance, FromIndex, ToIndex);
				}
			public void Insert(int where,char what)
				{
					TCollection_HAsciiString_Insert71824F83(Instance, where, what);
				}
			public void Insert(int where,string what)
				{
					TCollection_HAsciiString_InsertC9F1A165(Instance, where, what);
				}
			public void Insert(int where,TCollectionHAsciiString what)
				{
					TCollection_HAsciiString_Insert6A685A10(Instance, where, what.Instance);
				}
			public void InsertAfter(int Index,TCollectionHAsciiString other)
				{
					TCollection_HAsciiString_InsertAfter6A685A10(Instance, Index, other.Instance);
				}
			public void InsertBefore(int Index,TCollectionHAsciiString other)
				{
					TCollection_HAsciiString_InsertBefore6A685A10(Instance, Index, other.Instance);
				}
			public bool IsLess(TCollectionHAsciiString other)
				{
					return TCollection_HAsciiString_IsLessB439B3D5(Instance, other.Instance);
				}
			public bool IsGreater(TCollectionHAsciiString other)
				{
					return TCollection_HAsciiString_IsGreaterB439B3D5(Instance, other.Instance);
				}
			public bool IsDifferent(TCollectionHAsciiString S)
				{
					return TCollection_HAsciiString_IsDifferentB439B3D5(Instance, S.Instance);
				}
			public bool IsSameString(TCollectionHAsciiString S)
				{
					return TCollection_HAsciiString_IsSameStringB439B3D5(Instance, S.Instance);
				}
			public bool IsSameString(TCollectionHAsciiString S,bool CaseSensitive)
				{
					return TCollection_HAsciiString_IsSameString34C64CD3(Instance, S.Instance, CaseSensitive);
				}
			public void LeftAdjust()
				{
					TCollection_HAsciiString_LeftAdjust(Instance);
				}
			public void LeftJustify(int Width,char Filler)
				{
					TCollection_HAsciiString_LeftJustify71824F83(Instance, Width, Filler);
				}
			public int Location(TCollectionHAsciiString other,int FromIndex,int ToIndex)
				{
					return TCollection_HAsciiString_Location2FE6ADDB(Instance, other.Instance, FromIndex, ToIndex);
				}
			public int Location(int N,char C,int FromIndex,int ToIndex)
				{
					return TCollection_HAsciiString_LocationB9967886(Instance, N, C, FromIndex, ToIndex);
				}
			public void LowerCase()
				{
					TCollection_HAsciiString_LowerCase(Instance);
				}
			public void Prepend(TCollectionHAsciiString other)
				{
					TCollection_HAsciiString_PrependB439B3D5(Instance, other.Instance);
				}
			public void RemoveAll(char C,bool CaseSensitive)
				{
					TCollection_HAsciiString_RemoveAll6D30D0F7(Instance, C, CaseSensitive);
				}
			public void RemoveAll(char what)
				{
					TCollection_HAsciiString_RemoveAllBCA09447(Instance, what);
				}
			public void Remove(int where,int ahowmany)
				{
					TCollection_HAsciiString_Remove5107F6FE(Instance, where, ahowmany);
				}
			public void RightAdjust()
				{
					TCollection_HAsciiString_RightAdjust(Instance);
				}
			public void RightJustify(int Width,char Filler)
				{
					TCollection_HAsciiString_RightJustify71824F83(Instance, Width, Filler);
				}
			public int Search(string what)
				{
					return TCollection_HAsciiString_Search9381D4D(Instance, what);
				}
			public int Search(TCollectionHAsciiString what)
				{
					return TCollection_HAsciiString_SearchB439B3D5(Instance, what.Instance);
				}
			public int SearchFromEnd(string what)
				{
					return TCollection_HAsciiString_SearchFromEnd9381D4D(Instance, what);
				}
			public int SearchFromEnd(TCollectionHAsciiString what)
				{
					return TCollection_HAsciiString_SearchFromEndB439B3D5(Instance, what.Instance);
				}
			public void SetValue(int where,char what)
				{
					TCollection_HAsciiString_SetValue71824F83(Instance, where, what);
				}
			public void SetValue(int where,string what)
				{
					TCollection_HAsciiString_SetValueC9F1A165(Instance, where, what);
				}
			public void SetValue(int where,TCollectionHAsciiString what)
				{
					TCollection_HAsciiString_SetValue6A685A10(Instance, where, what.Instance);
				}
			public TCollectionHAsciiString Split(int where)
				{
					return new TCollectionHAsciiString(TCollection_HAsciiString_SplitE8219145(Instance, where));
				}
			public TCollectionHAsciiString SubString(int FromIndex,int ToIndex)
				{
					return new TCollectionHAsciiString(TCollection_HAsciiString_SubString5107F6FE(Instance, FromIndex, ToIndex));
				}
			public TCollectionHAsciiString Token(string separators,int whichone)
				{
					return new TCollectionHAsciiString(TCollection_HAsciiString_Token800FADE1(Instance, separators, whichone));
				}
			public void Trunc(int ahowmany)
				{
					TCollection_HAsciiString_TruncE8219145(Instance, ahowmany);
				}
			public void UpperCase()
				{
					TCollection_HAsciiString_UpperCase(Instance);
				}
			public char Value(int where)
				{
					return TCollection_HAsciiString_ValueE8219145(Instance, where);
				}
			public bool IsSameState(TCollectionHAsciiString other)
				{
					return TCollection_HAsciiString_IsSameStateB439B3D5(Instance, other.Instance);
				}
		public bool IsEmpty{
			get {
				return TCollection_HAsciiString_IsEmpty(Instance);
			}
		}
		public int IntegerValue{
			get {
				return TCollection_HAsciiString_IntegerValue(Instance);
			}
		}
		public bool IsIntegerValue{
			get {
				return TCollection_HAsciiString_IsIntegerValue(Instance);
			}
		}
		public bool IsRealValue{
			get {
				return TCollection_HAsciiString_IsRealValue(Instance);
			}
		}
		public bool IsAscii{
			get {
				return TCollection_HAsciiString_IsAscii(Instance);
			}
		}
		public int Length{
			get {
				return TCollection_HAsciiString_Length(Instance);
			}
		}
		public double RealValue{
			get {
				return TCollection_HAsciiString_RealValue(Instance);
			}
		}
		public string ToCString{
			get {
				return TCollection_HAsciiString_ToCString(Instance);
			}
		}
		public int UsefullLength{
			get {
				return TCollection_HAsciiString_UsefullLength(Instance);
			}
		}
		public TCollectionAsciiString String{
			get {
				return new TCollectionAsciiString(TCollection_HAsciiString_String(Instance));
			}
		}
		public TCollectionHAsciiString ShallowCopy{
			get {
				return new TCollectionHAsciiString(TCollection_HAsciiString_ShallowCopy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_Ctor9381D4D(string message);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_CtorBCA09447(char aChar);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_Ctor71824F83(int length,char filler);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_CtorE8219145(int value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_CtorD82819F3(double value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_Ctor66CFACD0(IntPtr aString);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_CtorB439B3D5(IntPtr aString);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_CtorB5FFA54(IntPtr aString,char replaceNonAscii);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_AssignCat9381D4D(IntPtr instance, string other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_AssignCatB439B3D5(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_Capitalize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_Cat9381D4D(IntPtr instance, string other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_CatB439B3D5(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_Center71824F83(IntPtr instance, int Width,char Filler);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_ChangeAll4A8EEFF6(IntPtr instance, char aChar,char NewChar,bool CaseSensitive);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HAsciiString_FirstLocationInSet2FE6ADDB(IntPtr instance, IntPtr Set,int FromIndex,int ToIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HAsciiString_FirstLocationNotInSet2FE6ADDB(IntPtr instance, IntPtr Set,int FromIndex,int ToIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_Insert71824F83(IntPtr instance, int where,char what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_InsertC9F1A165(IntPtr instance, int where,string what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_Insert6A685A10(IntPtr instance, int where,IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_InsertAfter6A685A10(IntPtr instance, int Index,IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_InsertBefore6A685A10(IntPtr instance, int Index,IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HAsciiString_IsLessB439B3D5(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HAsciiString_IsGreaterB439B3D5(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HAsciiString_IsDifferentB439B3D5(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HAsciiString_IsSameStringB439B3D5(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HAsciiString_IsSameString34C64CD3(IntPtr instance, IntPtr S,bool CaseSensitive);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_LeftAdjust(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_LeftJustify71824F83(IntPtr instance, int Width,char Filler);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HAsciiString_Location2FE6ADDB(IntPtr instance, IntPtr other,int FromIndex,int ToIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HAsciiString_LocationB9967886(IntPtr instance, int N,char C,int FromIndex,int ToIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_LowerCase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_PrependB439B3D5(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_RemoveAll6D30D0F7(IntPtr instance, char C,bool CaseSensitive);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_RemoveAllBCA09447(IntPtr instance, char what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_Remove5107F6FE(IntPtr instance, int where,int ahowmany);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_RightAdjust(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_RightJustify71824F83(IntPtr instance, int Width,char Filler);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HAsciiString_Search9381D4D(IntPtr instance, string what);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HAsciiString_SearchB439B3D5(IntPtr instance, IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HAsciiString_SearchFromEnd9381D4D(IntPtr instance, string what);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HAsciiString_SearchFromEndB439B3D5(IntPtr instance, IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_SetValue71824F83(IntPtr instance, int where,char what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_SetValueC9F1A165(IntPtr instance, int where,string what);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_SetValue6A685A10(IntPtr instance, int where,IntPtr what);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_SplitE8219145(IntPtr instance, int where);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_SubString5107F6FE(IntPtr instance, int FromIndex,int ToIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_Token800FADE1(IntPtr instance, string separators,int whichone);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_TruncE8219145(IntPtr instance, int ahowmany);
		[DllImport("NaroOccCore.dll")]
		private static extern void TCollection_HAsciiString_UpperCase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern char TCollection_HAsciiString_ValueE8219145(IntPtr instance, int where);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HAsciiString_IsSameStateB439B3D5(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HAsciiString_IsEmpty(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HAsciiString_IntegerValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HAsciiString_IsIntegerValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HAsciiString_IsRealValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TCollection_HAsciiString_IsAscii(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HAsciiString_Length(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double TCollection_HAsciiString_RealValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string TCollection_HAsciiString_ToCString(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TCollection_HAsciiString_UsefullLength(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_String(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TCollection_HAsciiString_ShallowCopy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TCollectionHAsciiString(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TCollectionHAsciiString_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TCollectionHAsciiString_Dtor(IntPtr instance);
	}
}
