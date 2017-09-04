#ifndef V3d_Viewer_H
#define V3d_Viewer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* V3d_Viewer_Ctor36F0AB5(
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
	int SurfaceDetail);
extern "C" DECL_EXPORT void V3d_Viewer_SetViewOn(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetViewOn36A6FAB7(
	void* instance,
	void* View);
extern "C" DECL_EXPORT void V3d_Viewer_SetViewOff(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetViewOff36A6FAB7(
	void* instance,
	void* View);
extern "C" DECL_EXPORT void V3d_Viewer_Update(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_UpdateLights(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_Redraw(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_Remove(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_Erase(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_UnHighlight(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultBackgroundColor638950E1(
	void* instance,
	int Type,
	double V1,
	double V2,
	double V3);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultBackgroundColor48F4F471(
	void* instance,
	int Name);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultBackgroundColor8FD7F48(
	void* instance,
	void* Color);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultBgGradientColors99C5FF9E(
	void* instance,
	int Name1,
	int Name2,
	int FillStyle);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultBgGradientColorsEE919A89(
	void* instance,
	void* Color1,
	void* Color2,
	int FillStyle);
extern "C" DECL_EXPORT void V3d_Viewer_DisplayPrivilegedPlane15F3D2D4(
	void* instance,
	bool OnOff,
	double aSize);
extern "C" DECL_EXPORT void V3d_Viewer_SetLightOn1C16FAC6(
	void* instance,
	void* MyLight);
extern "C" DECL_EXPORT void V3d_Viewer_SetLightOn(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetLightOff1C16FAC6(
	void* instance,
	void* MyLight);
extern "C" DECL_EXPORT void V3d_Viewer_SetLightOff(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_DelLight1C16FAC6(
	void* instance,
	void* MyLight);
extern "C" DECL_EXPORT void V3d_Viewer_ClearCurrentSelectedLight(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_DefaultBackgroundColor638950E1(
	void* instance,
	int Type,
	double* V1,
	double* V2,
	double* V3);
extern "C" DECL_EXPORT void* V3d_Viewer_DefaultBackgroundColor(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_DefaultBgGradientColorsCF0F9433(
	void* instance,
	void* Color1,
	void* Color2);
extern "C" DECL_EXPORT void V3d_Viewer_InitActiveViews(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_NextActiveViews(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_InitDefinedViews(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_NextDefinedViews(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_InitActiveLights(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_NextActiveLights(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_InitDefinedLights(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_NextDefinedLights(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_AddPlane20B19CEF(
	void* instance,
	void* MyPlane);
extern "C" DECL_EXPORT void V3d_Viewer_DelPlane20B19CEF(
	void* instance,
	void* MyPlane);
extern "C" DECL_EXPORT void V3d_Viewer_InitDefinedPlanes(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_NextDefinedPlanes(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_IsGlobalLight1C16FAC6(
	void* instance,
	void* TheLight);
extern "C" DECL_EXPORT void V3d_Viewer_ActivateGridBD34C5A5(
	void* instance,
	int aGridType,
	int aGridDrawMode);
extern "C" DECL_EXPORT void V3d_Viewer_DeactivateGrid(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_GridEcho(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_RectangularGridValues216AF150(
	void* instance,
	double* XOrigin,
	double* YOrigin,
	double* XStep,
	double* YStep,
	double* RotationAngle);
extern "C" DECL_EXPORT void V3d_Viewer_SetRectangularGridValues216AF150(
	void* instance,
	double XOrigin,
	double YOrigin,
	double XStep,
	double YStep,
	double RotationAngle);
extern "C" DECL_EXPORT void V3d_Viewer_CircularGridValuesFC0B193D(
	void* instance,
	double* XOrigin,
	double* YOrigin,
	double* RadiusStep,
	int* DivisionNumber,
	double* RotationAngle);
extern "C" DECL_EXPORT void V3d_Viewer_SetCircularGridValuesFC0B193D(
	void* instance,
	double XOrigin,
	double YOrigin,
	double RadiusStep,
	int DivisionNumber,
	double RotationAngle);
extern "C" DECL_EXPORT void V3d_Viewer_CircularGridGraphicValues9F0E714F(
	void* instance,
	double* Radius,
	double* OffSet);
extern "C" DECL_EXPORT void V3d_Viewer_SetCircularGridGraphicValues9F0E714F(
	void* instance,
	double Radius,
	double OffSet);
extern "C" DECL_EXPORT void V3d_Viewer_RectangularGridGraphicValues9282A951(
	void* instance,
	double* XSize,
	double* YSize,
	double* OffSet);
extern "C" DECL_EXPORT void V3d_Viewer_SetRectangularGridGraphicValues9282A951(
	void* instance,
	double XSize,
	double YSize,
	double OffSet);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultLights(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_Init(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_AddZLayerE8219145(
	void* instance,
	int* theLayerId);
extern "C" DECL_EXPORT bool V3d_Viewer_RemoveZLayerE8219145(
	void* instance,
	int theLayerId);
extern "C" DECL_EXPORT void V3d_Viewer_GetAllZLayersE22FA26(
	void* instance,
	void* theLayerSeq);
extern "C" DECL_EXPORT void* V3d_Viewer_CreateView(void* instance);
extern "C" DECL_EXPORT void* V3d_Viewer_DefaultOrthographicView(void* instance);
extern "C" DECL_EXPORT void* V3d_Viewer_DefaultPerspectiveView(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetZBufferManagment(void* instance, bool value);
extern "C" DECL_EXPORT bool V3d_Viewer_ZBufferManagment(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultTypeOfView(void* instance, int value);
extern "C" DECL_EXPORT void V3d_Viewer_SetPrivilegedPlane(void* instance, void* value);
extern "C" DECL_EXPORT void* V3d_Viewer_PrivilegedPlane(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultViewSize(void* instance, double value);
extern "C" DECL_EXPORT double V3d_Viewer_DefaultViewSize(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultViewProj(void* instance, int value);
extern "C" DECL_EXPORT int V3d_Viewer_DefaultViewProj(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultVisualization(void* instance, int value);
extern "C" DECL_EXPORT int V3d_Viewer_DefaultVisualization(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultShadingModel(void* instance, int value);
extern "C" DECL_EXPORT int V3d_Viewer_DefaultShadingModel(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultSurfaceDetail(void* instance, int value);
extern "C" DECL_EXPORT int V3d_Viewer_DefaultSurfaceDetail(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetDefaultAngle(void* instance, double value);
extern "C" DECL_EXPORT double V3d_Viewer_DefaultAngle(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetUpdateMode(void* instance, int value);
extern "C" DECL_EXPORT int V3d_Viewer_UpdateMode(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_IfMoreViews(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_MoreActiveViews(void* instance);
extern "C" DECL_EXPORT void* V3d_Viewer_ActiveView(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_LastActiveView(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_MoreDefinedViews(void* instance);
extern "C" DECL_EXPORT void* V3d_Viewer_DefinedView(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_MoreActiveLights(void* instance);
extern "C" DECL_EXPORT void* V3d_Viewer_ActiveLight(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_MoreDefinedLights(void* instance);
extern "C" DECL_EXPORT void* V3d_Viewer_DefinedLight(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_MoreDefinedPlanes(void* instance);
extern "C" DECL_EXPORT void* V3d_Viewer_DefinedPlane(void* instance);
extern "C" DECL_EXPORT void* V3d_Viewer_Viewer(void* instance);
extern "C" DECL_EXPORT void V3d_Viewer_SetCurrentSelectedLight(void* instance, void* value);
extern "C" DECL_EXPORT void* V3d_Viewer_CurrentSelectedLight(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_ComputedMode(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_DefaultComputedMode(void* instance);
extern "C" DECL_EXPORT bool V3d_Viewer_IsActive(void* instance);
extern "C" DECL_EXPORT void* V3d_Viewer_Grid(void* instance);
extern "C" DECL_EXPORT int V3d_Viewer_GridType(void* instance);
extern "C" DECL_EXPORT int V3d_Viewer_GridDrawMode(void* instance);
extern "C" DECL_EXPORT void V3dViewer_Dtor(void* instance);

#endif
