#include "TopoDSWire.h"
#include <TopoDS_Wire.hxx>


DECL_EXPORT void* TopoDS_Wire_Ctor()
{
	return new TopoDS_Wire();
}
DECL_EXPORT void TopoDSWire_Dtor(void* instance)
{
	delete (TopoDS_Wire*)instance;
}
