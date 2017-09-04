#include "TopoDSEdge.h"
#include <TopoDS_Edge.hxx>


DECL_EXPORT void* TopoDS_Edge_Ctor()
{
	return new TopoDS_Edge();
}
DECL_EXPORT void TopoDSEdge_Dtor(void* instance)
{
	delete (TopoDS_Edge*)instance;
}
