#ifndef TCollection_HExtendedString_H
#define TCollection_HExtendedString_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* TCollection_HExtendedString_Ctor();
extern "C" DECL_EXPORT void* TCollection_HExtendedString_Ctor9381D4D(
	char* message);
extern "C" DECL_EXPORT void* TCollection_HExtendedString_CtorBCA09447(
	char aChar);
extern "C" DECL_EXPORT void* TCollection_HExtendedString_Ctor71824F83(
	int length,
	char filler);
extern "C" DECL_EXPORT void* TCollection_HExtendedString_Ctor6EE6EE89(
	void* aString);
extern "C" DECL_EXPORT void* TCollection_HExtendedString_CtorB439B3D5(
	void* aString);
extern "C" DECL_EXPORT void* TCollection_HExtendedString_Ctor4C6BF532(
	void* aString);
extern "C" DECL_EXPORT void TCollection_HExtendedString_AssignCat4C6BF532(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void* TCollection_HExtendedString_Cat4C6BF532(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void TCollection_HExtendedString_ChangeAllF70B733C(
	void* instance,
	char aChar,
	char NewChar);
extern "C" DECL_EXPORT void TCollection_HExtendedString_Clear(void* instance);
extern "C" DECL_EXPORT void TCollection_HExtendedString_Insert71824F83(
	void* instance,
	int where,
	char what);
extern "C" DECL_EXPORT void TCollection_HExtendedString_Insert2BBF075E(
	void* instance,
	int where,
	void* what);
extern "C" DECL_EXPORT bool TCollection_HExtendedString_IsLess4C6BF532(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TCollection_HExtendedString_IsGreater4C6BF532(
	void* instance,
	void* other);
extern "C" DECL_EXPORT void TCollection_HExtendedString_Remove5107F6FE(
	void* instance,
	int where,
	int ahowmany);
extern "C" DECL_EXPORT void TCollection_HExtendedString_RemoveAllBCA09447(
	void* instance,
	char what);
extern "C" DECL_EXPORT void TCollection_HExtendedString_SetValue71824F83(
	void* instance,
	int where,
	char what);
extern "C" DECL_EXPORT void TCollection_HExtendedString_SetValue2BBF075E(
	void* instance,
	int where,
	void* what);
extern "C" DECL_EXPORT void* TCollection_HExtendedString_SplitE8219145(
	void* instance,
	int where);
extern "C" DECL_EXPORT int TCollection_HExtendedString_Search4C6BF532(
	void* instance,
	void* what);
extern "C" DECL_EXPORT int TCollection_HExtendedString_SearchFromEnd4C6BF532(
	void* instance,
	void* what);
extern "C" DECL_EXPORT void TCollection_HExtendedString_TruncE8219145(
	void* instance,
	int ahowmany);
extern "C" DECL_EXPORT char TCollection_HExtendedString_ValueE8219145(
	void* instance,
	int where);
extern "C" DECL_EXPORT bool TCollection_HExtendedString_IsSameState4C6BF532(
	void* instance,
	void* other);
extern "C" DECL_EXPORT bool TCollection_HExtendedString_IsEmpty(void* instance);
extern "C" DECL_EXPORT bool TCollection_HExtendedString_IsAscii(void* instance);
extern "C" DECL_EXPORT int TCollection_HExtendedString_Length(void* instance);
extern "C" DECL_EXPORT void* TCollection_HExtendedString_String(void* instance);
extern "C" DECL_EXPORT void* TCollection_HExtendedString_ShallowCopy(void* instance);
extern "C" DECL_EXPORT void TCollectionHExtendedString_Dtor(void* instance);

#endif
