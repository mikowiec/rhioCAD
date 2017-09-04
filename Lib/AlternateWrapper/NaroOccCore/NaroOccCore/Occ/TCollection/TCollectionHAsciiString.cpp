#include "TCollectionHAsciiString.h"
#include <TCollection_HAsciiString.hxx>

#include <TCollection_AsciiString.hxx>
#include <TCollection_HAsciiString.hxx>

DECL_EXPORT void* TCollection_HAsciiString_Ctor()
{
	return new Handle_TCollection_HAsciiString(new TCollection_HAsciiString());
}
DECL_EXPORT void* TCollection_HAsciiString_Ctor9381D4D(
	char* message)
{
	return new Handle_TCollection_HAsciiString(new TCollection_HAsciiString(			
message));
}
DECL_EXPORT void* TCollection_HAsciiString_CtorBCA09447(
	char aChar)
{
	return new Handle_TCollection_HAsciiString(new TCollection_HAsciiString(			
aChar));
}
DECL_EXPORT void* TCollection_HAsciiString_Ctor71824F83(
	int length,
	char filler)
{
	return new Handle_TCollection_HAsciiString(new TCollection_HAsciiString(			
length,			
filler));
}
DECL_EXPORT void* TCollection_HAsciiString_CtorE8219145(
	int value)
{
	return new Handle_TCollection_HAsciiString(new TCollection_HAsciiString(			
value));
}
DECL_EXPORT void* TCollection_HAsciiString_CtorD82819F3(
	double value)
{
	return new Handle_TCollection_HAsciiString(new TCollection_HAsciiString(			
value));
}
DECL_EXPORT void* TCollection_HAsciiString_Ctor66CFACD0(
	void* aString)
{
		const TCollection_AsciiString &  _aString =*(const TCollection_AsciiString *)aString;
	return new Handle_TCollection_HAsciiString(new TCollection_HAsciiString(			
_aString));
}
DECL_EXPORT void* TCollection_HAsciiString_CtorB439B3D5(
	void* aString)
{
		const Handle_TCollection_HAsciiString&  _aString =*(const Handle_TCollection_HAsciiString *)aString;
	return new Handle_TCollection_HAsciiString(new TCollection_HAsciiString(			
_aString));
}
DECL_EXPORT void* TCollection_HAsciiString_CtorB5FFA54(
	void* aString,
	char replaceNonAscii)
{
		const Handle_TCollection_HExtendedString&  _aString =*(const Handle_TCollection_HExtendedString *)aString;
	return new Handle_TCollection_HAsciiString(new TCollection_HAsciiString(			
_aString,			
replaceNonAscii));
}
DECL_EXPORT void TCollection_HAsciiString_AssignCat9381D4D(
	void* instance,
	char* other)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->AssignCat(			
other);
}
DECL_EXPORT void TCollection_HAsciiString_AssignCatB439B3D5(
	void* instance,
	void* other)
{
		const Handle_TCollection_HAsciiString&  _other =*(const Handle_TCollection_HAsciiString *)other;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->AssignCat(			
_other);
}
DECL_EXPORT void TCollection_HAsciiString_Capitalize(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->Capitalize();
}
DECL_EXPORT void* TCollection_HAsciiString_Cat9381D4D(
	void* instance,
	char* other)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return new Handle_TCollection_HAsciiString( 	result->Cat(			
other));
}
DECL_EXPORT void* TCollection_HAsciiString_CatB439B3D5(
	void* instance,
	void* other)
{
		const Handle_TCollection_HAsciiString&  _other =*(const Handle_TCollection_HAsciiString *)other;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return new Handle_TCollection_HAsciiString( 	result->Cat(			
_other));
}
DECL_EXPORT void TCollection_HAsciiString_Center71824F83(
	void* instance,
	int Width,
	char Filler)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->Center(			
Width,			
Filler);
}
DECL_EXPORT void TCollection_HAsciiString_ChangeAll4A8EEFF6(
	void* instance,
	char aChar,
	char NewChar,
	bool CaseSensitive)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->ChangeAll(			
aChar,			
NewChar,			
CaseSensitive);
}
DECL_EXPORT void TCollection_HAsciiString_Clear(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->Clear();
}
DECL_EXPORT int TCollection_HAsciiString_FirstLocationInSet2FE6ADDB(
	void* instance,
	void* Set,
	int FromIndex,
	int ToIndex)
{
		const Handle_TCollection_HAsciiString&  _Set =*(const Handle_TCollection_HAsciiString *)Set;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->FirstLocationInSet(			
_Set,			
FromIndex,			
ToIndex);
}
DECL_EXPORT int TCollection_HAsciiString_FirstLocationNotInSet2FE6ADDB(
	void* instance,
	void* Set,
	int FromIndex,
	int ToIndex)
{
		const Handle_TCollection_HAsciiString&  _Set =*(const Handle_TCollection_HAsciiString *)Set;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->FirstLocationNotInSet(			
_Set,			
FromIndex,			
ToIndex);
}
DECL_EXPORT void TCollection_HAsciiString_Insert71824F83(
	void* instance,
	int where,
	char what)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->Insert(			
where,			
what);
}
DECL_EXPORT void TCollection_HAsciiString_InsertC9F1A165(
	void* instance,
	int where,
	char* what)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->Insert(			
where,			
what);
}
DECL_EXPORT void TCollection_HAsciiString_Insert6A685A10(
	void* instance,
	int where,
	void* what)
{
		const Handle_TCollection_HAsciiString&  _what =*(const Handle_TCollection_HAsciiString *)what;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->Insert(			
where,			
_what);
}
DECL_EXPORT void TCollection_HAsciiString_InsertAfter6A685A10(
	void* instance,
	int Index,
	void* other)
{
		const Handle_TCollection_HAsciiString&  _other =*(const Handle_TCollection_HAsciiString *)other;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->InsertAfter(			
Index,			
_other);
}
DECL_EXPORT void TCollection_HAsciiString_InsertBefore6A685A10(
	void* instance,
	int Index,
	void* other)
{
		const Handle_TCollection_HAsciiString&  _other =*(const Handle_TCollection_HAsciiString *)other;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->InsertBefore(			
Index,			
_other);
}
DECL_EXPORT bool TCollection_HAsciiString_IsLessB439B3D5(
	void* instance,
	void* other)
{
		const Handle_TCollection_HAsciiString&  _other =*(const Handle_TCollection_HAsciiString *)other;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->IsLess(			
_other);
}
DECL_EXPORT bool TCollection_HAsciiString_IsGreaterB439B3D5(
	void* instance,
	void* other)
{
		const Handle_TCollection_HAsciiString&  _other =*(const Handle_TCollection_HAsciiString *)other;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->IsGreater(			
_other);
}
DECL_EXPORT bool TCollection_HAsciiString_IsDifferentB439B3D5(
	void* instance,
	void* S)
{
		const Handle_TCollection_HAsciiString&  _S =*(const Handle_TCollection_HAsciiString *)S;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->IsDifferent(			
_S);
}
DECL_EXPORT bool TCollection_HAsciiString_IsSameStringB439B3D5(
	void* instance,
	void* S)
{
		const Handle_TCollection_HAsciiString&  _S =*(const Handle_TCollection_HAsciiString *)S;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->IsSameString(			
_S);
}
DECL_EXPORT bool TCollection_HAsciiString_IsSameString34C64CD3(
	void* instance,
	void* S,
	bool CaseSensitive)
{
		const Handle_TCollection_HAsciiString&  _S =*(const Handle_TCollection_HAsciiString *)S;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->IsSameString(			
_S,			
CaseSensitive);
}
DECL_EXPORT void TCollection_HAsciiString_LeftAdjust(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->LeftAdjust();
}
DECL_EXPORT void TCollection_HAsciiString_LeftJustify71824F83(
	void* instance,
	int Width,
	char Filler)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->LeftJustify(			
Width,			
Filler);
}
DECL_EXPORT int TCollection_HAsciiString_Location2FE6ADDB(
	void* instance,
	void* other,
	int FromIndex,
	int ToIndex)
{
		const Handle_TCollection_HAsciiString&  _other =*(const Handle_TCollection_HAsciiString *)other;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->Location(			
_other,			
FromIndex,			
ToIndex);
}
DECL_EXPORT int TCollection_HAsciiString_LocationB9967886(
	void* instance,
	int N,
	char C,
	int FromIndex,
	int ToIndex)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->Location(			
N,			
C,			
FromIndex,			
ToIndex);
}
DECL_EXPORT void TCollection_HAsciiString_LowerCase(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->LowerCase();
}
DECL_EXPORT void TCollection_HAsciiString_PrependB439B3D5(
	void* instance,
	void* other)
{
		const Handle_TCollection_HAsciiString&  _other =*(const Handle_TCollection_HAsciiString *)other;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->Prepend(			
_other);
}
DECL_EXPORT void TCollection_HAsciiString_RemoveAll6D30D0F7(
	void* instance,
	char C,
	bool CaseSensitive)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->RemoveAll(			
C,			
CaseSensitive);
}
DECL_EXPORT void TCollection_HAsciiString_RemoveAllBCA09447(
	void* instance,
	char what)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->RemoveAll(			
what);
}
DECL_EXPORT void TCollection_HAsciiString_Remove5107F6FE(
	void* instance,
	int where,
	int ahowmany)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->Remove(			
where,			
ahowmany);
}
DECL_EXPORT void TCollection_HAsciiString_RightAdjust(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->RightAdjust();
}
DECL_EXPORT void TCollection_HAsciiString_RightJustify71824F83(
	void* instance,
	int Width,
	char Filler)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->RightJustify(			
Width,			
Filler);
}
DECL_EXPORT int TCollection_HAsciiString_Search9381D4D(
	void* instance,
	char* what)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->Search(			
what);
}
DECL_EXPORT int TCollection_HAsciiString_SearchB439B3D5(
	void* instance,
	void* what)
{
		const Handle_TCollection_HAsciiString&  _what =*(const Handle_TCollection_HAsciiString *)what;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->Search(			
_what);
}
DECL_EXPORT int TCollection_HAsciiString_SearchFromEnd9381D4D(
	void* instance,
	char* what)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->SearchFromEnd(			
what);
}
DECL_EXPORT int TCollection_HAsciiString_SearchFromEndB439B3D5(
	void* instance,
	void* what)
{
		const Handle_TCollection_HAsciiString&  _what =*(const Handle_TCollection_HAsciiString *)what;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->SearchFromEnd(			
_what);
}
DECL_EXPORT void TCollection_HAsciiString_SetValue71824F83(
	void* instance,
	int where,
	char what)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->SetValue(			
where,			
what);
}
DECL_EXPORT void TCollection_HAsciiString_SetValueC9F1A165(
	void* instance,
	int where,
	char* what)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->SetValue(			
where,			
what);
}
DECL_EXPORT void TCollection_HAsciiString_SetValue6A685A10(
	void* instance,
	int where,
	void* what)
{
		const Handle_TCollection_HAsciiString&  _what =*(const Handle_TCollection_HAsciiString *)what;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->SetValue(			
where,			
_what);
}
DECL_EXPORT void* TCollection_HAsciiString_SplitE8219145(
	void* instance,
	int where)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return new Handle_TCollection_HAsciiString( 	result->Split(			
where));
}
DECL_EXPORT void* TCollection_HAsciiString_SubString5107F6FE(
	void* instance,
	int FromIndex,
	int ToIndex)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return new Handle_TCollection_HAsciiString( 	result->SubString(			
FromIndex,			
ToIndex));
}
DECL_EXPORT void* TCollection_HAsciiString_Token800FADE1(
	void* instance,
	char* separators,
	int whichone)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return new Handle_TCollection_HAsciiString( 	result->Token(			
separators,			
whichone));
}
DECL_EXPORT void TCollection_HAsciiString_TruncE8219145(
	void* instance,
	int ahowmany)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->Trunc(			
ahowmany);
}
DECL_EXPORT void TCollection_HAsciiString_UpperCase(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
 	result->UpperCase();
}
DECL_EXPORT char TCollection_HAsciiString_ValueE8219145(
	void* instance,
	int where)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->Value(			
where);
}
DECL_EXPORT bool TCollection_HAsciiString_IsSameStateB439B3D5(
	void* instance,
	void* other)
{
		const Handle_TCollection_HAsciiString&  _other =*(const Handle_TCollection_HAsciiString *)other;
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return  	result->IsSameState(			
_other);
}
DECL_EXPORT bool TCollection_HAsciiString_IsEmpty(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return 	result->IsEmpty();
}

