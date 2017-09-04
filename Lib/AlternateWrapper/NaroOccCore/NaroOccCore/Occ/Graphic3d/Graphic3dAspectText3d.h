#ifndef Graphic3d_AspectText3d_H
#define Graphic3d_AspectText3d_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Graphic3d_AspectText3d_Ctor();
extern "C" DECL_EXPORT void* Graphic3d_AspectText3d_Ctor61B9B574(
	void* AColor,
	char* AFont,
	double AExpansionFactor,
	double ASpace,
	int AStyle,
	int ADisplayType);
extern "C" DECL_EXPORT void Graphic3d_AspectText3d_SetColor(void* instance, void* value);
extern "C" DECL_EXPORT void Graphic3d_AspectText3d_SetExpansionFactor(void* instance, double value);
extern "C" DECL_EXPORT void Graphic3d_AspectText3d_SetFont(void* instance, char* value);
extern "C" DECL_EXPORT void Graphic3d_AspectText3d_SetSpace(void* instance, double value);
extern "C" DECL_EXPORT void Graphic3d_AspectText3d_SetStyle(void* instance, int value);
extern "C" DECL_EXPORT void Graphic3d_AspectText3d_SetDisplayType(void* instance, int value);
extern "C" DECL_EXPORT void Graphic3d_AspectText3d_SetColorSubTitle(void* instance, void* value);
extern "C" DECL_EXPORT void Graphic3d_AspectText3d_SetTextZoomable(void* instance, bool value);
extern "C" DECL_EXPORT bool Graphic3d_AspectText3d_GetTextZoomable(void* instance);
extern "C" DECL_EXPORT void Graphic3d_AspectText3d_SetTextAngle(void* instance, double value);
extern "C" DECL_EXPORT double Graphic3d_AspectText3d_GetTextAngle(void* instance);
extern "C" DECL_EXPORT void Graphic3d_AspectText3d_SetTextFontAspect(void* instance, int value);
extern "C" DECL_EXPORT int Graphic3d_AspectText3d_GetTextFontAspect(void* instance);
extern "C" DECL_EXPORT void Graphic3dAspectText3d_Dtor(void* instance);

#endif
