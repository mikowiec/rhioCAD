#ifndef BRepPrimAPI_MakeOneAxis_H
#define BRepPrimAPI_MakeOneAxis_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void BRepPrimAPI_MakeOneAxis_Build(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeOneAxis_Face(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeOneAxis_Shell(void* instance);
extern "C" DECL_EXPORT void* BRepPrimAPI_MakeOneAxis_Solid(void* instance);
extern "C" DECL_EXPORT void BRepPrimAPIMakeOneAxis_Dtor(void* instance);

#endif
