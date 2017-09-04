#ifndef V3d_View_H
#define V3d_View_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void V3d_View_SetWindow6DD76FB2(
	void* instance,
	void* IdWin);
extern "C" DECL_EXPORT void V3d_View_SetMagnifyD520CBEE(
	void* instance,
	void* IdWin,
	void* aPreviousView,
	int x1,
	int y1,
	int x2,
	int y2);
extern "C" DECL_EXPORT void V3d_View_Remove(void* instance);
extern "C" DECL_EXPORT void V3d_View_Update(void* instance);
extern "C" DECL_EXPORT void V3d_View_Redraw(void* instance);
extern "C" DECL_EXPORT void V3d_View_Redraw8C6D7843(
	void* instance,
	int x,
	int y,
	int width,
	int height);
extern "C" DECL_EXPORT void V3d_View_MustBeResized(void* instance);
extern "C" DECL_EXPORT void V3d_View_DoMapping(void* instance);
extern "C" DECL_EXPORT void V3d_View_UpdateLights(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetBackgroundColor638950E1(
	void* instance,
	int Type,
	double V1,
	double V2,
	double V3);
extern "C" DECL_EXPORT void V3d_View_SetBackgroundColor8FD7F48(
	void* instance,
	void* Color);
extern "C" DECL_EXPORT void V3d_View_SetBackgroundColor48F4F471(
	void* instance,
	int Name);
extern "C" DECL_EXPORT void V3d_View_SetBgGradientColorsA313F140(
	void* instance,
	void* Color1,
	void* Color2,
	int FillStyle,
	bool update);
extern "C" DECL_EXPORT void V3d_View_SetBgGradientColors4216A027(
	void* instance,
	int Color1,
	int Color2,
	int FillStyle,
	bool update);
extern "C" DECL_EXPORT void V3d_View_SetBgGradientStyle86DFD8CC(
	void* instance,
	int AMethod,
	bool update);
extern "C" DECL_EXPORT void V3d_View_SetBackgroundImage5C59B37F(
	void* instance,
	char* FileName,
	int FillStyle,
	bool update);
extern "C" DECL_EXPORT void V3d_View_SetBgImageStyle254163A9(
	void* instance,
	int FillStyle,
	bool update);
extern "C" DECL_EXPORT void V3d_View_SetAxisBC7A5786(
	void* instance,
	double X,
	double Y,
	double Z,
	double Vx,
	double Vy,
	double Vz);
extern "C" DECL_EXPORT void V3d_View_SetAntialiasingOn(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetAntialiasingOff(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetZCueingOn(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetZCueingOff(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetLightOn1C16FAC6(
	void* instance,
	void* MyLight);
extern "C" DECL_EXPORT void V3d_View_SetLightOn(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetLightOff1C16FAC6(
	void* instance,
	void* MyLight);
extern "C" DECL_EXPORT void V3d_View_SetLightOff(void* instance);
extern "C" DECL_EXPORT bool V3d_View_IsActiveLight1C16FAC6(
	void* instance,
	void* aLight);
extern "C" DECL_EXPORT void V3d_View_SetPlaneOn20B19CEF(
	void* instance,
	void* MyPlane);
extern "C" DECL_EXPORT void V3d_View_SetPlaneOn(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetPlaneOff20B19CEF(
	void* instance,
	void* MyPlane);
extern "C" DECL_EXPORT void V3d_View_SetPlaneOff(void* instance);
extern "C" DECL_EXPORT bool V3d_View_IsActivePlane20B19CEF(
	void* instance,
	void* aPlane);
extern "C" DECL_EXPORT void V3d_View_ZBufferTriedronSetup9BCB825E(
	void* instance,
	int XColor,
	int YColor,
	int ZColor,
	double SizeRatio,
	double AxisDiametr,
	int NbFacettes);
extern "C" DECL_EXPORT void V3d_View_TriedronDisplay4E80490A(
	void* instance,
	int APosition,
	int AColor,
	double AScale,
	int AMode);
extern "C" DECL_EXPORT void V3d_View_TriedronErase(void* instance);
extern "C" DECL_EXPORT void V3d_View_TriedronEcho14CB0F5D(
	void* instance,
	int AType);
extern "C" DECL_EXPORT void V3d_View_GetGraduatedTrihedronC3638B35(
	void* instance,
	void* xname,
	void* yname,
	void* zname,
	bool* xdrawname,
	bool* ydrawname,
	bool* zdrawname,
	bool* xdrawvalues,
	bool* ydrawvalues,
	bool* zdrawvalues,
	bool* drawgrid,
	bool* drawaxes,
	int* nbx,
	int* nby,
	int* nbz,
	int* xoffset,
	int* yoffset,
	int* zoffset,
	int* xaxisoffset,
	int* yaxisoffset,
	int* zaxisoffset,
	bool* xdrawtickmarks,
	bool* ydrawtickmarks,
	bool* zdrawtickmarks,
	int* xtickmarklength,
	int* ytickmarklength,
	int* ztickmarklength,
	void* gridcolor,
	void* xnamecolor,
	void* ynamecolor,
	void* znamecolor,
	void* xcolor,
	void* ycolor,
	void* zcolor,
	void* fontOfNames,
	int styleOfNames,
	int* sizeOfNames,
	void* fontOfValues,
	int styleOfValues,
	int* sizeOfValues);
extern "C" DECL_EXPORT void V3d_View_GraduatedTrihedronDisplayC3638B35(
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
extern "C" DECL_EXPORT void V3d_View_GraduatedTrihedronErase(void* instance);
extern "C" DECL_EXPORT void V3d_View_ColorScaleDisplay(void* instance);
extern "C" DECL_EXPORT void V3d_View_ColorScaleErase(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetFront(void* instance);
extern "C" DECL_EXPORT void V3d_View_Rotate1B801FD4(
	void* instance,
	double Ax,
	double Ay,
	double Az,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_Rotate51E06B8D(
	void* instance,
	double Ax,
	double Ay,
	double Az,
	double X,
	double Y,
	double Z,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_Rotate45D32271(
	void* instance,
	int Axe,
	double Angle,
	double X,
	double Y,
	double Z,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_RotateB8D50DF4(
	void* instance,
	int Axe,
	double Angle,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_RotateC85E5E0F(
	void* instance,
	double Angle,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_Move1B801FD4(
	void* instance,
	double Dx,
	double Dy,
	double Dz,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_MoveB8D50DF4(
	void* instance,
	int Axe,
	double Length,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_MoveC85E5E0F(
	void* instance,
	double Length,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_Translate1B801FD4(
	void* instance,
	double Dx,
	double Dy,
	double Dz,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_TranslateB8D50DF4(
	void* instance,
	int Axe,
	double Length,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_TranslateC85E5E0F(
	void* instance,
	double Length,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_Place83917674(
	void* instance,
	int x,
	int y,
	double aZoomFactor);
extern "C" DECL_EXPORT void V3d_View_Turn1B801FD4(
	void* instance,
	double Ax,
	double Ay,
	double Az,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_TurnB8D50DF4(
	void* instance,
	int Axe,
	double Angle,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_TurnC85E5E0F(
	void* instance,
	double Angle,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_SetEye9282A951(
	void* instance,
	double X,
	double Y,
	double Z);
extern "C" DECL_EXPORT void V3d_View_SetProj9282A951(
	void* instance,
	double Vx,
	double Vy,
	double Vz);
extern "C" DECL_EXPORT void V3d_View_SetProj17AA5025(
	void* instance,
	int Orientation);
extern "C" DECL_EXPORT void V3d_View_SetAt9282A951(
	void* instance,
	double X,
	double Y,
	double Z);
extern "C" DECL_EXPORT void V3d_View_SetUp9282A951(
	void* instance,
	double Vx,
	double Vy,
	double Vz);
extern "C" DECL_EXPORT void V3d_View_SetUp17AA5025(
	void* instance,
	int Orientation);
extern "C" DECL_EXPORT void V3d_View_SetViewOrientationDefault(void* instance);
extern "C" DECL_EXPORT void V3d_View_ResetViewOrientation(void* instance);
extern "C" DECL_EXPORT void V3d_View_Panning1B801FD4(
	void* instance,
	double Dx,
	double Dy,
	double aZoomFactor,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_SetCenter9F0E714F(
	void* instance,
	double Xc,
	double Yc);
extern "C" DECL_EXPORT void V3d_View_SetCenter5107F6FE(
	void* instance,
	int X,
	int Y);
extern "C" DECL_EXPORT void V3d_View_SetSizeD82819F3(
	void* instance,
	double Size);
extern "C" DECL_EXPORT void V3d_View_SetZoomC85E5E0F(
	void* instance,
	double Coef,
	bool Start);
extern "C" DECL_EXPORT void V3d_View_SetAxialScale9282A951(
	void* instance,
	double Sx,
	double Sy,
	double Sz);
extern "C" DECL_EXPORT void V3d_View_FitAll7B00BEA(
	void* instance,
	double Coef,
	bool FitZ,
	bool update);
extern "C" DECL_EXPORT void V3d_View_ZFitAllD82819F3(
	void* instance,
	double Coef);
extern "C" DECL_EXPORT void V3d_View_DepthFitAll9F0E714F(
	void* instance,
	double Aspect,
	double Margin);
extern "C" DECL_EXPORT void V3d_View_FitAllC2777E0C(
	void* instance,
	double Umin,
	double Vmin,
	double Umax,
	double Vmax);
extern "C" DECL_EXPORT void V3d_View_WindowFit8C6D7843(
	void* instance,
	int Xmin,
	int Ymin,
	int Xmax,
	int Ymax);
extern "C" DECL_EXPORT void V3d_View_SetViewingVolumeBC7A5786(
	void* instance,
	double Left,
	double Right,
	double Bottom,
	double Top,
	double ZNear,
	double ZFar);
extern "C" DECL_EXPORT void V3d_View_SetViewMappingDefault(void* instance);
extern "C" DECL_EXPORT void V3d_View_ResetViewMapping(void* instance);
extern "C" DECL_EXPORT void V3d_View_Reset461FC46A(
	void* instance,
	bool update);
extern "C" DECL_EXPORT double V3d_View_ConvertE8219145(
	void* instance,
	int Vp);
extern "C" DECL_EXPORT void V3d_View_ConvertB83D31A8(
	void* instance,
	int Xp,
	int Yp,
	double* Xv,
	double* Yv);
extern "C" DECL_EXPORT int V3d_View_ConvertD82819F3(
	void* instance,
	double Vv);
extern "C" DECL_EXPORT void V3d_View_Convert852507E(
	void* instance,
	double Xv,
	double Yv,
	int* Xp,
	int* Yp);
extern "C" DECL_EXPORT void V3d_View_Convert636CFDD5(
	void* instance,
	int Xp,
	int Yp,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT void V3d_View_ConvertWithProj67C254F0(
	void* instance,
	int Xp,
	int Yp,
	double* X,
	double* Y,
	double* Z,
	double* Vx,
	double* Vy,
	double* Vz);
extern "C" DECL_EXPORT void V3d_View_ConvertToGrid636CFDD5(
	void* instance,
	int Xp,
	int Yp,
	double* Xg,
	double* Yg,
	double* Zg);
extern "C" DECL_EXPORT void V3d_View_ConvertToGridBC7A5786(
	void* instance,
	double X,
	double Y,
	double Z,
	double* Xg,
	double* Yg,
	double* Zg);
extern "C" DECL_EXPORT void V3d_View_Convert94A49759(
	void* instance,
	double X,
	double Y,
	double Z,
	int* Xp,
	int* Yp);
extern "C" DECL_EXPORT void V3d_View_Project216AF150(
	void* instance,
	double X,
	double Y,
	double Z,
	double* Xp,
	double* Yp);
extern "C" DECL_EXPORT void V3d_View_BackgroundColor638950E1(
	void* instance,
	int Type,
	double* V1,
	double* V2,
	double* V3);
extern "C" DECL_EXPORT void* V3d_View_BackgroundColor(void* instance);
extern "C" DECL_EXPORT void V3d_View_GradientBackgroundColorsCF0F9433(
	void* instance,
	void* Color1,
	void* Color2);
extern "C" DECL_EXPORT void V3d_View_AxialScale9282A951(
	void* instance,
	double* Sx,
	double* Sy,
	double* Sz);
extern "C" DECL_EXPORT void V3d_View_Center9F0E714F(
	void* instance,
	double* Xc,
	double* Yc);
extern "C" DECL_EXPORT void V3d_View_Size9F0E714F(
	void* instance,
	double* Width,
	double* Height);
extern "C" DECL_EXPORT void V3d_View_Eye9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT void V3d_View_FocalReferencePoint9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT void V3d_View_ProjReferenceAxe67C254F0(
	void* instance,
	int Xpix,
	int Ypix,
	double* XP,
	double* YP,
	double* ZP,
	double* VX,
	double* VY,
	double* VZ);
extern "C" DECL_EXPORT void V3d_View_Proj9282A951(
	void* instance,
	double* Vx,
	double* Vy,
	double* Vz);
extern "C" DECL_EXPORT void V3d_View_At9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT void V3d_View_Up9282A951(
	void* instance,
	double* Vx,
	double* Vy,
	double* Vz);
extern "C" DECL_EXPORT bool V3d_View_ZCueing9F0E714F(
	void* instance,
	double* Depth,
	double* Width);
extern "C" DECL_EXPORT int V3d_View_ZClipping9F0E714F(
	void* instance,
	double* Depth,
	double* Width);
extern "C" DECL_EXPORT void V3d_View_InitActiveLights(void* instance);
extern "C" DECL_EXPORT void V3d_View_NextActiveLights(void* instance);
extern "C" DECL_EXPORT void V3d_View_InitActivePlanes(void* instance);
extern "C" DECL_EXPORT void V3d_View_NextActivePlanes(void* instance);
extern "C" DECL_EXPORT void* V3d_View_Window(void* instance);
extern "C" DECL_EXPORT void V3d_View_Pan83917674(
	void* instance,
	int Dx,
	int Dy,
	double aZoomFactor);
extern "C" DECL_EXPORT void V3d_View_Zoom8C6D7843(
	void* instance,
	int X1,
	int Y1,
	int X2,
	int Y2);
extern "C" DECL_EXPORT void V3d_View_Zoom5107F6FE(
	void* instance,
	int X,
	int Y);
extern "C" DECL_EXPORT void V3d_View_StartZoomAtPoint5107F6FE(
	void* instance,
	int xpix,
	int ypix);
extern "C" DECL_EXPORT void V3d_View_ZoomAtPoint8C6D7843(
	void* instance,
	int mouseStartX,
	int mouseStartY,
	int mouseEndX,
	int mouseEndY);
extern "C" DECL_EXPORT void V3d_View_AxialScaleB5EB7D2C(
	void* instance,
	int Dx,
	int Dy,
	int Axis);
extern "C" DECL_EXPORT void V3d_View_StartRotation83917674(
	void* instance,
	int X,
	int Y,
	double zRotationThreshold);
extern "C" DECL_EXPORT void V3d_View_Rotation5107F6FE(
	void* instance,
	int X,
	int Y);
extern "C" DECL_EXPORT bool V3d_View_TransientManagerBeginDrawAE8C3818(
	void* instance,
	bool DoubleBuffer,
	bool RetainMode);
extern "C" DECL_EXPORT void V3d_View_TransientManagerClearDraw(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetAnimationModeOn(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetAnimationModeOff(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetDegenerateModeOn(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetDegenerateModeOff(void* instance);
extern "C" DECL_EXPORT void V3d_View_WindowFitAll8C6D7843(
	void* instance,
	int Xmin,
	int Ymin,
	int Xmax,
	int Ymax);
extern "C" DECL_EXPORT void V3d_View_Plot(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetGridA01EB949(
	void* instance,
	void* aPlane,
	void* aGrid);
extern "C" DECL_EXPORT double V3d_View_Tumble898DAFFC(
	void* instance,
	int NbImages,
	bool AnimationMode);
extern "C" DECL_EXPORT bool V3d_View_Print4B7FA157(
	void* instance,
	void* hPrnDC,
	bool showDialog,
	bool showBackground,
	char* filename,
	int printAlgorithm);
extern "C" DECL_EXPORT void V3d_View_EnableDepthTest461FC46A(
	void* instance,
	bool enable);
extern "C" DECL_EXPORT void V3d_View_EnableGLLight461FC46A(
	void* instance,
	bool enable);
extern "C" DECL_EXPORT bool V3d_View_IsEmpty(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetZClippingDepth(void* instance, double value);
extern "C" DECL_EXPORT void V3d_View_SetZClippingWidth(void* instance, double value);
extern "C" DECL_EXPORT void V3d_View_SetZClippingType(void* instance, int value);
extern "C" DECL_EXPORT void V3d_View_SetZCueingDepth(void* instance, double value);
extern "C" DECL_EXPORT void V3d_View_SetZCueingWidth(void* instance, double value);
extern "C" DECL_EXPORT void V3d_View_SetLayerMgr(void* instance, void* value);
extern "C" DECL_EXPORT bool V3d_View_ColorScaleIsDisplayed(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetScale(void* instance, double value);
extern "C" DECL_EXPORT double V3d_View_Scale(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetZSize(void* instance, double value);
extern "C" DECL_EXPORT double V3d_View_ZSize(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetDepth(void* instance, double value);
extern "C" DECL_EXPORT double V3d_View_Depth(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetTwist(void* instance, double value);
extern "C" DECL_EXPORT double V3d_View_Twist(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetShadingModel(void* instance, int value);
extern "C" DECL_EXPORT int V3d_View_ShadingModel(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetSurfaceDetail(void* instance, int value);
extern "C" DECL_EXPORT int V3d_View_SurfaceDetail(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetTransparency(void* instance, bool value);
extern "C" DECL_EXPORT bool V3d_View_Transparency(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetVisualization(void* instance, int value);
extern "C" DECL_EXPORT int V3d_View_Visualization(void* instance);
extern "C" DECL_EXPORT bool V3d_View_Antialiasing(void* instance);
extern "C" DECL_EXPORT bool V3d_View_IfMoreLights(void* instance);
extern "C" DECL_EXPORT bool V3d_View_MoreActiveLights(void* instance);
extern "C" DECL_EXPORT void* V3d_View_ActiveLight(void* instance);
extern "C" DECL_EXPORT bool V3d_View_IfMorePlanes(void* instance);
extern "C" DECL_EXPORT bool V3d_View_MoreActivePlanes(void* instance);
extern "C" DECL_EXPORT void* V3d_View_ActivePlane(void* instance);
extern "C" DECL_EXPORT void* V3d_View_Viewer(void* instance);
extern "C" DECL_EXPORT bool V3d_View_IfWindow(void* instance);
extern "C" DECL_EXPORT int V3d_View_Type(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetFocale(void* instance, double value);
extern "C" DECL_EXPORT double V3d_View_Focale(void* instance);
extern "C" DECL_EXPORT void* V3d_View_View(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetViewMapping(void* instance, void* value);
extern "C" DECL_EXPORT void* V3d_View_ViewMapping(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetViewOrientation(void* instance, void* value);
extern "C" DECL_EXPORT void* V3d_View_ViewOrientation(void* instance);
extern "C" DECL_EXPORT bool V3d_View_TransientManagerBeginAddDraw(void* instance);
extern "C" DECL_EXPORT bool V3d_View_AnimationModeIsOn(void* instance);
extern "C" DECL_EXPORT bool V3d_View_DegenerateModeIsOn(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetComputedMode(void* instance, bool value);
extern "C" DECL_EXPORT bool V3d_View_ComputedMode(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetPlotter(void* instance, void* value);
extern "C" DECL_EXPORT void V3d_View_SetGridGraphicValues(void* instance, void* value);
extern "C" DECL_EXPORT void V3d_View_SetGridActivity(void* instance, bool value);
extern "C" DECL_EXPORT void V3d_View_SetProjModel(void* instance, int value);
extern "C" DECL_EXPORT int V3d_View_ProjModel(void* instance);
extern "C" DECL_EXPORT void V3d_View_SetBackFacingModel(void* instance, int value);
extern "C" DECL_EXPORT int V3d_View_BackFacingModel(void* instance);
extern "C" DECL_EXPORT bool V3d_View_IsDepthTestEnabled(void* instance);
extern "C" DECL_EXPORT bool V3d_View_IsGLLightEnabled(void* instance);
extern "C" DECL_EXPORT void V3dView_Dtor(void* instance);

#endif
