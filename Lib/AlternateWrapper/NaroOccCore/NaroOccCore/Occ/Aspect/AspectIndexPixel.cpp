#include "AspectIndexPixel.h"
#include <Aspect_IndexPixel.hxx>


DECL_EXPORT void* Aspect_IndexPixel_Ctor()
{
	return new Aspect_IndexPixel();
}
DECL_EXPORT void* Aspect_IndexPixel_CtorE8219145(
	int anIndex)
{
	return new Aspect_IndexPixel(			
anIndex);
}
DECL_EXPORT int Aspect_IndexPixel_HashCodeE8219145(
	void* instance,
	int Upper)
{
	Aspect_IndexPixel* result = (Aspect_IndexPixel*)instance;
	return  	result->HashCode(			
Upper);
}
DECL_EXPORT bool Aspect_IndexPixel_IsEqual24DA5CD5(
	void* instance,
	void* Other)
{
		const Aspect_IndexPixel &  _Other =*(const Aspect_IndexPixel *)Other;
	Aspect_IndexPixel* result = (Aspect_IndexPixel*)instance;
	return  	result->IsEqual(			
_Other);
}
DECL_EXPORT bool Aspect_IndexPixel_IsNotEqual24DA5CD5(
	void* instance,
	void* Other)
{
		const Aspect_IndexPixel &  _Other =*(const Aspect_IndexPixel *)Other;
	Aspect_IndexPixel* result = (Aspect_IndexPixel*)instance;
	return  	result->IsNotEqual(			
_Other);
}
DECL_EXPORT void Aspect_IndexPixel_SetValue(void* instance, int value)
{
	Aspect_IndexPixel* result = (Aspect_IndexPixel*)instance;
		result->SetValue(value);
}

DECL_EXPORT int Aspect_IndexPixel_Value(void* instance)
{
	Aspect_IndexPixel* result = (Aspect_IndexPixel*)instance;
	return 	result->Value();
}

DECL_EXPORT void AspectIndexPixel_Dtor(void* instance)
{
	delete (Aspect_IndexPixel*)instance;
}
