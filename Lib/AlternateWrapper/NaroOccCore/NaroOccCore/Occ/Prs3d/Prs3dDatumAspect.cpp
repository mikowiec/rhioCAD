#include "Prs3dDatumAspect.h"
#include <Prs3d_DatumAspect.hxx>

#include <Prs3d_LineAspect.hxx>

DECL_EXPORT void* Prs3d_DatumAspect_Ctor()
{
	return new Handle_Prs3d_DatumAspect(new Prs3d_DatumAspect());
}
DECL_EXPORT void Prs3d_DatumAspect_SetAxisLength9282A951(
	void* instance,
	double L1,
	double L2,
	double L3)
{
	Prs3d_DatumAspect* result = (Prs3d_DatumAspect*)(((Handle_Prs3d_DatumAspect*)instance)->Access());
 	result->SetAxisLength(			
L1,			
L2,			
L3);
}
DECL_EXPORT void* Prs3d_DatumAspect_FirstAxisAspect(void* instance)
{
	Prs3d_DatumAspect* result = (Prs3d_DatumAspect*)(((Handle_Prs3d_DatumAspect*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->FirstAxisAspect());
}

DECL_EXPORT void* Prs3d_DatumAspect_SecondAxisAspect(void* instance)
{
	Prs3d_DatumAspect* result = (Prs3d_DatumAspect*)(((Handle_Prs3d_DatumAspect*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->SecondAxisAspect());
}

DECL_EXPORT void* Prs3d_DatumAspect_ThirdAxisAspect(void* instance)
{
	Prs3d_DatumAspect* result = (Prs3d_DatumAspect*)(((Handle_Prs3d_DatumAspect*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->ThirdAxisAspect());
}

DECL_EXPORT void Prs3d_DatumAspect_SetDrawFirstAndSecondAxis(void* instance, bool value)
{
	Prs3d_DatumAspect* result = (Prs3d_DatumAspect*)(((Handle_Prs3d_DatumAspect*)instance)->Access());
		result->SetDrawFirstAndSecondAxis(value);
}

DECL_EXPORT bool Prs3d_DatumAspect_DrawFirstAndSecondAxis(void* instance)
{
	Prs3d_DatumAspect* result = (Prs3d_DatumAspect*)(((Handle_Prs3d_DatumAspect*)instance)->Access());
	return 	result->DrawFirstAndSecondAxis();
}

DECL_EXPORT void Prs3d_DatumAspect_SetDrawThirdAxis(void* instance, bool value)
{
	Prs3d_DatumAspect* result = (Prs3d_DatumAspect*)(((Handle_Prs3d_DatumAspect*)instance)->Access());
		result->SetDrawThirdAxis(value);
}

DECL_EXPORT bool Prs3d_DatumAspect_DrawThirdAxis(void* instance)
{
	Prs3d_DatumAspect* result = (Prs3d_DatumAspect*)(((Handle_Prs3d_DatumAspect*)instance)->Access());
	return 	result->DrawThirdAxis();
}

DECL_EXPORT double Prs3d_DatumAspect_FirstAxisLength(void* instance)
{
	Prs3d_DatumAspect* result = (Prs3d_DatumAspect*)(((Handle_Prs3d_DatumAspect*)instance)->Access());
	return 	result->FirstAxisLength();
}

DECL_EXPORT double Prs3d_DatumAspect_SecondAxisLength(void* instance)
{
	Prs3d_DatumAspect* result = (Prs3d_DatumAspect*)(((Handle_Prs3d_DatumAspect*)instance)->Access());
	return 	result->SecondAxisLength();
}

DECL_EXPORT double Prs3d_DatumAspect_ThirdAxisLength(void* instance)
{
	Prs3d_DatumAspect* result = (Prs3d_DatumAspect*)(((Handle_Prs3d_DatumAspect*)instance)->Access());
	return 	result->ThirdAxisLength();
}

DECL_EXPORT void Prs3dDatumAspect_Dtor(void* instance)
{
	delete (Handle_Prs3d_DatumAspect*)instance;
}
