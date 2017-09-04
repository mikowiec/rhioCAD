#ifndef TCollection_HAsciiString_H
#define TCollection_HAsciiString_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TCollection_HAsciiString_Ctor();
extern "C" DECL_EXPORT void* TCollection_HAsciiString_Ctor9381D4D(
	char* message);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_CtorBCA09447(
	char aChar);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_Ctor71824F83(
	int length,
	char filler);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_CtorE8219145(
	int value);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_CtorD82819F3(
	double value);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_Ctor66CFACD0(
	void* aString);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_CtorB439B3D5(
	void* aString);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_CtorB5FFA54(
	void* aString,
	char replaceNonAscii);
extern "C" DECL_EXPORT void TCollection_HAsciiString_AssignCat9381D4D(
	void* instance,
	char* other);
extern "C" DECL_EXPORT void TCollection_HAsciiString_AssignCatB439B3D5(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void TCollection_HAsciiString_Capitalize(void* instance);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_Cat9381D4D(
	void* instance,
	char* other);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_CatB439B3D5(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void TCollection_HAsciiString_Center71824F83(
	void* instance,
	int Width,
	char Filler);
extern "C" DECL_EXPORT void TCollection_HAsciiString_ChangeAll4A8EEFF6(
	void* instance,
	char aChar,
	char NewChar,
	bool CaseSensitive);
extern "C" DECL_EXPORT void TCollection_HAsciiString_Clear(void* instance);
extern "C" DECL_EXPORT int TCollection_HAsciiString_FirstLocationInSet2FE6ADDB(
	void* instance,
	void* Set,
	int FromIndex,
	int ToIndex);
extern "C" DECL_EXPORT int TCollection_HAsciiString_FirstLocationNotInSet2FE6ADDB(
	void* instance,
	void* Set,
	int FromIndex,
	int ToIndex);
extern "C" DECL_EXPORT void TCollection_HAsciiString_Insert71824F83(
	void* instance,
	int where,
	char what);
extern "C" DECL_EXPORT void TCollection_HAsciiString_InsertC9F1A165(
	void* instance,
	int where,
	char* what);
extern "C" DECL_EXPORT void TCollection_HAsciiString_Insert6A685A10(
	void* instance,
	int where,
	void* what);
extern "C" DECL_EXPORT void TCollection_HAsciiString_InsertAfter6A685A10(
	void* instance,
	int Index,
	void* other);
extern "C" DECL_EXPORT void TCollection_HAsciiString_InsertBefore6A685A10(
	void* instance,
	int Index,
	void* other);
extern "C" DECL_EXPORT bool TCollection_HAsciiString_IsLessB439B3D5(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TCollection_HAsciiString_IsGreaterB439B3D5(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TCollection_HAsciiString_IsDifferentB439B3D5(
	void* instance,
	void* S);
extern "C" DECL_EXPORT bool TCollection_HAsciiString_IsSameStringB439B3D5(
	void* instance,
	void* S);
extern "C" DECL_EXPORT bool TCollection_HAsciiString_IsSameString34C64CD3(
	void* instance,
	void* S,
	bool CaseSensitive);
extern "C" DECL_EXPORT void TCollection_HAsciiString_LeftAdjust(void* instance);
extern "C" DECL_EXPORT void TCollection_HAsciiString_LeftJustify71824F83(
	void* instance,
	int Width,
	char Filler);
extern "C" DECL_EXPORT int TCollection_HAsciiString_Location2FE6ADDB(
	void* instance,
	void* other,
	int FromIndex,
	int ToIndex);
extern "C" DECL_EXPORT int TCollection_HAsciiString_LocationB9967886(
	void* instance,
	int N,
	char C,
	int FromIndex,
	int ToIndex);
extern "C" DECL_EXPORT void TCollection_HAsciiString_LowerCase(void* instance);
extern "C" DECL_EXPORT void TCollection_HAsciiString_PrependB439B3D5(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void TCollection_HAsciiString_RemoveAll6D30D0F7(
	void* instance,
	char C,
	bool CaseSensitive);
extern "C" DECL_EXPORT void TCollection_HAsciiString_RemoveAllBCA09447(
	void* instance,
	char what);
extern "C" DECL_EXPORT void TCollection_HAsciiString_Remove5107F6FE(
	void* instance,
	int where,
	int ahowmany);
extern "C" DECL_EXPORT void TCollection_HAsciiString_RightAdjust(void* instance);
extern "C" DECL_EXPORT void TCollection_HAsciiString_RightJustify71824F83(
	void* instance,
	int Width,
	char Filler);
extern "C" DECL_EXPORT int TCollection_HAsciiString_Search9381D4D(
	void* instance,
	char* what);
extern "C" DECL_EXPORT int TCollection_HAsciiString_SearchB439B3D5(
	void* instance,
	void* what);
extern "C" DECL_EXPORT int TCollection_HAsciiString_SearchFromEnd9381D4D(
	void* instance,
	char* what);
extern "C" DECL_EXPORT int TCollection_HAsciiString_SearchFromEndB439B3D5(
	void* instance,
	void* what);
extern "C" DECL_EXPORT void TCollection_HAsciiString_SetValue71824F83(
	void* instance,
	int where,
	char what);
extern "C" DECL_EXPORT void TCollection_HAsciiString_SetValueC9F1A165(
	void* instance,
	int where,
	char* what);
extern "C" DECL_EXPORT void TCollection_HAsciiString_SetValue6A685A10(
	void* instance,
	int where,
	void* what);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_SplitE8219145(
	void* instance,
	int where);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_SubString5107F6FE(
	void* instance,
	int FromIndex,
	int ToIndex);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_Token800FADE1(
	void* instance,
	char* separators,
	int whichone);
extern "C" DECL_EXPORT void TCollection_HAsciiString_TruncE8219145(
	void* instance,
	int ahowmany);
extern "C" DECL_EXPORT void TCollection_HAsciiString_UpperCase(void* instance);
extern "C" DECL_EXPORT char TCollection_HAsciiString_ValueE8219145(
	void* instance,
	int where);
extern "C" DECL_EXPORT bool TCollection_HAsciiString_IsSameStateB439B3D5(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TCollection_HAsciiString_IsEmpty(void* instance);
extern "C" DECL_EXPORT int TCollection_HAsciiString_IntegerValue(void* instance);
extern "C" DECL_EXPORT bool TCollection_HAsciiString_IsIntegerValue(void* instance);
extern "C" DECL_EXPORT bool TCollection_HAsciiString_IsRealValue(void* instance);
extern "C" DECL_EXPORT bool TCollection_HAsciiString_IsAscii(void* instance);
extern "C" DECL_EXPORT int TCollection_HAsciiString_Length(void* instance);
extern "C" DECL_EXPORT double TCollection_HAsciiString_RealValue(void* instance);
extern "C" DECL_EXPORT Standard_CString TCollection_HAsciiString_ToCString(void* instance);
extern "C" DECL_EXPORT int TCollection_HAsciiString_UsefullLength(void* instance);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_String(void* instance);
extern "C" DECL_EXPORT void* TCollection_HAsciiString_ShallowCopy(void* instance);
extern "C" DECL_EXPORT void TCollectionHAsciiString_Dtor(void* instance);

#endif
