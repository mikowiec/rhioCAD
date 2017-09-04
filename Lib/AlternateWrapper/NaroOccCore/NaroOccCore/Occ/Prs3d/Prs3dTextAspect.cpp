#include "Prs3dTextAspect.h"
#include <Prs3d_TextAspect.hxx>

#include <Graphic3d_AspectText3d.hxx>

DECL_EXPORT void* Prs3d_TextAspect_Ctor()
{
	return new Handle_Prs3d_TextAspect(new Prs3d_TextAspect());
}
DECL_EXPORT void Prs3d_TextAspect_SetColor8FD7F48(
	void* instance,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void Prs3d_TextAspect_SetColor48F4F471(
	void* instance,
	int aColor)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void Prs3d_TextAspect_SetFont(void* instance, char* value)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
		result->SetFont(value);
}

DECL_EXPORT void Prs3d_TextAspect_SetHeightWidthRatio(void* instance, double value)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
		result->SetHeightWidthRatio(value);
}

DECL_EXPORT void Prs3d_TextAspect_SetSpace(void* instance, double value)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
		result->SetSpace(value);
}

DECL_EXPORT void Prs3d_TextAspect_SetHeight(void* instance, double value)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
		result->SetHeight(value);
}

DECL_EXPORT double Prs3d_TextAspect_Height(void* instance)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
	return 	result->Height();
}

DECL_EXPORT void Prs3d_TextAspect_SetAngle(void* instance, double value)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
		result->SetAngle(value);
}

DECL_EXPORT double Prs3d_TextAspect_Angle(void* instance)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
	return 	result->Angle();
}

DECL_EXPORT void Prs3d_TextAspect_SetHorizontalJustification(void* instance, int value)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
		result->SetHorizontalJustification((const Graphic3d_HorizontalTextAlignment)value);
}

DECL_EXPORT int Prs3d_TextAspect_HorizontalJustification(void* instance)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
	return (int)	result->HorizontalJustification();
}

DECL_EXPORT void Prs3d_TextAspect_SetVerticalJustification(void* instance, int value)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
		result->SetVerticalJustification((const Graphic3d_VerticalTextAlignment)value);
}

DECL_EXPORT int Prs3d_TextAspect_VerticalJustification(void* instance)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
	return (int)	result->VerticalJustification();
}

DECL_EXPORT void Prs3d_TextAspect_SetOrientation(void* instance, int value)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
		result->SetOrientation((const Graphic3d_TextPath)value);
}

DECL_EXPORT int Prs3d_TextAspect_Orientation(void* instance)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
	return (int)	result->Orientation();
}

DECL_EXPORT void* Prs3d_TextAspect_Aspect(void* instance)
{
	Prs3d_TextAspect* result = (Prs3d_TextAspect*)(((Handle_Prs3d_TextAspect*)instance)->Access());
	return 	new Handle_Graphic3d_AspectText3d(	result->Aspect());
}

DECL_EXPORT void Prs3dTextAspect_Dtor(void* instance)
{
	delete (Handle_Prs3d_TextAspect*)instance;
}
