#include "Prs3dPointAspect.h"
#include <Prs3d_PointAspect.hxx>


DECL_EXPORT void* Prs3d_PointAspect_Ctor9BAF9396(
	int aType,
	void* aColor,
	double aScale)
{
		const Aspect_TypeOfMarker _aType =(const Aspect_TypeOfMarker )aType;
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	return new Handle_Prs3d_PointAspect(new Prs3d_PointAspect(			
_aType,			
_aColor,			
aScale));
}
DECL_EXPORT void* Prs3d_PointAspect_CtorF00B8265(
	int aType,
	int aColor,
	double aScale)
{
		const Aspect_TypeOfMarker _aType =(const Aspect_TypeOfMarker )aType;
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	return new Handle_Prs3d_PointAspect(new Prs3d_PointAspect(			
_aType,			
_aColor,			
aScale));
}
DECL_EXPORT void Prs3d_PointAspect_SetColor8FD7F48(
	void* instance,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	Prs3d_PointAspect* result = (Prs3d_PointAspect*)(((Handle_Prs3d_PointAspect*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void Prs3d_PointAspect_SetColor48F4F471(
	void* instance,
	int aColor)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	Prs3d_PointAspect* result = (Prs3d_PointAspect*)(((Handle_Prs3d_PointAspect*)instance)->Access());
 	result->SetColor(			
_aColor);
}
DECL_EXPORT void Prs3d_PointAspect_GetTextureSize5107F6FE(
	void* instance,
	int* AWidth,
	int* AHeight)
{
	Prs3d_PointAspect* result = (Prs3d_PointAspect*)(((Handle_Prs3d_PointAspect*)instance)->Access());
 	result->GetTextureSize(			
*AWidth,			
*AHeight);
}
DECL_EXPORT void Prs3d_PointAspect_SetTypeOfMarker(void* instance, int value)
{
	Prs3d_PointAspect* result = (Prs3d_PointAspect*)(((Handle_Prs3d_PointAspect*)instance)->Access());
		result->SetTypeOfMarker((const Aspect_TypeOfMarker)value);
}

DECL_EXPORT void Prs3d_PointAspect_SetScale(void* instance, double value)
{
	Prs3d_PointAspect* result = (Prs3d_PointAspect*)(((Handle_Prs3d_PointAspect*)instance)->Access());
		result->SetScale(value);
}

DECL_EXPORT void Prs3dPointAspect_Dtor(void* instance)
{
	delete (Handle_Prs3d_PointAspect*)instance;
}
