#include "V3dViewer.h"
#include <V3d_Viewer.hxx>

#include <Aspect_Grid.hxx>
#include <gp_Ax3.hxx>
#include <Quantity_Color.hxx>
#include <V3d_Light.hxx>
#include <V3d_OrthographicView.hxx>
#include <V3d_PerspectiveView.hxx>
#include <V3d_Plane.hxx>
#include <V3d_View.hxx>
#include <Visual3d_ViewManager.hxx>

DECL_EXPORT void* V3d_Viewer_Ctor36F0AB5(
	void* Device,
	char* aName,
	char* aDomain,
	double ViewSize,
	int ViewProj,
	int ViewBackground,
	int Visualization,
	int ShadingModel,
	int UpdateMode,
	bool ComputedMode,
	bool DefaultComputedMode,
	int SurfaceDetail)
{
		const Handle_Aspect_GraphicDevice&  _Device =*(const Handle_Aspect_GraphicDevice *)Device;
		const V3d_TypeOfOrientation _ViewProj =(const V3d_TypeOfOrientation )ViewProj;
		const Quantity_NameOfColor _ViewBackground =(const Quantity_NameOfColor )ViewBackground;
		const V3d_TypeOfVisualization _Visualization =(const V3d_TypeOfVisualization )Visualization;
		const V3d_TypeOfShadingModel _ShadingModel =(const V3d_TypeOfShadingModel )ShadingModel;
		const V3d_TypeOfUpdate _UpdateMode =(const V3d_TypeOfUpdate )UpdateMode;
		const V3d_TypeOfSurfaceDetail _SurfaceDetail =(const V3d_TypeOfSurfaceDetail )SurfaceDetail;
	return new Handle_V3d_Viewer(new V3d_Viewer(			
_Device,			
(short*)aName,			
aDomain,			
ViewSize,			
_ViewProj,			
_ViewBackground,			
_Visualization,			
_ShadingModel,			
_UpdateMode,			
ComputedMode,			
DefaultComputedMode,			
_SurfaceDetail));
}
DECL_EXPORT void V3d_Viewer_SetViewOn(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetViewOn();
}
DECL_EXPORT void V3d_Viewer_SetViewOn36A6FAB7(
	void* instance,
	void* View)
{
		const Handle_V3d_View&  _View =*(const Handle_V3d_View *)View;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetViewOn(			
_View);
}
DECL_EXPORT void V3d_Viewer_SetViewOff(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetViewOff();
}
DECL_EXPORT void V3d_Viewer_SetViewOff36A6FAB7(
	void* instance,
	void* View)
{
		const Handle_V3d_View&  _View =*(const Handle_V3d_View *)View;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetViewOff(			
_View);
}
DECL_EXPORT void V3d_Viewer_Update(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->Update();
}
DECL_EXPORT void V3d_Viewer_UpdateLights(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->UpdateLights();
}
DECL_EXPORT void V3d_Viewer_Redraw(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->Redraw();
}
DECL_EXPORT void V3d_Viewer_Remove(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->Remove();
}
DECL_EXPORT void V3d_Viewer_Erase(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->Erase();
}
DECL_EXPORT void V3d_Viewer_UnHighlight(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->UnHighlight();
}
DECL_EXPORT void V3d_Viewer_SetDefaultBackgroundColor638950E1(
	void* instance,
	int Type,
	double V1,
	double V2,
	double V3)
{
		const Quantity_TypeOfColor _Type =(const Quantity_TypeOfColor )Type;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetDefaultBackgroundColor(			
_Type,			
V1,			
V2,			
V3);
}
DECL_EXPORT void V3d_Viewer_SetDefaultBackgroundColor48F4F471(
	void* instance,
	int Name)
{
		const Quantity_NameOfColor _Name =(const Quantity_NameOfColor )Name;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetDefaultBackgroundColor(			
_Name);
}
DECL_EXPORT void V3d_Viewer_SetDefaultBackgroundColor8FD7F48(
	void* instance,
	void* Color)
{
		const Quantity_Color &  _Color =*(const Quantity_Color *)Color;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetDefaultBackgroundColor(			
_Color);
}
DECL_EXPORT void V3d_Viewer_SetDefaultBgGradientColors99C5FF9E(
	void* instance,
	int Name1,
	int Name2,
	int FillStyle)
{
		const Quantity_NameOfColor _Name1 =(const Quantity_NameOfColor )Name1;
		const Quantity_NameOfColor _Name2 =(const Quantity_NameOfColor )Name2;
		const Aspect_GradientFillMethod _FillStyle =(const Aspect_GradientFillMethod )FillStyle;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetDefaultBgGradientColors(			
_Name1,			
_Name2,			
_FillStyle);
}
DECL_EXPORT void V3d_Viewer_SetDefaultBgGradientColorsEE919A89(
	void* instance,
	void* Color1,
	void* Color2,
	int FillStyle)
{
		const Quantity_Color &  _Color1 =*(const Quantity_Color *)Color1;
		const Quantity_Color &  _Color2 =*(const Quantity_Color *)Color2;
		const Aspect_GradientFillMethod _FillStyle =(const Aspect_GradientFillMethod )FillStyle;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetDefaultBgGradientColors(			
_Color1,			
_Color2,			
_FillStyle);
}
DECL_EXPORT void V3d_Viewer_DisplayPrivilegedPlane15F3D2D4(
	void* instance,
	bool OnOff,
	double aSize)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->DisplayPrivilegedPlane(			
OnOff,			
aSize);
}
DECL_EXPORT void V3d_Viewer_SetLightOn1C16FAC6(
	void* instance,
	void* MyLight)
{
		const Handle_V3d_Light&  _MyLight =*(const Handle_V3d_Light *)MyLight;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetLightOn(			
_MyLight);
}
DECL_EXPORT void V3d_Viewer_SetLightOn(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetLightOn();
}
DECL_EXPORT void V3d_Viewer_SetLightOff1C16FAC6(
	void* instance,
	void* MyLight)
{
		const Handle_V3d_Light&  _MyLight =*(const Handle_V3d_Light *)MyLight;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetLightOff(			
_MyLight);
}
DECL_EXPORT void V3d_Viewer_SetLightOff(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetLightOff();
}
DECL_EXPORT void V3d_Viewer_DelLight1C16FAC6(
	void* instance,
	void* MyLight)
{
		const Handle_V3d_Light&  _MyLight =*(const Handle_V3d_Light *)MyLight;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->DelLight(			
_MyLight);
}
DECL_EXPORT void V3d_Viewer_ClearCurrentSelectedLight(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->ClearCurrentSelectedLight();
}
DECL_EXPORT void V3d_Viewer_DefaultBackgroundColor638950E1(
	void* instance,
	int Type,
	double* V1,
	double* V2,
	double* V3)
{
		const Quantity_TypeOfColor _Type =(const Quantity_TypeOfColor )Type;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->DefaultBackgroundColor(			
_Type,			
*V1,			
*V2,			
*V3);
}
DECL_EXPORT void* V3d_Viewer_DefaultBackgroundColor(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return new Quantity_Color( 	result->DefaultBackgroundColor());
}
DECL_EXPORT void V3d_Viewer_DefaultBgGradientColorsCF0F9433(
	void* instance,
	void* Color1,
	void* Color2)
{
		 Quantity_Color &  _Color1 =*( Quantity_Color *)Color1;
		 Quantity_Color &  _Color2 =*( Quantity_Color *)Color2;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->DefaultBgGradientColors(			
_Color1,			
_Color2);
}
DECL_EXPORT void V3d_Viewer_InitActiveViews(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->InitActiveViews();
}
DECL_EXPORT void V3d_Viewer_NextActiveViews(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->NextActiveViews();
}
DECL_EXPORT void V3d_Viewer_InitDefinedViews(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->InitDefinedViews();
}
DECL_EXPORT void V3d_Viewer_NextDefinedViews(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->NextDefinedViews();
}
DECL_EXPORT void V3d_Viewer_InitActiveLights(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->InitActiveLights();
}
DECL_EXPORT void V3d_Viewer_NextActiveLights(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->NextActiveLights();
}
DECL_EXPORT void V3d_Viewer_InitDefinedLights(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->InitDefinedLights();
}
DECL_EXPORT void V3d_Viewer_NextDefinedLights(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->NextDefinedLights();
}
DECL_EXPORT void V3d_Viewer_AddPlane20B19CEF(
	void* instance,
	void* MyPlane)
{
		const Handle_V3d_Plane&  _MyPlane =*(const Handle_V3d_Plane *)MyPlane;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->AddPlane(			
_MyPlane);
}
DECL_EXPORT void V3d_Viewer_DelPlane20B19CEF(
	void* instance,
	void* MyPlane)
{
		const Handle_V3d_Plane&  _MyPlane =*(const Handle_V3d_Plane *)MyPlane;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->DelPlane(			
_MyPlane);
}
DECL_EXPORT void V3d_Viewer_InitDefinedPlanes(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->InitDefinedPlanes();
}
DECL_EXPORT void V3d_Viewer_NextDefinedPlanes(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->NextDefinedPlanes();
}
DECL_EXPORT bool V3d_Viewer_IsGlobalLight1C16FAC6(
	void* instance,
	void* TheLight)
{
		const Handle_V3d_Light&  _TheLight =*(const Handle_V3d_Light *)TheLight;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return  	result->IsGlobalLight(			
_TheLight);
}
DECL_EXPORT void V3d_Viewer_ActivateGridBD34C5A5(
	void* instance,
	int aGridType,
	int aGridDrawMode)
{
		const Aspect_GridType _aGridType =(const Aspect_GridType )aGridType;
		const Aspect_GridDrawMode _aGridDrawMode =(const Aspect_GridDrawMode )aGridDrawMode;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->ActivateGrid(			
_aGridType,			
_aGridDrawMode);
}
DECL_EXPORT void V3d_Viewer_DeactivateGrid(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->DeactivateGrid();
}
DECL_EXPORT bool V3d_Viewer_GridEcho(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return  	result->GridEcho();
}
DECL_EXPORT void V3d_Viewer_RectangularGridValues216AF150(
	void* instance,
	double* XOrigin,
	double* YOrigin,
	double* XStep,
	double* YStep,
	double* RotationAngle)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->RectangularGridValues(			
*XOrigin,			
*YOrigin,			
*XStep,			
*YStep,			
*RotationAngle);
}
DECL_EXPORT void V3d_Viewer_SetRectangularGridValues216AF150(
	void* instance,
	double XOrigin,
	double YOrigin,
	double XStep,
	double YStep,
	double RotationAngle)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetRectangularGridValues(			
XOrigin,			
YOrigin,			
XStep,			
YStep,			
RotationAngle);
}
DECL_EXPORT void V3d_Viewer_CircularGridValuesFC0B193D(
	void* instance,
	double* XOrigin,
	double* YOrigin,
	double* RadiusStep,
	int* DivisionNumber,
	double* RotationAngle)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->CircularGridValues(			
*XOrigin,			
*YOrigin,			
*RadiusStep,			
*DivisionNumber,			
*RotationAngle);
}
DECL_EXPORT void V3d_Viewer_SetCircularGridValuesFC0B193D(
	void* instance,
	double XOrigin,
	double YOrigin,
	double RadiusStep,
	int DivisionNumber,
	double RotationAngle)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetCircularGridValues(			
XOrigin,			
YOrigin,			
RadiusStep,			
DivisionNumber,			
RotationAngle);
}
DECL_EXPORT void V3d_Viewer_CircularGridGraphicValues9F0E714F(
	void* instance,
	double* Radius,
	double* OffSet)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->CircularGridGraphicValues(			
*Radius,			
*OffSet);
}
DECL_EXPORT void V3d_Viewer_SetCircularGridGraphicValues9F0E714F(
	void* instance,
	double Radius,
	double OffSet)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetCircularGridGraphicValues(			
Radius,			
OffSet);
}
DECL_EXPORT void V3d_Viewer_RectangularGridGraphicValues9282A951(
	void* instance,
	double* XSize,
	double* YSize,
	double* OffSet)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->RectangularGridGraphicValues(			
*XSize,			
*YSize,			
*OffSet);
}
DECL_EXPORT void V3d_Viewer_SetRectangularGridGraphicValues9282A951(
	void* instance,
	double XSize,
	double YSize,
	double OffSet)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetRectangularGridGraphicValues(			
XSize,			
YSize,			
OffSet);
}
DECL_EXPORT void V3d_Viewer_SetDefaultLights(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->SetDefaultLights();
}
DECL_EXPORT void V3d_Viewer_Init(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->Init();
}
DECL_EXPORT bool V3d_Viewer_AddZLayerE8219145(
	void* instance,
	int* theLayerId)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return  	result->AddZLayer(			
*theLayerId);
}
DECL_EXPORT bool V3d_Viewer_RemoveZLayerE8219145(
	void* instance,
	int theLayerId)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return  	result->RemoveZLayer(			
theLayerId);
}
DECL_EXPORT void V3d_Viewer_GetAllZLayersE22FA26(
	void* instance,
	void* theLayerSeq)
{
		 TColStd_SequenceOfInteger &  _theLayerSeq =*( TColStd_SequenceOfInteger *)theLayerSeq;
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
 	result->GetAllZLayers(			
_theLayerSeq);
}
DECL_EXPORT void* V3d_Viewer_CreateView(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	new Handle_V3d_View(	result->CreateView());
}

