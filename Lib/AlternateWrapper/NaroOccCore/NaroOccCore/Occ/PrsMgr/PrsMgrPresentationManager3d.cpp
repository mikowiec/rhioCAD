#include "PrsMgrPresentationManager3d.h"
#include <PrsMgr_PresentationManager3d.hxx>

#include <Graphic3d_StructureManager.hxx>
#include <PrsMgr_Presentation3d.hxx>

DECL_EXPORT void* PrsMgr_PresentationManager3d_Ctor6B9CC1AA(
	void* aStructureManager)
{
		const Handle_Graphic3d_StructureManager&  _aStructureManager =*(const Handle_Graphic3d_StructureManager *)aStructureManager;
	return new Handle_PrsMgr_PresentationManager3d(new PrsMgr_PresentationManager3d(			
_aStructureManager));
}
DECL_EXPORT void PrsMgr_PresentationManager3d_ColorB83441D9(
	void* instance,
	void* aPresentableObject,
	int aColor,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
 	result->Color(			
_aPresentableObject,			
_aColor,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager3d_BoundBox6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
 	result->BoundBox(			
_aPresentableObject,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager3d_BeginDraw(void* instance)
{
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
 	result->BeginDraw();
}
DECL_EXPORT void PrsMgr_PresentationManager3d_EndDrawAD710B01(
	void* instance,
	void* aView,
	bool DoubleBuffer)
{
		const Handle_Viewer_View&  _aView =*(const Handle_Viewer_View *)aView;
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
 	result->EndDraw(			
_aView,			
DoubleBuffer);
}
DECL_EXPORT void PrsMgr_PresentationManager3d_ConnectDA51193F(
	void* instance,
	void* aPresentableObject,
	void* anOtherObject,
	int aMode,
	int anOtherMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
		const Handle_PrsMgr_PresentableObject&  _anOtherObject =*(const Handle_PrsMgr_PresentableObject *)anOtherObject;
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
 	result->Connect(			
_aPresentableObject,			
_anOtherObject,			
aMode,			
anOtherMode);
}
DECL_EXPORT void PrsMgr_PresentationManager3d_Transform17D81909(
	void* instance,
	void* aPresentableObject,
	void* aTransformation,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
		const Handle_Geom_Transformation&  _aTransformation =*(const Handle_Geom_Transformation *)aTransformation;
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
 	result->Transform(			
_aPresentableObject,			
_aTransformation,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager3d_PlaceDCA8B26(
	void* instance,
	void* aPresentableObject,
	double X,
	double Y,
	double Z,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
 	result->Place(			
_aPresentableObject,			
X,			
Y,			
Z,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager3d_Multiply17D81909(
	void* instance,
	void* aPresentableObject,
	void* aTransformation,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
		const Handle_Geom_Transformation&  _aTransformation =*(const Handle_Geom_Transformation *)aTransformation;
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
 	result->Multiply(			
_aPresentableObject,			
_aTransformation,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager3d_MoveDCA8B26(
	void* instance,
	void* aPresentableObject,
	double X,
	double Y,
	double Z,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
 	result->Move(			
_aPresentableObject,			
X,			
Y,			
Z,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager3d_SetShadingAspect4A55E6F9(
	void* instance,
	void* aPresentableObject,
	int aColor,
	int aMaterial,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
		const Graphic3d_NameOfMaterial _aMaterial =(const Graphic3d_NameOfMaterial )aMaterial;
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
 	result->SetShadingAspect(			
_aPresentableObject,			
_aColor,			
_aMaterial,			
aMode);
}
DECL_EXPORT void PrsMgr_PresentationManager3d_SetShadingAspect2BCEAF8F(
	void* instance,
	void* aPresentableObject,
	void* aShadingAspect,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
		const Handle_Prs3d_ShadingAspect&  _aShadingAspect =*(const Handle_Prs3d_ShadingAspect *)aShadingAspect;
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
 	result->SetShadingAspect(			
_aPresentableObject,			
_aShadingAspect,			
aMode);
}
DECL_EXPORT void* PrsMgr_PresentationManager3d_CastPresentation6305B33D(
	void* instance,
	void* aPresentableObject,
	int aMode)
{
		const Handle_PrsMgr_PresentableObject&  _aPresentableObject =*(const Handle_PrsMgr_PresentableObject *)aPresentableObject;
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
	return new Handle_PrsMgr_Presentation3d( 	result->CastPresentation(			
_aPresentableObject,			
aMode));
}
DECL_EXPORT bool PrsMgr_PresentationManager3d_Is3D(void* instance)
{
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
	return 	result->Is3D();
}

DECL_EXPORT void* PrsMgr_PresentationManager3d_StructureManager(void* instance)
{
	PrsMgr_PresentationManager3d* result = (PrsMgr_PresentationManager3d*)(((Handle_PrsMgr_PresentationManager3d*)instance)->Access());
	return 	new Handle_Graphic3d_StructureManager(	result->StructureManager());
}

DECL_EXPORT void PrsMgrPresentationManager3d_Dtor(void* instance)
{
	delete (Handle_PrsMgr_PresentationManager3d*)instance;
}
