#include "BRepOffsetAPIMiddlePath.h"
#include <BRepOffsetAPI_MiddlePath.hxx>


DECL_EXPORT void* BRepOffsetAPI_MiddlePath_Ctor5887D0C7(
	void* aShape,
	void* StartShape,
	void* EndShape)
{
		const TopoDS_Shape &  _aShape =*(const TopoDS_Shape *)aShape;
		const TopoDS_Shape &  _StartShape =*(const TopoDS_Shape *)StartShape;
		const TopoDS_Shape &  _EndShape =*(const TopoDS_Shape *)EndShape;
	return new BRepOffsetAPI_MiddlePath(			
_aShape,			
_StartShape,			
_EndShape);
}
DECL_EXPORT void BRepOffsetAPI_MiddlePath_Build(void* instance)
{
	BRepOffsetAPI_MiddlePath* result = (BRepOffsetAPI_MiddlePath*)instance;
 	result->Build();
}
DECL_EXPORT void BRepOffsetAPIMiddlePath_Dtor(void* instance)
{
	delete (BRepOffsetAPI_MiddlePath*)instance;
}
