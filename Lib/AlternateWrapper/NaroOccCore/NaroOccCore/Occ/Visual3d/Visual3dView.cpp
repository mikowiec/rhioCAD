#include "Visual3dView.h"
#include <Visual3d_View.hxx>

#include <Aspect_Background.hxx>
#include <Aspect_GraphicDriver.hxx>
#include <Aspect_Window.hxx>
#include <Visual3d_Layer.hxx>
#include <Visual3d_ViewManager.hxx>
#include <Visual3d_ViewMapping.hxx>
#include <Visual3d_ViewOrientation.hxx>

DECL_EXPORT void* Visual3d_View_CtorC8D72425(
	void* AManager)
{
		const Handle_Visual3d_ViewManager&  _AManager =*(const Handle_Visual3d_ViewManager *)AManager;
	return new Handle_Visual3d_View(new Visual3d_View(			
_AManager));
}
DECL_EXPORT void Visual3d_View_Activate(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->Activate();
}
DECL_EXPORT void Visual3d_View_Deactivate(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->Deactivate();
}
DECL_EXPORT void Visual3d_View_Redraw(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->Redraw();
}
DECL_EXPORT void Visual3d_View_Redraw8C6D7843(
	void* instance,
	int x,
	int y,
	int width,
	int height)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->Redraw(			
x,			
y,			
width,			
height);
}
DECL_EXPORT void Visual3d_View_Redraw7202F40D(
	void* instance,
	void* AnUnderLayer,
	void* AnOverLayer)
{
		const Handle_Visual3d_Layer&  _AnUnderLayer =*(const Handle_Visual3d_Layer *)AnUnderLayer;
		const Handle_Visual3d_Layer&  _AnOverLayer =*(const Handle_Visual3d_Layer *)AnOverLayer;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->Redraw(			
_AnUnderLayer,			
_AnOverLayer);
}
DECL_EXPORT void Visual3d_View_Redraw885CF247(
	void* instance,
	void* AnUnderLayer,
	void* AnOverLayer,
	int x,
	int y,
	int width,
	int height)
{
		const Handle_Visual3d_Layer&  _AnUnderLayer =*(const Handle_Visual3d_Layer *)AnUnderLayer;
		const Handle_Visual3d_Layer&  _AnOverLayer =*(const Handle_Visual3d_Layer *)AnOverLayer;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->Redraw(			
_AnUnderLayer,			
_AnOverLayer,			
x,			
y,			
width,			
height);
}
DECL_EXPORT void Visual3d_View_Remove(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->Remove();
}
DECL_EXPORT void Visual3d_View_Resized(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->Resized();
}
DECL_EXPORT void Visual3d_View_SetBackgroundImage5C59B37F(
	void* instance,
	char* FileName,
	int FillStyle,
	bool update)
{
		const Aspect_FillMethod _FillStyle =(const Aspect_FillMethod )FillStyle;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->SetBackgroundImage(			
FileName,			
_FillStyle,			
update);
}
DECL_EXPORT void Visual3d_View_SetBgImageStyle254163A9(
	void* instance,
	int FillStyle,
	bool update)
{
		const Aspect_FillMethod _FillStyle =(const Aspect_FillMethod )FillStyle;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->SetBgImageStyle(			
_FillStyle,			
update);
}
DECL_EXPORT void Visual3d_View_SetBgGradientStyle86DFD8CC(
	void* instance,
	int FillStyle,
	bool update)
{
		const Aspect_GradientFillMethod _FillStyle =(const Aspect_GradientFillMethod )FillStyle;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->SetBgGradientStyle(			
_FillStyle,			
update);
}
DECL_EXPORT void Visual3d_View_SetViewMappingDefault(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->SetViewMappingDefault();
}
DECL_EXPORT void Visual3d_View_SetViewOrientationDefault(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->SetViewOrientationDefault();
}
DECL_EXPORT void Visual3d_View_Update(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->Update();
}
DECL_EXPORT void Visual3d_View_Update7202F40D(
	void* instance,
	void* AnUnderLayer,
	void* AnOverLayer)
{
		const Handle_Visual3d_Layer&  _AnUnderLayer =*(const Handle_Visual3d_Layer *)AnUnderLayer;
		const Handle_Visual3d_Layer&  _AnOverLayer =*(const Handle_Visual3d_Layer *)AnOverLayer;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->Update(			
_AnUnderLayer,			
_AnOverLayer);
}
DECL_EXPORT void Visual3d_View_ViewMappingReset(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->ViewMappingReset();
}
DECL_EXPORT void Visual3d_View_ViewOrientationReset(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->ViewOrientationReset();
}
DECL_EXPORT void Visual3d_View_SetAnimationModeOff(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->SetAnimationModeOff();
}
DECL_EXPORT void Visual3d_View_ZBufferTriedronSetup9BCB825E(
	void* instance,
	int XColor,
	int YColor,
	int ZColor,
	double SizeRatio,
	double AxisDiametr,
	int NbFacettes)
{
		const Quantity_NameOfColor _XColor =(const Quantity_NameOfColor )XColor;
		const Quantity_NameOfColor _YColor =(const Quantity_NameOfColor )YColor;
		const Quantity_NameOfColor _ZColor =(const Quantity_NameOfColor )ZColor;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->ZBufferTriedronSetup(			
_XColor,			
_YColor,			
_ZColor,			
SizeRatio,			
AxisDiametr,			
NbFacettes);
}
DECL_EXPORT void Visual3d_View_TriedronDisplayE9A003B7(
	void* instance,
	int APosition,
	int AColor,
	double AScale,
	bool AsWireframe)
{
		const Aspect_TypeOfTriedronPosition _APosition =(const Aspect_TypeOfTriedronPosition )APosition;
		const Quantity_NameOfColor _AColor =(const Quantity_NameOfColor )AColor;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->TriedronDisplay(			
_APosition,			
_AColor,			
AScale,			
AsWireframe);
}
DECL_EXPORT void Visual3d_View_TriedronErase(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->TriedronErase();
}
DECL_EXPORT void Visual3d_View_TriedronEcho14CB0F5D(
	void* instance,
	int AType)
{
		const Aspect_TypeOfTriedronEcho _AType =(const Aspect_TypeOfTriedronEcho )AType;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->TriedronEcho(			
_AType);
}
DECL_EXPORT void Visual3d_View_GraduatedTrihedronDisplayC3638B35(
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
	int sizeOfValues)
{
		const TCollection_ExtendedString &  _xname =*(const TCollection_ExtendedString *)xname;
		const TCollection_ExtendedString &  _yname =*(const TCollection_ExtendedString *)yname;
		const TCollection_ExtendedString &  _zname =*(const TCollection_ExtendedString *)zname;
		const Quantity_Color &  _gridcolor =*(const Quantity_Color *)gridcolor;
		const Quantity_Color &  _xnamecolor =*(const Quantity_Color *)xnamecolor;
		const Quantity_Color &  _ynamecolor =*(const Quantity_Color *)ynamecolor;
		const Quantity_Color &  _znamecolor =*(const Quantity_Color *)znamecolor;
		const Quantity_Color &  _xcolor =*(const Quantity_Color *)xcolor;
		const Quantity_Color &  _ycolor =*(const Quantity_Color *)ycolor;
		const Quantity_Color &  _zcolor =*(const Quantity_Color *)zcolor;
		const TCollection_AsciiString &  _fontOfNames =*(const TCollection_AsciiString *)fontOfNames;
		const Font_FontAspect _styleOfNames =(const Font_FontAspect )styleOfNames;
		const TCollection_AsciiString &  _fontOfValues =*(const TCollection_AsciiString *)fontOfValues;
		const Font_FontAspect _styleOfValues =(const Font_FontAspect )styleOfValues;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->GraduatedTrihedronDisplay(			
_xname,			
_yname,			
_zname,			
xdrawname,			
ydrawname,			
zdrawname,			
xdrawvalues,			
ydrawvalues,			
zdrawvalues,			
drawgrid,			
drawaxes,			
nbx,			
nby,			
nbz,			
xoffset,			
yoffset,			
zoffset,			
xaxisoffset,			
yaxisoffset,			
zaxisoffset,			
xdrawtickmarks,			
ydrawtickmarks,			
zdrawtickmarks,			
xtickmarklength,			
ytickmarklength,			
ztickmarklength,			
_gridcolor,			
_xnamecolor,			
_ynamecolor,			
_znamecolor,			
_xcolor,			
_ycolor,			
_zcolor,			
_fontOfNames,			
_styleOfNames,			
sizeOfNames,			
_fontOfValues,			
_styleOfValues,			
sizeOfValues);
}
DECL_EXPORT void Visual3d_View_GraduatedTrihedronErase(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->GraduatedTrihedronErase();
}
DECL_EXPORT bool Visual3d_View_ContainsFacet(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return  	result->ContainsFacet();
}
DECL_EXPORT void Visual3d_View_MinMaxValuesBC7A5786(
	void* instance,
	double* XMin,
	double* YMin,
	double* ZMin,
	double* XMax,
	double* YMax,
	double* ZMax)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->MinMaxValues(			
*XMin,			
*YMin,			
*ZMin,			
*XMax,			
*YMax,			
*ZMax);
}
DECL_EXPORT void Visual3d_View_MinMaxValuesC2777E0C(
	void* instance,
	double* XMin,
	double* YMin,
	double* XMax,
	double* YMax)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->MinMaxValues(			
*XMin,			
*YMin,			
*XMax,			
*YMax);
}
DECL_EXPORT void Visual3d_View_ProjectsBC7A5786(
	void* instance,
	double AX,
	double AY,
	double AZ,
	double* APX,
	double* APY,
	double* APZ)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->Projects(			
AX,			
AY,			
AZ,			
*APX,			
*APY,			
*APZ);
}
DECL_EXPORT void* Visual3d_View_ViewMappingDefault(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return new Visual3d_ViewMapping( 	result->ViewMappingDefault());
}
DECL_EXPORT void* Visual3d_View_ViewOrientationDefault(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return new Visual3d_ViewOrientation( 	result->ViewOrientationDefault());
}
DECL_EXPORT void* Visual3d_View_Window(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return new Handle_Aspect_Window( 	result->Window());
}
DECL_EXPORT void Visual3d_View_Plot9190F42F(
	void* instance,
	void* APlotter)
{
		const Handle_Graphic3d_Plotter&  _APlotter =*(const Handle_Graphic3d_Plotter *)APlotter;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->Plot(			
_APlotter);
}
DECL_EXPORT bool Visual3d_View_Print3E41AD16(
	void* instance,
	void* AnUnderLayer,
	void* AnOverLayer,
	void* hPrnDC,
	bool showBackground,
	char* filename,
	int printAlgorithm,
	double theScaleFactor)
{
		const Handle_Visual3d_Layer&  _AnUnderLayer =*(const Handle_Visual3d_Layer *)AnUnderLayer;
		const Handle_Visual3d_Layer&  _AnOverLayer =*(const Handle_Visual3d_Layer *)AnOverLayer;
		const Aspect_PrintAlgo _printAlgorithm =(const Aspect_PrintAlgo )printAlgorithm;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return  	result->Print(			
_AnUnderLayer,			
_AnOverLayer,			
hPrnDC,			
showBackground,			
filename,			
_printAlgorithm,			
theScaleFactor);
}
DECL_EXPORT bool Visual3d_View_Print23A2F056(
	void* instance,
	void* hPrnDC,
	bool showBackground,
	char* filename,
	int printAlgorithm,
	double theScaleFactor)
{
		const Aspect_PrintAlgo _printAlgorithm =(const Aspect_PrintAlgo )printAlgorithm;
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return  	result->Print(			
hPrnDC,			
showBackground,			
filename,			
_printAlgorithm,			
theScaleFactor);
}
DECL_EXPORT void Visual3d_View_EnableDepthTest461FC46A(
	void* instance,
	bool enable)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->EnableDepthTest(			
enable);
}
DECL_EXPORT void Visual3d_View_EnableGLLight461FC46A(
	void* instance,
	bool enable)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
 	result->EnableGLLight(			
enable);
}
DECL_EXPORT void Visual3d_View_SetBackFacingModel(void* instance, int value)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
		result->SetBackFacingModel((const Visual3d_TypeOfBackfacingModel)value);
}

