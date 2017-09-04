#ifndef Visual3d_View_H
#define Visual3d_View_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_View_CtorC8D72425(
	void* AManager);
extern "C" DECL_EXPORT void Visual3d_View_Activate(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_Deactivate(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_Redraw(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_Redraw8C6D7843(
	void* instance,
	int x,
	int y,
	int width,
	int height);
extern "C" DECL_EXPORT void Visual3d_View_Redraw7202F40D(
	void* instance,
	void* AnUnderLayer,
	void* AnOverLayer);
extern "C" DECL_EXPORT void Visual3d_View_Redraw885CF247(
	void* instance,
	void* AnUnderLayer,
	void* AnOverLayer,
	int x,
	int y,
	int width,
	int height);
extern "C" DECL_EXPORT void Visual3d_View_Remove(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_Resized(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_SetBackgroundImage5C59B37F(
	void* instance,
	char* FileName,
	int FillStyle,
	bool update);
extern "C" DECL_EXPORT void Visual3d_View_SetBgImageStyle254163A9(
	void* instance,
	int FillStyle,
	bool update);
extern "C" DECL_EXPORT void Visual3d_View_SetBgGradientStyle86DFD8CC(
	void* instance,
	int FillStyle,
	bool update);
extern "C" DECL_EXPORT void Visual3d_View_SetViewMappingDefault(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_SetViewOrientationDefault(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_Update(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_Update7202F40D(
	void* instance,
	void* AnUnderLayer,
	void* AnOverLayer);
extern "C" DECL_EXPORT void Visual3d_View_ViewMappingReset(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_ViewOrientationReset(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_SetAnimationModeOff(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_ZBufferTriedronSetup9BCB825E(
	void* instance,
	int XColor,
	int YColor,
	int ZColor,
	double SizeRatio,
	double AxisDiametr,
	int NbFacettes);
extern "C" DECL_EXPORT void Visual3d_View_TriedronDisplayE9A003B7(
	void* instance,
	int APosition,
	int AColor,
	double AScale,
	bool AsWireframe);
extern "C" DECL_EXPORT void Visual3d_View_TriedronErase(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_TriedronEcho14CB0F5D(
	void* instance,
	int AType);
extern "C" DECL_EXPORT void Visual3d_View_GraduatedTrihedronDisplayC3638B35(
	void* instance,
	void* xname,
	void* yname,
	void* zname,
	bool xdrawname,
	bool ydrawname,
	bool zdrawname,
	bool xdrawvalues,
	bool ydrawvalues,
	bool zdrawvalues,
	bool drawgrid,
	bool drawaxes,
	int nbx,
	int nby,
	int nbz,
	int xoffset,
	int yoffset,
	int zoffset,
	int xaxisoffset,
	int yaxisoffset,
	int zaxisoffset,
	bool xdrawtickmarks,
	bool ydrawtickmarks,
	bool zdrawtickmarks,
	int xtickmarklength,
	int ytickmarklength,
	int ztickmarklength,
	void* gridcolor,
	void* xnamecolor,
	void* ynamecolor,
	void* znamecolor,
	void* xcolor,
	void* ycolor,
	void* zcolor,
	void* fontOfNames,
	int styleOfNames,
	int sizeOfNames,
	void* fontOfValues,
	int styleOfValues,
	int sizeOfValues);
extern "C" DECL_EXPORT void Visual3d_View_GraduatedTrihedronErase(void* instance);
extern "C" DECL_EXPORT bool Visual3d_View_ContainsFacet(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_MinMaxValuesBC7A5786(
	void* instance,
	double* XMin,
	double* YMin,
	double* ZMin,
	double* XMax,
	double* YMax,
	double* ZMax);
extern "C" DECL_EXPORT void Visual3d_View_MinMaxValuesC2777E0C(
	void* instance,
	double* XMin,
	double* YMin,
	double* XMax,
	double* YMax);
extern "C" DECL_EXPORT void Visual3d_View_ProjectsBC7A5786(
	void* instance,
	double AX,
	double AY,
	double AZ,
	double* APX,
	double* APY,
	double* APZ);
extern "C" DECL_EXPORT void* Visual3d_View_ViewMappingDefault(void* instance);
extern "C" DECL_EXPORT void* Visual3d_View_ViewOrientationDefault(void* instance);
extern "C" DECL_EXPORT void* Visual3d_View_Window(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_Plot9190F42F(
	void* instance,
	void* APlotter);
extern "C" DECL_EXPORT bool Visual3d_View_Print3E41AD16(
	void* instance,
	void* AnUnderLayer,
	void* AnOverLayer,
	void* hPrnDC,
	bool showBackground,
	char* filename,
	int printAlgorithm,
	double theScaleFactor);
extern "C" DECL_EXPORT bool Visual3d_View_Print23A2F056(
	void* instance,
	void* hPrnDC,
	bool showBackground,
	char* filename,
	int printAlgorithm,
	double theScaleFactor);
extern "C" DECL_EXPORT void Visual3d_View_EnableDepthTest461FC46A(
	void* instance,
	bool enable);
extern "C" DECL_EXPORT void Visual3d_View_EnableGLLight461FC46A(
	void* instance,
	bool enable);
extern "C" DECL_EXPORT void Visual3d_View_SetBackFacingModel(void* instance, int value);
extern "C" DECL_EXPORT int Visual3d_View_BackFacingModel(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_SetAnimationModeOn(void* instance, bool value);
extern "C" DECL_EXPORT bool Visual3d_View_AnimationModeIsOn(void* instance);
extern "C" DECL_EXPORT bool Visual3d_View_DegenerateModeIsOn(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_SetComputedMode(void* instance, bool value);
extern "C" DECL_EXPORT bool Visual3d_View_ComputedMode(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_SetBackground(void* instance, void* value);
extern "C" DECL_EXPORT void* Visual3d_View_Background(void* instance);
extern "C" DECL_EXPORT bool Visual3d_View_IsActive(void* instance);
extern "C" DECL_EXPORT bool Visual3d_View_IsDefined(void* instance);
extern "C" DECL_EXPORT bool Visual3d_View_IsDeleted(void* instance);
extern "C" DECL_EXPORT int Visual3d_View_NumberOfDisplayedStructures(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_SetViewMapping(void* instance, void* value);
extern "C" DECL_EXPORT void* Visual3d_View_ViewMapping(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_SetViewOrientation(void* instance, void* value);
extern "C" DECL_EXPORT void* Visual3d_View_ViewOrientation(void* instance);
extern "C" DECL_EXPORT int Visual3d_View_LightLimit(void* instance);
extern "C" DECL_EXPORT int Visual3d_View_PlaneLimit(void* instance);
extern "C" DECL_EXPORT void* Visual3d_View_ViewManager(void* instance);
extern "C" DECL_EXPORT int Visual3d_View_Identification(void* instance);
extern "C" DECL_EXPORT void* Visual3d_View_GraphicDriver(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_SetTransparency(void* instance, bool value);
extern "C" DECL_EXPORT bool Visual3d_View_ZBufferIsActivated(void* instance);
extern "C" DECL_EXPORT void Visual3d_View_SetZBufferActivity(void* instance, int value);
extern "C" DECL_EXPORT void* Visual3d_View_UnderLayer(void* instance);
extern "C" DECL_EXPORT void* Visual3d_View_OverLayer(void* instance);
extern "C" DECL_EXPORT bool Visual3d_View_IsDepthTestEnabled(void* instance);
extern "C" DECL_EXPORT bool Visual3d_View_IsGLLightEnabled(void* instance);
extern "C" DECL_EXPORT void Visual3dView_Dtor(void* instance);

#endif
