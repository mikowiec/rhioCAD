#include "Prs3dIsoAspect.h"
#include <Prs3d_IsoAspect.hxx>


DECL_EXPORT void* Prs3d_IsoAspect_CtorC2594F57(
	int aColor,
	int aType,
	double aWidth,
	int aNumber)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
		const Aspect_TypeOfLine _aType =(const Aspect_TypeOfLine )aType;
	return new Handle_Prs3d_IsoAspect(new Prs3d_IsoAspect(			
_aColor,			
_aType,			
aWidth,			
aNumber));
}
DECL_EXPORT void* Prs3d_IsoAspect_CtorE8121D05(
	void* aColor,
	int aType,
	double aWidth,
	int aNumber)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
		const Aspect_TypeOfLine _aType =(const Aspect_TypeOfLine )aType;
	return new Handle_Prs3d_IsoAspect(new Prs3d_IsoAspect(			
_aColor,			
_aType,			
aWidth,			
aNumber));
}
DECL_EXPORT void Prs3d_IsoAspect_SetNumber(void* instance, int value)
{
	Prs3d_IsoAspect* result = (Prs3d_IsoAspect*)(((Handle_Prs3d_IsoAspect*)instance)->Access());
		result->SetNumber(value);
}

DECL_EXPORT int Prs3d_IsoAspect_Number(void* instance)
{
	Prs3d_IsoAspect* result = (Prs3d_IsoAspect*)(((Handle_Prs3d_IsoAspect*)instance)->Access());
	return 	result->Number();
}

DECL_EXPORT void Prs3dIsoAspect_Dtor(void* instance)
{
	delete (Handle_Prs3d_IsoAspect*)instance;
}