DECL_EXPORT int Visual3d_View_BackFacingModel(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return (int)	result->BackFacingModel();
}

DECL_EXPORT void Visual3d_View_SetAnimationModeOn(void* instance, bool value)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
		result->SetAnimationModeOn(value);
}

DECL_EXPORT bool Visual3d_View_AnimationModeIsOn(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->AnimationModeIsOn();
}

DECL_EXPORT bool Visual3d_View_DegenerateModeIsOn(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->DegenerateModeIsOn();
}

DECL_EXPORT void Visual3d_View_SetComputedMode(void* instance, bool value)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
		result->SetComputedMode(value);
}

DECL_EXPORT bool Visual3d_View_ComputedMode(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->ComputedMode();
}

DECL_EXPORT void Visual3d_View_SetBackground(void* instance, void* value)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
		result->SetBackground(*(const Aspect_Background *)value);
}

DECL_EXPORT void* Visual3d_View_Background(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	new Aspect_Background(	result->Background());
}

DECL_EXPORT bool Visual3d_View_IsActive(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->IsActive();
}

DECL_EXPORT bool Visual3d_View_IsDefined(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->IsDefined();
}

DECL_EXPORT bool Visual3d_View_IsDeleted(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->IsDeleted();
}

DECL_EXPORT int Visual3d_View_NumberOfDisplayedStructures(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->NumberOfDisplayedStructures();
}

