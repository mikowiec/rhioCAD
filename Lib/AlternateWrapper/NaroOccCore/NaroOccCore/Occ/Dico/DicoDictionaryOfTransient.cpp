#include "DicoDictionaryOfTransient.h"
#include <Dico_DictionaryOfTransient.hxx>

#include <Dico_DictionaryOfTransient.hxx>
#include <Standard_Transient.hxx>

DECL_EXPORT void* Dico_DictionaryOfTransient_Ctor()
{
	return new Handle_Dico_DictionaryOfTransient(new Dico_DictionaryOfTransient());
}
DECL_EXPORT bool Dico_DictionaryOfTransient_HasItemDE32234A(
	void* instance,
	char* name,
	bool exact)
{
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return  	result->HasItem(			
name,			
exact);
}
DECL_EXPORT bool Dico_DictionaryOfTransient_HasItem145F6059(
	void* instance,
	void* name,
	bool exact)
{
		const TCollection_AsciiString &  _name =*(const TCollection_AsciiString *)name;
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return  	result->HasItem(			
_name,			
exact);
}
DECL_EXPORT void* Dico_DictionaryOfTransient_ItemDE32234A(
	void* instance,
	char* name,
	bool exact)
{
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return new Handle_Standard_Transient( 	result->Item(			
name,			
exact));
}
DECL_EXPORT void* Dico_DictionaryOfTransient_Item145F6059(
	void* instance,
	void* name,
	bool exact)
{
		const TCollection_AsciiString &  _name =*(const TCollection_AsciiString *)name;
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return new Handle_Standard_Transient( 	result->Item(			
_name,			
exact));
}
DECL_EXPORT bool Dico_DictionaryOfTransient_GetItem5A688646(
	void* instance,
	char* name,
	void* anitem,
	bool exact)
{
		Handle_Standard_Transient&  _anitem =*(Handle_Standard_Transient *)anitem;
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return  	result->GetItem(			
name,			
_anitem,			
exact);
}
DECL_EXPORT bool Dico_DictionaryOfTransient_GetItem10A7D525(
	void* instance,
	void* name,
	void* anitem,
	bool exact)
{
		const TCollection_AsciiString &  _name =*(const TCollection_AsciiString *)name;
		Handle_Standard_Transient&  _anitem =*(Handle_Standard_Transient *)anitem;
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return  	result->GetItem(			
_name,			
_anitem,			
exact);
}
DECL_EXPORT void Dico_DictionaryOfTransient_SetItem5A688646(
	void* instance,
	char* name,
	void* anitem,
	bool exact)
{
		const Handle_Standard_Transient&  _anitem =*(const Handle_Standard_Transient *)anitem;
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
 	result->SetItem(			
name,			
_anitem,			
exact);
}
DECL_EXPORT void Dico_DictionaryOfTransient_SetItem10A7D525(
	void* instance,
	void* name,
	void* anitem,
	bool exact)
{
		const TCollection_AsciiString &  _name =*(const TCollection_AsciiString *)name;
		const Handle_Standard_Transient&  _anitem =*(const Handle_Standard_Transient *)anitem;
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
 	result->SetItem(			
_name,			
_anitem,			
exact);
}
DECL_EXPORT void* Dico_DictionaryOfTransient_NewItem7BFBA428(
	void* instance,
	char* name,
	bool* isvalued,
	bool exact)
{
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return new Handle_Standard_Transient( 	result->NewItem(			
name,			
(Standard_Boolean&)*isvalued,			
exact));
}
DECL_EXPORT void* Dico_DictionaryOfTransient_NewItem18A50CD3(
	void* instance,
	void* name,
	bool* isvalued,
	bool exact)
{
		const TCollection_AsciiString &  _name =*(const TCollection_AsciiString *)name;
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return new Handle_Standard_Transient( 	result->NewItem(			
_name,			
(Standard_Boolean&)*isvalued,			
exact));
}
DECL_EXPORT bool Dico_DictionaryOfTransient_RemoveItem7BFBA428(
	void* instance,
	char* name,
	bool cln,
	bool exact)
{
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return  	result->RemoveItem(			
name,			
cln,			
exact);
}
DECL_EXPORT bool Dico_DictionaryOfTransient_RemoveItem18A50CD3(
	void* instance,
	void* name,
	bool cln,
	bool exact)
{
		const TCollection_AsciiString &  _name =*(const TCollection_AsciiString *)name;
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return  	result->RemoveItem(			
_name,			
cln,			
exact);
}
DECL_EXPORT void Dico_DictionaryOfTransient_Clean(void* instance)
{
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
 	result->Clean();
}
DECL_EXPORT void Dico_DictionaryOfTransient_Clear(void* instance)
{
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
 	result->Clear();
}
DECL_EXPORT bool Dico_DictionaryOfTransient_Complete31B29E5D(
	void* instance,
	void* acell)
{
		Handle_Dico_DictionaryOfTransient&  _acell =*(Handle_Dico_DictionaryOfTransient *)acell;
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return  	result->Complete(			
_acell);
}
DECL_EXPORT bool Dico_DictionaryOfTransient_IsEmpty(void* instance)
{
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return 	result->IsEmpty();
}

DECL_EXPORT void* Dico_DictionaryOfTransient_Copy(void* instance)
{
	Dico_DictionaryOfTransient* result = (Dico_DictionaryOfTransient*)(((Handle_Dico_DictionaryOfTransient*)instance)->Access());
	return 	new Handle_Dico_DictionaryOfTransient(	result->Copy());
}

DECL_EXPORT void DicoDictionaryOfTransient_Dtor(void* instance)
{
	delete (Handle_Dico_DictionaryOfTransient*)instance;
}
