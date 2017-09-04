#include "TopoDSVertex.h"
#include <TopoDS_Vertex.hxx>


DECL_EXPORT void* TopoDS_Vertex_Ctor()
{
	return new TopoDS_Vertex();
}
DECL_EXPORT void TopoDSVertex_Dtor(void* instance)
{
	delete (TopoDS_Vertex*)instance;
}
