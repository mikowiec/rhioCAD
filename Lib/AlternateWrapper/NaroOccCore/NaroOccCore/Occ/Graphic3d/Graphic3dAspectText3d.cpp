#include "Graphic3dAspectText3d.h"
#include <Graphic3d_AspectText3d.hxx>


DECL_EXPORT void* Graphic3d_AspectText3d_Ctor()
{
	return new Handle_Graphic3d_AspectText3d(new Graphic3d_AspectText3d());
}
DECL_EXPORT void* Graphic3d_AspectText3d_Ctor61B9B574(
	void* AColor,
	char* AFont,
	double AExpansionFactor,
	double ASpace,
	int AStyle,
	int ADisplayType)
{
		const Quantity_Color &  _AColor =*(const Quantity_Color *)AColor;
		const Aspect_TypeOfStyleText _AStyle =(const Aspect_TypeOfStyleText )AStyle;
		const Aspect_TypeOfDisplayText _ADisplayType =(const Aspect_TypeOfDisplayText )ADisplayType;
	return new Handle_Graphic3d_AspectText3d(new Graphic3d_AspectText3d(			
_AColor,			
AFont,			
AExpansionFactor,			
ASpace,			
_AStyle,			
_ADisplayType));
}
DECL_EXPORT void Graphic3d_AspectText3d_SetColor(void* instance, void* value)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
		result->SetColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void Graphic3d_AspectText3d_SetExpansionFactor(void* instance, double value)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
		result->SetExpansionFactor(value);
}

DECL_EXPORT void Graphic3d_AspectText3d_SetFont(void* instance, char* value)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
		result->SetFont(value);
}

DECL_EXPORT void Graphic3d_AspectText3d_SetSpace(void* instance, double value)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
		result->SetSpace(value);
}

DECL_EXPORT void Graphic3d_AspectText3d_SetStyle(void* instance, int value)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
		result->SetStyle((const Aspect_TypeOfStyleText)value);
}

DECL_EXPORT void Graphic3d_AspectText3d_SetDisplayType(void* instance, int value)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
		result->SetDisplayType((const Aspect_TypeOfDisplayText)value);
}

DECL_EXPORT void Graphic3d_AspectText3d_SetColorSubTitle(void* instance, void* value)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
		result->SetColorSubTitle(*(const Quantity_Color *)value);
}

DECL_EXPORT void Graphic3d_AspectText3d_SetTextZoomable(void* instance, bool value)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
		result->SetTextZoomable(value);
}

DECL_EXPORT bool Graphic3d_AspectText3d_GetTextZoomable(void* instance)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
	return 	result->GetTextZoomable();
}

DECL_EXPORT void Graphic3d_AspectText3d_SetTextAngle(void* instance, double value)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
		result->SetTextAngle(value);
}

DECL_EXPORT double Graphic3d_AspectText3d_GetTextAngle(void* instance)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
	return 	result->GetTextAngle();
}

DECL_EXPORT void Graphic3d_AspectText3d_SetTextFontAspect(void* instance, int value)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
		result->SetTextFontAspect((const Font_FontAspect)value);
}

DECL_EXPORT int Graphic3d_AspectText3d_GetTextFontAspect(void* instance)
{
	Graphic3d_AspectText3d* result = (Graphic3d_AspectText3d*)(((Handle_Graphic3d_AspectText3d*)instance)->Access());
	return (int)	result->GetTextFontAspect();
}

DECL_EXPORT void Graphic3dAspectText3d_Dtor(void* instance)
{
	delete (Handle_Graphic3d_AspectText3d*)instance;
}
