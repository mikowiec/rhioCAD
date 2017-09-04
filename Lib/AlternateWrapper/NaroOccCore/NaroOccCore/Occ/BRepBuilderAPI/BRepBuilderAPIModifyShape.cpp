#include "BRepBuilderAPIModifyShape.h"
#include <BRepBuilderAPI_ModifyShape.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void* BRepBuilderAPI_ModifyShape_ModifiedShape9EBAC0C0(
	void* instance,
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	BRepBuilderAPI_ModifyShape* result = (BRepBuilderAPI_ModifyShape*)instance;
	return new TopoDS_Shape( 	result->ModifiedShape(			
_S));
}
DECL_EXPORT void BRepBuilderAPIModifyShape_Dtor(void* instance)
{
	delete (BRepBuilderAPI_ModifyShape*)instance;
}
