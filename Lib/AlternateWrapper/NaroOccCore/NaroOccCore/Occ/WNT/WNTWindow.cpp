#include "WNTWindow.h"
#include <WNT_Window.hxx>


DECL_EXPORT void* WNT_Window_CtorB0EE1CA(
	void* aDevice,
	char* aTitle,
	void* aClass,
	double aStyle,
	double Xc,
	double Yc,
	double aWidth,
	double aHeight,
	int aBackColor,
	void* aParent,
	void* aMenu,
	void* aClientStruct)
{
		const Handle_WNT_GraphicDevice&  _aDevice =*(const Handle_WNT_GraphicDevice *)aDevice;
		const Handle_WNT_WClass&  _aClass =*(const Handle_WNT_WClass *)aClass;
		const Quantity_NameOfColor _aBackColor =(const Quantity_NameOfColor )aBackColor;
	return new Handle_WNT_Window(new WNT_Window(			
_aDevice,			
aTitle,			
_aClass,			
aStyle,			
Xc,			
Yc,			
aWidth,			
aHeight,			
_aBackColor,			
aParent,			
aMenu,			
aClientStruct));
}
DECL_EXPORT void* WNT_Window_Ctor83D53D04(
	void* theDevice,
	char* theTitle,
	void* theClass,
	double theStyle,
	int thePxLeft,
	int thePxTop,
	int thePxWidth,
	int thePxHeight,
	int theBackColor,
	void* theParent,
	void* theMenu,
	void* theClientStruct)
{
		const Handle_WNT_GraphicDevice&  _theDevice =*(const Handle_WNT_GraphicDevice *)theDevice;
		const Handle_WNT_WClass&  _theClass =*(const Handle_WNT_WClass *)theClass;
		const Quantity_NameOfColor _theBackColor =(const Quantity_NameOfColor )theBackColor;
	return new Handle_WNT_Window(new WNT_Window(			
_theDevice,			
theTitle,			
_theClass,			
theStyle,			
thePxLeft,			
thePxTop,			
thePxWidth,			
thePxHeight,			
_theBackColor,			
theParent,			
theMenu,			
theClientStruct));
}
DECL_EXPORT void* WNT_Window_Ctor9F345CFF(
	void* aDevice,
	void* aHandle,
	int aBackColor)
{
		const Handle_WNT_GraphicDevice&  _aDevice =*(const Handle_WNT_GraphicDevice *)aDevice;
		const Quantity_NameOfColor _aBackColor =(const Quantity_NameOfColor )aBackColor;
	return new Handle_WNT_Window(new WNT_Window(			
_aDevice,			
aHandle,			
_aBackColor));
}
DECL_EXPORT void* WNT_Window_CtorBCEC06DC(
	void* aDevice,
	int aPart1,
	int aPart2,
	int aBackColor)
{
		const Handle_WNT_GraphicDevice&  _aDevice =*(const Handle_WNT_GraphicDevice *)aDevice;
		const Quantity_NameOfColor _aBackColor =(const Quantity_NameOfColor )aBackColor;
	return new Handle_WNT_Window(new WNT_Window(			
_aDevice,			
aPart1,			
aPart2,			
_aBackColor));
}
DECL_EXPORT void WNT_Window_SetBackground60C2D936(
	void* instance,
	void* Background)
{
		const Aspect_Background &  _Background =*(const Aspect_Background *)Background;
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->SetBackground(			
_Background);
}
DECL_EXPORT void WNT_Window_SetBackground48F4F471(
	void* instance,
	int BackColor)
{
		const Quantity_NameOfColor _BackColor =(const Quantity_NameOfColor )BackColor;
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->SetBackground(			
_BackColor);
}
DECL_EXPORT void WNT_Window_SetBackground8FD7F48(
	void* instance,
	void* color)
{
		const Quantity_Color &  _color =*(const Quantity_Color *)color;
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->SetBackground(			
_color);
}
DECL_EXPORT void WNT_Window_SetBackgroundF9F0DFF(
	void* instance,
	void* aBackPixmap)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->SetBackground(			
aBackPixmap);
}
DECL_EXPORT bool WNT_Window_SetBackground7B49F0A3(
	void* instance,
	char* aName,
	int aMethod)
{
		const Aspect_FillMethod _aMethod =(const Aspect_FillMethod )aMethod;
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return  	result->SetBackground(			
aName,			
_aMethod);
}
DECL_EXPORT void WNT_Window_SetBackgroundEE919A89(
	void* instance,
	void* aCol1,
	void* aCol2,
	int aMethod)
{
		const Quantity_Color &  _aCol1 =*(const Quantity_Color *)aCol1;
		const Quantity_Color &  _aCol2 =*(const Quantity_Color *)aCol2;
		const Aspect_GradientFillMethod _aMethod =(const Aspect_GradientFillMethod )aMethod;
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->SetBackground(			
_aCol1,			
_aCol2,			
_aMethod);
}
DECL_EXPORT void WNT_Window_SetIconB5B2B94C(
	void* instance,
	void* anIcon,
	char* aName)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->SetIcon(			
anIcon,			
aName);
}
DECL_EXPORT void WNT_Window_Flush(void* instance)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->Flush();
}
DECL_EXPORT void WNT_Window_Map(void* instance)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->Map();
}
DECL_EXPORT void WNT_Window_MapE8219145(
	void* instance,
	int aMapMode)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->Map(			
aMapMode);
}
DECL_EXPORT void WNT_Window_Unmap(void* instance)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->Unmap();
}
DECL_EXPORT void WNT_Window_Clear(void* instance)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->Clear();
}
DECL_EXPORT void WNT_Window_ClearArea8C6D7843(
	void* instance,
	int Xc,
	int Yc,
	int Width,
	int Height)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->ClearArea(			
Xc,			
Yc,			
Width,			
Height);
}
DECL_EXPORT void WNT_Window_Restore(void* instance)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->Restore();
}
DECL_EXPORT void WNT_Window_RestoreArea8C6D7843(
	void* instance,
	int Xc,
	int Yc,
	int Width,
	int Height)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->RestoreArea(			
Xc,			
Yc,			
Width,			
Height);
}
DECL_EXPORT bool WNT_Window_Dump28A665C3(
	void* instance,
	char* aFilename,
	double aGammaValue)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return  	result->Dump(			
aFilename,			
aGammaValue);
}
DECL_EXPORT bool WNT_Window_DumpArea5B56276E(
	void* instance,
	char* aFilename,
	int Xc,
	int Yc,
	int Width,
	int Height,
	double aGammaValue)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return  	result->DumpArea(			
aFilename,			
Xc,			
Yc,			
Width,			
Height,			
aGammaValue);
}
DECL_EXPORT bool WNT_Window_Load9381D4D(
	void* instance,
	char* aFilename)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return  	result->Load(			
aFilename);
}
DECL_EXPORT bool WNT_Window_LoadAreaE8738FE0(
	void* instance,
	char* aFilename,
	int Xc,
	int Yc,
	int Width,
	int Height)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return  	result->LoadArea(			
aFilename,			
Xc,			
Yc,			
Width,			
Height);
}
DECL_EXPORT void WNT_Window_SetPos8C6D7843(
	void* instance,
	int X,
	int Y,
	int X1,
	int Y1)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->SetPos(			
X,			
Y,			
X1,			
Y1);
}
DECL_EXPORT void WNT_Window_ResetFlagsE8219145(
	void* instance,
	int aFlags)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->ResetFlags(			
aFlags);
}
DECL_EXPORT void WNT_Window_PositionC2777E0C(
	void* instance,
	double* X1,
	double* Y1,
	double* X2,
	double* Y2)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->Position(			
*X1,			
*Y1,			
*X2,			
*Y2);
}
DECL_EXPORT void WNT_Window_Position8C6D7843(
	void* instance,
	int* X1,
	int* Y1,
	int* X2,
	int* Y2)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->Position(			
*X1,			
*Y1,			
*X2,			
*Y2);
}
DECL_EXPORT void WNT_Window_Size9F0E714F(
	void* instance,
	double* Width,
	double* Height)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->Size(			
*Width,			
*Height);
}
DECL_EXPORT void WNT_Window_Size5107F6FE(
	void* instance,
	int* Width,
	int* Height)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->Size(			
*Width,			
*Height);
}
DECL_EXPORT void WNT_Window_MMSize9F0E714F(
	void* instance,
	double* Width,
	double* Height)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->MMSize(			
*Width,			
*Height);
}
DECL_EXPORT double WNT_Window_ConvertE8219145(
	void* instance,
	int PV)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return  	result->Convert(			
PV);
}
DECL_EXPORT int WNT_Window_ConvertD82819F3(
	void* instance,
	double DV)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return  	result->Convert(			
DV);
}
DECL_EXPORT void WNT_Window_ConvertB83D31A8(
	void* instance,
	int PX,
	int PY,
	double* DX,
	double* DY)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->Convert(			
PX,			
PY,			
*DX,			
*DY);
}
DECL_EXPORT void WNT_Window_Convert852507E(
	void* instance,
	double DX,
	double DY,
	int* PX,
	int* PY)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
 	result->Convert(			
DX,			
DY,			
*PX,			
*PY);
}
DECL_EXPORT void WNT_Window_SetCursor(void* instance, void* value)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
		result->SetCursor(value);
}

