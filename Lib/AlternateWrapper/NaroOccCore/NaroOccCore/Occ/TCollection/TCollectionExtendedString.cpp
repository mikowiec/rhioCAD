#include "TCollectionExtendedString.h"
#include <TCollection_ExtendedString.hxx>

#include <TCollection_ExtendedString.hxx>

DECL_EXPORT void* TCollection_ExtendedString_Ctor()
{
	return new TCollection_ExtendedString();
}
DECL_EXPORT void* TCollection_ExtendedString_CtorDE32234A(
	char* astring,
	bool isMultiByte)
{
	return new TCollection_ExtendedString(			
astring,			
isMultiByte);
}
DECL_EXPORT void* TCollection_ExtendedString_Ctor9381D4D(
	char* astring)
{
	return new TCollection_ExtendedString(			
astring);
}
DECL_EXPORT void* TCollection_ExtendedString_CtorBCA09447(
	char aChar)
{
	return new TCollection_ExtendedString(			
aChar);
}
DECL_EXPORT void* TCollection_ExtendedString_Ctor71824F83(
	int length,
	char filler)
{
	return new TCollection_ExtendedString(			
length,			
filler);
}
DECL_EXPORT void* TCollection_ExtendedString_CtorE8219145(
	int value)
{
	return new TCollection_ExtendedString(			
value);
}
DECL_EXPORT void* TCollection_ExtendedString_CtorD82819F3(
	double value)
{
	return new TCollection_ExtendedString(			
value);
}
DECL_EXPORT void* TCollection_ExtendedString_Ctor6EE6EE89(
	void* astring)
{
		const TCollection_ExtendedString &  _astring =*(const TCollection_ExtendedString *)astring;
	return new TCollection_ExtendedString(			
_astring);
}
DECL_EXPORT void* TCollection_ExtendedString_Ctor66CFACD0(
	void* astring)
{
		const TCollection_AsciiString &  _astring =*(const TCollection_AsciiString *)astring;
	return new TCollection_ExtendedString(			
_astring);
}
DECL_EXPORT void TCollection_ExtendedString_AssignCat6EE6EE89(
	void* instance,
	void* other)
{
		const TCollection_ExtendedString &  _other =*(const TCollection_ExtendedString *)other;
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
 	result->AssignCat(			
_other);
}
DECL_EXPORT void* TCollection_ExtendedString_Cat6EE6EE89(
	void* instance,
	void* other)
{
		const TCollection_ExtendedString &  _other =*(const TCollection_ExtendedString *)other;
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return new TCollection_ExtendedString( 	result->Cat(			
_other));
}
DECL_EXPORT void TCollection_ExtendedString_ChangeAllF70B733C(
	void* instance,
	char aChar,
	char NewChar)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
 	result->ChangeAll(			
aChar,			
NewChar);
}
DECL_EXPORT void TCollection_ExtendedString_Clear(void* instance)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
 	result->Clear();
}
DECL_EXPORT void TCollection_ExtendedString_Copy6EE6EE89(
	void* instance,
	void* fromwhere)
{
		const TCollection_ExtendedString &  _fromwhere =*(const TCollection_ExtendedString *)fromwhere;
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
 	result->Copy(			
_fromwhere);
}
DECL_EXPORT void TCollection_ExtendedString_Insert71824F83(
	void* instance,
	int where,
	char what)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
 	result->Insert(			
where,			
what);
}
DECL_EXPORT void TCollection_ExtendedString_Insert682EC762(
	void* instance,
	int where,
	void* what)
{
		const TCollection_ExtendedString &  _what =*(const TCollection_ExtendedString *)what;
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
 	result->Insert(			
where,			
_what);
}
DECL_EXPORT bool TCollection_ExtendedString_IsEqual9381D4D(
	void* instance,
	char* other)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return  	result->IsEqual(			
other);
}
DECL_EXPORT bool TCollection_ExtendedString_IsEqual6EE6EE89(
	void* instance,
	void* other)
{
		const TCollection_ExtendedString &  _other =*(const TCollection_ExtendedString *)other;
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return  	result->IsEqual(			
_other);
}
DECL_EXPORT bool TCollection_ExtendedString_IsDifferent9381D4D(
	void* instance,
	char* other)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return  	result->IsDifferent(			
other);
}
DECL_EXPORT bool TCollection_ExtendedString_IsDifferent6EE6EE89(
	void* instance,
	void* other)
{
		const TCollection_ExtendedString &  _other =*(const TCollection_ExtendedString *)other;
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return  	result->IsDifferent(			
_other);
}
DECL_EXPORT bool TCollection_ExtendedString_IsLess9381D4D(
	void* instance,
	char* other)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return  	result->IsLess(			
other);
}
DECL_EXPORT bool TCollection_ExtendedString_IsLess6EE6EE89(
	void* instance,
	void* other)
{
		const TCollection_ExtendedString &  _other =*(const TCollection_ExtendedString *)other;
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return  	result->IsLess(			
_other);
}
DECL_EXPORT bool TCollection_ExtendedString_IsGreater9381D4D(
	void* instance,
	char* other)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return  	result->IsGreater(			
other);
}
DECL_EXPORT bool TCollection_ExtendedString_IsGreater6EE6EE89(
	void* instance,
	void* other)
{
		const TCollection_ExtendedString &  _other =*(const TCollection_ExtendedString *)other;
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return  	result->IsGreater(			
_other);
}
DECL_EXPORT void TCollection_ExtendedString_RemoveAllBCA09447(
	void* instance,
	char what)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
 	result->RemoveAll(			
what);
}
DECL_EXPORT void TCollection_ExtendedString_Remove5107F6FE(
	void* instance,
	int where,
	int ahowmany)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
 	result->Remove(			
where,			
ahowmany);
}
DECL_EXPORT int TCollection_ExtendedString_Search6EE6EE89(
	void* instance,
	void* what)
{
		const TCollection_ExtendedString &  _what =*(const TCollection_ExtendedString *)what;
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return  	result->Search(			
_what);
}
DECL_EXPORT int TCollection_ExtendedString_SearchFromEnd6EE6EE89(
	void* instance,
	void* what)
{
		const TCollection_ExtendedString &  _what =*(const TCollection_ExtendedString *)what;
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return  	result->SearchFromEnd(			
_what);
}
DECL_EXPORT void TCollection_ExtendedString_SetValue71824F83(
	void* instance,
	int where,
	char what)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
 	result->SetValue(			
where,			
what);
}
DECL_EXPORT void TCollection_ExtendedString_SetValue682EC762(
	void* instance,
	int where,
	void* what)
{
		const TCollection_ExtendedString &  _what =*(const TCollection_ExtendedString *)what;
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
 	result->SetValue(			
where,			
_what);
}
DECL_EXPORT void* TCollection_ExtendedString_SplitE8219145(
	void* instance,
	int where)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return new TCollection_ExtendedString( 	result->Split(			
where));
}
DECL_EXPORT void TCollection_ExtendedString_TruncE8219145(
	void* instance,
	int ahowmany)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
 	result->Trunc(			
ahowmany);
}
DECL_EXPORT char TCollection_ExtendedString_ValueE8219145(
	void* instance,
	int where)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return  	result->Value(			
where);
}
DECL_EXPORT int TCollection_ExtendedString_HashCode6F67650A(
	void* astring,
	int Upper)
{
		const TCollection_ExtendedString &  _astring =*(const TCollection_ExtendedString *)astring;
	return  TCollection_ExtendedString::HashCode(			
_astring,			
Upper);
}
DECL_EXPORT bool TCollection_ExtendedString_IsEqual39BDF64A(
	void* string1,
	void* string2)
{
		const TCollection_ExtendedString &  _string1 =*(const TCollection_ExtendedString *)string1;
		const TCollection_ExtendedString &  _string2 =*(const TCollection_ExtendedString *)string2;
	return  TCollection_ExtendedString::IsEqual(			
_string1,			
_string2);
}
DECL_EXPORT bool TCollection_ExtendedString_IsAscii(void* instance)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return 	result->IsAscii();
}

DECL_EXPORT int TCollection_ExtendedString_Length(void* instance)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return 	result->Length();
}

DECL_EXPORT int TCollection_ExtendedString_LengthOfCString(void* instance)
{
	TCollection_ExtendedString* result = (TCollection_ExtendedString*)instance;
	return 	result->LengthOfCString();
}

DECL_EXPORT void TCollectionExtendedString_Dtor(void* instance)
{
	delete (TCollection_ExtendedString*)instance;
}
