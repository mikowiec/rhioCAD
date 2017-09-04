#include "PolyArray1OfTriangle.h"
#include <Poly_Array1OfTriangle.hxx>

#include <Poly_Array1OfTriangle.hxx>
#include <Poly_Triangle.hxx>

DECL_EXPORT void* Poly_Array1OfTriangle_Ctor5107F6FE(
	int Low,
	int Up)
{
	return new Poly_Array1OfTriangle(			
Low,			
Up);
}
DECL_EXPORT void* Poly_Array1OfTriangle_Ctor522DB52C(
	void* Item,
	int Low,
	int Up)
{
		const Poly_Triangle &  _Item =*(const Poly_Triangle *)Item;
	return new Poly_Array1OfTriangle(			
_Item,			
Low,			
Up);
}
DECL_EXPORT void Poly_Array1OfTriangle_Init170E771E(
	void* instance,
	void* V)
{
		const Poly_Triangle &  _V =*(const Poly_Triangle *)V;
	Poly_Array1OfTriangle* result = (Poly_Array1OfTriangle*)instance;
 	result->Init(			
_V);
}
DECL_EXPORT void* Poly_Array1OfTriangle_Assign8767CC10(
	void* instance,
	void* Other)
{
	
		const Poly_Array1OfTriangle &  _Other =*(const Poly_Array1OfTriangle *)Other;
	Poly_Array1OfTriangle* data = new Poly_Array1OfTriangle(0, 10);
		Poly_Array1OfTriangle* result = (Poly_Array1OfTriangle*)instance;
	*data = result->Assign(_Other);
	return data;
}
DECL_EXPORT void Poly_Array1OfTriangle_SetValue9D4F3515(
	void* instance,
	int Index,
	void* Value)
{
		const Poly_Triangle &  _Value =*(const Poly_Triangle *)Value;
	Poly_Array1OfTriangle* result = (Poly_Array1OfTriangle*)instance;
 	result->SetValue(			
Index,			
_Value);
}
DECL_EXPORT void* Poly_Array1OfTriangle_ValueE8219145(
	void* instance,
	int Index)
{
	Poly_Array1OfTriangle* result = (Poly_Array1OfTriangle*)instance;
	return new Poly_Triangle( 	result->Value(			
Index));
}
DECL_EXPORT void* Poly_Array1OfTriangle_ChangeValueE8219145(
	void* instance,
	int Index)
{
	Poly_Array1OfTriangle* result = (Poly_Array1OfTriangle*)instance;
	return new Poly_Triangle( 	result->ChangeValue(			
Index));
}
DECL_EXPORT bool Poly_Array1OfTriangle_IsAllocated(void* instance)
{
	Poly_Array1OfTriangle* result = (Poly_Array1OfTriangle*)instance;
	return 	result->IsAllocated();
}

DECL_EXPORT int Poly_Array1OfTriangle_Length(void* instance)
{
	Poly_Array1OfTriangle* result = (Poly_Array1OfTriangle*)instance;
	return 	result->Length();
}

DECL_EXPORT int Poly_Array1OfTriangle_Lower(void* instance)
{
	Poly_Array1OfTriangle* result = (Poly_Array1OfTriangle*)instance;
	return 	result->Lower();
}

DECL_EXPORT int Poly_Array1OfTriangle_Upper(void* instance)
{
	Poly_Array1OfTriangle* result = (Poly_Array1OfTriangle*)instance;
	return 	result->Upper();
}

DECL_EXPORT void PolyArray1OfTriangle_Dtor(void* instance)
{
	delete (Poly_Array1OfTriangle*)instance;
}
