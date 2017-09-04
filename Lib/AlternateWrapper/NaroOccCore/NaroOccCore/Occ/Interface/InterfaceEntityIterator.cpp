#include "InterfaceEntityIterator.h"
#include <Interface_EntityIterator.hxx>

#include <Interface_EntityIterator.hxx>
#include <Standard_Transient.hxx>

DECL_EXPORT void* Interface_EntityIterator_Ctor()
{
	return new Interface_EntityIterator();
}
DECL_EXPORT void Interface_EntityIterator_AddItemF411CB01(
	void* instance,
	void* anentity)
{
		const Handle_Standard_Transient&  _anentity =*(const Handle_Standard_Transient *)anentity;
	Interface_EntityIterator* result = (Interface_EntityIterator*)instance;
 	result->AddItem(			
_anentity);
}
DECL_EXPORT void Interface_EntityIterator_GetOneItemF411CB01(
	void* instance,
	void* anentity)
{
		const Handle_Standard_Transient&  _anentity =*(const Handle_Standard_Transient *)anentity;
	Interface_EntityIterator* result = (Interface_EntityIterator*)instance;
 	result->GetOneItem(			
_anentity);
}
DECL_EXPORT void Interface_EntityIterator_SelectTypeC4B77EEF(
	void* instance,
	void* atype,
	bool keep)
{
		const Handle_Standard_Type&  _atype =*(const Handle_Standard_Type *)atype;
	Interface_EntityIterator* result = (Interface_EntityIterator*)instance;
 	result->SelectType(			
_atype,			
keep);
}
DECL_EXPORT int Interface_EntityIterator_NbTypedE2B3EAC1(
	void* instance,
	void* type)
{
		const Handle_Standard_Type&  _type =*(const Handle_Standard_Type *)type;
	Interface_EntityIterator* result = (Interface_EntityIterator*)instance;
	return  	result->NbTyped(			
_type);
}
DECL_EXPORT void* Interface_EntityIterator_TypedE2B3EAC1(
	void* instance,
	void* type)
{
		const Handle_Standard_Type&  _type =*(const Handle_Standard_Type *)type;
	Interface_EntityIterator* result = (Interface_EntityIterator*)instance;
	return new Interface_EntityIterator( 	result->Typed(			
_type));
}
DECL_EXPORT void Interface_EntityIterator_Start(void* instance)
{
	Interface_EntityIterator* result = (Interface_EntityIterator*)instance;
 	result->Start();
}
DECL_EXPORT void Interface_EntityIterator_Next(void* instance)
{
	Interface_EntityIterator* result = (Interface_EntityIterator*)instance;
 	result->Next();
}
DECL_EXPORT void Interface_EntityIterator_Destroy(void* instance)
{
	Interface_EntityIterator* result = (Interface_EntityIterator*)instance;
 	result->Destroy();
}
DECL_EXPORT int Interface_EntityIterator_NbEntities(void* instance)
{
	Interface_EntityIterator* result = (Interface_EntityIterator*)instance;
	return 	result->NbEntities();
}

DECL_EXPORT bool Interface_EntityIterator_More(void* instance)
{
	Interface_EntityIterator* result = (Interface_EntityIterator*)instance;
	return 	result->More();
}

DECL_EXPORT void* Interface_EntityIterator_Value(void* instance)
{
	Interface_EntityIterator* result = (Interface_EntityIterator*)instance;
	return 	new Handle_Standard_Transient(	result->Value());
}

DECL_EXPORT void InterfaceEntityIterator_Dtor(void* instance)
{
	delete (Interface_EntityIterator*)instance;
}
