#include "TopoDSFace.h"
#include <TopoDS_Face.hxx>


DECL_EXPORT void* TopoDS_Face_Ctor()
{
	return new TopoDS_Face();
}
DECL_EXPORT void TopoDSFace_Dtor(void* instance)
{
	delete (TopoDS_Face*)instance;
}
