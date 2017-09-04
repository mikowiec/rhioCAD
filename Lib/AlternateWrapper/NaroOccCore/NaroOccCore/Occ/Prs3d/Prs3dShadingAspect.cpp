#include "Prs3dShadingAspect.h"
#include <Prs3d_ShadingAspect.hxx>

#include <Graphic3d_AspectFillArea3d.hxx>
#include <Graphic3d_MaterialAspect.hxx>
#include <Quantity_Color.hxx>

DECL_EXPORT void* Prs3d_ShadingAspect_Ctor()
{
	return new Handle_Prs3d_ShadingAspect(new Prs3d_ShadingAspect());
}
DECL_EXPORT void Prs3d_ShadingAspect_SetColor91B95C7E(
	void* instance,
	void* aColor,
	int aModel)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
		const Aspect_TypeOfFacingModel _aModel =(const Aspect_TypeOfFacingModel )aModel;
	Prs3d_ShadingAspect* result = (Prs3d_ShadingAspect*)(((Handle_Prs3d_ShadingAspect*)instance)->Access());
 	result->SetColor(			
_aColor,			
_aModel);
}
DECL_EXPORT void Prs3d_ShadingAspect_SetColor6AB9C7E3(
	void* instance,
	int aColor,
	int aModel)
{
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
		const Aspect_TypeOfFacingModel _aModel =(const Aspect_TypeOfFacingModel )aModel;
	Prs3d_ShadingAspect* result = (Prs3d_ShadingAspect*)(((Handle_Prs3d_ShadingAspect*)instance)->Access());
 	result->SetColor(			
_aColor,			
_aModel);
}
DECL_EXPORT void Prs3d_ShadingAspect_SetMaterial4216C4F1(
	void* instance,
	void* aMaterial,
	int aModel)
{
		const Graphic3d_MaterialAspect &  _aMaterial =*(const Graphic3d_MaterialAspect *)aMaterial;
		const Aspect_TypeOfFacingModel _aModel =(const Aspect_TypeOfFacingModel )aModel;
	Prs3d_ShadingAspect* result = (Prs3d_ShadingAspect*)(((Handle_Prs3d_ShadingAspect*)instance)->Access());
 	result->SetMaterial(			
_aMaterial,			
_aModel);
}
DECL_EXPORT void Prs3d_ShadingAspect_SetMaterialC75397AB(
	void* instance,
	int aMaterial,
	int aModel)
{
		const Graphic3d_NameOfMaterial _aMaterial =(const Graphic3d_NameOfMaterial )aMaterial;
		const Aspect_TypeOfFacingModel _aModel =(const Aspect_TypeOfFacingModel )aModel;
	Prs3d_ShadingAspect* result = (Prs3d_ShadingAspect*)(((Handle_Prs3d_ShadingAspect*)instance)->Access());
 	result->SetMaterial(			
_aMaterial,			
_aModel);
}
DECL_EXPORT void Prs3d_ShadingAspect_SetTransparencyEE7B4701(
	void* instance,
	double aValue,
	int aModel)
{
		const Aspect_TypeOfFacingModel _aModel =(const Aspect_TypeOfFacingModel )aModel;
	Prs3d_ShadingAspect* result = (Prs3d_ShadingAspect*)(((Handle_Prs3d_ShadingAspect*)instance)->Access());
 	result->SetTransparency(			
aValue,			
_aModel);
}
DECL_EXPORT void* Prs3d_ShadingAspect_ColorAE582B9F(
	void* instance,
	int aModel)
{
		const Aspect_TypeOfFacingModel _aModel =(const Aspect_TypeOfFacingModel )aModel;
	Prs3d_ShadingAspect* result = (Prs3d_ShadingAspect*)(((Handle_Prs3d_ShadingAspect*)instance)->Access());
	return new Quantity_Color( 	result->Color(			
_aModel));
}
DECL_EXPORT void* Prs3d_ShadingAspect_MaterialAE582B9F(
	void* instance,
	int aModel)
{
		const Aspect_TypeOfFacingModel _aModel =(const Aspect_TypeOfFacingModel )aModel;
	Prs3d_ShadingAspect* result = (Prs3d_ShadingAspect*)(((Handle_Prs3d_ShadingAspect*)instance)->Access());
	return new Graphic3d_MaterialAspect( 	result->Material(			
_aModel));
}
DECL_EXPORT double Prs3d_ShadingAspect_TransparencyAE582B9F(
	void* instance,
	int aModel)
{
		const Aspect_TypeOfFacingModel _aModel =(const Aspect_TypeOfFacingModel )aModel;
	Prs3d_ShadingAspect* result = (Prs3d_ShadingAspect*)(((Handle_Prs3d_ShadingAspect*)instance)->Access());
	return  	result->Transparency(			
_aModel);
}
DECL_EXPORT void Prs3d_ShadingAspect_SetAspect(void* instance, void* value)
{
	Prs3d_ShadingAspect* result = (Prs3d_ShadingAspect*)(((Handle_Prs3d_ShadingAspect*)instance)->Access());
		result->SetAspect(*(const Handle_Graphic3d_AspectFillArea3d *)value);
}

DECL_EXPORT void* Prs3d_ShadingAspect_Aspect(void* instance)
{
	Prs3d_ShadingAspect* result = (Prs3d_ShadingAspect*)(((Handle_Prs3d_ShadingAspect*)instance)->Access());
	return 	new Handle_Graphic3d_AspectFillArea3d(	result->Aspect());
}

DECL_EXPORT void Prs3dShadingAspect_Dtor(void* instance)
{
	delete (Handle_Prs3d_ShadingAspect*)instance;
}