DECL_EXPORT void* V3d_Viewer_DefaultOrthographicView(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	new Handle_V3d_OrthographicView(	result->DefaultOrthographicView());
}

DECL_EXPORT void* V3d_Viewer_DefaultPerspectiveView(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	new Handle_V3d_PerspectiveView(	result->DefaultPerspectiveView());
}

DECL_EXPORT void V3d_Viewer_SetZBufferManagment(void* instance, bool value)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
		result->SetZBufferManagment(value);
}

DECL_EXPORT bool V3d_Viewer_ZBufferManagment(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->ZBufferManagment();
}

DECL_EXPORT void V3d_Viewer_SetDefaultTypeOfView(void* instance, int value)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
		result->SetDefaultTypeOfView((const V3d_TypeOfView)value);
}

DECL_EXPORT void V3d_Viewer_SetPrivilegedPlane(void* instance, void* value)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
		result->SetPrivilegedPlane(*(const gp_Ax3 *)value);
}

DECL_EXPORT void* V3d_Viewer_PrivilegedPlane(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	new gp_Ax3(	result->PrivilegedPlane());
}

DECL_EXPORT void V3d_Viewer_SetDefaultViewSize(void* instance, double value)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
		result->SetDefaultViewSize(value);
}

DECL_EXPORT double V3d_Viewer_DefaultViewSize(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->DefaultViewSize();
}

