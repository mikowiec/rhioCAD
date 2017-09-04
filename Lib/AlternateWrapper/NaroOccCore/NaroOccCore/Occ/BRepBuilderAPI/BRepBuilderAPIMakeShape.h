#ifndef BRepBuilderAPI_MakeShape_H
#define BRepBuilderAPI_MakeShape_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void BRepBuilderAPI_MakeShape_Delete(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPI_MakeShape_Build(void* instance);
extern "C" DECL_EXPORT bool BRepBuilderAPI_MakeShape_IsDeleted9EBAC0C0(
	void* instance,
	void* S);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeShape_Shape(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPIMakeShape_Dtor(void* instance);

#endif