DECL_EXPORT void WNT_Window_SetIconName(void* instance, char* value)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
		result->SetIconName(value);
}

DECL_EXPORT int WNT_Window_DoResize(void* instance)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return (int)	result->DoResize();
}

DECL_EXPORT bool WNT_Window_DoMapping(void* instance)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return 	result->DoMapping();
}

DECL_EXPORT void WNT_Window_SetOutputFormat(void* instance, int value)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
		result->SetOutputFormat((const WNT_TypeOfImage)value);
}

DECL_EXPORT void WNT_Window_SetFlags(void* instance, int value)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
		result->SetFlags(value);
}

DECL_EXPORT bool WNT_Window_BackingStore(void* instance)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return 	result->BackingStore();
}

DECL_EXPORT void WNT_Window_SetDoubleBuffer(void* instance, bool value)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
		result->SetDoubleBuffer(value);
}

DECL_EXPORT bool WNT_Window_DoubleBuffer(void* instance)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return 	result->DoubleBuffer();
}

DECL_EXPORT bool WNT_Window_IsMapped(void* instance)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return 	result->IsMapped();
}

DECL_EXPORT double WNT_Window_Ratio(void* instance)
{
	WNT_Window* result = (WNT_Window*)(((Handle_WNT_Window*)instance)->Access());
	return 	result->Ratio();
}

DECL_EXPORT void WNTWindow_Dtor(void* instance)
{
	delete (Handle_WNT_Window*)instance;
}
