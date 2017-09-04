#ifndef TCollection_AsciiString_H
#define TCollection_AsciiString_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TCollection_AsciiString_Ctor();
extern "C" DECL_EXPORT void* TCollection_AsciiString_Ctor9381D4D(
	char* message);
extern "C" DECL_EXPORT void* TCollection_AsciiString_Ctor800FADE1(
	char* message,
	int aLen);
extern "C" DECL_EXPORT void* TCollection_AsciiString_CtorBCA09447(
	char aChar);
extern "C" DECL_EXPORT void* TCollection_AsciiString_Ctor71824F83(
	int length,
	char filler);
extern "C" DECL_EXPORT void* TCollection_AsciiString_CtorE8219145(
	int value);
extern "C" DECL_EXPORT void* TCollection_AsciiString_CtorD82819F3(
	double value);
extern "C" DECL_EXPORT void* TCollection_AsciiString_Ctor66CFACD0(
	void* astring);
extern "C" DECL_EXPORT void* TCollection_AsciiString_CtorD142C0D4(
	void* astring,
	char message);
extern "C" DECL_EXPORT void* TCollection_AsciiString_Ctor54DBAE97(
	void* astring,
	char* message);
extern "C" DECL_EXPORT void* TCollection_AsciiString_CtorB82186D3(
	void* astring,
	void* message);
extern "C" DECL_EXPORT void* TCollection_AsciiString_Ctor77E26705(
	void* astring,
	char replaceNonAscii);
extern "C" DECL_EXPORT void TCollection_AsciiString_AssignCatBCA09447(
	void* instance,
	char other);
extern "C" DECL_EXPORT void TCollection_AsciiString_AssignCatE8219145(
	void* instance,
	int other);
extern "C" DECL_EXPORT void TCollection_AsciiString_AssignCatD82819F3(
	void* instance,
	double other);
extern "C" DECL_EXPORT void TCollection_AsciiString_AssignCat9381D4D(
	void* instance,
	char* other);
