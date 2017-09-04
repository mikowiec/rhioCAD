#include "Prs3dLineAspect.h"
#include <Prs3d_LineAspect.hxx>


DECL_EXPORT void* Prs3d_LineAspect_Ctor1A9E9376(
	int aColor,
	int aType,
	double aWidth)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
		const Aspect_TypeOfLine _aType =(const Aspect_TypeOfLine )aType;
	return new Handle_Prs3d_LineAspect(new Prs3d_LineAspect(			
_aColor,			
_aType,			
aWidth));
}
DECL_EXPORT void* Prs3d_LineAspect_Ctor94ED4A31(
	void* aColor,
	int aType,
	double aWidth)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
		const Aspect_TypeOfLine _aType =(const Aspect_TypeOfLine )aType;
	return new Handle_Prs3d_LineAspect(new Prs3d_LineAspect(			
_aColor,			
_aType,			
aWidth));
}
DECL_EXPORT void Prs3d_LineAspect_SetColor8FD7F48(
	void* instance,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	Prs3d_LineAspect* result = (Prs3d_LineAspect*)(((Handle_Prs3d_LineAspect*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void Prs3d_LineAspect_SetColor48F4F471(
	void* instance,
	int aColor)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	Prs3d_LineAspect* result = (Prs3d_LineAspect*)(((Handle_Prs3d_LineAspect*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void Prs3d_LineAspect_SetTypeOfLine(void* instance, int value)
{
	Prs3d_LineAspect* result = (Prs3d_LineAspect*)(((Handle_Prs3d_LineAspect*)instance)->Access());
		result->SetTypeOfLine((const Aspect_TypeOfLine)value);
}

DECL_EXPORT void Prs3d_LineAspect_SetWidth(void* instance, double value)
{
	Prs3d_LineAspect* result = (Prs3d_LineAspect*)(((Handle_Prs3d_LineAspect*)instance)->Access());
		result->SetWidth(value);
}

DECL_EXPORT void Prs3dLineAspect_Dtor(void* instance)
{
	delete (Handle_Prs3d_LineAspect*)instance;
}
