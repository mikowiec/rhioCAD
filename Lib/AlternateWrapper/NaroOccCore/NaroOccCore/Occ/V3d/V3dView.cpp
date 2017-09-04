#include "V3dView.h"
#include <V3d_View.hxx>

#include <Aspect_Window.hxx>
#include <Quantity_Color.hxx>
#include <V3d_Light.hxx>
#include <V3d_Plane.hxx>
#include <V3d_Viewer.hxx>
#include <Visual3d_View.hxx>
#include <Visual3d_ViewMapping.hxx>
#include <Visual3d_ViewOrientation.hxx>

DECL_EXPORT void V3d_View_SetWindow6DD76FB2(
	void* instance,
	void* IdWin)
{
		const Handle_Aspect_Window&  _IdWin =*(const Handle_Aspect_Window *)IdWin;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetWindow(			
_IdWin);
}
DECL_EXPORT void V3d_View_SetMagnifyD520CBEE(
	void* instance,
	void* IdWin,
	void* aPreviousView,
	int x1,
	int y1,
	int x2,
	int y2)
{
		const Handle_Aspect_Window&  _IdWin =*(const Handle_Aspect_Window *)IdWin;
		const Handle_V3d_View&  _aPreviousView =*(const Handle_V3d_View *)aPreviousView;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetMagnify(			
_IdWin,			
_aPreviousView,			
x1,			
y1,			
x2,			
y2);
}
DECL_EXPORT void V3d_View_Remove(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Remove();
}
DECL_EXPORT void V3d_View_Update(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Update();
}
DECL_EXPORT void V3d_View_Redraw(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Redraw();
}
DECL_EXPORT void V3d_View_Redraw8C6D7843(
	void* instance,
	int x,
	int y,
	int width,
	int height)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Redraw(			
x,			
y,			
width,			
height);
}
DECL_EXPORT void V3d_View_MustBeResized(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->MustBeResized();
}
DECL_EXPORT void V3d_View_DoMapping(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->DoMapping();
}
DECL_EXPORT void V3d_View_UpdateLights(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->UpdateLights();
}
DECL_EXPORT void V3d_View_SetBackgroundColor638950E1(
	void* instance,
	int Type,
	double V1,
	double V2,
	double V3)
{
		const Quantity_TypeOfColor _Type =(const Quantity_TypeOfColor )Type;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetBackgroundColor(			
_Type,			
V1,			
V2,			
V3);
}
DECL_EXPORT void V3d_View_SetBackgroundColor8FD7F48(
	void* instance,
	void* Color)
{
		const Quantity_Color &  _Color =*(const Quantity_Color *)Color;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetBackgroundColor(			
_Color);
}
DECL_EXPORT void V3d_View_SetBackgroundColor48F4F471(
	void* instance,
	int Name)
{
		const Quantity_NameOfColor _Name =(const Quantity_NameOfColor )Name;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetBackgroundColor(			
_Name);
}
DECL_EXPORT void V3d_View_SetBgGradientColorsA313F140(
	void* instance,
	void* Color1,
	void* Color2,
	int FillStyle,
	bool update)
{
		const Quantity_Color &  _Color1 =*(const Quantity_Color *)Color1;
		const Quantity_Color &  _Color2 =*(const Quantity_Color *)Color2;
		const Aspect_GradientFillMethod _FillStyle =(const Aspect_GradientFillMethod )FillStyle;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetBgGradientColors(			
_Color1,			
_Color2,			
_FillStyle,			
update);
}
DECL_EXPORT void V3d_View_SetBgGradientColors4216A027(
	void* instance,
	int Color1,
	int Color2,
	int FillStyle,
	bool update)
{
		const Quantity_NameOfColor _Color1 =(const Quantity_NameOfColor )Color1;
		const Quantity_NameOfColor _Color2 =(const Quantity_NameOfColor )Color2;
		const Aspect_GradientFillMethod _FillStyle =(const Aspect_GradientFillMethod )FillStyle;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetBgGradientColors(			
_Color1,			
_Color2,			
_FillStyle,			
update);
}
DECL_EXPORT void V3d_View_SetBgGradientStyle86DFD8CC(
	void* instance,
	int AMethod,
	bool update)
{
		const Aspect_GradientFillMethod _AMethod =(const Aspect_GradientFillMethod )AMethod;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetBgGradientStyle(			
_AMethod,			
update);
}
DECL_EXPORT void V3d_View_SetBackgroundImage5C59B37F(
	void* instance,
	char* FileName,
	int FillStyle,
	bool update)
{
		const Aspect_FillMethod _FillStyle =(const Aspect_FillMethod )FillStyle;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetBackgroundImage(			
FileName,			
_FillStyle,			
update);
}
DECL_EXPORT void V3d_View_SetBgImageStyle254163A9(
	void* instance,
	int FillStyle,
	bool update)
{
		const Aspect_FillMethod _FillStyle =(const Aspect_FillMethod )FillStyle;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetBgImageStyle(			
_FillStyle,			
update);
}
DECL_EXPORT void V3d_View_SetAxisBC7A5786(
	void* instance,
	double X,
	double Y,
	double Z,
	double Vx,
	double Vy,
	double Vz)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetAxis(			
X,			
Y,			
Z,			
Vx,			
Vy,			
Vz);
}
DECL_EXPORT void V3d_View_SetAntialiasingOn(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetAntialiasingOn();
}
DECL_EXPORT void V3d_View_SetAntialiasingOff(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetAntialiasingOff();
}
DECL_EXPORT void V3d_View_SetZCueingOn(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetZCueingOn();
}
DECL_EXPORT void V3d_View_SetZCueingOff(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetZCueingOff();
}
DECL_EXPORT void V3d_View_SetLightOn1C16FAC6(
	void* instance,
	void* MyLight)
{
		const Handle_V3d_Light&  _MyLight =*(const Handle_V3d_Light *)MyLight;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetLightOn(			
_MyLight);
}
DECL_EXPORT void V3d_View_SetLightOn(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetLightOn();
}
DECL_EXPORT void V3d_View_SetLightOff1C16FAC6(
	void* instance,
	void* MyLight)
{
		const Handle_V3d_Light&  _MyLight =*(const Handle_V3d_Light *)MyLight;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetLightOff(			
_MyLight);
}
DECL_EXPORT void V3d_View_SetLightOff(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetLightOff();
}
DECL_EXPORT bool V3d_View_IsActiveLight1C16FAC6(
	void* instance,
	void* aLight)
{
		const Handle_V3d_Light&  _aLight =*(const Handle_V3d_Light *)aLight;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return  	result->IsActiveLight(			
_aLight);
}
DECL_EXPORT void V3d_View_SetPlaneOn20B19CEF(
	void* instance,
	void* MyPlane)
{
		const Handle_V3d_Plane&  _MyPlane =*(const Handle_V3d_Plane *)MyPlane;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetPlaneOn(			
_MyPlane);
}
DECL_EXPORT void V3d_View_SetPlaneOn(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetPlaneOn();
}
DECL_EXPORT void V3d_View_SetPlaneOff20B19CEF(
	void* instance,
	void* MyPlane)
{
		const Handle_V3d_Plane&  _MyPlane =*(const Handle_V3d_Plane *)MyPlane;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetPlaneOff(			
_MyPlane);
}
DECL_EXPORT void V3d_View_SetPlaneOff(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetPlaneOff();
}
DECL_EXPORT bool V3d_View_IsActivePlane20B19CEF(
	void* instance,
	void* aPlane)
{
		const Handle_V3d_Plane&  _aPlane =*(const Handle_V3d_Plane *)aPlane;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return  	result->IsActivePlane(			
_aPlane);
}
DECL_EXPORT void V3d_View_ZBufferTriedronSetup9BCB825E(
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
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->ZBufferTriedronSetup(			
_XColor,			
_YColor,			
_ZColor,			
SizeRatio,			
AxisDiametr,			
NbFacettes);
}
DECL_EXPORT void V3d_View_TriedronDisplay4E80490A(
	void* instance,
	int APosition,
	int AColor,
	double AScale,
	int AMode)
{
		const Aspect_TypeOfTriedronPosition _APosition =(const Aspect_TypeOfTriedronPosition )APosition;
		const Quantity_NameOfColor _AColor =(const Quantity_NameOfColor )AColor;
		const V3d_TypeOfVisualization _AMode =(const V3d_TypeOfVisualization )AMode;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->TriedronDisplay(			
_APosition,			
_AColor,			
AScale,			
_AMode);
}
DECL_EXPORT void V3d_View_TriedronErase(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->TriedronErase();
}
DECL_EXPORT void V3d_View_TriedronEcho14CB0F5D(
	void* instance,
	int AType)
{
		const Aspect_TypeOfTriedronEcho _AType =(const Aspect_TypeOfTriedronEcho )AType;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->TriedronEcho(			
_AType);
}
//DECL_EXPORT void V3d_View_GetGraduatedTrihedronC3638B35(
//	void* instance,
//	void* xname,
//	void* yname,
//	void* zname,
//	bool* xdrawname,
//	bool* ydrawname,
//	bool* zdrawname,
//	bool* xdrawvalues,
//	bool* ydrawvalues,
//	bool* zdrawvalues,
//	bool* drawgrid,
//	bool* drawaxes,
//	int* nbx,
//	int* nby,
//	int* nbz,
//	int* xoffset,
//	int* yoffset,
//	int* zoffset,
//	int* xaxisoffset,
//	int* yaxisoffset,
//	int* zaxisoffset,
//	bool* xdrawtickmarks,
//	bool* ydrawtickmarks,
//	bool* zdrawtickmarks,
//	int* xtickmarklength,
//	int* ytickmarklength,
//	int* ztickmarklength,
//	void* gridcolor,
//	void* xnamecolor,
//	void* ynamecolor,
//	void* znamecolor,
//	void* xcolor,
//	void* ycolor,
//	void* zcolor,
//	void* fontOfNames,
//	int styleOfNames,
//	int* sizeOfNames,
//	void* fontOfValues,
//	int styleOfValues,
//	int* sizeOfValues)
//{
//		 TCollection_ExtendedString &  _xname =*( TCollection_ExtendedString *)xname;
//		 TCollection_ExtendedString &  _yname =*( TCollection_ExtendedString *)yname;
//		 TCollection_ExtendedString &  _zname =*( TCollection_ExtendedString *)zname;
//		 Quantity_Color &  _gridcolor =*( Quantity_Color *)gridcolor;
//		 Quantity_Color &  _xnamecolor =*( Quantity_Color *)xnamecolor;
//		 Quantity_Color &  _ynamecolor =*( Quantity_Color *)ynamecolor;
//		 Quantity_Color &  _znamecolor =*( Quantity_Color *)znamecolor;
//		 Quantity_Color &  _xcolor =*( Quantity_Color *)xcolor;
//		 Quantity_Color &  _ycolor =*( Quantity_Color *)ycolor;
//		 Quantity_Color &  _zcolor =*( Quantity_Color *)zcolor;
//		 TCollection_AsciiString &  _fontOfNames =*( TCollection_AsciiString *)fontOfNames;
//		 Font_FontAspect _styleOfNames =( Font_FontAspect )styleOfNames;
//		 TCollection_AsciiString &  _fontOfValues =*( TCollection_AsciiString *)fontOfValues;
//		 Font_FontAspect _styleOfValues =( Font_FontAspect )styleOfValues;
//	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
// 	result->GetGraduatedTrihedron(			
//_xname,			
//_yname,			
//_zname,			
//*xdrawname,			
//*ydrawname,			
//*zdrawname,			
//*xdrawvalues,			
//*ydrawvalues,			
//*zdrawvalues,			
//*drawgrid,			
//*drawaxes,			
//*nbx,			
//*nby,			
//*nbz,			
//*xoffset,			
//*yoffset,			
//*zoffset,			
//*xaxisoffset,			
//*yaxisoffset,			
//*zaxisoffset,			
//*xdrawtickmarks,			
//*ydrawtickmarks,			
//*zdrawtickmarks,			
//*xtickmarklength,			
//*ytickmarklength,			
//*ztickmarklength,			
//_gridcolor,			
//_xnamecolor,			
//_ynamecolor,			
//_znamecolor,			
//_xcolor,			
//_ycolor,			
//_zcolor,			
//_fontOfNames,			
//_styleOfNames,			
//*sizeOfNames,			
//_fontOfValues,			
//_styleOfValues,			
//*sizeOfValues);
//}
DECL_EXPORT void V3d_View_GraduatedTrihedronDisplayC3638B35(
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
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
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
DECL_EXPORT void V3d_View_GraduatedTrihedronErase(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->GraduatedTrihedronErase();
}
DECL_EXPORT void V3d_View_ColorScaleDisplay(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->ColorScaleDisplay();
}
DECL_EXPORT void V3d_View_ColorScaleErase(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->ColorScaleErase();
}
DECL_EXPORT void V3d_View_SetFront(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetFront();
}
DECL_EXPORT void V3d_View_Rotate1B801FD4(
	void* instance,
	double Ax,
	double Ay,
	double Az,
	bool Start)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Rotate(			
Ax,			
Ay,			
Az,			
Start);
}
DECL_EXPORT void V3d_View_Rotate51E06B8D(
	void* instance,
	double Ax,
	double Ay,
	double Az,
	double X,
	double Y,
	double Z,
	bool Start)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Rotate(			
Ax,			
Ay,			
Az,			
X,			
Y,			
Z,			
Start);
}
DECL_EXPORT void V3d_View_Rotate45D32271(
	void* instance,
	int Axe,
	double Angle,
	double X,
	double Y,
	double Z,
	bool Start)
{
		const V3d_TypeOfAxe _Axe =(const V3d_TypeOfAxe )Axe;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Rotate(			
_Axe,			
Angle,			
X,			
Y,			
Z,			
Start);
}
DECL_EXPORT void V3d_View_RotateB8D50DF4(
	void* instance,
	int Axe,
	double Angle,
	bool Start)
{
		const V3d_TypeOfAxe _Axe =(const V3d_TypeOfAxe )Axe;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Rotate(			
_Axe,			
Angle,			
Start);
}
DECL_EXPORT void V3d_View_RotateC85E5E0F(
	void* instance,
	double Angle,
	bool Start)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Rotate(			
Angle,			
Start);
}
DECL_EXPORT void V3d_View_Move1B801FD4(
	void* instance,
	double Dx,
	double Dy,
	double Dz,
	bool Start)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Move(			
Dx,			
Dy,			
Dz,			
Start);
}
DECL_EXPORT void V3d_View_MoveB8D50DF4(
	void* instance,
	int Axe,
	double Length,
	bool Start)
{
		const V3d_TypeOfAxe _Axe =(const V3d_TypeOfAxe )Axe;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Move(			
_Axe,			
Length,			
Start);
}
DECL_EXPORT void V3d_View_MoveC85E5E0F(
	void* instance,
	double Length,
	bool Start)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Move(			
Length,			
Start);
}
DECL_EXPORT void V3d_View_Translate1B801FD4(
	void* instance,
	double Dx,
	double Dy,
	double Dz,
	bool Start)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Translate(			
Dx,			
Dy,			
Dz,			
Start);
}
DECL_EXPORT void V3d_View_TranslateB8D50DF4(
	void* instance,
	int Axe,
	double Length,
	bool Start)
{
		const V3d_TypeOfAxe _Axe =(const V3d_TypeOfAxe )Axe;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Translate(			
_Axe,			
Length,			
Start);
}
DECL_EXPORT void V3d_View_TranslateC85E5E0F(
	void* instance,
	double Length,
	bool Start)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Translate(			
Length,			
Start);
}
DECL_EXPORT void V3d_View_Place83917674(
	void* instance,
	int x,
	int y,
	double aZoomFactor)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Place(			
x,			
y,			
aZoomFactor);
}
DECL_EXPORT void V3d_View_Turn1B801FD4(
	void* instance,
	double Ax,
	double Ay,
	double Az,
	bool Start)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Turn(			
Ax,			
Ay,			
Az,			
Start);
}
DECL_EXPORT void V3d_View_TurnB8D50DF4(
	void* instance,
	int Axe,
	double Angle,
	bool Start)
{
		const V3d_TypeOfAxe _Axe =(const V3d_TypeOfAxe )Axe;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Turn(			
_Axe,			
Angle,			
Start);
}
DECL_EXPORT void V3d_View_TurnC85E5E0F(
	void* instance,
	double Angle,
	bool Start)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Turn(			
Angle,			
Start);
}
DECL_EXPORT void V3d_View_SetEye9282A951(
	void* instance,
	double X,
	double Y,
	double Z)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetEye(			
X,			
Y,			
Z);
}
DECL_EXPORT void V3d_View_SetProj9282A951(
	void* instance,
	double Vx,
	double Vy,
	double Vz)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetProj(			
Vx,			
Vy,			
Vz);
}
DECL_EXPORT void V3d_View_SetProj17AA5025(
	void* instance,
	int Orientation)
{
		const V3d_TypeOfOrientation _Orientation =(const V3d_TypeOfOrientation )Orientation;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetProj(			
_Orientation);
}
DECL_EXPORT void V3d_View_SetAt9282A951(
	void* instance,
	double X,
	double Y,
	double Z)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetAt(			
X,			
Y,			
Z);
}
DECL_EXPORT void V3d_View_SetUp9282A951(
	void* instance,
	double Vx,
	double Vy,
	double Vz)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetUp(			
Vx,			
Vy,			
Vz);
}
DECL_EXPORT void V3d_View_SetUp17AA5025(
	void* instance,
	int Orientation)
{
		const V3d_TypeOfOrientation _Orientation =(const V3d_TypeOfOrientation )Orientation;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetUp(			
_Orientation);
}
DECL_EXPORT void V3d_View_SetViewOrientationDefault(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetViewOrientationDefault();
}
DECL_EXPORT void V3d_View_ResetViewOrientation(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->ResetViewOrientation();
}
DECL_EXPORT void V3d_View_Panning1B801FD4(
	void* instance,
	double Dx,
	double Dy,
	double aZoomFactor,
	bool Start)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Panning(			
Dx,			
Dy,			
aZoomFactor,			
Start);
}
DECL_EXPORT void V3d_View_SetCenter9F0E714F(
	void* instance,
	double Xc,
	double Yc)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetCenter(			
Xc,			
Yc);
}
DECL_EXPORT void V3d_View_SetCenter5107F6FE(
	void* instance,
	int X,
	int Y)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetCenter(			
X,			
Y);
}
DECL_EXPORT void V3d_View_SetSizeD82819F3(
	void* instance,
	double Size)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetSize(			
Size);
}
DECL_EXPORT void V3d_View_SetZoomC85E5E0F(
	void* instance,
	double Coef,
	bool Start)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetZoom(			
Coef,			
Start);
}
DECL_EXPORT void V3d_View_SetAxialScale9282A951(
	void* instance,
	double Sx,
	double Sy,
	double Sz)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetAxialScale(			
Sx,			
Sy,			
Sz);
}
DECL_EXPORT void V3d_View_FitAll7B00BEA(
	void* instance,
	double Coef,
	bool FitZ,
	bool update)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->FitAll(			
Coef,			
FitZ,			
update);
}
DECL_EXPORT void V3d_View_ZFitAllD82819F3(
	void* instance,
	double Coef)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->ZFitAll(			
Coef);
}
DECL_EXPORT void V3d_View_DepthFitAll9F0E714F(
	void* instance,
	double Aspect,
	double Margin)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->DepthFitAll(			
Aspect,			
Margin);
}
DECL_EXPORT void V3d_View_FitAllC2777E0C(
	void* instance,
	double Umin,
	double Vmin,
	double Umax,
	double Vmax)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->FitAll(			
Umin,			
Vmin,			
Umax,			
Vmax);
}
DECL_EXPORT void V3d_View_WindowFit8C6D7843(
	void* instance,
	int Xmin,
	int Ymin,
	int Xmax,
	int Ymax)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->WindowFit(			
Xmin,			
Ymin,			
Xmax,			
Ymax);
}
DECL_EXPORT void V3d_View_SetViewingVolumeBC7A5786(
	void* instance,
	double Left,
	double Right,
	double Bottom,
	double Top,
	double ZNear,
	double ZFar)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetViewingVolume(			
Left,			
Right,			
Bottom,			
Top,			
ZNear,			
ZFar);
}
DECL_EXPORT void V3d_View_SetViewMappingDefault(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetViewMappingDefault();
}
DECL_EXPORT void V3d_View_ResetViewMapping(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->ResetViewMapping();
}
DECL_EXPORT void V3d_View_Reset461FC46A(
	void* instance,
	bool update)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Reset(			
update);
}
DECL_EXPORT double V3d_View_ConvertE8219145(
	void* instance,
	int Vp)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return  	result->Convert(			
Vp);
}
DECL_EXPORT void V3d_View_ConvertB83D31A8(
	void* instance,
	int Xp,
	int Yp,
	double* Xv,
	double* Yv)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Convert(			
Xp,			
Yp,			
*Xv,			
*Yv);
}
DECL_EXPORT int V3d_View_ConvertD82819F3(
	void* instance,
	double Vv)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return  	result->Convert(			
Vv);
}
DECL_EXPORT void V3d_View_Convert852507E(
	void* instance,
	double Xv,
	double Yv,
	int* Xp,
	int* Yp)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Convert(			
Xv,			
Yv,			
*Xp,			
*Yp);
}
DECL_EXPORT void V3d_View_Convert636CFDD5(
	void* instance,
	int Xp,
	int Yp,
	double* X,
	double* Y,
	double* Z)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Convert(			
Xp,			
Yp,			
*X,			
*Y,			
*Z);
}
DECL_EXPORT void V3d_View_ConvertWithProj67C254F0(
	void* instance,
	int Xp,
	int Yp,
	double* X,
	double* Y,
	double* Z,
	double* Vx,
	double* Vy,
	double* Vz)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->ConvertWithProj(			
Xp,			
Yp,			
*X,			
*Y,			
*Z,			
*Vx,			
*Vy,			
*Vz);
}
DECL_EXPORT void V3d_View_ConvertToGrid636CFDD5(
	void* instance,
	int Xp,
	int Yp,
	double* Xg,
	double* Yg,
	double* Zg)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->ConvertToGrid(			
Xp,			
Yp,			
*Xg,			
*Yg,			
*Zg);
}
DECL_EXPORT void V3d_View_ConvertToGridBC7A5786(
	void* instance,
	double X,
	double Y,
	double Z,
	double* Xg,
	double* Yg,
	double* Zg)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->ConvertToGrid(			
X,			
Y,			
Z,			
*Xg,			
*Yg,			
*Zg);
}
DECL_EXPORT void V3d_View_Convert94A49759(
	void* instance,
	double X,
	double Y,
	double Z,
	int* Xp,
	int* Yp)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Convert(			
X,			
Y,			
Z,			
*Xp,			
*Yp);
}
DECL_EXPORT void V3d_View_Project216AF150(
	void* instance,
	double X,
	double Y,
	double Z,
	double* Xp,
	double* Yp)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Project(			
X,			
Y,			
Z,			
*Xp,			
*Yp);
}
DECL_EXPORT void V3d_View_BackgroundColor638950E1(
	void* instance,
	int Type,
	double* V1,
	double* V2,
	double* V3)
{
		const Quantity_TypeOfColor _Type =(const Quantity_TypeOfColor )Type;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->BackgroundColor(			
_Type,			
*V1,			
*V2,			
*V3);
}
DECL_EXPORT void* V3d_View_BackgroundColor(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return new Quantity_Color( 	result->BackgroundColor());
}
DECL_EXPORT void V3d_View_GradientBackgroundColorsCF0F9433(
	void* instance,
	void* Color1,
	void* Color2)
{
		 Quantity_Color &  _Color1 =*( Quantity_Color *)Color1;
		 Quantity_Color &  _Color2 =*( Quantity_Color *)Color2;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->GradientBackgroundColors(			
_Color1,			
_Color2);
}
DECL_EXPORT void V3d_View_AxialScale9282A951(
	void* instance,
	double* Sx,
	double* Sy,
	double* Sz)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->AxialScale(			
*Sx,			
*Sy,			
*Sz);
}
DECL_EXPORT void V3d_View_Center9F0E714F(
	void* instance,
	double* Xc,
	double* Yc)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Center(			
*Xc,			
*Yc);
}
DECL_EXPORT void V3d_View_Size9F0E714F(
	void* instance,
	double* Width,
	double* Height)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Size(			
*Width,			
*Height);
}
DECL_EXPORT void V3d_View_Eye9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Eye(			
*X,			
*Y,			
*Z);
}
DECL_EXPORT void V3d_View_FocalReferencePoint9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->FocalReferencePoint(			
*X,			
*Y,			
*Z);
}
DECL_EXPORT void V3d_View_ProjReferenceAxe67C254F0(
	void* instance,
	int Xpix,
	int Ypix,
	double* XP,
	double* YP,
	double* ZP,
	double* VX,
	double* VY,
	double* VZ)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->ProjReferenceAxe(			
Xpix,			
Ypix,			
*XP,			
*YP,			
*ZP,			
*VX,			
*VY,			
*VZ);
}
DECL_EXPORT void V3d_View_Proj9282A951(
	void* instance,
	double* Vx,
	double* Vy,
	double* Vz)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Proj(			
*Vx,			
*Vy,			
*Vz);
}
DECL_EXPORT void V3d_View_At9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->At(			
*X,			
*Y,			
*Z);
}
DECL_EXPORT void V3d_View_Up9282A951(
	void* instance,
	double* Vx,
	double* Vy,
	double* Vz)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Up(			
*Vx,			
*Vy,			
*Vz);
}
DECL_EXPORT bool V3d_View_ZCueing9F0E714F(
	void* instance,
	double* Depth,
	double* Width)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return  	result->ZCueing(			
*Depth,			
*Width);
}
DECL_EXPORT int V3d_View_ZClipping9F0E714F(
	void* instance,
	double* Depth,
	double* Width)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return  	result->ZClipping(			
*Depth,			
*Width);
}
DECL_EXPORT void V3d_View_InitActiveLights(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->InitActiveLights();
}
DECL_EXPORT void V3d_View_NextActiveLights(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->NextActiveLights();
}
DECL_EXPORT void V3d_View_InitActivePlanes(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->InitActivePlanes();
}
DECL_EXPORT void V3d_View_NextActivePlanes(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->NextActivePlanes();
}
DECL_EXPORT void* V3d_View_Window(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return new Handle_Aspect_Window( 	result->Window());
}
DECL_EXPORT void V3d_View_Pan83917674(
	void* instance,
	int Dx,
	int Dy,
	double aZoomFactor)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Pan(			
Dx,			
Dy,			
aZoomFactor);
}
DECL_EXPORT void V3d_View_Zoom8C6D7843(
	void* instance,
	int X1,
	int Y1,
	int X2,
	int Y2)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Zoom(			
X1,			
Y1,			
X2,			
Y2);
}
DECL_EXPORT void V3d_View_Zoom5107F6FE(
	void* instance,
	int X,
	int Y)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Zoom(			
X,			
Y);
}
DECL_EXPORT void V3d_View_StartZoomAtPoint5107F6FE(
	void* instance,
	int xpix,
	int ypix)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->StartZoomAtPoint(			
xpix,			
ypix);
}
DECL_EXPORT void V3d_View_ZoomAtPoint8C6D7843(
	void* instance,
	int mouseStartX,
	int mouseStartY,
	int mouseEndX,
	int mouseEndY)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->ZoomAtPoint(			
mouseStartX,			
mouseStartY,			
mouseEndX,			
mouseEndY);
}
DECL_EXPORT void V3d_View_AxialScaleB5EB7D2C(
	void* instance,
	int Dx,
	int Dy,
	int Axis)
{
		const V3d_TypeOfAxe _Axis =(const V3d_TypeOfAxe )Axis;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->AxialScale(			
Dx,			
Dy,			
_Axis);
}
DECL_EXPORT void V3d_View_StartRotation83917674(
	void* instance,
	int X,
	int Y,
	double zRotationThreshold)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->StartRotation(			
X,			
Y,			
zRotationThreshold);
}
DECL_EXPORT void V3d_View_Rotation5107F6FE(
	void* instance,
	int X,
	int Y)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Rotation(			
X,			
Y);
}
DECL_EXPORT bool V3d_View_TransientManagerBeginDrawAE8C3818(
	void* instance,
	bool DoubleBuffer,
	bool RetainMode)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return  	result->TransientManagerBeginDraw(			
DoubleBuffer,			
RetainMode);
}
DECL_EXPORT void V3d_View_TransientManagerClearDraw(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->TransientManagerClearDraw();
}
DECL_EXPORT void V3d_View_SetAnimationModeOn(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetAnimationModeOn();
}
DECL_EXPORT void V3d_View_SetAnimationModeOff(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetAnimationModeOff();
}
DECL_EXPORT void V3d_View_SetDegenerateModeOn(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetDegenerateModeOn();
}
DECL_EXPORT void V3d_View_SetDegenerateModeOff(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetDegenerateModeOff();
}
DECL_EXPORT void V3d_View_WindowFitAll8C6D7843(
	void* instance,
	int Xmin,
	int Ymin,
	int Xmax,
	int Ymax)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->WindowFitAll(			
Xmin,			
Ymin,			
Xmax,			
Ymax);
}
DECL_EXPORT void V3d_View_Plot(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->Plot();
}
DECL_EXPORT void V3d_View_SetGridA01EB949(
	void* instance,
	void* aPlane,
	void* aGrid)
{
		const gp_Ax3 &  _aPlane =*(const gp_Ax3 *)aPlane;
		const Handle_Aspect_Grid&  _aGrid =*(const Handle_Aspect_Grid *)aGrid;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->SetGrid(			
_aPlane,			
_aGrid);
}
DECL_EXPORT double V3d_View_Tumble898DAFFC(
	void* instance,
	int NbImages,
	bool AnimationMode)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return  	result->Tumble(			
NbImages,			
AnimationMode);
}
DECL_EXPORT bool V3d_View_Print4B7FA157(
	void* instance,
	void* hPrnDC,
	bool showDialog,
	bool showBackground,
	char* filename,
	int printAlgorithm)
{
		const Aspect_PrintAlgo _printAlgorithm =(const Aspect_PrintAlgo )printAlgorithm;
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return  	result->Print(			
hPrnDC,			
showDialog,			
showBackground,			
filename,			
_printAlgorithm);
}
DECL_EXPORT void V3d_View_EnableDepthTest461FC46A(
	void* instance,
	bool enable)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->EnableDepthTest(			
enable);
}
DECL_EXPORT void V3d_View_EnableGLLight461FC46A(
	void* instance,
	bool enable)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
 	result->EnableGLLight(			
enable);
}
DECL_EXPORT bool V3d_View_IsEmpty(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->IsEmpty();
}

