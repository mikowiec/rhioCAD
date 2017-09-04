#include "TCollectionHExtendedString.h"
#include <TCollection_HExtendedString.hxx>

#include <TCollection_ExtendedString.hxx>
#include <TCollection_HExtendedString.hxx>

DECL_EXPORT void* TCollection_HExtendedString_Ctor()
{
	return new Handle_TCollection_HExtendedString(new TCollection_HExtendedString());
}
DECL_EXPORT void* TCollection_HExtendedString_Ctor9381D4D(
	char* message)
{
	return new Handle_TCollection_HExtendedString(new TCollection_HExtendedString(			
message));
}
DECL_EXPORT void* TCollection_HExtendedString_CtorBCA09447(
	char aChar)
{
	return new Handle_TCollection_HExtendedString(new TCollection_HExtendedString(			
aChar));
}
DECL_EXPORT void* TCollection_HExtendedString_Ctor71824F83(
	int length,
	char filler)
{
	return new Handle_TCollection_HExtendedString(new TCollection_HExtendedString(			
length,			
filler));
}
DECL_EXPORT void* TCollection_HExtendedString_Ctor6EE6EE89(
	void* aString)
{
		const TCollection_ExtendedString &  _aString =*(const TCollection_ExtendedString *)aString;
	return new Handle_TCollection_HExtendedString(new TCollection_HExtendedString(			
_aString));
}
DECL_EXPORT void* TCollection_HExtendedString_CtorB439B3D5(
	void* aString)
{
		const Handle_TCollection_HAsciiString&  _aString =*(const Handle_TCollection_HAsciiString *)aString;
	return new Handle_TCollection_HExtendedString(new TCollection_HExtendedString(			
_aString));
}
DECL_EXPORT void* TCollection_HExtendedString_Ctor4C6BF532(
	void* aString)
{
		const Handle_TCollection_HExtendedString&  _aString =*(const Handle_TCollection_HExtendedString *)aString;
	return new Handle_TCollection_HExtendedString(new TCollection_HExtendedString(			
_aString));
}
DECL_EXPORT void TCollection_HExtendedString_AssignCat4C6BF532(
	void* instance,
	void* other)
{
		const Handle_TCollection_HExtendedString&  _other =*(const Handle_TCollection_HExtendedString *)other;
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
 	result->AssignCat(			
_other);
}
DECL_EXPORT void* TCollection_HExtendedString_Cat4C6BF532(
	void* instance,
	void* other)
{
		const Handle_TCollection_HExtendedString&  _other =*(const Handle_TCollection_HExtendedString *)other;
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return new Handle_TCollection_HExtendedString( 	result->Cat(			
_other));
}
DECL_EXPORT void TCollection_HExtendedString_ChangeAllF70B733C(
	void* instance,
	char aChar,
	char NewChar)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
 	result->ChangeAll(			
aChar,			
NewChar);
}
DECL_EXPORT void TCollection_HExtendedString_Clear(void* instance)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
 	result->Clear();
}
DECL_EXPORT void TCollection_HExtendedString_Insert71824F83(
	void* instance,
	int where,
	char what)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
 	result->Insert(			
where,			
what);
}
DECL_EXPORT void TCollection_HExtendedString_Insert2BBF075E(
	void* instance,
	int where,
	void* what)
{
		const Handle_TCollection_HExtendedString&  _what =*(const Handle_TCollection_HExtendedString *)what;
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
 	result->Insert(			
where,			
_what);
}
DECL_EXPORT bool TCollection_HExtendedString_IsLess4C6BF532(
	void* instance,
	void* other)
{
		const Handle_TCollection_HExtendedString&  _other =*(const Handle_TCollection_HExtendedString *)other;
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return  	result->IsLess(			
_other);
}
DECL_EXPORT bool TCollection_HExtendedString_IsGreater4C6BF532(
	void* instance,
	void* other)
{
		const Handle_TCollection_HExtendedString&  _other =*(const Handle_TCollection_HExtendedString *)other;
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return  	result->IsGreater(			
_other);
}
DECL_EXPORT void TCollection_HExtendedString_Remove5107F6FE(
	void* instance,
	int where,
	int ahowmany)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
 	result->Remove(			
where,			
ahowmany);
}
DECL_EXPORT void TCollection_HExtendedString_RemoveAllBCA09447(
	void* instance,
	char what)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
 	result->RemoveAll(			
what);
}
DECL_EXPORT void TCollection_HExtendedString_SetValue71824F83(
	void* instance,
	int where,
	char what)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
 	result->SetValue(			
where,			
what);
}
DECL_EXPORT void TCollection_HExtendedString_SetValue2BBF075E(
	void* instance,
	int where,
	void* what)
{
		const Handle_TCollection_HExtendedString&  _what =*(const Handle_TCollection_HExtendedString *)what;
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
 	result->SetValue(			
where,			
_what);
}
DECL_EXPORT void* TCollection_HExtendedString_SplitE8219145(
	void* instance,
	int where)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return new Handle_TCollection_HExtendedString( 	result->Split(			
where));
}
DECL_EXPORT int TCollection_HExtendedString_Search4C6BF532(
	void* instance,
	void* what)
{
		const Handle_TCollection_HExtendedString&  _what =*(const Handle_TCollection_HExtendedString *)what;
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return  	result->Search(			
_what);
}
DECL_EXPORT int TCollection_HExtendedString_SearchFromEnd4C6BF532(
	void* instance,
	void* what)
{
		const Handle_TCollection_HExtendedString&  _what =*(const Handle_TCollection_HExtendedString *)what;
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return  	result->SearchFromEnd(			
_what);
}
DECL_EXPORT void TCollection_HExtendedString_TruncE8219145(
	void* instance,
	int ahowmany)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
 	result->Trunc(			
ahowmany);
}
DECL_EXPORT char TCollection_HExtendedString_ValueE8219145(
	void* instance,
	int where)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return  	result->Value(			
where);
}
DECL_EXPORT bool TCollection_HExtendedString_IsSameState4C6BF532(
	void* instance,
	void* other)
{
		const Handle_TCollection_HExtendedString&  _other =*(const Handle_TCollection_HExtendedString *)other;
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return  	result->IsSameState(			
_other);
}
DECL_EXPORT bool TCollection_HExtendedString_IsEmpty(void* instance)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return 	result->IsEmpty();
}

DECL_EXPORT bool TCollection_HExtendedString_IsAscii(void* instance)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return 	result->IsAscii();
}

DECL_EXPORT int TCollection_HExtendedString_Length(void* instance)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return 	result->Length();
}

DECL_EXPORT void* TCollection_HExtendedString_String(void* instance)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return 	new TCollection_ExtendedString(	result->String());
}

DECL_EXPORT void* TCollection_HExtendedString_ShallowCopy(void* instance)
{
	TCollection_HExtendedString* result = (TCollection_HExtendedString*)(((Handle_TCollection_HExtendedString*)instance)->Access());
	return 	new Handle_TCollection_HExtendedString(	result->ShallowCopy());
}

DECL_EXPORT void TCollectionHExtendedString_Dtor(void* instance)
{
	delete (Handle_TCollection_HExtendedString*)instance;
}
