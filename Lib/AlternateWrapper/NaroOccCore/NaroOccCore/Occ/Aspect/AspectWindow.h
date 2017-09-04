#ifndef Aspect_Window_H
#define Aspect_Window_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Aspect_Window_Background(void* instance);
extern "C" DECL_EXPORT Standard_CString Aspect_Window_BackgroundImage(void* instance);
extern "C" DECL_EXPORT int Aspect_Window_BackgroundFillMethod(void* instance);
extern "C" DECL_EXPORT void* Aspect_Window_HBackground(void* instance);
extern "C" DECL_EXPORT void* Aspect_Window_GraphicDevice(void* instance);
extern "C" DECL_EXPORT bool Aspect_Window_IsVirtual(void* instance);
extern "C" DECL_EXPORT void Aspect_Window_SetVirtual(void* instance, bool value);
extern "C" DECL_EXPORT void AspectWindow_Dtor(void* instance);

#endif