DECL_EXPORT void V3d_Viewer_SetDefaultViewProj(void* instance, int value)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
		result->SetDefaultViewProj((const V3d_TypeOfOrientation)value);
}

DECL_EXPORT int V3d_Viewer_DefaultViewProj(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return (int)	result->DefaultViewProj();
}

DECL_EXPORT void V3d_Viewer_SetDefaultVisualization(void* instance, int value)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
		result->SetDefaultVisualization((const V3d_TypeOfVisualization)value);
}

DECL_EXPORT int V3d_Viewer_DefaultVisualization(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return (int)	result->DefaultVisualization();
}

DECL_EXPORT void V3d_Viewer_SetDefaultShadingModel(void* instance, int value)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
		result->SetDefaultShadingModel((const V3d_TypeOfShadingModel)value);
}

DECL_EXPORT int V3d_Viewer_DefaultShadingModel(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return (int)	result->DefaultShadingModel();
}

DECL_EXPORT void V3d_Viewer_SetDefaultSurfaceDetail(void* instance, int value)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
		result->SetDefaultSurfaceDetail((const V3d_TypeOfSurfaceDetail)value);
}

DECL_EXPORT int V3d_Viewer_DefaultSurfaceDetail(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return (int)	result->DefaultSurfaceDetail();
}

