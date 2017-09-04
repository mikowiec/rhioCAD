#include "AspectBackground.h"
#include <Aspect_Background.hxx>

#include <Quantity_Color.hxx>

DECL_EXPORT void* Aspect_Background_Ctor()
{
	return new Aspect_Background();
}
DECL_EXPORT void* Aspect_Background_Ctor8FD7F48(
	void* AColor)
{
		const Quantity_Color &  _AColor =*(const Quantity_Color *)AColor;
	return new Aspect_Background(			
_AColor);
}
DECL_EXPORT void Aspect_Background_SetColor(void* instance, void* value)
{
	Aspect_Background* result = (Aspect_Background*)instance;
		result->SetColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void* Aspect_Background_Color(void* instance)
{
	Aspect_Background* result = (Aspect_Background*)instance;
	return 	new Quantity_Color(	result->Color());
}

DECL_EXPORT void AspectBackground_Dtor(void* instance)
{
	delete (Aspect_Background*)instance;
}