DECL_EXPORT void V3d_View_SetZClippingDepth(void* instance, double value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetZClippingDepth(value);
}

DECL_EXPORT void V3d_View_SetZClippingWidth(void* instance, double value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetZClippingWidth(value);
}

DECL_EXPORT void V3d_View_SetZClippingType(void* instance, int value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetZClippingType((const V3d_TypeOfZclipping)value);
}

DECL_EXPORT void V3d_View_SetZCueingDepth(void* instance, double value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetZCueingDepth(value);
}

DECL_EXPORT void V3d_View_SetZCueingWidth(void* instance, double value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetZCueingWidth(value);
}

DECL_EXPORT void V3d_View_SetLayerMgr(void* instance, void* value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetLayerMgr(*(const Handle_V3d_LayerMgr *)value);
}

DECL_EXPORT bool V3d_View_ColorScaleIsDisplayed(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->ColorScaleIsDisplayed();
}

DECL_EXPORT void V3d_View_SetScale(void* instance, double value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetScale(value);
}

DECL_EXPORT double V3d_View_Scale(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->Scale();
}

DECL_EXPORT void V3d_View_SetZSize(void* instance, double value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetZSize(value);
}

DECL_EXPORT double V3d_View_ZSize(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->ZSize();
}

DECL_EXPORT void V3d_View_SetDepth(void* instance, double value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetDepth(value);
}

