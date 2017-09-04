#include "AspectColorPixel.h"
#include <Aspect_ColorPixel.hxx>

#include <Quantity_Color.hxx>

DECL_EXPORT void* Aspect_ColorPixel_Ctor()
{
	return new Aspect_ColorPixel();
}
DECL_EXPORT void* Aspect_ColorPixel_Ctor8FD7F48(
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	return new Aspect_ColorPixel(			
_aColor);
}
DECL_EXPORT int Aspect_ColorPixel_HashCodeE8219145(
	void* instance,
	int Upper)
{
	Aspect_ColorPixel* result = (Aspect_ColorPixel*)instance;
	return  	result->HashCode(			
Upper);
}
DECL_EXPORT bool Aspect_ColorPixel_IsEqualBD406A6D(
	void* instance,
	void* Other)
{
		const Aspect_ColorPixel &  _Other =*(const Aspect_ColorPixel *)Other;
	Aspect_ColorPixel* result = (Aspect_ColorPixel*)instance;
	return  	result->IsEqual(			
_Other);
}
DECL_EXPORT bool Aspect_ColorPixel_IsNotEqualBD406A6D(
	void* instance,
	void* Other)
{
		const Aspect_ColorPixel &  _Other =*(const Aspect_ColorPixel *)Other;
	Aspect_ColorPixel* result = (Aspect_ColorPixel*)instance;
	return  	result->IsNotEqual(			
_Other);
}
DECL_EXPORT void Aspect_ColorPixel_SetValue(void* instance, void* value)
{
	Aspect_ColorPixel* result = (Aspect_ColorPixel*)instance;
		result->SetValue(*(const Quantity_Color *)value);
}

DECL_EXPORT void* Aspect_ColorPixel_Value(void* instance)
{
	Aspect_ColorPixel* result = (Aspect_ColorPixel*)instance;
	return 	new Quantity_Color(	result->Value());
}

DECL_EXPORT void AspectColorPixel_Dtor(void* instance)
{
	delete (Aspect_ColorPixel*)instance;
}
