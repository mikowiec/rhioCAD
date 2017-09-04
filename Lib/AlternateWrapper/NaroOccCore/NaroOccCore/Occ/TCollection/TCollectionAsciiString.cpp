#include "TCollectionAsciiString.h"
#include <TCollection_AsciiString.hxx>

#include <TCollection_AsciiString.hxx>

DECL_EXPORT void* TCollection_AsciiString_Ctor()
{
	return new TCollection_AsciiString();
}
DECL_EXPORT void* TCollection_AsciiString_Ctor9381D4D(
	char* message)
{
	return new TCollection_AsciiString(			
message);
}
DECL_EXPORT void* TCollection_AsciiString_Ctor800FADE1(
	char* message,
	int aLen)
{
	return new TCollection_AsciiString(			
message,			
aLen);
}
DECL_EXPORT void* TCollection_AsciiString_CtorBCA09447(
	char aChar)
{
	return new TCollection_AsciiString(			
aChar);
}
DECL_EXPORT void* TCollection_AsciiString_Ctor71824F83(
	int length,
	char filler)
{
	return new TCollection_AsciiString(			
length,			
filler);
}
DECL_EXPORT void* TCollection_AsciiString_CtorE8219145(
	int value)
{
	return new TCollection_AsciiString(			
value);
}
DECL_EXPORT void* TCollection_AsciiString_CtorD82819F3(
	double value)
{
	return new TCollection_AsciiString(			
value);
}
DECL_EXPORT void* TCollection_AsciiString_Ctor66CFACD0(
	void* astring)
{
		const TCollection_AsciiString &  _astring =*(const TCollection_AsciiString *)astring;
	return new TCollection_AsciiString(			
_astring);
}
DECL_EXPORT void* TCollection_AsciiString_CtorD142C0D4(
	void* astring,
	char message)
{
		const TCollection_AsciiString &  _astring =*(const TCollection_AsciiString *)astring;
	return new TCollection_AsciiString(			
_astring,			
message);
}
DECL_EXPORT void* TCollection_AsciiString_Ctor54DBAE97(
	void* astring,
	char* message)
{
		const TCollection_AsciiString &  _astring =*(const TCollection_AsciiString *)astring;
	return new TCollection_AsciiString(			
_astring,			
message);
}
DECL_EXPORT void* TCollection_AsciiString_CtorB82186D3(
	void* astring,
	void* message)
{
		const TCollection_AsciiString &  _astring =*(const TCollection_AsciiString *)astring;
		const TCollection_AsciiString &  _message =*(const TCollection_AsciiString *)message;
	return new TCollection_AsciiString(			
_astring,			
_message);
}
DECL_EXPORT void* TCollection_AsciiString_Ctor77E26705(
	void* astring,
	char replaceNonAscii)
{
		const TCollection_ExtendedString &  _astring =*(const TCollection_ExtendedString *)astring;
	return new TCollection_AsciiString(			
_astring,			
replaceNonAscii);
}
DECL_EXPORT void TCollection_AsciiString_AssignCatBCA09447(
	void* instance,
	char other)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->AssignCat(			
other);
}
DECL_EXPORT void TCollection_AsciiString_AssignCatE8219145(
	void* instance,
	int other)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->AssignCat(			
other);
}
DECL_EXPORT void TCollection_AsciiString_AssignCatD82819F3(
	void* instance,
	double other)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->AssignCat(			
other);
}
DECL_EXPORT void TCollection_AsciiString_AssignCat9381D4D(
	void* instance,
	char* other)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->AssignCat(			
other);
}
DECL_EXPORT void TCollection_AsciiString_AssignCat66CFACD0(
	void* instance,
	void* other)
{
		const TCollection_AsciiString &  _other =*(const TCollection_AsciiString *)other;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->AssignCat(			
_other);
}
DECL_EXPORT void TCollection_AsciiString_Capitalize(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->Capitalize();
}
DECL_EXPORT void* TCollection_AsciiString_CatBCA09447(
	void* instance,
	char other)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return new TCollection_AsciiString( 	result->Cat(			
other));
}
DECL_EXPORT void* TCollection_AsciiString_CatE8219145(
	void* instance,
	int other)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return new TCollection_AsciiString( 	result->Cat(			
other));
}
DECL_EXPORT void* TCollection_AsciiString_CatD82819F3(
	void* instance,
	double other)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return new TCollection_AsciiString( 	result->Cat(			
other));
}
DECL_EXPORT void* TCollection_AsciiString_Cat9381D4D(
	void* instance,
	char* other)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return new TCollection_AsciiString( 	result->Cat(			
other));
}
DECL_EXPORT void* TCollection_AsciiString_Cat66CFACD0(
	void* instance,
	void* other)
{
		const TCollection_AsciiString &  _other =*(const TCollection_AsciiString *)other;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return new TCollection_AsciiString( 	result->Cat(			
_other));
}
DECL_EXPORT void TCollection_AsciiString_Center71824F83(
	void* instance,
	int Width,
	char Filler)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->Center(			
Width,			
Filler);
}
DECL_EXPORT void TCollection_AsciiString_ChangeAll4A8EEFF6(
	void* instance,
	char aChar,
	char NewChar,
	bool CaseSensitive)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->ChangeAll(			
aChar,			
NewChar,			
CaseSensitive);
}
DECL_EXPORT void TCollection_AsciiString_Clear(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->Clear();
}
DECL_EXPORT void TCollection_AsciiString_Copy9381D4D(
	void* instance,
	char* fromwhere)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->Copy(			
fromwhere);
}
DECL_EXPORT void TCollection_AsciiString_Copy66CFACD0(
	void* instance,
	void* fromwhere)
{
		const TCollection_AsciiString &  _fromwhere =*(const TCollection_AsciiString *)fromwhere;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->Copy(			
_fromwhere);
}
DECL_EXPORT int TCollection_AsciiString_FirstLocationInSet10E3C1BB(
	void* instance,
	void* Set,
	int FromIndex,
	int ToIndex)
{
		const TCollection_AsciiString &  _Set =*(const TCollection_AsciiString *)Set;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->FirstLocationInSet(			
_Set,			
FromIndex,			
ToIndex);
}
DECL_EXPORT int TCollection_AsciiString_FirstLocationNotInSet10E3C1BB(
	void* instance,
	void* Set,
	int FromIndex,
	int ToIndex)
{
		const TCollection_AsciiString &  _Set =*(const TCollection_AsciiString *)Set;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->FirstLocationNotInSet(			
_Set,			
FromIndex,			
ToIndex);
}
DECL_EXPORT void TCollection_AsciiString_Insert71824F83(
	void* instance,
	int where,
	char what)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->Insert(			
where,			
what);
}
DECL_EXPORT void TCollection_AsciiString_InsertC9F1A165(
	void* instance,
	int where,
	char* what)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->Insert(			
where,			
what);
}
DECL_EXPORT void TCollection_AsciiString_InsertFCE887E8(
	void* instance,
	int where,
	void* what)
{
		const TCollection_AsciiString &  _what =*(const TCollection_AsciiString *)what;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->Insert(			
where,			
_what);
}
DECL_EXPORT void TCollection_AsciiString_InsertAfterFCE887E8(
	void* instance,
	int Index,
	void* other)
{
		const TCollection_AsciiString &  _other =*(const TCollection_AsciiString *)other;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->InsertAfter(			
Index,			
_other);
}
DECL_EXPORT void TCollection_AsciiString_InsertBeforeFCE887E8(
	void* instance,
	int Index,
	void* other)
{
		const TCollection_AsciiString &  _other =*(const TCollection_AsciiString *)other;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->InsertBefore(			
Index,			
_other);
}
DECL_EXPORT bool TCollection_AsciiString_IsEqual9381D4D(
	void* instance,
	char* other)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->IsEqual(			
other);
}
DECL_EXPORT bool TCollection_AsciiString_IsEqual66CFACD0(
	void* instance,
	void* other)
{
		const TCollection_AsciiString &  _other =*(const TCollection_AsciiString *)other;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->IsEqual(			
_other);
}
DECL_EXPORT bool TCollection_AsciiString_IsDifferent9381D4D(
	void* instance,
	char* other)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->IsDifferent(			
other);
}
DECL_EXPORT bool TCollection_AsciiString_IsDifferent66CFACD0(
	void* instance,
	void* other)
{
		const TCollection_AsciiString &  _other =*(const TCollection_AsciiString *)other;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->IsDifferent(			
_other);
}
DECL_EXPORT bool TCollection_AsciiString_IsLess9381D4D(
	void* instance,
	char* other)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->IsLess(			
other);
}
DECL_EXPORT bool TCollection_AsciiString_IsLess66CFACD0(
	void* instance,
	void* other)
{
		const TCollection_AsciiString &  _other =*(const TCollection_AsciiString *)other;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->IsLess(			
_other);
}
DECL_EXPORT bool TCollection_AsciiString_IsGreater9381D4D(
	void* instance,
	char* other)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->IsGreater(			
other);
}
DECL_EXPORT bool TCollection_AsciiString_IsGreater66CFACD0(
	void* instance,
	void* other)
{
		const TCollection_AsciiString &  _other =*(const TCollection_AsciiString *)other;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->IsGreater(			
_other);
}
DECL_EXPORT void TCollection_AsciiString_LeftAdjust(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->LeftAdjust();
}
DECL_EXPORT void TCollection_AsciiString_LeftJustify71824F83(
	void* instance,
	int Width,
	char Filler)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->LeftJustify(			
Width,			
Filler);
}
DECL_EXPORT int TCollection_AsciiString_Location10E3C1BB(
	void* instance,
	void* other,
	int FromIndex,
	int ToIndex)
{
		const TCollection_AsciiString &  _other =*(const TCollection_AsciiString *)other;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->Location(			
_other,			
FromIndex,			
ToIndex);
}
DECL_EXPORT int TCollection_AsciiString_LocationB9967886(
	void* instance,
	int N,
	char C,
	int FromIndex,
	int ToIndex)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->Location(			
N,			
C,			
FromIndex,			
ToIndex);
}
DECL_EXPORT void TCollection_AsciiString_LowerCase(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->LowerCase();
}
DECL_EXPORT void TCollection_AsciiString_Prepend66CFACD0(
	void* instance,
	void* other)
{
		const TCollection_AsciiString &  _other =*(const TCollection_AsciiString *)other;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->Prepend(			
_other);
}
DECL_EXPORT void TCollection_AsciiString_RemoveAll6D30D0F7(
	void* instance,
	char C,
	bool CaseSensitive)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->RemoveAll(			
C,			
CaseSensitive);
}
DECL_EXPORT void TCollection_AsciiString_RemoveAllBCA09447(
	void* instance,
	char what)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->RemoveAll(			
what);
}
DECL_EXPORT void TCollection_AsciiString_Remove5107F6FE(
	void* instance,
	int where,
	int ahowmany)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->Remove(			
where,			
ahowmany);
}
DECL_EXPORT void TCollection_AsciiString_RightAdjust(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->RightAdjust();
}
DECL_EXPORT void TCollection_AsciiString_RightJustify71824F83(
	void* instance,
	int Width,
	char Filler)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->RightJustify(			
Width,			
Filler);
}
DECL_EXPORT int TCollection_AsciiString_Search9381D4D(
	void* instance,
	char* what)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->Search(			
what);
}
DECL_EXPORT int TCollection_AsciiString_Search66CFACD0(
	void* instance,
	void* what)
{
		const TCollection_AsciiString &  _what =*(const TCollection_AsciiString *)what;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->Search(			
_what);
}
DECL_EXPORT int TCollection_AsciiString_SearchFromEnd9381D4D(
	void* instance,
	char* what)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->SearchFromEnd(			
what);
}
DECL_EXPORT int TCollection_AsciiString_SearchFromEnd66CFACD0(
	void* instance,
	void* what)
{
		const TCollection_AsciiString &  _what =*(const TCollection_AsciiString *)what;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->SearchFromEnd(			
_what);
}
DECL_EXPORT void TCollection_AsciiString_SetValue71824F83(
	void* instance,
	int where,
	char what)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->SetValue(			
where,			
what);
}
DECL_EXPORT void TCollection_AsciiString_SetValueC9F1A165(
	void* instance,
	int where,
	char* what)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->SetValue(			
where,			
what);
}
DECL_EXPORT void TCollection_AsciiString_SetValueFCE887E8(
	void* instance,
	int where,
	void* what)
{
		const TCollection_AsciiString &  _what =*(const TCollection_AsciiString *)what;
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->SetValue(			
where,			
_what);
}
DECL_EXPORT void* TCollection_AsciiString_SplitE8219145(
	void* instance,
	int where)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return new TCollection_AsciiString( 	result->Split(			
where));
}
DECL_EXPORT void* TCollection_AsciiString_SubString5107F6FE(
	void* instance,
	int FromIndex,
	int ToIndex)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return new TCollection_AsciiString( 	result->SubString(			
FromIndex,			
ToIndex));
}
DECL_EXPORT void* TCollection_AsciiString_Token800FADE1(
	void* instance,
	char* separators,
	int whichone)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return new TCollection_AsciiString( 	result->Token(			
separators,			
whichone));
}
DECL_EXPORT void TCollection_AsciiString_TruncE8219145(
	void* instance,
	int ahowmany)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->Trunc(			
ahowmany);
}
DECL_EXPORT void TCollection_AsciiString_UpperCase(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
 	result->UpperCase();
}
DECL_EXPORT char TCollection_AsciiString_ValueE8219145(
	void* instance,
	int where)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return  	result->Value(			
where);
}
DECL_EXPORT int TCollection_AsciiString_HashCodeCAFD1949(
	void* astring,
	int Upper)
{
		const TCollection_AsciiString &  _astring =*(const TCollection_AsciiString *)astring;
	return  TCollection_AsciiString::HashCode(			
_astring,			
Upper);
}
DECL_EXPORT bool TCollection_AsciiString_IsEqualB82186D3(
	void* string1,
	void* string2)
{
		const TCollection_AsciiString &  _string1 =*(const TCollection_AsciiString *)string1;
		const TCollection_AsciiString &  _string2 =*(const TCollection_AsciiString *)string2;
	return  TCollection_AsciiString::IsEqual(			
_string1,			
_string2);
}
DECL_EXPORT bool TCollection_AsciiString_IsEqual54DBAE97(
	void* string1,
	char* string2)
{
		const TCollection_AsciiString &  _string1 =*(const TCollection_AsciiString *)string1;
	return  TCollection_AsciiString::IsEqual(			
_string1,			
string2);
}
DECL_EXPORT int TCollection_AsciiString_HASHCODECAFD1949(
	void* astring,
	int Upper)
{
		const TCollection_AsciiString &  _astring =*(const TCollection_AsciiString *)astring;
	return  TCollection_AsciiString::HASHCODE(			
_astring,			
Upper);
}
DECL_EXPORT bool TCollection_AsciiString_ISSIMILARB82186D3(
	void* string1,
	void* string2)
{
		const TCollection_AsciiString &  _string1 =*(const TCollection_AsciiString *)string1;
		const TCollection_AsciiString &  _string2 =*(const TCollection_AsciiString *)string2;
	return  TCollection_AsciiString::ISSIMILAR(			
_string1,			
_string2);
}
DECL_EXPORT bool TCollection_AsciiString_IsEmpty(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return 	result->IsEmpty();
}

DECL_EXPORT int TCollection_AsciiString_IntegerValue(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return 	result->IntegerValue();
}

DECL_EXPORT bool TCollection_AsciiString_IsIntegerValue(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return 	result->IsIntegerValue();
}

DECL_EXPORT bool TCollection_AsciiString_IsRealValue(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return 	result->IsRealValue();
}

DECL_EXPORT bool TCollection_AsciiString_IsAscii(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return 	result->IsAscii();
}

DECL_EXPORT int TCollection_AsciiString_Length(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return 	result->Length();
}

DECL_EXPORT double TCollection_AsciiString_RealValue(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return 	result->RealValue();
}

DECL_EXPORT Standard_CString TCollection_AsciiString_ToCString(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return 	result->ToCString();
}

DECL_EXPORT int TCollection_AsciiString_UsefullLength(void* instance)
{
	TCollection_AsciiString* result = (TCollection_AsciiString*)instance;
	return 	result->UsefullLength();
}

DECL_EXPORT void TCollectionAsciiString_Dtor(void* instance)
{
	delete (TCollection_AsciiString*)instance;
}