extern "C" DECL_EXPORT void TCollection_AsciiString_AssignCat66CFACD0(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void TCollection_AsciiString_Capitalize(void* instance);
extern "C" DECL_EXPORT void* TCollection_AsciiString_CatBCA09447(
	void* instance,
	char other);
extern "C" DECL_EXPORT void* TCollection_AsciiString_CatE8219145(
	void* instance,
	int other);
extern "C" DECL_EXPORT void* TCollection_AsciiString_CatD82819F3(
	void* instance,
	double other);
extern "C" DECL_EXPORT void* TCollection_AsciiString_Cat9381D4D(
	void* instance,
	char* other);
extern "C" DECL_EXPORT void* TCollection_AsciiString_Cat66CFACD0(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void TCollection_AsciiString_Center71824F83(
	void* instance,
	int Width,
	char Filler);
extern "C" DECL_EXPORT void TCollection_AsciiString_ChangeAll4A8EEFF6(
	void* instance,
	char aChar,
	char NewChar,
	bool CaseSensitive);
extern "C" DECL_EXPORT void TCollection_AsciiString_Clear(void* instance);
extern "C" DECL_EXPORT void TCollection_AsciiString_Copy9381D4D(
	void* instance,
	char* fromwhere);
extern "C" DECL_EXPORT void TCollection_AsciiString_Copy66CFACD0(
	void* instance,
	void* fromwhere);
extern "C" DECL_EXPORT int TCollection_AsciiString_FirstLocationInSet10E3C1BB(
	void* instance,
	void* Set,
	int FromIndex,
	int ToIndex);
extern "C" DECL_EXPORT int TCollection_AsciiString_FirstLocationNotInSet10E3C1BB(
	void* instance,
	void* Set,
	int FromIndex,
	int ToIndex);
extern "C" DECL_EXPORT void TCollection_AsciiString_Insert71824F83(
	void* instance,
	int where,
	char what);
extern "C" DECL_EXPORT void TCollection_AsciiString_InsertC9F1A165(
	void* instance,
	int where,
	char* what);
extern "C" DECL_EXPORT void TCollection_AsciiString_InsertFCE887E8(
	void* instance,
	int where,
	void* what);
extern "C" DECL_EXPORT void TCollection_AsciiString_InsertAfterFCE887E8(
	void* instance,
	int Index,
	void* other);
extern "C" DECL_EXPORT void TCollection_AsciiString_InsertBeforeFCE887E8(
	void* instance,
	int Index,
	void* other);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsEqual9381D4D(
	void* instance,
	char* other);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsEqual66CFACD0(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsDifferent9381D4D(
	void* instance,
	char* other);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsDifferent66CFACD0(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsLess9381D4D(
	void* instance,
	char* other);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsLess66CFACD0(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsGreater9381D4D(
	void* instance,
	char* other);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsGreater66CFACD0(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void TCollection_AsciiString_LeftAdjust(void* instance);
extern "C" DECL_EXPORT void TCollection_AsciiString_LeftJustify71824F83(
	void* instance,
	int Width,
	char Filler);
extern "C" DECL_EXPORT int TCollection_AsciiString_Location10E3C1BB(
	void* instance,
	void* other,
	int FromIndex,
	int ToIndex);
extern "C" DECL_EXPORT int TCollection_AsciiString_LocationB9967886(
	void* instance,
	int N,
	char C,
	int FromIndex,
	int ToIndex);
extern "C" DECL_EXPORT void TCollection_AsciiString_LowerCase(void* instance);
extern "C" DECL_EXPORT void TCollection_AsciiString_Prepend66CFACD0(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void TCollection_AsciiString_RemoveAll6D30D0F7(
	void* instance,
	char C,
	bool CaseSensitive);
extern "C" DECL_EXPORT void TCollection_AsciiString_RemoveAllBCA09447(
	void* instance,
	char what);
extern "C" DECL_EXPORT void TCollection_AsciiString_Remove5107F6FE(
	void* instance,
	int where,
	int ahowmany);
extern "C" DECL_EXPORT void TCollection_AsciiString_RightAdjust(void* instance);
extern "C" DECL_EXPORT void TCollection_AsciiString_RightJustify71824F83(
	void* instance,
	int Width,
	char Filler);
extern "C" DECL_EXPORT int TCollection_AsciiString_Search9381D4D(
	void* instance,
	char* what);
extern "C" DECL_EXPORT int TCollection_AsciiString_Search66CFACD0(
	void* instance,
	void* what);
extern "C" DECL_EXPORT int TCollection_AsciiString_SearchFromEnd9381D4D(
	void* instance,
	char* what);
extern "C" DECL_EXPORT int TCollection_AsciiString_SearchFromEnd66CFACD0(
	void* instance,
	void* what);
extern "C" DECL_EXPORT void TCollection_AsciiString_SetValue71824F83(
	void* instance,
	int where,
	char what);
extern "C" DECL_EXPORT void TCollection_AsciiString_SetValueC9F1A165(
	void* instance,
	int where,
	char* what);
extern "C" DECL_EXPORT void TCollection_AsciiString_SetValueFCE887E8(
	void* instance,
	int where,
	void* what);
extern "C" DECL_EXPORT void* TCollection_AsciiString_SplitE8219145(
	void* instance,
	int where);
extern "C" DECL_EXPORT void* TCollection_AsciiString_SubString5107F6FE(
	void* instance,
	int FromIndex,
	int ToIndex);
extern "C" DECL_EXPORT void* TCollection_AsciiString_Token800FADE1(
	void* instance,
	char* separators,
	int whichone);
extern "C" DECL_EXPORT void TCollection_AsciiString_TruncE8219145(
	void* instance,
	int ahowmany);
extern "C" DECL_EXPORT void TCollection_AsciiString_UpperCase(void* instance);
extern "C" DECL_EXPORT char TCollection_AsciiString_ValueE8219145(
	void* instance,
	int where);
extern "C" DECL_EXPORT int TCollection_AsciiString_HashCodeCAFD1949(
	void* astring,
	int Upper);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsEqualB82186D3(
	void* string1,
	void* string2);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsEqual54DBAE97(
	void* string1,
	char* string2);
extern "C" DECL_EXPORT int TCollection_AsciiString_HASHCODECAFD1949(
	void* astring,
	int Upper);
extern "C" DECL_EXPORT bool TCollection_AsciiString_ISSIMILARB82186D3(
	void* string1,
	void* string2);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsEmpty(void* instance);
extern "C" DECL_EXPORT int TCollection_AsciiString_IntegerValue(void* instance);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsIntegerValue(void* instance);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsRealValue(void* instance);
extern "C" DECL_EXPORT bool TCollection_AsciiString_IsAscii(void* instance);
extern "C" DECL_EXPORT int TCollection_AsciiString_Length(void* instance);
extern "C" DECL_EXPORT double TCollection_AsciiString_RealValue(void* instance);
extern "C" DECL_EXPORT Standard_CString TCollection_AsciiString_ToCString(void* instance);
extern "C" DECL_EXPORT int TCollection_AsciiString_UsefullLength(void* instance);
extern "C" DECL_EXPORT void TCollectionAsciiString_Dtor(void* instance);

#endif
