#ifndef TCollection_ExtendedString_H
#define TCollection_ExtendedString_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TCollection_ExtendedString_Ctor();
extern "C" DECL_EXPORT void* TCollection_ExtendedString_CtorDE32234A(
	char* astring,
	bool isMultiByte);
extern "C" DECL_EXPORT void* TCollection_ExtendedString_Ctor9381D4D(
	char* astring);
extern "C" DECL_EXPORT void* TCollection_ExtendedString_CtorBCA09447(
	char aChar);
extern "C" DECL_EXPORT void* TCollection_ExtendedString_Ctor71824F83(
	int length,
	char filler);
extern "C" DECL_EXPORT void* TCollection_ExtendedString_CtorE8219145(
	int value);
extern "C" DECL_EXPORT void* TCollection_ExtendedString_CtorD82819F3(
	double value);
extern "C" DECL_EXPORT void* TCollection_ExtendedString_Ctor6EE6EE89(
	void* astring);
extern "C" DECL_EXPORT void* TCollection_ExtendedString_Ctor66CFACD0(
	void* astring);
extern "C" DECL_EXPORT void TCollection_ExtendedString_AssignCat6EE6EE89(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void* TCollection_ExtendedString_Cat6EE6EE89(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void TCollection_ExtendedString_ChangeAllF70B733C(
	void* instance,
	char aChar,
	char NewChar);
extern "C" DECL_EXPORT void TCollection_ExtendedString_Clear(void* instance);
extern "C" DECL_EXPORT void TCollection_ExtendedString_Copy6EE6EE89(
	void* instance,
	void* fromwhere);
extern "C" DECL_EXPORT void TCollection_ExtendedString_Insert71824F83(
	void* instance,
	int where,
	char what);
extern "C" DECL_EXPORT void TCollection_ExtendedString_Insert682EC762(
	void* instance,
	int where,
	void* what);
extern "C" DECL_EXPORT bool TCollection_ExtendedString_IsEqual9381D4D(
	void* instance,
	char* other);
extern "C" DECL_EXPORT bool TCollection_ExtendedString_IsEqual6EE6EE89(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TCollection_ExtendedString_IsDifferent9381D4D(
	void* instance,
	char* other);
extern "C" DECL_EXPORT bool TCollection_ExtendedString_IsDifferent6EE6EE89(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TCollection_ExtendedString_IsLess9381D4D(
	void* instance,
	char* other);
extern "C" DECL_EXPORT bool TCollection_ExtendedString_IsLess6EE6EE89(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TCollection_ExtendedString_IsGreater9381D4D(
	void* instance,
	char* other);
extern "C" DECL_EXPORT bool TCollection_ExtendedString_IsGreater6EE6EE89(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void TCollection_ExtendedString_RemoveAllBCA09447(
	void* instance,
	char what);
extern "C" DECL_EXPORT void TCollection_ExtendedString_Remove5107F6FE(
	void* instance,
	int where,
	int ahowmany);
extern "C" DECL_EXPORT int TCollection_ExtendedString_Search6EE6EE89(
	void* instance,
	void* what);
extern "C" DECL_EXPORT int TCollection_ExtendedString_SearchFromEnd6EE6EE89(
	void* instance,
	void* what);
extern "C" DECL_EXPORT void TCollection_ExtendedString_SetValue71824F83(
	void* instance,
	int where,
	char what);
extern "C" DECL_EXPORT void TCollection_ExtendedString_SetValue682EC762(
	void* instance,
	int where,
	void* what);
extern "C" DECL_EXPORT void* TCollection_ExtendedString_SplitE8219145(
	void* instance,
	int where);
extern "C" DECL_EXPORT void TCollection_ExtendedString_TruncE8219145(
	void* instance,
	int ahowmany);
extern "C" DECL_EXPORT char TCollection_ExtendedString_ValueE8219145(
	void* instance,
	int where);
extern "C" DECL_EXPORT int TCollection_ExtendedString_HashCode6F67650A(
	void* astring,
	int Upper);
extern "C" DECL_EXPORT bool TCollection_ExtendedString_IsEqual39BDF64A(
	void* string1,
	void* string2);
extern "C" DECL_EXPORT bool TCollection_ExtendedString_IsAscii(void* instance);
extern "C" DECL_EXPORT int TCollection_ExtendedString_Length(void* instance);
extern "C" DECL_EXPORT int TCollection_ExtendedString_LengthOfCString(void* instance);
extern "C" DECL_EXPORT void TCollectionExtendedString_Dtor(void* instance);

#endif
