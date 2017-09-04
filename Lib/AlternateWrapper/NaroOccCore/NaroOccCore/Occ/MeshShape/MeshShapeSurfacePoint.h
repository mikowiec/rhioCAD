#ifndef MeshShape_SurfacePoint_H
#define MeshShape_SurfacePoint_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* MeshShape_SurfacePoint_Ctor();
extern "C" DECL_EXPORT void* MeshShape_SurfacePoint_Ctor216AF150(
	double u,
	double v,
	double x,
	double y,
	double z);
extern "C" DECL_EXPORT void* MeshShape_SurfacePoint_Ctor1957E281(
	void* uv,
	void* coord);
extern "C" DECL_EXPORT void* MeshShape_SurfacePoint_CtorED84B375(
	double u,
	double v,
	void* coord);
extern "C" DECL_EXPORT void* MeshShape_SurfacePoint_UV(void* instance);
extern "C" DECL_EXPORT void* MeshShape_SurfacePoint_Coord(void* instance);
extern "C" DECL_EXPORT void MeshShapeSurfacePoint_Dtor(void* instance);

#endif
