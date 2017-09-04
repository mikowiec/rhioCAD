#include "TopoDSCompound.h"
#include <TopoDS_Compound.hxx>


DECL_EXPORT void* TopoDS_Compound_Ctor()
{
	return new TopoDS_Compound();
}
DECL_EXPORT void TopoDSCompound_Dtor(void* instance)
{
	delete (TopoDS_Compound*)instance;
}