DECL_EXPORT int TCollection_HAsciiString_IntegerValue(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return 	result->IntegerValue();
}

DECL_EXPORT bool TCollection_HAsciiString_IsIntegerValue(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return 	result->IsIntegerValue();
}

DECL_EXPORT bool TCollection_HAsciiString_IsRealValue(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return 	result->IsRealValue();
}

DECL_EXPORT bool TCollection_HAsciiString_IsAscii(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return 	result->IsAscii();
}

DECL_EXPORT int TCollection_HAsciiString_Length(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return 	result->Length();
}

DECL_EXPORT double TCollection_HAsciiString_RealValue(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return 	result->RealValue();
}

DECL_EXPORT Standard_CString TCollection_HAsciiString_ToCString(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return 	result->ToCString();
}

DECL_EXPORT int TCollection_HAsciiString_UsefullLength(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return 	result->UsefullLength();
}

DECL_EXPORT void* TCollection_HAsciiString_String(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return 	new TCollection_AsciiString(	result->String());
}

DECL_EXPORT void* TCollection_HAsciiString_ShallowCopy(void* instance)
{
	TCollection_HAsciiString* result = (TCollection_HAsciiString*)(((Handle_TCollection_HAsciiString*)instance)->Access());
	return 	new Handle_TCollection_HAsciiString(	result->ShallowCopy());
}

DECL_EXPORT void TCollectionHAsciiString_Dtor(void* instance)
{
	delete (Handle_TCollection_HAsciiString*)instance;
}
