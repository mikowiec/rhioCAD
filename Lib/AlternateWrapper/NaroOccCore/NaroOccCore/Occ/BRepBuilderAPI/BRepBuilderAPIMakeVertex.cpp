#include "BRepBuilderAPIMakeVertex.h"
#include <BRepBuilderAPI_MakeVertex.hxx>

#include <TopoDS_Vertex.hxx>

DECL_EXPORT void* BRepBuilderAPI_MakeVertex_Ctor9EAECD5B(
	void* P)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	return new BRepBuilderAPI_MakeVertex(			
_P);
}
DECL_EXPORT void* BRepBuilderAPI_MakeVertex_Vertex(void* instance)
{
	BRepBuilderAPI_MakeVertex* result = (BRepBuilderAPI_MakeVertex*)instance;
	return 	new TopoDS_Vertex(	result->Vertex());
}

DECL_EXPORT void BRepBuilderAPIMakeVertex_Dtor(void* instance)
{
	delete (BRepBuilderAPI_MakeVertex*)instance;
}
