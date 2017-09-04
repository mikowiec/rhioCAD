#ifndef WNT_Window_H
#define WNT_Window_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* WNT_Window_CtorB0EE1CA(
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
	void* aClientStruct);
extern "C" DECL_EXPORT void* WNT_Window_Ctor83D53D04(
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
	void* theClientStruct);
extern "C" DECL_EXPORT void* WNT_Window_Ctor9F345CFF(
	void* aDevice,
	void* aHandle,
	int aBackColor);
extern "C" DECL_EXPORT void* WNT_Window_CtorBCEC06DC(
	void* aDevice,
	int aPart1,
	int aPart2,
	int aBackColor);
extern "C" DECL_EXPORT void WNT_Window_SetBackground60C2D936(
	void* instance,
	void* Background);
extern "C" DECL_EXPORT void WNT_Window_SetBackground48F4F471(
	void* instance,
	int BackColor);
extern "C" DECL_EXPORT void WNT_Window_SetBackground8FD7F48(
	void* instance,
	void* color);
extern "C" DECL_EXPORT void WNT_Window_SetBackgroundF9F0DFF(
	void* instance,
	void* aBackPixmap);
extern "C" DECL_EXPORT bool WNT_Window_SetBackground7B49F0A3(
	void* instance,
	char* aName,
	int aMethod);
extern "C" DECL_EXPORT void WNT_Window_SetBackgroundEE919A89(
	void* instance,
	void* aCol1,
	void* aCol2,
	int aMethod);
extern "C" DECL_EXPORT void WNT_Window_SetIconB5B2B94C(
	void* instance,
	void* anIcon,
	char* aName);
extern "C" DECL_EXPORT void WNT_Window_Flush(void* instance);
extern "C" DECL_EXPORT void WNT_Window_Map(void* instance);
extern "C" DECL_EXPORT void WNT_Window_MapE8219145(
	void* instance,
	int aMapMode);
extern "C" DECL_EXPORT void WNT_Window_Unmap(void* instance);
extern "C" DECL_EXPORT void WNT_Window_Clear(void* instance);
extern "C" DECL_EXPORT void WNT_Window_ClearArea8C6D7843(
	void* instance,
	int Xc,
	int Yc,
	int Width,
	int Height);
extern "C" DECL_EXPORT void WNT_Window_Restore(void* instance);
extern "C" DECL_EXPORT void WNT_Window_RestoreArea8C6D7843(
	void* instance,
	int Xc,
	int Yc,
	int Width,
	int Height);
extern "C" DECL_EXPORT bool WNT_Window_Dump28A665C3(
	void* instance,
	char* aFilename,
	double aGammaValue);
extern "C" DECL_EXPORT bool WNT_Window_DumpArea5B56276E(
	void* instance,
	char* aFilename,
	int Xc,
	int Yc,
	int Width,
	int Height,
	double aGammaValue);
extern "C" DECL_EXPORT bool WNT_Window_Load9381D4D(
	void* instance,
	char* aFilename);
extern "C" DECL_EXPORT bool WNT_Window_LoadAreaE8738FE0(
	void* instance,
	char* aFilename,
	int Xc,
	int Yc,
	int Width,
	int Height);
extern "C" DECL_EXPORT void WNT_Window_SetPos8C6D7843(
	void* instance,
	int X,
	int Y,
	int X1,
	int Y1);
extern "C" DECL_EXPORT void WNT_Window_ResetFlagsE8219145(
	void* instance,
	int aFlags);
extern "C" DECL_EXPORT void WNT_Window_PositionC2777E0C(
	void* instance,
	double* X1,
	double* Y1,
	double* X2,
	double* Y2);
extern "C" DECL_EXPORT void WNT_Window_Position8C6D7843(
	void* instance,
	int* X1,
	int* Y1,
	int* X2,
	int* Y2);
extern "C" DECL_EXPORT void WNT_Window_Size9F0E714F(
	void* instance,
	double* Width,
	double* Height);
extern "C" DECL_EXPORT void WNT_Window_Size5107F6FE(
	void* instance,
	int* Width,
	int* Height);
extern "C" DECL_EXPORT void WNT_Window_MMSize9F0E714F(
	void* instance,
	double* Width,
	double* Height);
extern "C" DECL_EXPORT double WNT_Window_ConvertE8219145(
	void* instance,
	int PV);
extern "C" DECL_EXPORT int WNT_Window_ConvertD82819F3(
	void* instance,
	double DV);
extern "C" DECL_EXPORT void WNT_Window_ConvertB83D31A8(
	void* instance,
	int PX,
	int PY,
	double* DX,
	double* DY);
extern "C" DECL_EXPORT void WNT_Window_Convert852507E(
	void* instance,
	double DX,
	double DY,
	int* PX,
	int* PY);
extern "C" DECL_EXPORT void WNT_Window_SetCursor(void* instance, void* value);
extern "C" DECL_EXPORT void WNT_Window_SetIconName(void* instance, char* value);
extern "C" DECL_EXPORT int WNT_Window_DoResize(void* instance);
extern "C" DECL_EXPORT bool WNT_Window_DoMapping(void* instance);
extern "C" DECL_EXPORT void WNT_Window_SetOutputFormat(void* instance, int value);
extern "C" DECL_EXPORT void WNT_Window_SetFlags(void* instance, int value);
extern "C" DECL_EXPORT bool WNT_Window_BackingStore(void* instance);
extern "C" DECL_EXPORT void WNT_Window_SetDoubleBuffer(void* instance, bool value);
extern "C" DECL_EXPORT bool WNT_Window_DoubleBuffer(void* instance);
extern "C" DECL_EXPORT bool WNT_Window_IsMapped(void* instance);
extern "C" DECL_EXPORT double WNT_Window_Ratio(void* instance);
extern "C" DECL_EXPORT void WNTWindow_Dtor(void* instance);

#endif
