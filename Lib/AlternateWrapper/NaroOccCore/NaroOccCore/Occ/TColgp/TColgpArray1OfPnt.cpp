#include "TColgpArray1OfPnt.h"
#include <TColgp_Array1OfPnt.hxx>

#include <gp_Pnt.hxx>
#include <TColgp_Array1OfPnt.hxx>

DECL_EXPORT void* TColgp_Array1OfPnt_Ctor5107F6FE(
	int Low,
	int Up)
{
	return new TColgp_Array1OfPnt(			
Low,			
Up);
}
DECL_EXPORT void* TColgp_Array1OfPnt_CtorABE6CB63(
	void* Item,
	int Low,
	int Up)
{
		const gp_Pnt &  _Item =*(const gp_Pnt *)Item;
	return new TColgp_Array1OfPnt(			
_Item,			
Low,			
Up);
}
DECL_EXPORT void TColgp_Array1OfPnt_Init9EAECD5B(
	void* instance,
	void* V)
{
		const gp_Pnt &  _V =*(const gp_Pnt *)V;
	TColgp_Array1OfPnt* result = (TColgp_Array1OfPnt*)instance;
 	result->Init(			
_V);
}
DECL_EXPORT void* TColgp_Array1OfPnt_AssignFABD0F95(
	void* instance,
	void* Other)
{
	TColgp_Array1OfPnt* data = new TColgp_Array1OfPnt(0, 10);
		 TColgp_Array1OfPnt &  _Other =*( TColgp_Array1OfPnt *)Other;
	TColgp_Array1OfPnt* result = (TColgp_Array1OfPnt*)instance;
	*data = ( 	result->Assign(			
_Other));
	return data;
}
DECL_EXPORT void TColgp_Array1OfPnt_SetValue7B5D1E58(
	void* instance,
	int Index,
	void* Value)
{
		const gp_Pnt &  _Value =*(const gp_Pnt *)Value;
	TColgp_Array1OfPnt* result = (TColgp_Array1OfPnt*)instance;
 	result->SetValue(			
Index,			
_Value);
}
DECL_EXPORT void* TColgp_Array1OfPnt_ValueE8219145(
	void* instance,
	int Index)
{
	TColgp_Array1OfPnt* result = (TColgp_Array1OfPnt*)instance;
	return new gp_Pnt( 	result->Value(			
Index));
}
DECL_EXPORT void* TColgp_Array1OfPnt_ChangeValueE8219145(
	void* instance,
	int Index)
{
	TColgp_Array1OfPnt* result = (TColgp_Array1OfPnt*)instance;
	return new gp_Pnt( 	result->ChangeValue(			
Index));
}
DECL_EXPORT bool TColgp_Array1OfPnt_IsAllocated(void* instance)
{
	TColgp_Array1OfPnt* result = (TColgp_Array1OfPnt*)instance;
	return 	result->IsAllocated();
}

DECL_EXPORT int TColgp_Array1OfPnt_Length(void* instance)
{
	TColgp_Array1OfPnt* result = (TColgp_Array1OfPnt*)instance;
	return 	result->Length();
}

DECL_EXPORT int TColgp_Array1OfPnt_Lower(void* instance)
{
	TColgp_Array1OfPnt* result = (TColgp_Array1OfPnt*)instance;
	return 	result->Lower();
}

DECL_EXPORT int TColgp_Array1OfPnt_Upper(void* instance)
{
	TColgp_Array1OfPnt* result = (TColgp_Array1OfPnt*)instance;
	return 	result->Upper();
}

DECL_EXPORT void TColgpArray1OfPnt_Dtor(void* instance)
{
	delete (TColgp_Array1OfPnt*)instance;
}
