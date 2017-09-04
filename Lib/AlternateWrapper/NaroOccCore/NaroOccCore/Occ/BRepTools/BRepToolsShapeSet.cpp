#include "BRepToolsShapeSet.h"
#include <BRepTools_ShapeSet.hxx>


DECL_EXPORT void* BRepTools_ShapeSet_Ctor461FC46A(
	bool isWithTriangles)
{
	return new BRepTools_ShapeSet(			
isWithTriangles);
}
DECL_EXPORT void* BRepTools_ShapeSet_CtorC2019AEC(
	void* B,
	bool isWithTriangles)
{
		const BRep_Builder &  _B =*(const BRep_Builder *)B;
	return new BRepTools_ShapeSet(			
_B,			
isWithTriangles);
}
DECL_EXPORT void BRepTools_ShapeSet_Clear(void* instance)
{
	BRepTools_ShapeSet* result = (BRepTools_ShapeSet*)instance;
 	result->Clear();
}
DECL_EXPORT void BRepTools_ShapeSet_AddGeometry9EBAC0C0(
	void* instance,
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	BRepTools_ShapeSet* result = (BRepTools_ShapeSet*)instance;
 	result->AddGeometry(			
_S);
}
DECL_EXPORT void BRepTools_ShapeSet_AddShapes877A736F(
	void* instance,
	void* S1,
	void* S2)
{
		 TopoDS_Shape &  _S1 =*( TopoDS_Shape *)S1;
		const TopoDS_Shape &  _S2 =*(const TopoDS_Shape *)S2;
	BRepTools_ShapeSet* result = (BRepTools_ShapeSet*)instance;
 	result->AddShapes(			
_S1,			
_S2);
}
DECL_EXPORT void BRepTools_ShapeSet_Check6E774DE2(
	void* instance,
	int T,
	void* S)
{
		const TopAbs_ShapeEnum _T =(const TopAbs_ShapeEnum )T;
		 TopoDS_Shape &  _S =*( TopoDS_Shape *)S;
	BRepTools_ShapeSet* result = (BRepTools_ShapeSet*)instance;
 	result->Check(			
_T,			
_S);
}
DECL_EXPORT void BRepToolsShapeSet_Dtor(void* instance)
{
	delete (BRepTools_ShapeSet*)instance;
}
