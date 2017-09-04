#ifndef MeshShape_PolygonPoint_H
#define MeshShape_PolygonPoint_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* MeshShape_PolygonPoint_Ctor();
extern "C" DECL_EXPORT void* MeshShape_PolygonPoint_Ctor2935ABDE(
	double w,
	int Loc3d);
extern "C" DECL_EXPORT double MeshShape_PolygonPoint_Parameter(void* instance);
extern "C" DECL_EXPORT int MeshShape_PolygonPoint_Location3d(void* instance);
extern "C" DECL_EXPORT void MeshShapePolygonPoint_Dtor(void* instance);

#endif
