#include "MeshShapeSurfacePoint.h"
#include <MeshShape_SurfacePoint.hxx>

#include <gp_XY.hxx>
#include <gp_XYZ.hxx>

DECL_EXPORT void* MeshShape_SurfacePoint_Ctor()
{
	return new MeshShape_SurfacePoint();
}
DECL_EXPORT void* MeshShape_SurfacePoint_Ctor216AF150(
	double u,
	double v,
	double x,
	double y,
	double z)
{
	return new MeshShape_SurfacePoint(			
u,			
v,			
x,			
y,			
z);
}
DECL_EXPORT void* MeshShape_SurfacePoint_Ctor1957E281(
	void* uv,
	void* coord)
{
		const gp_XY &  _uv =*(const gp_XY *)uv;
		const gp_XYZ &  _coord =*(const gp_XYZ *)coord;
	return new MeshShape_SurfacePoint(			
_uv,			
_coord);
}
DECL_EXPORT void* MeshShape_SurfacePoint_CtorED84B375(
	double u,
	double v,
	void* coord)
{
		const gp_XYZ &  _coord =*(const gp_XYZ *)coord;
	return new MeshShape_SurfacePoint(			
u,			
v,			
_coord);
}
DECL_EXPORT void* MeshShape_SurfacePoint_UV(void* instance)
{
	MeshShape_SurfacePoint* result = (MeshShape_SurfacePoint*)instance;
	return 	new gp_XY(	result->UV());
}

DECL_EXPORT void* MeshShape_SurfacePoint_Coord(void* instance)
{
	MeshShape_SurfacePoint* result = (MeshShape_SurfacePoint*)instance;
	return 	new gp_XYZ(	result->Coord());
}

DECL_EXPORT void MeshShapeSurfacePoint_Dtor(void* instance)
{
	delete (MeshShape_SurfacePoint*)instance;
}
