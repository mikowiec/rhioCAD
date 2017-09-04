#include "BRepPrimAPIMakePrism.h"
#include <BRepPrimAPI_MakePrism.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void* BRepPrimAPI_MakePrism_CtorDCCCD2D4(
	void* S,
	void* V,
	bool Copy,
	bool Canonize)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		const gp_Vec &  _V =*(const gp_Vec *)V;
	return new BRepPrimAPI_MakePrism(			
_S,			
_V,			
Copy,			
Canonize);
}
DECL_EXPORT void* BRepPrimAPI_MakePrism_Ctor6CDB262A(
	void* S,
	void* D,
	bool Inf,
	bool Copy,
	bool Canonize)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		const gp_Dir &  _D =*(const gp_Dir *)D;
	return new BRepPrimAPI_MakePrism(			
_S,			
_D,			
Inf,			
Copy,			
Canonize);
}
DECL_EXPORT void BRepPrimAPI_MakePrism_Build(void* instance)
{
	BRepPrimAPI_MakePrism* result = (BRepPrimAPI_MakePrism*)instance;
 	result->Build();
}
DECL_EXPORT void* BRepPrimAPI_MakePrism_FirstShape(void* instance)
{
	BRepPrimAPI_MakePrism* result = (BRepPrimAPI_MakePrism*)instance;
	return new TopoDS_Shape( 	result->FirstShape());
}
DECL_EXPORT void* BRepPrimAPI_MakePrism_LastShape(void* instance)
{
	BRepPrimAPI_MakePrism* result = (BRepPrimAPI_MakePrism*)instance;
	return new TopoDS_Shape( 	result->LastShape());
}
DECL_EXPORT void* BRepPrimAPI_MakePrism_FirstShape9EBAC0C0(
	void* instance,
	void* theShape)
{
		const TopoDS_Shape &  _theShape =*(const TopoDS_Shape *)theShape;
	BRepPrimAPI_MakePrism* result = (BRepPrimAPI_MakePrism*)instance;
	return new TopoDS_Shape( 	result->FirstShape(			
_theShape));
}
DECL_EXPORT void* BRepPrimAPI_MakePrism_LastShape9EBAC0C0(
	void* instance,
	void* theShape)
{
		const TopoDS_Shape &  _theShape =*(const TopoDS_Shape *)theShape;
	BRepPrimAPI_MakePrism* result = (BRepPrimAPI_MakePrism*)instance;
	return new TopoDS_Shape( 	result->LastShape(			
_theShape));
}
DECL_EXPORT void BRepPrimAPIMakePrism_Dtor(void* instance)
{
	delete (BRepPrimAPI_MakePrism*)instance;
}
