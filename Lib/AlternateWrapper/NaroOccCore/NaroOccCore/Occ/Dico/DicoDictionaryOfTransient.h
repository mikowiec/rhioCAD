#ifndef Dico_DictionaryOfTransient_H
#define Dico_DictionaryOfTransient_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Dico_DictionaryOfTransient_Ctor();
extern "C" DECL_EXPORT bool Dico_DictionaryOfTransient_HasItemDE32234A(
	void* instance,
	char* name,
	bool exact);
extern "C" DECL_EXPORT bool Dico_DictionaryOfTransient_HasItem145F6059(
	void* instance,
	void* name,
	bool exact);
extern "C" DECL_EXPORT void* Dico_DictionaryOfTransient_ItemDE32234A(
	void* instance,
	char* name,
	bool exact);
extern "C" DECL_EXPORT void* Dico_DictionaryOfTransient_Item145F6059(
	void* instance,
	void* name,
	bool exact);
extern "C" DECL_EXPORT bool Dico_DictionaryOfTransient_GetItem5A688646(
	void* instance,
	char* name,
	void* anitem,
	bool exact);
extern "C" DECL_EXPORT bool Dico_DictionaryOfTransient_GetItem10A7D525(
	void* instance,
	void* name,
	void* anitem,
	bool exact);
extern "C" DECL_EXPORT void Dico_DictionaryOfTransient_SetItem5A688646(
	void* instance,
	char* name,
	void* anitem,
	bool exact);
extern "C" DECL_EXPORT void Dico_DictionaryOfTransient_SetItem10A7D525(
	void* instance,
	void* name,
	void* anitem,
	bool exact);
extern "C" DECL_EXPORT void* Dico_DictionaryOfTransient_NewItem7BFBA428(
	void* instance,
	char* name,
	bool* isvalued,
	bool exact);
extern "C" DECL_EXPORT void* Dico_DictionaryOfTransient_NewItem18A50CD3(
	void* instance,
	void* name,
	bool* isvalued,
	bool exact);
extern "C" DECL_EXPORT bool Dico_DictionaryOfTransient_RemoveItem7BFBA428(
	void* instance,
	char* name,
	bool cln,
	bool exact);
extern "C" DECL_EXPORT bool Dico_DictionaryOfTransient_RemoveItem18A50CD3(
	void* instance,
	void* name,
	bool cln,
	bool exact);
extern "C" DECL_EXPORT void Dico_DictionaryOfTransient_Clean(void* instance);
extern "C" DECL_EXPORT void Dico_DictionaryOfTransient_Clear(void* instance);
extern "C" DECL_EXPORT bool Dico_DictionaryOfTransient_Complete31B29E5D(
	void* instance,
	void* acell);
extern "C" DECL_EXPORT bool Dico_DictionaryOfTransient_IsEmpty(void* instance);
extern "C" DECL_EXPORT void* Dico_DictionaryOfTransient_Copy(void* instance);
extern "C" DECL_EXPORT void DicoDictionaryOfTransient_Dtor(void* instance);

#endif
