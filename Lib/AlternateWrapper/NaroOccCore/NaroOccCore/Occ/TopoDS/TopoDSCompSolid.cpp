#include "TopoDSCompSolid.h"
#include <TopoDS_CompSolid.hxx>


DECL_EXPORT void* TopoDS_CompSolid_Ctor()
{
	return new TopoDS_CompSolid();
}
DECL_EXPORT void TopoDSCompSolid_Dtor(void* instance)
{
	delete (TopoDS_CompSolid*)instance;
}
