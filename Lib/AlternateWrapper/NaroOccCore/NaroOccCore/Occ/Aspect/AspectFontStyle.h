#ifndef Aspect_FontStyle_H
#define Aspect_FontStyle_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Aspect_FontStyle_Ctor();
extern "C" DECL_EXPORT void* Aspect_FontStyle_Ctor625FF186(
	int Type,
	double Size,
	double Slant,
	bool CapsHeight);
extern "C" DECL_EXPORT void* Aspect_FontStyle_Ctor27C00EC7(
	char* Style,
	double Size,
	double Slant,
	bool CapsHeight);
extern "C" DECL_EXPORT void* Aspect_FontStyle_Ctor9381D4D(
	char* Style);
extern "C" DECL_EXPORT void* Aspect_FontStyle_Assign8E648131(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT void Aspect_FontStyle_SetValues625FF186(
	void* instance,
	int Type,
	double Size,
	double Slant,
	bool CapsHeight);
extern "C" DECL_EXPORT void Aspect_FontStyle_SetValues27C00EC7(
	void* instance,
	char* Style,
	double Size,
	double Slant,
	bool CapsHeight);
extern "C" DECL_EXPORT void Aspect_FontStyle_SetValues9381D4D(
	void* instance,
	char* Style);
extern "C" DECL_EXPORT void Aspect_FontStyle_Dump(void* instance);
extern "C" DECL_EXPORT bool Aspect_FontStyle_IsEqual8E648131(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT bool Aspect_FontStyle_IsNotEqual8E648131(
	void* instance,
	void* Other);
extern "C" DECL_EXPORT int Aspect_FontStyle_Style(void* instance);
extern "C" DECL_EXPORT int Aspect_FontStyle_Length(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_Value(void* instance);
extern "C" DECL_EXPORT double Aspect_FontStyle_Size(void* instance);
extern "C" DECL_EXPORT double Aspect_FontStyle_Slant(void* instance);
extern "C" DECL_EXPORT bool Aspect_FontStyle_CapsHeight(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_AliasName(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_FullName(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_Foundry(void* instance);
extern "C" DECL_EXPORT void Aspect_FontStyle_SetFamily(void* instance, char* value);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_Family(void* instance);
extern "C" DECL_EXPORT void Aspect_FontStyle_SetWeight(void* instance, char* value);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_Weight(void* instance);
extern "C" DECL_EXPORT void Aspect_FontStyle_SetRegistry(void* instance, char* value);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_Registry(void* instance);
extern "C" DECL_EXPORT void Aspect_FontStyle_SetEncoding(void* instance, char* value);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_Encoding(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_SSlant(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_SWidth(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_SStyle(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_SPixelSize(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_SPointSize(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_SResolutionX(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_SResolutionY(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_SSpacing(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_FontStyle_SAverageWidth(void* instance);
extern "C" DECL_EXPORT void AspectFontStyle_Dtor(void* instance);

#endif