DECL_EXPORT double V3d_View_Depth(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->Depth();
}

DECL_EXPORT void V3d_View_SetTwist(void* instance, double value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetTwist(value);
}

DECL_EXPORT double V3d_View_Twist(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->Twist();
}

DECL_EXPORT void V3d_View_SetShadingModel(void* instance, int value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetShadingModel((const V3d_TypeOfShadingModel)value);
}

DECL_EXPORT int V3d_View_ShadingModel(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return (int)	result->ShadingModel();
}

DECL_EXPORT void V3d_View_SetSurfaceDetail(void* instance, int value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetSurfaceDetail((const V3d_TypeOfSurfaceDetail)value);
}

DECL_EXPORT int V3d_View_SurfaceDetail(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return (int)	result->SurfaceDetail();
}

DECL_EXPORT void V3d_View_SetTransparency(void* instance, bool value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetTransparency(value);
}

DECL_EXPORT bool V3d_View_Transparency(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->Transparency();
}

DECL_EXPORT void V3d_View_SetVisualization(void* instance, int value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetVisualization((const V3d_TypeOfVisualization)value);
}

DECL_EXPORT int V3d_View_Visualization(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return (int)	result->Visualization();
}

DECL_EXPORT bool V3d_View_Antialiasing(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->Antialiasing();
}

