#include "BRepBuilderAPIMakeShape.h"
#include <BRepBuilderAPI_MakeShape.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void BRepBuilderAPI_MakeShape_Delete(void* instance)
{
	BRepBuilderAPI_MakeShape* result = (BRepBuilderAPI_MakeShape*)instance;
 	result->Delete();
}
DECL_EXPORT void BRepBuilderAPI_MakeShape_Build(void* instance)
{
	BRepBuilderAPI_MakeShape* result = (BRepBuilderAPI_MakeShape*)instance;
 	result->Build();
}
DECL_EXPORT bool BRepBuilderAPI_MakeShape_IsDeleted9EBAC0C0(
	void* instance,
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	BRepBuilderAPI_MakeShape* result = (BRepBuilderAPI_MakeShape*)instance;
	return  	result->IsDeleted(			
_S);
}
DECL_EXPORT void* BRepBuilderAPI_MakeShape_Shape(void* instance)
{
	BRepBuilderAPI_MakeShape* result = (BRepBuilderAPI_MakeShape*)instance;
	return 	new TopoDS_Shape(	result->Shape());
}

DECL_EXPORT void BRepBuilderAPIMakeShape_Dtor(void* instance)
{
	delete (BRepBuilderAPI_MakeShape*)instance;
}
