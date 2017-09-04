#include "TopoDSSolid.h"
#include <TopoDS_Solid.hxx>


DECL_EXPORT void* TopoDS_Solid_Ctor()
{
	return new TopoDS_Solid();
}
DECL_EXPORT void TopoDSSolid_Dtor(void* instance)
{
	delete (TopoDS_Solid*)instance;
}
