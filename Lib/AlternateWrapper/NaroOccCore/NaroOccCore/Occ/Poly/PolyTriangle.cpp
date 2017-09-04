#include "PolyTriangle.h"
#include <Poly_Triangle.hxx>


DECL_EXPORT void* Poly_Triangle_Ctor()
{
	return new Poly_Triangle();
}
DECL_EXPORT void* Poly_Triangle_CtorE278791(
	int N1,
	int N2,
	int N3)
{
	return new Poly_Triangle(			
N1,			
N2,			
N3);
}
DECL_EXPORT void Poly_Triangle_SetE278791(
	void* instance,
	int N1,
	int N2,
	int N3)
{
	Poly_Triangle* result = (Poly_Triangle*)instance;
 	result->Set(			
N1,			
N2,			
N3);
}
DECL_EXPORT void Poly_Triangle_Set5107F6FE(
	void* instance,
	int Index,
	int Node)
{
	Poly_Triangle* result = (Poly_Triangle*)instance;
 	result->Set(			
Index,			
Node);
}
DECL_EXPORT void Poly_Triangle_GetE278791(
	void* instance,
	int* N1,
	int* N2,
	int* N3)
{
	Poly_Triangle* result = (Poly_Triangle*)instance;
 	result->Get(			
*N1,			
*N2,			
*N3);
}
DECL_EXPORT int Poly_Triangle_ValueE8219145(
	void* instance,
	int Index)
{
	Poly_Triangle* result = (Poly_Triangle*)instance;
	return  	result->Value(			
Index);
}
DECL_EXPORT int Poly_Triangle_ChangeValueE8219145(
	void* instance,
	int Index)
{
	Poly_Triangle* result = (Poly_Triangle*)instance;
	return  	result->ChangeValue(			
Index);
}
DECL_EXPORT void PolyTriangle_Dtor(void* instance)
{
	delete (Poly_Triangle*)instance;
}