DECL_EXPORT void V3d_Viewer_SetDefaultAngle(void* instance, double value)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
		result->SetDefaultAngle(value);
}

DECL_EXPORT double V3d_Viewer_DefaultAngle(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->DefaultAngle();
}

DECL_EXPORT void V3d_Viewer_SetUpdateMode(void* instance, int value)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
		result->SetUpdateMode((const V3d_TypeOfUpdate)value);
}

DECL_EXPORT int V3d_Viewer_UpdateMode(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return (int)	result->UpdateMode();
}

DECL_EXPORT bool V3d_Viewer_IfMoreViews(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->IfMoreViews();
}

DECL_EXPORT bool V3d_Viewer_MoreActiveViews(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->MoreActiveViews();
}

DECL_EXPORT void* V3d_Viewer_ActiveView(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	new Handle_V3d_View(	result->ActiveView());
}

DECL_EXPORT bool V3d_Viewer_LastActiveView(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->LastActiveView();
}

DECL_EXPORT bool V3d_Viewer_MoreDefinedViews(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->MoreDefinedViews();
}

DECL_EXPORT void* V3d_Viewer_DefinedView(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	new Handle_V3d_View(	result->DefinedView());
}

DECL_EXPORT bool V3d_Viewer_MoreActiveLights(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->MoreActiveLights();
}

