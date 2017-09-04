#include "MeshShapePolygonPoint.h"
#include <MeshShape_PolygonPoint.hxx>


DECL_EXPORT void* MeshShape_PolygonPoint_Ctor()
{
	return new MeshShape_PolygonPoint();
}
DECL_EXPORT void* MeshShape_PolygonPoint_Ctor2935ABDE(
	double w,
	int Loc3d)
{
	return new MeshShape_PolygonPoint(			
w,			
Loc3d);
}
DECL_EXPORT double MeshShape_PolygonPoint_Parameter(void* instance)
{
	MeshShape_PolygonPoint* result = (MeshShape_PolygonPoint*)instance;
	return 	result->Parameter();
}

DECL_EXPORT int MeshShape_PolygonPoint_Location3d(void* instance)
{
	MeshShape_PolygonPoint* result = (MeshShape_PolygonPoint*)instance;
	return 	result->Location3d();
}

DECL_EXPORT void MeshShapePolygonPoint_Dtor(void* instance)
{
	delete (MeshShape_PolygonPoint*)instance;
}
