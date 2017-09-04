#include "BRepBuilderAPITransform.h"
#include <BRepBuilderAPI_Transform.hxx>

#include <TopoDS_Shape.hxx>

DECL_EXPORT void* BRepBuilderAPI_Transform_Ctor72D78650(
	void* T)
{
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	return new BRepBuilderAPI_Transform(			
_T);
}
DECL_EXPORT void* BRepBuilderAPI_Transform_CtorE2FB96F1(
	void* S,
	void* T,
	bool Copy)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
		const gp_Trsf &  _T =*(const gp_Trsf *)T;
	return new BRepBuilderAPI_Transform(			
_S,			
_T,			
Copy);
}
DECL_EXPORT void BRepBuilderAPI_Transform_Perform5E7DD5C8(
	void* instance,
	void* S,
	bool Copy)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	BRepBuilderAPI_Transform* result = (BRepBuilderAPI_Transform*)instance;
 	result->Perform(			
_S,			
Copy);
}
DECL_EXPORT void* BRepBuilderAPI_Transform_ModifiedShape9EBAC0C0(
	void* instance,
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	BRepBuilderAPI_Transform* result = (BRepBuilderAPI_Transform*)instance;
	return new TopoDS_Shape( 	result->ModifiedShape(			
_S));
}
DECL_EXPORT void BRepBuilderAPITransform_Dtor(void* instance)
{
	delete (BRepBuilderAPI_Transform*)instance;
}