DECL_EXPORT void* V3d_Viewer_ActiveLight(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	new Handle_V3d_Light(	result->ActiveLight());
}

DECL_EXPORT bool V3d_Viewer_MoreDefinedLights(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->MoreDefinedLights();
}

DECL_EXPORT void* V3d_Viewer_DefinedLight(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	new Handle_V3d_Light(	result->DefinedLight());
}

DECL_EXPORT bool V3d_Viewer_MoreDefinedPlanes(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->MoreDefinedPlanes();
}

DECL_EXPORT void* V3d_Viewer_DefinedPlane(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	new Handle_V3d_Plane(	result->DefinedPlane());
}

DECL_EXPORT void* V3d_Viewer_Viewer(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	new Handle_Visual3d_ViewManager(	result->Viewer());
}

DECL_EXPORT void V3d_Viewer_SetCurrentSelectedLight(void* instance, void* value)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
		result->SetCurrentSelectedLight(*(const Handle_V3d_Light *)value);
}

DECL_EXPORT void* V3d_Viewer_CurrentSelectedLight(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	new Handle_V3d_Light(	result->CurrentSelectedLight());
}

DECL_EXPORT bool V3d_Viewer_ComputedMode(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->ComputedMode();
}

DECL_EXPORT bool V3d_Viewer_DefaultComputedMode(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->DefaultComputedMode();
}

DECL_EXPORT bool V3d_Viewer_IsActive(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	result->IsActive();
}

DECL_EXPORT void* V3d_Viewer_Grid(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return 	new Handle_Aspect_Grid(	result->Grid());
}

DECL_EXPORT int V3d_Viewer_GridType(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return (int)	result->GridType();
}

DECL_EXPORT int V3d_Viewer_GridDrawMode(void* instance)
{
	V3d_Viewer* result = (V3d_Viewer*)(((Handle_V3d_Viewer*)instance)->Access());
	return (int)	result->GridDrawMode();
}

DECL_EXPORT void V3dViewer_Dtor(void* instance)
{
	delete (Handle_V3d_Viewer*)instance;
}
