#include "Graphic3dAspectFillArea3d.h"
#include <Graphic3d_AspectFillArea3d.hxx>

#include <Graphic3d_MaterialAspect.hxx>

DECL_EXPORT void* Graphic3d_AspectFillArea3d_Ctor()
{
	return new Handle_Graphic3d_AspectFillArea3d(new Graphic3d_AspectFillArea3d());
}
DECL_EXPORT void* Graphic3d_AspectFillArea3d_Ctor173C01E9(
	int Interior,
	void* InteriorColor,
	void* EdgeColor,
	int EdgeLineType,
	double EdgeWidth,
	void* FrontMaterial,
	void* BackMaterial)
{
		const Aspect_InteriorStyle _Interior =(const Aspect_InteriorStyle )Interior;
		const Quantity_Color &  _InteriorColor =*(const Quantity_Color *)InteriorColor;
		const Quantity_Color &  _EdgeColor =*(const Quantity_Color *)EdgeColor;
		const Aspect_TypeOfLine _EdgeLineType =(const Aspect_TypeOfLine )EdgeLineType;
		const Graphic3d_MaterialAspect &  _FrontMaterial =*(const Graphic3d_MaterialAspect *)FrontMaterial;
		const Graphic3d_MaterialAspect &  _BackMaterial =*(const Graphic3d_MaterialAspect *)BackMaterial;
	return new Handle_Graphic3d_AspectFillArea3d(new Graphic3d_AspectFillArea3d(			
_Interior,			
_InteriorColor,			
_EdgeColor,			
_EdgeLineType,			
EdgeWidth,			
_FrontMaterial,			
_BackMaterial));
}
DECL_EXPORT void Graphic3d_AspectFillArea3d_AllowBackFace(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
 	result->AllowBackFace();
}
DECL_EXPORT void Graphic3d_AspectFillArea3d_SetDistinguishOn(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
 	result->SetDistinguishOn();
}
DECL_EXPORT void Graphic3d_AspectFillArea3d_SetDistinguishOff(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
 	result->SetDistinguishOff();
}
DECL_EXPORT void Graphic3d_AspectFillArea3d_SetEdgeOn(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
 	result->SetEdgeOn();
}
DECL_EXPORT void Graphic3d_AspectFillArea3d_SetEdgeOff(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
 	result->SetEdgeOff();
}
DECL_EXPORT void Graphic3d_AspectFillArea3d_SuppressBackFace(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
 	result->SuppressBackFace();
}
DECL_EXPORT void Graphic3d_AspectFillArea3d_SetTextureMapOn(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
 	result->SetTextureMapOn();
}
DECL_EXPORT void Graphic3d_AspectFillArea3d_SetTextureMapOff(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
 	result->SetTextureMapOff();
}
DECL_EXPORT void Graphic3d_AspectFillArea3d_SetDefaultDegenerateModelE6DFDFE0(
	int aModel,
	double aRatio)
{
		const Aspect_TypeOfDegenerateModel _aModel =(const Aspect_TypeOfDegenerateModel )aModel;
 Graphic3d_AspectFillArea3d::SetDefaultDegenerateModel(			
_aModel,			
aRatio);
}
DECL_EXPORT void Graphic3d_AspectFillArea3d_SetDegenerateModelE6DFDFE0(
	void* instance,
	int aModel,
	double aRatio)
{
		const Aspect_TypeOfDegenerateModel _aModel =(const Aspect_TypeOfDegenerateModel )aModel;
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
 	result->SetDegenerateModel(			
_aModel,			
aRatio);
}
DECL_EXPORT void Graphic3d_AspectFillArea3d_SetPolygonOffsets306E0DFB(
	void* instance,
	int aMode,
	double aFactor,
	double aUnits)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
 	result->SetPolygonOffsets(			
aMode,			
aFactor,			
aUnits);
}
DECL_EXPORT int Graphic3d_AspectFillArea3d_DegenerateModelD82819F3(
	void* instance,
	double* aRatio)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
	return  	result->DegenerateModel(			
*aRatio);
}
DECL_EXPORT int Graphic3d_AspectFillArea3d_DefaultDegenerateModelD82819F3(
	double* aRatio)
{
	return  Graphic3d_AspectFillArea3d::DefaultDegenerateModel(			
*aRatio);
}
//DECL_EXPORT void Graphic3d_AspectFillArea3d_PolygonOffsets306E0DFB(
//	void* instance,
//	int* aMode,
//	double* aFactor,
//	double* aUnits)
//{
//	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
// 	result->PolygonOffsets(			
//*aMode,			
//*aFactor,			
//*aUnits);
//}
DECL_EXPORT bool Graphic3d_AspectFillArea3d_BackFace(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
	return 	result->BackFace();
}

DECL_EXPORT bool Graphic3d_AspectFillArea3d_Distinguish(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
	return 	result->Distinguish();
}

DECL_EXPORT bool Graphic3d_AspectFillArea3d_Edge(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
	return 	result->Edge();
}

DECL_EXPORT void Graphic3d_AspectFillArea3d_SetBackMaterial(void* instance, void* value)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
		result->SetBackMaterial(*(const Graphic3d_MaterialAspect *)value);
}

DECL_EXPORT void* Graphic3d_AspectFillArea3d_BackMaterial(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
	return 	new Graphic3d_MaterialAspect(	result->BackMaterial());
}

DECL_EXPORT void Graphic3d_AspectFillArea3d_SetFrontMaterial(void* instance, void* value)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
		result->SetFrontMaterial(*(const Graphic3d_MaterialAspect *)value);
}

DECL_EXPORT void* Graphic3d_AspectFillArea3d_FrontMaterial(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
	return 	new Graphic3d_MaterialAspect(	result->FrontMaterial());
}

DECL_EXPORT bool Graphic3d_AspectFillArea3d_TextureMapState(void* instance)
{
	Graphic3d_AspectFillArea3d* result = (Graphic3d_AspectFillArea3d*)(((Handle_Graphic3d_AspectFillArea3d*)instance)->Access());
	return 	result->TextureMapState();
}

DECL_EXPORT void Graphic3dAspectFillArea3d_Dtor(void* instance)
{
	delete (Handle_Graphic3d_AspectFillArea3d*)instance;
}