DECL_EXPORT bool V3d_View_IfMoreLights(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->IfMoreLights();
}

DECL_EXPORT bool V3d_View_MoreActiveLights(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->MoreActiveLights();
}

DECL_EXPORT void* V3d_View_ActiveLight(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	new Handle_V3d_Light(	result->ActiveLight());
}

DECL_EXPORT bool V3d_View_IfMorePlanes(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->IfMorePlanes();
}

DECL_EXPORT bool V3d_View_MoreActivePlanes(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->MoreActivePlanes();
}

DECL_EXPORT void* V3d_View_ActivePlane(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	new Handle_V3d_Plane(	result->ActivePlane());
}

DECL_EXPORT void* V3d_View_Viewer(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	new Handle_V3d_Viewer(	result->Viewer());
}

DECL_EXPORT bool V3d_View_IfWindow(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->IfWindow();
}

DECL_EXPORT int V3d_View_Type(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT void V3d_View_SetFocale(void* instance, double value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetFocale(value);
}

DECL_EXPORT double V3d_View_Focale(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->Focale();
}

DECL_EXPORT void* V3d_View_View(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	new Handle_Visual3d_View(	result->View());
}

DECL_EXPORT void V3d_View_SetViewMapping(void* instance, void* value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetViewMapping(*(const Visual3d_ViewMapping *)value);
}

DECL_EXPORT void* V3d_View_ViewMapping(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	new Visual3d_ViewMapping(	result->ViewMapping());
}

DECL_EXPORT void V3d_View_SetViewOrientation(void* instance, void* value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetViewOrientation(*(const Visual3d_ViewOrientation *)value);
}

DECL_EXPORT void* V3d_View_ViewOrientation(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	new Visual3d_ViewOrientation(	result->ViewOrientation());
}

DECL_EXPORT bool V3d_View_TransientManagerBeginAddDraw(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->TransientManagerBeginAddDraw();
}

DECL_EXPORT bool V3d_View_AnimationModeIsOn(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->AnimationModeIsOn();
}

DECL_EXPORT bool V3d_View_DegenerateModeIsOn(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->DegenerateModeIsOn();
}

DECL_EXPORT void V3d_View_SetComputedMode(void* instance, bool value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetComputedMode(value);
}

DECL_EXPORT bool V3d_View_ComputedMode(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->ComputedMode();
}

DECL_EXPORT void V3d_View_SetPlotter(void* instance, void* value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetPlotter(*(const Handle_Graphic3d_Plotter *)value);
}

DECL_EXPORT void V3d_View_SetGridGraphicValues(void* instance, void* value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetGridGraphicValues(*(const Handle_Aspect_Grid *)value);
}

DECL_EXPORT void V3d_View_SetGridActivity(void* instance, bool value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetGridActivity(value);
}

DECL_EXPORT void V3d_View_SetProjModel(void* instance, int value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetProjModel((const V3d_TypeOfProjectionModel)value);
}

DECL_EXPORT int V3d_View_ProjModel(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return (int)	result->ProjModel();
}

DECL_EXPORT void V3d_View_SetBackFacingModel(void* instance, int value)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
		result->SetBackFacingModel((const V3d_TypeOfBackfacingModel)value);
}

DECL_EXPORT int V3d_View_BackFacingModel(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return (int)	result->BackFacingModel();
}

DECL_EXPORT bool V3d_View_IsDepthTestEnabled(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->IsDepthTestEnabled();
}

DECL_EXPORT bool V3d_View_IsGLLightEnabled(void* instance)
{
	V3d_View* result = (V3d_View*)(((Handle_V3d_View*)instance)->Access());
	return 	result->IsGLLightEnabled();
}

DECL_EXPORT void V3dView_Dtor(void* instance)
{
	delete (Handle_V3d_View*)instance;
}