DECL_EXPORT void Visual3d_View_SetViewMapping(void* instance, void* value)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
		result->SetViewMapping(*(const Visual3d_ViewMapping *)value);
}

DECL_EXPORT void* Visual3d_View_ViewMapping(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	new Visual3d_ViewMapping(	result->ViewMapping());
}

DECL_EXPORT void Visual3d_View_SetViewOrientation(void* instance, void* value)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
		result->SetViewOrientation(*(const Visual3d_ViewOrientation *)value);
}

DECL_EXPORT void* Visual3d_View_ViewOrientation(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	new Visual3d_ViewOrientation(	result->ViewOrientation());
}

DECL_EXPORT int Visual3d_View_LightLimit(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->LightLimit();
}

DECL_EXPORT int Visual3d_View_PlaneLimit(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->PlaneLimit();
}

DECL_EXPORT void* Visual3d_View_ViewManager(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	new Handle_Visual3d_ViewManager(	result->ViewManager());
}

DECL_EXPORT int Visual3d_View_Identification(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->Identification();
}

DECL_EXPORT void* Visual3d_View_GraphicDriver(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	new Handle_Aspect_GraphicDriver(	result->GraphicDriver());
}

DECL_EXPORT void Visual3d_View_SetTransparency(void* instance, bool value)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
		result->SetTransparency(value);
}

DECL_EXPORT bool Visual3d_View_ZBufferIsActivated(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->ZBufferIsActivated();
}

DECL_EXPORT void Visual3d_View_SetZBufferActivity(void* instance, int value)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
		result->SetZBufferActivity(value);
}

DECL_EXPORT void* Visual3d_View_UnderLayer(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	new Handle_Visual3d_Layer(	result->UnderLayer());
}

DECL_EXPORT void* Visual3d_View_OverLayer(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	new Handle_Visual3d_Layer(	result->OverLayer());
}

DECL_EXPORT bool Visual3d_View_IsDepthTestEnabled(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->IsDepthTestEnabled();
}

DECL_EXPORT bool Visual3d_View_IsGLLightEnabled(void* instance)
{
	Visual3d_View* result = (Visual3d_View*)(((Handle_Visual3d_View*)instance)->Access());
	return 	result->IsGLLightEnabled();
}

DECL_EXPORT void Visual3dView_Dtor(void* instance)
{
	delete (Handle_Visual3d_View*)instance;
}
