#ifndef Aspect_AspectFillArea_H
#define Aspect_AspectFillArea_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void Aspect_AspectFillArea_SetEdgeColor(void* instance, void* value);
extern "C" DECL_EXPORT void Aspect_AspectFillArea_SetEdgeLineType(void* instance, int value);
extern "C" DECL_EXPORT void Aspect_AspectFillArea_SetEdgeWidth(void* instance, double value);
extern "C" DECL_EXPORT void Aspect_AspectFillArea_SetInteriorColor(void* instance, void* value);
extern "C" DECL_EXPORT void Aspect_AspectFillArea_SetBackInteriorColor(void* instance, void* value);
extern "C" DECL_EXPORT void Aspect_AspectFillArea_SetInteriorStyle(void* instance, int value);
extern "C" DECL_EXPORT void Aspect_AspectFillArea_SetHatchStyle(void* instance, int value);
extern "C" DECL_EXPORT int Aspect_AspectFillArea_HatchStyle(void* instance);
extern "C" DECL_EXPORT void AspectAspectFillArea_Dtor(void* instance);

#endif
