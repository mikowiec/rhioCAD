#include "AISInteractiveContext.h"
#include <AIS_InteractiveContext.hxx>

#include <AIS_InteractiveObject.hxx>
#include <Prs3d_Drawer.hxx>
#include <Prs3d_LineAspect.hxx>
#include <PrsMgr_PresentationManager3d.hxx>
#include <SelectMgr_EntityOwner.hxx>
#include <SelectMgr_SelectionManager.hxx>
#include <Standard_Transient.hxx>
#include <StdSelect_ViewerSelector3d.hxx>
#include <TCollection_AsciiString.hxx>
#include <TopLoc_Location.hxx>
#include <TopoDS_Shape.hxx>
#include <V3d_Viewer.hxx>

DECL_EXPORT void* AIS_InteractiveContext_Ctor79560492(
	void* MainViewer)
{
		const Handle_V3d_Viewer&  _MainViewer =*(const Handle_V3d_Viewer *)MainViewer;
	return new Handle_AIS_InteractiveContext(new AIS_InteractiveContext(			
_MainViewer));
}
DECL_EXPORT void* AIS_InteractiveContext_Ctor27F4A3E3(
	void* MainViewer,
	void* Collector)
{
		const Handle_V3d_Viewer&  _MainViewer =*(const Handle_V3d_Viewer *)MainViewer;
		const Handle_V3d_Viewer&  _Collector =*(const Handle_V3d_Viewer *)Collector;
	return new Handle_AIS_InteractiveContext(new AIS_InteractiveContext(			
_MainViewer,			
_Collector));
}
DECL_EXPORT void AIS_InteractiveContext_Delete(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Delete();
}
DECL_EXPORT void AIS_InteractiveContext_CloseCollector(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->CloseCollector();
}
DECL_EXPORT void AIS_InteractiveContext_OpenCollector(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->OpenCollector();
}
DECL_EXPORT void AIS_InteractiveContext_Display7BDA0103(
	void* instance,
	void* anIobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _anIobj =*(const Handle_AIS_InteractiveObject *)anIobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Display(			
_anIobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_DisplayBB87E00C(
	void* instance,
	void* anIobj,
	int amode,
	int aSelectionMode,
	bool updateviewer,
	bool allowdecomposition)
{
		const Handle_AIS_InteractiveObject&  _anIobj =*(const Handle_AIS_InteractiveObject *)anIobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Display(			
_anIobj,			
amode,			
aSelectionMode,			
updateviewer,			
allowdecomposition);
}
DECL_EXPORT void AIS_InteractiveContext_LoadFDB02EB(
	void* instance,
	void* aniobj,
	int SelectionMode,
	bool AllowDecomp)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Load(			
_aniobj,			
SelectionMode,			
AllowDecomp);
}
DECL_EXPORT void AIS_InteractiveContext_EraseB05E0FC3(
	void* instance,
	void* aniobj,
	bool updateviewer,
	bool PutInCollector)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Erase(			
_aniobj,			
updateviewer,			
PutInCollector);
}
DECL_EXPORT void AIS_InteractiveContext_EraseModeFDB02EB(
	void* instance,
	void* aniobj,
	int aMode,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->EraseMode(			
_aniobj,			
aMode,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_EraseAllAE8C3818(
	void* instance,
	bool PutInCollector,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->EraseAll(			
PutInCollector,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_DisplayAllAE8C3818(
	void* instance,
	bool OnlyFromCollector,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->DisplayAll(			
OnlyFromCollector,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_DisplayFromCollector7BDA0103(
	void* instance,
	void* anIObj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _anIObj =*(const Handle_AIS_InteractiveObject *)anIObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->DisplayFromCollector(			
_anIObj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_EraseSelectedAE8C3818(
	void* instance,
	bool PutInCollector,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->EraseSelected(			
PutInCollector,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_DisplaySelected461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->DisplaySelected(			
updateviewer);
}
DECL_EXPORT bool AIS_InteractiveContext_KeepTemporary4F47E777(
	void* instance,
	void* anIObj,
	int InWhichLocal)
{
		const Handle_AIS_InteractiveObject&  _anIObj =*(const Handle_AIS_InteractiveObject *)anIObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->KeepTemporary(			
_anIObj,			
InWhichLocal);
}
DECL_EXPORT void AIS_InteractiveContext_Clear7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Clear(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_ClearPrsFDB02EB(
	void* instance,
	void* aniobj,
	int aMode,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ClearPrs(			
_aniobj,			
aMode,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_Remove7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Remove(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_RemoveAll461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->RemoveAll(			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_Hilight7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Hilight(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_HilightWithColor80F07260(
	void* instance,
	void* aniobj,
	int aCol,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
		const Quantity_NameOfColor _aCol =(const Quantity_NameOfColor )aCol;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->HilightWithColor(			
_aniobj,			
_aCol,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_Unhilight7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Unhilight(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetDisplayPriority4F47E777(
	void* instance,
	void* anIobj,
	int aPriority)
{
		const Handle_AIS_InteractiveObject&  _anIobj =*(const Handle_AIS_InteractiveObject *)anIobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetDisplayPriority(			
_anIobj,			
aPriority);
}
DECL_EXPORT void AIS_InteractiveContext_SetZLayer4F47E777(
	void* instance,
	void* theIObj,
	int theLayerId)
{
		const Handle_AIS_InteractiveObject&  _theIObj =*(const Handle_AIS_InteractiveObject *)theIObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetZLayer(			
_theIObj,			
theLayerId);
}
DECL_EXPORT int AIS_InteractiveContext_GetZLayer5DD8A2CA(
	void* instance,
	void* theIObj)
{
		const Handle_AIS_InteractiveObject&  _theIObj =*(const Handle_AIS_InteractiveObject *)theIObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->GetZLayer(			
_theIObj);
}
DECL_EXPORT void AIS_InteractiveContext_RedisplayB05E0FC3(
	void* instance,
	void* aniobj,
	bool updateviewer,
	bool allmodes)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Redisplay(			
_aniobj,			
updateviewer,			
allmodes);
}
DECL_EXPORT void AIS_InteractiveContext_Redisplay766D350B(
	void* instance,
	int aTypeOfObject,
	int Signature,
	bool updateviewer)
{
		const AIS_KindOfInteractive _aTypeOfObject =(const AIS_KindOfInteractive )aTypeOfObject;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Redisplay(			
_aTypeOfObject,			
Signature,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_RecomputePrsOnlyB05E0FC3(
	void* instance,
	void* anIobj,
	bool updateviewer,
	bool allmodes)
{
		const Handle_AIS_InteractiveObject&  _anIobj =*(const Handle_AIS_InteractiveObject *)anIobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->RecomputePrsOnly(			
_anIobj,			
updateviewer,			
allmodes);
}
DECL_EXPORT void AIS_InteractiveContext_RecomputeSelectionOnly5DD8A2CA(
	void* instance,
	void* anIObj)
{
		const Handle_AIS_InteractiveObject&  _anIObj =*(const Handle_AIS_InteractiveObject *)anIObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->RecomputeSelectionOnly(			
_anIObj);
}
DECL_EXPORT void AIS_InteractiveContext_Update7BDA0103(
	void* instance,
	void* anIobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _anIobj =*(const Handle_AIS_InteractiveObject *)anIobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Update(			
_anIobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetDisplayModeFDB02EB(
	void* instance,
	void* aniobj,
	int aMode,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetDisplayMode(			
_aniobj,			
aMode,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_UnsetDisplayMode7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UnsetDisplayMode(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetSelectionMode4F47E777(
	void* instance,
	void* aniobj,
	int aMode)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetSelectionMode(			
_aniobj,			
aMode);
}
DECL_EXPORT void AIS_InteractiveContext_UnsetSelectionMode5DD8A2CA(
	void* instance,
	void* aniobj)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UnsetSelectionMode(			
_aniobj);
}
DECL_EXPORT void AIS_InteractiveContext_SetLocation852B9922(
	void* instance,
	void* aniobj,
	void* aLocation)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
		const TopLoc_Location &  _aLocation =*(const TopLoc_Location *)aLocation;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetLocation(			
_aniobj,			
_aLocation);
}
DECL_EXPORT void AIS_InteractiveContext_ResetLocation5DD8A2CA(
	void* instance,
	void* aniobj)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ResetLocation(			
_aniobj);
}
DECL_EXPORT bool AIS_InteractiveContext_HasLocation5DD8A2CA(
	void* instance,
	void* aniobj)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->HasLocation(			
_aniobj);
}
DECL_EXPORT void* AIS_InteractiveContext_Location5DD8A2CA(
	void* instance,
	void* aniobj)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return new TopLoc_Location( 	result->Location(			
_aniobj));
}
DECL_EXPORT void AIS_InteractiveContext_SetCurrentFacingModelCD8717A5(
	void* instance,
	void* aniobj,
	int aModel)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
		const Aspect_TypeOfFacingModel _aModel =(const Aspect_TypeOfFacingModel )aModel;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetCurrentFacingModel(			
_aniobj,			
_aModel);
}
DECL_EXPORT void AIS_InteractiveContext_SetColor80F07260(
	void* instance,
	void* aniobj,
	int aColor,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
		const Quantity_NameOfColor _aColor =(const Quantity_NameOfColor )aColor;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetColor(			
_aniobj,			
_aColor,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetColorCCA19205(
	void* instance,
	void* aniobj,
	void* aColor,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetColor(			
_aniobj,			
_aColor,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_UnsetColor7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UnsetColor(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetWidthADEC6198(
	void* instance,
	void* aniobj,
	double aValue,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetWidth(			
_aniobj,			
aValue,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_UnsetWidth7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UnsetWidth(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetMaterial4D782AAE(
	void* instance,
	void* aniobj,
	int aName,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
		const Graphic3d_NameOfMaterial _aName =(const Graphic3d_NameOfMaterial )aName;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetMaterial(			
_aniobj,			
_aName,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_UnsetMaterial7BDA0103(
	void* instance,
	void* anObj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _anObj =*(const Handle_AIS_InteractiveObject *)anObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UnsetMaterial(			
_anObj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetTransparencyADEC6198(
	void* instance,
	void* aniobj,
	double aValue,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetTransparency(			
_aniobj,			
aValue,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_UnsetTransparency7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UnsetTransparency(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetDegenerateModel157E506C(
	void* instance,
	void* aniobj,
	int aModel,
	double aRatio)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
		const Aspect_TypeOfDegenerateModel _aModel =(const Aspect_TypeOfDegenerateModel )aModel;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetDegenerateModel(			
_aniobj,			
_aModel,			
aRatio);
}
DECL_EXPORT void AIS_InteractiveContext_SetDegenerateModelE6DFDFE0(
	void* instance,
	int aModel,
	double aSkipRatio)
{
		const Aspect_TypeOfDegenerateModel _aModel =(const Aspect_TypeOfDegenerateModel )aModel;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetDegenerateModel(			
_aModel,			
aSkipRatio);
}
DECL_EXPORT void AIS_InteractiveContext_SetLocalAttributes6233D91F(
	void* instance,
	void* aniobj,
	void* aDrawer,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
		const Handle_AIS_Drawer&  _aDrawer =*(const Handle_AIS_Drawer *)aDrawer;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetLocalAttributes(			
_aniobj,			
_aDrawer,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_UnsetLocalAttributes7BDA0103(
	void* instance,
	void* anObj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _anObj =*(const Handle_AIS_InteractiveObject *)anObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UnsetLocalAttributes(			
_anObj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetPolygonOffsets6907E6A5(
	void* instance,
	void* anObj,
	int aMode,
	double aFactor,
	double aUnits,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _anObj =*(const Handle_AIS_InteractiveObject *)anObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetPolygonOffsets(			
_anObj,			
aMode,			
aFactor,			
aUnits,			
updateviewer);
}
DECL_EXPORT bool AIS_InteractiveContext_HasPolygonOffsets5DD8A2CA(
	void* instance,
	void* anObj)
{
		const Handle_AIS_InteractiveObject&  _anObj =*(const Handle_AIS_InteractiveObject *)anObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->HasPolygonOffsets(			
_anObj);
}
//DECL_EXPORT void AIS_InteractiveContext_PolygonOffsets330EF62(
//	void* instance,
//	void* anObj,
//	int* aMode,
//	double* aFactor,
//	double* aUnits)
//{
//		const Handle_AIS_InteractiveObject&  _anObj =*(const Handle_AIS_InteractiveObject *)anObj;
//	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
// 	result->PolygonOffsets(			
//_anObj,			
//*aMode,			
//*aFactor,			
//*aUnits);
//}
DECL_EXPORT void AIS_InteractiveContext_SetTrihedronSizeC85E5E0F(
	void* instance,
	double aSize,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetTrihedronSize(			
aSize,			
updateviewer);
}
DECL_EXPORT double AIS_InteractiveContext_TrihedronSize(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->TrihedronSize();
}
DECL_EXPORT bool AIS_InteractiveContext_PlaneSize9F0E714F(
	void* instance,
	double* XSize,
	double* YSize)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->PlaneSize(			
*XSize,			
*YSize);
}
DECL_EXPORT int AIS_InteractiveContext_DisplayStatus5DD8A2CA(
	void* instance,
	void* anIobj)
{
		const Handle_AIS_InteractiveObject&  _anIobj =*(const Handle_AIS_InteractiveObject *)anIobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->DisplayStatus(			
_anIobj);
}
DECL_EXPORT bool AIS_InteractiveContext_IsDisplayed5DD8A2CA(
	void* instance,
	void* anIobj)
{
		const Handle_AIS_InteractiveObject&  _anIobj =*(const Handle_AIS_InteractiveObject *)anIobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->IsDisplayed(			
_anIobj);
}
DECL_EXPORT bool AIS_InteractiveContext_IsDisplayed4F47E777(
	void* instance,
	void* aniobj,
	int aMode)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->IsDisplayed(			
_aniobj,			
aMode);
}
DECL_EXPORT bool AIS_InteractiveContext_IsInCollector5DD8A2CA(
	void* instance,
	void* anIObj)
{
		const Handle_AIS_InteractiveObject&  _anIObj =*(const Handle_AIS_InteractiveObject *)anIObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->IsInCollector(			
_anIObj);
}
DECL_EXPORT int AIS_InteractiveContext_DisplayPriority5DD8A2CA(
	void* instance,
	void* anIobj)
{
		const Handle_AIS_InteractiveObject&  _anIobj =*(const Handle_AIS_InteractiveObject *)anIobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->DisplayPriority(			
_anIobj);
}
DECL_EXPORT bool AIS_InteractiveContext_HasColor5DD8A2CA(
	void* instance,
	void* aniobj)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->HasColor(			
_aniobj);
}
DECL_EXPORT int AIS_InteractiveContext_Color5DD8A2CA(
	void* instance,
	void* aniobj)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->Color(			
_aniobj);
}
DECL_EXPORT void AIS_InteractiveContext_ColorE6084039(
	void* instance,
	void* aniobj,
	void* acolor)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
		 Quantity_Color &  _acolor =*( Quantity_Color *)acolor;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Color(			
_aniobj,			
_acolor);
}
DECL_EXPORT double AIS_InteractiveContext_Width5DD8A2CA(
	void* instance,
	void* aniobj)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->Width(			
_aniobj);
}
DECL_EXPORT void AIS_InteractiveContext_StatusE16287D5(
	void* instance,
	void* anObj,
	void* astatus)
{
		const Handle_AIS_InteractiveObject&  _anObj =*(const Handle_AIS_InteractiveObject *)anObj;
		 TCollection_ExtendedString &  _astatus =*( TCollection_ExtendedString *)astatus;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Status(			
_anObj,			
_astatus);
}
DECL_EXPORT void AIS_InteractiveContext_UpdateCurrentViewer(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UpdateCurrentViewer();
}
DECL_EXPORT void AIS_InteractiveContext_UpdateCollector(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UpdateCollector();
}
DECL_EXPORT int AIS_InteractiveContext_DisplayMode(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->DisplayMode();
}
DECL_EXPORT int AIS_InteractiveContext_SelectionColor(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->SelectionColor();
}
DECL_EXPORT void AIS_InteractiveContext_SelectionColor48F4F471(
	void* instance,
	int aCol)
{
		const Quantity_NameOfColor _aCol =(const Quantity_NameOfColor )aCol;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SelectionColor(			
_aCol);
}
DECL_EXPORT void AIS_InteractiveContext_SetDisplayMode989C8794(
	void* instance,
	int AMode,
	bool updateviewer)
{
		const AIS_DisplayMode _AMode =(const AIS_DisplayMode )AMode;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetDisplayMode(			
_AMode,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetDeviationCoefficientADEC6198(
	void* instance,
	void* aniobj,
	double aCoefficient,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetDeviationCoefficient(			
_aniobj,			
aCoefficient,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetDeviationAngleADEC6198(
	void* instance,
	void* aniobj,
	double anAngle,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetDeviationAngle(			
_aniobj,			
anAngle,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetAngleAndDeviationADEC6198(
	void* instance,
	void* aniobj,
	double anAngle,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetAngleAndDeviation(			
_aniobj,			
anAngle,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetHLRDeviationCoefficientADEC6198(
	void* instance,
	void* aniobj,
	double aCoefficient,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetHLRDeviationCoefficient(			
_aniobj,			
aCoefficient,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetHLRDeviationAngleADEC6198(
	void* instance,
	void* aniobj,
	double anAngle,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetHLRDeviationAngle(			
_aniobj,			
anAngle,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetHLRAngleAndDeviationADEC6198(
	void* instance,
	void* aniobj,
	double anAngle,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetHLRAngleAndDeviation(			
_aniobj,			
anAngle,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetDeviationCoefficientD82819F3(
	void* instance,
	double aCoefficient)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetDeviationCoefficient(			
aCoefficient);
}
DECL_EXPORT double AIS_InteractiveContext_DeviationCoefficient(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->DeviationCoefficient();
}
DECL_EXPORT void AIS_InteractiveContext_SetDeviationAngleD82819F3(
	void* instance,
	double anAngle)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetDeviationAngle(			
anAngle);
}
DECL_EXPORT double AIS_InteractiveContext_DeviationAngle(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->DeviationAngle();
}
DECL_EXPORT void AIS_InteractiveContext_SetHLRDeviationCoefficientD82819F3(
	void* instance,
	double aCoefficient)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetHLRDeviationCoefficient(			
aCoefficient);
}
DECL_EXPORT double AIS_InteractiveContext_HLRDeviationCoefficient(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->HLRDeviationCoefficient();
}
DECL_EXPORT void AIS_InteractiveContext_SetHLRAngleAndDeviationD82819F3(
	void* instance,
	double anAngle)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetHLRAngleAndDeviation(			
anAngle);
}
DECL_EXPORT void AIS_InteractiveContext_EnableDrawHiddenLine(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->EnableDrawHiddenLine();
}
DECL_EXPORT void AIS_InteractiveContext_DisableDrawHiddenLine(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->DisableDrawHiddenLine();
}
DECL_EXPORT void AIS_InteractiveContext_SetIsoNumber818B71C9(
	void* instance,
	int NbIsos,
	int WhichIsos)
{
		const AIS_TypeOfIso _WhichIsos =(const AIS_TypeOfIso )WhichIsos;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetIsoNumber(			
NbIsos,			
_WhichIsos);
}
DECL_EXPORT int AIS_InteractiveContext_IsoNumber4113B908(
	void* instance,
	int WhichIsos)
{
		const AIS_TypeOfIso _WhichIsos =(const AIS_TypeOfIso )WhichIsos;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->IsoNumber(			
_WhichIsos);
}
DECL_EXPORT void AIS_InteractiveContext_IsoOnPlane461FC46A(
	void* instance,
	bool SwitchOn)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->IsoOnPlane(			
SwitchOn);
}
DECL_EXPORT bool AIS_InteractiveContext_IsoOnPlane(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->IsoOnPlane();
}
DECL_EXPORT void AIS_InteractiveContext_SetSelectedAspectBD651AAF(
	void* instance,
	void* anAspect,
	bool globalChange,
	bool updateViewer)
{
		const Handle_Prs3d_BasicAspect&  _anAspect =*(const Handle_Prs3d_BasicAspect *)anAspect;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetSelectedAspect(			
_anAspect,			
globalChange,			
updateViewer);
}
DECL_EXPORT int AIS_InteractiveContext_MoveTo556D776C(
	void* instance,
	int XPix,
	int YPix,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->MoveTo(			
XPix,			
YPix,			
_aView);
}
DECL_EXPORT int AIS_InteractiveContext_HilightNextDetected36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->HilightNextDetected(			
_aView);
}
DECL_EXPORT int AIS_InteractiveContext_HilightPreviousDetected36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->HilightPreviousDetected(			
_aView);
}
DECL_EXPORT int AIS_InteractiveContext_Select92079733(
	void* instance,
	int XPMin,
	int YPMin,
	int XPMax,
	int YPMax,
	void* aView,
	bool updateviewer)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->Select(			
XPMin,			
YPMin,			
XPMax,			
YPMax,			
_aView,			
updateviewer);
}
DECL_EXPORT int AIS_InteractiveContext_Select461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->Select(			
updateviewer);
}
DECL_EXPORT int AIS_InteractiveContext_ShiftSelect461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->ShiftSelect(			
updateviewer);
}
DECL_EXPORT int AIS_InteractiveContext_ShiftSelect92079733(
	void* instance,
	int XPMin,
	int YPMin,
	int XPMax,
	int YPMax,
	void* aView,
	bool updateviewer)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->ShiftSelect(			
XPMin,			
YPMin,			
XPMax,			
YPMax,			
_aView,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetCurrentObject7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetCurrentObject(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_AddOrRemoveCurrentObject7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->AddOrRemoveCurrentObject(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_UpdateCurrent(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UpdateCurrent();
}
DECL_EXPORT void AIS_InteractiveContext_SetOkCurrent(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetOkCurrent();
}
DECL_EXPORT bool AIS_InteractiveContext_IsCurrent5DD8A2CA(
	void* instance,
	void* aniobj)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->IsCurrent(			
_aniobj);
}
DECL_EXPORT void AIS_InteractiveContext_InitCurrent(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->InitCurrent();
}
DECL_EXPORT void AIS_InteractiveContext_NextCurrent(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->NextCurrent();
}
DECL_EXPORT void AIS_InteractiveContext_HilightCurrents461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->HilightCurrents(			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_UnhilightCurrents461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UnhilightCurrents(			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_ClearCurrents461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ClearCurrents(			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetSelected7BDA0103(
	void* instance,
	void* aniObj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniObj =*(const Handle_AIS_InteractiveObject *)aniObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetSelected(			
_aniObj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SetSelectedCurrent(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetSelectedCurrent();
}
DECL_EXPORT void AIS_InteractiveContext_UpdateSelected461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UpdateSelected(			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_AddOrRemoveSelected7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->AddOrRemoveSelected(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_HilightSelected461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->HilightSelected(			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_UnhilightSelected461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UnhilightSelected(			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_ClearSelected461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ClearSelected(			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_AddOrRemoveSelected5E7DD5C8(
	void* instance,
	void* aShape,
	bool updateviewer)
{
		const TopoDS_Shape &  _aShape =*(const TopoDS_Shape *)aShape;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->AddOrRemoveSelected(			
_aShape,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_AddOrRemoveSelected26C4ECD2(
	void* instance,
	void* anOwner,
	bool updateviewer)
{
		const Handle_SelectMgr_EntityOwner&  _anOwner =*(const Handle_SelectMgr_EntityOwner *)anOwner;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->AddOrRemoveSelected(			
_anOwner,			
updateviewer);
}
DECL_EXPORT bool AIS_InteractiveContext_IsSelected5DD8A2CA(
	void* instance,
	void* aniobj)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->IsSelected(			
_aniobj);
}
DECL_EXPORT void AIS_InteractiveContext_InitSelected(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->InitSelected();
}
DECL_EXPORT void AIS_InteractiveContext_NextSelected(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->NextSelected();
}
DECL_EXPORT void AIS_InteractiveContext_InitDetected(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->InitDetected();
}
DECL_EXPORT void AIS_InteractiveContext_NextDetected(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->NextDetected();
}
DECL_EXPORT int AIS_InteractiveContext_OpenLocalContextA58FCEEB(
	void* instance,
	bool UseDisplayedObjects,
	bool AllowShapeDecomposition,
	bool AcceptEraseOfObjects,
	bool BothViewers)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->OpenLocalContext(			
UseDisplayedObjects,			
AllowShapeDecomposition,			
AcceptEraseOfObjects,			
BothViewers);
}
DECL_EXPORT void AIS_InteractiveContext_CloseLocalContext898DAFFC(
	void* instance,
	int Index,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->CloseLocalContext(			
Index,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_CloseAllContexts461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->CloseAllContexts(			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_ResetOriginalState461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ResetOriginalState(			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_ClearLocalContext4E21E443(
	void* instance,
	int TheMode)
{
		const AIS_ClearMode _TheMode =(const AIS_ClearMode )TheMode;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ClearLocalContext(			
_TheMode);
}
DECL_EXPORT void AIS_InteractiveContext_UseDisplayedObjects(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->UseDisplayedObjects();
}
DECL_EXPORT void AIS_InteractiveContext_NotUseDisplayedObjects(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->NotUseDisplayedObjects();
}
DECL_EXPORT bool AIS_InteractiveContext_ImmediateAdd4F47E777(
	void* instance,
	void* anIObj,
	int aMode)
{
		const Handle_AIS_InteractiveObject&  _anIObj =*(const Handle_AIS_InteractiveObject *)anIObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->ImmediateAdd(			
_anIObj,			
aMode);
}
DECL_EXPORT bool AIS_InteractiveContext_ImmediateRemove4F47E777(
	void* instance,
	void* anIObj,
	int aMode)
{
		const Handle_AIS_InteractiveObject&  _anIObj =*(const Handle_AIS_InteractiveObject *)anIObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->ImmediateRemove(			
_anIObj,			
aMode);
}
DECL_EXPORT bool AIS_InteractiveContext_EndImmediateDraw3F19241F(
	void* instance,
	void* aView,
	bool DoubleBuf)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->EndImmediateDraw(			
_aView,			
DoubleBuf);
}
DECL_EXPORT bool AIS_InteractiveContext_EndImmediateDraw461FC46A(
	void* instance,
	bool DoubleBuf)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->EndImmediateDraw(			
DoubleBuf);
}
DECL_EXPORT void AIS_InteractiveContext_Drag5E8F49C8(
	void* instance,
	void* aView,
	void* anObject,
	void* aTranformation,
	bool postConcatenate,
	bool update,
	bool zBuffer)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
		const Handle_AIS_InteractiveObject&  _anObject =*(const Handle_AIS_InteractiveObject *)anObject;
		const Handle_Geom_Transformation&  _aTranformation =*(const Handle_Geom_Transformation *)aTranformation;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Drag(			
_aView,			
_anObject,			
_aTranformation,			
postConcatenate,			
update,			
zBuffer);
}
DECL_EXPORT void AIS_InteractiveContext_Activate4F47E777(
	void* instance,
	void* anIobj,
	int aMode)
{
		const Handle_AIS_InteractiveObject&  _anIobj =*(const Handle_AIS_InteractiveObject *)anIobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Activate(			
_anIobj,			
aMode);
}
DECL_EXPORT void AIS_InteractiveContext_Deactivate5DD8A2CA(
	void* instance,
	void* anIObj)
{
		const Handle_AIS_InteractiveObject&  _anIObj =*(const Handle_AIS_InteractiveObject *)anIObj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Deactivate(			
_anIObj);
}
DECL_EXPORT void AIS_InteractiveContext_Deactivate4F47E777(
	void* instance,
	void* anIobj,
	int aMode)
{
		const Handle_AIS_InteractiveObject&  _anIobj =*(const Handle_AIS_InteractiveObject *)anIobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->Deactivate(			
_anIobj,			
aMode);
}
DECL_EXPORT void AIS_InteractiveContext_SetShapeDecomposition7BDA0103(
	void* instance,
	void* anIobj,
	bool aStatus)
{
		const Handle_AIS_InteractiveObject&  _anIobj =*(const Handle_AIS_InteractiveObject *)anIobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetShapeDecomposition(			
_anIobj,			
aStatus);
}
DECL_EXPORT void AIS_InteractiveContext_SetTemporaryAttributesA5FB0AF4(
	void* instance,
	void* anObj,
	void* aDrawer,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _anObj =*(const Handle_AIS_InteractiveObject *)anObj;
		const Handle_Prs3d_Drawer&  _aDrawer =*(const Handle_Prs3d_Drawer *)aDrawer;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SetTemporaryAttributes(			
_anObj,			
_aDrawer,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SubIntensityOn7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SubIntensityOn(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SubIntensityOff7BDA0103(
	void* instance,
	void* aniobj,
	bool updateviewer)
{
		const Handle_AIS_InteractiveObject&  _aniobj =*(const Handle_AIS_InteractiveObject *)aniobj;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SubIntensityOff(			
_aniobj,			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SubIntensityOn461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SubIntensityOn(			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_SubIntensityOff461FC46A(
	void* instance,
	bool updateviewer)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->SubIntensityOff(			
updateviewer);
}
DECL_EXPORT void AIS_InteractiveContext_AddFilter3C9475B7(
	void* instance,
	void* aFilter)
{
		const Handle_SelectMgr_Filter&  _aFilter =*(const Handle_SelectMgr_Filter *)aFilter;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->AddFilter(			
_aFilter);
}
DECL_EXPORT void AIS_InteractiveContext_RemoveFilter3C9475B7(
	void* instance,
	void* aFilter)
{
		const Handle_SelectMgr_Filter&  _aFilter =*(const Handle_SelectMgr_Filter *)aFilter;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->RemoveFilter(			
_aFilter);
}
DECL_EXPORT void AIS_InteractiveContext_RemoveFilters(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->RemoveFilters();
}
DECL_EXPORT void AIS_InteractiveContext_ActivateStandardModeC6FD32C4(
	void* instance,
	int aStandardActivation)
{
		const TopAbs_ShapeEnum _aStandardActivation =(const TopAbs_ShapeEnum )aStandardActivation;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ActivateStandardMode(			
_aStandardActivation);
}
DECL_EXPORT void AIS_InteractiveContext_DeactivateStandardModeC6FD32C4(
	void* instance,
	int aStandardActivation)
{
		const TopAbs_ShapeEnum _aStandardActivation =(const TopAbs_ShapeEnum )aStandardActivation;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->DeactivateStandardMode(			
_aStandardActivation);
}
DECL_EXPORT void AIS_InteractiveContext_DisplayedObjectsFB1E3476(
	void* instance,
	void* aListOfIO,
	bool OnlyFromNeutral)
{
		 AIS_ListOfInteractive &  _aListOfIO =*( AIS_ListOfInteractive *)aListOfIO;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->DisplayedObjects(			
_aListOfIO,			
(Standard_Boolean)OnlyFromNeutral);
}
DECL_EXPORT void AIS_InteractiveContext_DisplayedObjects552A363C(
	void* instance,
	int WhichKind,
	int WhichSignature,
	void* aListOfIO,
	bool OnlyFromNeutral)
{
		const AIS_KindOfInteractive _WhichKind =(const AIS_KindOfInteractive )WhichKind;
		 AIS_ListOfInteractive &  _aListOfIO =*( AIS_ListOfInteractive *)aListOfIO;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->DisplayedObjects(			
_WhichKind,			
WhichSignature,			
_aListOfIO,			
OnlyFromNeutral);
}
DECL_EXPORT void AIS_InteractiveContext_ObjectsInCollector235DE22E(
	void* instance,
	void* aListOfIO)
{
		 AIS_ListOfInteractive &  _aListOfIO =*( AIS_ListOfInteractive *)aListOfIO;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ObjectsInCollector(			
_aListOfIO);
}
DECL_EXPORT void AIS_InteractiveContext_ObjectsInCollectorFB8692A(
	void* instance,
	int WhichKind,
	int WhichSignature,
	void* aListOfIO)
{
		const AIS_KindOfInteractive _WhichKind =(const AIS_KindOfInteractive )WhichKind;
		 AIS_ListOfInteractive &  _aListOfIO =*( AIS_ListOfInteractive *)aListOfIO;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ObjectsInCollector(			
_WhichKind,			
WhichSignature,			
_aListOfIO);
}
DECL_EXPORT void AIS_InteractiveContext_ErasedObjects235DE22E(
	void* instance,
	void* theListOfIO)
{
		 AIS_ListOfInteractive &  _theListOfIO =*( AIS_ListOfInteractive *)theListOfIO;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ErasedObjects(			
_theListOfIO);
}
DECL_EXPORT void AIS_InteractiveContext_ErasedObjectsFB8692A(
	void* instance,
	int WhichKind,
	int WhichSignature,
	void* theListOfIO)
{
		const AIS_KindOfInteractive _WhichKind =(const AIS_KindOfInteractive )WhichKind;
		 AIS_ListOfInteractive &  _theListOfIO =*( AIS_ListOfInteractive *)theListOfIO;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ErasedObjects(			
_WhichKind,			
WhichSignature,			
_theListOfIO);
}
DECL_EXPORT void AIS_InteractiveContext_ObjectsByDisplayStatusF86BDF5C(
	void* instance,
	int theStatus,
	void* theListOfIO)
{
		const AIS_DisplayStatus _theStatus =(const AIS_DisplayStatus )theStatus;
		 AIS_ListOfInteractive &  _theListOfIO =*( AIS_ListOfInteractive *)theListOfIO;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ObjectsByDisplayStatus(			
_theStatus,			
_theListOfIO);
}
DECL_EXPORT void AIS_InteractiveContext_ObjectsByDisplayStatusB048A7AD(
	void* instance,
	int WhichKind,
	int WhichSignature,
	int theStatus,
	void* theListOfIO)
{
		const AIS_KindOfInteractive _WhichKind =(const AIS_KindOfInteractive )WhichKind;
		const AIS_DisplayStatus _theStatus =(const AIS_DisplayStatus )theStatus;
		 AIS_ListOfInteractive &  _theListOfIO =*( AIS_ListOfInteractive *)theListOfIO;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ObjectsByDisplayStatus(			
_WhichKind,			
WhichSignature,			
_theStatus,			
_theListOfIO);
}
DECL_EXPORT void AIS_InteractiveContext_ObjectsInsideC8729CEC(
	void* instance,
	void* aListOfIO,
	int WhichKind,
	int WhichSignature)
{
		 AIS_ListOfInteractive &  _aListOfIO =*( AIS_ListOfInteractive *)aListOfIO;
		const AIS_KindOfInteractive _WhichKind =(const AIS_KindOfInteractive )WhichKind;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ObjectsInside(			
_aListOfIO,			
_WhichKind,			
WhichSignature);
}
DECL_EXPORT int AIS_InteractiveContext_PurgeDisplay461FC46A(
	void* instance,
	bool CollectorToo)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->PurgeDisplay(			
CollectorToo);
}
DECL_EXPORT void AIS_InteractiveContext_DisplayActiveAreas36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->DisplayActiveAreas(			
_aView);
}
DECL_EXPORT void AIS_InteractiveContext_ClearActiveAreas36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ClearActiveAreas(			
_aView);
}
DECL_EXPORT void AIS_InteractiveContext_DisplayActiveSensitive36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->DisplayActiveSensitive(			
_aView);
}
DECL_EXPORT void AIS_InteractiveContext_ClearActiveSensitive36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->ClearActiveSensitive(			
_aView);
}
DECL_EXPORT void AIS_InteractiveContext_DisplayActiveSensitiveC47ED7A2(
	void* instance,
	void* anObject,
	void* aView)
{
		const Handle_AIS_InteractiveObject&  _anObject =*(const Handle_AIS_InteractiveObject *)anObject;
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->DisplayActiveSensitive(			
_anObject,			
_aView);
}
DECL_EXPORT void AIS_InteractiveContext_DisplayActiveAreasC47ED7A2(
	void* instance,
	void* anObject,
	void* aView)
{
		const Handle_AIS_InteractiveObject&  _anObject =*(const Handle_AIS_InteractiveObject *)anObject;
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
 	result->DisplayActiveAreas(			
_anObject,			
_aView);
}
DECL_EXPORT bool AIS_InteractiveContext_IsInLocal4F47E777(
	void* instance,
	void* anObject,
	int* TheIndex)
{
		const Handle_AIS_InteractiveObject&  _anObject =*(const Handle_AIS_InteractiveObject *)anObject;
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return  	result->IsInLocal(			
_anObject,			
*TheIndex);
}
DECL_EXPORT bool AIS_InteractiveContext_IsCollectorClosed(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->IsCollectorClosed();
}

DECL_EXPORT void AIS_InteractiveContext_SetAutoActivateSelection(void* instance, bool value)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
		result->SetAutoActivateSelection(value);
}

DECL_EXPORT bool AIS_InteractiveContext_GetAutoActivateSelection(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->GetAutoActivateSelection();
}

DECL_EXPORT void AIS_InteractiveContext_SetSensitivityMode(void* instance, int value)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
		result->SetSensitivityMode((const StdSelect_SensitivityMode)value);
}

DECL_EXPORT int AIS_InteractiveContext_SensitivityMode(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return (int)	result->SensitivityMode();
}

DECL_EXPORT void AIS_InteractiveContext_SetSensitivity(void* instance, double value)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
		result->SetSensitivity(value);
}

DECL_EXPORT double AIS_InteractiveContext_Sensitivity(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->Sensitivity();
}

DECL_EXPORT void AIS_InteractiveContext_SetPixelTolerance(void* instance, int value)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
		result->SetPixelTolerance(value);
}

DECL_EXPORT int AIS_InteractiveContext_PixelTolerance(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->PixelTolerance();
}

DECL_EXPORT int AIS_InteractiveContext_PreSelectionColor(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return (int)	result->PreSelectionColor();
}

DECL_EXPORT int AIS_InteractiveContext_DefaultColor(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return (int)	result->DefaultColor();
}

DECL_EXPORT void AIS_InteractiveContext_SetHilightColor(void* instance, int value)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
		result->SetHilightColor((const Quantity_NameOfColor)value);
}

DECL_EXPORT int AIS_InteractiveContext_HilightColor(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return (int)	result->HilightColor();
}

DECL_EXPORT void AIS_InteractiveContext_SetPreselectionColor(void* instance, int value)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
		result->SetPreselectionColor((const Quantity_NameOfColor)value);
}

DECL_EXPORT void AIS_InteractiveContext_SetSubIntensityColor(void* instance, int value)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
		result->SetSubIntensityColor((const Quantity_NameOfColor)value);
}

DECL_EXPORT int AIS_InteractiveContext_SubIntensityColor(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return (int)	result->SubIntensityColor();
}

DECL_EXPORT void AIS_InteractiveContext_SetHLRAngle(void* instance, double value)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
		result->SetHLRAngle(value);
}

DECL_EXPORT double AIS_InteractiveContext_HLRAngle(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->HLRAngle();
}

DECL_EXPORT void AIS_InteractiveContext_SetHiddenLineAspect(void* instance, void* value)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
		result->SetHiddenLineAspect(*(const Handle_Prs3d_LineAspect *)value);
}

DECL_EXPORT void* AIS_InteractiveContext_HiddenLineAspect(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_Prs3d_LineAspect(	result->HiddenLineAspect());
}

DECL_EXPORT bool AIS_InteractiveContext_DrawHiddenLine(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->DrawHiddenLine();
}

DECL_EXPORT bool AIS_InteractiveContext_HasNextDetected(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->HasNextDetected();
}

DECL_EXPORT void AIS_InteractiveContext_SetToHilightSelected(void* instance, bool value)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
		result->SetToHilightSelected(value);
}

DECL_EXPORT bool AIS_InteractiveContext_ToHilightSelected(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->ToHilightSelected();
}

DECL_EXPORT bool AIS_InteractiveContext_WasCurrentTouched(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->WasCurrentTouched();
}

DECL_EXPORT bool AIS_InteractiveContext_MoreCurrent(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->MoreCurrent();
}

DECL_EXPORT void* AIS_InteractiveContext_Current(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_AIS_InteractiveObject(	result->Current());
}

DECL_EXPORT int AIS_InteractiveContext_NbCurrents(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->NbCurrents();
}

DECL_EXPORT void* AIS_InteractiveContext_FirstCurrentObject(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_AIS_InteractiveObject(	result->FirstCurrentObject());
}

DECL_EXPORT bool AIS_InteractiveContext_MoreSelected(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->MoreSelected();
}

DECL_EXPORT int AIS_InteractiveContext_NbSelected(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->NbSelected();
}

DECL_EXPORT bool AIS_InteractiveContext_HasSelectedShape(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->HasSelectedShape();
}

DECL_EXPORT void* AIS_InteractiveContext_SelectedShape(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new TopoDS_Shape(	result->SelectedShape());
}

DECL_EXPORT void* AIS_InteractiveContext_SelectedOwner(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_SelectMgr_EntityOwner(	result->SelectedOwner());
}

DECL_EXPORT void* AIS_InteractiveContext_Interactive(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_AIS_InteractiveObject(	result->Interactive());
}

DECL_EXPORT void* AIS_InteractiveContext_SelectedInteractive(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_AIS_InteractiveObject(	result->SelectedInteractive());
}

DECL_EXPORT bool AIS_InteractiveContext_HasApplicative(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->HasApplicative();
}

DECL_EXPORT void* AIS_InteractiveContext_Applicative(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_Standard_Transient(	result->Applicative());
}

DECL_EXPORT bool AIS_InteractiveContext_HasDetected(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->HasDetected();
}

DECL_EXPORT bool AIS_InteractiveContext_HasDetectedShape(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->HasDetectedShape();
}

DECL_EXPORT void* AIS_InteractiveContext_DetectedShape(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new TopoDS_Shape(	result->DetectedShape());
}

DECL_EXPORT void* AIS_InteractiveContext_DetectedInteractive(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_AIS_InteractiveObject(	result->DetectedInteractive());
}

DECL_EXPORT void* AIS_InteractiveContext_DetectedOwner(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_SelectMgr_EntityOwner(	result->DetectedOwner());
}

DECL_EXPORT bool AIS_InteractiveContext_MoreDetected(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->MoreDetected();
}

DECL_EXPORT void* AIS_InteractiveContext_DetectedCurrentShape(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new TopoDS_Shape(	result->DetectedCurrentShape());
}

DECL_EXPORT void* AIS_InteractiveContext_DetectedCurrentObject(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_AIS_InteractiveObject(	result->DetectedCurrentObject());
}

DECL_EXPORT int AIS_InteractiveContext_IndexOfCurrentLocal(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->IndexOfCurrentLocal();
}

DECL_EXPORT bool AIS_InteractiveContext_BeginImmediateDraw(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->BeginImmediateDraw();
}

DECL_EXPORT bool AIS_InteractiveContext_IsImmediateModeOn(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->IsImmediateModeOn();
}

DECL_EXPORT void AIS_InteractiveContext_SetAutomaticHilight(void* instance, bool value)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
		result->SetAutomaticHilight(value);
}

DECL_EXPORT bool AIS_InteractiveContext_AutomaticHilight(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->AutomaticHilight();
}

DECL_EXPORT void AIS_InteractiveContext_SetZDetection(void* instance, bool value)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
		result->SetZDetection(value);
}

DECL_EXPORT bool AIS_InteractiveContext_ZDetection(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->ZDetection();
}

DECL_EXPORT void* AIS_InteractiveContext_DefaultDrawer(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_Prs3d_Drawer(	result->DefaultDrawer());
}

DECL_EXPORT void* AIS_InteractiveContext_CurrentViewer(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_V3d_Viewer(	result->CurrentViewer());
}

DECL_EXPORT void* AIS_InteractiveContext_Collector(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_V3d_Viewer(	result->Collector());
}

DECL_EXPORT bool AIS_InteractiveContext_HasOpenedContext(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->HasOpenedContext();
}

DECL_EXPORT void* AIS_InteractiveContext_CurrentName(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new TCollection_AsciiString(	result->CurrentName());
}

DECL_EXPORT void* AIS_InteractiveContext_SelectionName(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new TCollection_AsciiString(	result->SelectionName());
}

DECL_EXPORT Standard_CString AIS_InteractiveContext_DomainOfMainViewer(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->DomainOfMainViewer();
}

DECL_EXPORT void* AIS_InteractiveContext_SelectionManager(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_SelectMgr_SelectionManager(	result->SelectionManager());
}

DECL_EXPORT void* AIS_InteractiveContext_MainPrsMgr(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_PrsMgr_PresentationManager3d(	result->MainPrsMgr());
}

DECL_EXPORT void* AIS_InteractiveContext_CollectorPrsMgr(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_PrsMgr_PresentationManager3d(	result->CollectorPrsMgr());
}

DECL_EXPORT void* AIS_InteractiveContext_MainSelector(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_StdSelect_ViewerSelector3d(	result->MainSelector());
}

DECL_EXPORT void* AIS_InteractiveContext_LocalSelector(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_StdSelect_ViewerSelector3d(	result->LocalSelector());
}

DECL_EXPORT void* AIS_InteractiveContext_CollectorSelector(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	new Handle_StdSelect_ViewerSelector3d(	result->CollectorSelector());
}

DECL_EXPORT int AIS_InteractiveContext_HighestIndex(void* instance)
{
	AIS_InteractiveContext* result = (AIS_InteractiveContext*)(((Handle_AIS_InteractiveContext*)instance)->Access());
	return 	result->HighestIndex();
}

DECL_EXPORT void AISInteractiveContext_Dtor(void* instance)
{
	delete (Handle_AIS_InteractiveContext*)instance;
}
