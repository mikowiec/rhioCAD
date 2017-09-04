#ifndef Graphic3d_WNTGraphicDevice_H
#define Graphic3d_WNTGraphicDevice_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Graphic3d_WNTGraphicDevice_Ctor();
extern "C" DECL_EXPORT void* Graphic3d_WNTGraphicDevice_Ctor9381D4D(
	char* graphicLib);
extern "C" DECL_EXPORT void* Graphic3d_WNTGraphicDevice_GraphicDriver(void* instance);
extern "C" DECL_EXPORT void Graphic3dWNTGraphicDevice_Dtor(void* instance);

#endif
